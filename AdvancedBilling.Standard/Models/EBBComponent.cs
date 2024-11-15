// <copyright file="EBBComponent.cs" company="APIMatic">
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
    /// EBBComponent.
    /// </summary>
    public class EBBComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EBBComponent"/> class.
        /// </summary>
        public EBBComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EBBComponent"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="unitName">unit_name.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="eventBasedBillingMetricId">event_based_billing_metric_id.</param>
        /// <param name="description">description.</param>
        /// <param name="handle">handle.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="prices">prices.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="pricePoints">price_points.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="hideDateRangeOnInvoice">hide_date_range_on_invoice.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        public EBBComponent(
            string name,
            string unitName,
            EBBComponentPricingScheme pricingScheme,
            int eventBasedBillingMetricId,
            string description = null,
            string handle = null,
            bool? taxable = null,
            List<Models.Price> prices = null,
            string upgradeCharge = null,
            string downgradeCredit = null,
            List<Models.ComponentPricePointItem> pricePoints = null,
            EBBComponentUnitPrice unitPrice = null,
            string taxCode = null,
            bool? hideDateRangeOnInvoice = null,
            string priceInCents = null)
        {
            this.Name = name;
            this.UnitName = unitName;
            this.Description = description;
            this.Handle = handle;
            this.Taxable = taxable;
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
            this.UpgradeCharge = upgradeCharge;
            this.DowngradeCredit = downgradeCredit;
            this.PricePoints = pricePoints;
            this.UnitPrice = unitPrice;
            this.TaxCode = taxCode;
            this.HideDateRangeOnInvoice = hideDateRangeOnInvoice;
            this.PriceInCents = priceInCents;
            this.EventBasedBillingMetricId = eventBasedBillingMetricId;
        }

        /// <summary>
        /// A name for this component that is suitable for showing customers and displaying on billing statements, ie. "Minutes".
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the unit of measurement for the component. It should be singular since it will be automatically pluralized when necessary. i.e. “message”, which may then be shown as “5 messages” on a subscription’s component line-item
        /// </summary>
        [JsonProperty("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// A description for the component that will be displayed to the user on the hosted signup page.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// A unique identifier for your use that can be used to retrieve this component is subsequent requests.  Must start with a letter or number and may only contain lowercase letters, numbers, or the characters '.', ':', '-', or '_'.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Boolean flag describing whether a component is taxable or not.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public EBBComponentPricingScheme PricingScheme { get; set; }

        /// <summary>
        /// (Not required for ‘per_unit’ pricing schemes) One or more price brackets. See [Price Bracket Rules](https://help.chargify.com/products/product-components.html#general-price-bracket-rules) for an overview of how price brackets work for different pricing schemes.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Price> Prices { get; set; }

        /// <summary>
        /// Gets or sets UpgradeCharge.
        /// </summary>
        [JsonProperty("upgrade_charge", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeCharge { get; set; }

        /// <summary>
        /// Gets or sets DowngradeCredit.
        /// </summary>
        [JsonProperty("downgrade_credit", NullValueHandling = NullValueHandling.Ignore)]
        public string DowngradeCredit { get; set; }

        /// <summary>
        /// Gets or sets PricePoints.
        /// </summary>
        [JsonProperty("price_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentPricePointItem> PricePoints { get; set; }

        /// <summary>
        /// The amount the customer will be charged per unit when the pricing scheme is “per_unit”. The price can contain up to 8 decimal places. i.e. 1.00 or 0.0012 or 0.00000065
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public EBBComponentUnitPrice UnitPrice { get; set; }

        /// <summary>
        /// A string representing the tax code related to the component type. This is especially important when using the Avalara service to tax based on locale. This attribute has a max length of 10 characters.
        /// </summary>
        [JsonProperty("tax_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxCode { get; set; }

        /// <summary>
        /// (Only available on Relationship Invoicing sites) Boolean flag describing if the service date range should show for the component on generated invoices.
        /// </summary>
        [JsonProperty("hide_date_range_on_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideDateRangeOnInvoice { get; set; }

        /// <summary>
        /// deprecated May 2011 - use unit_price instead
        /// </summary>
        [JsonProperty("price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public string PriceInCents { get; set; }

        /// <summary>
        /// The ID of an event based billing metric that will be attached to this component.
        /// </summary>
        [JsonProperty("event_based_billing_metric_id")]
        public int EventBasedBillingMetricId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EBBComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is EBBComponent other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.UnitName == null && other.UnitName == null) || (this.UnitName?.Equals(other.UnitName) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.Taxable == null && other.Taxable == null) || (this.Taxable?.Equals(other.Taxable) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Prices == null && other.Prices == null) || (this.Prices?.Equals(other.Prices) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.PricePoints == null && other.PricePoints == null) || (this.PricePoints?.Equals(other.PricePoints) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.TaxCode == null && other.TaxCode == null) || (this.TaxCode?.Equals(other.TaxCode) == true)) &&
                ((this.HideDateRangeOnInvoice == null && other.HideDateRangeOnInvoice == null) || (this.HideDateRangeOnInvoice?.Equals(other.HideDateRangeOnInvoice) == true)) &&
                ((this.PriceInCents == null && other.PriceInCents == null) || (this.PriceInCents?.Equals(other.PriceInCents) == true)) &&
                this.EventBasedBillingMetricId.Equals(other.EventBasedBillingMetricId);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.UnitName = {(this.UnitName == null ? "null" : this.UnitName)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"this.Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge)}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit)}");
            toStringOutput.Add($"this.PricePoints = {(this.PricePoints == null ? "null" : $"[{string.Join(", ", this.PricePoints)} ]")}");
            toStringOutput.Add($"UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"this.TaxCode = {(this.TaxCode == null ? "null" : this.TaxCode)}");
            toStringOutput.Add($"this.HideDateRangeOnInvoice = {(this.HideDateRangeOnInvoice == null ? "null" : this.HideDateRangeOnInvoice.ToString())}");
            toStringOutput.Add($"this.PriceInCents = {(this.PriceInCents == null ? "null" : this.PriceInCents)}");
            toStringOutput.Add($"this.EventBasedBillingMetricId = {this.EventBasedBillingMetricId}");
        }
    }
}