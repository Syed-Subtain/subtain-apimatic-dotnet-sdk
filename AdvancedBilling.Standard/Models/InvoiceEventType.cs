// <copyright file="InvoiceEventType.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// InvoiceEventType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceEventType
    {
        /// <summary>
        /// IssueInvoice.
        /// </summary>
        [EnumMember(Value = "issue_invoice")]
        IssueInvoice,

        /// <summary>
        /// ApplyCreditNote.
        /// </summary>
        [EnumMember(Value = "apply_credit_note")]
        ApplyCreditNote,

        /// <summary>
        /// ApplyPayment.
        /// </summary>
        [EnumMember(Value = "apply_payment")]
        ApplyPayment,

        /// <summary>
        /// ApplyDebitNote.
        /// </summary>
        [EnumMember(Value = "apply_debit_note")]
        ApplyDebitNote,

        /// <summary>
        /// RefundInvoice.
        /// </summary>
        [EnumMember(Value = "refund_invoice")]
        RefundInvoice,

        /// <summary>
        /// VoidInvoice.
        /// </summary>
        [EnumMember(Value = "void_invoice")]
        VoidInvoice,

        /// <summary>
        /// VoidRemainder.
        /// </summary>
        [EnumMember(Value = "void_remainder")]
        VoidRemainder,

        /// <summary>
        /// BackportInvoice.
        /// </summary>
        [EnumMember(Value = "backport_invoice")]
        BackportInvoice,

        /// <summary>
        /// ChangeInvoiceStatus.
        /// </summary>
        [EnumMember(Value = "change_invoice_status")]
        ChangeInvoiceStatus,

        /// <summary>
        /// ChangeInvoiceCollectionMethod.
        /// </summary>
        [EnumMember(Value = "change_invoice_collection_method")]
        ChangeInvoiceCollectionMethod,

        /// <summary>
        /// RemovePayment.
        /// </summary>
        [EnumMember(Value = "remove_payment")]
        RemovePayment
    }
}