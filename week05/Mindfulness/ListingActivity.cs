class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "When have you felt peace this week?",
        "Who are your heroes?"
    };

    private Random _random = new Random();

    //Constructor
    public ListingActivity() 
        : base(
            "Listing Activity",
            "This activity will help you list positive things in your life."
        )
    {
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        
        string prompt = GetRandomPrompt();
        Console.WriteLine("\n" + prompt);

        
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        
        List<string> items = GetListFromUser();

        
        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }
    
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        return items;
    }
}