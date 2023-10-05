using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Defines a content decorator that can stretch and scale a single child to fill
/// the available space.
/// </summary>
public static class ViewboxMarkup
{
    /// <summary>
    /// Sets the StretchDirection, which determines how scaling is applied to the contents of a Viewbox.
    /// The default is **Both**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="stretchDirection"></param>
    /// <returns>The <see cref="Viewbox"/> instance for method chaining</returns>
    public static Viewbox StretchDirection(this Viewbox element, StretchDirection stretchDirection)
    {
        element.StretchDirection = stretchDirection;
        return element;
    }

    /// <summary>
    /// Sets the Stretch mode, which determines how content fits into the available space.
    /// The default is **Uniform**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="stretch"></param>
    /// <returns>The <see cref="Viewbox"/> instance for method chaining</returns>
    public static Viewbox Stretch(this Viewbox element, Stretch stretch)
    {
        element.Stretch = stretch;
        return element;
    }

    /// <summary>
    /// Sets the single child element of a Viewbox element.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="child"></param>
    /// <returns>The <see cref="Viewbox"/> instance for method chaining</returns>
    public static Viewbox Child(this Viewbox element, UIElement child)
    {
        element.Child = child;
        return element;
    }
}
