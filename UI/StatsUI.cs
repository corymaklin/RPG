using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class StatsUI : BaseUI
    {
        public Stats stats;
        [SerializeField] private Skills skills;
        [SerializeField] private Transform statParent;
        [SerializeField] private Transform dynamicStatParent;
        [SerializeField] private Button closeButton;
        [SerializeField] private Text availablePoints;
        [SerializeField] private Text combatLevel;
        private List<BaseStatUI> statUis;
        private List<DynamicStatUI> dynamicStatUis;

        private void Awake()
        {
            base.Awake();
            statUis = statParent.GetComponentsInChildren<BaseStatUI>(true).ToList();
            dynamicStatUis = dynamicStatParent.GetComponentsInChildren<DynamicStatUI>(true).ToList();
            closeButton.onClick.AddListener(delegate { UIManager.Instance.Hide(); });
        }

        private void Start()
        {
            combatLevel.text = $"Lvl. {skills[SkillType.Combat].Level}";
            availablePoints.text = stats.AvailablePoints.ToString();
            Initialize();
        }

        private void OnEnable()
        {
            stats.OnChangePoints += ChangePoints;
            skills[SkillType.Combat].OnLevelUp += LevelUp;
        }

        private void OnDisable()
        {
            stats.OnChangePoints -= ChangePoints;
            skills[SkillType.Combat].OnLevelUp -= LevelUp;
        }

        private void LevelUp(Skill skill)
        {
            combatLevel.text = $"Lvl. {skill.Level}";
        }

        private void ChangePoints()
        {
            availablePoints.text = stats.AvailablePoints.ToString();
        }

        private void Initialize()
        {
            foreach (var statUI in statUis)
            {
                Stat stat = stats[statUI.statName];
                statUI.Refresh(stat);
                stat.OnChangedValue += statUI.Refresh;
                statUI.container = this;
            }
            
            foreach (var dynamicStatUI in dynamicStatUis)
            {
                DynamicStat dynamicStat = stats[dynamicStatUI.statName] as DynamicStat;
                dynamicStatUI.Refresh(dynamicStat);
                dynamicStat.OnChangedCurrentValue += dynamicStatUI.Refresh;
            }
        }
    }
}