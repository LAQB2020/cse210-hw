public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What made me smile today?",
    "What challenge did I face today and how did I handle it?",
    "What is something new I learned today?",
    "What is one thing I am grateful for today?",
    "What moment today made me feel the most peace?",
    "Did I help someone today? How?",
    "What is something small that made today special?",
    "What did I do today that I am proud of?",
    "What is something I could improve tomorrow?",
    "What was the most surprising thing that happened today?",
    "When did I feel closest to God today?",
    "What scripture or thought inspired me today?",
    "What is something kind someone did for me today?",
    "What personal strength did I use today?",
    "What moment today would I like to remember in the future?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();      
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    

}