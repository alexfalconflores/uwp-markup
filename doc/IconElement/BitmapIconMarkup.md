# IconElement
## BitmapIconMarkup

```csharp
using UWP.Markup;
using UWP.Markup.IconElement;

BitmapIcon bitmapIcon = new BitmapIcon()
     .UriSource("ms-appx:///Assets/StoreLogo.png") // +1 overload
     .ShowAsMonochrome(true)
     .Height(100)
     .Width(100); // more...
```

> Custom Methods
### UriSource(string uriSource)
Sets the `string` representation of the Uniform Resource Identifier (`Uri`) of the bitmap to use as the icon content.

```csharp
.UriSource("ms-appx:///Assets/StoreLogo.png");
```
---
> WinUI Methods

### UriSource(Uri uriSource)
Sets the Uniform Resource Identifier `Uri` of the bitmap to use as the icon content.

```csharp
.UriSource(new Uri("ms-appx:///Assets/StoreLogo.png"));
```

### ShowAsMonochrome
Sets a value that indicates whether the bitmap is shown in a single color. The default is `true`.