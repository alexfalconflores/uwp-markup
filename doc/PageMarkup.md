# Markup
## PageMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Controls.Primitives;

var value = new Page()
     .TopAppBar(new AppBar())
     .NavigationCacheMode(Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled)
     .BottomAppBar(new AppBar());
// doc ⬇️
```

> WinUI Methods

### TopAppBar
Sets a reference to an `AppBar` displayed at the `top` of the `page`, if any.

### NavigationCacheMode
Sets the navigation mode that indicates whether this `Page` is `cached`, and the period of time that the `cache` entry should persist. The default is `Disabled`.

### BottomAppBar
Sets a reference to an `AppBar` displayed at the `bottom` of the `page`, if any.
