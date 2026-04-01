public class Assignment
{
    private string _studentName;
    private string _topic;

    //Constructors
    public Assignment()
    {
        _studentName = "Jane Doe";
        _topic = "None";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;            
    }
    //Getters and setters
    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetTopic()
    {
        return _topic;
    }
    //Methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}