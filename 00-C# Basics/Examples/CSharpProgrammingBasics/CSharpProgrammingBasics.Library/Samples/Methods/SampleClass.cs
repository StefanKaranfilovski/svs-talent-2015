/*
 * *****************************************************************************************
    Author : goce.kalamadevski, Seavus 
    Date created   : 3/28/2012 10:09:04 AM
    
    Modified by: goce.kalamadevski, Seavus
    Date modified: 3/28/2012 10:09:04 AM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Static;

namespace CSharpProgrammingBasics.Library.Samples
{
    /// <summary>
    /// Sample class for method overloading
    /// </summary>
    public partial class SampleClass
    {
        public bool SampleMethod(int methodParameter)
        {
            try
            {
                if (methodParameter == 0)
                {
                    this.LastError = "Sample method called with invalid parameter!";
                    return false;
                }
                //some actions here
                return true;
            }
            finally
            {
                this.LastMethodCalled = "SampleMethod(int)";
            }
        }

        public bool SampleMethod(int methodParameter, params object[] errorMessageParameters)
        {
            try
            {
                bool _result = this.SampleMethod(methodParameter);
                if (!_result)
                {
                    this.LastError = string.Format(this.LastError, errorMessageParameters);
                }
                return _result;
            }
            finally
            {
                this.LastMethodCalled = "SampleMethod(int, params)";
            }
        }

        public bool SampleMethod(int methodParameter, string callContext = null)
        {
            //must cast to object in order for the right method overload to be called
            return this.SampleMethod(methodParameter, (object)callContext);
        }

        /// <summary>
        /// Method with value type parameter passed by reference
        /// </summary>
        /// <param name="methodParameter"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SampleMethod(int methodParameter, ref int errorCode)
        {
            //the value will be passed back to the calling code
            errorCode = 12;
            return false;
        }

        public bool SampleMethodWithOut(int methodParameter, out string errorMessage)
        {
            errorMessage = "Initial message";
            return false;
        }

        /// <summary>
        /// Overloaded method
        /// </summary>
        public void SomeFunctionalityProvidedByTheClass(object methodParameter)
        {
        }

        //this is an error
        ///// <summary>
        ///// Overloaded method
        ///// </summary>
        //public bool SomeFunctionalityProvidedByTheClass(object methodParameter)
        //{
        //    return false;
        //}

        /// <summary>
        /// Overloaded method
        /// </summary>
        public bool SomeFunctionalityProvidedByTheClass(string methodParameter)
        {
            return false;
        }

        /// <summary>
        /// Overloaded method
        /// </summary>
        public void SomeFunctionalityProvidedByTheClass(ref int methodParameter)
        {
            //method body here
        }


        public void UseIndexer()
        {
            AbstractCar _theCar = CarFactory.CreateNewElectricCar();
            AbstractCar _theCarOne = CarFactory.CreateNewElectricCar();
            if (_theCar == _theCarOne)
                System.Console.WriteLine("Equal");
            int _frontRightWindowPosition = _theCar[WindowLocation.FrontRight];
        }

        //this is an error
        ///// <summary>
        ///// Overloaded method
        ///// </summary>
        //public void SomeFunctionalityProvidedByTheClass(out int methodParameter)
        //{
        //    methodParameter = 0;
        //    //method body here
        //}


        private void ExampleMethod()
        {
            int _varForValue= 0;
            SampleMethod(0, ref _varForValue);

            string _outputValue = "string";
            SampleMethodWithOut(-2, out _outputValue);
        }

    }
}