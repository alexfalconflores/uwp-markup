using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for configuring a <see cref="PopupThemeTransition"/> in XAML markup.
/// </summary>
public static class PopupThemeTransitionMarkup
{
    /// <summary>
    /// Sets the distance by which the target is translated in the horizontal direction when the animation is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="fromVerticalOffset"></param>
    /// <returns>The <see cref="PopupThemeTransition"/> instance for method chaining.</returns>
    public static PopupThemeTransition FromHorizontalOffset(this PopupThemeTransition transition, double fromHorizontalOffset)
    {
        transition.FromHorizontalOffset = fromHorizontalOffset;
        return transition;
    }
    /// <summary>
    /// Sets the distance by which the target is translated in the vertical direction when the animation is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="fromVerticalOffset"></param>
    /// <returns>The <see cref="PopupThemeTransition"/> instance for method chaining.</returns>
    public static PopupThemeTransition FromVerticalOffset(this PopupThemeTransition transition, double fromVerticalOffset)
    {
        transition.FromVerticalOffset = fromVerticalOffset;
        return transition;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1

    /// <summary>
    /// Sets the distance by which the target is translated in the horizontal direction and the vertical direction when the animation is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="fromHorizontalOffset"></param>
    /// <param name="fromVerticalOffset"></param>
    /// <returns>The <see cref="PopupThemeTransition"/> instance for method chaining.</returns>
    public static PopupThemeTransition FromOffset(this PopupThemeTransition transition, double fromHorizontalOffset, double fromVerticalOffset)
    {
        transition.FromHorizontalOffset = fromHorizontalOffset;
        transition.FromVerticalOffset = fromVerticalOffset;
        return transition;
    }

    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
