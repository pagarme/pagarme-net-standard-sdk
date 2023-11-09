
# Get Transfer

## Structure

`GetTransfer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `GatewayId` | `string` | Required | - |
| `Amount` | `int` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `Metadata` | `Dictionary<string, string>` | Optional | - |
| `Fee` | `int?` | Optional | - |
| `FundingDate` | `DateTime?` | Optional | - |
| `FundingEstimatedDate` | `DateTime?` | Optional | - |
| `Type` | `string` | Required | - |
| `Source` | [`GetTransferSourceResponse`](../../doc/models/get-transfer-source-response.md) | Required | - |
| `Target` | [`GetTransferTargetResponse`](../../doc/models/get-transfer-target-response.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "id8",
  "gateway_id": "gateway_id8",
  "amount": 122,
  "status": "status0",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "metadata": {
    "key0": "metadata5"
  },
  "fee": 80,
  "funding_date": "2016-03-13T12:52:32.123Z",
  "funding_estimated_date": "2016-03-13T12:52:32.123Z",
  "type": "type8",
  "source": {
    "source_id": "source_id8",
    "type": "type6"
  },
  "target": {
    "target_id": "target_id2",
    "type": "type8"
  }
}
```

