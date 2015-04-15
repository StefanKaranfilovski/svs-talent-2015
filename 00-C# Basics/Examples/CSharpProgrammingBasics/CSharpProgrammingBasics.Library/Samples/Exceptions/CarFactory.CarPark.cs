using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Exceptions;
using CSharpProgrammingBasics.Library.Samples.Interfaces;

namespace CSharpProgrammingBasics.Library.Samples.Static
{
    public enum CarParkLocation
    {
        East, 
        West, 
        North,
        South
    }

    public static partial class CarFactory
    {



        public static CarPark GetCarPark(CarParkLocation location)
        {
            return _carParks[location];
        }

        public static IDictionary<CarParkLocation, CarPark> _carParks;

        public static int ParkCar(CarParkLocation carParkLocation, ICar carToPark)
        {
            return _carParks[carParkLocation].ParkCar(carToPark);
        }

    }
}
