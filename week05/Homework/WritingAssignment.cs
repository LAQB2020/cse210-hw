public class WritingAssignment : Assignment
{
    private string _title;
    //Constructors
    public WritingAssignment():base()
    {
        _title = "None";
        
    }

    public WritingAssignment (string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //Getters and Setters
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }

    //Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()} ";
    }

}