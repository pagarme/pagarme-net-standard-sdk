
# Error Exception

Api Error Exception

## Structure

`ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Required | - |
| `Errors` | `object` | Required | - |
| `Request` | `object` | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ErrorException)
    {
        // TODO: Handle ErrorException
        Console.WriteLine(e.Message);
    }
}
```

