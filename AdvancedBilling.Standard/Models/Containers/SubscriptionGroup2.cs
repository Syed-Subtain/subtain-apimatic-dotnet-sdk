using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<SubscriptionGroup2>),
        new Type[] {
            typeof(SubscriptionGroupInlinedCase)
        },
        true
    )]
    public abstract class SubscriptionGroup2
    {
        /// <summary>
        /// This is Subscription Group Inlined case.
        /// </summary>
        /// <returns>
        /// The SubscriptionGroup2 instance, wrapping the provided SubscriptionGroupInlined value.
        /// </returns>
        public static SubscriptionGroup2 FromSubscriptionGroupInlined(SubscriptionGroupInlined subscriptionGroupInlined)
        {
            return new SubscriptionGroupInlinedCase().Set(subscriptionGroupInlined);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<SubscriptionGroupInlined, T> subscriptionGroupInlined);

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionGroupInlinedCase, SubscriptionGroupInlined>))]
        private sealed class SubscriptionGroupInlinedCase : SubscriptionGroup2, ICaseValue<SubscriptionGroupInlinedCase, SubscriptionGroupInlined>
        {
            public SubscriptionGroupInlined _value;

            public override T Match<T>(Func<SubscriptionGroupInlined, T> subscriptionGroupInlined)
            {
                return subscriptionGroupInlined(_value);
            }

            public SubscriptionGroupInlinedCase Set(SubscriptionGroupInlined value)
            {
                _value = value;
                return this;
            }

            public SubscriptionGroupInlined Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}