
# Prepayment 1

## Structure

`Prepayment1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `double` | Required | - |
| `SubscriptionId` | `double` | Required | - |
| `AmountInCents` | `double` | Required | - |
| `RemainingAmountInCents` | `double` | Required | - |
| `RefundedAmountInCents` | `double?` | Optional | - |
| `Details` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `External` | `bool` | Required | - |
| `Memo` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `PaymentType` | [`PrepaymentMethod?`](../../doc/models/prepayment-method.md) | Optional | The payment type of the prepayment. |
| `CreatedAt` | `string` | Required | **Constraints**: *Minimum Length*: `1` |

## Example (as JSON)

```json
{
  "id": 52.0,
  "subscription_id": 78.7,
  "amount_in_cents": 32.38,
  "remaining_amount_in_cents": 84.16,
  "refunded_amount_in_cents": 109.26,
  "details": "details0",
  "external": false,
  "memo": "memo4",
  "payment_type": "ach",
  "created_at": "created_at8"
}
```

