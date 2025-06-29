class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, string requirements, string type) : base(name, description, points, requirements, type)
    {_type = "Eternal";}
    public override string Display()
    {
        return $"{_name} ({_description}) - Points: {_points} - Requirements: {_requirements}";
    }
}