using System.Collections.Generic;


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
            numbers.Sort();
            float max = numbers[numbers.Count-1];
            return max > this.maxThreshold;
        }
    }
}
