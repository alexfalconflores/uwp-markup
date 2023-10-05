using UWP.Markup.Helper;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI;

namespace UWP.Markup;

public static class GridMarkup
{
    /// <summary>
    /// Sets the distance between the border and its child object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, Thickness thickness) where T : Grid
    {
        element.Padding = thickness;
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the panel's border.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, CornerRadius cornerRadius) where T : Grid
    {
        element.CornerRadius = cornerRadius;
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the panel.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, Thickness thickness) where T : Grid
    {
        element.BorderThickness = thickness;
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the border fill of the panel.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T BorderBrush<T>(this T element, Brush brush) where T : Grid
    {
        element.BorderBrush = brush;
        return element;
    }

    /// <summary>
    /// Sets the uniform distance (in pixels) between grid rows.
    /// <list type="bullet">
    /// <item> Windows version: 1709, SDK version 16299 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rowSpacing"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T RowSpacing<T>(this T element, double rowSpacing) where T : Grid
    {
        element.RowSpacing = rowSpacing;
        return element;
    }

    /// <summary>
    /// Sets the uniform distance (in pixels) between grid columns.
    /// <list type="bullet">
    /// <item> Windows version: 1709, SDK version 16299 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="columnSpacing"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T ColumnSpacing<T>(this T element, double columnSpacing) where T : Grid
    {
        element.ColumnSpacing = columnSpacing;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how far the background extends in relation
    /// to this element's border. The default is **InnerBorderEdge**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="backgroundSizing"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T BackgroundSizing<T>(this T element, BackgroundSizing backgroundSizing) where T : Grid
    {
        element.BackgroundSizing = backgroundSizing;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the distance between the border and its child object. The default value is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double padding = 0) where T : Grid
    {
        element.Padding = new Thickness(padding);
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object. The default value is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Grid
    {
        element.Padding = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object. The default value is horizontal: 0, vertical: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double horizontal = 0, double vertical = 0) where T : Grid
    {
        element.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the panel's border.
    /// The default is 0.
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double cornerRadius = 0) where T : Grid
    {
        element.CornerRadius = new CornerRadius(cornerRadius);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the panel's border.
    /// The default is topLeftRight: 0, bottomRightLeft: 0.
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="topLeftRight"></param>
    /// <param name="bottomRightLeft"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double topLeftRight = 0, double bottomRightLeft = 0) where T : Grid
    {
        element.CornerRadius = new CornerRadius(topLeftRight, topLeftRight, bottomRightLeft, bottomRightLeft);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the panel's border.
    /// The default is top-left: 0, top-right: 0, bottom-right: 0, bottom-left: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="topLeft"></param>
    /// <param name="topRight"></param>
    /// <param name="bottomRight"></param>
    /// <param name="bottomLeft"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double topLeft = 0, double topRight = 0, double bottomRight = 0, double bottomLeft = 0) where T : Grid
    {
        element.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the panel. The default is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double thickness = 0) where T : Grid
    {
        element.BorderThickness = new Thickness(thickness);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the panel. The default leftRight and topBottom is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="leftRight"></param>
    /// <param name="topBottom"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double leftRight = 0, double topBottom = 0) where T : Grid
    {
        element.BorderThickness = new Thickness(leftRight, topBottom, leftRight, topBottom);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the panel. The default is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Grid
    {
        element.BorderThickness = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the border fill of the panel.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T BorderBrush<T>(this T element, Color colors) where T : Grid
    {
        element.BorderBrush = new SolidColorBrush(colors);
        return element;
    }

    /// <summary>
    /// Sets the uniform distance (in pixels) between grid rows and grid columns.
    /// <list type="bullet">
    /// <item> Windows version: 1709, SDK version 16299 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rowSpacing"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Spacing<T>(this T element, double spacing) where T : Grid
    {
        element.RowSpacing = spacing;
        element.ColumnSpacing = spacing;
        return element;
    }

    /// <summary>
    /// Sets the uniform distance (in pixels) between grid rows and grid columns.
    /// <list type="bullet">
    /// <item> Windows version: 1709, SDK version 16299 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rowSpacing"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Spacing<T>(this T element, double rowSpacing, double columnSpacing) where T : Grid
    {
        element.RowSpacing = rowSpacing;
        element.ColumnSpacing = columnSpacing;
        return element;
    }

    /// <summary>
    /// Add a RowDefinition to the RowDefinitions collection of the Grid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rowDefinition"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T RowDefinition<T>(this T element, RowDefinition rowDefinition) where T : Grid
    {
        element.RowDefinitions.Add(rowDefinition);
        return element;
    }

    /// <summary>
    /// Add a ColumnDefinition to the ColumnDefinitions collection of the Grid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="columnDefinition"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T ColumnDefinition<T>(this T element, ColumnDefinition columnDefinition) where T : Grid
    {
        element.ColumnDefinitions.Add(columnDefinition);
        return element;
    }

    /// <summary>
    /// Add rows as a params array of RowDefinition to the RowDefinitions collection of the Grid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rowDefinitions"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T RowDefinitions<T>(this T element, params RowDefinition[] rowDefinitions) where T : Grid
    {
        foreach (RowDefinition rowDefinition in rowDefinitions)
        {
            element.RowDefinitions.Add(rowDefinition);
        }
        return element;
    }

    /// <summary>
    /// Add columns as a params array of ColumnDefinition to the ColumnDefinitions collection of the Grid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="columnDefinitions"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T ColumnDefinitions<T>(this T element, params ColumnDefinition[] columnDefinitions) where T : Grid
    {
        foreach (ColumnDefinition columnDefinition in columnDefinitions)
        {
            element.ColumnDefinitions.Add(columnDefinition);
        }
        return element;
    }

    /// <summary>
    /// Add Rows as a params array of string to the RowDefinitions collection of the Grid.
    /// <example>
    /// For Example:
    /// <code>
    /// var grid = new Grid()
    ///     .Rows("Auto", "*", "2*", "200");
    /// </code>
    /// </example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rows"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Rows<T>(this T element, params string[] rows) where T : Grid
    {
        foreach (string row in rows)
        {
            element.RowDefinitions.Add(new RowDefinition().Height(GridHelper.StringToGridLength(row)));
        }
        return element;
    }

    /// <summary>
    /// Add Columns as a params array of string to the ColumnDefinitions collection of the Grid.
    /// <example>
    /// For Example:
    /// <code>
    /// var grid = new Grid()
    ///     .Columns("*", "Auto", "2*", "200");
    /// </code>
    /// </example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="columns"></param>
    /// <returns>The <see cref="Grid"/> instance for method chaining</returns>
    public static T Columns<T>(this T element, params string[] columns) where T : Grid
    {
        foreach (string column in columns)
        {
            element.ColumnDefinitions.Add(new ColumnDefinition().Width(GridHelper.StringToGridLength(column)));
        }
        return element;
    }

    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
