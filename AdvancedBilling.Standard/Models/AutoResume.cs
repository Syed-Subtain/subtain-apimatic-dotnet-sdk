// <copyright file="AutoResume.cs" company="APIMatic">
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
    /// AutoResume.
    /// </summary>
    public class AutoResume
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoResume"/> class.
        /// </summary>
        public AutoResume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoResume"/> class.
        /// </summary>
        /// <param name="automaticallyResumeAt">automatically_resume_at.</param>
        public AutoResume(
            string automaticallyResumeAt = null)
        {
            this.AutomaticallyResumeAt = automaticallyResumeAt;
        }

        /// <summary>
        /// Gets or sets AutomaticallyResumeAt.
        /// </summary>
        [JsonProperty("automatically_resume_at", NullValueHandling = NullValueHandling.Ignore)]
        public string AutomaticallyResumeAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoResume : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoResume other &&                ((this.AutomaticallyResumeAt == null && other.AutomaticallyResumeAt == null) || (this.AutomaticallyResumeAt?.Equals(other.AutomaticallyResumeAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AutomaticallyResumeAt = {(this.AutomaticallyResumeAt == null ? "null" : this.AutomaticallyResumeAt)}");
        }
    }
}