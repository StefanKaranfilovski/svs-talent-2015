using ExampleSrp.TheGood.Interfaces;
using System;

namespace ExampleSrp.TheGood
{
    public class ConsoleLogger : IErrorLogger
    {
        public void LogError(string message)
        {
            Console.WriteLine(message);
        }
    }
}
