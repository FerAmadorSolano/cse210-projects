public class Swimming : Activity
{
    private int _laps;
    private int lapPool = 50;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override string GetActivityType()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return (_laps * lapPool) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}