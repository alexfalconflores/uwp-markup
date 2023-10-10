# VirtualizingPanel
## OrientedVirtualizingPanelMarkup

```csharp
using UWP.Markup;
using UWP.Markup.VirtualizingPanel;

var value = new VirtualizingStackPanel()
    .Orientation(Orientation.Horizontal)
    .AreScrollSnapPointsRegular(true);
// ...
```

> WinUI Methods
### Orientation (Orientation orientation)
Sets a value that describes the horizontal or vertical orientation of stacked content. The default is Vertical.

### AreScrollSnapPointsRegular (bool areScrollSnapPointsRegular)
Sets a value that indicates whether the generated snap points used for panning in the VirtualizingStackPanel are equidistant from each other.
