using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateSubscriptionComponents>),
        new Type[] {
            typeof(CreateSubscriptionComponentCase)
        },
        true
    )]
    public abstract class CreateSubscriptionComponents
    {
        /// <summary>
        /// This is Create Subscription Component case.
        /// </summary>
        /// <returns>
        /// The CreateSubscriptionComponents instance, wrapping the provided CreateSubscriptionComponent value.
        /// </returns>
        public static CreateSubscriptionComponents FromCreateSubscriptionComponent(CreateSubscriptionComponent createSubscriptionComponent)
        {
            return new CreateSubscriptionComponentCase().Set(createSubscriptionComponent);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CreateSubscriptionComponent, T> createSubscriptionComponent);

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateSubscriptionComponentCase, CreateSubscriptionComponent>))]
        private sealed class CreateSubscriptionComponentCase : CreateSubscriptionComponents, ICaseValue<CreateSubscriptionComponentCase, CreateSubscriptionComponent>
        {
            public CreateSubscriptionComponent _value;

            public override T Match<T>(Func<CreateSubscriptionComponent, T> createSubscriptionComponent)
            {
                return createSubscriptionComponent(_value);
            }

            public CreateSubscriptionComponentCase Set(CreateSubscriptionComponent value)
            {
                _value = value;
                return this;
            }

            public CreateSubscriptionComponent Get()
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