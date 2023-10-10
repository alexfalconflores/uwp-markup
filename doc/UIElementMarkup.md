# Markup
## UIElementMarkup

```csharp
using UWP.Markup;

var value = new Button()
    .ToolTip("ToolTip") // +4 overloads
    .Opacity(0.5);

// doc ⬇️
```

> Custom Methods
> 
> the `tooltips` apply to all elements that inherit from the `UIElement` class. If the tooltip is `null` or `string.empty` it is not `displayed`.
### ToolTip(object toolTip)
Sets the `ToolTip` for the `UIElement`.

### ToolTip(object toolTip, PlacementMode placementMode)
Sets the `ToolTip` for the `UIElement`.

### ToolTip(object toolTip, PlacementMode placementMode, UIElement placementTarget)
Sets the `ToolTip` for the `UIElement`.

### ToolTip(object toolTip, PlacementMode placementMode, UIElement placementTarget, Rect? placementRect)
Sets the `ToolTip` for the `UIElement`.

### ToolTip(object toolTip, PlacementMode placementMode, UIElement placementTarget, Rect? placementRect, double horizontalOffset, double verticalOffset, bool isOpen)
Sets the `ToolTip` for the `UIElement`.

---
> WinUI Methods

- ### Transitions
- ### Projection
- ### RenderTransformOrigin
- ### Opacity
- ### ManipulationMode
- ### IsTapEnabled
- ### IsRightTapEnabled
- ### IsHoldingEnabled
- ### IsHitTestVisible
- ### IsDoubleTapEnabled
- ### AllowDrop
- ### Clip
- ### CacheMode
- ### UseLayoutRounding
- ### RenderTransform
- ### Visibility
- ### XamlRoot
- ### Shadow
- ### CompositeMode
- ### Transform3D
- ### CanDrag
- ### IsAccessKeyScope
- ### ExitDisplayModeOnAccessKeyInvoked
- ### ContextFlyout
- ### AccessKeyScopeOwner
- ### AccessKey
- ### KeyTipHorizontalOffset
- ### HighContrastAdjustment
- ### XYFocusRightNavigationStrategy
- ### XYFocusKeyboardNavigation
- ### XYFocusDownNavigationStrategy
- ### KeyTipVerticalOffset
- ### TabFocusNavigation
- ### XYFocusUpNavigationStrategy
- ### KeyTipPlacementMode
- ### XYFocusLeftNavigationStrategy
- ### KeyboardAcceleratorPlacementTarget
- ### KeyboardAcceleratorPlacementMode
- ### KeyTipTarget
- ### TranslationTransition
- ### OpacityTransition
- ### TransformMatrix
- ### ScaleTransition
- ### Scale
- ### RotationTransition
- ### RotationAxis
- ### Rotation
- ### Translation
- ### CenterPoint
- ### CanBeScrollAnchor