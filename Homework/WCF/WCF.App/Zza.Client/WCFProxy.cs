using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Client.WCFServices;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
using WCF.Entities;

namespace WCF.Client
{

    class WCFProxy : ClientBase<IWCFService>, IWCFService
    {
        public WCFProxy() { }
        public WCFProxy(string endpointName) : base(endpointName) { }
        public WCFProxy(Binding binding, string address) : base(binding, new EndpointAddress(address)) { }

        public ObservableCollection<Product> GetProducts()
        {
            return Channel.GetProducts();
        }

        public Task<ObservableCollection<Product>> GetProductsAsync()
        {
            return Channel.GetProductsAsync();
        }

        public ObservableCollection<Customer> GetCustomers()
        {
            return Channel.GetCustomers();
        }

        public Task<ObservableCollection<Customer>> GetCustomersAsync()
        {
            return Channel.GetCustomersAsync();
        }

        public void SubmitOrder(Order order)
        {
            Channel.SubmitOrder(order);
        }

        public Task SubmitOrderAsync(Order order)
        {
            return Channel.SubmitOrderAsync(order);
        }
    }
}
