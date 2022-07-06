using PostsharpTutorial.Aspects;
using System;

namespace PostsharpTutorial.Objects
{
    internal class AccountNotifier
    {
        [LocationAspect]
        public decimal AccountValue { get; set; }

        [EventAspect]
        public event EventHandler Notify;

        public AccountNotifier(decimal startValue)
        {
            AccountValue = startValue;
            Notify += new EventHandler(WriteNotification);
        }

        [MethodBoundaryAspect]
        public void IncreaseValue(decimal value)
        {
            AccountValue += value;
            Notify(new object(), new EventArgs());
        }

        [InterceptionAspect]
        public void DecreaseValue(decimal value)
        {
            AccountValue -= value;
            Notify(new object(), new EventArgs());
        }

        public void WriteNotification(object sender, EventArgs e)
        {
            Console.WriteLine("Account value changed!");
        }

    }
}
