using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using CSharpProgrammingBasics.Library.Samples.Static;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using System.Diagnostics;

namespace CSharpProgrammingBasics.Library.Samples.Exceptions
{
    public partial class CatchingExceptions
    {
        public void TryFinallyExample()
        {

            ICar _createdCar = null;
            //create the car
            _createdCar = CarFactory.CreateNewElectricCar();
            //before park open the window
            _createdCar.OpenWindow(WindowLocation.FrontLeft, 100);
            //initialize before you park
            //try to park            
            try
            {
                CarFactory.ParkCar(CarParkLocation.East, _createdCar);
                //this does not interfere with the finally
                //the window will be closed
                return;
            }
            catch
            {
                EventLog.WriteEntry("Application", "Error while parking new car!");
            }
            finally
            {
                //close the window no matter if exception occured
                _createdCar.CloseWindow(WindowLocation.FrontLeft, 50);
            }            
        }

    }
}
