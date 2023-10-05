using System;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;
using Windows.UI;

namespace UWP.Markup;

/// <summary>
/// Represents the base class for UI elements that use a ControlTemplate to define
/// their appearance. Parent class for ContentControl, UserControl, ItemsControl
/// and several practical controls.
/// </summary>
public static class ControlMarkup
{
    /// <summary>
    /// Sets the padding inside a control. The default is a Thickness with values of 0 on all four sides.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, Thickness thickness) where T : Control
    {
        element.Padding = thickness;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether a control is included in tab navigation.
    /// The default is **true**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isTabStop"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T IsTabStop<T>(this T element, bool isTabStop) where T : Control
    {
        element.IsTabStop = isTabStop;
        return element;
    }

    /// <summary>
    /// Sets a value indicating whether the user can interact with the control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isEnabled"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T IsEnabled<T>(this T element, bool isEnabled) where T : Control
    {
        element.IsEnabled = isEnabled;
        return element;
    }

    /// <summary>
    /// Sets the horizontal alignment of the control's content. The default is <see cref="HorizontalAlignment.Left"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="horizontalAlignment"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T HorizontalContentAlignment<T>(this T element, HorizontalAlignment horizontalAlignment) where T : Control
    {
        element.HorizontalContentAlignment = horizontalAlignment;
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the foreground color. The default value is a SolidColorBrush with color of Black.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="foreground"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Foreground<T>(this T element, Brush foreground) where T : Control
    {
        element.Foreground = foreground;
        return element;
    }

    /// <summary>
    /// Sets the thickness of the specified font. The default is **Normal**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontWeight"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T FontWeight<T>(this T element, FontWeight fontWeight) where T : Control
    {
        element.FontWeight = fontWeight;
        return element;
    }

    /// <summary>
    /// Sets the style in which the text is rendered. The default is **Normal**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="style"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T FontStyle<T>(this T element, FontStyle style) where T : Control
    {
        element.FontStyle = style;
        return element;
    }

    /// <summary>
    /// Sets the degree to which a font is condensed or expanded on the screen.
    /// The default is **Normal**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontStretch"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T FontStretch<T>(this T element, FontStretch fontStretch) where T : Control
    {
        element.FontStretch = fontStretch;
        return element;
    }

    /// <summary>
    /// Sets the size of the text in this control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontSize"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T FontSize<T>(this T element, double fontSize) where T : Control
    {
        element.FontSize = fontSize;
        return element;
    }

    /// <summary>
    /// Sets the font used to display text in the control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="fontFamily"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T FontFamily<T>(this T element, FontFamily fontFamily) where T : Control
    {
        element.FontFamily = fontFamily;
        return element;
    }

    /// <summary>
    /// Sets a value that determines the order in which elements receive focus
    /// when the user navigates through controls by pressing the Tab key.
    /// The default value is MaxValue.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="index"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T TabIndex<T>(this T element, int index) where T : Control
    {
        element.TabIndex = index;
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
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T CharacterSpacing<T>(this T element, int spacing) where T : Control
    {
        element.CharacterSpacing = spacing;
        return element;
    }

    /// <summary>
    /// Sets the border thickness of a control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, Thickness thickness) where T : Control
    {
        element.BorderThickness = thickness;
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the border fill of a control.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T BorderBrush<T>(this T element, Brush brush) where T : Control
    {
        element.BorderBrush = brush;
        return element;
    }

    /// <summary>
    /// Sets a value that modifies how tabbing and TabIndex work for this control.
    /// The default is **Local**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="mode"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T TabNavigation<T>(this T element, KeyboardNavigationMode mode) where T : Control
    {
        element.TabNavigation = mode;
        return element;
    }

    /// <summary>
    /// Sets a brush that provides the background of the control.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="brush"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Background<T>(this T element, Brush brush) where T : Control
    {
        element.Background = brush;
        return element;
    }

    /// <summary>
    /// Sets the vertical alignment of the control's content. The default is **Top**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="verticalAlignment"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T VerticalContentAlignment<T>(this T element, VerticalAlignment verticalAlignment) where T : Control
    {
        element.VerticalContentAlignment = verticalAlignment;
        return element;
    }

    /// <summary>
    /// Sets a control template. The control template defines the visual appearance
    /// of a control in UI, and is defined in XAML markup.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="template"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Template<T>(this T element, ControlTemplate template) where T : Control
    {
        element.Template = template;
        return element;
    }

    /// <summary>
    /// Sets whether automatic text enlargement, to reflect the system text size
    /// setting, is enabled.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isTextScaleFactorEnabled"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T IsTextScaleFactorEnabled<T>(this T element, bool isTextScaleFactorEnabled) where T : Control
    {
        element.IsTextScaleFactorEnabled = isTextScaleFactorEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the control uses focus visuals that
    /// are drawn by the system or those defined in the control template.
    /// The default is **false**; see Remarks.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="useSystemFocusVisuals"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T UseSystemFocusVisuals<T>(this T element, bool useSystemFocusVisuals) where T : Control
    {
        element.UseSystemFocusVisuals = useSystemFocusVisuals;
        return element;
    }

    /// <summary>
    /// sets the object that gets focus when a user presses the Directional Pad (D-pad) up.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="xyFocusUp"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T XYFocusUp<T>(this T element, DependencyObject xyFocusUp) where T : Control
    {
        element.XYFocusUp = xyFocusUp;
        return element;
    }

    /// <summary>
    /// Sets the object that gets focus when a user presses the Directional Pad (D-pad) right.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="xyFocusRight"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T XYFocusRight<T>(this T element, DependencyObject xyFocusRight) where T : Control
    {
        element.XYFocusRight = xyFocusRight;
        return element;
    }

    /// <summary>
    /// Sets the object that gets focus when a user presses the Directional Pad (D-pad) left.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="xyFocusLeft"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T XYFocusLeft<T>(this T element, DependencyObject xyFocusLeft) where T : Control
    {
        element.XYFocusLeft = xyFocusLeft;
        return element;
    }

    /// <summary>
    /// Sets the object that gets focus when a user presses the Directional Pad (D-pad) down.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="xyFocusDown"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T XYFocusDown<T>(this T element, DependencyObject xyFocusDown) where T : Control
    {
        element.XYFocusDown = xyFocusDown;
        return element;
    }

    /// <summary>
    /// Sets whether a UI element supports mouse mode, which emulates pointer
    /// interaction experiences with non-pointer input devices such as an Xbox gamepad
    /// or remote control. The default is **Never**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="requiresPointer"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T RequiresPointer<T>(this T element, RequiresPointer requiresPointer) where T : Control
    {
        element.RequiresPointer = requiresPointer;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether focus can be constrained within the
    /// control boundaries (for game pad/remote interaction).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isFocusEngagementEnabled"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T IsFocusEngagementEnabled<T>(this T element, bool isFocusEngagementEnabled) where T : Control
    {
        element.IsFocusEngagementEnabled = isFocusEngagementEnabled;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether focus is constrained within the control
    /// boundaries (for game pad/remote interaction).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isFocusEngaged"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T IsFocusEngaged<T>(this T element, bool isFocusEngaged) where T : Control
    {
        element.IsFocusEngaged = isFocusEngaged;
        return element;
    }

    /// <summary>
    /// Sets a value that specifies a control's preference for whether sounds are played.
    /// The default is **Auto**.
    /// <list type="bullet">
    /// <item> Windows version: 1607, SDK version 14393 </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="elementSoundMode"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T ElementSoundMode<T>(this T element, ElementSoundMode elementSoundMode) where T : Control
    {
        element.ElementSoundMode = elementSoundMode;
        return element;
    }

    /// <summary>
    /// Sets the path to the resource file that contains the default style for the control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="resourceUri"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T DefaultStyleResourceUri<T>(this T element, Uri resourceUri) where T : Control
    {
        element.DefaultStyleResourceUri = resourceUri;
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the control's border.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, CornerRadius cornerRadius) where T : Control
    {
        element.CornerRadius = cornerRadius;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates how far the background extends in relation
    /// to this element's border. The default is **InnerBorderEdge**.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="backgroundSizing"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T GetTBackgroundSizing<T>(this T element, BackgroundSizing backgroundSizing) where T : Control
    {
        element.BackgroundSizing = backgroundSizing;
        return element;
    }

    #region UWP_Toolkit.Markup Functions v0.0.1
    /// <summary>
    /// Sets the padding inside a control. The default value is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="padding"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double padding = 0) where T : Control
    {
        element.Padding = new Thickness(padding);
        return element;
    }

    /// <summary>
    /// Sets the padding inside a control. The default value is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
    {
        element.Padding = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets the padding inside a control. The default value is horizontal: 0, vertical: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Padding<T>(this T element, double horizontal = 0, double vertical = 0) where T : Control
    {
        element.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
        return element;
    }

    /// <summary>
    /// Sets The horizontal and vertical alignment of the control's content.
    /// The default is <see cref="HorizontalAlignment.Left"/> and <see cref="VerticalAlignment.Top"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="horizontalAlignment"></param>
    /// <param name="verticalAlignment"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T ContentAlignment<T>(this T element, HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left, VerticalAlignment verticalAlignment = VerticalAlignment.Top) where T : Control
    {
        element.HorizontalContentAlignment = horizontalAlignment;
        element.VerticalContentAlignment = verticalAlignment;
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the foreground color. The default value is a SolidColorBrush with color of Black.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="color"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Foreground<T>(this T element, Color color) where T : Control
    {
        element.Foreground = new SolidColorBrush(color);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of a control. The default is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="thickness"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double thickness = 0) where T : Control
    {
        element.BorderThickness = new Thickness(thickness);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of a control. The default leftRight and topBottom is 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="leftRight"></param>
    /// <param name="topBottom"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double leftRight = 0, double topBottom = 0) where T : Control
    {
        element.BorderThickness = new Thickness(leftRight, topBottom, leftRight, topBottom);
        return element;
    }

    /// <summary>
    /// Sets the border thickness of a control. The default is left: 0, top: 0, right: 0, bottom: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="left"></param>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T BorderThickness<T>(this T element, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : Control
    {
        element.BorderThickness = new Thickness(left, top, right, bottom);
        return element;
    }

    /// <summary>
    /// Sets a brush that describes the border fill of a control.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T BorderBrush<T>(this T element, Color colors) where T : Control
    {
        element.BorderBrush = new SolidColorBrush(colors);
        return element;
    }

    /// <summary>
    /// Sets a brush that provides the background of the control.
    /// The default is **null**, (a null brush) which is evaluated as Transparent for rendering.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="colors"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T Background<T>(this T element, Color colors) where T : Control
    {
        element.Background = new SolidColorBrush(colors);
        return element;
    }

    /// <summary>
    /// Sets the path to the resource file that contains the default style for the control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="resourceUri"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T DefaultStyleResourceUri<T>(this T element, string resourceUri) where T : Control
    {
        element.DefaultStyleResourceUri = new Uri(resourceUri);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the control's border.
    /// The default is 0.
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="cornerRadius"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double cornerRadius = 0) where T : Control
    {
        element.CornerRadius = new CornerRadius(cornerRadius);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the control's border.
    /// The default is topLeftRight: 0, bottomRightLeft: 0.
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="topLeftRight"></param>
    /// <param name="bottomRightLeft"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double topLeftRight = 0, double bottomRightLeft = 0) where T : Control
    {
        element.CornerRadius = new CornerRadius(topLeftRight, topLeftRight, bottomRightLeft, bottomRightLeft);
        return element;
    }

    /// <summary>
    /// Sets the radius for the corners of the control's border.
    /// The default is top-left: 0, top-right: 0, bottom-right: 0, bottom-left: 0.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="topLeft"></param>
    /// <param name="topRight"></param>
    /// <param name="bottomRight"></param>
    /// <param name="bottomLeft"></param>
    /// <returns>The <see cref="Control"/> instance for method chaining</returns>
    public static T CornerRadius<T>(this T element, double topLeft = 0, double topRight = 0, double bottomRight = 0, double bottomLeft = 0) where T : Control
    {
        element.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
        return element;
    }
    #endregion UWP_Toolkit.Markup Functions v0.0.1
}
