
# Price Point

## Structure

`PricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `PricingScheme` | `string` | Optional | - |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Optional | - |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site.<br>**Default**: `true` |
| `OveragePricing` | [`OveragePricing`](../../doc/models/overage-pricing.md) | Optional | - |
| `RolloverPrepaidRemainder` | `bool?` | Optional | Boolean which controls whether or not remaining units should be rolled over to the next period |
| `RenewPrepaidAllocation` | `bool?` | Optional | Boolean which controls whether or not the allocated quantity should be renewed at the beginning of each period |
| `ExpirationInterval` | `double?` | Optional | (only for prepaid usage components where rollover_prepaid_remainder is true) The number of `expiration_interval_unit`s after which rollover amounts should expire |
| `ExpirationIntervalUnit` | [`PricePointExpirationIntervalUnit`](../../doc/models/containers/price-point-expiration-interval-unit.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "use_site_exchange_rate": true,
  "name": "name0",
  "handle": "handle6",
  "pricing_scheme": "pricing_scheme8",
  "prices": [
    {
      "starting_quantity": 242,
      "ending_quantity": 40,
      "unit_price": 23.26
    }
  ]
}
```

