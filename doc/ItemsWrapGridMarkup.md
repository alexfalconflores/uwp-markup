# Markup
## ItemsWrapGridMarkup

```csharp
using UWP.Markup;

var value = new ItemsWrapGrid()
    .GroupPadding(10)
    .Orientation(Orientation.Horizontal)
    .MaximumRowsOrColumns(3)
    .CacheLength(10);
// doc ⬇️
```

> Custom Methods

### GroupPadding (double padding)
Sets the `amount of space around a group`. The default value is `0`.

### GroupPadding (double left, double top, double right, double bottom)
Sets the `amount of space around a group`. The default value is `left: 0, top: 0, right: 0, bottom: 0.`

### GroupPadding (double horizontal, double vertical)
Sets the `amount of space around a group`. The default value is `horizontal: 0, vertical: 0.`

---
> WinUI Methods

### Orientation
### MaximumRowsOrColumns
### ItemWidth
### ItemHeight
### GroupPadding
### GroupHeaderPlacement
### CacheLength