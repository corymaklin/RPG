using System;

namespace _Project.Scripts
{
    [Serializable]
    public struct SkillData
    {
        public int requiredExperience;
        public int currentExperience;
        public int level;
        public SkillType type;
    }
}