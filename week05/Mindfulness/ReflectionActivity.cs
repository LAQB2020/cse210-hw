class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you showed strength.",
        "Think of a time you did something selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you apply this in the future?"
    };

    private Random _random = new Random();

    //Constructor
    public ReflectionActivity() 
        : base(
            "Reflection Activity",
            "This activity helps you reflect on moments of strength and growth."
        )
    {
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        
        string prompt = GetRandomPrompt();
        Console.WriteLine("\n" + prompt);

        Console.WriteLine("\nThink about this...");
        ShowSpinner(4);

        int elapsedTime = 0;

        
        while (elapsedTime < _duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine("\n" + question);

            ShowSpinner(5);

            elapsedTime += 5;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
}