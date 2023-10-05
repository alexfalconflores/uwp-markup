using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace UWP.Markup.VirtualizingPanel;

/// <summary>
/// Arranges and virtualizes content on a single line that is oriented either horizontally
/// or vertically. Can only be used to display items in an <see cref="ItemsControl"/>.
/// <see cref="VirtualizingStackPanel"/> can only be used to display items in an <see cref="ItemsControl"/>.
/// A primary scenario for <see cref="VirtualizingStackPanel"/> is that it provides the items panel template behavior
/// for <see cref="FlipView"/> and <see cref="ListBox"/> in default templates.
/// </summary>
public static class VirtualizingStackPanelMarkup
{
    /// <summary>
    /// Sets a value that describes the horizontal or vertical orientation of stacked content.
    /// The default is Vertical.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="orientation"></param>
    /// <returns>The <see cref="VirtualizingStackPanel"/> instance for method chaining</returns>
    public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel element, Orientation orientation)
    {
        element.Orientation = orientation;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether the generated snap points used for
    /// panning in the VirtualizingStackPanel are equidistant from each other.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="areScrollSnapPointsRegular"></param>
    /// <returns>The <see cref="VirtualizingStackPanel"/> instance for method chaining</returns>
    public static VirtualizingStackPanel AreScrollSnapPointsRegular(this VirtualizingStackPanel element, bool areScrollSnapPointsRegular)
    {
        element.AreScrollSnapPointsRegular = areScrollSnapPointsRegular;
        return element;
    }
}
