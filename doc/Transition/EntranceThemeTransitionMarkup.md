# Transition
## EntranceThemeTransitionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;

var value = new EntranceThemeTransition()
    .FromOffset(0, 100)
    .IsStaggeringEnabled(true);

var value2 = new EntranceThemeTransition()
    .FromHorizontalOffset(100)
    .FromVerticalOffset(0)
    .IsStaggeringEnabled(true);
```

> Custom Methods
### FromOffset (double fromVerticalOffset, double fromHorizontalOffset)
Sets the distance by which the target is translated in the `vertical` direction and `horizontal` direction when the animation is active.

---
> WinUI Methods
### IsStaggeringEnabled(bool isStaggeringEnabled)
Sets a value that determines whether the `transition staggers` rendering of multiple items, or renders all items at once.

### FromVerticalOffset(double fromVerticalOffset)
Sets the distance by which the target is translated in the `vertical` direction when the animation is active.

### HorizontalOffset(double fromHorizontalOffset)
Sets the distance by which the target is translated in the `horizontal` direction when the animation is active.