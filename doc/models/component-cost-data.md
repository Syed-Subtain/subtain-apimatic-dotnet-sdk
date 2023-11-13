
# Component Cost Data

## Structure

`ComponentCostData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ComponentCodeId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `Quantity` | `string` | Optional | - |
| `Amount` | `string` | Optional | - |
| `PricingScheme` | [`ComponentCostDataPricingScheme`](../../doc/models/containers/component-cost-data-pricing-scheme.md) | Optional | This is a container for one-of cases. |
| `Tiers` | [`List<ComponentCostDataRateTier>`](../../doc/models/component-cost-data-rate-tier.md) | Optional | - |

## Example (as JSON)

```json
{
  "component_code_id": 16,
  "price_point_id": 186,
  "product_id": 250,
  "quantity": "quantity8",
  "amount": "amount4"
}
```

