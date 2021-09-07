using _Project.Scripts.Enemies.Animations.Character;
using UnityEngine;
using UnityEngine.Animations;

namespace _Project.Scripts.Enemies.Animations
{
    public class FollowingSMB : SceneLinkedSMB<Enemy>
    {
        public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        {
            base.OnSLStateNoTransitionUpdate(animator, stateInfo, layerIndex);
            
            m_MonoBehaviour.Agent.SetDestination(m_MonoBehaviour.Target.position);
        }
    }
}