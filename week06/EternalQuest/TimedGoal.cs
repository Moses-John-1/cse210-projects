using System;

public class TimedGoal : Goal
{
    private DateTime _startTime;
    private DateTime _endTime;
    private bool _isComplete;

    public TimedGoal(string shortName, string description, int points, DateTime endTime)
        : base(shortName, description, points)
    {
        _startTime = DateTime.Now;
        _endTime = endTime;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete && DateTime.Now <= _endTime)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) - Due by: {_endTime.ToShortDateString()}";
    }

    public override string GetStringRepresentation()
    {
        return $"TimedGoal|{_shortName}|{_description}|{_points}|{_endTime}|{_isComplete}";
    }
}
