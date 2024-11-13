// <copyright file="BulkUpdateSegmentsItem.cs" company="APIMatic">
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
    /// BulkUpdateSegmentsItem.
    /// </summary>
    public class BulkUpdateSegmentsItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSegmentsItem"/> class.
        /// </summary>
        public BulkUpdateSegmentsItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSegmentsItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="prices">prices.</param>
        public BulkUpdateSegmentsItem(
            int id,
            string pricingScheme,
            List<Models.CreateOrUpdateSegmentPrice> prices)
        {
            this.Id = id;
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
        }

        /// <summary>
        /// The ID of the segment you want to update.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The handle for the pricing scheme. Available options: per_unit, volume, tiered, stairstep. See [Price Bracket Rules](https://help.chargify.com/products/product-components.html#price-bracket-rules) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public string PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices")]
        public List<Models.CreateOrUpdateSegmentPrice> Prices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BulkUpdateSegmentsItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is BulkUpdateSegmentsItem other &&                this.Id.Equals(other.Id) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.Prices == null && other.Prices == null) || (this.Prices?.Equals(other.Prices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme)}");
            toStringOutput.Add($"this.Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");
        }
    }
}