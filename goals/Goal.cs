using System;
using System.Collections.Generic;

namespace goals
{
    public class Goal
    {
        // public variables for test purposes
        public string title;
        string description;
        List<Goal> subGoals;
        public int importance;
        public int urgency;

        public Goal()
        {
            title = "Please add goal name";
            description = "Please add description";
            urgency = 0;
            importance = 0;
            subGoals = new List<Goal>();
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDesc()
        {
            return description;
        }

        public List<Goal> GetSubGoals()
        {
            return subGoals;
        }

        public int GetImportance()
        {
            return importance;
        }

        public int GetUrgency()
        {
            return urgency;
        }
    }
}
