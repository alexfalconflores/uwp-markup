using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace UWP.Markup;

/// <summary>
/// Represents a tick mark on a Slider control. Not intended for general use.
/// </summary>
public static class TickBarMarkup
{
    /// <summary>
    /// Sets the Brush that draws on the background area of the TickBar.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="value"></param>
    /// <returns>The <see cref="TickBar"/> instance for method chaining</returns>
    public static TickBar Fill(this TickBar element, Brush value)
    {
        element.Fill = value;
        return element;
    }
}
