
# Subscription Group Component Custom Price

Used in place of `price_point_id` to define a custom price point unique to the subscription. You still need to provide `component_id`.

## Structure

`SubscriptionGroupComponentCustomPrice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingScheme` | [`SubscriptionGroupComponentCustomPricePricingScheme`](../../doc/models/containers/subscription-group-component-custom-price-pricing-scheme.md) | Optional | This is a container for one-of cases. |
| `Prices` | [`List<Price>`](../../doc/models/price.md) | Optional | - |
| `OveragePricing` | [`List<ComponentCustomPrice>`](../../doc/models/component-custom-price.md) | Optional | - |

## Example (as JSON)

```json
{
  "pricing_scheme": "tiered",
  "prices": [
    {
      "starting_quantity": 242,
      "ending_quantity": 40,
      "unit_price": 23.26
    }
  ],
  "overage_pricing": [
    {
      "pricing_scheme": "volume",
      "prices": [
        {
          "starting_quantity": 242,
          "ending_quantity": 40,
          "unit_price": 23.26
        }
      ]
    }
  ]
}
```

