// <copyright file="AllocationPreviewItem.cs" company="APIMatic">
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
    /// AllocationPreviewItem.
    /// </summary>
    public class AllocationPreviewItem
    {
        private string timestamp;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "timestamp", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewItem"/> class.
        /// </summary>
        public AllocationPreviewItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewItem"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="previousQuantity">previous_quantity.</param>
        /// <param name="memo">memo.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="prorationUpgradeScheme">proration_upgrade_scheme.</param>
        /// <param name="prorationDowngradeScheme">proration_downgrade_scheme.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="previousPricePointId">previous_price_point_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        public AllocationPreviewItem(
            int? componentId = null,
            int? subscriptionId = null,
            double? quantity = null,
            int? previousQuantity = null,
            string memo = null,
            string timestamp = null,
            string prorationUpgradeScheme = null,
            string prorationDowngradeScheme = null,
            bool? accrueCharge = null,
            string upgradeCharge = null,
            string downgradeCredit = null,
            int? pricePointId = null,
            int? previousPricePointId = null,
            string componentHandle = null)
        {
            this.ComponentId = componentId;
            this.SubscriptionId = subscriptionId;
            this.Quantity = quantity;
            this.PreviousQuantity = previousQuantity;
            this.Memo = memo;
            if (timestamp != null)
            {
                this.Timestamp = timestamp;
            }

            this.ProrationUpgradeScheme = prorationUpgradeScheme;
            this.ProrationDowngradeScheme = prorationDowngradeScheme;
            this.AccrueCharge = accrueCharge;
            this.UpgradeCharge = upgradeCharge;
            this.DowngradeCredit = downgradeCredit;
            this.PricePointId = pricePointId;
            this.PreviousPricePointId = previousPricePointId;
            this.ComponentHandle = componentHandle;
        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity { get; set; }

        /// <summary>
        /// Gets or sets PreviousQuantity.
        /// </summary>
        [JsonProperty("previous_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousQuantity { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp
        {
            get
            {
                return this.timestamp;
            }

            set
            {
                this.shouldSerialize["timestamp"] = true;
                this.timestamp = value;
            }
        }

        /// <summary>
        /// Gets or sets ProrationUpgradeScheme.
        /// </summary>
        [JsonProperty("proration_upgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationUpgradeScheme { get; set; }

        /// <summary>
        /// Gets or sets ProrationDowngradeScheme.
        /// </summary>
        [JsonProperty("proration_downgrade_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string ProrationDowngradeScheme { get; set; }

        /// <summary>
        /// Gets or sets AccrueCharge.
        /// </summary>
        [JsonProperty("accrue_charge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccrueCharge { get; set; }

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
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets PreviousPricePointId.
        /// </summary>
        [JsonProperty("previous_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousPricePointId { get; set; }

        /// <summary>
        /// Gets or sets ComponentHandle.
        /// </summary>
        [JsonProperty("component_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentHandle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AllocationPreviewItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTimestamp()
        {
            this.shouldSerialize["timestamp"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTimestamp()
        {
            return this.shouldSerialize["timestamp"];
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
            return obj is AllocationPreviewItem other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.PreviousQuantity == null && other.PreviousQuantity == null) || (this.PreviousQuantity?.Equals(other.PreviousQuantity) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.ProrationUpgradeScheme == null && other.ProrationUpgradeScheme == null) || (this.ProrationUpgradeScheme?.Equals(other.ProrationUpgradeScheme) == true)) &&
                ((this.ProrationDowngradeScheme == null && other.ProrationDowngradeScheme == null) || (this.ProrationDowngradeScheme?.Equals(other.ProrationDowngradeScheme) == true)) &&
                ((this.AccrueCharge == null && other.AccrueCharge == null) || (this.AccrueCharge?.Equals(other.AccrueCharge) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.PreviousPricePointId == null && other.PreviousPricePointId == null) || (this.PreviousPricePointId?.Equals(other.PreviousPricePointId) == true)) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.PreviousQuantity = {(this.PreviousQuantity == null ? "null" : this.PreviousQuantity.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp)}");
            toStringOutput.Add($"this.ProrationUpgradeScheme = {(this.ProrationUpgradeScheme == null ? "null" : this.ProrationUpgradeScheme)}");
            toStringOutput.Add($"this.ProrationDowngradeScheme = {(this.ProrationDowngradeScheme == null ? "null" : this.ProrationDowngradeScheme)}");
            toStringOutput.Add($"this.AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge)}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit)}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.PreviousPricePointId = {(this.PreviousPricePointId == null ? "null" : this.PreviousPricePointId.ToString())}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
        }
    }
}