using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            //Implement statistics here

            if (numbers == null || numbers.Count == 0) 
            {
                return new Stats
                {
                    average = Double.NaN,
                    max = Double.NaN,
                    min = Double.NaN
                };
            }

            return new Stats
            {
                average = numbers.Average(),
                max = numbers.Max(),
                min = numbers.Min()
            };
        }
    }
}
