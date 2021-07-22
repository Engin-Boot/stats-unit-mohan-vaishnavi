using System.Collections.Generic;
using AlertingSystem;

namespace Statistics
{
    public class StatsAlerter
    {
        public float maxThreshold { get; private set; }
        public IAlerter[] alerters { get; private set; }

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(List<float> numbers)
        {
            if(checkIfMaxAboveThreshold(numbers))
            {
                foreach(IAlerter alerter in this.alerters)
                {
                    alerter.alert();
                }
            }
        }

        private bool checkIfMaxAboveThreshold(List<float> numbers)
        {
            StatsComputer statsComputer = new StatsComputer();
            float max = statsComputer.CalculateMax(numbers);
            return max > this.maxThreshold;
        }
    }
}
