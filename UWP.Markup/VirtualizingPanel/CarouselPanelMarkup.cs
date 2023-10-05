using Windows.UI.Xaml.Controls.Primitives;

namespace UWP.Markup.VirtualizingPanel;

/// <summary>
/// CarouselPanel can't be used as a standalone control, it can only be used  as the ItemsPanel of an ItemsControl.
/// It's the default ItemsPanel for the ComboBox control., and is not supported for use any other ItemsControl.
/// </summary>
public static class CarouselPanelMarkup
{
    /// <summary>
    /// Sets a reference to a ScrollViewer that is the scroll host or scroll
    /// owner for scrolling behavior of the CarouselPanel.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="scrollOwner"></param>
    /// <returns>The <see cref="CarouselPanel"/> instance for method chaining</returns>
    public static T ScrollOwner<T>(this T element, object scrollOwner) where T : CarouselPanel
    {
        element.ScrollOwner = scrollOwner;
        return element;
    }

    /// <summary>
    /// Not intended for general use. Sets a value that indicates whether scrolling
    /// on the vertical axis is possible.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="canVerticallyScroll"></param>
    /// <returns>The <see cref="CarouselPanel"/> instance for method chaining</returns>
    public static T CanVerticallyScroll<T>(this T element, bool canVerticallyScroll) where T : CarouselPanel
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
    /// <returns>The <see cref="CarouselPanel"/> instance for method chaining</returns>
    public static T CanHorizontallyScroll<T>(this T element, bool canHorizontallyScroll) where T : CarouselPanel
    {
        element.CanHorizontallyScroll = canHorizontallyScroll;
        return element;
    }
}
