using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{
    public class Bike : IGetProductPrice
    {
        public void GetProductPrice(string product)
        {
            Console.WriteLine("The bike is 150$");
        }
    }
}
