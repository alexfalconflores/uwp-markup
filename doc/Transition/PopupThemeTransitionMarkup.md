# Transition
## PopupThemeTransitionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;

var value = new PopupThemeTransition()
    .FromOffset(100, 200);

var value2 = new PopupThemeTransition()
    .FromHorizontalOffset(100)
    .FromVerticalOffset(200);
```

> Custom Methods
### FromOffset (double fromHorizontalOffset, double fromVerticalOffset)
Sets the distance by which the target is translated in the `horizontal` direction and the `vertical` direction when the animation is active.

---
> WinUI Methods
### FromHorizontalOffset(double fromHorizontalOffset)
Sets the distance by which the target is translated in the `horizontal` direction when the animation is active.

### FromVerticalOffset(double fromVerticalOffset)
Sets the distance by which the target is translated in the `vertical` direction when the animation is active.