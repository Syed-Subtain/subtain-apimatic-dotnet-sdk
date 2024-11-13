// <copyright file="SubscriptionPaymentCollectionMethod.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<SubscriptionPaymentCollectionMethod>),
        new Type[] {
            typeof(PaymentCollectionMethodCase)
        },
        true
    )]
    public abstract class SubscriptionPaymentCollectionMethod
    {
        /// <summary>
        /// This is Payment Collection Method case.
        /// </summary>
        /// <returns>
        /// The SubscriptionPaymentCollectionMethod instance, wrapping the provided PaymentCollectionMethod value.
        /// </returns>
        public static SubscriptionPaymentCollectionMethod FromPaymentCollectionMethod(PaymentCollectionMethod paymentCollectionMethod)
        {
            return new PaymentCollectionMethodCase().Set(paymentCollectionMethod);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<PaymentCollectionMethod, T> paymentCollectionMethod);

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentCollectionMethodCase, PaymentCollectionMethod>))]
        private sealed class PaymentCollectionMethodCase : SubscriptionPaymentCollectionMethod, ICaseValue<PaymentCollectionMethodCase, PaymentCollectionMethod>
        {
            public PaymentCollectionMethod _value;

            public override T Match<T>(Func<PaymentCollectionMethod, T> paymentCollectionMethod)
            {
                return paymentCollectionMethod(_value);
            }

            public PaymentCollectionMethodCase Set(PaymentCollectionMethod value)
            {
                _value = value;
                return this;
            }

            public PaymentCollectionMethod Get()
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