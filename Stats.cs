using System;
using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.GameFoundation;
using Random = UnityEngine.Random;

namespace _Project.Scripts
{
    public class Stats : MonoBehaviour, ISavable
    {
        private List<Stat> stats;
        private int availablePoints;

        public int AvailablePoints
        {
            get { return availablePoints; }
            set
            {
                availablePoints = value;
                OnChangePoints?.Invoke();
            }
        }
        public event Action OnChangePoints;
        private Skills skills;
        private Equipment equipment;

        private void Awake()
        {
            skills = GetComponent<Skills>();
            equipment = GetComponent<Equipment>();
        }

        private void OnEnable()
        {
            equipment.OnEquip += AddEquipmentModifiers;
            equipment.OnUnEquip += RemoveEquipmentModifiers;
            skills[SkillType.Combat].OnLevelUp += LevelUp;
        }

        private void OnDisable()
        {
            equipment.OnEquip -= AddEquipmentModifiers;
            equipment.OnUnEquip -= RemoveEquipmentModifiers;
            skills[SkillType.Combat].OnLevelUp -= LevelUp;
        }

        private void LevelUp(Skill skill)
        {
            AvailablePoints += 5;
        }

        public void Initialize(bool randomize)
        {
            availablePoints = 15;
            
            stats = new List<Stat>
            {
                new Stat(StatType.STRENGTH, 1),
                new Stat(StatType.CONSTITUTION, 1),
                new Stat(StatType.WISDOM, 1),
                new Stat(StatType.INTELLIGENCE, 1),
                new Stat(StatType.CHARISMA, 1),
                new Stat(StatType.DEXTERITY, 1)
            };

            if (randomize)
            {
                while (AvailablePoints > 0)
                {
                    int index = Random.Range(0, stats.Count);
                    int points = Random.Range(1, AvailablePoints);
                    SpendPoints(stats[index].name, points);
                }
            }
            
            stats.AddRange(new List<Stat>
            {
                new Stat(StatType.PHYSICAL_ATTACK, 0),
                new Stat(StatType.MAGIC_ATTACK, 0),
                new Stat(StatType.PHYSICAL_DEFENSE, 0),
                new Stat(StatType.MAGIC_DEFENSE, 0),
                new DynamicStat(StatType.HEALTH, 100),
                new DynamicStat(StatType.MANA, 100)
            });
        }
        
        public void SpendPoints(string name, int points)
        {
            if (points > 0 && points <= availablePoints)
            {
                Stat stat = this[name];
                if (stat != null)
                {
                    stat.BaseValue += points;
                    AvailablePoints -= points;
                }
            }
        }
        
        private void AddEquipmentModifiers(InventoryItem item)
        {
            foreach (var mutableProperty in item.GetMutableProperties())
            {
                Stat stat = stats.Find(s => s.name == mutableProperty.Key);
                stat.AddModifier(new StatModifier(item.id, mutableProperty.Value.AsInt(), ModifierType.Flat));
            }
        }
        private void RemoveEquipmentModifiers(InventoryItem item)
        {
            foreach (var mutableProperty in item.GetMutableProperties())
            {
                Stat stat = stats.Find(s => s.name == mutableProperty.Key);
                stat.RemoveModifier(item.id);
            }
        }
        public Stat this[string name]
        {
            get => stats.Find(stat => stat.name == name);
            set
            {
                int index = stats.FindIndex(stat => stat.name == name);
                if (index == -1)
                    stats[index] = value;
                else
                    stats.Add(value);
            }
        }
        
        public object SaveData()
        {
            return new StatsData
            {
                availablePoints = availablePoints,
                stats = stats.Where(stat => !(stat is DynamicStat)).Select(stat => new StatData
                {
                    baseValue = stat.BaseValue,
                    name = stat.name,
                    modifiers = stat.Modifiers.ToList(),
                    value = stat.Value
                }).ToList(),
                dynamicStats = stats.Where(stat => stat is DynamicStat).Select(stat => new DynamicStatData
                {
                    baseValue = stat.BaseValue,
                    name = stat.name,
                    modifiers = stat.Modifiers.ToList(),
                    value = stat.Value,
                    currentValue = (stat as DynamicStat).CurrentValue
                }).ToList()
            };
        }
        
        public void LoadData(object data)
        {
            StatsData statsData = (StatsData) data;

            availablePoints = statsData.availablePoints;
            
            stats = new List<Stat>();
            
            stats.AddRange(statsData.stats.Select(stat => new Stat(
                stat.name,
                stat.baseValue,
                stat.modifiers,
                stat.value
            )).ToList());
            
            stats.AddRange(statsData.dynamicStats.Select(dynamicStat => new DynamicStat(
                dynamicStat.name,
                dynamicStat.baseValue,
                dynamicStat.modifiers,
                dynamicStat.value,
                dynamicStat.currentValue
            )).ToList());
        }
    }
}