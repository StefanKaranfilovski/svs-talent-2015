/*
 * *****************************************************************************************
    Author : Goce.Kalamadevski, Seavus 
    Date created   : 6/12/2012 7:20:55 PM
    
    Modified by: Goce.Kalamadevski, Seavus
    Date modified: 6/12/2012 7:20:55 PM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Initializers;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using System.Linq;

namespace CSharpProgrammingBasics.Library.Samples.Anonymous
{
    /// <summary>
    /// <write description here>
    /// </summary>
    public class Anonymous
    {
        public static void AnonymousExample()
        {
            CarDealer _dealer = new CarDealer();
            var v = new { Amount = 108, Message = "Hello" };
            //the name of the property is determined from the context
            var v1 = new { _dealer.Name, _dealer.Address };
            //
            //anonymous array type
            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };

            List<List<string>> _theList = new List<List<string>>() { new List<string>() { "prvstring", "vtor"}, new List<string>() { "tret"}};

            List<List<CarDealer>> _theBigList = new List<List<CarDealer>>() { new List<CarDealer>() { new CarDealer() { Name="TheName", Address="Address" }}, new List<CarDealer>()};

            // The inferred types of v.Amount and v.Message in the following
            // statement are int and string.
            Console.WriteLine(v.Amount + v.Message);
            //The inferred types and name of properties can be used directly
            Console.WriteLine(v1.Name + v1.Address);
            //
            List<CarDealer> _allCarDealers = new List<CarDealer>();
            List<ICar> _allCars = new List<ICar>();            

            //find cars with same name as dealers
            var _result = from a in _allCarDealers
                          join b in _allCars on a.Name equals b.Name
                          select new { a.Name, Car = b };
            //
            foreach (var _item in _result)
            {
                //make some operations with the found items in this method only
                Console.WriteLine(_item.Name, _item.Car);
            }

            //
            List<Store> _allHedisStores = new List<Store>();
            List<Product> _allProductsInStores = new List<Product>();
            //
            var _productsInStore = from s in _allHedisStores
                                   join p in _allProductsInStores on s.Id equals p.StoreId
                                   select new ResultFromJoin { Id = s.Id, Name = s.Name, Product = p };
                                   //select new { s.Id, s.Name, Product = p };
            //list all product in store
            foreach (var _storeProduct in _productsInStore)
            {
                Console.WriteLine("StoreName:{0}, has ProductName:{1}", _storeProduct.Name, _storeProduct.Product.ProductName);
            }

           
        }
    }

    public enum Months { January, December, EndOfTheWorld }

    public struct ResultFromJoin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
    }

    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int ProductName { get; set; }
        public int Quantity { get; set; }
    }
}