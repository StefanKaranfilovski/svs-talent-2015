namespace ExampleSrp.TheGood.Interfaces
{
    public interface ILogger
    {
        void LogError(string message);
  
        void LogChangeState(string message);
    }
}
