/*
 * *****************************************************************************************
    Author : Goce.Kalamadevski, Seavus 
    Date created   : 6/12/2012 2:04:03 AM
    
    Modified by: Goce.Kalamadevski, Seavus
    Date modified: 6/12/2012 2:04:03 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using CSharpProgrammingBasics.Library.Samples.Static;

namespace CSharpProgrammingBasics.Library.Samples.Extensions
{
    /// <summary>
    /// <write description here>
    /// </summary>
    class CallExtensions
    {
        private void CallExtensionMethod()
        {
            ICar _theCar = CarFactory.CreateNewElectricCar();
            //
            //_theCar.ToString();
            //_theCar.StopEngine();
            //notice how this is called
            _theCar.CloseAllWindows();
            //
            CarExtensions.CloseAllWindows(_theCar);
        }
    }
}