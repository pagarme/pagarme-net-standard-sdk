
# Get Balance Operation Response

Generic response object for getting a BalanceOperation.

## Structure

`GetBalanceOperationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `BalanceAmount` | `string` | Optional | - |
| `BalanceOldAmount` | `string` | Optional | - |
| `Type` | `string` | Optional | - |
| `Amount` | `string` | Optional | - |
| `Fee` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `MovementObject` | [`Models.GetMovementObjectBaseResponse`](../../doc/models/get-movement-object-base-response.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "status": "status8",
  "balance_amount": "balance_amount0",
  "balance_old_amount": "balance_old_amount2",
  "type": "type0"
}
```

