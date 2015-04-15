/*
 * *****************************************************************************************
    Author : Goce.Kalamadevski, Seavus 
    Date created   : 6/12/2012 6:57:53 PM
    
    Modified by: Goce.Kalamadevski, Seavus
    Date modified: 6/12/2012 6:57:53 PM
    
    Proprietary and Confidential information of Seavus.  
    Redistribution and use in source and binary forms, with or without modification, without the authorization of Seavus is prohibited.

****************************** Copyright Seavus ©2010 ****************************************
******************************   All rights reserved    **************************************/

using System;
using System.Collections.Generic;
using System.Text;
using CSharpProgrammingBasics.Library.Samples.Inheritance;
using CSharpProgrammingBasics.Library.Samples.Static;

namespace CSharpProgrammingBasics.Library.Samples.Initializers
{
    /// <summary>
    /// <write description here>
    /// </summary>
    /// <summary>
    /// A car dealer that sells the cars
    /// </summary>
    public partial class CarDealer
    {
        public CarDealer()
        {
        }

        public CarDealer(string name)
        {
            this.Name = name;
            this.Address = null;
        }

        /// <summary>
        /// The Name of the dealer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The address of the dealer
        /// </summary>
        public string Address { get; set; }

        private IDictionary<Colours, IList<string>> _waitList = new Dictionary<Colours, IList<string>>();

        public void HandleNewCarProduced(object sender, CarCompleteEventArgs eventArguments)
        {
            var _newCar = eventArguments.CompletedCar;
            //
            if (!this._waitList.ContainsKey(_newCar.Colour))
                return;
            //
            var _waitListEmails = this._waitList[_newCar.Colour];
            foreach (var _email in _waitListEmails)
            {
                string _emailAsString = _email;
                //send email to client
                SendCarAvailableMail(_email);

            }
        }

        private void SendCarAvailableMail(string emailAddress)
        {
            //code to send mails
            return;
        }


    }

}