class MathAssignment : Assignment
{
    private string _problems;
    private string _textbookSection;
    public MathAssignment(string studentName, string topic,string problems, string textbookSection)
    {
        _studentName = studentName;
        _topic = topic;
        _problems = problems;
        _textbookSection = textbookSection;
    }
    public string GetHomeworkList()
    {
        return $"{GetSummary()}\n{_textbookSection} {_problems}";
    }

}