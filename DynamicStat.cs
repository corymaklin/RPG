using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts
{
    [Serializable]
    public class DynamicStat : Stat
    {
        public event Action<DynamicStat> OnChangedCurrentValue;
        
        [SerializeField] private int currentValue;
        public int CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = Mathf.Clamp(value, 0, Value);
                OnChangedCurrentValue?.Invoke(this);
            }
        }

        public DynamicStat(string name, int baseValue) : base(name, baseValue)
        {
            CurrentValue = baseValue;
        }
        
        public DynamicStat(string name, int baseValue, List<StatModifier> modifiers, int value, int currentValue) : base(name, baseValue, modifiers, value)
        {
            CurrentValue = currentValue;
        }
    }
}