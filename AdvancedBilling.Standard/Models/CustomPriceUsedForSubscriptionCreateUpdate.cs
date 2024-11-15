// <copyright file="CustomPriceUsedForSubscriptionCreateUpdate.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CustomPriceUsedForSubscriptionCreateUpdate.
    /// </summary>
    public class CustomPriceUsedForSubscriptionCreateUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPriceUsedForSubscriptionCreateUpdate"/> class.
        /// </summary>
        public CustomPriceUsedForSubscriptionCreateUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPriceUsedForSubscriptionCreateUpdate"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="trialPriceInCents">trial_price_in_cents.</param>
        /// <param name="trialInterval">trial_interval.</param>
        /// <param name="trialIntervalUnit">trial_interval_unit.</param>
        /// <param name="initialChargeInCents">initial_charge_in_cents.</param>
        /// <param name="initialChargeAfterTrial">initial_charge_after_trial.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        /// <param name="taxIncluded">tax_included.</param>
        public CustomPriceUsedForSubscriptionCreateUpdate(
            string name = null,
            string handle = null,
            CustomPriceUsedForSubscriptionCreateUpdatePriceInCents priceInCents = null,
            CustomPriceUsedForSubscriptionCreateUpdateInterval interval = null,
            CustomPriceUsedForSubscriptionCreateUpdateIntervalUnit intervalUnit = null,
            CustomPriceUsedForSubscriptionCreateUpdateTrialPriceInCents trialPriceInCents = null,
            CustomPriceUsedForSubscriptionCreateUpdateTrialInterval trialInterval = null,
            CustomPriceUsedForSubscriptionCreateUpdateTrialIntervalUnit trialIntervalUnit = null,
            CustomPriceUsedForSubscriptionCreateUpdateInitialChargeInCents initialChargeInCents = null,
            bool? initialChargeAfterTrial = null,
            CustomPriceUsedForSubscriptionCreateUpdateExpirationInterval expirationInterval = null,
            CustomPriceUsedForSubscriptionCreateUpdateExpirationIntervalUnit expirationIntervalUnit = null,
            bool? taxIncluded = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.TrialPriceInCents = trialPriceInCents;
            this.TrialInterval = trialInterval;
            this.TrialIntervalUnit = trialIntervalUnit;
            this.InitialChargeInCents = initialChargeInCents;
            this.InitialChargeAfterTrial = initialChargeAfterTrial;
            this.ExpirationInterval = expirationInterval;
            this.ExpirationIntervalUnit = expirationIntervalUnit;
            this.TaxIncluded = taxIncluded;
        }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Required if using `custom_price` attribute.
        /// </summary>
        [JsonProperty("price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdatePriceInCents PriceInCents { get; set; }

        /// <summary>
        /// Required if using `custom_price` attribute.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateInterval Interval { get; set; }

        /// <summary>
        /// Required if using `custom_price` attribute.
        /// </summary>
        [JsonProperty("interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateIntervalUnit IntervalUnit { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("trial_price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateTrialPriceInCents TrialPriceInCents { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("trial_interval", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateTrialInterval TrialInterval { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("trial_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateTrialIntervalUnit TrialIntervalUnit { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("initial_charge_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateInitialChargeInCents InitialChargeInCents { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("initial_charge_after_trial", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitialChargeAfterTrial { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("expiration_interval", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateExpirationInterval ExpirationInterval { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("expiration_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPriceUsedForSubscriptionCreateUpdateExpirationIntervalUnit ExpirationIntervalUnit { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty("tax_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaxIncluded { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomPriceUsedForSubscriptionCreateUpdate : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomPriceUsedForSubscriptionCreateUpdate other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.PriceInCents == null && other.PriceInCents == null) || (this.PriceInCents?.Equals(other.PriceInCents) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true)) &&
                ((this.TrialPriceInCents == null && other.TrialPriceInCents == null) || (this.TrialPriceInCents?.Equals(other.TrialPriceInCents) == true)) &&
                ((this.TrialInterval == null && other.TrialInterval == null) || (this.TrialInterval?.Equals(other.TrialInterval) == true)) &&
                ((this.TrialIntervalUnit == null && other.TrialIntervalUnit == null) || (this.TrialIntervalUnit?.Equals(other.TrialIntervalUnit) == true)) &&
                ((this.InitialChargeInCents == null && other.InitialChargeInCents == null) || (this.InitialChargeInCents?.Equals(other.InitialChargeInCents) == true)) &&
                ((this.InitialChargeAfterTrial == null && other.InitialChargeAfterTrial == null) || (this.InitialChargeAfterTrial?.Equals(other.InitialChargeAfterTrial) == true)) &&
                ((this.ExpirationInterval == null && other.ExpirationInterval == null) || (this.ExpirationInterval?.Equals(other.ExpirationInterval) == true)) &&
                ((this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null) || (this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true)) &&
                ((this.TaxIncluded == null && other.TaxIncluded == null) || (this.TaxIncluded?.Equals(other.TaxIncluded) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"PriceInCents = {(this.PriceInCents == null ? "null" : this.PriceInCents.ToString())}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"TrialPriceInCents = {(this.TrialPriceInCents == null ? "null" : this.TrialPriceInCents.ToString())}");
            toStringOutput.Add($"TrialInterval = {(this.TrialInterval == null ? "null" : this.TrialInterval.ToString())}");
            toStringOutput.Add($"TrialIntervalUnit = {(this.TrialIntervalUnit == null ? "null" : this.TrialIntervalUnit.ToString())}");
            toStringOutput.Add($"InitialChargeInCents = {(this.InitialChargeInCents == null ? "null" : this.InitialChargeInCents.ToString())}");
            toStringOutput.Add($"this.InitialChargeAfterTrial = {(this.InitialChargeAfterTrial == null ? "null" : this.InitialChargeAfterTrial.ToString())}");
            toStringOutput.Add($"ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");
            toStringOutput.Add($"this.TaxIncluded = {(this.TaxIncluded == null ? "null" : this.TaxIncluded.ToString())}");
        }
    }
}