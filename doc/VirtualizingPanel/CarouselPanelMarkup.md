# VirtualizingPanel
## CarouselPanelMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Controls.Primitives;
using UWP.Markup.VirtualizingPanel;

var value = new CarouselPanel()
    .ScrollOwner(object)
    .CanVerticallyScroll(true)
    .CanHorizontallyScroll(true);
// ...
```

> WinUI Methods
### ScrollOwner (object scrollOwner)
Sets a reference to a `ScrollViewer` that is the `scroll` host or scroll owner for scrolling behavior of the `CarouselPanel`.

### CanVerticallyScroll (bool canVerticallyScroll)
Not intended for general use. Sets a value that indicates whether scrolling on the `vertical` axis is possible.

### CanHorizontallyScroll (bool canVerticallyScroll)
Not intended for general use. Gets or sets a value that indicates whether scrolling on the `horizontal` axis is possible.
