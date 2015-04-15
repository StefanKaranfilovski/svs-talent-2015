using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpProgrammingBasics.Library
{
    public class Class1
    {
        /// <summary>
        /// This is a description of the method
        /// </summary>
        /// <param name="mandatory">Mandatory paramter</param>
        /// <param name="optional"></param>
        /// <returns></returns>
        public bool MethodWithOptionalParameters(int mandatory, int optional = -1,int optionalOne=-2, string optionalString="test")
        {
            //logic
            return false;
        }

        public void MethodThatCallsMethodWihtParameters()
        {
            MethodWithOptionalParameters(0, -2);
            MethodWithOptionalParameters(optional: 10, mandatory: 20);
            MethodWithOptionalParameters(0, optionalString: "NewString");
        }

         
    }
}
