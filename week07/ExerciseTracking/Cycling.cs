public  class Cycling : Activity
{
    private double _speed;

    public Cycling (int minutes,double speed) : base (minutes)
    {
        _speed = speed;
    }

    public override string GetActivity()
    {
        return "Cycling";
    }
    public override double GetDistance()
    {
        return _speed * GetMinutes();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }


}