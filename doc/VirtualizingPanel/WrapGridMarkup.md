# VirtualizingPanel
## OrientedVirtualizingPanelMarkup

```csharp
using UWP.Markup;
using UWP.Markup.VirtualizingPanel;

 var value = new WrapGrid()
     .VerticalChildrenAlignment(VerticalAlignment.Center)
     .Orientation(Orientation.Horizontal)
     .MaximumRowsOrColumns(3)
     .ItemWidth(100)
     .ItemHeight(100)
     .HorizontalChildrenAlignment(HorizontalAlignment.Center)
```

> WinUI Methods
### VerticalChildrenAlignment (VerticalAlignment verticalChildrenAlignment)
Sets the alignment rules by which child elements are arranged for the `vertical` dimension. The default is `Top`.

### Orientation (Orientation orientation)
Sets a value that describes the horizontal or vertical orientation of stacked content. The default is Vertical.

### MaximumRowsOrColumns (int maximumRowsOrColumns)
Sets a value that influences the wrap point, also accounting for `Orientation`. The default is `-1`, which is a special value that indicates `no maximum`.

### ItemWidth (double itemWidth)
Sets the `width` of the layout area for each item that is contained in a `WrapGrid`. The default is `Double.NaN`, which results in the `"Auto"` layout behavior.

### ItemHeight (double itemHeight)
Sets the `height` of the layout area for each item that is contained in a `WrapGrid`. The default is `Double.NaN`, which results in the `"Auto"` layout behavior.

### HorizontalChildrenAlignment (HorizontalAlignment horizontalChildrenAlignment)
Sets the alignment rules by which child elements are arranged for the `horizontal` dimension. The default is `Left`.
