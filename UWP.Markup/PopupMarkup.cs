using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Provides extension methods for configuring a <see cref="Popup"/> in XAML markup.
/// </summary>
public static class PopupMarkup
{
    /// <summary>
    /// Sets the distance between the top of the application window and the top of the popup.
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="offset"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup VerticalOffset(this Popup popup, double offset)
    {
        popup.VerticalOffset = offset;
        return popup;
    }

    /// <summary>
    /// Sets whether the popup is currently displayed on the screen. The default is **false**.
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="isOpen"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup IsOpen(this Popup popup, bool isOpen)
    {
        popup.IsOpen = isOpen;
        return popup;
    }

    /// <summary>
    /// Sets a value that determines how the Popup can be dismissed.
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="isLightDismissEnabled"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup IsLightDismissEnabled(this Popup popup, bool isLightDismissEnabled)
    {
        popup.IsLightDismissEnabled = isLightDismissEnabled;
        return popup;
    }

    /// <summary>
    /// Sets the distance between the left side of the application window and
    /// the left side of the popup.
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="offset"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup HorizontalOffset(this Popup popup, double offset)
    {
        popup.HorizontalOffset = offset;
        return popup;
    }

    /// <summary>
    /// Sets the collection of Transition style elements that apply to child content of a Popup.
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="transitions"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup ChildTransitions(this Popup popup, TransitionCollection transitions)
    {
        popup.ChildTransitions = transitions;
        return popup;
    }

    /// <summary>
    /// Sets the content to be hosted in the popup.
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="uiElement"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup Child(this Popup popup, UIElement uiElement)
    {
        popup.Child = uiElement;
        return popup;
    }

    /// <summary>
    /// Sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="lightDismissOverlayMode"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup LightDismissOverlayMode(this Popup popup, LightDismissOverlayMode lightDismissOverlayMode)
    {
        popup.LightDismissOverlayMode = lightDismissOverlayMode;
        return popup;
    }

    /// <summary>
    /// Sets a value that indicates whether the popup should be shown within
    /// the bounds of the XAML root.
    /// <list type="bullet">
    /// <item> Windows version: 1903, SDK version 18362 </item>
    /// </list>
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="shouldConstrainToRootBounds"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup ShouldConstrainToRootBounds(this Popup popup, bool shouldConstrainToRootBounds)
    {
        popup.ShouldConstrainToRootBounds = shouldConstrainToRootBounds;
        return popup;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the distance between the left side and top side of the application window and
    /// the left side of the popup.
    /// </summary>
    /// <param name="popup"></param>
    /// <param name="offset"></param>
    /// <returns>The <see cref="Popup"/> instance for method chaining</returns>
    public static Popup Offset(this Popup popup, double horizontal = 0, double vertical = 0)
    {
        popup.HorizontalOffset = horizontal;
        popup.VerticalOffset = vertical;
        return popup;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
