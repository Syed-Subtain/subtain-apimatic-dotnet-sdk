
# Invoice Event 1

The event data is the data that, when combined with the command, results in the output invoice found in the invoice field.

## Structure

`InvoiceEvent1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | Unique identifier for the credit note application. It is generated automatically by Chargify and has the prefix "cdt_" followed by alphanumeric characters. |
| `CreditNoteNumber` | `string` | Optional | A unique, identifying string that appears on the credit note and in places it is referenced. |
| `CreditNoteUid` | `string` | Optional | Unique identifier for the credit note. It is generated automatically by Chargify and has the prefix "cn_" followed by alphanumeric characters. |
| `OriginalAmount` | `string` | Optional | The full, original amount of the credit note. |
| `AppliedAmount` | `string` | Optional | The amount of the credit note applied to invoice. |
| `TransactionTime` | `DateTime?` | Optional | The time the credit note was applied, in ISO 8601 format, i.e. "2019-06-07T17:20:06Z" |
| `Memo` | `string` | Optional | The credit note memo. |
| `Role` | `string` | Optional | The role of the credit note (e.g. 'general') |
| `ConsolidatedInvoice` | `bool?` | Optional | Shows whether it was applied to consolidated invoice or not |
| `AppliedCreditNotes` | [`List<AppliedCreditNote>`](../../doc/models/applied-credit-note.md) | Optional | List of credit notes applied to children invoices (if consolidated invoice) |
| `DebitNoteNumber` | `string` | Optional | A unique, identifying string that appears on the debit note and in places it is referenced. |
| `DebitNoteUid` | `string` | Optional | Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters. |
| `PaymentMethod` | [`InvoiceEvent1PaymentMethod`](../../doc/models/containers/invoice-event-1-payment-method.md) | Optional | This is a container for one-of cases. |
| `TransactionId` | `int?` | Optional | The Chargify id of the original payment |
| `FromCollectionMethod` | `string` | Optional | The previous collection method of the invoice. |
| `ToCollectionMethod` | `string` | Optional | The new collection method of the invoice. |
| `ConsolidationLevel` | [`InvoiceConsolidationLevel?`](../../doc/models/invoice-consolidation-level.md) | Optional | Consolidation level of the invoice, which is applicable to invoice consolidation.  It will hold one of the following values:<br><br>* "none": A normal invoice with no consolidation.<br>* "child": An invoice segment which has been combined into a consolidated invoice.<br>* "parent": A consolidated invoice, whose contents are composed of invoice segments.<br><br>"Parent" invoices do not have lines of their own, but they have subtotals and totals which aggregate the member invoice segments.<br><br>See also the [invoice consolidation documentation](https://chargify.zendesk.com/hc/en-us/articles/4407746391835). |
| `FromStatus` | [`Status?`](../../doc/models/status.md) | Optional | The status of the invoice before event occurence. See [Invoice Statuses](https://chargify.zendesk.com/hc/en-us/articles/4407737494171#line-item-breakdowns) for more. |
| `ToStatus` | [`Status?`](../../doc/models/status.md) | Optional | The status of the invoice after event occurence. See [Invoice Statuses](https://chargify.zendesk.com/hc/en-us/articles/4407737494171#line-item-breakdowns) for more. |
| `DueAmount` | `string` | Optional | Amount due on the invoice, which is `total_amount - credit_amount - paid_amount`. |
| `TotalAmount` | `string` | Optional | The invoice total, which is `subtotal_amount - discount_amount + tax_amount`.' |
| `ApplyCredit` | `bool?` | Optional | If true, credit was created and applied it to the invoice. |
| `CreditNoteAttributes` | [`CreditNote1`](../../doc/models/credit-note-1.md) | Optional | - |
| `PaymentId` | `int?` | Optional | The ID of the payment transaction to be refunded. |
| `RefundAmount` | `string` | Optional | The amount of the refund. |
| `RefundId` | `int?` | Optional | The ID of the refund transaction. |
| `Prepayment` | `bool?` | Optional | The flag that shows whether the original payment was a prepayment or not |
| `IsAdvanceInvoice` | `bool?` | Optional | If true, the invoice is an advance invoice. |

## Example (as JSON)

```json
{
  "uid": "uid0",
  "credit_note_number": "credit_note_number4",
  "credit_note_uid": "credit_note_uid4",
  "original_amount": "original_amount4",
  "applied_amount": "applied_amount8"
}
```

