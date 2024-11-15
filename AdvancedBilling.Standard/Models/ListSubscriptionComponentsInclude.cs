// <copyright file="ListSubscriptionComponentsInclude.cs" company="APIMatic">
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
    /// ListSubscriptionComponentsInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListSubscriptionComponentsInclude
    {
        /// <summary>
        /// Subscription.
        /// </summary>
        [EnumMember(Value = "subscription")]
        Subscription
    }
}