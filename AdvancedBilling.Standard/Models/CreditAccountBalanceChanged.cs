// <copyright file="CreditAccountBalanceChanged.cs" company="APIMatic">
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
    /// CreditAccountBalanceChanged.
    /// </summary>
    public class CreditAccountBalanceChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditAccountBalanceChanged"/> class.
        /// </summary>
        public CreditAccountBalanceChanged()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditAccountBalanceChanged"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="serviceCreditAccountBalanceInCents">service_credit_account_balance_in_cents.</param>
        /// <param name="serviceCreditBalanceChangeInCents">service_credit_balance_change_in_cents.</param>
        /// <param name="currencyCode">currency_code.</param>
        /// <param name="atTime">at_time.</param>
        public CreditAccountBalanceChanged(
            string reason,
            int serviceCreditAccountBalanceInCents,
            int serviceCreditBalanceChangeInCents,
            string currencyCode,
            string atTime)
        {
            this.Reason = reason;
            this.ServiceCreditAccountBalanceInCents = serviceCreditAccountBalanceInCents;
            this.ServiceCreditBalanceChangeInCents = serviceCreditBalanceChangeInCents;
            this.CurrencyCode = currencyCode;
            this.AtTime = atTime;
        }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("reason")]
        [JsonRequired]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets ServiceCreditAccountBalanceInCents.
        /// </summary>
        [JsonProperty("service_credit_account_balance_in_cents")]
        [JsonRequired]
        public int ServiceCreditAccountBalanceInCents { get; set; }

        /// <summary>
        /// Gets or sets ServiceCreditBalanceChangeInCents.
        /// </summary>
        [JsonProperty("service_credit_balance_change_in_cents")]
        [JsonRequired]
        public int ServiceCreditBalanceChangeInCents { get; set; }

        /// <summary>
        /// Gets or sets CurrencyCode.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("currency_code")]
        [JsonRequired]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets AtTime.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("at_time")]
        [JsonRequired]
        public string AtTime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreditAccountBalanceChanged : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreditAccountBalanceChanged other &&                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true)) &&
                this.ServiceCreditAccountBalanceInCents.Equals(other.ServiceCreditAccountBalanceInCents) &&
                this.ServiceCreditBalanceChangeInCents.Equals(other.ServiceCreditBalanceChangeInCents) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.AtTime == null && other.AtTime == null) || (this.AtTime?.Equals(other.AtTime) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
            toStringOutput.Add($"this.ServiceCreditAccountBalanceInCents = {this.ServiceCreditAccountBalanceInCents}");
            toStringOutput.Add($"this.ServiceCreditBalanceChangeInCents = {this.ServiceCreditBalanceChangeInCents}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.AtTime = {(this.AtTime == null ? "null" : this.AtTime)}");
        }
    }
}