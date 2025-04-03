class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() 
        : base("Listing Activity", "A reflective listing exercise.", 0) { }

    public override void Run() 
    {
        // Implementation for listing activity
    }

    private string GetRandomPrompt() 
    {
        // Return a random prompt from _prompts list
        return "";
    }

    private List<string> GetListFromUser() 
    {
        // Get user input list
        return new List<string>();
    }
}
