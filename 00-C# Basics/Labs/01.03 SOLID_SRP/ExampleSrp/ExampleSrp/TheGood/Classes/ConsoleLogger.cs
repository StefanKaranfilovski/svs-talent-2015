using ExampleSrp.TheGood.Interfaces;
using System;
using System.Diagnostics;

namespace ExampleSrp.TheGood
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public void LogChangeState(string message)
        {
            Console.WriteLine("Car state: {0}", message);
        }
    }
}
