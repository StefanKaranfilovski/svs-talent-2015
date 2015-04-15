/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 10:31:43 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 10:31:43 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using CSharpProgrammingBasics.Library.Samples.Attributes;

namespace CSharpProgrammingBasics.Library.Samples.Inheritance
{
    
    [Flags]
    public enum WindowLocation
    {
        None = 0,
        FrontLeft = 1,
        FrontRight = 2,
        RearLeft = 4,
        RearRight = 8
    }

    [Flags]
    public enum StartEngineOptions
    {
        Default = 0,
        TurnOffLightsBeforeStart = 1,
        TurnOnLightsAfterStart = 2,
        TurnOffRadioBeforeStart = 4,
        TurnOnRadioAfterStart = 8,

    }

    [Flags]
    public enum CarDiagnostics
    {
        None = 0,
        OilCheckOk = 1,
        TyrePreasureOk = 2,
        AirbagsOk = 4,
        BatteriesOk = 8,

    }

    public enum Colours
    {
        White = 0,
        Red = 1,
        Green = 2,
        Blue = 3
    }

    public enum SteeringWheelPosition
    {
        Left = 0,
        Right = 1,
    }


    /// <summary>
    /// Sample abstract class with abstract and implemented members
    /// Represents a base class for all cars
    /// </summary>
    /// <summary>
    /// Partial of the abstract car defining the serializable attribute
    /// </summary>
    [Serializable]
    [CLSCompliant(true), VehicleMetadata(ShortName = "TheCar")]
    public abstract partial class AbstractCar:Object,ICar
    {
        private bool m_EngineRunning;
        private Dictionary<WindowLocation, int> m_WindowPositions;
        //private Dictionary<int, float> m_TyrePresure;
        private bool m_IsLightsOn;
        private bool m_IsRadioOn;
        private CarDiagnostics m_LastDiagnostics;

        public AbstractCar()
        {            
            m_WindowPositions = new Dictionary<WindowLocation, int>();
            this.NumberOfWheels = 4;
            //m_TyrePresure.Add("prvata guma", 10.5);
            InitializeWindowPositions();
            //count the cars created
            AbstractCar.TotalCarCount++;
        }

        public string Name { get; set; } 

        /// <summary>
        /// Gets or sets the running status of the engine
        /// </summary>
        public bool IsEngineRunning
        {
            get { return m_EngineRunning; }
            protected set { m_EngineRunning = value; }
        }

        /// <summary>
        /// Gets the dictionary with the window positions
        /// </summary>
        public Dictionary<WindowLocation, int> WindowPositions
        {
            get { return m_WindowPositions; }
            private set { m_WindowPositions = value; }
        }

        public bool IsLightsOn
        {
            get { return m_IsLightsOn; }
            protected set { m_IsLightsOn = value; }
        }

        public bool IsRadioOn
        {
            get { return m_IsRadioOn; }
            protected set { m_IsRadioOn = value; }
        }


        public CarDiagnostics LastDiagnostics
        {
            get { return m_LastDiagnostics; }
            protected set { m_LastDiagnostics = value; }
        }

        public int this[WindowLocation index]
        {
            get
            {
                return this.WindowPositions[index];
            }
            set
            {
                this.WindowPositions[index] = value;
            }
        }

        /// <summary>
        /// Sample implemented property that does not need implementation in the inherited classes
        /// </summary>
        public Colours Colour { get; set; }

        /// <summary>
        /// Abstract property that needs to be implemented in the inherited class
        /// </summary>
        public abstract SteeringWheelPosition SteeringWheelPosition { get; }

        /// <summary>
        /// Virtual property that can be overridden
        /// </summary>
        public virtual int NumberOfWheels { get; set; }

        /// <summary>
        /// It starts the car
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public abstract CarDiagnostics StartEngine(StartEngineOptions options);

        /// <summary>
        /// Stops the car engine
        /// </summary>
        /// <returns></returns>
        public abstract CarDiagnostics StopEngine();

        /// <summary>
        /// SampleAbstractMethod that needs to be implemented by the inherited classes.
        /// It opens a cars window for the amount specified by the increment 
        /// </summary>
        /// <param name="whichWindow">A collection of windows to open</param>
        /// <param name="increment">The increment that defines how much should the windows be opened in percent</param>
        /// <returns>Returns the amount in percent that the window is open</returns>
        /// <remarks>
        /// Notice that the method is only declared and not implemented.
        /// </remarks>
        public abstract int OpenWindow(WindowLocation whichWindow, int increment);

        /// <summary>
        /// It closes a cars window for the amount specified by the increment 
        /// </summary>
        /// <param name="whichWindow"></param>
        /// <param name="increment"></param>
        /// <returns></returns>
        public abstract int CloseWindow(WindowLocation whichWindow, int increment);

        /// <summary>
        /// SampleProtectedImplementedMethod that already has implementation
        /// </summary>
        /// <param name="methodParameter"></param>
        /// <returns></returns>
        protected virtual CarDiagnostics CheckCarDiagnostics()
        {
            CarDiagnostics _result = CarDiagnostics.AirbagsOk | CarDiagnostics.OilCheckOk | CarDiagnostics.TyrePreasureOk;
            this.LastDiagnostics = _result;
            return _result;
            
        }

        protected virtual void HandleBeforeStartOptions(StartEngineOptions options)
        {
            //do some actions before starting the engine
            if ((options & StartEngineOptions.TurnOffLightsBeforeStart) == StartEngineOptions.TurnOffLightsBeforeStart)
            {
                LightSwitch(false);
            }
            if ((options & StartEngineOptions.TurnOffRadioBeforeStart) == StartEngineOptions.TurnOffRadioBeforeStart)
            {
                RadioSwitch(false);
            }

        }

        protected virtual void HandleAfterStartOptions(StartEngineOptions options)
        {
            //do some actions after starting the engine
            if ((options & StartEngineOptions.TurnOnLightsAfterStart) == StartEngineOptions.TurnOnLightsAfterStart)
            {
                LightSwitch(true);
            }

            if ((options & StartEngineOptions.TurnOnRadioAfterStart) == StartEngineOptions.TurnOnRadioAfterStart)
            {
                RadioSwitch(true);
            }

        }

        /// <summary>
        /// SamplePrivateImplementedMethod that already has implementation
        /// It switches the lights on and off
        /// </summary>
        /// <param name="isLightsOn">Set true to turn the lights on, set false to turn the light off</param>
        /// <returns></returns>
        public virtual void LightSwitch(bool isLightsOn)
        {
            this.IsLightsOn = isLightsOn;
        }

        /// <summary>
        /// It switches the radio on and off
        /// </summary>
        /// <param name="isRadioOn"></param>
        public virtual void RadioSwitch(bool isRadioOn)
        {
            this.IsRadioOn = isRadioOn;
        }


        private void InitializeWindowPositions()
        {
            this.WindowPositions[WindowLocation.FrontLeft] = 100;
            this.WindowPositions[WindowLocation.FrontRight] = 50;
            this.WindowPositions[WindowLocation.RearLeft] = 25;
            this.WindowPositions[WindowLocation.RearRight] = 15;
        }


        #region IDisposable Members

        void IDisposable.Dispose()
        {
            this.WindowPositions = null;
        }

        #endregion

        #region ICloneable Members

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}