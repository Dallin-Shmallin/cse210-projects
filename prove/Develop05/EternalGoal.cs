class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, string requirements, string type) : base(name, description, points, requirements, type)
    { _type = "Eternal"; }
    public override string Display()
    {
        return $"{_name} -{_description} - {_points} - {_requirements}";
    }
    public override int Complete()
    {
        return _points;
    }
    public override string DisplayToUser(){
        return $"{_name} - {_description} - Points: {_points} Requirements: {_requirements} Type: -{_type}";
    }
}