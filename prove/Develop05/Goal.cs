class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected string _requirements;
    protected int _points;
    protected virtual void Complete() { }
    protected virtual string Display() { return ""; }
    public Goal(string name, string description, int points, string requirements, string type)
    {
        _name = name;
        _description = description;
        _points = points;
        _requirements = requirements;
        _type = type;
    }
}