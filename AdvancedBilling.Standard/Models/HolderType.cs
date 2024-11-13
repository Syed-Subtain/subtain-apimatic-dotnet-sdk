// <copyright file="HolderType.cs" company="APIMatic">
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
    /// HolderType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum HolderType
    {
        /// <summary>
        /// Personal.
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,

        /// <summary>
        /// Business.
        /// </summary>
        [EnumMember(Value = "business")]
        Business
    }
}