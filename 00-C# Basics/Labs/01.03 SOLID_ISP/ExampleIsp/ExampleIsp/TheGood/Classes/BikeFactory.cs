using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Classes
{
    public class BikeFactory : IBikeFactory
    {
        public int CloseShift()
        {
            throw new NotImplementedException();
        }

        public int Paint(int paintColour)
        {
            throw new NotImplementedException();
        }

        public int PaintBike(int paintColour)
        {
            throw new NotImplementedException();
        }

        public int ProduceFrameBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandlesBike()
        {
            throw new NotImplementedException();
        }

        public int StartProductionLane()
        {
            throw new NotImplementedException();
        }

        public int StartShift()
        {
            throw new NotImplementedException();
        }

        public int StopProductionLane()
        {
            throw new NotImplementedException();
        }
    }
}
