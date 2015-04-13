using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainModel.WindowsFormsApplication.Extension_Metods
{
    public static class ComboBoxExtensionMethods
    {
        /// <summary>
        /// Combobox control extension method that converts the selected text into string
        /// </summary>
        /// <param type=ComboBox name="comboBox"></param>
        /// <returns>string</returns>
        public static string MakeString(this ComboBox comboBox) 
        {
            string stringValue = Convert.ToString(comboBox.Text);
            return stringValue;
        }
    }
}
