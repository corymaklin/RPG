using _Project.Scripts.Enemies.Animations.Character;
using UnityEngine;

namespace _Project.Scripts.Enemies.Animations
{
    public class AttackSMB : SceneLinkedSMB<Enemy>
    {
        public override void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
            base.OnSLStateExit(animator, stateInfo, layerIndex);
            m_MonoBehaviour.timeUntilNextAttack = Time.time + 1f / m_MonoBehaviour.attackSpeed;
        }
    }
}