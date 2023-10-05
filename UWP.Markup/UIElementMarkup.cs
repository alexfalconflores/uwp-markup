using System.Numerics;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Media3D;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;

namespace UWP.Markup;

/// <summary>
/// Provides extension methods for configuring <see cref="UIElement"/> objects in XAML markup.
/// </summary>
public static class UIElementMarkup
{
    /// <summary>
    /// Sets the collection of Transition style elements that apply to a UIElement.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transitions"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Transitions<T>(this T element, TransitionCollection transitions) where T : UIElement
    {
        element.Transitions = transitions;
        return element;
    }

    /// <summary>
    /// Sets the perspective projection (3-D effect) to apply when rendering this element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="projection"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Projection<T>(this T element, Projection projection) where T : UIElement
    {
        element.Projection = projection;
        return element;
    }

    /// <summary>
    /// Sets the origin point of any possible render transform declared by RenderTransform, relative to the bounds of the UIElement.
    /// The default value is a Point with value 0,0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="renderTransformOrigin"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T RenderTransformOrigin<T>(this T element, Point renderTransformOrigin) where T : UIElement
    {
        element.RenderTransformOrigin = renderTransformOrigin;
        return element;
    }

    /// <summary>
    /// Sets the degree of the object's opacity. The default value is 1.0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="opacity"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Opacity<T>(this T element, double opacity) where T : UIElement
    {
        element.Opacity = opacity;
        return element;
    }

    /// <summary>
    /// Sets the ManipulationModes value used for UIElement behavior and interaction
    /// with gestures. Setting this value enables handling the manipulation events from
    /// this element in app code. The default is typically **System**, but this can vary
    /// on specific controls and elements. See Remarks.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="manipulationMode"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T ManipulationMode<T>(this T element, ManipulationModes manipulationMode) where T : UIElement
    {
        element.ManipulationMode = manipulationMode;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether the Tapped event can originate from that element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isTapEnabled"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T IsTapEnabled<T>(this T element, bool isTapEnabled) where T : UIElement
    {
        element.IsTapEnabled = isTapEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether the RightTapped event can originate from that element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isRightTapEnabled"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T IsRightTapEnabled<T>(this T element, bool isRightTapEnabled) where T : UIElement
    {
        element.IsRightTapEnabled = isRightTapEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether the Holding event can originate from that element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="holdingEnabled"></param>
    /// <returns></returns>
    public static T IsHoldingEnabled<T>(this T element, bool holdingEnabled) where T : UIElement
    {
        element.IsHoldingEnabled = holdingEnabled;
        return element;
    }

    /// <summary>
    /// Sets whether the contained area of this UIElement can return true values for hit testing.
    /// The default is **true**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isHitTestVisible"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T IsHitTestVisible<T>(this T element, bool isHitTestVisible) where T : UIElement
    {
        element.IsHitTestVisible = isHitTestVisible;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether the DoubleTapped event can originate from that element.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isDoubleTapEnabled"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T IsDoubleTapEnabled<T>(this T element, bool isDoubleTapEnabled) where T : UIElement
    {
        element.IsDoubleTapEnabled = isDoubleTapEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether this UIElement can be a drop target for purposes of drag-and-drop operations.
    /// The default is **false**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="allowDrop"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T AllowDrop<T>(this T element, bool allowDrop) where T : UIElement
    {
        element.AllowDrop = allowDrop;
        return element;
    }

    /// <summary>
    /// Sets the RectangleGeometry used to define the outline of the contents of a UIElement.
    /// The default value is **null** (no clipping).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="clip"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Clip<T>(this T element, RectangleGeometry clip) where T : UIElement
    {
        element.Clip = clip;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates that rendered content should be cached as a composited bitmap when possible.
    /// The default is **null**, which does not enable a cached composition mode.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="cacheMode"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T CacheMode<T>(this T element, CacheMode cacheMode) where T : UIElement
    {
        element.CacheMode = cacheMode;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether rendering for the object and its
    /// visual subtree should use rounding behavior that aligns rendering to whole pixels.
    /// The default is **true**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="useLayoutRounding"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T UseLayoutRounding<T>(this T element, bool useLayoutRounding) where T : UIElement
    {
        element.UseLayoutRounding = useLayoutRounding;
        return element;
    }

    /// <summary>
    /// Sets transform information that affects the rendering position of a UIElement.
    /// The default value is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transform"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T RenderTransform<T>(this T element, Transform transform) where T : UIElement
    {
        element.RenderTransform = transform;
        return element;
    }

    /// <summary>
    /// Sets the visibility of a UIElement. A UIElement that is not visible is
    /// not rendered and does not communicate its desired size to layout.
    /// The default value is **Visible**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="visibility"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Visibility<T>(this T element, Visibility visibility) where T : UIElement
    {
        element.Visibility = visibility;
        return element;
    }

    /// <summary>
    /// Sets the XamlRoot in which this element is being viewed. The default is **null**.
    /// <list type="bullet">
    /// <item> Windows version: 1903, SDK version 18362 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="xamlRoot"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T XamlRoot<T>(this T element, XamlRoot xamlRoot) where T : UIElement
    {
        element.XamlRoot = xamlRoot;
        return element;
    }

    /// <summary>
    /// Sets the shadow effect cast by the element.
    /// <list type="bullet">
    /// <item> Windows version: 1903, SDK version 18362 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="shadow"></param>
    /// <returns></returns>
    public static T Shadow<T>(this T element, Shadow shadow) where T : UIElement
    {
        element.Shadow = shadow;
        return element;
    }

    /// <summary>
    /// Sets a property that declares alternate composition and blending modes
    /// for the element in its parent layout and window. This is relevant for elements
    /// that are involved in a mixed XAML / Microsoft DirectX UI.
    /// The default is **Inherit**
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="compositeMode"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T CompositeMode<T>(this T element, ElementCompositeMode compositeMode) where T : UIElement
    {
        element.CompositeMode = compositeMode;
        return element;
    }

    /// <summary>
    /// Sets the 3-D transform effect to apply when rendering this element. The default is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transform3D"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Transform3D<T>(this T element, Transform3D transform3D) where T : UIElement
    {
        element.Transform3D = transform3D;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the element can be dragged as data
    /// in a drag-and-drop operation.
    /// The default is **false**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="canDrag"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T CanDrag<T>(this T element, bool canDrag) where T : UIElement
    {
        element.CanDrag = canDrag;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether an element defines its own access key scope.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isAccessKeyScope"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T IsAccessKeyScope<T>(this T element, bool isAccessKeyScope) where T : UIElement
    {
        element.IsAccessKeyScope = isAccessKeyScope;
        return element;
    }

    /// <summary>
    /// Sets a value that specifies whether the access key display is dismissed when an access key is invoked.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="exitDisplayModeOnAccessKeyInvoked"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T ExitDisplayModeOnAccessKeyInvoked<T>(this T element, bool exitDisplayModeOnAccessKeyInvoked) where T : UIElement
    {
        element.ExitDisplayModeOnAccessKeyInvoked = exitDisplayModeOnAccessKeyInvoked;
        return element;
    }

    /// <summary>
    /// Sets the flyout associated with this element. The default is **null**.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="contextFlyout"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T ContextFlyout<T>(this T element, FlyoutBase contextFlyout) where T : UIElement
    {
        element.ContextFlyout = contextFlyout;
        return element;
    }

    /// <summary>
    /// Sets a source element that provides the access key scope for this element,
    /// even if it's not in the visual tree of the source element.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="accessKeyScopeOwner"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T AccessKeyScopeOwner<T>(this T element, DependencyObject accessKeyScopeOwner) where T : UIElement
    {
        element.AccessKeyScopeOwner = accessKeyScopeOwner;
        return element;
    }

    /// <summary>
    /// Sets the access key (mnemonic) for this element.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="accessKey"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T AccessKey<T>(this T element, string accessKey) where T : UIElement
    {
        element.AccessKey = accessKey;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how far left or right the Key Tip is placed in relation to the UIElement.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="offset"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T KeyTipHorizontalOffset<T>(this T element, double offset) where T : UIElement
    {
        element.KeyTipHorizontalOffset = offset;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the framework automatically adjusts
    /// the element's visual properties when high contrast themes are enabled.
    /// The default is **Application**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="highContrastAdjustment"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T HighContrastAdjustment<T>(this T element, ElementHighContrastAdjustment highContrastAdjustment) where T : UIElement
    {
        element.HighContrastAdjustment = highContrastAdjustment;
        return element;
    }

    /// <summary>
    /// Sets a value that specifies the strategy used to determine the target element of a right navigation.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="strategy"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T XYFocusRightNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy) where T : UIElement
    {
        element.XYFocusRightNavigationStrategy = strategy;
        return element;
    }

    /// <summary>
    /// Sets a value that enables or disables navigation using the keyboard directional arrows.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="mode"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T XYFocusKeyboardNavigation<T>(this T element, XYFocusKeyboardNavigationMode mode) where T : UIElement
    {
        element.XYFocusKeyboardNavigation = mode;
        return element;
    }

    /// <summary>
    /// Sets a value that specifies the strategy used to determine the target element of a down navigation.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="strategy"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T XYFocusDownNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy) where T : UIElement
    {
        element.XYFocusDownNavigationStrategy = strategy;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how far up or down the Key Tip is placed
    /// in relation to the UI element.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    public static T KeyTipVerticalOffset<T>(this T element, double offset) where T : UIElement
    {
        element.KeyTipVerticalOffset = offset;
        return element;
    }

    /// <summary>
    /// Sets a value that modifies how tabbing and TabIndex work for this control.
    /// The default is **Local**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="mode"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T TabFocusNavigation<T>(this T element, KeyboardNavigationMode mode) where T : UIElement
    {
        element.TabFocusNavigation = mode;
        return element;
    }

    /// <summary>
    /// Sets a value that specifies the strategy used to determine the target element of an up navigation.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="strategy"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T XYFocusUpNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy) where T : UIElement
    {
        element.XYFocusUpNavigationStrategy = strategy;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates where the access key Key Tip is placed in relation to the boundary of the UIElement.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="mode"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T KeyTipPlacementMode<T>(this T element, KeyTipPlacementMode mode) where T : UIElement
    {
        element.KeyTipPlacementMode = mode;
        return element;
    }

    /// <summary>
    /// Sets a value that specifies the strategy used to determine the target element of a left navigation.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="strategy"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T XYFocusLeftNavigationStrategy<T>(this T element, XYFocusNavigationStrategy strategy) where T : UIElement
    {
        element.XYFocusLeftNavigationStrategy = strategy;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the control tooltip that displays the accelerator key combination.
    /// <list type="bullet">
    /// <item> Windows version: 1803, SDK version 17134 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="keyboardAcceleratorPlacementTarget"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T KeyboardAcceleratorPlacementTarget<T>(this T element, DependencyObject keyboardAcceleratorPlacementTarget) where T : UIElement
    {
        element.KeyboardAcceleratorPlacementTarget = keyboardAcceleratorPlacementTarget;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the control tooltip displays the key combination for it's associated keyboard accelerator.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1803, SDK version 17134 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="mode"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T KeyboardAcceleratorPlacementMode<T>(this T element, KeyboardAcceleratorPlacementMode mode) where T : UIElement
    {
        element.KeyboardAcceleratorPlacementMode = mode;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the element targeted by the access key Key Tip.
    /// <list type="bullet">
    /// <item> Windows version: 1803, SDK version 17134 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="keyTipTarget"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T KeyTipTarget<T>(this T element, DependencyObject keyTipTarget) where T : UIElement
    {
        element.KeyTipTarget = keyTipTarget;
        return element;
    }

    /// <summary>
    /// Sets the Vector3Transition that animates changes to the Translation property.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="translationTransition"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T TranslationTransition<T>(this T element, Vector3Transition translationTransition) where T : UIElement
    {
        element.TranslationTransition = translationTransition;
        return element;
    }

    /// <summary>
    /// Sets the ScalarTransition that animates changes to the Opacity property.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="opacityTransition"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T OpacityTransition<T>(this T element, ScalarTransition opacityTransition) where T : UIElement
    {
        element.OpacityTransition = opacityTransition;
        return element;
    }

    /// <summary>
    /// Sets the transformation matrix to apply to the element.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="matrix"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T TransformMatrix<T>(this T element, Matrix4x4 matrix) where T : UIElement
    {
        element.TransformMatrix = matrix;
        return element;
    }

    /// <summary>
    /// Sets the Vector3Transition that animates changes to the Scale property.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="scaleTransition"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T ScaleTransition<T>(this T element, Vector3Transition scaleTransition) where T : UIElement
    {
        element.ScaleTransition = scaleTransition;
        return element;
    }

    /// <summary>
    /// Sets the scale of the element. Scales relative to the element's CenterPoint.
    /// Affects the rendering position of the element.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="scale"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Scale<T>(this T element, Vector3 scale) where T : UIElement
    {
        element.Scale = scale;
        return element;
    }

    /// <summary>
    /// Sets the ScalarTransition that animates changes to the Rotation property.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rotationTransition"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T RotationTransition<T>(this T element, ScalarTransition rotationTransition) where T : UIElement
    {
        element.RotationTransition = rotationTransition;
        return element;
    }

    /// <summary>
    /// Sets the axis to rotate the element around.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rotationAxis"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T RotationAxis<T>(this T element, Vector3 rotationAxis) where T : UIElement
    {
        element.RotationAxis = rotationAxis;
        return element;
    }

    /// <summary>
    /// Sets the angle of clockwise rotation, in degrees. Rotates relative to
    /// the RotationAxis and the CenterPoint. Affects the rendering position of the element.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="rotation"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Rotation<T>(this T element, float rotation) where T : UIElement
    {
        element.Rotation = rotation;
        return element;
    }

    /// <summary>
    /// Sets the x, y, and z rendering position of the element.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="translation"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T Translation<T>(this T element, Vector3 translation) where T : UIElement
    {
        element.Translation = translation;
        return element;
    }

    /// <summary>
    /// Sets the center point of the element, which is the point about which
    /// rotation or scaling occurs. Affects the rendering position of the element.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="centerPoint"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T CenterPoint<T>(this T element, Vector3 centerPoint) where T : UIElement
    {
        element.CenterPoint = centerPoint;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the UIElement can be a candidate
    /// for scroll anchoring. The default is **false**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="canBeScrollAnchor"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining</returns>
    public static T CanBeScrollAnchor<T>(this T element, bool canBeScrollAnchor) where T : UIElement
    {
        element.CanBeScrollAnchor = canBeScrollAnchor;
        return element;
    }

    #region  UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the <see cref="Windows.UI.Xaml.Controls.ToolTip"/> for the <see cref="UIElement"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="UIElement"/> type</typeparam>
    /// <param name="element">The <see cref="UIElement"/> instance.</param>
    /// <param name="toolTip">The content of the <see cref="Windows.UI.Xaml.Controls.ToolTip"/>.</param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining.</returns>
    public static T ToolTip<T>(this T element, object toolTip) where T : UIElement
    {
        if (toolTip is null || string.IsNullOrWhiteSpace(toolTip as string))
            return element;
        ToolTip _toolTip = new ToolTip().Content(toolTip);
        ToolTipService.SetToolTip(element, _toolTip);
        return element;
    }

    /// <summary>
    /// Sets the <see cref="Windows.UI.Xaml.Controls.ToolTip"/> for the <see cref="UIElement"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="UIElement"/> type</typeparam>
    /// <param name="element">The <see cref="UIElement"/> instance.</param>
    /// <param name="toolTip">The content of the <see cref="Windows.UI.Xaml.Controls.ToolTip"/>.</param>
    /// <param name="placementMode">Defines constants that specify the preferred location for positioning a <see cref="Windows.UI.Xaml.Controls.ToolTip"/> relative to a visual element.</param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining.</returns>
    public static T ToolTip<T>(this T element, object toolTip, PlacementMode placementMode) where T : UIElement
    {
        if (toolTip is null || string.IsNullOrWhiteSpace(toolTip as string))
            return element;
        ToolTip _toolTip = new ToolTip().Content(toolTip).Placement(placementMode);
        ToolTipService.SetToolTip(element, _toolTip);
        return element;
    }

    /// <summary>
    /// Sets the <see cref="Windows.UI.Xaml.Controls.ToolTip"/> for the <see cref="UIElement"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="UIElement"/> type</typeparam>
    /// <param name="element">The <see cref="UIElement"/> instance.</param>
    /// <param name="toolTip">The content of the <see cref="Windows.UI.Xaml.Controls.ToolTip"/>.</param>
    /// <param name="placementMode">Defines constants that specify the preferred location for positioning a <see cref="Windows.UI.Xaml.Controls.ToolTip"/> relative to a visual element.</param>
    /// <param name="placementTarget">UIElement is a base class for most of the Windows Runtime UI objects that have visual appearance and can process basic input as part of your app's user interface.</param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining.</returns>
    public static T ToolTip<T>(this T element, object toolTip, PlacementMode placementMode,
        UIElement placementTarget = null) where T : UIElement
    {
        if (toolTip is null || string.IsNullOrWhiteSpace(toolTip as string))
            return element;
        ToolTip _toolTip = new ToolTip()
            .Content(toolTip)
            .Placement(placementMode)
            .PlacementTarget(placementTarget);
        ToolTipService.SetToolTip(element, _toolTip);
        return element;
    }

    /// <summary>
    /// Sets the <see cref="Windows.UI.Xaml.Controls.ToolTip"/> for the <see cref="UIElement"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="UIElement"/> type</typeparam>
    /// <param name="element">The <see cref="UIElement"/> instance.</param>
    /// <param name="toolTip">The content of the <see cref="Windows.UI.Xaml.Controls.ToolTip"/>.</param>
    /// <param name="placementMode">Defines constants that specify the preferred location for positioning a <see cref="Windows.UI.Xaml.Controls.ToolTip"/> relative to a visual element.</param>
    /// <param name="placementTarget">UIElement is a base class for most of the Windows Runtime UI objects that have visual appearance and can process basic input as part of your app's user interface.</param>
    /// <param name="placementRect"></param>
    /// <returns>The <see cref="UIElement"/> instance for method chaining.</returns>
    public static T ToolTip<T>(this T element, object toolTip, PlacementMode placementMode,
        UIElement placementTarget = null, Rect? placementRect = null) where T : UIElement
    {
        if (toolTip is null || string.IsNullOrWhiteSpace(toolTip as string))
            return element;
        ToolTip _toolTip = new ToolTip()
            .Content(toolTip)
            .Placement(placementMode)
            .PlacementTarget(placementTarget)
            .PlacementRect(placementRect);
        ToolTipService.SetToolTip(element, _toolTip);
        return element;
    }

    /// <summary>
    /// Sets the <see cref="Windows.UI.Xaml.Controls.ToolTip"/> for the <see cref="UIElement"/>.
    /// </summary>
    /// <typeparam name="T">The <see cref="UIElement"/> type</typeparam>
    /// <param name="element">The <see cref="UIElement"/> instance.</param>
    /// <param name="toolTip">The content of the <see cref="Windows.UI.Xaml.Controls.ToolTip"/>.</param>
    /// <param name="placementMode">Defines constants that specify the preferred location for positioning a <see cref="Windows.UI.Xaml.Controls.ToolTip"/> relative to a visual element.</param>
    /// <param name="placementTarget">UIElement is a base class for most of the Windows Runtime UI objects that have visual appearance and can process basic input as part of your app's user interface.</param>
    /// <param name="placementRect"></param>
    /// <param name="horizontalOffset">the horizontal distance between the target origin and the pop-up alignment point.</param>
    /// <param name="verticalOffset">the vertical distance between the target origin and the pop-up alignment point.</param>
    /// <param name="isOpen">indicates whether the <see cref="Windows.UI.Xaml.Controls.ToolTip"/> is visible.</param>
    /// <returns></returns>
    public static T ToolTip<T>(this T element, object toolTip,
        PlacementMode placementMode, UIElement placementTarget = null,
        Rect? placementRect = null, double horizontalOffset = 0,
        double verticalOffset = 0, bool isOpen = false) where T : UIElement
    {
        if (toolTip is null || string.IsNullOrWhiteSpace(toolTip as string))
            return element;
        ToolTip _toolTip = new ToolTip()
            .Content(toolTip)
            .Placement(placementMode)
            .PlacementTarget(placementTarget)
            .PlacementRect(placementRect)
            .HorizontalOffset(horizontalOffset)
            .VerticalOffset(verticalOffset)
            .IsOpen(isOpen);
        ToolTipService.SetToolTip(element, _toolTip);
        return element;
    }
    #endregion  UWP_Toolkit.Markup Functions v0.0.1
}
