// <copyright file="PricePoint.cs" company="APIMatic">
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
    /// PricePoint.
    /// </summary>
    public class PricePoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricePoint"/> class.
        /// </summary>
        public PricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePoint"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="prices">prices.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="overagePricing">overage_pricing.</param>
        /// <param name="rolloverPrepaidRemainder">rollover_prepaid_remainder.</param>
        /// <param name="renewPrepaidAllocation">renew_prepaid_allocation.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        public PricePoint(
            string name = null,
            string handle = null,
            string pricingScheme = null,
            List<Models.Price> prices = null,
            bool? useSiteExchangeRate = true,
            Models.OveragePricing overagePricing = null,
            bool? rolloverPrepaidRemainder = null,
            bool? renewPrepaidAllocation = null,
            double? expirationInterval = null,
            PricePointExpirationIntervalUnit expirationIntervalUnit = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
            this.UseSiteExchangeRate = useSiteExchangeRate;
            this.OveragePricing = overagePricing;
            this.RolloverPrepaidRemainder = rolloverPrepaidRemainder;
            this.RenewPrepaidAllocation = renewPrepaidAllocation;
            this.ExpirationInterval = expirationInterval;
            this.ExpirationIntervalUnit = expirationIntervalUnit;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets PricingScheme.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Price> Prices { get; set; }

        /// <summary>
        /// Whether to use the site level exchange rate or define your own prices for each currency if you have multiple currencies defined on the site.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets OveragePricing.
        /// </summary>
        [JsonProperty("overage_pricing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OveragePricing OveragePricing { get; set; }

        /// <summary>
        /// Boolean which controls whether or not remaining units should be rolled over to the next period
        /// </summary>
        [JsonProperty("rollover_prepaid_remainder", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RolloverPrepaidRemainder { get; set; }

        /// <summary>
        /// Boolean which controls whether or not the allocated quantity should be renewed at the beginning of each period
        /// </summary>
        [JsonProperty("renew_prepaid_allocation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenewPrepaidAllocation { get; set; }

        /// <summary>
        /// (only for prepaid usage components where rollover_prepaid_remainder is true) The number of `expiration_interval_unit`s after which rollover amounts should expire
        /// </summary>
        [JsonProperty("expiration_interval", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpirationInterval { get; set; }

        /// <summary>
        /// Gets or sets ExpirationIntervalUnit.
        /// </summary>
        [JsonProperty("expiration_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public PricePointExpirationIntervalUnit ExpirationIntervalUnit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricePoint : ({string.Join(", ", toStringOutput)})";
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
            return obj is PricePoint other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Prices == null && other.Prices == null) || (this.Prices?.Equals(other.Prices) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true)) &&
                ((this.OveragePricing == null && other.OveragePricing == null) || (this.OveragePricing?.Equals(other.OveragePricing) == true)) &&
                ((this.RolloverPrepaidRemainder == null && other.RolloverPrepaidRemainder == null) || (this.RolloverPrepaidRemainder?.Equals(other.RolloverPrepaidRemainder) == true)) &&
                ((this.RenewPrepaidAllocation == null && other.RenewPrepaidAllocation == null) || (this.RenewPrepaidAllocation?.Equals(other.RenewPrepaidAllocation) == true)) &&
                ((this.ExpirationInterval == null && other.ExpirationInterval == null) || (this.ExpirationInterval?.Equals(other.ExpirationInterval) == true)) &&
                ((this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null) || (this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme)}");
            toStringOutput.Add($"this.Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.OveragePricing = {(this.OveragePricing == null ? "null" : this.OveragePricing.ToString())}");
            toStringOutput.Add($"this.RolloverPrepaidRemainder = {(this.RolloverPrepaidRemainder == null ? "null" : this.RolloverPrepaidRemainder.ToString())}");
            toStringOutput.Add($"this.RenewPrepaidAllocation = {(this.RenewPrepaidAllocation == null ? "null" : this.RenewPrepaidAllocation.ToString())}");
            toStringOutput.Add($"this.ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");
        }
    }
}