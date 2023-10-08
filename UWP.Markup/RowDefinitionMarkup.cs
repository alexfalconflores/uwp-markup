using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Defines the extension methods for the <see cref="RowDefinition"/> class.
/// </summary>
public static class RowDefinitionMarkup
{
    /// <summary>
    /// Sets a value that represents the minimum allowed height of a RowDefinition.
    /// The default value is 0.
    /// </summary>
    /// <param name="rowDefinition"></param>
    /// <param name="minHeight"></param>
    /// <returns>The <see cref="RowDefinition"/> instance for method chaining</returns>
    public static RowDefinition MinHeight(this RowDefinition rowDefinition, double minHeight)
    {
        rowDefinition.MinHeight = minHeight;
        return rowDefinition;
    }

    /// <summary>
    /// Sets a value that represents the maximum height of a RowDefinition.
    /// </summary>
    /// <param name="rowDefinition"></param>
    /// <param name="maxHeight"></param>
    /// <returns>The <see cref="RowDefinition"/> instance for method chaining</returns>
    public static RowDefinition MaxHeight(this RowDefinition rowDefinition, double maxHeight)
    {
        rowDefinition.MaxHeight = maxHeight;
        return rowDefinition;
    }

    /// <summary>
    /// Sets the GridLength value of a row that is defined by the RowDefinition.
    /// The default value is a GridLength representing a "1\*" sizing.
    /// </summary>
    /// <param name="rowDefinition"></param>
    /// <param name="gridLength"></param>
    /// <returns>The <see cref="RowDefinition"/> instance for method chaining</returns>
    public static RowDefinition Height(this RowDefinition rowDefinition, GridLength gridLength)
    {
        rowDefinition.Height = gridLength;
        return rowDefinition;
    }
}
