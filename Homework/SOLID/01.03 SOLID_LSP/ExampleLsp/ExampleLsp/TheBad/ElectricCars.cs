using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheBad
{
    // Even though ElectricCars inherits from Cars it is still limited by the fact that
    // we can only add 5 cars to it. It looks like Cars, but doesn't behave like it, so it
    // can't replace Cars. This violates the Liskov Substitution Principle.

    // We need to find a way to create an abstraction between the two classes

    public class ElectricCars : Cars
    {
        private int maxNumberOfCars = 5;

        public override void AddCar(Car c)
        {
            if (CountCars < maxNumberOfCars)
            {
                base.AddCar(c);
            }
            else 
            {
                throw new Exception("You can't create more than " + maxNumberOfCars + " electric cars");
            }
        }
    }
}
