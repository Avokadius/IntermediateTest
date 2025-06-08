namespace Example3;

public static class DateTimer
{
     public static string ToCustomString(this DateTime dateTime)
     {
         string day = dateTime.Day.ToString("D2");
         string month = dateTime.ToString("MMM");
         int year = dateTime.Year + 5508;

        return $"День '{day}' месяца '{month}' года '{year}' от сотворения мира.";
    }
}
