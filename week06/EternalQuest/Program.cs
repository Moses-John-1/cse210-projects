//I added a new goal type called TimedGoal. This type of goal includes a deadline, 
//and the user only earns the points if they complete the goal before the deadline. 
//This adds more challenge to the program, just to motivate users with time-based pressure, 
//just like real-life goals.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
