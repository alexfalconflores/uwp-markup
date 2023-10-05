using Windows.UI.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UWP.Markup.IconElement;

/// <summary>
/// Provides extension methods for configuring a <see cref="FontIcon"/> in XAML markup.
/// </summary>
public static class FontIconMarkup
{
    /// <summary>
    /// Sets the character code that identifies the icon glyph.
    /// </summary>
    /// <remarks >
    /// Glyph("\uE8BB").
    /// </remarks>
    /// <param name="element"></param>
    /// <param name="characterCode"></param>
    /// <returns>The <see cref="FontIcon"/> instance for method chaining</returns>
    public static FontIcon Glyph(this FontIcon element, string characterCode)
    {
        element.Glyph = characterCode;
        return element;
    }

    /// <summary>
    /// Sets the thickness of the icon glyph. The default is **Normal**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontWeight"></param>
    /// <returns>The <see cref="FontIcon"/> instance for method chaining</returns>
    public static FontIcon FontWeight(this FontIcon element, FontWeight fontWeight)
    {
        element.FontWeight = fontWeight;
        return element;
    }

    /// <summary>
    /// Sets the size of the icon glyph.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontSize"></param>
    /// <returns>The <see cref="FontIcon"/> instance for method chaining</returns>
    public static FontIcon FontSize(this FontIcon element, double fontSize)
    {
        element.FontSize = fontSize;
        return element;
    }

    /// <summary>
    /// Sets the font used to display the icon glyph.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontFamily"></param>
    /// <returns>The <see cref="FontIcon"/> instance for method chaining</returns>
    public static FontIcon FontFamily(this FontIcon element, FontFamily fontFamily)
    {
        element.FontFamily = fontFamily;
        return element;
    }

    /// <summary>
    /// Sets whether automatic text enlargement, to reflect the system text size setting, is enabled.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isTextScaleFactorEnabled"></param>
    /// <returns>The <see cref="FontIcon"/> instance for method chaining</returns>
    public static FontIcon IsTextScaleFactorEnabled(this FontIcon element, bool isTextScaleFactorEnabled)
    {
        element.IsTextScaleFactorEnabled = isTextScaleFactorEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the icon mirrored when the FlowDirection is **RightToLeft**. The default is **false**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="mirroredWhenRightToLeft"></param>
    /// <returns>The <see cref="FontIcon"/> instance for method chaining</returns>
    public static FontIcon MirroredWhenRightToLeft(this FontIcon element, bool mirroredWhenRightToLeft)
    {
        element.MirroredWhenRightToLeft = mirroredWhenRightToLeft;
        return element;
    }
}
