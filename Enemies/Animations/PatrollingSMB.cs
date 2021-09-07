using System.Collections;
using _Project.Scripts.Enemies.Animations.Character;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

namespace _Project.Scripts.Enemies.Animations
{
    public class PatrollingSMB : SceneLinkedSMB<Enemy>
    {
        private float agentSpeed;
        public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        {
            base.OnSLStateNoTransitionUpdate(animator, stateInfo, layerIndex);
            
            Vector3 distance = m_MonoBehaviour.transform.position - m_MonoBehaviour.Agent.destination;

            if (distance.magnitude < 0.1f)
            {
                SampleNavMesh();
                m_MonoBehaviour.StartCoroutine(Wait(1.5f));
            }
        }

        public override void OnSLStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateEnter(animator, stateInfo, layerIndex);
            agentSpeed = m_MonoBehaviour.Agent.speed;
            m_MonoBehaviour.Agent.speed = m_MonoBehaviour.patrollingSpeed;
        }
        
        public override void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateEnter(animator, stateInfo, layerIndex);
            m_MonoBehaviour.Agent.speed = agentSpeed;
        }

        private IEnumerator Wait(float duration)
        {
            m_MonoBehaviour.Agent.isStopped = true;
            yield return new WaitForSeconds(duration);
            m_MonoBehaviour.Agent.isStopped = false;
        }
        
        private void SampleNavMesh()
        {
            Vector3 randomPoint = m_MonoBehaviour.OriginalPosition + Random.insideUnitSphere * m_MonoBehaviour.patrolDistance;

            if (NavMesh.SamplePosition(randomPoint, out NavMeshHit hit, 1.0f, NavMesh.AllAreas))
            {
                m_MonoBehaviour.Agent.SetDestination(hit.position);
            }
            else
            {
                SampleNavMesh();
            }
        }
    }
}