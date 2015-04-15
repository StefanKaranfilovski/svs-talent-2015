using ExampleSrp.TheGood.Interfaces;
using System;

namespace ExampleSrp.TheGood
{
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }

        private IErrorLogger log;

        private IComputerLogger comLog;

        public event LogEventHandler logError;

        public event LogEventHandler logChangeState;

        public AcmeCar(IErrorLogger i, IComputerLogger cl)
        {
            log = i;
            comLog = cl;
            logError += log.LogError;
            logChangeState += comLog.LogChangeState;
        }

        public void Lock()
        {
            try
            {
                IsLocked = LockState.Locked;
                //log state change in computer
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
