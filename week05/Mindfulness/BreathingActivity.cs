class BreathingActivity : Activity
{
    // ✅ Constructor (usa el de la clase base)
    public BreathingActivity() 
        : base(
            "Breathing Activity",
            "This activity will help you relax by guiding your breathing in and out slowly."
        )
    {
    }

    
    public void Run()
    {
        
        DisplayStartingMessage();

        int elapsedTime = 0;

       
        while (elapsedTime < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            Console.Write("\nBreathe out... ");
            ShowCountDown(4);

            elapsedTime += 8; 
        }

        DisplayEndingMessage();
    }
}