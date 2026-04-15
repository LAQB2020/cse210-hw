public  class Swimming : Activity
{
    
    private int _laps;

    public Swimming(int minutes, int laps) : base(minutes)
    {
        _laps = laps;
    }

     public override string GetActivity()
    {
        return "Swimming";
    }
    public override double GetDistance()
    {
        return _laps * 50.00 / 1000 ;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60.0;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed() ;
    }

}