using ExampleSrp.TheGood.Interfaces;
using System;

namespace ExampleSrp.TheGood.Classes
{
    public class ComputerLogger : IComputerLogger
    {
        public void LogChangeState(string message)
        {
            Console.WriteLine("Car state: {0}", message);
        }
    }
}
