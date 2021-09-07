using System;

namespace _Project.Scripts
{
    [Serializable]
    public class ActivePart
    {
        public PartType type;
        public int id;

        public ActivePart(PartType type, int id)
        {
            this.type = type;
            this.id = id;
        }

        private ActivePart() {}
    }
}