# Transition
## NavigationThemeTransitionMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;

var value = new NavigationThemeTransition()
    .DefaultNavigationTransitionInfo(new SuppressNavigationTransitionInfo());

var value2 = new NavigationThemeTransition()
    .DefaultNavigationTransitionInfo(new EntranceNavigationTransitionInfo());

var value3 = new NavigationThemeTransition()
    .DefaultNavigationTransitionInfo(new DrillInNavigationTransitionInfo());

var value4 = new NavigationThemeTransition()
    .DefaultNavigationTransitionInfo(new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight});

var value5 = new NavigationThemeTransition()
    .DefaultNavigationTransitionInfo(new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromLeft });

var value6 = new NavigationThemeTransition()
    .DefaultNavigationTransitionInfo(new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromBottom });
```

> WinUI Methods
### DefaultNavigationTransitionInfo(NavigationTransitionInfo navigationTransitionInfo)
Sets the default transition used when navigating between pages.