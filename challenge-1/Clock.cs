using System;

namespace Tempora
{
    public class Clock : IClock
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime CurrentTime { get; set; }

        public Clock(string name, int id, DateTime currentTime)
        {
            Name = name;
            Id = id;
            CurrentTime = currentTime;
        }

        public TimeSpan AdjustTime(DateTime newTime)
        {
            TimeSpan difference = newTime - CurrentTime;
            CurrentTime = newTime;
            return difference;
        }
    }
}
