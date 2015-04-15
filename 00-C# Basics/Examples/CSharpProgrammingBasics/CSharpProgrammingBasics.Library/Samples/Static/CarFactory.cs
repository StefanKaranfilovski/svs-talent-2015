/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/27/2012 10:38:18 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/27/2012 10:38:18 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Interfaces;

namespace CSharpProgrammingBasics.Library.Samples.Static
{
    /// <summary>
    /// A Factory class for cars.
    /// It in fact follows the facotry pattern
    /// </summary>
    public static partial class CarFactory
    {
        private static AbstractCar s_LastCreatedCar;

        /// <summary>
        /// The reference to the last "produced" car
        /// </summary>
        public static AbstractCar LastCreatedCar
        {
            get { return CarFactory.s_LastCreatedCar; }
            private set { CarFactory.s_LastCreatedCar = value; }
        }

        /// <summary>
        /// Static constructor that is called for one time initialization
        /// </summary>
        static CarFactory()
        {
            CarFactory.LastCreatedCar = null;
            ////create new car
            //AbstractCar _carInstance =  CarFactory.CreateNewElectricCar();
        }
        /// <summary>
        /// Creates a new instance of an ElectricCar class
        /// </summary>
        /// <returns></returns>
        public static AbstractCar CreateNewElectricCar()
        {
            AbstractCar _result = new ElectricCar();
            CarFactory.LastCreatedCar = _result;
            return _result;
        }

        public static ICar CreateNewCar()
        {
            ICar _result = new CombustionEngineCar();
            return _result;
        }

        public static bool TestTheCar(ICar carToBeTested)
        {
            //carToBeTested.OpenWindow(

            //
            carToBeTested.StartEngine(StartEngineOptions.TurnOffLightsBeforeStart);
            //
            carToBeTested.OpenWindow(WindowLocation.FrontLeft | WindowLocation.FrontRight ,50);
            //
            carToBeTested.StopEngine();

            //
            return true;
        }
    }
}