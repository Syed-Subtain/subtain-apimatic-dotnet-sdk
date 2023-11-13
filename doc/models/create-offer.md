
# Create Offer

## Structure

`CreateOffer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `Components` | [`List<CreateOfferComponent>`](../../doc/models/create-offer-component.md) | Optional | - |
| `Coupons` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name4",
  "handle": "handle0",
  "description": "description4",
  "product_id": 208,
  "product_price_point_id": 132
}
```

