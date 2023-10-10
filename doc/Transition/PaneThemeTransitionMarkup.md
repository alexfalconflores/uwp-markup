# Transition
## PaneThemeTransitionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;
using Windows.UI.Xaml.Controls.Primitives;

var value = new PaneThemeTransition()
    .Edge(EdgeTransitionLocation.Right);
```

> WinUI Methods
### PaneThemeTransition(EdgeTransitionLocation edge)
Sets the `edge` position to use for the `transition`.