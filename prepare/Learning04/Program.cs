using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

    }
}
class Assignment
{
    protected string _studentName;
    protected string _topic;
    protected string GetSummary()
    {
        return $"Student: {_studentName}, Topic: {_topic}";
    }
}

