# Transition
## ContentThemeTransitionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;

var value = new ContentThemeTransition()
    .Offset(100, 200);

var value2 = new ContentThemeTransition()
    .VerticalOffset(100)
    .HorizontalOffset(200);
```

> Custom Methods
### Offset (double horizontalOffset, double verticalOffset)
Sets the distance by which the target is translated in the `vertical` direction and the `horizontal` direction when the transition is active.

---
> WinUI Methods
### VerticalOffset(double offset)
Sets the distance by which the target is translated in the `vertical` direction when the transition is active.

### HorizontalOffset(double offset)
Sets the distance by which the target is translated in the `horizontal` direction when the transition is active.