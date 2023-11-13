
# Product Price Point Currency Price

object Product Price Point Currency Price:

## Structure

`ProductPricePointCurrencyPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Currency` | `string` | Optional | - |
| `Price` | `int?` | Optional | - |
| `FormattedPrice` | `string` | Optional | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `Role` | [`CurrencyPriceRole?`](../../doc/models/currency-price-role.md) | Optional | Role for the price. |

## Example (as JSON)

```json
{
  "id": 254,
  "currency": "currency2",
  "price": 130,
  "formatted_price": "formatted_price0",
  "product_price_point_id": 120
}
```

