using System;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Job john = new Job();
        john._company = "McDonalds";
        john._startyear = 2025;
        john._endyear = 2026;
        john._jobTitle = "Fast Food Worker";
        john.Display();
    }
}