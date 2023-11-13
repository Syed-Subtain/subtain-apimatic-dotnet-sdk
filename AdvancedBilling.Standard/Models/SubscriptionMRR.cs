// <copyright file="SubscriptionMRR.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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

    /// <summary>
    /// SubscriptionMRR.
    /// </summary>
    public class SubscriptionMRR
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMRR"/> class.
        /// </summary>
        public SubscriptionMRR()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMRR"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="mrrAmountInCents">mrr_amount_in_cents.</param>
        /// <param name="breakouts">breakouts.</param>
        public SubscriptionMRR(
            double subscriptionId,
            double mrrAmountInCents,
            Models.SubscriptionMRRBreakout breakouts = null)
        {
            this.SubscriptionId = subscriptionId;
            this.MrrAmountInCents = mrrAmountInCents;
            this.Breakouts = breakouts;
        }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public double SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets MrrAmountInCents.
        /// </summary>
        [JsonProperty("mrr_amount_in_cents")]
        public double MrrAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets Breakouts.
        /// </summary>
        [JsonProperty("breakouts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionMRRBreakout Breakouts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionMRR : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionMRR other &&                this.SubscriptionId.Equals(other.SubscriptionId) &&
                this.MrrAmountInCents.Equals(other.MrrAmountInCents) &&
                ((this.Breakouts == null && other.Breakouts == null) || (this.Breakouts?.Equals(other.Breakouts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"this.MrrAmountInCents = {this.MrrAmountInCents}");
            toStringOutput.Add($"this.Breakouts = {(this.Breakouts == null ? "null" : this.Breakouts.ToString())}");
        }
    }
}