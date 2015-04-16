using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    // Using an interface the class that impements it will always match the base type
    // no matter the concrete implementation of its methods and properties.

    public class ElectricCars : IVehicle
    {
        private int count = 0;
        Car[] cars = new Car[5];

        public int CountCars
        {
            get { return cars.Length; }
        }

        public void AddCar(Car c)
        {
            if (count < 5) 
            {
                cars[count] = c;
                count++;
            }
            else 
            {
                throw new Exception("You can't create more than " + count + " electric cars");
            }
        }
    }
}
