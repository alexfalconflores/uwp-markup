using System;
using Windows.UI.Xaml.Controls;

namespace UWP.Markup.IconElement;

/// <summary>
/// Provides extension methods for configuring a <see cref="BitmapIcon"/> in XAML markup.
/// </summary>
public static class BitmapIconMarkup
{
    /// <summary>
    /// Sets the Uniform Resource Identifier (<see cref="Uri"/>) of the bitmap to use as the icon content.
    /// </summary>
    /// <remarks>
    /// UriSource(new Uri("ms-appx:///Assets/StoreLogo.png")).
    /// </remarks>
    /// <param name="element"></param>
    /// <param name="uriSource"></param>
    /// <returns>The <see cref="BitmapIcon"/> instance for method chaining</returns>
    public static BitmapIcon UriSource(this BitmapIcon element, Uri uriSource)
    {
        element.UriSource = uriSource;
        return element;
    }

    /// <summary>
    /// Sets the string representation of the Uniform Resource Identifier (<see cref="Uri"/>) of the bitmap to use as the icon content.
    /// </summary>
    /// <remarks>
    /// UriSource("ms-appx:///Assets/StoreLogo.png").
    /// </remarks>
    /// <param name="element"></param>
    /// <param name="uriSource"></param>
    /// <returns>The <see cref="BitmapIcon"/> instance for method chaining</returns>
    public static BitmapIcon UriSource(this BitmapIcon element, string uriSource)
    {
        element.UriSource = new Uri(uriSource);
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the bitmap is shown in a single color. The default is **true**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="showAsMonochrome"></param>
    /// <returns>The <see cref="BitmapIcon"/> instance for method chaining</returns>
    public static BitmapIcon ShowAsMonochrome(this BitmapIcon element, bool showAsMonochrome)
    {
        element.ShowAsMonochrome = showAsMonochrome;
        return element;
    }
}
