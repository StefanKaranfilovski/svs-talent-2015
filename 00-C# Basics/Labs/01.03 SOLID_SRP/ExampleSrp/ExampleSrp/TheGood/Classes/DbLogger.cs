using ExampleSrp.TheGood.Interfaces;
using System;

namespace ExampleSrp.TheGood.Classes
{
    public class DbLogger : ILogger
    {
        public void LogError(string message)
        {
            // Log error in database
        }

        public void LogChangeState(string message)
        {
            // Log ChangeState in database
        }
    }
}
