using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI;
using Windows.UI.Xaml.Controls;

namespace UWP.Markup;

/// <summary>
/// Provides a set of static methods for creating instances of <see cref="Panel"/> derived classes
/// </summary>
public static class PanelMarkup
{
    /// <summary>
    /// Sets the collection of Transition style elements that apply to child
    /// content of a Panel subclass.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transitions"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T ChildrenTransitions<T>(this T element, TransitionCollection transitions) where T : Panel
    {
        element.ChildrenTransitions = transitions;
        return element;
    }

    /// <summary>
    /// Sets a Brush that fills the panel content area
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T Background<T>(this T element, Brush brush) where T : Panel
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
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="brushTransition"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T BackgroundTransition<T>(this T element, BrushTransition brushTransition) where T : Panel
    {
        element.BackgroundTransition = brushTransition;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets a Brush that fills the panel content area
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T Background<T>(this T element, Color colors) where T : Panel
    {
        element.Background = new SolidColorBrush(colors);
        return element;
    }

    /// <summary>
    /// Add items as a params array of UIElement to the Children collection of the Panel.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="items"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T AddChildren<T>(T element, params UIElement[] items) where T : Panel
    {
        foreach (var item in items)
            element.AddChild(item);
        return element;
    }

    /// <summary>
    /// Add a item to the Children collection of the Panel.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="item"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T AddChild<T>(this T element, UIElement item) where T : Panel
    {
        element.Children.Add(item);
        return element;
    }

    /// <summary>
    /// Try to add items as a params array of UIElement to the Children collection of the Panel.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="items"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T TryAddChildren<T>(T element, params UIElement[] items) where T : Panel
    {
        foreach (var item in items)
            element.TryAddChild(item);
        return element;
    }

    /// <summary>
    /// Try to add a item to the Children collection of the Panel.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="item"></param>
    /// <returns>The <see cref="Panel"/> instance for method chaining</returns>
    public static T TryAddChild<T>(this T element, UIElement item) where T : Panel
    {
        if (item != null) element.Children.Add(item);
        return element;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
