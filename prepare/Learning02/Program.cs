using System;
public class Job
{
    public string _company;
    public int _startyear;
    public int _endyear;

    public string DisplayJobInformation(string company, int startyear, int endyear)
    {
        return string.Format("", company,startyear,endyear);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

    }
}