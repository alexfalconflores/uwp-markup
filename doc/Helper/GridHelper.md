# Helper
## GridHelper
### StringToGridLength
Convert `string` to `GridLength`. The default value is `GridLength.Auto`.

```csharp
GridLength width = GridHelper.StringToGridLength("Auto"); // Auto
GridLength width = GridHelper.StringToGridLength("*"); // 1*
GridLength width = GridHelper.StringToGridLength("2*"); // 2*
GridLength width = GridHelper.StringToGridLength("100"); // 100
```
