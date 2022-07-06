using PostSharp.Aspects;
using PostSharp.Serialization;

namespace PostsharpTutorial.Aspects
{
    /// <summary>
    /// LocationInterceptionAspect - Adds code for fields or properties
    /// </summary>
    [PSerializable]
    internal class LocationAspect : LocationInterceptionAspect
    {
        public override void OnGetValue(LocationInterceptionArgs args)
        {
            System.Console.WriteLine($"Property getter called. Property: {args.Instance.GetType().Name}");
            args.ProceedGetValue();
        }

        public override void OnSetValue(LocationInterceptionArgs args)
        {
            System.Console.WriteLine($"Property setter called. Setting property: {args.Instance.GetType().Name} value to: {args.Value}");
            args.ProceedSetValue();
        }
    }
}
