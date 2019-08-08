using System;

public class Clock
{
    private int _minutes;

    const int HoursPerDay = 24;
    const int MinutesPerHour = 60;

    public Clock(int hours, int minutes)
    {
        Set(hours * MinutesPerHour + minutes);
    }

    private void Set(int minutes)
    {
        _minutes += minutes;
        _minutes %= MinutesPerHour * HoursPerDay;
        if(_minutes < 0) _minutes += MinutesPerHour * HoursPerDay;
    }

    public int Hours => _minutes / MinutesPerHour;

    public int Minutes => _minutes % MinutesPerHour;

    public Clock Add(int minutesToAdd)
    {
        Set(minutesToAdd);
        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Set(-minutesToSubtract);
        return this;
    }

    public override string ToString() => $"{Hours:00}:{Minutes:00}";
}