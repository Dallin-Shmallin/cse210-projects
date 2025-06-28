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
}