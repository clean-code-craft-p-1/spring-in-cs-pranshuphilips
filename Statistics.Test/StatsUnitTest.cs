using System;
using System.Collections.Generic;
using Xunit;
using Statistics;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }

        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{});
            // All fields of computedStats (average, max, min) must be
            // Double.NaN (not-a-number), as described in
            // https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
            // Specify the Assert statements here
            Assert.True(double.IsNaN(computedStats.average));
            Assert.True(double.IsNaN(computedStats.max));
            Assert.True(double.IsNaN(computedStats.min));
        }
    }
}
