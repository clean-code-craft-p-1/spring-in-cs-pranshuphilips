using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats stats = new Stats();

            //Initializing values
            float min = float.MaxValue;
            float max = float.MinValue;
            float sum = 0;

            //Calculating min,max and sum of numbers
            foreach (float value in numbers)
            {
                min = Math.Min(min, value);
                max = Math.Max(max, value);
                sum += value;
            }

            //Assigning the values to object
            stats.min = min;
            stats.max = max;
            stats.average = sum / numbers.Count;

            return stats;
        }
    }
}
