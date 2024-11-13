// <copyright file="CouponCompoundingStrategyCase0.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CouponCompoundingStrategyCase0>),
        new Type[] {
            typeof(CompoundingStrategyCase)
        },
        true
    )]
    public abstract class CouponCompoundingStrategyCase0
    {
        /// <summary>
        /// This is Compounding Strategy case.
        /// </summary>
        /// <returns>
        /// The CouponCompoundingStrategyCase0 instance, wrapping the provided CompoundingStrategy value.
        /// </returns>
        public static CouponCompoundingStrategyCase0 FromCompoundingStrategy(CompoundingStrategy compoundingStrategy)
        {
            return new CompoundingStrategyCase().Set(compoundingStrategy);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CompoundingStrategy, T> compoundingStrategy);

        [JsonConverter(typeof(UnionTypeCaseConverter<CompoundingStrategyCase, CompoundingStrategy>))]
        private sealed class CompoundingStrategyCase : CouponCompoundingStrategyCase0, ICaseValue<CompoundingStrategyCase, CompoundingStrategy>
        {
            public CompoundingStrategy _value;

            public override T Match<T>(Func<CompoundingStrategy, T> compoundingStrategy)
            {
                return compoundingStrategy(_value);
            }

            public CompoundingStrategyCase Set(CompoundingStrategy value)
            {
                _value = value;
                return this;
            }

            public CompoundingStrategy Get()
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