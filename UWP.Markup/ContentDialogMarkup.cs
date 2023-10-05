using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Represents a dialog box that can be customized to contain checkboxes, hyperlinks,
/// buttons and any other XAML content.
/// </summary>
public static class ContentDialogMarkup
{
    /// <summary>
    /// Sets the title template.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="titleTemplate"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T TitleTemplate<T>(this T element, DataTemplate titleTemplate) where T : ContentDialog
    {
        element.TitleTemplate = titleTemplate;
        return element;
    }

    /// <summary>
    /// Sets the title of the dialog.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="title"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T Title<T>(this T element, object title) where T : ContentDialog
    {
        element.Title = title;
        return element;
    }

    /// <summary>
    /// Sets the text to be displayed on the secondary button.
    /// To hide this button, set the value to **null** or **string.empty**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="secondaryButtonText"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T SecondaryButtonText<T>(this T element, string secondaryButtonText) where T : ContentDialog
    {
        element.SecondaryButtonText = secondaryButtonText;
        return element;
    }

    /// <summary>
    /// Sets the parameter to pass to the command for the secondary button.
    /// The default value is **null**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="secondaryButtonCommandParameter"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T SecondaryButtonCommandParameter<T>(this T element, object secondaryButtonCommandParameter) where T : ContentDialog
    {
        element.SecondaryButtonCommandParameter = secondaryButtonCommandParameter;
        return element;
    }

    /// <summary>
    /// Sets the command to invoke when the secondary button is tapped.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="command"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T SecondaryButtonCommand<T>(this T element, ICommand command) where T : ContentDialog
    {
        element.SecondaryButtonCommand = command;
        return element;
    }

    /// <summary>
    /// Sets the text to display on the primary button.
    /// To hide this button, set the text to **null** or string.empty. The default is empty.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="primaryButtonText"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T PrimaryButtonText<T>(this T element, string primaryButtonText) where T : ContentDialog
    {
        element.PrimaryButtonText = primaryButtonText;
        return element;
    }

    /// <summary>
    /// Sets the parameter to pass to the command for the primary button.
    /// The default is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="primaryButtonCommandParameter"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T PrimaryButtonCommandParameter<T>(this T element, object primaryButtonCommandParameter) where T : ContentDialog
    {
        element.PrimaryButtonCommandParameter = primaryButtonCommandParameter;
        return element;
    }

    /// <summary>
    /// Sets the command to invoke when the primary button is tapped.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="command"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T PrimaryButtonCommand<T>(this T element, ICommand command) where T : ContentDialog
    {
        element.PrimaryButtonCommand = command;
        return element;
    }

    /// <summary>
    /// Sets whether the dialog's secondary button is enabled.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isSecondaryButtonEnabled"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T IsSecondaryButtonEnabled<T>(T element, bool isSecondaryButtonEnabled) where T : ContentDialog
    {
        element.IsSecondaryButtonEnabled = isSecondaryButtonEnabled;
        return element;
    }

    /// <summary>
    /// Sets whether the dialog's primary button is enabled.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isPrimaryButtonEnabled"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T IsPrimaryButtonEnabled<T>(this T element, bool isPrimaryButtonEnabled) where T : ContentDialog
    {
        element.IsPrimaryButtonEnabled = isPrimaryButtonEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether a request is being made to display
    /// the dialog full screen. The default is **false**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fullSizeDesired"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T FullSizeDesired<T>(this T element, bool fullSizeDesired) where T : ContentDialog
    {
        element.FullSizeDesired = fullSizeDesired;
        return element;
    }

    /// <summary>
    /// Sets the Style to apply to the dialog's secondary button.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="secondaryButtonStyleEnabled"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T SecondaryButtonStyle<T>(this T element, Style secondaryButtonStyleEnabled) where T : ContentDialog
    {
        element.SecondaryButtonStyle = secondaryButtonStyleEnabled;
        return element;
    }

    /// <summary>
    /// Sets the Style to apply to the dialog's primary button.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="primaryButtonStyleEnabled"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T PrimaryButtonStyle<T>(this T element, Style primaryButtonStyleEnabled) where T : ContentDialog
    {
        element.PrimaryButtonStyle = primaryButtonStyleEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates which button on the dialog is the default action.
    /// The default is **None.**
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="defaultButton"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T DefaultButton<T>(this T element, ContentDialogButton defaultButton) where T : ContentDialog
    {
        element.DefaultButton = defaultButton;
        return element;
    }

    /// <summary>
    /// Sets the text to display on the close button.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="text"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T CloseButtonText<T>(this T element, string text) where T : ContentDialog
    {
        element.CloseButtonText = text;
        return element;
    }

    /// <summary>
    /// Sets the Style to apply to the dialog's close button.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="style"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T CloseButtonStyle<T>(this T element, Style style) where T : ContentDialog
    {
        element.CloseButtonStyle = style;
        return element;
    }

    /// <summary>
    /// Sets the parameter to pass to the command for the close button.
    /// The default is **null.**
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="commandParameter"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T CloseButtonCommandParameter<T>(this T element, object commandParameter) where T : ContentDialog
    {
        element.CloseButtonCommandParameter = commandParameter;
        return element;
    }

    /// <summary>
    /// Sets the command to invoke when the close button is tapped.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="command"></param>
    /// <returns>The <see cref="ContentDialog"/> instance for method chaining</returns>
    public static T CloseButtonCommand<T>(this T element, ICommand command) where T : ContentDialog
    {
        element.CloseButtonCommand = command;
        return element;
    }
}
