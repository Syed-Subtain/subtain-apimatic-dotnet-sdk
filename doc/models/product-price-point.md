
# Product Price Point

## Structure

`ProductPricePoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `PriceInCents` | `int?` | Optional | - |
| `Interval` | `int?` | Optional | - |
| `IntervalUnit` | `string` | Optional | - |
| `TrialPriceInCents` | `int?` | Optional | - |
| `TrialInterval` | `int?` | Optional | - |
| `TrialIntervalUnit` | `string` | Optional | - |
| `TrialType` | `string` | Optional | - |
| `IntroductoryOffer` | `bool?` | Optional | reserved for future use |
| `InitialChargeInCents` | `int?` | Optional | - |
| `InitialChargeAfterTrial` | `bool?` | Optional | - |
| `ExpirationInterval` | `int?` | Optional | - |
| `ExpirationIntervalUnit` | `string` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `ArchivedAt` | `string` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `UpdatedAt` | `string` | Optional | - |
| `UseSiteExchangeRate` | `bool?` | Optional | Whether or not to use the site's exchange rate or define your own pricing when your site has multiple currencies defined. |
| `Type` | [`PricePointType?`](../../doc/models/price-point-type.md) | Optional | Price point type. We expose the following types:<br><br>1. **default**: a price point that is marked as a default price for a certain product.<br>2. **custom**: a custom price point.<br>3. **catalog**: a price point that is **not** marked as a default price for a certain product and is **not** a custom one. |
| `TaxIncluded` | `bool?` | Optional | - |
| `SubscriptionId` | `int?` | Optional | - |

## Example (as JSON)

```json
{
  "id": 196,
  "name": "name6",
  "handle": "handle2",
  "price_in_cents": 248,
  "interval": 8
}
```

