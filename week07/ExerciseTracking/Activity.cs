public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(int minutes)
    {
        _date = DateTime.Now;
        _minutes = minutes;
    }

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivity();

    public string GetSumary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetActivity()} ({GetMinutes()})- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km ";
    }

}