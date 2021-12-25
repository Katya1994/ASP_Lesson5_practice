namespace BlazorApp;

public class ClockUtc: IClock
{
    public DateTime GetCurrentDate()
    {
        return DateTime.UtcNow;
    }
}