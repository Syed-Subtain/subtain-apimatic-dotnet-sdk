using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<UpdateCouponBody>),
        new Type[] {
            typeof(CreateOrUpdateCouponCase)
        },
        true
    )]
    public abstract class UpdateCouponBody
    {
        /// <summary>
        /// This is Create or Update Coupon case.
        /// </summary>
        /// <returns>
        /// The UpdateCouponBody instance, wrapping the provided CreateOrUpdateCoupon value.
        /// </returns>
        public static UpdateCouponBody FromCreateOrUpdateCoupon(CreateOrUpdateCoupon createOrUpdateCoupon)
        {
            return new CreateOrUpdateCouponCase().Set(createOrUpdateCoupon);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CreateOrUpdateCoupon, T> createOrUpdateCoupon);

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateOrUpdateCouponCase, CreateOrUpdateCoupon>))]
        private sealed class CreateOrUpdateCouponCase : UpdateCouponBody, ICaseValue<CreateOrUpdateCouponCase, CreateOrUpdateCoupon>
        {
            public CreateOrUpdateCoupon _value;

            public override T Match<T>(Func<CreateOrUpdateCoupon, T> createOrUpdateCoupon)
            {
                return createOrUpdateCoupon(_value);
            }

            public CreateOrUpdateCouponCase Set(CreateOrUpdateCoupon value)
            {
                _value = value;
                return this;
            }

            public CreateOrUpdateCoupon Get()
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