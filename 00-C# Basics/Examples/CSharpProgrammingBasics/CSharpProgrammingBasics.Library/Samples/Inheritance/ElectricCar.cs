/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 11:26:15 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 11:26:15 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.Inheritance
{
    /// <summary>
    /// A sample class that can not be inherited
    /// A specific car that we will all be driving in the future, the Electric Car
    /// </summary>
    public sealed class ElectricCar:CombustionEngineCar
    {
        public ElectricCar()
        {
            this.Name = "ElectricCar";
        }

        /*
        public override CarDiagnostics StartEngine(StartEngineOptions methodParameter)
        {
            Console.WriteLine("Start engine electric car called!");
            //CarDiagnostics _result = base.StartEngine(methodParameter);
            CarDiagnostics _result = CarDiagnostics.None;
            //aditionally check the batteries
            this.LastDiagnostics = this.LastDiagnostics | CarDiagnostics.BatteriesOk;
            return _result;
        }
        */
        
        public new CarDiagnostics StartEngine(StartEngineOptions methodParameter)
        {
            Console.WriteLine("Start engine electric car called!");
            //CarDiagnostics _result = base.StartEngine(methodParameter);
            CarDiagnostics _result = CarDiagnostics.None;
            //aditionally check the batteries
            this.LastDiagnostics = this.LastDiagnostics | CarDiagnostics.BatteriesOk;
            return _result;
        }
        
    }


    public class BudgetCar : AbstractCar
    {
        public override SteeringWheelPosition SteeringWheelPosition
        {
            get { throw new NotImplementedException(); }
        }

        public override CarDiagnostics StartEngine(StartEngineOptions options)
        {
            throw new NotImplementedException();
        }

        public override CarDiagnostics StopEngine()
        {
            throw new NotImplementedException();
        }

        public override int OpenWindow(WindowLocation whichWindow, int increment)
        {
            throw new NotImplementedException();
        }

        public override int CloseWindow(WindowLocation whichWindow, int increment)
        {
            throw new NotImplementedException();
        }
    }


    public class BaseElevator
    {
        public virtual void GoUp(int floor)
        {
            //logic goes here
            System.Console.WriteLine("Going up {0} floors!", floor);
        }

    }

    public class JapaneseTurboElevator : BaseElevator
    {
        public override void GoUp(int floor)
        {
            this.GoUp(2);
            GoUp(2);
            System.Console.WriteLine("Turbo lift going up {0} floors!", floor);
        }
    }


    public class Building
    {
        public BaseElevator LeftElevator { get; set; }
        public BaseElevator RightElevator { get; set; }
    }
}