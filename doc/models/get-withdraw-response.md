
# Get Withdraw Response

## Structure

`GetWithdrawResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `GatewayId` | `string` | Optional | - |
| `Amount` | `int?` | Optional | - |
| `Status` | `string` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `UpdatedAt` | `DateTime?` | Optional | - |
| `Metadata` | `List<string>` | Optional | - |
| `Fee` | `int?` | Optional | - |
| `FundingDate` | `DateTime?` | Optional | - |
| `FundingEstimatedDate` | `DateTime?` | Optional | - |
| `Type` | `string` | Optional | - |
| `Source` | [`Models.GetWithdrawSourceResponse`](../../doc/models/get-withdraw-source-response.md) | Optional | - |
| `Target` | [`Models.GetWithdrawTargetResponse`](../../doc/models/get-withdraw-target-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "gateway_id": "gateway_id0",
  "amount": 46,
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z"
}
```

