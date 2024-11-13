// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Production server.
        /// </summary>
        [EnumMember(Value = "production")]
        Production,

        /// <summary>
        /// Production server.
        /// </summary>
        [EnumMember(Value = "environment2")]
        Environment2,
    }
}
