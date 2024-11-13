// <copyright file="CreateProductPricePoint.cs" company="APIMatic">
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
    /// CreateProductPricePoint.
    /// </summary>
    public class CreateProductPricePoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductPricePoint"/> class.
        /// </summary>
        public CreateProductPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProductPricePoint"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="handle">handle.</param>
        /// <param name="trialPriceInCents">trial_price_in_cents.</param>
        /// <param name="trialInterval">trial_interval.</param>
        /// <param name="trialIntervalUnit">trial_interval_unit.</param>
        /// <param name="trialType">trial_type.</param>
        /// <param name="initialChargeInCents">initial_charge_in_cents.</param>
        /// <param name="initialChargeAfterTrial">initial_charge_after_trial.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        public CreateProductPricePoint(
            string name,
            int priceInCents,
            int interval,
            string intervalUnit,
            string handle = null,
            int? trialPriceInCents = null,
            int? trialInterval = null,
            string trialIntervalUnit = null,
            string trialType = null,
            int? initialChargeInCents = null,
            bool? initialChargeAfterTrial = null,
            int? expirationInterval = null,
            string expirationIntervalUnit = null,
            bool? useSiteExchangeRate = true)
        {
            this.Name = name;
            this.Handle = handle;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.TrialPriceInCents = trialPriceInCents;
            this.TrialInterval = trialInterval;
            this.TrialIntervalUnit = trialIntervalUnit;
            this.TrialType = trialType;
            this.InitialChargeInCents = initialChargeInCents;
            this.InitialChargeAfterTrial = initialChargeAfterTrial;
            this.ExpirationInterval = expirationInterval;
            this.ExpirationIntervalUnit = expirationIntervalUnit;
            this.UseSiteExchangeRate = useSiteExchangeRate;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets PriceInCents.
        /// </summary>
        [JsonProperty("price_in_cents")]
        public int PriceInCents { get; set; }

        /// <summary>
        /// Gets or sets Interval.
        /// </summary>
        [JsonProperty("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// Gets or sets IntervalUnit.
        /// </summary>
        [JsonProperty("interval_unit")]
        public string IntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets TrialPriceInCents.
        /// </summary>
        [JsonProperty("trial_price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrialPriceInCents { get; set; }

        /// <summary>
        /// Gets or sets TrialInterval.
        /// </summary>
        [JsonProperty("trial_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrialInterval { get; set; }

        /// <summary>
        /// Gets or sets TrialIntervalUnit.
        /// </summary>
        [JsonProperty("trial_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string TrialIntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets TrialType.
        /// </summary>
        [JsonProperty("trial_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrialType { get; set; }

        /// <summary>
        /// Gets or sets InitialChargeInCents.
        /// </summary>
        [JsonProperty("initial_charge_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialChargeInCents { get; set; }

        /// <summary>
        /// Gets or sets InitialChargeAfterTrial.
        /// </summary>
        [JsonProperty("initial_charge_after_trial", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InitialChargeAfterTrial { get; set; }

        /// <summary>
        /// Gets or sets ExpirationInterval.
        /// </summary>
        [JsonProperty("expiration_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpirationInterval { get; set; }

        /// <summary>
        /// Gets or sets ExpirationIntervalUnit.
        /// </summary>
        [JsonProperty("expiration_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationIntervalUnit { get; set; }

        /// <summary>
        /// Whether or not to use the site's exchange rate or define your own pricing when your site has multiple currencies defined.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateProductPricePoint : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateProductPricePoint other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                this.PriceInCents.Equals(other.PriceInCents) &&
                this.Interval.Equals(other.Interval) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true)) &&
                ((this.TrialPriceInCents == null && other.TrialPriceInCents == null) || (this.TrialPriceInCents?.Equals(other.TrialPriceInCents) == true)) &&
                ((this.TrialInterval == null && other.TrialInterval == null) || (this.TrialInterval?.Equals(other.TrialInterval) == true)) &&
                ((this.TrialIntervalUnit == null && other.TrialIntervalUnit == null) || (this.TrialIntervalUnit?.Equals(other.TrialIntervalUnit) == true)) &&
                ((this.TrialType == null && other.TrialType == null) || (this.TrialType?.Equals(other.TrialType) == true)) &&
                ((this.InitialChargeInCents == null && other.InitialChargeInCents == null) || (this.InitialChargeInCents?.Equals(other.InitialChargeInCents) == true)) &&
                ((this.InitialChargeAfterTrial == null && other.InitialChargeAfterTrial == null) || (this.InitialChargeAfterTrial?.Equals(other.InitialChargeAfterTrial) == true)) &&
                ((this.ExpirationInterval == null && other.ExpirationInterval == null) || (this.ExpirationInterval?.Equals(other.ExpirationInterval) == true)) &&
                ((this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null) || (this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.PriceInCents = {this.PriceInCents}");
            toStringOutput.Add($"this.Interval = {this.Interval}");
            toStringOutput.Add($"this.IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit)}");
            toStringOutput.Add($"this.TrialPriceInCents = {(this.TrialPriceInCents == null ? "null" : this.TrialPriceInCents.ToString())}");
            toStringOutput.Add($"this.TrialInterval = {(this.TrialInterval == null ? "null" : this.TrialInterval.ToString())}");
            toStringOutput.Add($"this.TrialIntervalUnit = {(this.TrialIntervalUnit == null ? "null" : this.TrialIntervalUnit)}");
            toStringOutput.Add($"this.TrialType = {(this.TrialType == null ? "null" : this.TrialType)}");
            toStringOutput.Add($"this.InitialChargeInCents = {(this.InitialChargeInCents == null ? "null" : this.InitialChargeInCents.ToString())}");
            toStringOutput.Add($"this.InitialChargeAfterTrial = {(this.InitialChargeAfterTrial == null ? "null" : this.InitialChargeAfterTrial.ToString())}");
            toStringOutput.Add($"this.ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"this.ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit)}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
        }
    }
}