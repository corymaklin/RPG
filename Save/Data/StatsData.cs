using System;
using System.Collections.Generic;

namespace _Project.Scripts
{
    [Serializable]
    public struct StatsData
    {
        public int availablePoints;
        public List<StatData> stats;
        public List<DynamicStatData> dynamicStats;
    }
}