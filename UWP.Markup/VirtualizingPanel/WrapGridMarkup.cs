using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup.VirtualizingPanel;

/// <summary>
/// Positions child elements sequentially from left to right or top to bottom. When
/// elements extend beyond the container edge, elements are positioned in the next
/// row or column. Can only be used to display items in an ItemsControl. See Remarks.
/// </summary>
public static class WrapGridMarkup
{
    /// <summary>
    /// Sets the alignment rules by which child elements are arranged for the
    /// vertical dimension. The default is **Top**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalChildrenAlignment"></param>
    /// <returns>The <see cref="WrapGrid"/> instance for method chaining</returns>
    public static WrapGrid VerticalChildrenAlignment(this WrapGrid element, VerticalAlignment verticalChildrenAlignment)
    {
        element.VerticalChildrenAlignment = verticalChildrenAlignment;
        return element;
    }

    /// <summary>
    /// Sets the direction in which child elements are arranged.
    /// The default is **Vertical**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="orientation"></param>
    /// <returns>The <see cref="WrapGrid"/> instance for method chaining</returns>
    public static WrapGrid Orientation(this WrapGrid element, Orientation orientation)
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
    /// <returns>The <see cref="WrapGrid"/> instance for method chaining</returns>
    public static WrapGrid MaximumRowsOrColumns(this WrapGrid element, int maximumRowsOrColumns)
    {
        element.MaximumRowsOrColumns = maximumRowsOrColumns;
        return element;
    }

    /// <summary>
    /// Sets the width of the layout area for each item that is contained in a WrapGrid.
    /// The default is Double.NaN, which results in the "Auto" layout behavior.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="itemWidth"></param>
    /// <returns>The <see cref="WrapGrid"/> instance for method chaining</returns>
    public static WrapGrid ItemWidth(this WrapGrid element, double itemWidth)
    {
        element.ItemWidth = itemWidth;
        return element;
    }

    /// <summary>
    /// Sets the height of the layout area for each item that is contained in a WrapGrid.
    /// The default is Double.NaN, which results in the "Auto" layout behavior.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="itemHeight"></param>
    /// <returns>The <see cref="WrapGrid"/> instance for method chaining</returns>
    public static WrapGrid ItemHeight(this WrapGrid element, double itemHeight)
    {
        element.ItemHeight = itemHeight;
        return element;
    }

    /// <summary>
    /// Sets the alignment rules by which child elements are arranged for the horizontal dimension.
    /// The default is **Left**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalChildrenAlignment"></param>
    /// <returns>The <see cref="WrapGrid"/> instance for method chaining</returns>
    public static WrapGrid HorizontalChildrenAlignment(this WrapGrid element, HorizontalAlignment horizontalChildrenAlignment)
    {
        element.HorizontalChildrenAlignment = horizontalChildrenAlignment;
        return element;
    }
}
