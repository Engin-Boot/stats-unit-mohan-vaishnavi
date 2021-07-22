public class EmailAlert : IAlerter
    {
        public bool emailSent { get; private set; } = false;

        public void alert()
        {
            this.emailSent = true;
        }
    }
	
