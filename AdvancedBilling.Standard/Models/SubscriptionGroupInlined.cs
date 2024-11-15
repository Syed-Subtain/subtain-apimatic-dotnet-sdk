// <copyright file="SubscriptionGroupInlined.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionGroupInlined.
    /// </summary>
    public class SubscriptionGroupInlined
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupInlined"/> class.
        /// </summary>
        public SubscriptionGroupInlined()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupInlined"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="primarySubscriptionId">primary_subscription_id.</param>
        /// <param name="primary">primary.</param>
        public SubscriptionGroupInlined(
            string uid = null,
            string scheme = null,
            string primarySubscriptionId = null,
            bool? primary = null)
        {
            this.Uid = uid;
            this.Scheme = scheme;
            this.PrimarySubscriptionId = primarySubscriptionId;
            this.Primary = primary;
        }

        /// <summary>
        /// The UID for the group
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Whether the group is configured to rely on a primary subscription for billing. At this time, it will always be 1.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Scheme { get; set; }

        /// <summary>
        /// The subscription ID of the primary within the group. Applicable to scheme 1.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("primary_subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimarySubscriptionId { get; set; }

        /// <summary>
        /// A boolean indicating whether the subscription is the primary in the group. Applicable to scheme 1.
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupInlined : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SubscriptionGroupInlined other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Scheme == null && other.Scheme == null) || (this.Scheme?.Equals(other.Scheme) == true)) &&
                ((this.PrimarySubscriptionId == null && other.PrimarySubscriptionId == null) || (this.PrimarySubscriptionId?.Equals(other.PrimarySubscriptionId) == true)) &&
                ((this.Primary == null && other.Primary == null) || (this.Primary?.Equals(other.Primary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Scheme = {(this.Scheme == null ? "null" : this.Scheme)}");
            toStringOutput.Add($"this.PrimarySubscriptionId = {(this.PrimarySubscriptionId == null ? "null" : this.PrimarySubscriptionId)}");
            toStringOutput.Add($"this.Primary = {(this.Primary == null ? "null" : this.Primary.ToString())}");
        }
    }
}