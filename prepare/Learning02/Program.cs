using System;
public class Job
{
    public string _company;
    public int _startyear;
    public int _endyear;

    public string DisplayJobInformation()
    {
        return _company + " " + _startyear.ToString() + "-" + _endyear.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Job john = new Job();
        john._company = "McDonalds";
        john._startyear = 2025;
        john._endyear = 2026;
        string johninfo = john.DisplayJobInformation();
        Console.WriteLine(johninfo);
    }
}