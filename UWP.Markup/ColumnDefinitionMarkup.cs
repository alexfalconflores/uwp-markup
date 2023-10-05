using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Provides a set of static methods for creating <see cref="ColumnDefinition"/> instances
/// </summary>
public static class ColumnDefinitionMarkup
{
    /// <summary>
    /// Sets the GridLength value of a column that is defined by the ColumnDefinition.
    /// The default value is a GridLength representing a "1\*" sizing.
    /// </summary>
    /// <param name="columnDefinition"></param>
    /// <param name="gridLength"></param>
    /// <returns>The <see cref="ColumnDefinition"/> instance for method chaining</returns>
    public static ColumnDefinition Width(this ColumnDefinition columnDefinition, GridLength gridLength)
    {
        columnDefinition.Width = gridLength;
        return columnDefinition;
    }

    /// <summary>
    /// Sets a value that represents the minimum width of a ColumnDefinition.
    /// The default is 0.
    /// </summary>
    /// <param name="columnDefinition"></param>
    /// <param name="minWidth"></param>
    /// <returns>The <see cref="ColumnDefinition"/> instance for method chaining</returns>
    public static ColumnDefinition MinWidth(this ColumnDefinition columnDefinition, double minWidth)
    {
        columnDefinition.MinWidth = minWidth;
        return columnDefinition;
    }

    /// <summary>
    /// Sets a value that represents the maximum width of a ColumnDefinition.
    /// The default is PositiveInfinity.
    /// </summary>
    /// <param name="columnDefinition"></param>
    /// <param name="maxWidth"></param>
    /// <returns>The <see cref="ColumnDefinition"/> instance for method chaining</returns>
    public static ColumnDefinition MaxWidth(this ColumnDefinition columnDefinition, double maxWidth)
    {
        columnDefinition.MaxWidth = maxWidth;
        return columnDefinition;
    }
}
