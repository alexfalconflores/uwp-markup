using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWP.Markup.Helper;

/// <summary>
/// Helper class for <see cref="Grid"/>.
/// </summary>
public static class GridHelper
{
    /// <summary>
    /// Convert <see cref="string"/> to GridLength. The default value is GridLength.Auto.
    /// <example>
    /// <code>
    /// GridLength width = GridHelper.StringToGridLength("Auto"); // Auto
    /// GridLength width = GridHelper.StringToGridLength("*"); // 1*
    /// GridLength width = GridHelper.StringToGridLength("2*"); // 2*
    /// GridLength width = GridHelper.StringToGridLength("100"); // 100
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="value"></param>
    /// <returns>GridLength value</returns>
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
