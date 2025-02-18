using System;
using System.Collections.Generic;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            // Initialize GrandClock with CurrentTime set to 15:00
            GrandClock grandClock = new GrandClock("Grand Clock Tower", 1, today.AddHours(15));

            // Add other clocks with their respective CurrentTime
            grandClock.Clocks.Add(new Clock("Clock 1", 2, today.AddHours(14).AddMinutes(45)));
            grandClock.Clocks.Add(new Clock("Clock 2", 3, today.AddHours(15).AddMinutes(5)));
            grandClock.Clocks.Add(new Clock("Clock 3", 4, today.AddHours(15)));
            grandClock.Clocks.Add(new Clock("Clock 4", 5, today.AddHours(14).AddMinutes(40)));

            // Output the current times of all clocks
            Console.WriteLine("Grand Clock Tower Time: " + grandClock.CurrentTime);
            foreach (var clock in grandClock.Clocks)
            {
                Console.WriteLine($"{clock.Name} Time: {clock.CurrentTime}");
            }

            // Sync all clocks with the Grand Clock Tower and get time differences
            int[] timeDifferences = grandClock.SyncTime(grandClock.Clocks);

            // Output the current times of all clocks after synchronization
            Console.WriteLine("\nAfter Synchronization:");
            Console.WriteLine("Grand Clock Tower Time: " + grandClock.CurrentTime);
            foreach (var clock in grandClock.Clocks)
            {
                Console.WriteLine($"{clock.Name} Time: {clock.CurrentTime}");
            }

            // Output the time differences
            Console.WriteLine("\nTime Differences (in minutes):");
            for (int i = 0; i < timeDifferences.Length; i++)
            {
                Console.WriteLine($"{grandClock.Clocks[i].Name}: {timeDifferences[i]} minutes");
            }
        }
    }
}
