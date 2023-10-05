using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for configuring a <see cref="ContentThemeTransition"/> in XAML markup.
/// </summary>
public static class ContentThemeTransitionMarkup
{
    /// <summary>
    /// Sets the distance by which the target is translated in the vertical direction
    /// when the transition is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="offset"></param>
    /// <returns>The <see cref="ContentThemeTransition"/> instance for method chaining</returns>
    public static ContentThemeTransition VerticalOffset(this ContentThemeTransition transition, double offset)
    {
        transition.VerticalOffset = offset;
        return transition;
    }

    /// <summary>
    /// Sets the distance by which the target is translated in the horizontal
    /// direction when the transition is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="offset"></param>
    /// <returns>The <see cref="ContentThemeTransition"/> instance for method chaining</returns>
    public static ContentThemeTransition HorizontalOffset(this ContentThemeTransition transition, double offset)
    {
        transition.HorizontalOffset = offset;
        return transition;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1

    /// <summary>
    /// Sets the distance by which the target is translated in the vertical direction and the horizontal direction when the transition is active.
    /// </summary>
    /// <param name="transition"></param>
    /// <param name="horizontalOffset"></param>
    /// <param name="verticalOffset"></param>
    /// <returns>The <see cref="ContentThemeTransition"/> instance for method chaining</returns>
    public static ContentThemeTransition Offset(this ContentThemeTransition transition, double horizontalOffset, double verticalOffset)
    {
        transition.HorizontalOffset = horizontalOffset;
        transition.VerticalOffset = verticalOffset;
        return transition;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
