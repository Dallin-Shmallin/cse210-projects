class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesUntilCompleted;
    public ChecklistGoal(string name, string description, int points, string requirements, int timesUntilCompleted, string type)
        : base(name, description, points, requirements, type)
    {
        _timesCompleted = 0;
        _timesUntilCompleted = timesUntilCompleted;
        _type = "Checklist";
    }
    public int GetTimesCompleted() { return _timesCompleted; }
    public int GetTimesUntilCompleted() { return _timesUntilCompleted; }
    public override string Display()
    {
        return $"{_name} ({_description}) - {_points} - {_requirements} - {_type}-{_timesCompleted}-{_timesUntilCompleted}";
    }
    public override string DisplayToUser()
    {
        return $"{_name} - {_description} - Points: {_points} Requirements: {_requirements} Type: -{_type}- Times Completed: {_timesCompleted}/{_timesUntilCompleted}";
    }
    public override int Complete()
    {
        if (_timesCompleted >= _timesUntilCompleted)
        {
            Console.WriteLine("Goal already completed.");
            return 0;
        }
        _timesCompleted++;
        return _points;
    }
}