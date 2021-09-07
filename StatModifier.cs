using System;

namespace _Project.Scripts
{
    [Serializable]
    public enum ModifierType
    {
        Flat,
        Percent
    }
    
    [Serializable]
    public class StatModifier
    {
        public string id;
        public int value;
        public ModifierType type;

        public StatModifier(string id, int value, ModifierType type)
        {
            this.id = id;
            this.value = value;
            this.type = type;
        }
    }
}