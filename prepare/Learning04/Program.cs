using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Problems 8-19", "Section 7.3");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
class Assignment
{
    protected string _studentName;
    protected string _topic;
    protected string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

