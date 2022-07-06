using PostsharpTutorial.Aspects;
using System;

namespace PostsharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteClockNotifications();
        }

        //Getting starting with AOP: https://www.youtube.com/watch?v=Vw7ISN3-TJY
        private static void WriteClockNotifications()
        {
            var clock = new ClockNotifier();

            clock.WriteCurrentTime();
            clock.WriteCurrentTimeIsLeap();

        }
    }
}
