using Windows.UI.Xaml.Controls;

namespace UWP.Markup.IconElement;

/// <summary>
/// Provides extension methods for configuring a <see cref="IconSourceElement"/> in XAML markup.
/// </summary>
public static class IconSourceElementMarkup
{
    /// <summary>
    /// Sets the IconSource used as the icon content.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="iconSource"></param>
    /// <returns>The <see cref="IconSourceElement"/> instance for method chaining</returns>
    public static IconSourceElement IconSource(this IconSourceElement element, IconSource iconSource)
    {
        element.IconSource = iconSource;
        return element;
    }
}
