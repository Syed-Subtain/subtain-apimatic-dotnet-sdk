// <copyright file="ListSubscriptionComponentsForSiteInputDirection.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ListSubscriptionComponentsForSiteInputDirection>),
        new Type[] {
            typeof(SortingDirectionCase)
        },
        true
    )]
    public abstract class ListSubscriptionComponentsForSiteInputDirection
    {
        /// <summary>
        /// This is Sorting direction case.
        /// </summary>
        /// <returns>
        /// The ListSubscriptionComponentsForSiteInputDirection instance, wrapping the provided SortingDirection value.
        /// </returns>
        public static ListSubscriptionComponentsForSiteInputDirection FromSortingDirection(SortingDirection sortingDirection)
        {
            return new SortingDirectionCase().Set(sortingDirection);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<SortingDirection, T> sortingDirection);

        [JsonConverter(typeof(UnionTypeCaseConverter<SortingDirectionCase, SortingDirection>))]
        private sealed class SortingDirectionCase : ListSubscriptionComponentsForSiteInputDirection, ICaseValue<SortingDirectionCase, SortingDirection>
        {
            public SortingDirection _value;

            public override T Match<T>(Func<SortingDirection, T> sortingDirection)
            {
                return sortingDirection(_value);
            }

            public SortingDirectionCase Set(SortingDirection value)
            {
                _value = value;
                return this;
            }

            public SortingDirection Get()
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