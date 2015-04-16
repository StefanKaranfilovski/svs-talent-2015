using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheBad
{
    public class Cars
    {
        List<Car> cars = new List<Car>();

        public virtual void AddCar(Car c) 
        {
            cars.Add(c);
        }

        public int CountCars 
        {
            get { return cars.Count; }
        }
    }
}
