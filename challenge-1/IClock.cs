using System;

namespace Challenge1
{
    public interface IClock
    {
        string Name { get; set; }
        int Id { get; set; }
        DateTime CurrentTime { get; }
        TimeSpan AdjustTime(DateTime newTime);
    }
}
