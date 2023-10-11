# Markup
## ScrollViewerMarkup

```csharp
using UWP.Markup;

var value = new ScrollViewer()
    .IsVerticalRailEnabled(true)
    .IsHorizontalRailEnabled(true)
    .MinZoomFactor(0.5f)
    .TopLeftHeader(new TextBlock().Text("TopLeftHeader"))
    .TopHeader(new TextBlock().Text("TopHeader"))
    .LeftHeader(new TextBlock().Text("LeftHeader"))
    .VerticalAnchorRatio(0.5);

// doc ⬇️
```

### IsVerticalRailEnabled
### IsScrollInertiaEnabled
### IsHorizontalScrollChainingEnabled
### IsHorizontalRailEnabled
### IsDeferredScrollingEnabled
### HorizontalSnapPointsType
### HorizontalSnapPointsAlignment
### HorizontalScrollMode
### HorizontalScrollBarVisibility
### MinZoomFactor
### MaxZoomFactor
### IsZoomInertiaEnabled
### IsZoomChainingEnabled
### IsVerticalScrollChainingEnabled
### BringIntoViewOnFocusChange
### ZoomSnapPointsType
### ZoomMode
### VerticalSnapPointsType
### VerticalSnapPointsAlignment
### VerticalScrollMode
### VerticalScrollBarVisibility
### TopLeftHeader
### TopHeader
### LeftHeader
### VerticalAnchorRatio
### ReduceViewportForCoreInputViewOcclusions
### HorizontalAnchorRatio
### CanContentRenderOutsideBounds