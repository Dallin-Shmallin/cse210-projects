class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points, string requirements, string type) : base(name, description, points, requirements, type)
    {
        _isCompleted = false;
        _type = "Simple";
    }

    public override string Display()
    {
        return $"{_name} ({_description}) - Points: {_points} - Requirements: {_requirements}";
    }
}