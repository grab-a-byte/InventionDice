using System;
using System.Globalization;
using Xamarin.Forms;

namespace InventionDice.Infrastructure.Converters
{
    public class EntryCompleteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new object();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
