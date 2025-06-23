using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace ProtechDemo.Converters;

public class FavoriteToIconConverter: IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool favorite)
        {
            if (favorite)
            {
                return "♡";
            }
        }
        return "♥";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}