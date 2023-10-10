# Markup
## ColumnDefinitionMarkup

```csharp
using UWP.Markup;

var value = new ColumnDefinition()
    .Width(new GridLength(1, GridUnitType.Star))
    .MinWidth(100)
    .MaxWidth(200);
```

> WinUI Methods
### Width (GridLength gridLength)
Sets the `GridLength` value of a column that is defined by the `ColumnDefinition`. The default value is a `GridLength representing a "1\*" sizing`.

### MinWidth (double minWidth)
Sets a value that represents the `minimum width` of a `ColumnDefinition`. The default is `0`.

### MaxWidth (double maxWidth)
Sets a value that represents the `maximum width` of a `ColumnDefinition`. The default is `PositiveInfinity`.