
# Create or Update Product

## Structure

`CreateOrUpdateProduct`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Handle` | `string` | Optional | - |
| `Description` | `string` | Required | - |
| `AccountingCode` | `string` | Optional | - |
| `RequireCreditCard` | `bool?` | Optional | - |
| `PriceInCents` | `int` | Required | - |
| `Interval` | `int` | Required | - |
| `IntervalUnit` | `string` | Required | - |
| `AutoCreateSignupPage` | `bool?` | Optional | - |
| `TaxCode` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name8",
  "handle": "handle4",
  "description": "description8",
  "accounting_code": "accounting_code4",
  "require_credit_card": false,
  "price_in_cents": 190,
  "interval": 174,
  "interval_unit": "interval_unit8",
  "auto_create_signup_page": false,
  "tax_code": "tax_code6"
}
```

