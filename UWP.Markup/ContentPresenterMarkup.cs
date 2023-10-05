using Windows.UI.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI;

namespace UWP.Markup;

/// <summary>
/// Provides extension methods for configuring a <see cref="ContentPresenter"/> in XAML markup.
/// </summary>
public static class ContentPresenterMarkup
{
    /// <summary>
    /// Sets the Brush to apply to the text content handled by the ContentPresenter.
    /// The default is a null brush from a pure code perspective, but system style defaults set this
    /// to Black (for **Light** theme) or White (for **Dark** theme).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="foreground"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Foreground<T>(this T element, Brush foreground) where T : ContentPresenter
    {
        element.Foreground = foreground;
        return element;
    }

    /// <summary>
    /// Sets the top-level font weight for the text content presented by the ContentPresenter.
    /// The default is Normal.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontWeight"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T FontWeight<T>(this T element, FontWeight fontWeight) where T : ContentPresenter
    {
        element.FontWeight = fontWeight;
        return element;
    }

    /// <summary>
    /// Sets the font style for the presented content. The default is Normal.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="style"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T FontStyle<T>(this T element, FontStyle style) where T : ContentPresenter
    {
        element.FontStyle = style;
        return element;
    }

    /// <summary>
    /// Sets the font stretch for the text content presented by the ContentPresenter.
    /// The default is **Normal**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontStretch"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T FontStretch<T>(this T element, FontStretch fontStretch) where T : ContentPresenter
    {
        element.FontStretch = fontStretch;
        return element;
    }

    /// <summary>
    /// Sets the font size for the text content presented by the ContentPresenter.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontSize"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T FontSize<T>(this T element, double fontSize) where T : ContentPresenter
    {
        element.FontSize = fontSize;
        return element;
    }

    /// <summary>
    /// Sets the preferred top-level font family for the text content presented
    /// by the ContentPresenter.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontFamily"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T FontFamily<T>(this T element, FontFamily fontFamily) where T : ContentPresenter
    {
        element.FontFamily = fontFamily;
        return element;
    }

    /// <summary>
    /// Sets the collection of Transition style elements that apply to content
    /// presented by the ContentPresenter.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transitions"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T ContentTransitions<T>(this T element, TransitionCollection transitions) where T : ContentPresenter
    {
        element.ContentTransitions = transitions;
        return element;
    }

    /// <summary>
    /// Sets a selection object that changes the DataTemplate to apply for content
    /// presented in the ContentPresenter, based on processing information about the
    /// content item or its container at run time.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="selector"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T ContentTemplateSelector<T>(this T element, DataTemplateSelector selector) where T : ContentPresenter
    {
        element.ContentTemplateSelector = selector;
        return element;
    }

    /// <summary>
    /// Sets the template that is used to display the content of the control.
    /// The default is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="template"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T ContentTemplate<T>(this T element, DataTemplate template) where T : ContentPresenter
    {
        element.ContentTemplate = template;
        return element;
    }

    /// <summary>
    /// Sets the data that is used to generate the child elements of a ContentPresenter.
    /// The default is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="content"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Content<T>(this T element, object content) where T : ContentPresenter
    {
        element.Content = content;
        return element;
    }

    /// <summary>
    /// Sets the uniform spacing between characters, in units of 1/1000 of an em.
    /// The default is 0. Positive values increase tracking and loosen character spacing. Negative
    /// values decrease tracking and tighten the character spacing.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="spacing"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T CharacterSpacing<T>(this T element, int spacing) where T : ContentPresenter
    {
        element.CharacterSpacing = spacing;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how the line box height is determined for
    /// each line of text displayed in the ContentPresenter.
    /// The default is **Full**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="bounds"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T TextLineBounds<T>(this T element, TextLineBounds bounds) where T : ContentPresenter
    {
        element.TextLineBounds = bounds;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how the font is modified to align with fonts of different sizes.
    /// The default is **None**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="alignment"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T OpticalMarginAlignment<T>(this T element, OpticalMarginAlignment alignment) where T : ContentPresenter
    {
        element.OpticalMarginAlignment = alignment;
        return element;
    }

    /// <summary>
    /// Sets whether automatic text enlargement, to reflect the system text size setting, is enabled.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isEnabled"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T IsTextScaleFactorEnabled<T>(this T element, bool isEnabled) where T : ContentPresenter
    {
        element.IsTextScaleFactorEnabled = isEnabled;
        return element;
    }

    /// <summary>
    /// Sets the vertical alignment of the content.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="alignment"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T VerticalContentAlignment<T>(this T element, VerticalAlignment alignment) where T : ContentPresenter
    {
        element.VerticalContentAlignment = alignment;
        return element;
    }

    /// <summary>
    /// Sets how the element wraps text.
    /// The default is **NoWrap**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="wrapping"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T TextWrapping<T>(this T element, TextWrapping wrapping) where T : ContentPresenter
    {
        element.TextWrapping = wrapping;
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, Thickness padding) where T : ContentPresenter
    {
        element.Padding = padding;
        return element;
    }

    /// <summary>
    /// Sets the maximum lines of text shown.
    /// The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="maxLines"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T MaxLines<T>(this T element, int maxLines) where T : ContentPresenter
    {
        element.MaxLines = maxLines;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how a line box is determined for each line of text.
    /// The default is **MaxHeight**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="strategy"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T LineStackingStrategy<T>(this T element, LineStackingStrategy strategy) where T : ContentPresenter
    {
        element.LineStackingStrategy = strategy;
        return element;
    }

    /// <summary>
    /// Sets the height of each line of text content presented by the ContentPresenter.
    /// The default is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="height"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T LineHeight<T>(this T element, double height) where T : ContentPresenter
    {
        element.LineHeight = height;
        return element;
    }

    /// <summary>
    /// Sets the horizontal alignment of the content.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="alignment"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T HorizontalContentAlignment<T>(this T element, HorizontalAlignment alignment) where T : ContentPresenter
    {
        element.HorizontalContentAlignment = alignment;
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the content presenter's border.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, CornerRadius cornerRadius) where T : ContentPresenter
    {
        element.CornerRadius = cornerRadius;
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the content presenter.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, Thickness thickness) where T : ContentPresenter
    {
        element.BorderThickness = thickness;
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the border fill of the content presenter.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BorderBrush<T>(this T element, Brush brush) where T : ContentPresenter
    {
        element.BorderBrush = brush;
        return element;
    }

    /// <summary>
    /// Sets the Brush to apply to the background of content handled by the ContentPresenter.
    /// The default is a null brush from a pure code perspective, but system style defaults set this to White
    /// (for **Light** theme) or Black (for **Dark** theme).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Background<T>(this T element, Brush brush) where T : ContentPresenter
    {
        element.Background = brush;
        return element;
    }

    /// <summary>
    /// Sets an instance of BrushTransition to automatically animate changes
    /// to the Background property. The default is **null**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="transitions"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BackgroundTransition<T>(this T element, BrushTransition transitions) where T : ContentPresenter
    {
        element.BackgroundTransition = transitions;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how far the background extends in relation
    /// to this element's border. The default is **InnerBorderEdge**.
    /// <list type="bullet">
    /// <item> Windows version: 1809, SDK version 17763 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="sizing"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BackgroundSizing<T>(this T element, BackgroundSizing sizing) where T : ContentPresenter
    {
        element.BackgroundSizing = sizing;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the Brush to apply to the text content handled by the ContentPresenter.
    /// The default is a null brush from a pure code perspective, but system style defaults set this
    /// to Black (for **Light** theme) or White (for **Dark** theme).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="color"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Foreground<T>(this T element, Color color) where T : ContentPresenter
    {
        element.Foreground = new SolidColorBrush(color);
        return element;
    }

    /// <summary>
    /// Sets The horizontal and vertical alignment of the content.
    /// The default is <see cref="HorizontalAlignment.Left"/> and <see cref="VerticalAlignment.Top"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="horizontalAlignment"></param>
    /// <param name="verticalAlignment"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T ContentAlignment<T>(this T element, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left, VerticalAlignment verticalAlignment = VerticalAlignment.Top) where T : ContentPresenter
    {
        element.HorizontalContentAlignment = horizontalAlignment;
        element.VerticalContentAlignment = verticalAlignment;
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object. The default value is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double padding = 0) where T : ContentPresenter
    {
        element.Padding = new Thickness(padding);
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object. The default value is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : ContentPresenter
    {
        element.Padding = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets the distance between the border and its child object. The default value is horizontal: 0, vertical: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double horizontal = 0, double vertical = 0) where T : ContentPresenter
    {
        element.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the content presenter's border.
    /// The default is 0.
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double cornerRadius = 0) where T : ContentPresenter
    {
        element.CornerRadius = new CornerRadius(cornerRadius);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the content presenter's border.
    /// The default is topLeftRight: 0, bottomRightLeft: 0.
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="topLeftRight"></param>
    /// <param name="bottomRightLeft"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double topLeftRight = 0, double bottomRightLeft = 0) where T : ContentPresenter
    {
        element.CornerRadius = new CornerRadius(topLeftRight, topLeftRight, bottomRightLeft, bottomRightLeft);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the content presenter's border.
    /// The default is top-left: 0, top-right: 0, bottom-right: 0, bottom-left: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="topLeft"></param>
    /// <param name="topRight"></param>
    /// <param name="bottomRight"></param>
    /// <param name="bottomLeft"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double topLeft = 0, double topRight = 0, double bottomRight = 0, double bottomLeft = 0) where T : ContentPresenter
    {
        element.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the content presenter. The default is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double thickness = 0) where T : ContentPresenter
    {
        element.BorderThickness = new Thickness(thickness);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the content presenter. The default leftRight and topBottom is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="leftRight"></param>
    /// <param name="topBottom"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double leftRight = 0, double topBottom = 0) where T : ContentPresenter
    {
        element.BorderThickness = new Thickness(leftRight, topBottom, leftRight, topBottom);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of the content presenter. The default is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : ContentPresenter
    {
        element.BorderThickness = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the border fill of the content presenter.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T BorderBrush<T>(this T element, Color colors) where T : ContentPresenter
    {
        element.BorderBrush = new SolidColorBrush(colors);
        return element;
    }

    /// <summary>
    /// Sets the Brush to apply to the background of content handled by the ContentPresenter.
    /// The default is a null brush from a pure code perspective, but system style defaults set this to White
    /// (for **Light** theme) or Black (for **Dark** theme).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="ContentPresenter"/> instance for method chaining</returns>
    public static T Background<T>(this T element, Color colors) where T : ContentPresenter
    {
        element.Background = new SolidColorBrush(colors);
        return element;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
