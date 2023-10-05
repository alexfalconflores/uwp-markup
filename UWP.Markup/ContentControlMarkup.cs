using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Represents a control with a single piece of content. Controls such as Button,
/// CheckBox, and ScrollViewer directly or indirectly inherit from this class.
/// </summary>
public static class ContentControlMarkup
{
    /// <summary>
    /// Sets the collection of Transition style elements that apply to the content of a ContentControl.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transitionCollection"></param>
    /// <returns>The <see cref="ContentControl"/> instance for method chaining</returns>
    public static T ContentTransitions<T>(this T element, TransitionCollection transitionCollection) where T : ContentControl
    {
        element.ContentTransitions = transitionCollection;
        return element;
    }

    /// <summary>
    /// Sets a selection object that changes the DataTemplate to apply for content,
    /// based on processing information about the content item or its container at run time.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="dataTemplateSelector"></param>
    /// <returns>The <see cref="ContentControl"/> instance for method chaining</returns>
    public static T ContentTemplateSelector<T>(this T element, DataTemplateSelector dataTemplateSelector) where T : ContentControl
    {
        element.ContentTemplateSelector = dataTemplateSelector;
        return element;
    }

    /// <summary>
    /// Sets the data template that is used to display the content of the ContentControl.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="dataTemplate"></param>
    /// <returns>The <see cref="ContentControl"/> instance for method chaining</returns>
    public static T ContentTemplate<T>(this T element, DataTemplate dataTemplate) where T : ContentControl
    {
        element.ContentTemplate = dataTemplate;
        return element;
    }

    /// <summary>
    /// Sets the content of a ContentControl.The default is **null**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="content"></param>
    /// <returns>The <see cref="ContentControl"/> instance for method chaining</returns>
    public static T Content<T>(this T element, object content) where T : ContentControl
    {
        element.Content = content;
        return element;
    }
}
