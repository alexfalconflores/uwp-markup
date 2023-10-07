using System;
using Windows.UI.Xaml;

namespace UWP.Markup.Helper;

public static class GridHelper
{
    public static GridLength StringToGridLength(string value)
    {
        return value switch
        {
            _ when value.Equals("Auto", StringComparison.OrdinalIgnoreCase) => GridLength.Auto,
            _ when value.StartsWith("*") => new GridLength(1, GridUnitType.Star),
            _ when value.EndsWith("*") && double.TryParse(value.TrimEnd('*'), out double starValue) => new GridLength(starValue, GridUnitType.Star),
            _ when double.TryParse(value, out double pixelValue) => new GridLength(pixelValue),
            _ => GridLength.Auto,

        };
        //if (value.Equals("Auto", StringComparison.OrdinalIgnoreCase))
        //    return GridLength.Auto;
        //else if (value.StartsWith("*"))
        //    return new GridLength(1, GridUnitType.Star);
        //else if (value.EndsWith("*"))
        //    if (double.TryParse(value.TrimEnd('*'), out double starValue))
        //        return new GridLength(starValue, GridUnitType.Star);
        //    else if (double.TryParse(value, out double pixelValue))
        //        return new GridLength(pixelValue);
        //return GridLength.Auto;
    }
}
