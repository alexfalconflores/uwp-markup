using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Provides a grid-style layout panel where each tile/cell can be variable size
/// based on content.
/// </summary>
public static class VariableSizedWrapGridMarkup
{
    /// <summary>
    /// Sets the alignment rules by which child elements are arranged for the vertical dimension.
    /// The default is **Top**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalChildrenAlignment"></param>
    /// <returns>The <see cref="VariableSizedWrapGrid"/> instance for method chaining</returns>
    public static VariableSizedWrapGrid VerticalChildrenAlignment(this VariableSizedWrapGrid element, VerticalAlignment verticalChildrenAlignment)
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
    /// <returns>The <see cref="VariableSizedWrapGrid"/> instance for method chaining</returns>
    public static VariableSizedWrapGrid Orientation(this VariableSizedWrapGrid element, Orientation orientation)
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
    /// <returns>The <see cref="VariableSizedWrapGrid"/> instance for method chaining</returns>
    public static VariableSizedWrapGrid MaximumRowsOrColumns(this VariableSizedWrapGrid element, int maximumRowsOrColumns)
    {
        element.MaximumRowsOrColumns = maximumRowsOrColumns;
        return element;
    }

    /// <summary>
    /// Sets the width of the layout area for each item that is contained in a VariableSizedWrapGrid.
    /// The default is Double.NaN, which results in the "Auto" layout behavior.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="itemWidth"></param>
    /// <returns>The <see cref="VariableSizedWrapGrid"/> instance for method chaining</returns>
    public static VariableSizedWrapGrid ItemWidth(this VariableSizedWrapGrid element, double itemWidth)
    {
        element.ItemWidth = itemWidth;
        return element;
    }

    /// <summary>
    /// Sets the height of the layout area for each item that is contained in a VariableSizedWrapGrid.
    /// The default is Double.NaN, which results in the "Auto" layout behavior.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="itemHeight"></param>
    /// <returns>The <see cref="VariableSizedWrapGrid"/> instance for method chaining</returns>
    public static VariableSizedWrapGrid ItemHeight(this VariableSizedWrapGrid element, double itemHeight)
    {
        element.ItemHeight = itemHeight;
        return element;
    }

    /// <summary>
    /// Sets the alignment rules by which child elements are arranged for the horizontal dimension.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalChildrenAlignment"></param>
    /// <returns>The <see cref="VariableSizedWrapGrid"/> instance for method chaining</returns>
    public static VariableSizedWrapGrid HorizontalChildrenAlignment(this VariableSizedWrapGrid element, HorizontalAlignment horizontalChildrenAlignment)
    {
        element.HorizontalChildrenAlignment = horizontalChildrenAlignment;
        return element;
    }
}
