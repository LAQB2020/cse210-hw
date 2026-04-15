using System.Diagnostics;

public class Running : Activity
{
    private double _distance;

    public Running (int minutes,double distance) : base (minutes)
    {
        _distance = distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetMinutes() * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}