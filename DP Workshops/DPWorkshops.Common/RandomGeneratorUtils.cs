using System;

namespace DPWorkshops.Common
{
    public static class RandomGeneratorUtils
    {
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}
