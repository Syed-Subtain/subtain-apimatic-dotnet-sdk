// <copyright file="CreateSubscriptionGroup2.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateSubscriptionGroup2>),
        new Type[] {
            typeof(GroupSettingsCase),
            typeof(BooleanCase)
        },
        true
    )]
    public abstract class CreateSubscriptionGroup2
    {
        /// <summary>
        /// This is Group Settings case.
        /// </summary>
        /// <returns>
        /// The CreateSubscriptionGroup2 instance, wrapping the provided GroupSettings value.
        /// </returns>
        public static CreateSubscriptionGroup2 FromGroupSettings(GroupSettings groupSettings)
        {
            return new GroupSettingsCase().Set(groupSettings);
        }

        /// <summary>
        /// This is Boolean case.
        /// </summary>
        /// <returns>
        /// The CreateSubscriptionGroup2 instance, wrapping the provided bool value.
        /// </returns>
        public static CreateSubscriptionGroup2 FromBoolean(bool boolean)
        {
            return new BooleanCase().Set(boolean);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GroupSettings, T> groupSettings, Func<bool, T> boolean);

        [JsonConverter(typeof(UnionTypeCaseConverter<GroupSettingsCase, GroupSettings>))]
        private sealed class GroupSettingsCase : CreateSubscriptionGroup2, ICaseValue<GroupSettingsCase, GroupSettings>
        {
            public GroupSettings _value;

            public override T Match<T>(Func<GroupSettings, T> groupSettings, Func<bool, T> boolean)
            {
                return groupSettings(_value);
            }

            public GroupSettingsCase Set(GroupSettings value)
            {
                _value = value;
                return this;
            }

            public GroupSettings Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BooleanCase, bool>), JTokenType.Boolean)]
        private sealed class BooleanCase : CreateSubscriptionGroup2, ICaseValue<BooleanCase, bool>
        {
            public bool _value;

            public override T Match<T>(Func<GroupSettings, T> groupSettings, Func<bool, T> boolean)
            {
                return boolean(_value);
            }

            public BooleanCase Set(bool value)
            {
                _value = value;
                return this;
            }

            public bool Get()
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