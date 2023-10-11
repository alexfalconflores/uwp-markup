# Markup
## RelativePanelMarkup

```csharp
using UWP.Markup;

var value = new RelativePanel()
    .Padding(10)
    .CornerRadius(10)
    .BorderThickness(2)
    .BorderBrush(Colors.Red);
// doc ⬇️
```

> Custom Methods

### Padding (double padding)
Sets the distance between the border and its child object. The default value is `0`.

### Padding (double left, double top, double right, double bottom)
Sets the distance between the border and its child object. The default value is `left: 0, top: 0, right: 0, bottom: 0`.

### Padding (double horizontal, double vertical)
Sets the distance between the border and its child object. The default value is `horizontal: 0, vertical: 0`.

### CornerRadius (double cornerRadius)
Sets the `radius` for the corners of the border. The default is `0`.

### CornerRadius (double topLeftRight, double bottomRightLeft)
Sets the `radius` for the corners of the border. The default is `topLeftRight: 0, bottomRightLeft: 0`.

### CornerRadius (double topLeft, double topRight, double bottomRight, double bottomLeft)
Sets the `radius` for the corners of the border. The default is `top-left: 0, top-right: 0, bottom-right: 0, bottom-left: 0`.

### BorderThickness (double thickness)
Sets the `thickness` of the border. The default is `0`.

### BorderThickness (double leftRight, double topBottom)
Sets the `thickness` of the border. The default `leftRight and topBottom is 0`.

### BorderThickness (double left, double top, double right, double bottom)
Sets the `thickness` of the border. The default is `left: 0, top: 0, right: 0, bottom: 0.`

### BorderBrush (Color colors)
Sets the `Brush` that is applied to the edge area of the Border. The default is `null, (a null brush) which is evaluated as Transparent for rendering.`

---
> WinUI Methods

### Padding
### CornerRadius
### BorderThickness
### BorderBrush
### BackgroundSizing