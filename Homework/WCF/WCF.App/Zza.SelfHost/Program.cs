using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Services;

namespace WCF.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are creating a new instance of the WCFService service so we can use it, and close it when we are done with it
            ServiceHost host = new ServiceHost(typeof(WCFService));
            try
            {
                host.Open();
                Console.WriteLine("Press any key to shut down");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            finally 
            {
                host.Close();
            }
        }
    }
}
