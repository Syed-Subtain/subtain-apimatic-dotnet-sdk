// <copyright file="ListSubscriptionGroupPrepaymentDateField.cs" company="APIMatic">
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
    /// ListSubscriptionGroupPrepaymentDateField.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListSubscriptionGroupPrepaymentDateField
    {
        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt,

        /// <summary>
        /// ApplicationAt.
        /// </summary>
        [EnumMember(Value = "application_at")]
        ApplicationAt
    }
}