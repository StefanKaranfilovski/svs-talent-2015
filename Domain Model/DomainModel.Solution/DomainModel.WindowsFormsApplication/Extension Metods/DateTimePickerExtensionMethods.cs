using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainModel.WindowsFormsApplication.Extension_Metods
{
    public static class DateTimePickerExtensionMethods
    {
        /// <summary>
        /// DateTimePicker control extension method that converts the control value into DateTime
        /// </summary>
        /// <param type=DateTimePicker name="dateTimePicker"></param>
        /// <returns>DateTime</returns>
        public static DateTime MakeDateTime(this DateTimePicker dateTimePicker) 
        {
            DateTime dateTimeValue = Convert.ToDateTime(dateTimePicker.Text);
            return dateTimeValue;
        }
    }
}
