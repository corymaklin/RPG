using System;
using UnityEngine;

namespace _Project.Scripts
{
    [Serializable]
    public enum SkillType
    {
        Combat
    }

    [Serializable]
    public class Skill
    {
        [SerializeField] private int requiredExperience;
        [SerializeField] private int currentExperience;
        [SerializeField] private int level;
        [SerializeField] private SkillType type;
        public event Action<Skill> OnLevelUp;

        public SkillType Type
        {
            get { return type; }
        }
        
        public int Level
        {
            get { return level; }
        }
        
        public int RequiredExperience
        {
            get { return requiredExperience; }
        }
        
        public int CurrentExperience
        {
            get
            {
                return currentExperience;
            }
            set
            {
                if (currentExperience + value >= requiredExperience)
                {
                    currentExperience = currentExperience + value - requiredExperience;
                    requiredExperience *= 2;
                    level += 1;
                    OnLevelUp?.Invoke(this);
                }
                else
                {
                    currentExperience = Mathf.Clamp(value, 0, requiredExperience);
                }
            }
        }

        public Skill(int currentExperience, int level, int requiredExperience, SkillType type)
        {
            this.currentExperience = currentExperience;
            this.level = level;
            this.requiredExperience = requiredExperience;
            this.type = type;
        }
    }
}