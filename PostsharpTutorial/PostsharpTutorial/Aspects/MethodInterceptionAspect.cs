using PostSharp.Aspects;
using PostSharp.Serialization;
using System;

namespace PostsharpTutorial.Aspects
{
    /// <summary>
    /// MethodInterceptionAspect - adds code before and after method invokation
    /// </summary>
    [PSerializable]
    internal class InterceptionAspect : MethodInterceptionAspect
    {
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            Console.WriteLine("Before Invoking");

            args.Proceed(); //proceeds with method invokation

            Console.WriteLine("After Invoking");
        }
    }
}
