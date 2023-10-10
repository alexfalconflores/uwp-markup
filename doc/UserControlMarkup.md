# Markup
## VariableSizedWrapGridMarkup

```csharp
using UWP.Markup;

var value = new UserControl()
    .Content(new TextBlock().Text("Hello World!"))
    .Alignment(VerticalAlignment.Center, HorizontalAlignment.Center);

// more...
```

> WinUI Methods
### Content (UIElement content)
Sets the `content` that is contained within a `user control`.