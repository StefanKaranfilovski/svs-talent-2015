/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/27/2012 11:09:16 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/27/2012 11:09:16 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

//using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.Inheritance
{
    using Accessories = CSharpProgrammingBasics.Library.Samples.Namespaces.CarAccessories;
    using NamespaceAlias = CSharpProgrammingBasics.Library.Samples.Namespaces;

    /// <summary>
    /// </summary>
    partial class AbstractCar
    {
        
        private static int s_TotalCarCount = 0;

        /// <summary>
        /// Keeps the total count of created cars
        /// </summary>
        public static int TotalCarCount
        {
            get { 
                return s_TotalCarCount;
                System.Console.Write("test");
            }
            protected set { s_TotalCarCount = value; }
        }
    }
    
    

}