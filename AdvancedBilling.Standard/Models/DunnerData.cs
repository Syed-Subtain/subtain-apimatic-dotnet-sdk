// <copyright file="DunnerData.cs" company="APIMatic">
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
    /// DunnerData.
    /// </summary>
    public class DunnerData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DunnerData"/> class.
        /// </summary>
        public DunnerData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DunnerData"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="revenueAtRiskInCents">revenue_at_risk_in_cents.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="attempts">attempts.</param>
        /// <param name="lastAttemptedAt">last_attempted_at.</param>
        public DunnerData(
            string state,
            int subscriptionId,
            int revenueAtRiskInCents,
            string createdAt,
            int attempts,
            string lastAttemptedAt)
        {
            this.State = state;
            this.SubscriptionId = subscriptionId;
            this.RevenueAtRiskInCents = revenueAtRiskInCents;
            this.CreatedAt = createdAt;
            this.Attempts = attempts;
            this.LastAttemptedAt = lastAttemptedAt;
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets RevenueAtRiskInCents.
        /// </summary>
        [JsonProperty("revenue_at_risk_in_cents")]
        public int RevenueAtRiskInCents { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Attempts.
        /// </summary>
        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        /// <summary>
        /// Gets or sets LastAttemptedAt.
        /// </summary>
        [JsonProperty("last_attempted_at")]
        public string LastAttemptedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DunnerData : ({string.Join(", ", toStringOutput)})";
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
            return obj is DunnerData other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                this.SubscriptionId.Equals(other.SubscriptionId) &&
                this.RevenueAtRiskInCents.Equals(other.RevenueAtRiskInCents) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                this.Attempts.Equals(other.Attempts) &&
                ((this.LastAttemptedAt == null && other.LastAttemptedAt == null) || (this.LastAttemptedAt?.Equals(other.LastAttemptedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"this.RevenueAtRiskInCents = {this.RevenueAtRiskInCents}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.Attempts = {this.Attempts}");
            toStringOutput.Add($"this.LastAttemptedAt = {(this.LastAttemptedAt == null ? "null" : this.LastAttemptedAt)}");
        }
    }
}