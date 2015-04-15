/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/26/2012 8:49:36 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/26/2012 8:49:36 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Interfaces;
using CSharpProgrammingBasics.Library.Samples.Static;

namespace CSharpProgrammingBasics.Library.Samples
{
/// <summary>
    /// Example of an event handler delegate definition
    /// </summary>
    public delegate void SampleEventHandlerSignature(object sender, object eventArgument);
    /// <summary>
    /// An example class to describe the components of a class
    /// </summary>
    public partial class SampleClass
    {

        //the definition of event in the class
        public event SampleEventHandlerSignature OnSomeEvent;

        //constructor
        public SampleClass()
        {
            //ConfigurationManager.AppSettings["testsetting"]
        }
        //destructor
        ~SampleClass()
        {
        }


        #region The body of the class containing the class definition

        #region Properties ot the class the hold the class state
        //the properties
        public string LastError { get; set; }

        public string LastMethodCalled { get; set; }

        #endregion

        #region Methods of the class the define the class actions and behavior

        //the methods
        public void SomeFunctionalityProvidedByTheClass()
        {
        }

        public string SomeOtherFunctionalityProvidedByTheClass()
        {
            return string.Empty;

            CombustionEngineCar _theCar = new CombustionEngineCar();
            _theCar.Name = "Ferrari";
            //_theCar.Name this is an error when explicit implementing interfaces
            //
            ICar _theCarInterface = _theCar as ICar;
            string carName = _theCarInterface.Name;
        }


        public void ProductionLane()
        {
            //
            ICar _theNewCar = CarFactory.CreateNewCar();
            //
            bool _testResult = CarFactory.TestTheCar(_theNewCar);
            if (_testResult == false)
                throw new Exception("The car test failed!");
            //difference between struct and class
            SampleClassForStructure _classVariable = new SampleClassForStructure();
            SampleStructure _structVariable;
            //set field in class
            _classVariable.PropertyOne = 20;
            //set field in structure
            _structVariable.PropertyOne = 21;

        }
        #endregion

        #endregion
    }

    public class SampleClassForStructure
    {
        public int PropertyOne;
        public int PropertyTwo;
        public string PropertyString;
    }

    public struct SampleStructure
    {
        public int PropertyOne;
        public int PropertyTwo;
        public string PropertyString;
    }
}