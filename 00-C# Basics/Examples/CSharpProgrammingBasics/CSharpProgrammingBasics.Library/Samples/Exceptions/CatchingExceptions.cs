using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Static;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using System.Diagnostics;

namespace CSharpProgrammingBasics.Library.Samples.Exceptions
{
    public partial class CatchingExceptions
    {
        private void CreateAndParkCar()
        {
            Exception _catchedException = null;
            ICar _carToPark = CarFactory.CreateNewElectricCar();
            try
            {
                CarFactory.ParkCar(CarParkLocation.East, _carToPark);
            }
            catch (CarParkFullException full)
            {
                throw full;
                //throw new NotImplementedException();
            }
            catch (Exception e)
            {
                //you can do some actions here
                //we are storing the last exception to display its details later
                _catchedException = e;
                //write the message in event log
                EventLog.WriteEntry("Application", e.Message);
                //..etc
            }
        }
    }
}
