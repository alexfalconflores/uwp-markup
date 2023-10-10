# Markup
## BorderMarkup

```csharp
using UWP.Markup;

var value = new ContentPresenter()
    .Foreground(Colors.Red)
    .ContentAlignment(HorizontalAlignment.Center, VerticalAlignment.Center)
    .Padding(10)
    .CornerRadius(10)
    .BorderThickness(2)
    .BorderBrush(Colors.Red)
    .Background(Colors.White)
    .Content("ContentPresenter");
// doc ⬇️
```

> Custom Methods

### Foreground (Color color)
Sets the `Brush` to apply to the text content handled by the ContentPresenter.The default is a `null brush` from a pure code perspective, but system style defaults set this to Black (for **Light** theme) or White (for **Dark** theme).

### ContentAlignment (HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment)
Sets The `horizontal` and `vertical` alignment of the content. The default is `HorizontalAlignment.Left and VerticalAlignment.Top`.

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

### Background (Color colors)
Sets the `Brush` that fills the background (inner area) of the border. The default is `null, (a null brush) which is evaluated as Transparent for rendering.`

---
> WinUI Methods

### Foreground
### FontWeight
### FontStyle
### FontStretch
### FontSize
### FontFamily
### ContentTransitions
### ContentTemplateSelector
### ContentTemplate
### Content
### CharacterSpacing
### TextLineBounds
### OpticalMarginAlignment
### IsTextScaleFactorEnabled
### VerticalContentAlignment
### TextWrapping
### Padding
### MaxLines
### LineStackingStrategy
### LineHeight
### HorizontalContentAlignment
### CornerRadius
### BorderThickness
### BorderBrush
### Background
### BackgroundTransition
### BackgroundSizing