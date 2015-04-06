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
        public static DateTime MakeDateTime(this DateTimePicker dateTimePicker) 
        {
            DateTime dateTimeValue = Convert.ToDateTime(dateTimePicker.Text);
            return dateTimeValue;
        }
    }
}
