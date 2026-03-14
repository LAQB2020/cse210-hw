public class Entry
{
    //List of attributes
    public string _date = "";
    public string _promptText = "";
    public string _entryText ="";

    public  void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        PromptGenerator prompFromPromptGenerator = new PromptGenerator();
        _promptText = prompFromPromptGenerator.GetRandomPrompt();         
        Console.WriteLine(_promptText);
    }





}