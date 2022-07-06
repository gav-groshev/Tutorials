using PostSharp.Aspects;
using PostSharp.Serialization;

namespace PostsharpTutorial.Aspects
{
    /// <summary>
    /// EventInterceptionAspect - adds code when adding, removing or invoking method
    /// </summary>
    [PSerializable]
    internal class EventAspect : EventInterceptionAspect
    {
        public override void OnAddHandler(EventInterceptionArgs args)
        {
            System.Console.WriteLine("A handler was added");
            args.ProceedAddHandler();
        }

        public override void OnRemoveHandler(EventInterceptionArgs args)
        {
            System.Console.WriteLine("A handler was removed");
            args.ProceedRemoveHandler();        
        }
        public override void OnInvokeHandler(EventInterceptionArgs args)
        {
            System.Console.WriteLine("A handler was invoked");
            args.ProceedInvokeHandler();
        }
    }
}
