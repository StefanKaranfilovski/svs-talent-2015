using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateExample
{



    public delegate void EngageAutoPilot(int time,Coordinates coorinates);

    public class Plane
    {
        public string Type { get; set; }

        public event EngageAutoPilot AutopilotHandler;// { get; set; }

        public bool FlyToDestination(Coordinates coordinates)
        {
            //check engine
            CheckEngine();
            //check fuel
            CheckFuel();
            //check food
            //engage autopilot
            if (AutopilotHandler != null)
                this.AutopilotHandler(30, coordinates);
            else
                throw new Exception("Autopilot handler not set!");
            //wait to get to destination
            return true;

        }

        public void CheckEngine()
        {

        }

        public void CheckFuel()
        {

        }
    }


    public struct Coordinates
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }
}
