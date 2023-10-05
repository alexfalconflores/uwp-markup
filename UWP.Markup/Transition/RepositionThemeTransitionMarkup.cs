using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for configuring a <see cref="RepositionThemeTransition"/> in XAML markup.
/// </summary>
public static class RepositionThemeTransitionMarkup
{
    /// <summary>
    /// Sets a value that determines whether the transition staggers rendering
    /// of multiple items, or renders all items at once. The default is **true**.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="isStaggeringEnabled"></param>
    /// <returns>The <see cref="RepositionThemeTransition"/> instance for method chaining</returns>
    public static RepositionThemeTransition IsStaggeringEnabled(this RepositionThemeTransition transition, bool isStaggeringEnabled)
    {
        transition.IsStaggeringEnabled = isStaggeringEnabled;
        return transition;
    }
}
