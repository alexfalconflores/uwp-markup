using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for configuring a <see cref="PaneThemeTransition"/> in XAML markup.
/// </summary>
public static class PaneThemeTransitionMarkup
{
    /// <summary>
    /// sets the edge position to use for the transition.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="edge"></param>
    /// <returns>The <see cref="PaneThemeTransition"/> instance for method chaining</returns>
    public static PaneThemeTransition Edge(this PaneThemeTransition transition, EdgeTransitionLocation edge)
    {
        transition.Edge = edge;
        return transition;
    }
}
