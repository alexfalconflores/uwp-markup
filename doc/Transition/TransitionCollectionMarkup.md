# Transition
## TransitionCollectionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;

var value = new TransitionCollection()
    .AddTransition(new EntranceThemeTransition());

var value2 = new TransitionCollection()
    .AddTransition(new PopupThemeTransition());
// ...
```

> Custom Methods
### AddTransition (Windows.UI.Xaml.Media.Animation.Transition item)
Adds a `Windows.UI.Xaml.Media.Animation.Transition` to the `TransitionCollection`.
