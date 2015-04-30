using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheBad
{
    public class AcmeFactory
    {
        // The class violates the Open Closed Principle beacuse for each 
        // new product we need to modify the GetProductPrice

        // We need to find a way to add new products without changing this class
        public void GetProductPrice(string product) 
        {
            switch (product.ToLower())
            {
                case "car":
                    Console.WriteLine("The car is 25000$");
                    break;
                case "bike":
                    Console.WriteLine("The bike is 150$");
                    break;
                case "motorcycle":
                    Console.WriteLine("The motorcycle is 5000$");
                    break;
                default:
                    Console.WriteLine("The factory is not producing that product");
                    break;
            }
        }
    }
}
