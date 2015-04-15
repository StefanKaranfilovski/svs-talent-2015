using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using System.Collections;

namespace CSharpProgrammingBasics.Library.Samples.Exceptions
{
    public class CarPark
    {
        public int Capacity { get; set;}

        private IList<ICar> _ParkedCars { get; set; }

        public int TotalCarCount
        {
            get
            {
                return this._ParkedCars.Count;
            }
        }

        /// <summary>
        /// Parks new car in the car park
        /// </summary>
        /// <param name="carToBeParked">The car ro be parked</param>
        /// <returns>Returns the car position in the park</returns>
        public int ParkCar(ICar carToBeParked)
        {
            if (carToBeParked == null)
                throw new ArgumentNullException("carToBeParked", "Can not park a non existing car!");
            if (this.TotalCarCount > this.Capacity)
                //throw new Exception("Car park full!");
                throw new CarParkFullException("Car park full", this.Capacity);
            _ParkedCars.Add(carToBeParked);
            return _ParkedCars.Count;
        }

    }
}
