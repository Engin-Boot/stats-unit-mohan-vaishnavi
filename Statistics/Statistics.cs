using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            		
			double average, min, max;
			if (numbers.Count==0){
				average = Double.NaN;
				min = Double.NaN;
				max = Double.NaN;	
			
			}
			
			else{
				var sum = 0f;
			
				numbers.Sort();
				foreach (var num in numbers)
					{
						sum += num;		
					}
				average = sum/numbers.Count;
				min = numbers[0];
				max = numbers[numbers.Count-1];		
			
			}
			
			
		return new Stats{
			min=min,
			max=max,
			average=average
		};	
        }
    }
}
