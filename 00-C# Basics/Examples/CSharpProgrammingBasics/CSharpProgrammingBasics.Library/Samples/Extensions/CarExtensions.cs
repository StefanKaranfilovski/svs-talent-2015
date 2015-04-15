/*
 * *****************************************************************************************
    Author : Goce.Kalamadevski, Seavus 
    Date created   : 6/12/2012 2:03:08 AM
    
    Modified by: Goce.Kalamadevski, Seavus
    Date modified: 6/12/2012 2:03:08 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using CSharpProgrammingBasics.Library.Samples.Inheritance;

namespace CSharpProgrammingBasics.Library.Samples.Extensions
{
    /// <summary>
    /// Class conatining the extension methods for the ICar interface
    /// </summary>
    public static class CarExtensions
    {

        /// <summary>
        /// Defines an extension method for the ICar type, that is withouth parameters
        /// </summary>
        /// <param name="carInstance"></param>
        /// <returns></returns>
        public static int CloseAllWindows(this ICar carInstance)
        {
            foreach (WindowLocation _item in Enum.GetValues(typeof(WindowLocation)))
            {
                carInstance.CloseWindow(_item, 100);
            }
            return 100;
        }
    }

}