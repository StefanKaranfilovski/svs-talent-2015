/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 8:51:13 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 8:51:13 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CSharpProgrammingBasics.Library.Samples.AccessModifiers
{

    public class SampleBaseClass
    {
        private int _value;

        public SampleBaseClass(int mustProvideValue)
        {
            this._value = mustProvideValue;
        }
    }
    /// <summary>
    /// <write description here>
    /// </summary>
    public class SampleAccessModifiersBaseClass:SampleBaseClass
    {

        public SampleAccessModifiersBaseClass()
            :this(-1)
        {
            //this.SamplePublicProperty = - 1;
        }

        private SampleAccessModifiersBaseClass(int valueToBeStored)
            :base(valueToBeStored)
        {
            this.SamplePublicProperty = valueToBeStored;
        }

        public int SamplePublicProperty { get; set; }

        internal double SampleInternalProperty { get; set; }

        protected float SampleProtectedProperty { get; set; }

        protected virtual internal object SampleProtectedInternalProperty { get; set; }

        private string SamplePrivateProperty { get; set; }

        public static SampleAccessModifiersBaseClass CreateInstance()
        {
            return new SampleAccessModifiersBaseClass();
        }

    }


    public class SampleAccessModiferUserClass
    {
        public void TestMethod()
        {
            //XmlReader _reader = XmlReader.Create(
            SampleAccessModifiersBaseClass _instance = SampleAccessModifiersBaseClass.CreateInstance();
            //logic
            //SampleAccessModifiersBaseClass _instance = new SampleAccessModifiersBaseClass();
        }
    }
}