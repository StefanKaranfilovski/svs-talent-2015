/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 3:30:10 PM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 3:30:10 PM
    
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
    /// The english version of the car with abnormal driving position :)
    /// </summary>
    public class CombustionEngineCarEnglishVersion:CombustionEngineCar
    {
        public CombustionEngineCarEnglishVersion()
        {
            this.Name = "CombustionEngineEnglishVersion";
        }

        public override SteeringWheelPosition SteeringWheelPosition
        {
            get
            {
                return SteeringWheelPosition.Right;
            }
        }
    }
}