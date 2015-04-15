using ExampleSrp.TheGood.Interfaces;
using System;

namespace ExampleSrp.TheGood.Classes
{
    public class DbLogger : IErrorLogger
    {
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }
    }
}
