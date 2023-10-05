using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Positions child elements sequentially from left to right or top to bottom in
/// an ItemsControl that shows multiple items. When elements extend beyond the container
/// edge, elements are positioned in the next row or column. Supports pixel-based
/// UI virtualization and grouped layouts.
/// <see cref="ItemsWrapGrid"/> can be used only as the ItemsPanel of an <see cref="ItemsControl"/>
/// that displays more than one item at a time. be used with an <see cref="ItemsControl"/>
/// that displays only one item at a time, such as a <see cref="ComboBox"/> or <see cref="FlipView"/>.
/// <see cref="ItemsWrapGrid"/> is the default ItemsPanel for <see cref="GridView"/>.
/// In an <see cref="ItemsWrapGrid"/>, elements are arranged in rows or columns that automatically wrap
/// to a new row or column when the elements reach the container edge.
/// If the MaximumRowsOrColumns property is set, items wrap when the specified
/// number of rows or columns is reached instead.
/// </summary>
public static class ItemsWrapGridMarkup
{
    /// <summary>
    /// Sets the dimension by which child elements are stacked.
    /// The default is **Vertical**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="orientation"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid Orientation(this ItemsWrapGrid element, Orientation orientation)
    {
        element.Orientation = orientation;
        return element;
    }

    /// <summary>
    /// Sets a value that influences the wrap point, also accounting for Orientation.
    /// The default is -1, which is a special value that indicates no maximum.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="maximumRowsOrColumns"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid MaximumRowsOrColumns(this ItemsWrapGrid element, int maximumRowsOrColumns)
    {
        element.MaximumRowsOrColumns = maximumRowsOrColumns;
        return element;
    }

    /// <summary>
    /// Sets the width of the layout area for each item that is contained in an ItemsWrapGrid.
    /// The default is Double.NaN, which results in the "Auto" layout behavior.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="itemWidth"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid ItemWidth(this ItemsWrapGrid element, double itemWidth)
    {
        element.ItemWidth = itemWidth;
        return element;
    }

    /// <summary>
    /// Sets the height of the layout area for each item that is contained in an ItemsWrapGrid.
    /// The default is **Double.NaN**, which results in the "Auto" layout behavior.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="itemHeight"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid ItemHeight(this ItemsWrapGrid element, double itemHeight)
    {
        element.ItemHeight = itemHeight;
        return element;
    }

    /// <summary>
    /// Sets the amount of space around a group.
    /// The default is a uniform Thickness of 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid GroupPadding(this ItemsWrapGrid element, Thickness thickness)
    {
        element.GroupPadding = thickness;
        return element;
    }

    /// <summary>
    /// Sets a value that specifies where group headers are positioned in relation to the group.
    /// The default is **Top**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="groupHeaderPlacement"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid GroupHeaderPlacement(this ItemsWrapGrid element, GroupHeaderPlacement groupHeaderPlacement)
    {
        element.GroupHeaderPlacement = groupHeaderPlacement;
        return element;
    }

    /// <summary>
    /// Sets the size of the buffers for items outside the viewport, in multiples
    /// of the viewport size. The default is 4.0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="cacheLength"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid CacheLength(this ItemsWrapGrid element, double cacheLength)
    {
        element.CacheLength = cacheLength;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the amount of space around a group. The default value is 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid GroupPadding(this ItemsWrapGrid element, double groupPadding = 0)
    {
        element.GroupPadding = new Thickness(groupPadding);
        return element;
    }

    /// <summary>
    /// Sets the amount of space around a group. The default value is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid GroupPadding(this ItemsWrapGrid element, double left = 0, double top = 0, double right = 0, double bottom = 0)
    {
        element.GroupPadding = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets the amount of space around a group. The default value is horizontal: 0, vertical: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="ItemsWrapGrid"/> instance for method chaining</returns>
    public static ItemsWrapGrid GroupPadding(this ItemsWrapGrid element, double horizontal = 0, double vertical = 0)
    {
        element.GroupPadding = new Thickness(horizontal, vertical, horizontal, vertical);
        return element;
    }

    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
