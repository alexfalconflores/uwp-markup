# Markup
## FrameworkElementMarkup

```csharp
using UWP.Markup;

var value = new Button()
    .Alignment(VerticalAlignment.Center, HorizontalAlignment.Center)
    .Margin(10)
    .Content("Button")
    .Row(1).Column(1)
    .RowSpan(2)
    .ColumnSpan(2);

var value2 = new Button()
    .Alignment((VerticalAlignment.Center, HorizontalAlignment.Center)) //tuple
    .Margin(10)
    .Content("Button")
    .Row(1).Column(1)
    .RowSpan(2)
    .ColumnSpan(2);
// doc ⬇️
```

> Custom Methods

### Alignment (VerticalAlignment verticalAlignment, HorizontalAlignment horizontalAlignment)
Sets the `vertical` and `horizontal` alignment characteristics that are applied to a `FrameworkElement` when it is composed in a `parent` object such as a `panel` or `items control`. The default `vertical` and `horizontal` value is `Stretch`.

### Alignment ((VerticalAlignment vertical, HorizontalAlignment horizontal) alignment)
Sets the `vertical` and `horizontal` alignment `tuple` characteristics that are applied to a `FrameworkElement` when it is composed in a `parent` object such as a `panel` or `items control`.

### Margin (double margin)
Sets the outer `margin` of a `FrameworkElement`.The default value is `0`.

### Margin (double left, double top, double right, double bottom)
Sets the outer `margin` of a `FrameworkElement`.The default value is `left: 0, top: 0, right: 0, bottom: 0.`

### Margin (double horizontal, double vertical)
Sets the outer `margin` of a `FrameworkElement`.The default value is `horizontal: 0, vertical: 0.`

### Row (int row)
Sets the value of the `Grid.Row` XAML attached property on the specified `FrameworkElement`. 

### Column (int column)
Sets the value of the `Grid.Column` XAML attached property on the specified `FrameworkElement`.

### RowSpan (int rowSpan)
Sets the value of the `Grid.RowSpan` XAML attached property on the specified `FrameworkElement`.

### ColumnSpan (int columnSpan)
Sets the value of the `Grid.ColumnSpan` XAML attached property on the specified `FrameworkElement`.

---
> WinUI Methods

### Width
### VerticalAlignment
### Tag
### Style
### Resources
### Name
### MinWidth
### MinHeight
### MaxWidth
### MaxHeight
### Margin
### Language
### HorizontalAlignment
### Height
### FlowDirection
### DataContext
### RequestedTheme
### FocusVisualSecondaryThickness
### FocusVisualSecondaryBrush
### FocusVisualPrimaryThickness
### FocusVisualPrimaryBrush
### FocusVisualMargin
### AllowFocusWhenDisabled
### AllowFocusOnInteraction