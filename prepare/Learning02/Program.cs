using System;
public class Job
{
    public string _company;

    public string _job_title;
    public int _startyear;
    public int _endyear;

    public string DisplayJobInformation()
    {
        return _job_title +" (" + _company + ")" + " " + _startyear.ToString() + "-" + _endyear.ToString();
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
        john._job_title = "Fast Food Worker";
        string johninfo = john.DisplayJobInformation();
        Console.WriteLine(johninfo);
    }
}