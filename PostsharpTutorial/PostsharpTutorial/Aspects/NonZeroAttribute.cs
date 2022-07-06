using PostSharp.Aspects;
using PostSharp.Patterns.Contracts;
using PostSharp.Reflection;
using System;

namespace PostsharpTutorial.Aspects
{
    public class NonZeroAttribute : LocationContractAttribute, ILocationValidationAspect<float>
    {
        public NonZeroAttribute() : base() {}

        public Exception ValidateValue(float value, string locationName, LocationKind locationKind, LocationValidationContext context)
        {
            return Validate(value, locationName);
        }

        private Exception Validate(float value, string locationName)
        {
            Exception exception = null;
            if (value == 0)
            {
                exception = new ArgumentOutOfRangeException($"Value of {locationName} cannot be 0.");
            }

            return exception;
        }

    }
}
