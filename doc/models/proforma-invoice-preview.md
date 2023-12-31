
# Proforma Invoice Preview

## Structure

`ProformaInvoicePreview`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `SiteId` | `double?` | Optional | - |
| `CustomerId` | `double?` | Optional | - |
| `SubscriptionId` | `double?` | Optional | - |
| `Number` | `string` | Optional | - |
| `SequenceNumber` | `int?` | Optional | - |
| `CreatedAt` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `DeliveryDate` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Status` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `CollectionMethod` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `PaymentInstructions` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Currency` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `ConsolidationLevel` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `ProductName` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `ProductFamilyName` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Role` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `Seller` | [`InvoiceSeller`](../../doc/models/invoice-seller.md) | Optional | Information about the seller (merchant) listed on the masthead of the invoice. |
| `Customer` | [`InvoiceCustomer`](../../doc/models/invoice-customer.md) | Optional | Information about the customer who is owner or recipient the invoiced subscription. |
| `Memo` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `BillingAddress` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Optional | - |
| `ShippingAddress` | [`InvoiceAddress`](../../doc/models/invoice-address.md) | Optional | - |
| `SubtotalAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `DiscountAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `TaxAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `TotalAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `CreditAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `PaidAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `RefundAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `DueAmount` | `string` | Optional | **Constraints**: *Minimum Length*: `1` |
| `LineItems` | [`List<InvoiceLineItem>`](../../doc/models/invoice-line-item.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Discounts` | [`List<ProformaInvoiceDiscount>`](../../doc/models/proforma-invoice-discount.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Taxes` | [`List<ProformaInvoiceTax>`](../../doc/models/proforma-invoice-tax.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Credits` | [`List<ProformaInvoiceCredit>`](../../doc/models/proforma-invoice-credit.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `Payments` | [`List<ProformaInvoicePayment>`](../../doc/models/proforma-invoice-payment.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `CustomFields` | [`List<ProformaCustomField>`](../../doc/models/proforma-custom-field.md) | Optional | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `PublicUrl` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "uid": "uid2",
  "site_id": 127.58,
  "customer_id": 51.9,
  "subscription_id": 206.22,
  "number": "number0"
}
```

