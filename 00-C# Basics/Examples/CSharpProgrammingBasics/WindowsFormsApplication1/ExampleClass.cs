using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedProgramingBasics.Examples
{
    /// <summary>
    /// Example of an event handler delegate definition
    /// </summary>
    public delegate void SampleEventHandlerSignature(object sender, object eventArgument);
    /// <summary>
    /// An example class to describe the components of a class
    /// </summary>
    public class SampleClass
    {

        //the definition of event in the class
        public event SampleEventHandlerSignature OnSomeEvent;

    }
        //constructor
        public SampleClass()
        {

        }
        //destructor
        ~SampleClass()
        {
        }


        #region The body of the class containing the class definition

        #region Properties ot the class the hold the class state
        //the properties
        public string SomePropertyOfTheClass { get; set; }

        public string SomeOtherPropertyOfTheClass { get; set; }

        #endregion

        #region Methods of the class the define the class actions and behavior

        //the methods
        public void SomeFunctionalityProvidedByTheClass()
        {
        }

        public string SomeOtherFunctionalityProvidedByTheClass()
        {
            return string.Empty;
        }
        #endregion

        #endregion
    }
}
