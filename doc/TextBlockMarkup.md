# Markup
## TextBlockMarkup

```csharp
using UWP.Markup;

var value =  new TextBlock()
    .Text("Value")
    .Alignment(VerticalAlignment.Center, HorizontalAlignment.Right);

// doc ⬇️
```

> Custom Methods

### Padding(double padding)
Sets a value that indicates the `thickness` of padding space between the boundaries of the content area and the content displayed by a `TextBlock`. The default value is `0`.

### Padding(double left, double top, double right, double bottom)
Sets a value that indicates the `thickness` of padding space between the boundaries of the content area and the content displayed by a `TextBlock`. The default value is `left: 0, top: 0, right: 0, bottom: 0.`

### Padding(double horizontal, double vertical)
Sets a value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a `TextBlock`. The default value is `horizontal: 0, vertical: 0.`

### Foreground(Color color)
Sets the Brush to apply to the text contents of the `TextBlock`. The default is a `null brush` from a pure code perspective, but the default text styles set to Black (for **Light** theme) or White (for **Dark** theme) for a `TextBlock` element in UI.

---
> WinUI Methods

- ### TextWrapping
- ### TextTrimming
- ### TextAlignment
- ### Text
- ### Padding
- ### Foreground
- ### FontWeight
- ### FontStretch
- ### FontStyle
- ### FontFamily
- ### LineStackingStrategy
- ### LineHeight
- ### CharacterSpacing
- ### IsTextSelectionEnabled
- ### TextReadingOrder
- ### TextLineBounds
- ### SelectionHighlightColor
- ### OpticalMarginAlignment
- ### MaxLines
- ### IsColorFontEnabled
- ### IsTextScaleFactorEnabled
- ### TextDecorations
- ### HorizontalTextAlignment
- ### SelectionFlyout