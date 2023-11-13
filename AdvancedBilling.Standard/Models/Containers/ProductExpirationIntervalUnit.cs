using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ProductExpirationIntervalUnit>),
        new Type[] {
            typeof(Case0)
        },
        true
    )]
    public abstract class ProductExpirationIntervalUnit
    {
        /// <summary>
        /// This is ProductExpirationIntervalUnitCase0 case.
        /// </summary>
        /// <returns>
        /// The ProductExpirationIntervalUnit instance, wrapping the provided ProductExpirationIntervalUnitCase0 value.
        /// </returns>
        public static ProductExpirationIntervalUnit FromProductExpirationIntervalUnitCase0(ProductExpirationIntervalUnitCase0 productExpirationIntervalUnitCase0)
        {
            return new Case0().Set(productExpirationIntervalUnitCase0);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ProductExpirationIntervalUnitCase0, T> productExpirationIntervalUnitCase0);

        [JsonConverter(typeof(UnionTypeCaseConverter<Case0, ProductExpirationIntervalUnitCase0>))]
        private sealed class Case0 : ProductExpirationIntervalUnit, ICaseValue<Case0, ProductExpirationIntervalUnitCase0>
        {
            public ProductExpirationIntervalUnitCase0 _value;

            public override T Match<T>(Func<ProductExpirationIntervalUnitCase0, T> productExpirationIntervalUnitCase0)
            {
                return productExpirationIntervalUnitCase0(_value);
            }

            public Case0 Set(ProductExpirationIntervalUnitCase0 value)
            {
                _value = value;
                return this;
            }

            public ProductExpirationIntervalUnitCase0 Get()
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