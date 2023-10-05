using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UWP.Markup;

/// <summary>
/// Represents content that a Frame control can navigate to.
/// </summary>
public static class PageMarkup
{
    /// <summary>
    /// Sets a reference to an AppBar displayed at the top of the page, if any.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="appBar"></param>
    /// <returns>The <see cref="Page"/> instance for method chaining</returns>
    public static T TopAppBar<T>(this T element, AppBar appBar) where T : Page
    {
        element.TopAppBar = appBar;
        return element;
    }

    /// <summary>
    /// Sets the navigation mode that indicates whether this Page is cached,
    /// and the period of time that the cache entry should persist. The default is **Disabled**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="navigationCacheMode"></param>
    /// <returns>The <see cref="Page"/> instance for method chaining</returns>
    public static T NavigationCacheMode<T>(this T element, NavigationCacheMode navigationCacheMode) where T : Page
    {
        element.NavigationCacheMode = navigationCacheMode;
        return element;
    }

    /// <summary>
    /// Sets a reference to an AppBar displayed at the bottom of the page, if any.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="appBar"></param>
    /// <returns></returns>
    public static T BottomAppBar<T>(this T element, AppBar appBar) where T : Page
    {
        element.BottomAppBar = appBar;
        return element;
    }
}
