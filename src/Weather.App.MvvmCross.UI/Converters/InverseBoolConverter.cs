using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Converters;

namespace Weather.App.Converters
{
    public class InverseBoolConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}
