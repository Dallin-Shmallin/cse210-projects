class BreathExercise : Exercise
{

    public BreathExercise(int waitTime, string goodJobMessage, string openingMessage)
        : base(waitTime, goodJobMessage, openingMessage)
    {
        _waitTime = waitTime;
        _goodJobMessage = goodJobMessage;
        _openingMessage = openingMessage;
    }

    public void StartBreathExercise()
    {
        Console.WriteLine(_openingMessage);
        Console.WriteLine("Take a deep breath in...");
        System.Threading.Thread.Sleep(_waitTime);
        Console.WriteLine("Now breathe out slowly...");
        System.Threading.Thread.Sleep(_waitTime);
        Console.WriteLine(_goodJobMessage);
    }
}