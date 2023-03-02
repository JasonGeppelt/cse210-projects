 class Checklist : Goal
    {
        private int timesCompleted;
        private int target;

        public Checklist(string name, int value, int target) : base(name, value)
        {
            timesCompleted = 0;
            this.target = target;
        }

        public override void RecordEvent()
        {
            timesCompleted++;
            if (timesCompleted >= target)
            {
                isComplete = true;
                value += 500; // bonus for completing checklist
            }
        }

        public override string GetDescription()
        {
            return $"[ ] {name} - {value} points (completed {timesCompleted}/{target} times)";
        }
    }