using System.Windows.Input;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace UWP.Markup;

/// <summary>
/// An InfoBar is an inline notification for essential app-wide messages. The InfoBar
/// will take up space in a layout and will not cover up other content or float on
/// top of it. It supports rich content (including titles, messages, icons, and buttons)
/// and can be configured to be user-dismissable or persistent.
/// </summary>
public static class InfoBarMarkup
{
    /// <summary>
    /// Sets the title of the InfoBar.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Element"></param>
    /// <param name="title"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified Title. </returns>
    public static T Title<T>(this T Element, string title) where T : InfoBar
    {
        Element.Title = title;
        return Element;
    }

    /// <summary>
    /// Sets the type of the InfoBar to apply consistent status color, icon,
    /// and assistive technology settings dependent on the criticality of the notification.
    /// The default is Informational
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="severity"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified Severity. </returns>
    public static T Severity<T>(this T element, InfoBarSeverity severity) where T : InfoBar
    {
        element.Severity = severity;
        return element;
    }

    /// <summary>
    /// Sets the message of the InfoBar.
    /// The default is an empty string.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="message"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified Message. </returns>
    public static T Message<T>(this T element, string message) where T : InfoBar
    {
        element.Message = message;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the InfoBar is open.
    /// The default is false.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isOpen"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified IsOpen. </returns>
    public static T IsOpen<T>(this T element, bool isOpen) where T : InfoBar
    {
        element.IsOpen = isOpen;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the icon is visible in the InfoBar.
    /// The default is true.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isVisible"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified IsIconVisible. </returns>
    public static T IsIconVisible<T>(this T element, bool isVisible) where T : InfoBar
    {
        element.IsIconVisible = isVisible;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the user can close the InfoBar.
    /// The default is true.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isClosable"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified IsClosable. </returns>
    public static T IsClosable<T>(this T element, bool isClosable) where T : InfoBar
    {
        element.IsClosable = isClosable;
        return element;
    }

    /// <summary>
    /// sets the graphic content to appear alongside the title and message in the InfoBar.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="iconSource"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified IconSource. </returns>
    public static T IconSource<T>(this T element, IconSource iconSource) where T : InfoBar
    {
        element.IconSource = iconSource;
        return element;
    }

    /// <summary>
    /// Sets the data template for the InfoBar.Content".
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="contentTemplate"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified ContentTemplate. </returns>
    public static T ContentTemplate<T>(this T element, DataTemplate contentTemplate) where T : InfoBar
    {
        element.ContentTemplate = contentTemplate;
        return element;
    }

    /// <summary>
    /// Sets the XAML Content that is displayed below the title and message in the InfoBar.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="content"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified Content. </returns>
    public static T Content<T>(this T element, object content) where T : InfoBar
    {
        element.Content = content;
        return element;
    }

    /// <summary>
    /// Sets the Style to apply to the close button in the InfoBar.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="closeButtonStyle"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified CloseButtonStyle. </returns>
    public static T CloseButtonStyle<T>(this T element, Style closeButtonStyle) where T : InfoBar
    {
        element.CloseButtonStyle = closeButtonStyle;
        return element;
    }

    /// <summary>
    /// Sets the parameter to pass to the command for the close button in the InfoBar.
    /// The default is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="closeButtonCommandParameter"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified CloseButtonCommandParameter. </returns>
    public static T CloseButtonCommandParameter<T>(this T element, object closeButtonCommandParameter) where T : InfoBar
    {
        element.CloseButtonCommandParameter = closeButtonCommandParameter;
        return element;
    }

    /// <summary>
    /// Sets the command to invoke when the close button is clicked in the InfoBar.
    /// The default is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="closeButtonCommand"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified CloseButtonCommand. </returns>
    public static T CloseButtonCommand<T>(this T element, ICommand closeButtonCommand) where T : InfoBar
    {
        element.CloseButtonCommand = closeButtonCommand;
        return element;
    }

    /// <summary>
    /// Sets the action button of the InfoBar.
    /// The default is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="actionButton"></param>
    /// <returns>The modified <see cref="InfoBar"/> with the specified ActionButton. </returns>
    public static T ActionButton<T>(this T element, ButtonBase actionButton) where T : InfoBar
    {
        element.ActionButton = actionButton;
        return element;
    }
}
