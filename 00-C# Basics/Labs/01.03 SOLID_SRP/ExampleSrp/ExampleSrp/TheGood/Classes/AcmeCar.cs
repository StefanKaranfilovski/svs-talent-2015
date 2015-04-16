using ExampleSrp.TheGood.Interfaces;
using System;

namespace ExampleSrp.TheGood
{
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }

        private ILogger log;

        public event LogEventHandler logError;

        public event LogEventHandler logChangeState;

        public AcmeCar(ILogger i)
        {
            log = i;
            logError += log.LogError;
            logChangeState += log.LogChangeState;
        }

        public void Lock()
        {
            try
            {
                IsLocked = LockState.Locked;
                logChangeState("CarLocked");
            }
            catch (Exception)
            {
                logError("There was an error locking the car!");
            }
        }

        public void Unlock()
        {
            try
            {
                IsLocked = LockState.Unlocked;
                logChangeState("CarUnlocked");
            }
            catch (Exception)
            {
                logError("There was an error unlocking the car!");
            }
        }
    }
}
