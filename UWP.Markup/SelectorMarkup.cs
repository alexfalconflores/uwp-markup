using Windows.UI.Xaml.Controls.Primitives;

namespace UWP.Markup;

/// <summary>
/// Defines the extension methods for the <see cref="Selector"/> class.
/// </summary>
public static class SelectorMarkup
{
    /// <summary>
    /// Sets the property path that is used to get the SelectedValue property
    /// of the SelectedItem property. The default is String.Empty.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="selectedValuePath"></param>
    /// <returns>The <see cref="Selector"/> instance for method chaining</returns>
    public static T SelectedValuePath<T>(this T element, string selectedValuePath) where T : Selector
    {
        element.SelectedValuePath = selectedValuePath;
        return element;
    }

    /// <summary>
    /// Sets the value of the selected item, obtained by using the SelectedValuePath.
    /// The default value is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="selectedValue"></param>
    /// <returns>The <see cref="Selector"/> instance for method chaining</returns>
    public static T SelectedValue<T>(this T element, object selectedValue) where T : Selector
    {
        element.SelectedValue = selectedValue;
        return element;
    }

    /// <summary>
    /// Sets the selected item. The default value is null.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="selectedItem"></param>
    /// <returns>The <see cref="Selector"/> instance for method chaining</returns>
    public static T SelectedItem<T>(this T element, object selectedItem) where T : Selector
    {
        element.SelectedItem = selectedItem;
        return element;
    }

    /// <summary>
    /// Sets the index of the selected item.
    /// The default is -1, which indicates that no item is selected.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="index"></param>
    /// <returns>The <see cref="Selector"/> instance for method chaining</returns>
    public static T SelectedIndex<T>(this T element, int index) where T : Selector
    {
        element.SelectedIndex = index;
        return element;
    }

    /// <summary>
    /// Sets a value that indicates whether a Selector should keep the SelectedItem
    /// synchronized with the current item in the Items property.
    /// The default value is **null**/indeterminate.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="element"></param>
    /// <param name="isSynchronizedWithCurrentItem"></param>
    /// <returns>The <see cref="Selector"/> instance for method chaining</returns>
    public static T IsSynchronizedWithCurrentItem<T>(this T element, bool? @isSynchronizedWithCurrentItem) where T : Selector
    {
        element.IsSynchronizedWithCurrentItem = @isSynchronizedWithCurrentItem;
        return element;
    }
}
