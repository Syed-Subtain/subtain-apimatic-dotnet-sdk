// <copyright file="CreateOrUpdateProduct.cs" company="APIMatic">
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
    /// CreateOrUpdateProduct.
    /// </summary>
    public class CreateOrUpdateProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateProduct"/> class.
        /// </summary>
        public CreateOrUpdateProduct()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateProduct"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="handle">handle.</param>
        /// <param name="accountingCode">accounting_code.</param>
        /// <param name="requireCreditCard">require_credit_card.</param>
        /// <param name="autoCreateSignupPage">auto_create_signup_page.</param>
        /// <param name="taxCode">tax_code.</param>
        public CreateOrUpdateProduct(
            string name,
            string description,
            int priceInCents,
            int interval,
            string intervalUnit,
            string handle = null,
            string accountingCode = null,
            bool? requireCreditCard = null,
            bool? autoCreateSignupPage = null,
            string taxCode = null)
        {
            this.Name = name;
            this.Handle = handle;
            this.Description = description;
            this.AccountingCode = accountingCode;
            this.RequireCreditCard = requireCreditCard;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.AutoCreateSignupPage = autoCreateSignupPage;
            this.TaxCode = taxCode;
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
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets AccountingCode.
        /// </summary>
        [JsonProperty("accounting_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountingCode { get; set; }

        /// <summary>
        /// Gets or sets RequireCreditCard.
        /// </summary>
        [JsonProperty("require_credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireCreditCard { get; set; }

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
        /// Gets or sets AutoCreateSignupPage.
        /// </summary>
        [JsonProperty("auto_create_signup_page", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateSignupPage { get; set; }

        /// <summary>
        /// Gets or sets TaxCode.
        /// </summary>
        [JsonProperty("tax_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrUpdateProduct : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrUpdateProduct other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AccountingCode == null && other.AccountingCode == null) || (this.AccountingCode?.Equals(other.AccountingCode) == true)) &&
                ((this.RequireCreditCard == null && other.RequireCreditCard == null) || (this.RequireCreditCard?.Equals(other.RequireCreditCard) == true)) &&
                this.PriceInCents.Equals(other.PriceInCents) &&
                this.Interval.Equals(other.Interval) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true)) &&
                ((this.AutoCreateSignupPage == null && other.AutoCreateSignupPage == null) || (this.AutoCreateSignupPage?.Equals(other.AutoCreateSignupPage) == true)) &&
                ((this.TaxCode == null && other.TaxCode == null) || (this.TaxCode?.Equals(other.TaxCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AccountingCode = {(this.AccountingCode == null ? "null" : this.AccountingCode)}");
            toStringOutput.Add($"this.RequireCreditCard = {(this.RequireCreditCard == null ? "null" : this.RequireCreditCard.ToString())}");
            toStringOutput.Add($"this.PriceInCents = {this.PriceInCents}");
            toStringOutput.Add($"this.Interval = {this.Interval}");
            toStringOutput.Add($"this.IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit)}");
            toStringOutput.Add($"this.AutoCreateSignupPage = {(this.AutoCreateSignupPage == null ? "null" : this.AutoCreateSignupPage.ToString())}");
            toStringOutput.Add($"this.TaxCode = {(this.TaxCode == null ? "null" : this.TaxCode)}");
        }
    }
}