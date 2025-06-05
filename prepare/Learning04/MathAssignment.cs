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
        GetSummary();
        return $"Problems: {_problems}, Textbook Section: {_textbookSection}";
    }

}