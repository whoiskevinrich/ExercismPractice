using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var isDivisibleBy4 = year % 4 == 0;
        var isDivisibleBy100 = year % 100 == 0;
        var isDivisibleBy400 = year % 400 == 0;


        return isDivisibleBy400 || (isDivisibleBy4 && !isDivisibleBy100);
    }
}