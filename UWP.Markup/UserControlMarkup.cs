
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

public static class UserControlMarkup
{
    /// <summary>
    /// Sets the content that is contained within a user control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="content"></param>
    /// <returns>The <see cref="UserControl"/> instance for method chaining</returns>
    public static T Content<T>(this T element, UIElement content) where T : UserControl
    {
        element.Content = content;
        return element;
    }
}
