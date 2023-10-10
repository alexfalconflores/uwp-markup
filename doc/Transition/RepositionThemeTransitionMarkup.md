# Transition
## RepositionThemeTransitionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;

var value = new RepositionThemeTransition()
    .IsStaggeringEnabled(true);
```

> WinUI Methods
### IsStaggeringEnabled(bool isStaggeringEnabled)
Sets a value that determines whether the `transition staggers` rendering of multiple items, or renders all items at once. The default is `true`.
