# Markup
## ToolTipMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Controls.Primitives;

var value = new ToolTip()
    .Offset(20, 10)
    .Placement(PlacementMode.Mouse);

// doc ⬇️
```

> Custom Methods

### Offset(double horizontalOffset, double verticalOffset)
Sets the `Horizontal` and `Vertical` distance between the target origin and the `pop-up alignment` point.

---
> WinUI Methods

### VerticalOffset
Sets the `vertical` distance between the target origin and the `pop-up alignment` point.

### PlacementTarget
Sets the visual element or control that the tool tip should be positioned in relation to when opened by the `ToolTipService`.

### Placement
Sets how a `ToolTip` is positioned in relation to the placement target element.

### IsOpen
Sets a value that indicates whether the `ToolTip` is visible.

### HorizontalOffset
Sets the `horizontal` distance between the target origin and the `pop-up alignment` point.

### PlacementRect
Sets the rectangular area that the `ToolTip` should be positioned in relation to when opened by the `ToolTipService`. If space allows, the open `ToolTip` will not occlude the area defined by its `PlacementRect`.

