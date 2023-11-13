
# Custom Price Used for Subscription Create Update

(Optional) Used in place of `product_price_point_id` to define a custom price point unique to the subscription

## Structure

`CustomPriceUsedForSubscriptionCreateUpdate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | (Optional) |
| `Handle` | `string` | Optional | (Optional) |
| `PriceInCents` | [`CustomPriceUsedForSubscriptionCreateUpdatePriceInCents`](../../doc/models/containers/custom-price-used-for-subscription-create-update-price-in-cents.md) | Optional | This is a container for one-of cases. |
| `Interval` | [`CustomPriceUsedForSubscriptionCreateUpdateInterval`](../../doc/models/containers/custom-price-used-for-subscription-create-update-interval.md) | Optional | This is a container for one-of cases. |
| `IntervalUnit` | [`CustomPriceUsedForSubscriptionCreateUpdateIntervalUnit`](../../doc/models/containers/custom-price-used-for-subscription-create-update-interval-unit.md) | Optional | This is a container for one-of cases. |
| `TrialPriceInCents` | [`CustomPriceUsedForSubscriptionCreateUpdateTrialPriceInCents`](../../doc/models/containers/custom-price-used-for-subscription-create-update-trial-price-in-cents.md) | Optional | This is a container for one-of cases. |
| `TrialInterval` | [`CustomPriceUsedForSubscriptionCreateUpdateTrialInterval`](../../doc/models/containers/custom-price-used-for-subscription-create-update-trial-interval.md) | Optional | This is a container for one-of cases. |
| `TrialIntervalUnit` | [`CustomPriceUsedForSubscriptionCreateUpdateTrialIntervalUnit`](../../doc/models/containers/custom-price-used-for-subscription-create-update-trial-interval-unit.md) | Optional | This is a container for one-of cases. |
| `InitialChargeInCents` | [`CustomPriceUsedForSubscriptionCreateUpdateInitialChargeInCents`](../../doc/models/containers/custom-price-used-for-subscription-create-update-initial-charge-in-cents.md) | Optional | This is a container for one-of cases. |
| `InitialChargeAfterTrial` | `bool?` | Optional | (Optional) |
| `ExpirationInterval` | [`CustomPriceUsedForSubscriptionCreateUpdateExpirationInterval`](../../doc/models/containers/custom-price-used-for-subscription-create-update-expiration-interval.md) | Optional | This is a container for one-of cases. |
| `ExpirationIntervalUnit` | [`CustomPriceUsedForSubscriptionCreateUpdateExpirationIntervalUnit`](../../doc/models/containers/custom-price-used-for-subscription-create-update-expiration-interval-unit.md) | Optional | This is a container for one-of cases. |
| `TaxIncluded` | `bool?` | Optional | (Optional) |

## Example (as JSON)

```json
{
  "name": "name4",
  "handle": "handle0",
  "price_in_cents": "String3",
  "interval": "String3",
  "interval_unit": "day"
}
```

