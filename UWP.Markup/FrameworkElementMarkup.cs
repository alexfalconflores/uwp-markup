using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Provides extension methods for configuring a <see cref="FrameworkElement"/> in XAML markup.
/// </summary>
public static class FrameworkElementMarkup
{
    /// <summary>
    /// Sets the width of a FrameworkElement. The default is **NaN**. Except for the special
    /// NaN value, this value must be equal to or greater than 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="width"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Width<T>(this T element, double width) where T : FrameworkElement
    {
        element.Width = width;
        return element;
    }

    /// <summary>
    /// Sets the vertical alignment characteristics that are applied to a FrameworkElement
    /// when it is composed in a parent object such as a panel or items control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="verticalAlignment"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T VerticalAlignment<T>(this T element, VerticalAlignment verticalAlignment) where T : FrameworkElement
    {
        element.VerticalAlignment = verticalAlignment;
        return element;
    }

    /// <summary>
    /// Sets an arbitrary object value that can be used to store custom information about this object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="tag"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Tag<T>(this T element, object tag) where T : FrameworkElement
    {
        element.Tag = tag;
        return element;
    }

    /// <summary>
    /// Sets an instance Style that is applied for this object during layout and rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="style"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Style<T>(this T element, Style style) where T : FrameworkElement
    {
        element.Style = style;
        return element;
    }

    /// <summary>
    /// Get the locally defined resource dictionary. In XAML, you can establish resource items
    /// as child object elements of a `frameworkElement.Resources` property element, through
    /// XAML implicit collection syntax.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="resources"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Resources<T>(this T element, ResourceDictionary resources) where T : FrameworkElement
    {
        element.Resources = resources;
        return element;
    }

    /// <summary>
    /// Sets the identifying name of the object. When a XAML processor creates the object tree
    /// from XAML markup, run-time code can refer to the XAML-declared object by this name.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="name"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Name<T>(this T element, string name) where T : FrameworkElement
    {
        element.Name = name;
        return element;
    }

    /// <summary>
    /// Sets the minimum width constraint of a FrameworkElement. The default is **0**. This value can
    /// be any value equal to or greater than 0. However, PositiveInfinity is not valid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="width"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T MinWidth<T>(this T element, double width) where T : FrameworkElement
    {
        element.MinWidth = width;
        return element;
    }

    /// <summary>
    /// Sets the minimum height constraint of a FrameworkElement. The default is **0**. This value can
    /// be any value equal to or greater than 0. However, PositiveInfinity is not valid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="height"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T MinHeight<T>(this T element, double height) where T : FrameworkElement
    {
        element.MinHeight = height;
        return element;
    }

    /// <summary>
    /// Sets the maximum width constraint of a FrameworkElement. The default is **PositiveInfinity**.
    /// This value can be any value equal to or greater than 0. PositiveInfinity is also valid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="width"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T MaxWidth<T>(this T element, double width) where T : FrameworkElement
    {
        element.MaxWidth = width;
        return element;
    }

    /// <summary>
    /// Sets the maximum height constraint of a FrameworkElement. The default value is **PositiveInfinity**.
    /// This value can be any value equal to or greater than 0. PositiveInfinity is also valid.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="height"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T MaxHeight<T>(this T element, double height) where T : FrameworkElement
    {
        element.MaxHeight = height;
        return element;
    }

    /// <summary>
    /// Sets the outer margin of a FrameworkElement.The default value is a default Thickness
    /// with all properties (dimensions) equal to 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="margin"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Margin<T>(this T element, Thickness margin) where T : FrameworkElement
    {
        element.Margin = margin;
        return element;
    }

    /// <summary>
    /// Sets localization/globalization language information that applies to
    /// a FrameworkElement, and also to all child elements of the current FrameworkElement
    /// in the object representation and in UI.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="language"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Language<T>(this T element, string language) where T : FrameworkElement
    {
        element.Language = language;
        return element;
    }

    /// <summary>
    /// Sets the horizontal alignment characteristics that are applied to a FrameworkElement
    /// when it is composed in a layout parent, such as a panel or items control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="horizontalAlignment"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T HorizontalAlignment<T>(this T element, HorizontalAlignment horizontalAlignment) where T : FrameworkElement
    {
        element.HorizontalAlignment = horizontalAlignment;
        return element;
    }

    /// <summary>
    /// Sets the suggested height of a FrameworkElement. The default is NaN. Except for the special
    /// NaN value, this value must be equal to or greater than 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="height"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Height<T>(this T element, double height) where T : FrameworkElement
    {
        element.Height = height;
        return element;
    }

    /// <summary>
    /// Sets the direction in which text and other UI elements flow within any
    /// parent element that controls their layout. This property can be set to either
    /// <see cref="FlowDirection.LeftToRight"/> or <see cref="FlowDirection.RightToLeft"/>. Setting FlowDirection to <see cref="FlowDirection.RightToLeft"/>
    /// on any element sets the alignment to the right, the reading order to right-to-left
    /// and the layout of the control to flow from right to left. The default is <see cref="FlowDirection.LeftToRight"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="flowDirection"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T FlowDirection<T>(this T element, FlowDirection flowDirection) where T : FrameworkElement
    {
        element.FlowDirection = flowDirection;
        return element;
    }

    /// <summary>
    /// Sets the data context for a FrameworkElement. A common use of a data
    /// context is when a **FrameworkElement** uses the {Binding} markup extension and
    /// participates in data binding.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="dataContext"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T DataContext<T>(this T element, object dataContext) where T : FrameworkElement
    {
        element.DataContext = dataContext;
        return element;
    }

    /// <summary>
    /// Sets the UI theme that is used by the <see cref="UIElement"/> (and its child elements)
    /// for resource determination. The UI theme you specify with RequestedTheme can
    /// override the app-level RequestedTheme.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="requestedTheme"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T RequestedTheme<T>(this T element, ElementTheme requestedTheme) where T : FrameworkElement
    {
        element.RequestedTheme = requestedTheme;
        return element;
    }

    /// <summary>
    /// Sets the thickness of the inner border of a HighVisibility focus visual for a FrameworkElement.
    /// The default is 1.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="focusVisualSecondaryThickness"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T FocusVisualSecondaryThickness<T>(this T element, Thickness focusVisualSecondaryThickness) where T : FrameworkElement
    {
        element.FocusVisualSecondaryThickness = focusVisualSecondaryThickness;
        return element;
    }

    /// <summary>
    /// Sets the brush used to draw the inner border of a HighVisibility focus visual for a FrameworkElement.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="focusVisualSecondaryBrush"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T FocusVisualSecondaryBrush<T>(this T element, Brush focusVisualSecondaryBrush) where T : FrameworkElement
    {
        element.FocusVisualSecondaryBrush = focusVisualSecondaryBrush;
        return element;
    }

    /// <summary>
    /// Sets the thickness of the outer border of a HighVisibility focus visual for a FrameworkElement.
    /// The default is 2.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="focusVisualPrimaryThickness"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T FocusVisualPrimaryThickness<T>(this T element, Thickness focusVisualPrimaryThickness) where T : FrameworkElement
    {
        element.FocusVisualPrimaryThickness = focusVisualPrimaryThickness;
        return element;
    }

    /// <summary>
    /// Sets the brush used to draw the outer border of a HighVisibility focus visual for a FrameworkElement.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="focusVisualPrimaryBrush"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T FocusVisualPrimaryBrush<T>(this T element, Brush focusVisualPrimaryBrush) where T : FrameworkElement
    {
        element.FocusVisualPrimaryBrush = focusVisualPrimaryBrush;
        return element;
    }

    /// <summary>
    /// Sets the outer margin of the focus visual for a FrameworkElement. The default value is a default
    /// Thickness with all properties (dimensions) equal to 0.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="focusVisualMargin"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T FocusVisualMargin<T>(this T element, Thickness focusVisualMargin) where T : FrameworkElement
    {
        element.FocusVisualMargin = focusVisualMargin;
        return element;
    }

    /// <summary>
    /// Sets whether a disabled control can receive focus.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="allowFocusWhenDisabled"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T AllowFocusWhenDisabled<T>(this T element, bool allowFocusWhenDisabled) where T : FrameworkElement
    {
        element.AllowFocusWhenDisabled = allowFocusWhenDisabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the element automatically gets focus
    /// when the user interacts with it.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="allowFocusOnInteraction"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T AllowFocusOnInteraction<T>(this T element, bool allowFocusOnInteraction) where T : FrameworkElement
    {
        element.AllowFocusOnInteraction = allowFocusOnInteraction;

        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the vertical and horizontal alignment characteristics that are applied to a FrameworkElement
    /// when it is composed in a parent object such as a panel or items control. The default vertical and horizontal
    /// value is **Stretch**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="verticalAlignment"></param>
    /// <param name="horizontalAlignment"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Alignment<T>(this T element, VerticalAlignment verticalAlignment = Windows.UI.Xaml.VerticalAlignment.Stretch, HorizontalAlignment horizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Stretch) where T : FrameworkElement
    {
        element.VerticalAlignment = verticalAlignment;
        element.HorizontalAlignment = horizontalAlignment;
        return element;
    }

    /// <summary>
    /// Sets the vertical and horizontal alignment tuple characteristics that are applied to a FrameworkElement
    /// when it is composed in a parent object such as a panel or items control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="alignment"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Alignment<T>(this T element, (VerticalAlignment vertical, HorizontalAlignment horizontal) alignment) where T : FrameworkElement
    {
        element.VerticalAlignment = alignment.vertical;
        element.HorizontalAlignment = alignment.horizontal;
        return element;
    }

    /// <summary>
    /// Sets the outer margin of a FrameworkElement.The default value is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="margin"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Margin<T>(this T element, double margin = 0) where T : FrameworkElement
    {
        element.Margin = new Thickness(margin);
        return element;
    }

    /// <summary>
    /// Sets the outer margin of a FrameworkElement.The default value is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Margin<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : FrameworkElement
    {
        element.Margin = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets the outer margin of a FrameworkElement.The default value is horizontal: 0, vertical: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Margin<T>(this T element, double horizontal = 0, double vertical = 0) where T : FrameworkElement
    {
        element.Margin = new Thickness(horizontal, vertical, horizontal, vertical);
        return element;
    }

    /// <summary>
    /// Sets the value of the Grid.Row XAML attached property on the specified FrameworkElement. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element">The target element on which to set the Grid.Row XAML attached property.</param>
    /// <param name="row">The property value to set</param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Row<T>(this T element, int row) where T : FrameworkElement
    {
        Grid.SetRow(element, row);
        return element;
    }

    /// <summary>
    /// Sets the value of the Grid.Column XAML attached property on the specified FrameworkElement.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element">The target element on which to set the Grid.Column XAML attached property.</param>
    /// <param name="column">The property value to set.</param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T Column<T>(this T element, int column) where T : FrameworkElement
    {
        Grid.SetColumn(element, column);
        return element;
    }

    /// <summary>
    /// Sets the value of the Grid.RowSpan XAML attached property on the specified FrameworkElement.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element">The target element on which to set the Grid.RowSpan XAML attached property.</param>
    /// <param name="rowSpan">The property value to set.</param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T RowSpan<T>(this T element, int rowSpan) where T : FrameworkElement
    {
        Grid.SetRowSpan(element, rowSpan);
        return element;
    }

    /// <summary>
    /// Sets the value of the Grid.ColumnSpan XAML attached property on the specified FrameworkElement.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element">The element on which to set the Grid.ColumnSpan XAML attached property.</param>
    /// <param name="columnSpan">The property value to set.</param>
    /// <returns>The <see cref="FrameworkElement"/> instance for method chaining</returns>
    public static T ColumnSpan<T>(this T element, int columnSpan) where T : FrameworkElement
    {
        Grid.SetColumnSpan(element, columnSpan);
        return element;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
