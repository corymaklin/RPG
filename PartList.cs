using System;
using System.Collections;
using UnityEngine;

namespace _Project.Scripts
{
    [Serializable]
    public class PartList: IEnumerable
    {
        public PartType type;
        public GameObject[] parts;
        public PartList(PartType type, GameObject[] parts)
        {
            this.type = type;
            this.parts = parts;
        }
        
        public GameObject this[int id]
        {
            get => parts[id];
            set => parts[id] = value;
        }

        public IEnumerator GetEnumerator()
        {
            return parts.GetEnumerator();
        }
    }
}