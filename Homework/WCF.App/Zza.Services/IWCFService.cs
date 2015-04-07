using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Entities;

namespace WCF.Services
{
    /// <summary>
    /// Defining a IWCFService interface for defining the methods that are going to be exposed from the service
    /// Adding the [ServiceContract] attribute exposes the interface to the service
    /// </summary>
    [ServiceContract]
    public interface IWCFService
    {
        /// <summary>
        /// The [OperationContract] attribute exposes the methods to the service
        /// </summary
        [OperationContract]
        List<Product> GetProducts();

        [OperationContract()]
        List<Customer> GetCustomers();

        [OperationContract]
        void SubmitOrder(Order order);
    }
}
