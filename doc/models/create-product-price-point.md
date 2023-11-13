
# Create Product Price Point

## Structure

`CreateProductPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Handle` | `string` | Optional | - |
| `PriceInCents` | `int` | Required | - |
| `Interval` | `int` | Required | - |
| `IntervalUnit` | `string` | Required | - |
| `TrialPriceInCents` | `int?` | Optional | - |
| `TrialInterval` | `int?` | Optional | - |
| `TrialIntervalUnit` | `string` | Optional | - |
| `TrialType` | `string` | Optional | - |
| `InitialChargeInCents` | `int?` | Optional | - |
| `InitialChargeAfterTrial` | `bool?` | Optional | - |
| `ExpirationInterval` | `int?` | Optional | - |
| `ExpirationIntervalUnit` | `string` | Optional | - |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether or not to use the site's exchange rate or define your own pricing when your site has multiple currencies defined.<br>**Default**: `true` |

## Example (as JSON)

```json
{
  "name": "name6",
  "price_in_cents": 216,
  "interval": 200,
  "interval_unit": "interval_unit6",
  "use_site_exchange_rate": true,
  "handle": "handle2",
  "trial_price_in_cents": 48,
  "trial_interval": 102,
  "trial_interval_unit": "trial_interval_unit0",
  "trial_type": "trial_type0"
}
```

