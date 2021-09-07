using System;
using UnityEngine;

namespace _Project.Scripts
{
    [Serializable]
    public static class ArmorType
    {
        public const string HEAD = "head";
        public const string SHOULDERS = "shoulders";
        public const string CLOAK = "cloak";
        public const string TORSO = "torso";
        public const string GLOVES = "gloves";
        public const string LEGS = "legs";
        public const string FEET = "feet";
        public const string RINGS = "rings";
    }

    [Serializable]
    public class ArmorPart
    {
        public PartType type;
        public int id;
    }
    
    [CreateAssetMenu(fileName = "Armor", menuName = "Inventory/Armor", order = 0)]
    public class Armor : ScriptableObject
    {
        public String type;
        public ArmorPart[] parts;
    }
}