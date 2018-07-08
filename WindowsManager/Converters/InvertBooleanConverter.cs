using System;
using System.Globalization;
using System.Windows.Data;

namespace WindowsManager.Converters
{
    class InvertBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool invertedValue = value != null && !(bool) value;
            return invertedValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
