# Markup
## GridMarkup

```csharp
using UWP.Markup;

var value = new Grid()
    .Rows("Auto", "*", "200")
    .Columns("Auto", "*", "200")
    .AddChild(new TextBlock().Text("1"))
    .AddChild(new TextBlock().Text("2").Row(0).Column(1))
    .AddChild(new TextBlock().Text("3").Row(0).Column(2))
    .Spacing(10)
    .Padding(10)
    .CornerRadius(10);
// doc ⬇️
```

> Custom Methods

### Padding (double padding)
Sets the distance between the `border` and its child object. The default value is `0`.

### Padding (double left, double top, double right, double bottom)
Sets the distance between the `border` and its child object. The default value is `left: 0, top: 0, right: 0, bottom: 0.`

### Padding (double horizontal, double vertical)
Sets the distance between the `border` and its child object. The default value is `horizontal: 0, vertical: 0.`

### CornerRadius (double cornerRadius)
Sets the `radius` for the `corners` of the panel's border. The default is `0`.

### CornerRadius (double topLeftRight, double bottomRightLeft)
Sets the `radius` for the `corners` of the panel's border. The default is `topLeftRight: 0, bottomRightLeft: 0.`

### CornerRadius (double topLeft, double topRight, double bottomRight, double bottomLeft)
Sets the `radius` for the `corners` of the panel's border. The default is `top-left: 0, top-right: 0, bottom-right: 0, bottom-left: 0.`

### BorderThickness (double thickness)
Sets the `border thickness` of the panel. The default is `0`.

### BorderThickness (double leftRight, double topBottom)
Sets the `border thickness` of the panel. The default `leftRight and topBottom is 0.`

### BorderThickness (double left, double top, double right, double bottom)
Sets the `border thickness` of the panel. The default is `left: 0, top: 0, right: 0, bottom: 0.`

### BorderBrush (Color colors)
Sets a `brush` that describes the border fill of the panel. The default is `null`, (a null brush) which is evaluated as Transparent for rendering.

### Spacing (double spacing)
Sets the `uniform distance (in pixels)` between grid `rows` and grid `columns`.

### Spacing (double rowSpacing, double columnSpacing)
Sets the `uniform distance (in pixels)` between grid `rows` and grid `columns`.

### RowDefinition (RowDefinition rowDefinition))
Add a `RowDefinition` to the `RowDefinitions collection` of the `Grid`.

### ColumnDefinition (ColumnDefinition columnDefinition))
Add a `ColumnDefinition` to the `ColumnDefinitions collection` of the `Grid`.

### RowDefinitions (params RowDefinition[] rowDefinitions)
Add `rows` as a `params` array of `RowDefinition` to the RowDefinitions collection of the `Grid`.

### ColumnDefinitions (params ColumnDefinition[] columnDefinitions)
Add `columns` as a `params` array of `ColumnDefinition` to the ColumnDefinitions collection of the `Grid`.

### Rows (params string[] rows)
Add `Rows` as a `params` array of `string` to the RowDefinitions collection of the `Grid`.
```csharp
var grid = new Grid()
  .Rows("Auto", "*", "2*", "200");
```

### Columns (params string[] columns)
Add `Columns` as a `params` array of `string` to the ColumnDefinitions collection of the `Grid`.
```csharp
var grid = new Grid()
	.Columns("*", "Auto", "2*", "200");
```

---
> WinUI Methods

### Padding
### CornerRadius
### BorderThickness
### BorderBrush
### RowSpacing
### ColumnSpacing
### BackgroundSizing