/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/27/2012 11:34:43 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/27/2012 11:34:43 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Inheritance;

namespace CSharpProgrammingBasics.Library.Samples.Interfaces
{
    /// <summary>
    /// Defines the contract for a car
    /// </summary>
    public interface ICar:IDisposable,ICloneable
    {
        string Name { get; }
        bool IsEngineRunning { get; }
        bool IsLightsOn { get; }
        bool IsRadioOn { get; }
        Colours Colour { get; set; }
        int NumberOfWheels { get; }
        CarDiagnostics StartEngine(StartEngineOptions options);
        CarDiagnostics StopEngine();
        void LightSwitch(bool isLightsOn);
        void RadioSwitch(bool isRadioOn);
        int OpenWindow(WindowLocation whichWindow, int increment);
        int CloseWindow(WindowLocation whichWindow, int increment);
    }
}
