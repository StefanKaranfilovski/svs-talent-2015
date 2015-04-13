using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainModel.WindowsFormsApplication.Extension_Metods
{
    public static class TextBoxExtensionMethods
    {
        /// <summary>
        /// TextBox control extension methods that convert the control text into string, int32 and decimal respectfully
        /// </summary>

        public static string MakeString(this TextBox textBox) 
        {
            string stringValue = Convert.ToString(textBox.Text);
            return stringValue;
        }

        public static int MakeInt32(this TextBox textBox) 
        {
            int intValue = Convert.ToInt32(textBox.Text);
            return intValue;
        }

        public static decimal MakeDecimal(this TextBox textBox) 
        {
            decimal decimalValue = Convert.ToDecimal(textBox.Text);
            return decimalValue;
        }
    }
}
