using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class Cars : IVehicle
    {
        List<Car> cars = new List<Car>();

        public int CountCars
        {
            get { return cars.Count(); }
        }

        public void AddCar(Car c)
        {
            cars.Add(c);
        }
    }
}
