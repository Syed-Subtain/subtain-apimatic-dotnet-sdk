// <copyright file="ProductTrialIntervalUnit.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ProductTrialIntervalUnit>),
        new Type[] {
            typeof(Case0)
        },
        true
    )]
    public abstract class ProductTrialIntervalUnit
    {
        /// <summary>
        /// This is ProductTrialIntervalUnitCase0 case.
        /// </summary>
        /// <returns>
        /// The ProductTrialIntervalUnit instance, wrapping the provided ProductTrialIntervalUnitCase0 value.
        /// </returns>
        public static ProductTrialIntervalUnit FromProductTrialIntervalUnitCase0(ProductTrialIntervalUnitCase0 productTrialIntervalUnitCase0)
        {
            return new Case0().Set(productTrialIntervalUnitCase0);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ProductTrialIntervalUnitCase0, T> productTrialIntervalUnitCase0);

        [JsonConverter(typeof(UnionTypeCaseConverter<Case0, ProductTrialIntervalUnitCase0>))]
        private sealed class Case0 : ProductTrialIntervalUnit, ICaseValue<Case0, ProductTrialIntervalUnitCase0>
        {
            public ProductTrialIntervalUnitCase0 _value;

            public override T Match<T>(Func<ProductTrialIntervalUnitCase0, T> productTrialIntervalUnitCase0)
            {
                return productTrialIntervalUnitCase0(_value);
            }

            public Case0 Set(ProductTrialIntervalUnitCase0 value)
            {
                _value = value;
                return this;
            }

            public ProductTrialIntervalUnitCase0 Get()
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