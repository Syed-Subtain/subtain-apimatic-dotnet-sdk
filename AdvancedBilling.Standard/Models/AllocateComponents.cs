// <copyright file="AllocateComponents.cs" company="APIMatic">
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
    /// AllocateComponents.
    /// </summary>
    public class AllocateComponents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocateComponents"/> class.
        /// </summary>
        public AllocateComponents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocateComponents"/> class.
        /// </summary>
        /// <param name="prorationUpgradeScheme">proration_upgrade_scheme.</param>
        /// <param name="prorationDowngradeScheme">proration_downgrade_scheme.</param>
        /// <param name="allocations">allocations.</param>
        /// <param name="accrueCharge">accrue_charge.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        public AllocateComponents(
            string prorationUpgradeScheme = "no-prorate",
            string prorationDowngradeScheme = "no-prorate",
            List<Models.CreateAllocationRequest> allocations = null,
            bool? accrueCharge = null,
            string upgradeCharge = null,
            string downgradeCredit = null,
            Models.PaymentCollectionMethod1? paymentCollectionMethod = Models.PaymentCollectionMethod1.Automatic)
        {
            this.ProrationUpgradeScheme = prorationUpgradeScheme;
            this.ProrationDowngradeScheme = prorationDowngradeScheme;
            this.Allocations = allocations;
            this.AccrueCharge = accrueCharge;
            this.UpgradeCharge = upgradeCharge;
            this.DowngradeCredit = downgradeCredit;
            this.PaymentCollectionMethod = paymentCollectionMethod;
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
        /// Gets or sets Allocations.
        /// </summary>
        [JsonProperty("allocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateAllocationRequest> Allocations { get; set; }

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
        /// (Optional) If not passed, the allocation(s) will use the payment collection method on the subscription
        /// </summary>
        [JsonProperty("payment_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentCollectionMethod1? PaymentCollectionMethod { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AllocateComponents : ({string.Join(", ", toStringOutput)})";
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
            return obj is AllocateComponents other &&                ((this.ProrationUpgradeScheme == null && other.ProrationUpgradeScheme == null) || (this.ProrationUpgradeScheme?.Equals(other.ProrationUpgradeScheme) == true)) &&
                ((this.ProrationDowngradeScheme == null && other.ProrationDowngradeScheme == null) || (this.ProrationDowngradeScheme?.Equals(other.ProrationDowngradeScheme) == true)) &&
                ((this.Allocations == null && other.Allocations == null) || (this.Allocations?.Equals(other.Allocations) == true)) &&
                ((this.AccrueCharge == null && other.AccrueCharge == null) || (this.AccrueCharge?.Equals(other.AccrueCharge) == true)) &&
                ((this.UpgradeCharge == null && other.UpgradeCharge == null) || (this.UpgradeCharge?.Equals(other.UpgradeCharge) == true)) &&
                ((this.DowngradeCredit == null && other.DowngradeCredit == null) || (this.DowngradeCredit?.Equals(other.DowngradeCredit) == true)) &&
                ((this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null) || (this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProrationUpgradeScheme = {(this.ProrationUpgradeScheme == null ? "null" : this.ProrationUpgradeScheme)}");
            toStringOutput.Add($"this.ProrationDowngradeScheme = {(this.ProrationDowngradeScheme == null ? "null" : this.ProrationDowngradeScheme)}");
            toStringOutput.Add($"this.Allocations = {(this.Allocations == null ? "null" : $"[{string.Join(", ", this.Allocations)} ]")}");
            toStringOutput.Add($"this.AccrueCharge = {(this.AccrueCharge == null ? "null" : this.AccrueCharge.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge)}");
            toStringOutput.Add($"this.DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit)}");
            toStringOutput.Add($"this.PaymentCollectionMethod = {(this.PaymentCollectionMethod == null ? "null" : this.PaymentCollectionMethod.ToString())}");
        }
    }
}