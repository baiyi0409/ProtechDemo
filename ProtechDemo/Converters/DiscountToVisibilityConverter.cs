using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace ProtechDemo.Converters;

public class DiscountToVisibilityConverter:IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is double discount)
        {
            return discount == 0 ? false : true;
        }
        return false;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}