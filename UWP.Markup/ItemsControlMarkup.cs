using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Represents a control that can be used to present a collection of items.
/// </summary>
public static class ItemsControlMarkup
{
    /// <summary>
    /// Sets an object source used to generate the content of the ItemsControl.
    /// The default value is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="itemsSource"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T ItemsSource<T>(this T element, object itemsSource) where T : ItemsControl
    {
        element.ItemsSource = itemsSource;
        return element;
    }

    /// <summary>
    /// Sets the template that defines the panel that controls the layout of items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="itemsPanel"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T ItemsPanel<T>(this T element, ItemsPanelTemplate itemsPanel) where T : ItemsControl
    {
        element.ItemsPanel = itemsPanel;
        return element;
    }

    /// <summary>
    /// Sets a reference to a custom DataTemplateSelector logic class. The DataTemplateSelector
    /// referenced by this property returns a template to apply to items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="dataTemplateSelector"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T ItemTemplateSelector<T>(this T element, DataTemplateSelector dataTemplateSelector) where T : ItemsControl
    {
        element.ItemTemplateSelector = dataTemplateSelector;
        return element;
    }

    /// <summary>
    /// Sets the DataTemplate used to display each item.
    /// The default value is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="dataTemplate"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T ItemTemplate<T>(this T element, DataTemplate dataTemplate) where T : ItemsControl
    {
        element.ItemTemplate = dataTemplate;
        return element;
    }

    /// <summary>
    /// Sets the collection of Transition style elements that apply to the item
    /// containers of an ItemsControl.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transitions"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T ItemContainerTransitions<T>(this T element, TransitionCollection transitions) where T : ItemsControl
    {
        element.ItemContainerTransitions = transitions;
        return element;
    }

    /// <summary>
    /// Sets a reference to a custom StyleSelector logic class. The StyleSelector
    /// returns different Style values to use for the item container based on characteristics
    /// of the object being displayed.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="styleSelector"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T ItemContainerStyleSelector<T>(this T element, StyleSelector styleSelector) where T : ItemsControl
    {
        element.ItemContainerStyleSelector = styleSelector;
        return element;
    }

    /// <summary>
    /// Sets the style that is used when rendering the item containers.
    /// The default value is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="style"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T ItemContainerStyle<T>(this T element, Style style) where T : ItemsControl
    {
        element.ItemContainerStyle = style;
        return element;
    }

    /// <summary>
    /// Sets a reference to a custom GroupStyleSelector logic class. The GroupStyleSelector
    /// returns different GroupStyle values to use for content based on the characteristics
    /// of that content.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="groupStyleSelector"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T GroupStyleSelector<T>(this T element, GroupStyleSelector groupStyleSelector) where T : ItemsControl
    {
        element.GroupStyleSelector = groupStyleSelector;
        return element;
    }

    /// <summary>
    /// Sets the name or path of the property that is displayed for each data item.
    /// The default is an empty string ("").
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="propertyName"></param>
    /// <returns>The <see cref="ItemsControl"/> instance for method chaining</returns>
    public static T DisplayMemberPath<T>(this T element, string propertyName) where T : ItemsControl
    {
        element.DisplayMemberPath = propertyName;
        return element;
    }
}
