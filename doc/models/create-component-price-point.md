
# Create Component Price Point

## Structure

`CreateComponentPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Handle` | `string` | Optional | - |
| `PricingScheme` | `string` | Required | - |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Required | - |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site.<br>**Default**: `true` |

## Example (as JSON)

```json
{
  "name": "name0",
  "pricing_scheme": "pricing_scheme8",
  "prices": [
    {
      "starting_quantity": 242,
      "ending_quantity": 40,
      "unit_price": 23.26
    }
  ],
  "use_site_exchange_rate": true,
  "handle": "handle6"
}
```

