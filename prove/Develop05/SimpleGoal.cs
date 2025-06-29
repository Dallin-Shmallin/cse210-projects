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
        return $"{_name} - {_description} - {_points} - {_requirements} -{_type}- {_isCompleted}";
    }
    public override string DisplayToUser(){
        return $"{_name} - {_description} - Points: {_points} Requirements: {_requirements} Type: -{_type}- Completed: {( _isCompleted ? "Yes" : "No" )}";
    }
    public override int Complete()
    {
        if (_isCompleted)
        {
            Console.WriteLine("Goal already completed.");
            return 0;
        }
        _isCompleted = true;
        return _points;
    }
}