class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected string _requirements;
    protected int _points;
    public virtual int Complete() {return 0;}
    public virtual string Display() {return "";}
    public virtual string DisplayToUser() {return "";}
    public string Gettype() { return _type; }
    public string GetName() { return _name; }
    public Goal(string name, string description, int points, string requirements, string type)
    {
        _name = name;
        _description = description;
        _points = points;
        _requirements = requirements;
        _type = type;
    }
}