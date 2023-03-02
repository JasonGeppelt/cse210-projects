class EternalGoal : Goal
    {
        private int timesCompleted;

        public EternalGoal(string name, int value) : base(name, value)
        {
            timesCompleted = 0;
        }

        public override void RecordEvent()
        {
            timesCompleted++;
        }

        public override string GetDescription()
        {
            return $"[ ] {name} - {value} points (completed {timesCompleted} times)";
        }
    }