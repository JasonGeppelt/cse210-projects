class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int value) : base(name, value)
        {
        }

        public override void RecordEvent()
        {
            isComplete = true;
        }

        public override string GetDescription()
        {
            return $"[ ] {name} - {value} points";
        }
    }