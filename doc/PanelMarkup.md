# Markup
## PanelMarkup

```csharp
using UWP.Markup;

var value = new StackPanel()
    .Background(Colors.Red)
    .AddChild(new TextBlock().Text("Hello"));
// doc ⬇️
```

> Custom Methods

### Background (Color color)
Sets a `Brush` that fills the `panel` content area.

### AddChildren (params UIElement[] items)
Add items as a `params array of UIElement` to the `Children` collection of the `Panel`.

### AddChild (UIElement item)
Add a `item` to the `Children` collection of the `Panel`.

### TryAddChildren (params UIElement[] items)
`Try` to `add items` as a `params` array of UIElement to the `Children` collection of the `Panel`.

### TryAddChild (UIElement item)
`Try` to `add` a `item` to the `Children` collection of the `Panel`.

---
> WinUI Methods

### ChildrenTransitions
### Background
### BackgroundTransition