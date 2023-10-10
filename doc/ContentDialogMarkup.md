# Markup
## ContentDialogMarkup

```csharp
using UWP.Markup;

ContentDialog dialog = new ContentDialog()
    .Title("Save your work?")
    .PrimaryButtonText("Save")
    .SecondaryButtonText("Don't Save")
    .CloseButtonText("Cancel")
    .DefaultButton(ContentDialogButton.Primary)
    .Content(new ContentDialogContent());

var result = await dialog.ShowAsync();

// doc ⬇️
```

> WinUI Methods

- ### TitleTemplate
- ### Title
- ### SecondaryButtonText
- ### SecondaryButtonCommandParameter
- ### SecondaryButtonCommand
- ### PrimaryButtonText
- ### PrimaryButtonCommandParameter
- ### PrimaryButtonCommand
- ### IsSecondaryButtonEnabled
- ### IsPrimaryButtonEnabled
- ### FullSizeDesired
- ### SecondaryButtonStyle
- ### PrimaryButtonStyle
- ### DefaultButton
- ### CloseButtonText
- ### CloseButtonStyle
- ### CloseButtonCommandParameter
- ### CloseButtonCommand