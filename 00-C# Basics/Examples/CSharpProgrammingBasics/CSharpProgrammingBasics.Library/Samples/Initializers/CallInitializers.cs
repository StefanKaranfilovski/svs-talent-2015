/*
 * *****************************************************************************************
    Author : Goce.Kalamadevski, Seavus 
    Date created   : 6/12/2012 6:58:48 PM
    
    Modified by: Goce.Kalamadevski, Seavus
    Date modified: 6/12/2012 6:58:48 PM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Attributes;

namespace CSharpProgrammingBasics.Library.Samples.Initializers
{
    /// <summary>
    /// <write description here>
    /// </summary>
    [VehicleMetadata(ShortName="ShortName", Description="Description")]
    public static class CallInitializers
    {

        public static CarDealer CreateNewCarDealer()
        {
            int[] _tmpInt = new int[5] { 2, 3, 4, 5, 6 };
            CarDealer[] _tmbCarDealer = new CarDealer[] { new CarDealer() { Name="TestName"}, new CarDealer() { Address="TestAddress"} };
            //
            _tmbCarDealer[0] = new CarDealer() { Name = "testName" };
            //
            _tmpInt[0] = 2;
            CarDealer _dealer = new CarDealer() { Name = "The Best Car Dealer", Address = "Street One, City" };
            CarDealer _dealerOne = new CarDealer("The Best Car Dealer") { Address = CreateRandomAddress() };
            return _dealer;
        }

        public static void CreateDealerRegister()
        {
            CarDealerRegister _register = new CarDealerRegister() 
                                                { 
                                                    CarDealers = new List<CarDealer> 
                                                        { 
                                                            CreateNewCarDealer(), 
                                                            new CarDealer { Name="Example combined"} 
                                                        } 
                                                };
            //
            _register = new CarDealerRegister();
            _register.CarDealers = new List<CarDealer>();
            _register.CarDealers.Add(CreateNewCarDealer());
            _register.CarDealers.Add(new CarDealer());
            _register.CarDealers[1].Name = "Example combined";
        }

        private static string CreateRandomAddress()
        {
            return string.Format("New random address:{0}", Guid.NewGuid());
        }

    }
}