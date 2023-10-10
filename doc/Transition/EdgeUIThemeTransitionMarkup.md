# Transition
## EdgeUIThemeTransitionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;
using Windows.UI.Xaml.Controls.Primitives;

var value = new EdgeUIThemeTransition()
    .Edge(EdgeTransitionLocation.Bottom);
```

> WinUI Methods
### Edge (EdgeTransitionLocation edgeTransitionLocation)
Sets the edge position to use for the transition. The default is `Top`.