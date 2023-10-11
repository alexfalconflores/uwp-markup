# Markup
## PopupMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Controls.Primitives;

 var value = new Popup()
      .Offset(100, 200)
      .IsOpen(true)
      .IsLightDismissEnabled(false)
      .Child(new TextBlock().Text("Popup Content"));
// doc ⬇️
```

> Custom Methods

### Offset (double horizontal, double vertical)
Sets the distance between the `left` side and `top` side of the application `window` and the left side of the `popup`.

---
> WinUI Methods

### VerticalOffset
Sets the distance between the `top` of the application `window` and the top of the `popup`.

### IsOpen
Sets whether the `popup` is currently displayed on the screen. The default is `false`.

### IsLightDismissEnabled
Sets a value that determines how the `Popup` can be `dismissed`.

### HorizontalOffset
Sets the distance between the `left` side of the application `window` and the `left` side of the `popup`.

### ChildTransitions
Sets the `collection` of `Transition` style elements that apply to child content of a `Popup`.

### Child
Sets the `content` to be `hosted` in the `popup`.

### LightDismissOverlayMode
Sets a value that specifies whether the area outside of a `light-dismiss` UI is darkened. The default is `Auto`.

### ShouldConstrainToRootBounds
Sets a value that indicates whether the `popup` should be `shown` within the bounds of the `XAML root`.
