# Markup
## ContentControlMarkup

```csharp
using UWP.Markup;
using Windows.UI.Xaml.Media.Animation;
using UWP.Markup.Transition;

var value = new ContentControl()
    .ContentTransitions(new TransitionCollection().AddTransition(new EntranceThemeTransition()))
    .ContentTemplateSelector(new DataTemplateSelector())
    .ContentTemplate(new DataTemplate())
    .Content(object);
```

> WinUI Methods
### ContentTransitions (TransitionCollection transitionCollection)
Sets the `collection of Transition` style elements that apply to the content of a `ContentControl`.

### ContentTemplateSelector (DataTemplateSelector dataTemplateSelector)
Sets a `selection object` that changes the `DataTemplate` to apply for content, based on processing information about the content item or its container at run time.

### ContentTemplate (DataTemplate dataTemplate)
Sets the `data template` that is used to display the content of the `ContentControl`.

### Content (object content)
Sets the content of a `ContentControl`.The default is `null`.