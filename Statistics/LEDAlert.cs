public class LEDAlert : IAlerter
    {
        public bool ledGlows { get; private set; } = false;

        public void alert()
        {
            this.ledGlows = true;
        }
    }
