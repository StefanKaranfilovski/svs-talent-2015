/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 8:57:07 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 8:57:07 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProgrammingBasics.Library.Samples.AccessModifiers
{
    /// <summary>
    /// <write description here>
    /// </summary>
    internal class SampleAccessModifiersNonIherited
    {
        
        private void SampleMethodInNonInherited()
        {
            //the method uses an instanve of the samplebase classes
            SampleAccessModifiersBaseClass _baseClassInstance = new SampleAccessModifiersBaseClass();
            //internal and public internal properties can be used here
            _baseClassInstance.SampleInternalProperty = 0.5;
            _baseClassInstance.SampleProtectedInternalProperty = new int[] { 1, 2, 3 };
            //public properties can be used normally
            _baseClassInstance.SamplePublicProperty = 123;
            //
            //_baseClassInstance.
        }
         
    }
}