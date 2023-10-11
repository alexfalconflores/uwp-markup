# Markup
## InfoBarMarkup

```csharp
using UWP.Markup;

var value = new InfoBar()
    .Title("Title")
    .Severity(InfoBarSeverity.Informational)
    .Message("Message")
    .IsOpen(true)
    .IsIconVisible(true)
    .IsClosable(true)
    .IconSource(new Microsoft.UI.Xaml.Controls.SymbolIconSource() { Symbol = Symbol.Accept });
// doc ⬇️
```

> WinUI Methods

### Title
### Severity
### Message
### IsOpen
### IsIconVisible
### IsClosable
### IconSource
### ContentTemplate
### Content
### CloseButtonStyle
### CloseButtonCommandParameter
### CloseButtonCommand
### ActionButton