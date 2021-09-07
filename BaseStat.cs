using System;
using UnityEngine;

namespace _Project.Scripts
{
    [Serializable]
    public class BaseStat
    {
        public string name;
        [SerializeField] protected int baseValue;
        public virtual int BaseValue
        {
            get { return baseValue; }
            set
            {
                baseValue = value;
            }
        }
        public BaseStat(string name, int baseValue)
        {
            this.name = name;
            this.baseValue = baseValue;
        }
    }
}