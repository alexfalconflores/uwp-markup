using Windows.UI.Text;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI;

namespace UWP.Markup;

/// <summary>
/// Defines the extension methods for the <see cref="TextBlock"/> class.
/// </summary>
public static class TextBlockMarkup
{
    /// <summary>
    /// Sets how the TextBlock wraps text. The default is **NoWrap**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="textWrapping"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock TextWrapping(this TextBlock element, TextWrapping textWrapping)
    {
        element.TextWrapping = textWrapping;
        return element;
    }

    /// <summary>
    /// Sets the text trimming behavior to employ when content overflows the content area. The default is **None**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="textTrimming"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock TextTrimming(this TextBlock element, TextTrimming textTrimming)
    {
        element.TextTrimming = textTrimming;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the horizontal alignment of text content. The default is **Left**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="textAlignment"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock TextAlignment(this TextBlock element, TextAlignment textAlignment)
    {
        element.TextAlignment = textAlignment;
        return element;
    }

    /// <summary>
    /// Sets the text contents of a TextBlock. The default is an empty string.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="text"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock Text(this TextBlock element, string text)
    {
        element.Text = text;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the thickness of padding space between the
    /// boundaries of the content area and the content displayed by a TextBlock.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock Padding(this TextBlock element, Thickness padding)
    {
        element.Padding = padding;
        return element;
    }

    /// <summary>
    /// Sets the Brush to apply to the text contents of the TextBlock.
    /// The default is a null brush from a pure code perspective,
    /// but the default text styles set this to Black (for **Light**
    /// theme) or White (for **Dark** theme) for a TextBlock element in UI.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock Foreground(this TextBlock element, Brush brush)
    {
        element.Foreground = brush;
        return element;
    }

    /// <summary>
    /// Sets the top-level font weight for the TextBlock. The default is **Normal**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontWeight"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock FontWeight(this TextBlock element, FontWeight fontWeight)
    {
        element.FontWeight = fontWeight;
        return element;
    }

    /// <summary>
    /// Sets the font stretch for the text content in this element. The default is **Normal**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontStretch"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock FontStretch(this TextBlock element, FontStretch fontStretch)
    {
        element.FontStretch = fontStretch;
        return element;
    }

    /// <summary>
    /// Sets the font style for the content in this element. The default is **Normal**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontStyle"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock FontStyle(this TextBlock element, FontStyle fontStyle)
    {
        element.FontStyle = fontStyle;
        return element;
    }

    /// <summary>
    /// Sets the font size for the text content in this element. The default is **11**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontSize"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock FontSize(this TextBlock element, double fontSize)
    {
        element.FontSize = fontSize;
        return element;
    }

    /// <summary>
    /// Sets the preferred top-level font family for the text content in this element.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="fontFamily"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock FontFamily(this TextBlock element, FontFamily fontFamily)
    {
        element.FontFamily = fontFamily;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how a line box is determined for each line
    /// of text in the TextBlock. The default is **MaxHeight**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="lineStackingStrategy"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock LineStackingStrategy(this TextBlock element, LineStackingStrategy lineStackingStrategy)
    {
        element.LineStackingStrategy = lineStackingStrategy;
        return element;
    }

    /// <summary>
    /// Sets the height of each line of content. The default is 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="lineHeight"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock LineHeight(this TextBlock element, double lineHeight)
    {
        element.LineHeight = lineHeight;
        return element;
    }

    /// <summary>
    /// Sets the uniform spacing between characters, in units of 1/1000 of an em.
    /// The default is 0. Positive values increase tracking and loosen character spacing.
    /// Negative values decrease tracking and tighten the character spacing.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="characterSpacing"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock CharacterSpacing(this TextBlock element, int characterSpacing)
    {
        element.CharacterSpacing = characterSpacing;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether text selection is enabled in the
    /// TextBlock, either through user action or calling selection-related API.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isTextSelectionEnabled"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock IsTextSelectionEnabled(this TextBlock element, bool isTextSelectionEnabled)
    {
        element.IsTextSelectionEnabled = isTextSelectionEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how the reading order is determined for the TextBlock.
    /// The default is **DetectFromContent**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="textReadingOrder"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock TextReadingOrder(this TextBlock element, TextReadingOrder textReadingOrder)
    {
        element.TextReadingOrder = textReadingOrder;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how the line box height is determined for
    /// each line of text in the TextBlock. The default is **Full**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="textLineBounds"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock TextLineBounds(this TextBlock element, TextLineBounds textLineBounds)
    {
        element.TextLineBounds = textLineBounds;
        return element;
    }

    /// <summary>
    /// Sets the brush used to highlight the selected text. The default is a null brush from
    /// a pure code perspective, but the system uses base text styles to supply a runtime
    /// value for apps (unless you specifically override that style). The practical default
    /// is a brush using the theme resource **TextSelectionHighlightThemeColor**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="solidColorBrush"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock SelectionHighlightColor(this TextBlock element, SolidColorBrush solidColorBrush)
    {
        element.SelectionHighlightColor = solidColorBrush;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how the font is modified to align with fonts of different sizes.
    /// The default is **None**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="opticalMarginAlignment"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock OpticalMarginAlignment(this TextBlock element, OpticalMarginAlignment opticalMarginAlignment)
    {
        element.OpticalMarginAlignment = opticalMarginAlignment;
        return element;
    }

    /// <summary>
    /// Sets the maximum number of lines of text shown in the TextBlock.
    /// The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="maxLines"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock MaxLines(this TextBlock element, int maxLines)
    {
        element.MaxLines = maxLines;
        return element;
    }

    /// <summary>
    /// Sets a value that determines whether font glyphs that contain color layers,
    /// such as Segoe UI Emoji, are rendered in color. The default is **true**.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isColorFontEnabled"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock IsColorFontEnabled(this TextBlock element, bool isColorFontEnabled)
    {
        element.IsColorFontEnabled = isColorFontEnabled;
        return element;
    }

    /// <summary>
    /// Sets whether automatic text enlargement, to reflect the system text size setting,is enabled.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="isTextScaleFactorEnabled"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock IsTextScaleFactorEnabled(this TextBlock element, bool isTextScaleFactorEnabled)
    {
        element.IsTextScaleFactorEnabled = isTextScaleFactorEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates what decorations are applied to the text. The default is **None**.
    /// <list type="bullet">
    /// <item> Windows version: 1703, SDK version 15063 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="textDecorations"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock TextDecorations(this TextBlock element, TextDecorations textDecorations)
    {
        element.TextDecorations = textDecorations;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how text is aligned in the TextBlock. The default is **Left**.
    /// <list type="bullet">
    /// <item> Windows version: 1709, SDK version 16299 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="textAlignment"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock HorizontalTextAlignment(this TextBlock element, TextAlignment textAlignment)
    {
        element.HorizontalTextAlignment = textAlignment;
        return element;
    }

    /// <summary>
    /// Sets the flyout that is shown when text is selected using touch or pen, or **null** if no flyout is shown.
    /// The default is an instance of TextCommandBarFlyout.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <param name="element"></param>
    /// <param name="flyout"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock SelectionFlyout(this TextBlock element, FlyoutBase flyout)
    {
        element.SelectionFlyout = flyout;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets a value that indicates the thickness of padding space between the
    /// boundaries of the content area and the content displayed by a TextBlock.
    /// The default value is 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock Padding(this TextBlock element, double padding = 0)
    {
        element.Padding = new Thickness(padding);
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the thickness of padding space between the
    /// boundaries of the content area and the content displayed by a TextBlock.
    /// The default value is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock Padding(this TextBlock element, double left = 0, double top = 0, double right = 0, double bottom = 0)
    {
        element.Padding = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets a value that indicates the thickness of padding space between the
    /// boundaries of the content area and the content displayed by a TextBlock.
    /// The default value is horizontal: 0, vertical: 0.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="horizontal"></param>
    /// <param name="vertical"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock Padding(this TextBlock element, double horizontal = 0, double vertical = 0)
    {
        element.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
        return element;
    }

    /// <summary>
    /// Sets the Brush to apply to the text contents of the TextBlock.
    /// The default is a null brush from a pure code perspective,
    /// but the default text styles set this to Black (for **Light**
    /// theme) or White (for **Dark** theme) for a TextBlock element in UI.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="color"></param>
    /// <returns>The <see cref="TextBlock"/> instance for method chaining</returns>
    public static TextBlock Foreground(this TextBlock element, Color color)
    {
        element.Foreground = new SolidColorBrush(color);
        return element;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
