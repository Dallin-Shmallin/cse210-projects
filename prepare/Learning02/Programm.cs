using System;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "McDonalds";
        job1._startyear = 2025;
        job1._endyear = 2026;
        job1._jobTitle = "Fast Food Worker";

                Job job2 = new Job();
        job2._jobTitle = "epic supervisor";
        job2._company = "Epic Games";
        job2._startyear = 2023;
        job2._endyear = 2026;

        Resume employeeResume = new Resume();
        employeeResume._name = "Bingo Epicus";

        employeeResume._jobs.Add(job1);
        employeeResume._jobs.Add(job2);

        employeeResume.Display();
    }
}