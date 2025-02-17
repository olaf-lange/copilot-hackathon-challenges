using System;

namespace Tempora
{
    public interface IClock
    {
        string Name { get; set; }
        int Id { get; set; }
        DateTime CurrentTime { get; }
        TimeSpan AdjustTime(DateTime newTime);
    }
}
