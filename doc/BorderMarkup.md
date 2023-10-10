# Markup
## BorderMarkup

```csharp
using UWP.Markup;

var value = new Border()
     .Padding(10)
     .CornerRadius(10)
     .BorderThickness(2)
     .BorderBrush(Colors.Red)
     .Background(Colors.Blue);

var value2 = new Border()
    .Padding(10,10)
    .CornerRadius(10,10)
    .BorderThickness(2,2)
    .BorderBrush(Colors.Red)
    .Background(Colors.Blue);

// doc ⬇️
```

> Custom Methods
### Padding (double padding)
Sets the distance between the border and its child object. The default value is `0`.

### Padding (double horizontalOffset, double left, double top, double right, double bottom)
Sets the distance between the border and its child object. The default value is `left: 0, top: 0, right: 0, bottom: 0`.

### Padding (double horizontalOffset, double horizontal, double vertical)
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

### Padding (Thickness thickness)
Sets the distance between the border and its child object.

### CornerRadius (CornerRadius cornerRadius)
Sets the `radius` for the corners of the border.

### ChildTransitions(TransitionCollection childTransitions)
Sets the `collection of Transition` style elements that apply to child content of a Border.

### Child (UIElement child)
Sets the child element to draw the border around.

### BorderThickness(Thickness thickness)
Sets the `thickness` of the border.

### BorderBrush (Brush brush)
Sets the `Brush` that is applied to the edge area of the Border. The default is `null, (a null brush) which is evaluated as Transparent for rendering.`

### Background (Brush brush)
Sets the `Brush` that fills the background (inner area) of the border. The default is `null, (a null brush) which is evaluated as Transparent for rendering.`

### BackgroundTransition (BrushTransition backgroundTransition)
Sets an instance of `BrushTransition` to automatically animate changes to the Background property. The default is `null`.

### BackgroundSizing (BackgroundSizing backgroundSizing)
Sets a value that indicates how far the background extends in relation to this element's border. The default is `InnerBorderEdge`.