// <copyright file="Event.cs" company="APIMatic">
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
    /// Event.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="key">key.</param>
        /// <param name="message">message.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="eventSpecificData">event_specific_data.</param>
        public Event(
            double id,
            string key,
            string message,
            double subscriptionId,
            double customerId,
            string createdAt,
            EventEventSpecificData eventSpecificData = null)
        {
            this.Id = id;
            this.Key = key;
            this.Message = message;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.CreatedAt = createdAt;
            this.EventSpecificData = eventSpecificData;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public double Id { get; set; }

        /// <summary>
        /// Gets or sets Key.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public double SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id")]
        public double CustomerId { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets EventSpecificData.
        /// </summary>
        [JsonProperty("event_specific_data", NullValueHandling = NullValueHandling.Include)]
        public EventEventSpecificData EventSpecificData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Event : ({string.Join(", ", toStringOutput)})";
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
            return obj is Event other &&                this.Id.Equals(other.Id) &&
                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                this.SubscriptionId.Equals(other.SubscriptionId) &&
                this.CustomerId.Equals(other.CustomerId) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.EventSpecificData == null && other.EventSpecificData == null) || (this.EventSpecificData?.Equals(other.EventSpecificData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"this.CustomerId = {this.CustomerId}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"EventSpecificData = {(this.EventSpecificData == null ? "null" : this.EventSpecificData.ToString())}");
        }
    }
}