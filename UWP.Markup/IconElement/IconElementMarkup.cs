using Windows.UI;
using Windows.UI.Xaml.Media;

namespace UWP.Markup.IconElement;

/// <summary>
/// Provides extension methods for configuring a <see cref="Windows.UI.Xaml.Controls.IconElement"/> in XAML markup.
/// </summary>
public static class IconElementMarkup
{
    /// <summary>
    /// Sets a brush that describes the foreground color.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="foreground"></param>
    /// <returns>The <see cref="Windows.UI.Xaml.Controls.IconElement"/> instance for method chaining</returns>
    public static T Foreground<T>(this T element, Brush foreground) where T : Windows.UI.Xaml.Controls.IconElement
    {
        element.Foreground = foreground;
        return element;
    }

    /// <summary>
    /// Sets a Color that describes the foreground color.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="color"></param>
    /// <returns>The <see cref="Windows.UI.Xaml.Controls.IconElement"/> instance for method chaining</returns>
    public static T Foreground<T>(this T element, Color color) where T : Windows.UI.Xaml.Controls.IconElement
    {
        element.Foreground = new SolidColorBrush(color);
        return element;
    }
}
