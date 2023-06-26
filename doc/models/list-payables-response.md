
# List Payables Response

Response object for listing payable objects

## Structure

`ListPayablesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Models.GetPayableResponse>`](../../doc/models/get-payable-response.md) | Optional | The payable object |
| `Paging` | [`Models.PagingResponse`](../../doc/models/paging-response.md) | Optional | Paging object |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": 23,
      "status": "status7",
      "amount": 121,
      "fee": 79,
      "anticipation_fee": 27,
      "fraud_coverage_fee": 81,
      "installment": 99,
      "gateway_id": 227,
      "charge_id": "charge_id7",
      "split_id": "split_id7",
      "bulk_anticipation_id": "bulk_anticipation_id1",
      "anticipation_id": "anticipation_id5",
      "recipient_id": "recipient_id5",
      "originator_model": "originator_model1",
      "originator_model_id": "originator_model_id1",
      "payment_date": "2016-03-13T12:52:32.123Z",
      "original_payment_date": "2016-03-13T12:52:32.123Z",
      "type": "type5",
      "payment_method": "payment_method5",
      "accrual_at": "2016-03-13T12:52:32.123Z",
      "created_at": "2016-03-13T12:52:32.123Z",
      "liquidation_arrangement_id": "liquidation_arrangement_id9"
    },
    {
      "id": 24,
      "status": "status8",
      "amount": 122,
      "fee": 80,
      "anticipation_fee": 28,
      "fraud_coverage_fee": 82,
      "installment": 100,
      "gateway_id": 228,
      "charge_id": "charge_id8",
      "split_id": "split_id8",
      "bulk_anticipation_id": "bulk_anticipation_id2",
      "anticipation_id": "anticipation_id6",
      "recipient_id": "recipient_id6",
      "originator_model": "originator_model2",
      "originator_model_id": "originator_model_id2",
      "payment_date": "2016-03-13T12:52:32.123Z",
      "original_payment_date": "2016-03-13T12:52:32.123Z",
      "type": "type6",
      "payment_method": "payment_method6",
      "accrual_at": "2016-03-13T12:52:32.123Z",
      "created_at": "2016-03-13T12:52:32.123Z",
      "liquidation_arrangement_id": "liquidation_arrangement_id0"
    }
  ],
  "paging": {
    "total": 6,
    "previous": "previous2",
    "next": "next8"
  }
}
```

