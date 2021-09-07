using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _Project.Scripts.Enemies
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/New Enemy", order = 0)]
    public class EnemyDefinition : ScriptableObject
    {
        public BaseStat[] baseStats;
        public BaseStat health;
        public BaseStat mana;
        public string enemyName;
        public int experienceReward;
        void Reset()
        {
            baseStats = new []
            {
                new BaseStat(StatType.PHYSICAL_ATTACK, 0),
                new BaseStat(StatType.MAGIC_ATTACK, 0),
                new BaseStat(StatType.PHYSICAL_DEFENSE, 0),
                new BaseStat(StatType.MAGIC_DEFENSE, 0)
            };

            health = new BaseStat(StatType.HEALTH, 100);
            mana = new BaseStat(StatType.MANA, 100);
        }
    }
}