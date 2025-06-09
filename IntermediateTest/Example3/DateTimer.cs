namespace Example3;

public static class DateTimer
{
     public static string ToCustomString(this DateTime dateTime)
     {
         var day = dateTime.Day.ToString("D2");
         var month = dateTime.ToString("MMM");
         var year = dateTime.Year + 5508;

        return $"День {day} месяца {month} года {year} от сотворения мира.";
    }
}
