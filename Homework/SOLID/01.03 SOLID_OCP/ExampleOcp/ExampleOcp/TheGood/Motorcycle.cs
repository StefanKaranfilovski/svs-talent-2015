using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{
    public class Motorcycle : IGetProductPrice
    {
        public void GetProductPrice(string product)
        {
            Console.WriteLine("The motorcycle is 5000$");
        }
    }
}
