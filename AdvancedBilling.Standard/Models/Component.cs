// <copyright file="Component.cs" company="APIMatic">
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
    /// Component.
    /// </summary>
    public class Component
    {
        private string pricingScheme;
        private string unitPrice;
        private int? pricePerUnitInCents;
        private string description;
        private List<Models.ComponentPrice> prices;
        private string taxCode;
        private string upgradeCharge;
        private string downgradeCredit;
        private string archivedAt;
        private bool? useSiteExchangeRate;
        private string accountingCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "pricing_scheme", false },
            { "unit_price", false },
            { "price_per_unit_in_cents", false },
            { "description", false },
            { "prices", false },
            { "tax_code", false },
            { "upgrade_charge", false },
            { "downgrade_credit", false },
            { "archived_at", false },
            { "use_site_exchange_rate", false },
            { "accounting_code", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        public Component()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="unitName">unit_name.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="productFamilyId">product_family_id.</param>
        /// <param name="productFamilyName">product_family_name.</param>
        /// <param name="pricePerUnitInCents">price_per_unit_in_cents.</param>
        /// <param name="kind">kind.</param>
        /// <param name="archived">archived.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="description">description.</param>
        /// <param name="defaultPricePointId">default_price_point_id.</param>
        /// <param name="prices">prices.</param>
        /// <param name="pricePointCount">price_point_count.</param>
        /// <param name="pricePointsUrl">price_points_url.</param>
        /// <param name="defaultPricePointName">default_price_point_name.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="hideDateRangeOnInvoice">hide_date_range_on_invoice.</param>
        /// <param name="allowFractionalQuantities">allow_fractional_quantities.</param>
        /// <param name="itemCategory">item_category.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="accountingCode">accounting_code.</param>
        /// <param name="eventBasedBillingMetricId">event_based_billing_metric_id.</param>
        public Component(
            int? id = null,
            string name = null,
            string handle = null,
            string pricingScheme = null,
            string unitName = null,
            string unitPrice = null,
            int? productFamilyId = null,
            string productFamilyName = null,
            int? pricePerUnitInCents = null,
            Models.ComponentKind? kind = null,
            bool? archived = null,
            bool? taxable = null,
            string description = null,
            int? defaultPricePointId = null,
            List<Models.ComponentPrice> prices = null,
            int? pricePointCount = null,
            string pricePointsUrl = null,
            string defaultPricePointName = null,
            string taxCode = null,
            bool? recurring = null,
            string upgradeCharge = null,
            string downgradeCredit = null,
            string createdAt = null,
            string updatedAt = null,
            string archivedAt = null,
            bool? hideDateRangeOnInvoice = null,
            bool? allowFractionalQuantities = null,
            Models.ItemCategory? itemCategory = null,
            bool? useSiteExchangeRate = null,
            string accountingCode = null,
            int? eventBasedBillingMetricId = null)
        {
            this.Id = id;
            this.Name = name;
            this.Handle = handle;
            if (pricingScheme != null)
            {
                this.PricingScheme = pricingScheme;
            }

            this.UnitName = unitName;
            if (unitPrice != null)
            {
                this.UnitPrice = unitPrice;
            }

            this.ProductFamilyId = productFamilyId;
            this.ProductFamilyName = productFamilyName;
            if (pricePerUnitInCents != null)
            {
                this.PricePerUnitInCents = pricePerUnitInCents;
            }

            this.Kind = kind;
            this.Archived = archived;
            this.Taxable = taxable;
            if (description != null)
            {
                this.Description = description;
            }

            this.DefaultPricePointId = defaultPricePointId;
            if (prices != null)
            {
                this.Prices = prices;
            }

            this.PricePointCount = pricePointCount;
            this.PricePointsUrl = pricePointsUrl;
            this.DefaultPricePointName = defaultPricePointName;
            if (taxCode != null)
            {
                this.TaxCode = taxCode;
            }

            this.Recurring = recurring;
            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }

            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }

            this.HideDateRangeOnInvoice = hideDateRangeOnInvoice;
            this.AllowFractionalQuantities = allowFractionalQuantities;
            this.ItemCategory = itemCategory;
            if (useSiteExchangeRate != null)
            {
                this.UseSiteExchangeRate = useSiteExchangeRate;
            }

            if (accountingCode != null)
            {
                this.AccountingCode = accountingCode;
            }

            this.EventBasedBillingMetricId = eventBasedBillingMetricId;
        }

        /// <summary>
        /// The unique ID assigned to the component by Chargify. This ID can be used to fetch the component from the API.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the Component, suitable for display on statements. i.e. Text Messages.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The component API handle
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// The handle for the pricing scheme. Available options: per_unit, volume, tiered, stairstep. See [Price Bracket Rules](https://chargify.zendesk.com/hc/en-us/articles/4407755865883#price-bracket-rules) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public string PricingScheme
        {
            get
            {
                return this.pricingScheme;
            }

            set
            {
                this.shouldSerialize["pricing_scheme"] = true;
                this.pricingScheme = value;
            }
        }

        /// <summary>
        /// The name of the unit that the component’s usage is measured in. i.e. message
        /// </summary>
        [JsonProperty("unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitName { get; set; }

        /// <summary>
        /// The amount the customer will be charged per unit. This field is only populated for ‘per_unit’ pricing schemes, otherwise it may be null.
        /// </summary>
        [JsonProperty("unit_price")]
        public string UnitPrice
        {
            get
            {
                return this.unitPrice;
            }

            set
            {
                this.shouldSerialize["unit_price"] = true;
                this.unitPrice = value;
            }
        }

        /// <summary>
        /// The id of the Product Family to which the Component belongs
        /// </summary>
        [JsonProperty("product_family_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductFamilyId { get; set; }

        /// <summary>
        /// The name of the Product Family to which the Component belongs
        /// </summary>
        [JsonProperty("product_family_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductFamilyName { get; set; }

        /// <summary>
        /// deprecated - use unit_price instead
        /// </summary>
        [JsonProperty("price_per_unit_in_cents")]
        public int? PricePerUnitInCents
        {
            get
            {
                return this.pricePerUnitInCents;
            }

            set
            {
                this.shouldSerialize["price_per_unit_in_cents"] = true;
                this.pricePerUnitInCents = value;
            }
        }

        /// <summary>
        /// A handle for the component type
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ComponentKind? Kind { get; set; }

        /// <summary>
        /// Boolean flag describing whether a component is archived or not.
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// Boolean flag describing whether a component is taxable or not.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// The description of the component.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets DefaultPricePointId.
        /// </summary>
        [JsonProperty("default_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPricePointId { get; set; }

        /// <summary>
        /// An array of price brackets. If the component uses the ‘per_unit’ pricing scheme, this array will be empty.
        /// </summary>
        [JsonProperty("prices")]
        public List<Models.ComponentPrice> Prices
        {
            get
            {
                return this.prices;
            }

            set
            {
                this.shouldSerialize["prices"] = true;
                this.prices = value;
            }
        }

        /// <summary>
        /// Count for the number of price points associated with the component
        /// </summary>
        [JsonProperty("price_point_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointCount { get; set; }

        /// <summary>
        /// URL that points to the location to read the existing price points via GET request
        /// </summary>
        [JsonProperty("price_points_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePointsUrl { get; set; }

        /// <summary>
        /// Gets or sets DefaultPricePointName.
        /// </summary>
        [JsonProperty("default_price_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPricePointName { get; set; }

        /// <summary>
        /// A string representing the tax code related to the component type. This is especially important when using the Avalara service to tax based on locale. This attribute has a max length of 10 characters.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode
        {
            get
            {
                return this.taxCode;
            }

            set
            {
                this.shouldSerialize["tax_code"] = true;
                this.taxCode = value;
            }
        }

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Gets or sets UpgradeCharge.
        /// </summary>
        [JsonProperty("upgrade_charge")]
        public string UpgradeCharge
        {
            get
            {
                return this.upgradeCharge;
            }

            set
            {
                this.shouldSerialize["upgrade_charge"] = true;
                this.upgradeCharge = value;
            }
        }

        /// <summary>
        /// Gets or sets DowngradeCredit.
        /// </summary>
        [JsonProperty("downgrade_credit")]
        public string DowngradeCredit
        {
            get
            {
                return this.downgradeCredit;
            }

            set
            {
                this.shouldSerialize["downgrade_credit"] = true;
                this.downgradeCredit = value;
            }
        }

        /// <summary>
        /// Timestamp indicating when this component was created
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when this component was updated
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when this component was archived
        /// </summary>
        [JsonProperty("archived_at")]
        public string ArchivedAt
        {
            get
            {
                return this.archivedAt;
            }

            set
            {
                this.shouldSerialize["archived_at"] = true;
                this.archivedAt = value;
            }
        }

        /// <summary>
        /// (Only available on Relationship Invoicing sites) Boolean flag describing if the service date range should show for the component on generated invoices.
        /// </summary>
        [JsonProperty("hide_date_range_on_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideDateRangeOnInvoice { get; set; }

        /// <summary>
        /// Gets or sets AllowFractionalQuantities.
        /// </summary>
        [JsonProperty("allow_fractional_quantities", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowFractionalQuantities { get; set; }

        /// <summary>
        /// One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other
        /// </summary>
        [JsonProperty("item_category", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ItemCategory? ItemCategory { get; set; }

        /// <summary>
        /// Gets or sets UseSiteExchangeRate.
        /// </summary>
        [JsonProperty("use_site_exchange_rate")]
        public bool? UseSiteExchangeRate
        {
            get
            {
                return this.useSiteExchangeRate;
            }

            set
            {
                this.shouldSerialize["use_site_exchange_rate"] = true;
                this.useSiteExchangeRate = value;
            }
        }

        /// <summary>
        /// E.g. Internal ID or SKU Number
        /// </summary>
        [JsonProperty("accounting_code")]
        public string AccountingCode
        {
            get
            {
                return this.accountingCode;
            }

            set
            {
                this.shouldSerialize["accounting_code"] = true;
                this.accountingCode = value;
            }
        }

        /// <summary>
        /// (Only for Event Based Components) This is an ID of a metric attached to the component. This metric is used to bill upon collected events.
        /// </summary>
        [JsonProperty("event_based_billing_metric_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventBasedBillingMetricId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Component : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricingScheme()
        {
            this.shouldSerialize["pricing_scheme"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnitPrice()
        {
            this.shouldSerialize["unit_price"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePerUnitInCents()
        {
            this.shouldSerialize["price_per_unit_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPrices()
        {
            this.shouldSerialize["prices"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTaxCode()
        {
            this.shouldSerialize["tax_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUpgradeCharge()
        {
            this.shouldSerialize["upgrade_charge"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDowngradeCredit()
        {
            this.shouldSerialize["downgrade_credit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUseSiteExchangeRate()
        {
            this.shouldSerialize["use_site_exchange_rate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountingCode()
        {
            this.shouldSerialize["accounting_code"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingScheme()
        {
            return this.shouldSerialize["pricing_scheme"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitPrice()
        {
            return this.shouldSerialize["unit_price"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePerUnitInCents()
        {
            return this.shouldSerialize["price_per_unit_in_cents"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrices()
        {
            return this.shouldSerialize["prices"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTaxCode()
        {
            return this.shouldSerialize["tax_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpgradeCharge()
        {
            return this.shouldSerialize["upgrade_charge"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDowngradeCredit()
        {
            return this.shouldSerialize["downgrade_credit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArchivedAt()
        {
            return this.shouldSerialize["archived_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUseSiteExchangeRate()
        {
            return this.shouldSerialize["use_site_exchange_rate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountingCode()
        {
            return this.shouldSerialize["accounting_code"];
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
            return obj is Component other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.UnitName == null && other.UnitName == null) || (this.UnitName?.Equals(other.UnitName) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.ProductFamilyId == null && other.ProductFamilyId == null) || (this.ProductFamilyId?.Equals(other.ProductFamilyId) == true)) &&
                ((this.ProductFamilyName == null && other.ProductFamilyName == null) || (this.ProductFamilyName?.Equals(other.ProductFamilyName) == true)) &&
                ((this.PricePerUnitInCents == null && other.PricePerUnitInCents == null) || (this.PricePerUnitInCents?.Equals(other.PricePerUnitInCents) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Archived == null && other.Archived == null) || (this.Archived?.Equals(other.Archived) == true)) &&
                ((this.Taxable == null && other.Taxable == null) || (this.Taxable?.Equals(other.Taxable) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.DefaultPricePointId == null && other.DefaultPricePointId == null) || (this.DefaultPricePointId?.Equals(other.DefaultPricePointId) == true)) &&
                ((this.Prices == null && other.Prices == null) || (this.Prices?.Equals(other.Prices) == true)) &&
                ((this.PricePointCount == null && other.PricePointCount == null) || (this.PricePointCount?.Equals(other.PricePointCount) == true)) &&
                ((this.PricePointsUrl == null && other.PricePointsUrl == null) || (this.PricePointsUrl?.Equals(other.PricePointsUrl) == true)) &&
                ((this.DefaultPricePointName == null && other.DefaultPricePointName == null) || (this.DefaultPricePointName?.Equals(other.DefaultPricePointName) == true)) &&
                ((this.TaxCode == null && other.TaxCode == null) || (this.TaxCode?.Equals(other.TaxCode) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.ArchivedAt == null && other.ArchivedAt == null) || (this.ArchivedAt?.Equals(other.ArchivedAt) == true)) &&
                ((this.HideDateRangeOnInvoice == null && other.HideDateRangeOnInvoice == null) || (this.HideDateRangeOnInvoice?.Equals(other.HideDateRangeOnInvoice) == true)) &&
                ((this.AllowFractionalQuantities == null && other.AllowFractionalQuantities == null) || (this.AllowFractionalQuantities?.Equals(other.AllowFractionalQuantities) == true)) &&
                ((this.ItemCategory == null && other.ItemCategory == null) || (this.ItemCategory?.Equals(other.ItemCategory) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true)) &&
                ((this.AccountingCode == null && other.AccountingCode == null) || (this.AccountingCode?.Equals(other.AccountingCode) == true)) &&
                ((this.EventBasedBillingMetricId == null && other.EventBasedBillingMetricId == null) || (this.EventBasedBillingMetricId?.Equals(other.EventBasedBillingMetricId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme)}");
            toStringOutput.Add($"this.UnitName = {(this.UnitName == null ? "null" : this.UnitName)}");
            toStringOutput.Add($"this.UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice)}");
            toStringOutput.Add($"this.ProductFamilyId = {(this.ProductFamilyId == null ? "null" : this.ProductFamilyId.ToString())}");
            toStringOutput.Add($"this.ProductFamilyName = {(this.ProductFamilyName == null ? "null" : this.ProductFamilyName)}");
            toStringOutput.Add($"this.PricePerUnitInCents = {(this.PricePerUnitInCents == null ? "null" : this.PricePerUnitInCents.ToString())}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind.ToString())}");
            toStringOutput.Add($"this.Archived = {(this.Archived == null ? "null" : this.Archived.ToString())}");
            toStringOutput.Add($"this.Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.DefaultPricePointId = {(this.DefaultPricePointId == null ? "null" : this.DefaultPricePointId.ToString())}");
            toStringOutput.Add($"this.Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
            toStringOutput.Add($"this.PricePointCount = {(this.PricePointCount == null ? "null" : this.PricePointCount.ToString())}");
            toStringOutput.Add($"this.PricePointsUrl = {(this.PricePointsUrl == null ? "null" : this.PricePointsUrl)}");
            toStringOutput.Add($"this.DefaultPricePointName = {(this.DefaultPricePointName == null ? "null" : this.DefaultPricePointName)}");
            toStringOutput.Add($"this.TaxCode = {(this.TaxCode == null ? "null" : this.TaxCode)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge)}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt)}");
            toStringOutput.Add($"this.HideDateRangeOnInvoice = {(this.HideDateRangeOnInvoice == null ? "null" : this.HideDateRangeOnInvoice.ToString())}");
            toStringOutput.Add($"this.AllowFractionalQuantities = {(this.AllowFractionalQuantities == null ? "null" : this.AllowFractionalQuantities.ToString())}");
            toStringOutput.Add($"this.ItemCategory = {(this.ItemCategory == null ? "null" : this.ItemCategory.ToString())}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.AccountingCode = {(this.AccountingCode == null ? "null" : this.AccountingCode)}");
            toStringOutput.Add($"this.EventBasedBillingMetricId = {(this.EventBasedBillingMetricId == null ? "null" : this.EventBasedBillingMetricId.ToString())}");
        }
    }
}