public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //Constructors
    public MathAssignment():base()
    {
        _textbookSection = "None";
        _problems = "None";
    }

    public MathAssignment(string name, string topic, string textSection, string problems):base(name,topic)
    {
        _textbookSection = textSection;
        _problems = problems;
    }

    //Getters and setters
    public void SetTextBookSection(string textSection)
    {
        _textbookSection = textSection;
    }
    public string GetTextBookSection()
    {
        return _textbookSection;
    }

     public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetProblems()
    {
        return _problems;
    }
    //Methods
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}