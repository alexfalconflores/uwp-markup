using Windows.UI.Xaml.Controls;

namespace UWP.Markup;

/// <summary>
/// Represents an items control that displays one item at a time, and enables "flip"
/// behavior for traversing its collection of items.
/// </summary>
public static class FlipViewMarkup
{
    /// <summary>
    /// Sets a value that indicates whether transition animations are always
    /// used whether the navigation is touch-based, button-based or programmatic.
    /// The default is **true**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="value"></param>
    /// <returns>The <see cref="FlipView"/> instance for method chaining</returns>
    public static T UseTouchAnimationsForAllNavigation<T>(this T element, bool value) where T : FlipView
    {
        element.UseTouchAnimationsForAllNavigation = value;
        return element;
    }
}
