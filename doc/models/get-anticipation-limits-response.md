
# Get Anticipation Limits Response

Anticipation limits

## Structure

`GetAnticipationLimitsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Max` | [`GetAnticipationLimitResponse`](../../doc/models/get-anticipation-limit-response.md) | Optional | Max limit |
| `Min` | [`GetAnticipationLimitResponse`](../../doc/models/get-anticipation-limit-response.md) | Optional | Min limit |

## Example

```csharp
using PagarmeApiSDK.Standard.Models;

GetAnticipationLimitsResponse getAnticipationLimitsResponse = new GetAnticipationLimitsResponse
{
    Max = null,
    Min = null,
};
```

