# IconElement
## FontIconMarkup

```csharp
using UWP.Markup;
using UWP.Markup.IconElement;
using Windows.UI.Text;

FontIcon fontIcon = new FontIcon()
    .Glyph("\uE8E5")
    .FontWeight(FontWeights.Bold)
    .FontSize(20)
    .FontFamily(new FontFamily("Segoe MDL2 Assets"))
    .IsTextScaleFactorEnabled(true)
    .MirroredWhenRightToLeft(true)
    .Foreground(new SolidColorBrush(Colors.Red)); // more...
```

### Glyph
Sets the character code that identifies the icon glyph.

### FontWeight
Sets the thickness of the icon glyph. The default is `Normal`.

### FontSize
Sets the size of the icon glyph.

### FontFamily
Sets the font used to display the icon glyph.

### IsTextScaleFactorEnabled
Sets whether automatic text enlargement, to reflect the system text size setting, is enabled.

### MirroredWhenRightToLeft
Sets a value that indicates whether the icon mirrored when the FlowDirection is `RightToLeft`. The default is `false`.