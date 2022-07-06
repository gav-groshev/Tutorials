using PostsharpTutorial.Objects;
using System;

namespace PostsharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteClockNotifications();
            //WriteAccountOperationResults();
            WriteCalculationResult();
        }

        //Getting starting with AOP: https://www.youtube.com/watch?v=Vw7ISN3-TJY
        private static void WriteClockNotifications()
        {
            var clock = new ClockNotifier();

            clock.WriteCurrentTime();

            Console.WriteLine("---");

            clock.WriteCurrentTimeIsLeap();
        }

        //Advanced AOP Programming: https://www.youtube.com/watch?v=xhKIJrNzdyM
        public static void WriteAccountOperationResults()
        {
            var account = new AccountNotifier(1000);
            Console.WriteLine("Method Boundary Aspect example: ");
            account.IncreaseValue(500);
            Console.WriteLine($"Account value: {account.AccountValue}");
            Console.WriteLine("---");

            Console.WriteLine("Method Interception Aspect example: ");
            account.DecreaseValue(400);
            Console.WriteLine($"Account value: {account.AccountValue}");
            Console.WriteLine("---");
        }

        //Custom Contracts example from documentation
        public static void WriteCalculationResult()
        {
            var calc = new Calculator();
            calc.WriteCalculationResult(2,'+',2);
            calc.WriteCalculationResult(2, '-', 2);
            calc.WriteCalculationResult(2, '*', 3);
            calc.WriteCalculationResult(2, '/', 4);
            calc.WriteCalculationResult(2, '/', 0);
            calc.WriteCalculationResult(2, '=', 2);

        }
    }
}
