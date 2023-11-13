using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<SubscriptionCancellationMethod>),
        new Type[] {
            typeof(CancellationMethodCase)
        },
        true
    )]
    public abstract class SubscriptionCancellationMethod
    {
        /// <summary>
        /// This is Cancellation Method case.
        /// </summary>
        /// <returns>
        /// The SubscriptionCancellationMethod instance, wrapping the provided CancellationMethod value.
        /// </returns>
        public static SubscriptionCancellationMethod FromCancellationMethod(CancellationMethod cancellationMethod)
        {
            return new CancellationMethodCase().Set(cancellationMethod);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CancellationMethod, T> cancellationMethod);

        [JsonConverter(typeof(UnionTypeCaseConverter<CancellationMethodCase, CancellationMethod>))]
        private sealed class CancellationMethodCase : SubscriptionCancellationMethod, ICaseValue<CancellationMethodCase, CancellationMethod>
        {
            public CancellationMethod _value;

            public override T Match<T>(Func<CancellationMethod, T> cancellationMethod)
            {
                return cancellationMethod(_value);
            }

            public CancellationMethodCase Set(CancellationMethod value)
            {
                _value = value;
                return this;
            }

            public CancellationMethod Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }
    }
}