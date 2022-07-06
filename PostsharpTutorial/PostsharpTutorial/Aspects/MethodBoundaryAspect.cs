using PostSharp.Aspects;
using PostSharp.Serialization;
using System;

namespace PostsharpTutorial.Aspects
{
    /// <summary>
    /// OnMethodBoundaryAspect - can be applied to methods and classes
    /// Methods: Add piece of code before and after method
    /// Class: Add piece of code before and after every ctor/property/method/
    /// </summary>
    [PSerializable]
    internal class MethodBoundaryAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            WriteOperationResult("Entering", args);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            WriteOperationResult("Exception", args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            WriteOperationResult("Exiting", args);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            WriteOperationResult("Successful", args);
        }

        private void WriteOperationResult(string operation, MethodExecutionArgs args)
        {
            var operationResult = $"{operation}: {args.Instance.GetType().Name} :: {args.Method.Name}";
            Console.WriteLine(operationResult);
        }
    }
}
