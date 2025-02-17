using System;
using System.Collections.Generic;

namespace Tempora
{
    public class GrandClock : Clock
    {
        public List<Clock> Clocks { get; set; }

        public GrandClock(string name, int id, DateTime currentTime)
            : base(name, id, currentTime)
        {
            Clocks = new List<Clock>();
        }

        public int[] SyncTime(IEnumerable<Clock> clocks)
        {
            List<int> timeDifferences = new List<int>();

            foreach (var clock in clocks)
            {
                TimeSpan difference = clock.AdjustTime(this.CurrentTime);
                timeDifferences.Add(-(int)difference.TotalMinutes);
            }

            return timeDifferences.ToArray();
        }
    }
}
