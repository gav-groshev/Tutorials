using PostsharpTutorial.Aspects;
using System;
using System.Collections.Generic;

namespace PostsharpTutorial.Objects
{
    internal class Calculator 
    {
        private delegate float operation(float numberOne, float numberTwo);
        private Dictionary<char, operation> operationDict = new Dictionary<char, operation>()
        {
            { '+', new operation(Sum) },
            { '-', new operation(Sub) },
            { '*', new operation(Mul) },
            { '/', new operation(Div) }
        };

        public void WriteCalculationResult(float numberOne, char operationSign, float numberTwo)
        {
            var message = $"Invalid operation provided: {operationSign}";
            if (operationDict.ContainsKey(operationSign))
            {
                var operation = operationDict[operationSign];
                float operationResult = 0;
                try 
                { 
                    operationResult = operation(numberOne, numberTwo);
                    message = $"{numberOne}{operationSign}{numberTwo}= {operationResult}";
                }
                catch (Exception ex)
                {
                    message = $"Error while performing operation: {ex.Message}";
                }
            }
            Console.WriteLine(message);
        }

        private static float Sum(float numberOne, float numberTwo)
        {
            return numberOne + numberTwo;
        }

        private static float Sub(float numberOne, float numberTwo)
        {
            return numberOne - numberTwo;
        }

        private static float Mul(float numberOne, float numberTwo)
        {
            return numberOne * numberTwo;
        }

        private static float Div(float numberOne, [NonZero]float numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}
