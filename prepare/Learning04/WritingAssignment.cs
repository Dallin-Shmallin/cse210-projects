class WritingAssignment : Assignment {
    private string _title;
    public WritingAssignment(string studentName, string topic, string title)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }
    public string GetWritingInformation()
    {
        GetSummary();
        return $"{_title} by {_studentName}";
    }
}