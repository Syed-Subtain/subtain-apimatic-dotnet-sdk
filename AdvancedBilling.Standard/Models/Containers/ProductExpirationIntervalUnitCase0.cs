// <copyright file="ProductExpirationIntervalUnitCase0.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ProductExpirationIntervalUnitCase0>),
        new Type[] {
            typeof(ExtendedIntervalUnitCase)
        },
        true
    )]
    public abstract class ProductExpirationIntervalUnitCase0
    {
        /// <summary>
        /// This is Extended Interval Unit case.
        /// </summary>
        /// <returns>
        /// The ProductExpirationIntervalUnitCase0 instance, wrapping the provided ExtendedIntervalUnit value.
        /// </returns>
        public static ProductExpirationIntervalUnitCase0 FromExtendedIntervalUnit(ExtendedIntervalUnit extendedIntervalUnit)
        {
            return new ExtendedIntervalUnitCase().Set(extendedIntervalUnit);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ExtendedIntervalUnit, T> extendedIntervalUnit);

        [JsonConverter(typeof(UnionTypeCaseConverter<ExtendedIntervalUnitCase, ExtendedIntervalUnit>))]
        private sealed class ExtendedIntervalUnitCase : ProductExpirationIntervalUnitCase0, ICaseValue<ExtendedIntervalUnitCase, ExtendedIntervalUnit>
        {
            public ExtendedIntervalUnit _value;

            public override T Match<T>(Func<ExtendedIntervalUnit, T> extendedIntervalUnit)
            {
                return extendedIntervalUnit(_value);
            }

            public ExtendedIntervalUnitCase Set(ExtendedIntervalUnit value)
            {
                _value = value;
                return this;
            }

            public ExtendedIntervalUnit Get()
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