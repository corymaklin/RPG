using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;

namespace _Project.Scripts
{
    [Serializable]
    public class Stat : BaseStat
    {
        public event Action<Stat> OnChangedValue;
        public override int BaseValue
        {
            get { return baseValue; }
            set
            {
                baseValue = value;
                CalculateValue();
            }
        }
        public int Value { get; private set; }
        [SerializeField] private List<StatModifier> modifiers;
        public ReadOnlyCollection<StatModifier> Modifiers => modifiers.AsReadOnly();
        public Stat(string name, int baseValue) : base(name, baseValue)
        {
            modifiers = new List<StatModifier>();
            Value = baseValue;
        }

        public Stat(string name, int baseValue, List<StatModifier> modifiers, int value) : base(name, baseValue)
        {
            this.modifiers = modifiers;
            Value = value;
        }
        
        public void AddModifier(StatModifier modifier)
        {
            modifiers.Add(modifier);
            CalculateValue();
        }

        public void RemoveModifier(string id)
        {
            modifiers = modifiers.Where(modifier => modifier.id != id).ToList();
            CalculateValue();
        }

        public void RemoveAllModifiers()
        {
            modifiers.Clear();
            CalculateValue();
        }

        private void CalculateValue()
        {
            Value = baseValue;

            foreach (var modifier in modifiers.Where(modifier => modifier.type == ModifierType.Flat).ToList())
            {
                Value += modifier.value;
            }
            
            foreach (var modifier in modifiers.Where(modifier => modifier.type == ModifierType.Percent).ToList())
            {
                Value *= modifier.value;
            }
            
            OnChangedValue?.Invoke(this);
        }
    }
}