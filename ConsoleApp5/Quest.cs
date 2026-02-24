using System.Runtime.InteropServices;

namespace QuestProgressTracker
{
    public class Quest
    {
        public string QuestName { get; set; }
        public List<Objective> Objectives { get; set; } = new();
        public bool AllObjectivesComplete { get; set; }
        public bool IsCompleted { get; set; }

        public Quest() {}

        public Quest(string name)
        {
            QuestName = name; 
        }


        public void AddObjective(string name, int requiredAmount)
        {
            Objective newObjective = new(name, requiredAmount);
            Objectives.Add(newObjective);
        }

        public void ProgressObjective(string name, int amount)
        {
            int uncompleteObjectives = 0;

            foreach (Objective obj in Objectives)
            {
                if(obj.ObjectiveName == name) { obj.Progress(amount); }
                
                if(obj.CurrentAmount != obj.RequiredAmount) { uncompleteObjectives++; }

            }

            if (uncompleteObjectives == 0)
            {
                AllObjectivesComplete = true;
            }
            else { Console.WriteLine("Your quest is not yet completed."); }
        }

        public void TurnIn()
        {

        }

        public Objective GetObjective(string name)
        {
            foreach (Objective obj in Objectives)
            {
                if (obj.ObjectiveName == name) { return obj; }
            }

            throw new Exception("Objective not found :(");
        }

    }
}
