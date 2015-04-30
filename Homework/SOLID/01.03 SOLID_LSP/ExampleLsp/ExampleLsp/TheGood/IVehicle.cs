using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public interface IVehicle
    {
        int CountCars { get; }
        void AddCar(Car c);
    }
}
