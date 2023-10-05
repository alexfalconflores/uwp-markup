using Windows.UI.Xaml.Controls;

namespace UWP.Markup.IconElement;

/// <summary>
/// Provides extension methods for configuring a <see cref="SymbolIcon"/> in XAML markup.
/// </summary>
public static class SymbolIconMarkup
{
    /// <summary>
    /// Sets the Segoe MDL2 Assets glyph used as the icon content.
    /// </summary>
    /// <param name="element"></param>
    /// <param name="symbol"></param>
    /// <returns>The <see cref="SymbolIcon"/> instance for method chaining</returns>
    public static SymbolIcon Symbol(this SymbolIcon element, Symbol symbol)
    {
        element.Symbol = symbol;
        return element;
    }
}
