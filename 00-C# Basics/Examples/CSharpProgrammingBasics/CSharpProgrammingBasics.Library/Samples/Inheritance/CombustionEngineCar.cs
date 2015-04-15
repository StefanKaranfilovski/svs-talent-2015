/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 10:49:29 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 10:49:29 AM
    
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
    /// The implementation of the abstract car class
    /// The kind of cars that are normal in the present time
    /// </summary>
    public class CombustionEngineCar : AbstractCar
    {

        public CombustionEngineCar()
            
        {
            this.Name = "CombustionEngineCar";
        }

        public override SteeringWheelPosition SteeringWheelPosition
        {
            get
            {
                return SteeringWheelPosition.Left;
            }            
        }

        public override int OpenWindow(WindowLocation whichWindow, int increment)
        {

            if (whichWindow == WindowLocation.FrontLeft)
                Console.WriteLine("Need to open front left");
            if ((whichWindow & WindowLocation.FrontLeft) == WindowLocation.FrontLeft)
                Console.WriteLine("Need to open front left");
            int _position = this.WindowPositions[whichWindow];
            if (_position > 0)
            {
                if (increment > _position)
                    increment = _position;
                _position -= increment;
            }
            return _position;
        }

        public override int CloseWindow(WindowLocation whichWindow, int increment)
        {
            int _position = this.WindowPositions[whichWindow];
            int _remaining = 100-_position;
            if (_remaining > 0)
            {
                if (increment > _remaining)
                    increment = _remaining;
                _position += increment;
            }
            return _position;
        }

        /// <summary>
        /// It starts the car engine
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public override CarDiagnostics StartEngine(StartEngineOptions options)
        {
            Console.WriteLine("StartEngine combustion car called!");
            //if engine is not running start the engine
            if (!IsEngineRunning)
            {
                //do some actions before starting the engine
                HandleBeforeStartOptions(options);
                this.IsEngineRunning = true;
            }
            HandleAfterStartOptions(options);
            return CheckCarDiagnostics();
        }

        /// <summary>
        /// It stops the car engine
        /// </summary>
        /// <returns></returns>
        public override CarDiagnostics StopEngine()
        {
            //do some actions to stop the engine
            this.IsEngineRunning = false;
            return CheckCarDiagnostics();
        }

    }
}