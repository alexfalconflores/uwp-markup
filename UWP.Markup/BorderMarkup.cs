using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI;

namespace UWP.Markup;

/// <summary>
/// Defines the extension methods for the <see cref="Border"/> class.
/// </summary>
public static class BorderMarkup
{
    /// <summary>
    /// Sets the distance between the border and its child object.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border Padding(this Border element, Thickness thickness)
    {
        element.Padding = thickness;
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the border.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border CornerRadius(this Border element, CornerRadius cornerRadius)
    {
        element.CornerRadius = cornerRadius;
        return element;
    }

    /// <summary>
    /// Sets the collection of Transition style elements that apply to child content of a Border.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="childTransitions"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border ChildTransitions(this Border element, TransitionCollection childTransitions)
    {
        element.ChildTransitions = childTransitions;
        return element;
    }

    /// <summary>
    /// Sets the child element to draw the border around.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="child"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border Child(this Border element, UIElement child)
    {
        element.Child = child;
        return element;
    }

    /// <summary>
    /// Sets the thickness of the border.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BorderThickness(this Border element, Thickness thickness)
    {
        element.BorderThickness = thickness;
        return element;
    }

    /// <summary>
    /// Sets the Brush that is applied to the edge area of the Border.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BorderBrush(this Border element, Brush brush)
    {
        element.BorderBrush = brush;
        return element;
    }

    /// <summary>
    /// Sets the Brush that fills the background (inner area) of the border.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border Background(this Border element, Brush brush)
    {
        element.Background = brush;
        return element;
    }

    /// <summary>
    /// Sets an instance of BrushTransition to automatically animate changes
    /// to the Background property. The default is **null**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="backgroundTransition"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BackgroundTransition(this Border element, BrushTransition backgroundTransition)
    {
        element.BackgroundTransition = backgroundTransition;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how far the background extends in relation
    /// to this element's border. The default is **InnerBorderEdge**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="backgroundSizing"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BackgroundSizing(this Border element, BackgroundSizing backgroundSizing)
    {
        element.BackgroundSizing = backgroundSizing;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the distance between the border and its child object. The default value is 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border Padding(this Border element, double padding = 0)
    {
        element.Padding = new Thickness(padding);
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object. The default value is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border Padding(this Border element, double left = 0, double top = 0, double right = 0, double bottom = 0)
    {
        element.Padding = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object. The default value is horizontal: 0, vertical: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border Padding(this Border element, double horizontal = 0, double vertical = 0)
    {
        element.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the border.
    /// The default is 0.
    /// </summary>  
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border CornerRadius(this Border element, double cornerRadius = 0)
    {
        element.CornerRadius = new CornerRadius(cornerRadius);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the border.
    /// The default is topLeftRight: 0, bottomRightLeft: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="topLeftRight"></param>
    /// <param name="bottomRightLeft"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border CornerRadius(this Border element, double topLeftRight = 0, double bottomRightLeft = 0)
    {
        element.CornerRadius = new CornerRadius(topLeftRight, topLeftRight, bottomRightLeft, bottomRightLeft);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the border.
    /// The default is top-left: 0, top-right: 0, bottom-right: 0, bottom-left: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="topLeft"></param>
    /// <param name="topRight"></param>
    /// <param name="bottomRight"></param>
    /// <param name="bottomLeft"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border CornerRadius(this Border element, double topLeft = 0, double topRight = 0, double bottomRight = 0, double bottomLeft = 0)
    {
        element.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return element;
    }

    /// <summary>
    /// Sets the thickness of the border. The default is 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BorderThickness(this Border element, double thickness = 0)
    {
        element.BorderThickness = new Thickness(thickness);
        return element;
    }

    /// <summary>
    /// Sets the thickness of the border. The default leftRight and topBottom is 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="leftRight"></param>
    /// <param name="topBottom"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BorderThickness(this Border element, double leftRight = 0, double topBottom = 0)
    {
        element.BorderThickness = new Thickness(leftRight, topBottom, leftRight, topBottom);
        return element;
    }

    /// <summary>
    /// Sets the thickness of the border. The default is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BorderThickness(this Border element, double left = 0, double top = 0, double right = 0, double bottom = 0)
    {
        element.BorderThickness = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets the Brush that is applied to the edge area of the Border.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border BorderBrush(this Border element, Color colors)
    {
        element.BorderBrush = new SolidColorBrush(colors);
        return element;
    }

    /// <summary>
    /// Sets the Brush that fills the background (inner area) of the border.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="Border"/> instance for method chaining</returns>
    public static Border Background(this Border element, Color colors)
    {
        element.Background = new SolidColorBrush(colors);
        return element;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
