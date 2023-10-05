using Windows.Foundation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Provides extension methods for configuring a <see cref="ToolTip"/> in XAML markup.
/// </summary>
public static class ToolTipMarkup
{
    /// <summary>
    /// Sets the vertical distance between the target origin and the pop-up alignment point.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalOffset"></param>
    /// <returns>The <see cref="ToolTip"/> instance for method chaining</returns>
    public static ToolTip VerticalOffset(this ToolTip element, double verticalOffset)
    {
        element.VerticalOffset = verticalOffset;
        return element;
    }

    /// <summary>
    /// Sets the visual element or control that the tool tip should be positioned
    /// in relation to when opened by the <see cref="ToolTipService"/>.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="placementTarget"></param>
    /// <returns>The <see cref="ToolTip"/> instance for method chaining</returns>
    public static ToolTip PlacementTarget(this ToolTip element, UIElement placementTarget)
    {
        element.PlacementTarget = placementTarget;
        return element;
    }

    /// <summary>
    /// Sets how a <see cref="ToolTip"/> is positioned in relation to the placement target element.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="placementMode"></param>
    /// <returns>The <see cref="ToolTip"/> instance for method chaining</returns>
    public static ToolTip Placement(this ToolTip element, PlacementMode placementMode)
    {
        element.Placement = placementMode;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the <see cref="ToolTip"/> is visible.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isOpen"></param>
    /// <returns>The <see cref="ToolTip"/> instance for method chaining</returns>
    public static ToolTip IsOpen(this ToolTip element, bool isOpen)
    {
        element.IsOpen = isOpen;
        return element;
    }

    /// <summary>
    /// Sets the horizontal distance between the target origin and the pop-up alignment point.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalOffset"></param>
    /// <returns>The <see cref="ToolTip"/> instance for method chaining</returns>
    public static ToolTip HorizontalOffset(this ToolTip element, double horizontalOffset)
    {
        element.HorizontalOffset = horizontalOffset;
        return element;
    }

    /// <summary>
    /// Sets the rectangular area that the <see cref="ToolTip"/> should be positioned in relation
    /// to when opened by the <see cref="ToolTipService"/>. If space allows, the open <see cref="ToolTip"/> will
    /// not occlude the area defined by its PlacementRect.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="placementRect"></param>
    /// <returns>The <see cref="ToolTip"/> instance for method chaining</returns>
    public static ToolTip PlacementRect(this ToolTip element, Rect? placementRect)
    {
        element.PlacementRect = placementRect;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the Horizontal and Vertical distance between the target origin and the pop-up alignment point.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalOffset"></param>
    /// <param name="verticalOffset"></param>
    /// <returns>The <see cref="ToolTip"/> instance for method chaining</returns>
    public static ToolTip Offset(this ToolTip element, double horizontalOffset, double verticalOffset)
    {
        element.HorizontalOffset = horizontalOffset;
        element.VerticalOffset = verticalOffset;
        return element;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
