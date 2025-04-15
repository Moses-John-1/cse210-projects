public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public abstract double GetDistance();  
    public abstract double GetSpeed(); 
    public abstract double GetPace(); 

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():0.##} miles, Speed {GetSpeed():0.##} mph, Pace: {GetPace():0.##} min per mile";
    }
}
