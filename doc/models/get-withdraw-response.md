
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
  "id": null,
  "gateway_id": null,
  "amount": null,
  "status": null,
  "created_at": null,
  "updated_at": null,
  "metadata": null,
  "fee": null,
  "funding_date": null,
  "funding_estimated_date": null,
  "type": null,
  "source": null,
  "target": null
}
```

