# Markup
## ViewboxMarkup

```csharp
using UWP.Markup;

var value = new Viewbox()
    .StretchDirection(StretchDirection.Both)
    .Stretch(Stretch.Uniform)
    .Child(new TextBlock()
        .Text("Hello World")
        .FontSize(20)
        .Foreground(new SolidColorBrush(Colors.Red)));
```

> WinUI Methods
### StretchDirection (StretchDirection stretchDirection)
Sets the `StretchDirection`, which determines how scaling is applied to the contents of a `Viewbox`. The default is `Both`.

### Stretch (Stretch stretch)
Sets the `Stretch` mode, which determines how content fits into the available space. The default is `Uniform`.

### Child (UIElement child)
Sets the single child element of a `Viewbox` element.