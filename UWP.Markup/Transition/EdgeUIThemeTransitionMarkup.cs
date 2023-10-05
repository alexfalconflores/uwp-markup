using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for configuring a <see cref="EdgeUIThemeTransition"/> in XAML markup.
/// </summary>
public static class EdgeUIThemeTransitionMarkup
{
    /// <summary>
    /// sets the edge position to use for the transition.
    /// The default is **Top**.
    /// </summary>
    /// <param name="edgeUIThemeTransition"></param>
    /// <param name="edgeTransitionLocation"></param>
    /// <returns>The <see cref="EdgeUIThemeTransition"/> instance for method chaining</returns>
    public static EdgeUIThemeTransition Edge(this EdgeUIThemeTransition edgeUIThemeTransition, EdgeTransitionLocation edgeTransitionLocation)
    {
        edgeUIThemeTransition.Edge = edgeTransitionLocation;
        return edgeUIThemeTransition;
    }
}
