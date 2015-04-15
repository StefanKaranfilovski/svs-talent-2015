/*
 * *****************************************************************************************
    Author : Goce.Kalamadevski, Seavus 
    Date created   : 6/12/2012 9:54:57 PM
    
    Modified by: Goce.Kalamadevski, Seavus
    Date modified: 6/12/2012 9:54:57 PM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Static;
using CSharpProgrammingBasics.Library.Samples.Delegates;
using CSharpProgrammingBasics.Library.Samples.Interfaces;

namespace CSharpProgrammingBasics.Library.Samples.Anonymous
{
    /// <summary>
    /// <write description here>
    /// </summary>
    class CarPainterAnonymous
    {
        private void AttachAnonymousCarPainter()
        {
            //named method
            PaintCar _painter = new PaintCar(DelegatesAndEvents.CarPainter);
            SpecializedCarFactory<ElectricCar> _factory = new SpecializedCarFactory<ElectricCar>(_painter);
            //_factory.CarPainter = _painter;
            //Anonymous method
            _painter = delegate(ICar car, Colours color) { car.Colour = color; };
            _factory = new SpecializedCarFactory<ElectricCar>(_painter);
        }

        private delegate void ParametarlessDelegate();

        private void AnonymousMethodCaptureVariable()
        {
            //capturing local variable
            int n = 0;
            ParametarlessDelegate d = delegate() { System.Console.WriteLine("Copy #:{0}", ++n); };
            //
            d = ()=>
            { 
                System.Console.Write("Test");
                throw new NotImplementedException();
            };
            //
            d();
        }
    }
}