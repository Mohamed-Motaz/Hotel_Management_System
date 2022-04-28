using System;

public class TimeHandler
{
    private static TimeHandler timeHandler = new TimeHandler();

    private TimeHandler(){}

    public static TimeHandler getInstance()
    {
        return timeHandler;
    }

    public long GetDateInEpoch(int day,int month,int year)
    {
        return (long)(new DateTimeOffset(year,month,day,0,0,0, TimeSpan.Zero) - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
    }

    public int GetNumberOfDays(long firstEpoch, long secondEpoch)
    {
        DateTime differenceDate = new DateTime(1970, 1, 1, 0, 0, 0, 0); 
        differenceDate = differenceDate.AddSeconds(Math.Abs(firstEpoch-secondEpoch));
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (int)differnce.Days;
    }

    public long GetYesterdayInEpoch()
    {
        DateTime differenceDate = DateTime.Today.AddDays(-1);
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (long)differnce.TotalSeconds;
    }

    public long GetLastWeekInEpoch()
    {
        DateTime differenceDate = DateTime.Today.AddDays(-7);
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (long)differnce.TotalSeconds;
    }



    public long GetLastMonthInEpoch()
    {
        DateTime differenceDate = DateTime.Today.AddMonths(-1);
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (long)differnce.TotalSeconds;
    }

    public long GetLastYearInEpoch()
    {
        DateTime differenceDate = DateTime.Today.AddYears(-1);
        TimeSpan differnce = differenceDate.Subtract(DateTime.Parse("01-Jan-1970"));
        return (long)differnce.TotalSeconds;
    }

    public long GetTodayInEpoch()
    {
        TimeHandler timeHandler = TimeHandler.getInstance();
        return timeHandler.GetDateInEpoch(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
    }


}