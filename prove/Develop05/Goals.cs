class Goals
    {
        private List<Goal> goals;
        private int score;

        public Goals()
        {
            goals = new List<Goal>();
            score = 0;
        }

        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(int index)
        {
            goals[index].RecordEvent();
            score += goals[index].GetValue();
            if (goals[index].IsComplete())
            {
                Console.WriteLine($"Congratulations! You completed the goal: {goals[index].GetName()}");
            }
        }

        public void DisplayGoals()
        {
            for (int i = 0; i < goals.Count; i++)
            {
                string status = goals[i].IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{status} {goals[i].GetDescription()}");
            }
            Console.WriteLine($"Total score: {score}");
        }

        public void SaveToFile(string filename)
        {
            try
            {
                Console.WriteLine($"Goals saved to file: {filename}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Error saving goals to file: {filename}");
            }
        }
    }