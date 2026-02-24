namespace QuestProgressTracker
{

    public class Objective
    {
        public string ObjectiveName { get; set; }
        public int RequiredAmount { get; set; }
        public int CurrentAmount { get; set; } = 0;

        public Objective() {}
        public Objective(string objectiveName, int requiredAmount)
        {
            ObjectiveName = objectiveName;
            RequiredAmount = requiredAmount;
        }

        public void Progress(int amount)
        {
            Console.WriteLine($"Objective: {ObjectiveName.ToUpper()}");
            CurrentAmount += amount;
            if(CurrentAmount >= RequiredAmount) 
            { 
                CurrentAmount = RequiredAmount;
                Console.WriteLine($"Objective: {ObjectiveName.ToUpper()} is Complete.");
            }
            Console.WriteLine($"Progression: {CurrentAmount}/{RequiredAmount}");
        }
    }
}
