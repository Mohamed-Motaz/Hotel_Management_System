using System;

public static class TimeHandler
{

    public static long GetDateInEpoch(int day,int month,int year)
    {
        return (long)(new DateTimeOffset(year,month,day,0,0,0, TimeSpan.Zero) - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
    }

    public static int GetNumberOfDays(long firstEpoch, long secondEpoch)
    {
        DateTime differenceDate = new DateTime(1970, 1, 1, 0, 0, 0, 0); 
        differenceDate = differenceDate.AddSeconds(Math.Abs(firstEpoch-secondEpoch));
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (int)differnce.Days;
    }

    public static long GetDayInEpoch()
    {
        DateTime differenceDate = new DateTime(1970, 1, 2, 0, 0, 0, 0);
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (long)differnce.TotalSeconds;
    }

    public static long GetMonthInEpoch()
    {
        DateTime differenceDate = new DateTime(1970, 2, 1, 0, 0, 0, 0);
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (long)differnce.TotalSeconds;
    }

    public static long GetYearInEpoch()
    {
        DateTime differenceDate = new DateTime(1971, 1, 1, 0, 0, 0, 0);
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (long)differnce.TotalSeconds;
    }


}