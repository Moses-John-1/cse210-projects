abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage() {}
    public void DisplayEndingMessage() {}
    protected void ShowSpinner(int seconds) {}
    protected void ShowCountDown(int seconds) {}

    public abstract void Run(); 
}
