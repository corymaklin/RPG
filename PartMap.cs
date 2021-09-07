using System;
using System.Collections;
using System.Collections.Generic;

namespace _Project.Scripts
{
    [Serializable]
    public class PartMap : IEnumerable
    {
        public List<PartList> partLists;

        public PartList this[PartType type]
        {
            get => partLists.Find(partList => partList.type == type);
            set
            {
                int index = partLists.FindIndex(partList => partList.type == type);
                if (index == -1)
                    partLists[index] = value;
                else
                    partLists.Add(value);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return partLists.GetEnumerator();
        }
    }
}