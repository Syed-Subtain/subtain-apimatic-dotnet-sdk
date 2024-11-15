// <copyright file="CustomerPayerChange.cs" company="APIMatic">
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
    /// CustomerPayerChange.
    /// </summary>
    public class CustomerPayerChange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPayerChange"/> class.
        /// </summary>
        public CustomerPayerChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPayerChange"/> class.
        /// </summary>
        /// <param name="before">before.</param>
        /// <param name="after">after.</param>
        public CustomerPayerChange(
            object before = null,
            object after = null)
        {
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// Gets or sets Before.
        /// </summary>
        [JsonProperty("before", NullValueHandling = NullValueHandling.Ignore)]
        public object Before { get; set; }

        /// <summary>
        /// Gets or sets After.
        /// </summary>
        [JsonProperty("after", NullValueHandling = NullValueHandling.Ignore)]
        public object After { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerPayerChange : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerPayerChange other &&                ((this.Before == null && other.Before == null) || (this.Before?.Equals(other.Before) == true)) &&
                ((this.After == null && other.After == null) || (this.After?.Equals(other.After) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Before = {(this.Before == null ? "null" : this.Before.ToString())}");
            toStringOutput.Add($"After = {(this.After == null ? "null" : this.After.ToString())}");
        }
    }
}