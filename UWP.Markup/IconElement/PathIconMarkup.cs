using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace UWP.Markup.IconElement;

/// <summary>
/// Provides extension methods for configuring a <see cref="PathIcon"/> in XAML markup.
/// </summary>
public static class PathIconMarkup
{
    /// <summary>
    /// Sets a Geometry that specifies the shape to be drawn. In XAML. this can also be set using a string that describes Move and Draw commands syntax.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="geometry"></param>
    /// <returns>The <see cref="PathIcon"/> instance for method chaining</returns>
    public static PathIcon Data(this PathIcon element, Geometry geometry)
    {
        element.Data = geometry;
        return element;
    }
}
