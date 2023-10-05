using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Provides a set of static methods for creating <see cref="ScrollViewer"/> instances with fluent syntax.
/// </summary>
public static class ScrollViewerMarkup
{
    /// <summary>
    /// Sets a value that indicates whether the scroll rail is enabled for the vertical axis.
    /// The default is **true**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isVerticalRailEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsVerticalRailEnabled(this ScrollViewer element, bool isVerticalRailEnabled)
    {
        element.IsVerticalRailEnabled = isVerticalRailEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether scroll actions should include inertia in their behavior and value.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isScrollInertiaEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer element, bool isScrollInertiaEnabled)
    {
        element.IsScrollInertiaEnabled = isScrollInertiaEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether scroll chaining is enabled from this
    /// child to its parent, for the horizontal axis.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isHorizontalScrollChainingEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsHorizontalScrollChainingEnabled(this ScrollViewer element, bool isHorizontalScrollChainingEnabled)
    {
        element.IsHorizontalScrollChainingEnabled = isHorizontalScrollChainingEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the scroll rail is enabled for the
    /// horizontal axis. The default is **true**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isHorizontalRailEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsHorizontalRailEnabled(this ScrollViewer element, bool isHorizontalRailEnabled)
    {
        element.IsHorizontalRailEnabled = isHorizontalRailEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that determines the deferred scrolling behavior for a ScrollViewer.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isDeferredScrollingEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer element, bool isDeferredScrollingEnabled)
    {
        element.IsDeferredScrollingEnabled = isDeferredScrollingEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that declares how manipulation behavior reacts to the snap
    /// points along the horizontal axis. The default is **None** but might be set through a control template.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalSnapPointsType"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer element, SnapPointsType horizontalSnapPointsType)
    {
        element.HorizontalSnapPointsType = horizontalSnapPointsType;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how the existing snap points are horizontally
    /// aligned versus the initial viewport.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalSnapPointsAlignment"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer element, SnapPointsAlignment horizontalSnapPointsAlignment)
    {
        element.HorizontalSnapPointsAlignment = horizontalSnapPointsAlignment;
        return element;
    }

    /// <summary>
    /// Sets a value that determines how manipulation input influences scrolling
    /// behavior on the horizontal axis. The typical default (as set through the default template,
    /// not class initialization) is **Enabled**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalScrollMode"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer HorizontalScrollMode(this ScrollViewer element, ScrollMode horizontalScrollMode)
    {
        element.HorizontalScrollMode = horizontalScrollMode;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether a horizontal ScrollBar should be displayed.
    /// The default value is **Disabled**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalScrollBarVisibility"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer element, ScrollBarVisibility horizontalScrollBarVisibility)
    {
        element.HorizontalScrollBarVisibility = horizontalScrollBarVisibility;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the minimum permitted run-time value of ZoomFactor.
    /// The default is 0.1.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="minZoomFactor"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer MinZoomFactor(this ScrollViewer element, float minZoomFactor)
    {
        element.MinZoomFactor = minZoomFactor;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the maximum permitted run-time value of ZoomFactor.
    /// The default is 10.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="maxZoomFactor"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer MaxZoomFactor(this ScrollViewer element, float maxZoomFactor)
    {
        element.MaxZoomFactor = maxZoomFactor;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether zoom actions should include inertia
    /// in their behavior and value.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isZoomInertiaEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsZoomInertiaEnabled(this ScrollViewer element, bool isZoomInertiaEnabled)
    {
        element.IsZoomInertiaEnabled = isZoomInertiaEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether zoom chaining is enabled from this child to its parent.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isZoomChainingEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsZoomChainingEnabled(this ScrollViewer element, bool isZoomChainingEnabled)
    {
        element.IsZoomChainingEnabled = isZoomChainingEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether scroll chaining is enabled from this
    /// child to its parent, for the vertical axis.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isVerticalScrollChainingEnabled"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer IsVerticalScrollChainingEnabled(this ScrollViewer element, bool isVerticalScrollChainingEnabled)
    {
        element.IsVerticalScrollChainingEnabled = isVerticalScrollChainingEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether the ScrollViewer uses a bring-into-view
    /// scroll behavior when an item in the view gets focus. The default is **true**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="bringIntoViewOnFocusChange"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer element, bool bringIntoViewOnFocusChange)
    {
        element.BringIntoViewOnFocusChange = bringIntoViewOnFocusChange;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how zoom snap points are processed for interaction input.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="zoomSnapPointsType"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer ZoomSnapPointsType(this ScrollViewer element, SnapPointsType zoomSnapPointsType)
    {
        element.ZoomSnapPointsType = zoomSnapPointsType;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether zoom behavior in the ScrollViewer content is enabled.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="zoomMode"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer ZoomMode(this ScrollViewer element, ZoomMode zoomMode)
    {
        element.ZoomMode = zoomMode;
        return element;
    }

    /// <summary>
    /// Sets a value that declares how manipulation behavior reacts to the snap points along the vertical axis.
    /// The default is **None** but might be set through a control template.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalSnapPointsType"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer VerticalSnapPointsType(this ScrollViewer element, SnapPointsType verticalSnapPointsType)
    {
        element.VerticalSnapPointsType = verticalSnapPointsType;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how the existing snap points are vertically
    /// aligned versus the initial viewport.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalSnapPointsAlignment"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer element, SnapPointsAlignment verticalSnapPointsAlignment)
    {
        element.VerticalSnapPointsAlignment = verticalSnapPointsAlignment;
        return element;
    }

    /// <summary>
    /// Sets a value that determines how manipulation input influences scrolling
    /// behavior on the vertical axis. The typical default (as set through the default template,
    /// not class initialization) is **Enabled**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalScrollMode"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer VerticalScrollMode(this ScrollViewer element, ScrollMode verticalScrollMode)
    {
        element.VerticalScrollMode = verticalScrollMode;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether a vertical ScrollBar should be displayed.
    /// The default value is **Visible**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalScrollBarVisibility"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer element, ScrollBarVisibility verticalScrollBarVisibility)
    {
        element.VerticalScrollBarVisibility = verticalScrollBarVisibility;
        return element;
    }

    /// <summary>
    /// Sets the content of the top, left header.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="topLeftHeader"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer TopLeftHeader(this ScrollViewer element, UIElement topLeftHeader)
    {
        element.TopLeftHeader = topLeftHeader;
        return element;
    }

    /// <summary>
    /// Sets the content of the top header.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="topHeader"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer TopHeader(this ScrollViewer element, UIElement topHeader)
    {
        element.TopHeader = topHeader;
        return element;
    }

    /// <summary>
    /// Sets the content of the left header.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="leftHeader"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer LeftHeader(this ScrollViewer element, UIElement leftHeader)
    {
        element.LeftHeader = leftHeader;
        return element;
    }

    /// <summary>
    /// Determines the vertical position of the ScrollViewer's *anchor point* with respect
    /// to the viewport. By default, the ScrollViewer selects an element as its CurrentAnchor
    /// by identifying the element in its viewport nearest to the anchor point.
    /// A normalized value (0.0 to 1.0). The default is 0.0.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="verticalAnchorRatio"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer VerticalAnchorRatio(this ScrollViewer element, double verticalAnchorRatio)
    {
        element.VerticalAnchorRatio = verticalAnchorRatio;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the ScrollViewer should try to adjust
    /// its content to keep it visible when a docked CoreInputView occludes part of it.
    /// The default is **false**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="reduceViewportForCoreInputViewOcclusions"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer ReduceViewportForCoreInputViewOcclusions(this ScrollViewer element, bool reduceViewportForCoreInputViewOcclusions)
    {
        element.ReduceViewportForCoreInputViewOcclusions = reduceViewportForCoreInputViewOcclusions;
        return element;
    }

    /// <summary>
    /// Determines the horizontal position of the ScrollViewer's *anchor point* with
    ///     respect to the viewport. By default, the ScrollViewer selects an element as its
    ///     CurrentAnchor by identifying the element in its viewport nearest to the anchor
    ///     point. A normalized value (0.0 to 1.0). The default is 0.0.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontalAnchorRatio"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer HorizontalAnchorRatio(this ScrollViewer element, double horizontalAnchorRatio)
    {
        element.HorizontalAnchorRatio = horizontalAnchorRatio;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether scrolled content can render outside the bounds of the ScrollViewer.
    /// The default is **false**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="canContentRenderOutsideBounds"></param>
    /// <returns>The <see cref="ScrollViewer"/> instance for method chaining</returns>
    public static ScrollViewer CanContentRenderOutsideBounds(this ScrollViewer element, bool canContentRenderOutsideBounds)
    {
        element.CanContentRenderOutsideBounds = canContentRenderOutsideBounds;
        return element;
    }
}
