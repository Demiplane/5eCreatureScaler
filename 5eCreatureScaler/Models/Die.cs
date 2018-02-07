﻿using System.Collections.Generic;

namespace CreatureScaler.Models
{
    public static class DieExtensions
    {
        private static Dictionary<Die, double> DieToHitPointPerLevelMap = new Dictionary<Die, double>
        {
            { Die.D4, 2.5 },
            { Die.D6, 3.5 },
            { Die.D8, 4.5 },
            { Die.D10, 5.5 },
            { Die.D12, 6.5 },
            { Die.D20, 10.5 },
        };

        public static double ToHitPointPerLevel(this Die die)
        {
            return DieToHitPointPerLevelMap[die];
        }
    }

    public enum Die
    {
        D4,
        D6,
        D8,
        D10,
        D12,
        D20,
    }
}
