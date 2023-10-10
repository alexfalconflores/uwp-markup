![UWP Markup Cover](<assets/UWP Markup - cover - my library.jpg>)

> This project uses `C# 11` with the [`PolySharp`](https://github.com/Sergio0694/PolySharp/tree/main) library. The minimum version is Windows 10, `1903` (Build,18362).

> This project can be used with C# 7.2, but we recommend that you use C# 11 in your project (.csproj) and use the [`PolySharp`](https://github.com/Sergio0694/PolySharp/tree/main) library.

<br/>

[![NuGet](https://img.shields.io/nuget/dt/AlexFalconFlores.UWP.Markup.svg)](https://www.nuget.org/stats/packages/AlexFalconFlores.UWP.Markup?groupby=Version) 
[![NuGet](https://img.shields.io/nuget/vpre/AlexFalconFlores.UWP.Markup.svg)](https://www.nuget.org/packages/AlexFalconFlores.UWP.Markup/)
<a href="https://www.nuget.org/packages/AlexFalconFlores.UWP.Markup/">
    <img src="https://raw.githubusercontent.com/alexfalconflores/alexfalconflores/main/img/nuget-banner.svg" height=20 alt="Go to Nuget"/>
</a>

Applies the Fluent design pattern to WinUI controls to create interfaces in a more expressive and readable way.

Uses method chaining in the control class for cleaner, more readable code.

## Installation 📦
This project is available as a [NuGet package](https://www.nuget.org/packages/AlexFalconFlores.UWP.Markup/). You can install it using the NuGet Package Console window:
```bash
NuGet\Install-Package AlexFalconFlores.UWP.Markup -Version 1.0.0
```

## Documentation 📖
> I highlight the `custom methods` that are not `WinUI's own`, so that the `developer` can keep in mind that only WinUI's own methods will not be found. To know how to use them, I checked the `documentation`.

- 📁 Helper
  - [GridHelper](doc/Helper/GridHelper.md)
    - [StringToGridLength](doc/Helper/GridHelper.md#StringToGridLength)
- 📁 IconElement
  - [BitmapIconMarkup](doc/IconElement/BitmapIconMarkup.md)
    - [UriSource(string uriSource)](doc/IconElement/BitmapIconMarkup.md#urisourcestring-urisource)
  - [FontIconMarkup](doc/IconElement/FontIconMarkup.md)
  - [IconElementMarkup](doc/IconElement/IconElementMarkup.md)
    - [Foreground(Color color)](doc/IconElement/IconElementMarkup.md#foregroundcolor-color)
  - [PathIconMarkup](doc/IconElement/PathIconMarkup.md)
  - [SymbolIconMarkup](doc/IconElement/SymbolIconMarkup.md)
- 📁 Transition
  - [ContentThemeTransitionMarkup](doc/Transition/ContentThemeTransitionMarkup.md)
    - [Offset (double horizontalOffset, double verticalOffset)](doc/Transition/ContentThemeTransitionMarkup.md#offset-double-horizontaloffset-double-verticaloffset)
  - [EdgeUIThemeTransitionMarkup](doc/Transition/EdgeUIThemeTransitionMarkup.md)
  - [EntranceThemeTransitionMarkup](doc/Transition/EntranceThemeTransitionMarkup.md)
    - [FromOffset (double fromVerticalOffset, double fromHorizontalOffset)](doc/Transition/EntranceThemeTransitionMarkup.md#fromoffset-double-fromverticaloffset-double-fromhorizontaloffset)
  - [NavigationThemeTransitionMarkup](doc/Transition/NavigationThemeTransitionMarkup.md)
  - [PaneThemeTransitionMarkup](doc/Transition/PaneThemeTransitionMarkup.md)
  - [PopupThemeTransitionMarkup](doc/Transition/PopupThemeTransitionMarkup.md)
    - [FromOffset (double fromHorizontalOffset, double fromVerticalOffset)](doc/Transition/PopupThemeTransitionMarkup.md#fromoffset-double-fromhorizontaloffset-double-fromverticaloffset)
  - [RepositionThemeTransitionMarkup](doc/Transition/RepositionThemeTransitionMarkup.md)
  - [TransitionCollectionMarkup](doc/Transition/TransitionCollectionMarkup.md)
    - [AddTransition (Transition item)](doc/Transition/TransitionCollectionMarkup.md#addtransition-windowsuixamlmediaanimationtransition-item)
- 📁 VirtualizingPanel
  - [CarouselPanelMarkup](doc/VirtualizingPanel/CarouselPanelMarkup.md)
  - [OrientedVirtualizingPanelMarkup](doc/VirtualizingPanel/OrientedVirtualizingPanelMarkup.md)
  - [VirtualizingStackPanelMarkup](doc/VirtualizingPanel/VirtualizingStackPanelMarkup.md)
  - [WrapGridMarkup](doc/VirtualizingPanel/WrapGridMarkup.md)
- [BorderMarkup](doc/BorderMarkup.md)
  - [Padding (double padding)](doc/BorderMarkup.md#padding-double-padding)
  - [Padding (double left , double top , double right , double bottom)](doc/BorderMarkup.md#padding-double-horizontaloffset-double-left-double-top-double-right-double-bottom)
  - [Padding (double horizontal , double vertical)](doc/BorderMarkup.md#padding-double-horizontaloffset-double-horizontal-double-vertical)
  - [CornerRadius (double cornerRadius)](doc/BorderMarkup.md#cornerradius-double-cornerradius)
  - [CornerRadius (double topLeftRight , double bottomRightLeft)](doc/BorderMarkup.md#cornerradius-double-topleftright-double-bottomrightleft)
  - [CornerRadius (double topLeft, double topRight , double bottomRight , double bottomLeft)](doc/BorderMarkup.md#cornerradius-double-topleft-double-topright-double-bottomright-double-bottomleft)
  - [BorderThickness (double thickness)](doc/BorderMarkup.md#borderthickness-double-thickness)
  - [BorderThickness (double leftRight , double topBottom)](doc/BorderMarkup.md#borderthickness-double-leftright-double-topbottom)
  - [BorderThickness (double left , double top, double right , double bottom)](doc/BorderMarkup.md#borderthickness-double-left-double-top-double-right-double-bottom)
  - [BorderBrush (Color colors)](doc/BorderMarkup.md#borderbrush-color-colors)
  - [Background (Color colors)](doc/BorderMarkup.md#background-color-colors)
- [CaptureElementMarkup](doc/CaptureElementMarkup.md)
- [ColumnDefinitionMarkup](doc/ColumnDefinitionMarkup.md)
- [ContentControlMarkup](doc/ContentControlMarkup.md)
- [ContentDialogMarkup]()
  - more...
- [ContentPresenterMarkup]()
  - [Foreground (Color color)]()
  - [ContentAlignment (HorizontalAlignment horizontalAlignment , VerticalAlignment verticalAlignment)]()
  - [Padding (double padding)]()
  - [Padding (double left , double top , double right , double bottom)]()
  - [Padding (double horizontal , double vertical)]()
  - [CornerRadius (double cornerRadius)]()
  - [CornerRadius (double topLeftRight, double bottomRightLeft)]()
  - [CornerRadius (double topLeft , double topRight , double bottomRight , double bottomLeft)]()
  - [BorderThickness (double thickness)]()
  - [BorderThickness (double leftRight , double topBottom)]()
  - [BorderThickness (double left , double top , double right , double bottom)]()
  - [BorderBrush (Color colors)]()
  - [Background (Color colors)]()
  - more...
- [ControlMarkup]()
  - [Padding (double padding)]()
  - [Padding (double left , double top , double right , double bottom)]()
  - [Padding (double horizontal , double vertical)]()
  - [ContentAlignment (HorizontalAlignment horizontalAlignment , VerticalAlignment verticalAlignment)]()
  - [Foreground (Color color)]()
  - [BorderThickness (double thickness)]()
  - [BorderThickness (double leftRight , double topBottom)]()
  - [BorderThickness (double left , double top , double right , double bottom)]()
  - [BorderBrush (Color colors)]()
  - [Background (Color colors)]()
  - [DefaultStyleResourceUri (string resourceUri)]()
  - [CornerRadius (double cornerRadius)]()
  - [CornerRadius (double topLeftRight , double bottomRightLeft)]()
  - [CornerRadius (double topLeft , double topRight , double bottomRight , double bottomLeft)]()
  - more...
- [FlipViewMarkup]()
  - more...
- [FrameworkElementMarkup]()
  - [Alignment (VerticalAlignment verticalAlignment, HorizontalAlignment horizontalAlignment)]()
  - [Alignment ((VerticalAlignment vertical, HorizontalAlignment horizontal) alignment)]()
  - [Margin (double margin)]()
  - [Margin (double left , double top , double right , double bottom)]()
  - [Margin (double horizontal, double vertical)]()
  - [Row (int row)]()
  - [Column (int column)]()
  - [RowSpan (int rowSpan)]()
  - [ColumnSpan (int columnSpan)]()
- [GridMarkup]()
  - [Padding (double padding)]()
  - [Padding (double left , double top, double right , double bottom)]()
  - [Padding (double horizontal , double vertical)]()
  - [CornerRadius (double cornerRadius)]()
  - [CornerRadius (double topLeftRight, double bottomRightLeft)]()
  - [CornerRadius (double topLeft, double topRight, double bottomRight, double bottomLeft)]()
  - [BorderThickness (double thickness)]()
  - [BorderThickness (double leftRight, double topBottom)]()
  - [BorderThickness (double left, double top, double right, double bottom)]()
  - [BorderBrush (Color colors)]()
  - [Spacing (double spacing)]()
  - [Spacing (double rowSpacing, double columnSpacing)]()
  - [RowDefinition (RowDefinition rowDefinition)]()
  - [ColumnDefinition (ColumnDefinition columnDefinition)]()
  - [RowDefinitions (params RowDefinition[] rowDefinitions)]()
  - [ColumnDefinitions (params ColumnDefinition[] columnDefinitions)]()
  - [Rows (params string[] rows)]()
  - [Columns (params string[] columns)]()
  - more...
- [InfoBarMarkup]()
  - more...
- [ItemsControlMarkup]()
  - more...
- [ItemsWrapGridMarkup]()
  - [GroupPadding (double groupPadding)]()
  - [GroupPadding (double left, double top, double right, double bottom)]()
  - [GroupPadding (double horizontal , double vertical)]()
  - more...
- [PageMarkup]()
  - more...
- [PanelMarkup]()
  - [Background (Color colors)]()
  - [AddChildren (params UIElement[] items)]()
  - [AddChild (UIElement item)]()
  - [TryAddChildren (params UIElement[] items)]()
  - [TryAddChild (UIElement item)]()
- [PopupMarkup]()
  - [Offset (double horizontal, double vertical)]()
  - more...
- [RelativePanelMarkup]()
  - [Padding (double padding)]()
  - [Padding (double left , double top, double right , double bottom)]()
  - [Padding (double horizontal , double vertical)]()
  - [CornerRadius (double cornerRadius)]()
  - [CornerRadius (double topLeftRight, double bottomRightLeft)]()
  - [CornerRadius (double topLeft, double topRight, double bottomRight, double bottomLeft)]()
  - [BorderThickness (double thickness)]()
  - [BorderThickness (double leftRight, double topBottom)]()
  - [BorderThickness (double left, double top, double right, double bottom)]()
  - [BorderBrush (Color colors)]()
  - more...
- [RowDefinitionMarkup]()
  - more...
- [ScrollViewerMarkup]()
  - more...
- [SelectorMarkup]()
  - more...
- [StackPanelMarkup]()
  - [Padding (double padding)]()
  - [Padding (double left , double top, double right , double bottom)]()
  - [Padding (double horizontal , double vertical)]()
  - [CornerRadius (double cornerRadius)]()
  - [CornerRadius (double topLeftRight, double bottomRightLeft)]()
  - [CornerRadius (double topLeft, double topRight, double bottomRight, double bottomLeft)]()
  - [BorderThickness (double thickness)]()
  - [BorderThickness (double leftRight, double topBottom)]()
  - [BorderThickness (double left, double top, double right, double bottom)]()
  - [BorderBrush (Color colors)]()
  - more...
- [TextBlockMarkup]()
  - [Padding (double padding)]()
  - [Padding (double left , double top, double right , double bottom)]()
  - [Padding (double horizontal , double vertical)]()
  - [Foreground (Color color)]()
  - more...
- [TickBarMarkup]()
  - more...
- [ToolTipMarkup]()
  - [Offset (double horizontalOffset, double verticalOffset)]()
  - more...
- [UIElementMarkup]()
  - [ToolTip (object toolTip)]()
  - [ToolTip (object toolTip, PlacementMode placementMode)]()
  - [ToolTip (object toolTip, PlacementMode placementMode, UIElement placementTarget)]()
  - [ToolTip (object toolTip, PlacementMode placementMode, UIElement placementTarget, Rect? placementRect)]()
  - [ToolTip (object toolTip, PlacementMode placementMode, UIElement placementTarget, Rect? placementRect, double horizontalOffset, double verticalOffset, bool isOpen)]()
- [UserControlMarkup]()
  - more...
- [VariableSizedWrapGridMarkup]()
  - more...
- [ViewboxMarkup]()
  - more...