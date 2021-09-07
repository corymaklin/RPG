using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Enemies;
using _Project.Scripts.Managers;
using UnityEngine;

namespace _Project.Scripts
{
    public class Skills : MonoBehaviour, ISavable
    {
        [SerializeField] private ParticleSystem levelUpVfx;
        [SerializeField] private AudioSource levelUpSfx;
        private List<Skill> skills;
        public void Initialize()
        {
            skills = new List<Skill>
            {
                new Skill(0, 1, 10, SkillType.Combat)
            };
        }

        private void OnEnable()
        {
            foreach (var skill in skills)
            {
                skill.OnLevelUp += LevelUp;
            }
        
            EventManager.Instance.OnEnemyDied += GainExperience;
        }

        private void OnDisable()
        {
            foreach (var skill in skills)
            {
                skill.OnLevelUp -= LevelUp;
            }
        
            EventManager.Instance.OnEnemyDied -= GainExperience;
        }

        public Skill this[SkillType type]
        {
            get => skills.Find(skill => skill.Type == type);
            set
            {
                int index = skills.FindIndex(skill => skill.Type == type);
                if (index == -1)
                    skills[index] = value;
                else
                    skills.Add(value);
            }
        }

        private void LevelUp(Skill skill)
        {
            if (levelUpSfx)
                levelUpSfx.Play();
            if (levelUpVfx)
                levelUpVfx.Play();
        }

        private void GainExperience(Enemy enemy)
        {
            this[SkillType.Combat].CurrentExperience += enemy.definition.experienceReward;
        }
        
        public object SaveData()
        {
            return new SkillsData
            {
                skills = skills.Select(skill => new SkillData
                {
                    requiredExperience = skill.RequiredExperience,
                    currentExperience = skill.CurrentExperience,
                    level = skill.Level,
                    type = skill.Type,
                }).ToList()
            };
        }
        
        public void LoadData(object data)
        {
            SkillsData skillsData = (SkillsData) data;
            skills = skillsData.skills.Select(skill => new Skill(
                skill.currentExperience,
                skill.level,
                skill.requiredExperience,
                skill.type
            )).ToList();
        }
    }
}