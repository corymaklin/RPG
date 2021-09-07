using System;
using System.Collections.Generic;

namespace _Project.Scripts
{
    [Serializable]
    public class ActivePartMap
    {
        public List<ActivePart> parts;
        
        public ActivePart this[PartType type]
        {
            get => parts.Find(part => part.type == type);
            set
            {
                int index = parts.FindIndex(part => part.type == type);
                if (index == -1)
                    parts[index] = value;
                else
                    parts.Add(value);
            }
        }

        public ActivePartMap()
        {
            parts = new List<ActivePart>();
        }
    }
}