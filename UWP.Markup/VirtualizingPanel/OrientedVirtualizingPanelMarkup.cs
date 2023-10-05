using Windows.UI.Xaml.Controls.Primitives;

namespace UWP.Markup.VirtualizingPanel;

/// <summary>
/// Adds infrastructure (provides base class) for virtualizing layout containers
/// that support spatial cues, such as VirtualizingStackPanel and WrapGrid.
/// </summary>
public static class OrientedVirtualizingPanelMarkup
{
    /// <summary>
    /// Sets a reference to a ScrollViewer that is the scroll host or scroll
    /// owner for scrolling behavior of the OrientedVirtualizingPanel.
    /// **true** to support a potentially infinite vertical layout dimension. **false**
    /// to restrict to available size.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="scrollOwner"></param>
    /// <returns>The <see cref="OrientedVirtualizingPanel"/> instance for method chaining</returns>
    public static T ScrollOwner<T>(this T element, object scrollOwner) where T : OrientedVirtualizingPanel
    {
        element.ScrollOwner = scrollOwner;
        return element;
    }

    /// <summary>
    /// Sets a value that determines how the OrientedVirtualizingPanel measures
    /// space for child elements for possible scrolling in the horizontal dimension.
    /// **true** to support a potentially infinite horizontal layout dimension. **false**
    /// to restrict to available size.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="canVerticallyScroll"></param>
    /// <returns>The <see cref="OrientedVirtualizingPanel"/> instance for method chaining</returns>
    public static T CanVerticallyScroll<T>(this T element, bool canVerticallyScroll) where T : OrientedVirtualizingPanel
    {
        element.CanVerticallyScroll = canVerticallyScroll;
        return element;
    }

    /// <summary>
    /// Not intended for general use. Gets or sets a value that indicates whether scrolling
    /// on the horizontal axis is possible.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="canHorizontallyScroll"></param>
    /// <returns>The <see cref="OrientedVirtualizingPanel"/> instance for method chaining</returns>
    public static T CanHorizontallyScroll<T>(this T element, bool canHorizontallyScroll) where T : OrientedVirtualizingPanel
    {
        element.CanHorizontallyScroll = canHorizontallyScroll;
        return element;
    }
}
