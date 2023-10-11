# Markup
## RowDefinitionMarkup

```csharp
using UWP.Markup;

var value = new RowDefinition()
    .Height(new GridLength(1, GridUnitType.Star))
    .MinHeight(100)
    .MaxHeight(200);
```

> WinUI Methods
### Height (GridLength gridLength)
Sets the `GridLength` value of a row that is defined by the `RowDefinition`. The default value is a `GridLength` representing a `"1\*" sizing`.

### MinHeight (double minHeight)
Sets a value that represents the minimum allowed `height` of a `RowDefinition`. The default value is `0`.

### MaxHeight (double maxHeight)
Sets a value that represents the `maximum` height of a `RowDefinition`.