
# Update Subscription

## Structure

`UpdateSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreditCardAttributes` | [`CreditCardAttributes`](../../doc/models/credit-card-attributes.md) | Optional | - |
| `ProductHandle` | `string` | Optional | Set to the handle of a different product to change the subscription's product |
| `ProductId` | `int?` | Optional | Set to the id of a different product to change the subscription's product |
| `ProductChangeDelayed` | `bool?` | Optional | **Default**: `false` |
| `NextProductId` | `string` | Optional | Set to an empty string to cancel a delayed product change. |
| `NextProductPricePointId` | `string` | Optional | - |
| `SnapDay` | [`UpdateSubscriptionSnapDay`](../../doc/models/containers/update-subscription-snap-day.md) | Optional | This is a container for one-of cases. |
| `NextBillingAt` | `string` | Optional | - |
| `PaymentCollectionMethod` | `string` | Optional | - |
| `ReceivesInvoiceEmails` | `bool?` | Optional | - |
| `NetTerms` | [`UpdateSubscriptionNetTerms`](../../doc/models/containers/update-subscription-net-terms.md) | Optional | This is a container for one-of cases. |
| `StoredCredentialTransactionId` | `int?` | Optional | - |
| `Reference` | `string` | Optional | - |
| `CustomPrice` | [`CustomPriceUsedForSubscriptionCreateUpdate`](../../doc/models/custom-price-used-for-subscription-create-update.md) | Optional | (Optional) Used in place of `product_price_point_id` to define a custom price point unique to the subscription |
| `Components` | [`List<UpdateSubscriptionComponent>`](../../doc/models/update-subscription-component.md) | Optional | (Optional) An array of component ids and custom prices to be added to the subscription. |
| `DunningCommunicationDelayEnabled` | `bool?` | Optional | Enable Communication Delay feature, making sure no communication (email or SMS) is sent to the Customer between 9PM and 8AM in time zone set by the `dunning_communication_delay_time_zone` attribute.<br>**Default**: `false` |
| `DunningCommunicationDelayTimeZone` | `string` | Optional | Time zone for the Dunning Communication Delay feature. |

## Example (as JSON)

```json
{
  "product_change_delayed": false,
  "dunning_communication_delay_enabled": false,
  "dunning_communication_delay_time_zone": "\"Eastern Time (US & Canada)\"",
  "credit_card_attributes": {
    "full_number": "full_number2",
    "expiration_month": "expiration_month6",
    "expiration_year": "expiration_year2"
  },
  "product_handle": "product_handle2",
  "product_id": 114,
  "next_product_id": "next_product_id8"
}
```

