using System;

abstract class Goal
    {
        protected string name;
        protected int value;
        protected bool isComplete;

        public Goal(string name, int value)
        {
            this.name = name;
            this.value = value;
            isComplete = false;
        }

        public virtual void MarkComplete()
        {
            isComplete = true;
        }

        public abstract void RecordEvent();

        public string GetName()
        {
            return name;
        }

        public int GetValue()
        {
            return value;
        }

        public bool IsComplete()
        {
            return isComplete;
        }

        public abstract string GetDescription();
    }