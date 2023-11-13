using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CouponCompoundingStrategy>),
        new Type[] {
            typeof(Case0)
        },
        false
    )]
    public abstract class CouponCompoundingStrategy
    {
        /// <summary>
        /// This is CouponCompoundingStrategyCase0 case.
        /// </summary>
        /// <returns>
        /// The CouponCompoundingStrategy instance, wrapping the provided CouponCompoundingStrategyCase0 value.
        /// </returns>
        public static CouponCompoundingStrategy FromCouponCompoundingStrategyCase0(CouponCompoundingStrategyCase0 couponCompoundingStrategyCase0)
        {
            return new Case0().Set(couponCompoundingStrategyCase0);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CouponCompoundingStrategyCase0, T> couponCompoundingStrategyCase0);

        [JsonConverter(typeof(UnionTypeCaseConverter<Case0, CouponCompoundingStrategyCase0>))]
        private sealed class Case0 : CouponCompoundingStrategy, ICaseValue<Case0, CouponCompoundingStrategyCase0>
        {
            public CouponCompoundingStrategyCase0 _value;

            public override T Match<T>(Func<CouponCompoundingStrategyCase0, T> couponCompoundingStrategyCase0)
            {
                return couponCompoundingStrategyCase0(_value);
            }

            public Case0 Set(CouponCompoundingStrategyCase0 value)
            {
                _value = value;
                return this;
            }

            public CouponCompoundingStrategyCase0 Get()
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