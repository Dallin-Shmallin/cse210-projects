using System;
using Microsoft.VisualBasic;
class BreathExercise : Exercise

{
    public BreathExercise(string title, string description)
        : base(title,description)
    {
        _title = title;
        _description = description;

    }

    public void StartBreathExercise()
    {
        StartActivity();
        int interval;
        if (_waitTime < 12000)
        {
            interval = 2;
        }
        else
        {
            interval = _waitTime / 6000;
        }
        double dividedTime = _waitTime / interval;
        for (double i = 0; i < _waitTime; i += dividedTime * 2)
        {
            Console.WriteLine("Take a deep breath in...");
            DisplayLoadingAnimation(dividedTime);
            Console.WriteLine("Now breathe out slowly...");
            DisplayLoadingAnimation(dividedTime);
        }
        EndActivity();
    }
}