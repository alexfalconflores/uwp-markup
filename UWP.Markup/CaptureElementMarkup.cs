using Windows.Media.Capture;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UWP.Markup;

/// <summary>
/// Renders a stream from a capture device, such as a camera or webcam. CaptureElement
/// is used in conjunction with the Windows.Media.Capture.MediaCapture API, and must
/// be hooked up in the code behind.
/// </summary>
public static class CaptureElementMarkup
{
    /// <summary>
    /// Sets how content from Source is resized to fill its allocated space,
    /// as declared by the Height and Width properties of the CaptureElement.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="stretch"></param>
    /// <returns>The <see cref="CaptureElement"/> instance for method chaining</returns>
    public static CaptureElement Stretch(this CaptureElement element, Stretch stretch)
    {
        element.Stretch = stretch;
        return element;
    }

    /// <summary>
    /// Sets the source MediaCapture that this CaptureElement represents.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="source"></param>
    /// <returns>The <see cref="CaptureElement"/> instance for method chaining</returns>
    public static CaptureElement Source(this CaptureElement element, MediaCapture source)
    {
        element.Source = source;
        return element;
    }
}
