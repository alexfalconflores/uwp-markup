# Markup
## ControlMarkup

```csharp
using UWP.Markup;

var value = new ItemsControl()
    .ItemsSource(new string[] { "1", "2", "3" })
    .ItemsPanel(new ItemsPanelTemplate())
    .DisplayMemberPath("1")
    .GroupStyleSelector(new GroupStyleSelector());
// doc ⬇️
```

> WinUI Methods

### ItemsSource
### ItemsPanel
### ItemTemplateSelector
### ItemTemplate
### ItemContainerTransitions
### ItemContainerStyleSelector
### ItemContainerStyle
### GroupStyleSelector
### DisplayMemberPath