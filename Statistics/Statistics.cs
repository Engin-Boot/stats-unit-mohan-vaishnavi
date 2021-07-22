using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            Stats _stats = new Stats();
			var sum = 0f;
			
			numbers.Sort();
			foreach (var num in numbers)
				{
					sum += num;		
				}
			_stats.average = sum/numbers.Count;
			_stats.min = numbers[0];
			_stats.max = numbers[numbers.Count-1];		
			
			return _stats;	
        }
    }
}
