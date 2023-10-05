using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for configuring a <see cref="EntranceThemeTransition"/> in XAML markup.
/// </summary>
public static class EntranceThemeTransitionMarkup
{
    /// <summary>
    /// Sets a value that determines whether the transition staggers rendering
    /// of multiple items, or renders all items at once.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="isStaggeringEnabled"></param>
    /// <returns>The <see cref="EntranceThemeTransition"/> instance for method chaining</returns>
    public static EntranceThemeTransition IsStaggeringEnabled(this EntranceThemeTransition transition, bool isStaggeringEnabled)
    {
        transition.IsStaggeringEnabled = isStaggeringEnabled;
        return transition;
    }

    /// <summary>
    /// Sets the distance by which the target is translated in the vertical direction when the animation is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="fromVerticalOffset"></param>
    /// <returns>The <see cref="EntranceThemeTransition"/> instance for method chaining</returns>
    public static EntranceThemeTransition FromVerticalOffset(this EntranceThemeTransition transition, double fromVerticalOffset)
    {
        transition.FromVerticalOffset = fromVerticalOffset;
        return transition;
    }

    /// <summary>
    /// Sets the distance by which the target is translated in the horizontal direction when the animation is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="fromHorizontalOffset"></param>
    /// <returns>The <see cref="EntranceThemeTransition"/> instance for method chaining</returns>
    public static EntranceThemeTransition FromHorizontalOffset(this EntranceThemeTransition transition, double fromHorizontalOffset)
    {
        transition.FromHorizontalOffset = fromHorizontalOffset;
        return transition;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the distance by which the target is translated in the vertical direction and horizontal direction when the animation is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="fromVerticalOffset"></param>
    /// <param name="fromHorizontalOffset"></param>
    /// <returns>The <see cref="EntranceThemeTransition"/> instance for method chaining</returns>
    public static EntranceThemeTransition FromOffset(this EntranceThemeTransition transition, double fromVerticalOffset, double fromHorizontalOffset)
    {
        transition.FromVerticalOffset = fromVerticalOffset;
        transition.FromHorizontalOffset = fromHorizontalOffset;
        return transition;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
