# Markup
## CaptureElementMarkup

```csharp
using UWP.Markup;
using Windows.Media.Capture;

var value = new CaptureElement()
    .Stretch(Stretch.Uniform)
    .Source(new MediaCapture());
```

> WinUI Methods
### Stretch(Stretch stretch)
Sets how content from Source is resized to fill its allocated space, as declared by the `Height` and `Width` properties of the `CaptureElement`.

### Source(MediaCapture source)
Sets the source `MediaCapture` that this CaptureElement represents.