using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{
    // This way for each new product all we need to do is implement this interface and
    // provide concrete implementation of the GetProductPrice method and none of the
    // existing code needs to be changed

    public interface IGetProductPrice
    {
        void GetProductPrice(string product);
    }
}
