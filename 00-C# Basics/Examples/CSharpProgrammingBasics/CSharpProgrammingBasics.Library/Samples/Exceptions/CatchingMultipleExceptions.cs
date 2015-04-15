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
        private void CreateAndParkCarCatchMultipleExceptions()
        {
            Exception _catchedException = null;
            ICar _carToPark = null;
            try
            {
                while (true)
                {
                    //overflow the park with new cars
                    _carToPark = CarFactory.CreateNewElectricCar();
                    //park the car
                    CarFactory.ParkCar(CarParkLocation.East, _carToPark);
                }
            }
            catch (ArgumentNullException _nullException)
            {
                _catchedException = _nullException;
                _catchedException.HelpLink = "see null exception";
                throw _nullException;
            }
            catch (Exception _generalException)
            {
                _catchedException = _generalException;
                _catchedException.HelpLink = "see general exception";
            }
            if (_catchedException != null)
            {
                //write the message in event log
                EventLog.WriteEntry("Application", _catchedException.Message);
                //..etc
            }
        }
    }
}
