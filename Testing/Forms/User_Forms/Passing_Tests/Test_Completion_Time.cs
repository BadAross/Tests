using System;
using System.Diagnostics;

namespace Testing.Classes
{
    public class Test_Completion_Time
    {
        private static Stopwatch stop_Watch = new Stopwatch();

        public static void Start_Timer()
        {
            stop_Watch.Start();
        }

        public static void Stop_Timer()
        {
            stop_Watch.Stop();
        }

        public static string Returns_Time_Completion_Test()
        {
            Stop_Timer();
            var time_Complete = stop_Watch.Elapsed;
            return Convert.ToString(time_Complete.Hours + ":" + time_Complete.Minutes + ":" + time_Complete.Seconds);
        }
    }
}
