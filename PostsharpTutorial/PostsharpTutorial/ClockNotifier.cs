using PostsharpTutorial.Aspects;
using System;
namespace PostsharpTutorial
{
    [MethodBoundaryAspect] //Applies to all methods including ctors and properties
    internal class ClockNotifier
    {
        public DateTime CurrentTime => DateTime.Now;

        //[MethodBoundaryAspect]
        public void WriteCurrentTime()
        {
            Console.WriteLine($"Current time: {CurrentTime}");
        }

        //[MethodBoundaryAspect]
        public void WriteCurrentTimeIsLeap()
        {
            var isLeap = IsLeapYear() ? "Yes" : "No";
            Console.WriteLine($"Current year is leap: {isLeap}");
        }

        private bool IsLeapYear()
        {
            return DateTime.IsLeapYear(CurrentTime.Year);
        }
    }
}
