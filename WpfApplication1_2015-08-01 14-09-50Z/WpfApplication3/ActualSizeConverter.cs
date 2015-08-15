using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApplication3
{
    class ActualSizeConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return string.Format("{0:f2}; {1:f2}", values);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.ToString().Split(';').Select(s => (object) System.Convert.ToDouble(s)).ToArray();
        }
    }
}
