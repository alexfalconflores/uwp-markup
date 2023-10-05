using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for configuring a <see cref="NavigationThemeTransition"/> in XAML markup.
/// </summary>
public static class NavigationThemeTransitionMarkup
{
    /// <summary>
    /// Sets the default transition used when navigating between pages.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="navigationTransitionInfo"></param>
    /// <returns>The <see cref="NavigationThemeTransition"/> instance for method chaining</returns>
    public static NavigationThemeTransition DefaultNavigationTransitionInfo(this NavigationThemeTransition transition, NavigationTransitionInfo navigationTransitionInfo)
    {
        transition.DefaultNavigationTransitionInfo = navigationTransitionInfo;
        return transition;
    }
}
