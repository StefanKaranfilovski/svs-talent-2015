using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using WCF.Data;
using WCF.Entities;

namespace WCF.Services
{
    /// <summary>
    /// Defining a WCFService class who implements the IWCFService and IDisposable interfaces
    /// We are using this class to implement the behavior or the methods defined in the interfaces and be called as a service
    /// The [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)] attribute makes sure that a new instance of the service is created with each call to that service
    /// </summary>
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class WCFService : IWCFService, IDisposable
    {
        /// <summary>
        /// Creating a private readonly instance of the WCFDbContext class to access the database
        /// </summary>
        readonly WCFDbContext _Context = new WCFDbContext();

        public List<Product> GetProducts()
        {
            return _Context.Products.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return _Context.Customers.ToList();
        }

        /// <summary>
        /// The SubmitOrder method adds orders in the context instance and foreach order it inserts the order items in the context instance
        /// The [OperationBehavior(TransactionScopeRequired=true)] makes sure that the query that inserts the order items in the context executes in a transaction
        /// </summary>
        /// <param name="order"></param>
        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            _Context.Orders.Add(order);
            order.OrderItems.ForEach(oi => _Context.OrderItems.Add(oi));
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
