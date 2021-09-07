using _Project.Scripts.Enemies.Animations.Character;
using UnityEngine;
using UnityEngine.Animations;

namespace _Project.Scripts.Enemies.Animations
{
    public class AttackingSMB : SceneLinkedSMB<Enemy>
    {
        private static readonly int Attack = Animator.StringToHash("attack");

        public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
        {
            m_MonoBehaviour.transform.LookAt(m_MonoBehaviour.Target);

            if (Time.time >= m_MonoBehaviour.timeUntilNextAttack)
            {
                animator.SetTrigger(Attack);
            }
        }
    }
}