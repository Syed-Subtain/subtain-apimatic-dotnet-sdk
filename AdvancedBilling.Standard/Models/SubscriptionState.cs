// <copyright file="SubscriptionState.cs" company="APIMatic">
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
    /// SubscriptionState.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionState
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

        /// <summary>
        /// ExpiredCards.
        /// </summary>
        [EnumMember(Value = "expired_cards")]
        ExpiredCards,

        /// <summary>
        /// OnHold.
        /// </summary>
        [EnumMember(Value = "on_hold")]
        OnHold,

        /// <summary>
        /// PastDue.
        /// </summary>
        [EnumMember(Value = "past_due")]
        PastDue,

        /// <summary>
        /// PendingCancellation.
        /// </summary>
        [EnumMember(Value = "pending_cancellation")]
        PendingCancellation,

        /// <summary>
        /// PendingRenewal.
        /// </summary>
        [EnumMember(Value = "pending_renewal")]
        PendingRenewal,

        /// <summary>
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,

        /// <summary>
        /// TrialEnded.
        /// </summary>
        [EnumMember(Value = "trial_ended")]
        TrialEnded,

        /// <summary>
        /// Trialing.
        /// </summary>
        [EnumMember(Value = "trialing")]
        Trialing,

        /// <summary>
        /// Unpaid.
        /// </summary>
        [EnumMember(Value = "unpaid")]
        Unpaid
    }
}