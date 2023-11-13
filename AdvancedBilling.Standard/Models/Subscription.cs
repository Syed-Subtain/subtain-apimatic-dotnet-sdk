// <copyright file="Subscription.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Subscription.
    /// </summary>
    public class Subscription
    {
        private string trialStartedAt;
        private string trialEndedAt;
        private string expiresAt;
        private string cancellationMessage;
        private SubscriptionCancellationMethod cancellationMethod;
        private bool? cancelAtEndOfPeriod;
        private string canceledAt;
        private string delayedCancelAt;
        private string couponCode;
        private string snapDay;
        private SubscriptionPaymentCollectionMethod paymentCollectionMethod;
        private SubscriptionGroup2 mGroup;
        private string paymentType;
        private string referralCode;
        private int? nextProductId;
        private string nextProductHandle;
        private int? couponUseCount;
        private int? couponUsesAllowed;
        private string reasonCode;
        private string automaticallyResumeAt;
        private int? offerId;
        private int? nextProductPricePointId;
        private int? netTerms;
        private int? storedCredentialTransactionId;
        private string reference;
        private string onHoldAt;
        private string dunningCommunicationDelayTimeZone;
        private bool? receivesInvoiceEmails;
        private string locale;
        private string scheduledCancellationAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "trial_started_at", false },
            { "trial_ended_at", false },
            { "expires_at", false },
            { "cancellation_message", false },
            { "cancellation_method", false },
            { "cancel_at_end_of_period", false },
            { "canceled_at", false },
            { "delayed_cancel_at", false },
            { "coupon_code", false },
            { "snap_day", false },
            { "payment_collection_method", false },
            { "group", false },
            { "payment_type", false },
            { "referral_code", false },
            { "next_product_id", false },
            { "next_product_handle", false },
            { "coupon_use_count", false },
            { "coupon_uses_allowed", false },
            { "reason_code", false },
            { "automatically_resume_at", false },
            { "offer_id", false },
            { "next_product_price_point_id", false },
            { "net_terms", false },
            { "stored_credential_transaction_id", false },
            { "reference", false },
            { "on_hold_at", false },
            { "dunning_communication_delay_time_zone", false },
            { "receives_invoice_emails", false },
            { "locale", false },
            { "scheduled_cancellation_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        public Subscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="state">state.</param>
        /// <param name="balanceInCents">balance_in_cents.</param>
        /// <param name="totalRevenueInCents">total_revenue_in_cents.</param>
        /// <param name="productPriceInCents">product_price_in_cents.</param>
        /// <param name="productVersionNumber">product_version_number.</param>
        /// <param name="currentPeriodEndsAt">current_period_ends_at.</param>
        /// <param name="nextAssessmentAt">next_assessment_at.</param>
        /// <param name="trialStartedAt">trial_started_at.</param>
        /// <param name="trialEndedAt">trial_ended_at.</param>
        /// <param name="activatedAt">activated_at.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="cancellationMessage">cancellation_message.</param>
        /// <param name="cancellationMethod">cancellation_method.</param>
        /// <param name="cancelAtEndOfPeriod">cancel_at_end_of_period.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="currentPeriodStartedAt">current_period_started_at.</param>
        /// <param name="previousState">previous_state.</param>
        /// <param name="signupPaymentId">signup_payment_id.</param>
        /// <param name="signupRevenue">signup_revenue.</param>
        /// <param name="delayedCancelAt">delayed_cancel_at.</param>
        /// <param name="couponCode">coupon_code.</param>
        /// <param name="snapDay">snap_day.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        /// <param name="customer">customer.</param>
        /// <param name="product">product.</param>
        /// <param name="creditCard">credit_card.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="bankAccount">bank_account.</param>
        /// <param name="paymentType">payment_type.</param>
        /// <param name="referralCode">referral_code.</param>
        /// <param name="nextProductId">next_product_id.</param>
        /// <param name="nextProductHandle">next_product_handle.</param>
        /// <param name="couponUseCount">coupon_use_count.</param>
        /// <param name="couponUsesAllowed">coupon_uses_allowed.</param>
        /// <param name="reasonCode">reason_code.</param>
        /// <param name="automaticallyResumeAt">automatically_resume_at.</param>
        /// <param name="couponCodes">coupon_codes.</param>
        /// <param name="offerId">offer_id.</param>
        /// <param name="payerId">payer_id.</param>
        /// <param name="currentBillingAmountInCents">current_billing_amount_in_cents.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="productPricePointType">product_price_point_type.</param>
        /// <param name="nextProductPricePointId">next_product_price_point_id.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="storedCredentialTransactionId">stored_credential_transaction_id.</param>
        /// <param name="reference">reference.</param>
        /// <param name="onHoldAt">on_hold_at.</param>
        /// <param name="prepaidDunning">prepaid_dunning.</param>
        /// <param name="coupons">coupons.</param>
        /// <param name="dunningCommunicationDelayEnabled">dunning_communication_delay_enabled.</param>
        /// <param name="dunningCommunicationDelayTimeZone">dunning_communication_delay_time_zone.</param>
        /// <param name="receivesInvoiceEmails">receives_invoice_emails.</param>
        /// <param name="locale">locale.</param>
        /// <param name="currency">currency.</param>
        /// <param name="scheduledCancellationAt">scheduled_cancellation_at.</param>
        /// <param name="creditBalanceInCents">credit_balance_in_cents.</param>
        /// <param name="prepaymentBalanceInCents">prepayment_balance_in_cents.</param>
        public Subscription(
            int? id = null,
            string state = null,
            int? balanceInCents = null,
            int? totalRevenueInCents = null,
            int? productPriceInCents = null,
            int? productVersionNumber = null,
            string currentPeriodEndsAt = null,
            string nextAssessmentAt = null,
            string trialStartedAt = null,
            string trialEndedAt = null,
            string activatedAt = null,
            string expiresAt = null,
            string createdAt = null,
            string updatedAt = null,
            string cancellationMessage = null,
            SubscriptionCancellationMethod cancellationMethod = null,
            bool? cancelAtEndOfPeriod = null,
            string canceledAt = null,
            string currentPeriodStartedAt = null,
            string previousState = null,
            int? signupPaymentId = null,
            string signupRevenue = null,
            string delayedCancelAt = null,
            string couponCode = null,
            string snapDay = null,
            SubscriptionPaymentCollectionMethod paymentCollectionMethod = null,
            Models.Customer customer = null,
            Models.Product product = null,
            Models.PaymentProfile creditCard = null,
            SubscriptionGroup2 mGroup = null,
            Models.SubscriptionBankAccount bankAccount = null,
            string paymentType = null,
            string referralCode = null,
            int? nextProductId = null,
            string nextProductHandle = null,
            int? couponUseCount = null,
            int? couponUsesAllowed = null,
            string reasonCode = null,
            string automaticallyResumeAt = null,
            List<string> couponCodes = null,
            int? offerId = null,
            int? payerId = null,
            int? currentBillingAmountInCents = null,
            int? productPricePointId = null,
            string productPricePointType = null,
            int? nextProductPricePointId = null,
            int? netTerms = null,
            int? storedCredentialTransactionId = null,
            string reference = null,
            string onHoldAt = null,
            bool? prepaidDunning = null,
            List<Models.SubscriptionIncludedCoupon> coupons = null,
            bool? dunningCommunicationDelayEnabled = false,
            string dunningCommunicationDelayTimeZone = null,
            bool? receivesInvoiceEmails = null,
            string locale = null,
            string currency = null,
            string scheduledCancellationAt = null,
            int? creditBalanceInCents = null,
            int? prepaymentBalanceInCents = null)
        {
            this.Id = id;
            this.State = state;
            this.BalanceInCents = balanceInCents;
            this.TotalRevenueInCents = totalRevenueInCents;
            this.ProductPriceInCents = productPriceInCents;
            this.ProductVersionNumber = productVersionNumber;
            this.CurrentPeriodEndsAt = currentPeriodEndsAt;
            this.NextAssessmentAt = nextAssessmentAt;
            if (trialStartedAt != null)
            {
                this.TrialStartedAt = trialStartedAt;
            }

            if (trialEndedAt != null)
            {
                this.TrialEndedAt = trialEndedAt;
            }

            this.ActivatedAt = activatedAt;
            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }

            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            if (cancellationMessage != null)
            {
                this.CancellationMessage = cancellationMessage;
            }

            if (cancellationMethod != null)
            {
                this.CancellationMethod = cancellationMethod;
            }

            if (cancelAtEndOfPeriod != null)
            {
                this.CancelAtEndOfPeriod = cancelAtEndOfPeriod;
            }

            if (canceledAt != null)
            {
                this.CanceledAt = canceledAt;
            }

            this.CurrentPeriodStartedAt = currentPeriodStartedAt;
            this.PreviousState = previousState;
            this.SignupPaymentId = signupPaymentId;
            this.SignupRevenue = signupRevenue;
            if (delayedCancelAt != null)
            {
                this.DelayedCancelAt = delayedCancelAt;
            }

            if (couponCode != null)
            {
                this.CouponCode = couponCode;
            }

            if (snapDay != null)
            {
                this.SnapDay = snapDay;
            }

            if (paymentCollectionMethod != null)
            {
                this.PaymentCollectionMethod = paymentCollectionMethod;
            }

            this.Customer = customer;
            this.Product = product;
            this.CreditCard = creditCard;
            if (mGroup != null)
            {
                this.MGroup = mGroup;
            }

            this.BankAccount = bankAccount;
            if (paymentType != null)
            {
                this.PaymentType = paymentType;
            }

            if (referralCode != null)
            {
                this.ReferralCode = referralCode;
            }

            if (nextProductId != null)
            {
                this.NextProductId = nextProductId;
            }

            if (nextProductHandle != null)
            {
                this.NextProductHandle = nextProductHandle;
            }

            if (couponUseCount != null)
            {
                this.CouponUseCount = couponUseCount;
            }

            if (couponUsesAllowed != null)
            {
                this.CouponUsesAllowed = couponUsesAllowed;
            }

            if (reasonCode != null)
            {
                this.ReasonCode = reasonCode;
            }

            if (automaticallyResumeAt != null)
            {
                this.AutomaticallyResumeAt = automaticallyResumeAt;
            }

            this.CouponCodes = couponCodes;
            if (offerId != null)
            {
                this.OfferId = offerId;
            }

            this.PayerId = payerId;
            this.CurrentBillingAmountInCents = currentBillingAmountInCents;
            this.ProductPricePointId = productPricePointId;
            this.ProductPricePointType = productPricePointType;
            if (nextProductPricePointId != null)
            {
                this.NextProductPricePointId = nextProductPricePointId;
            }

            if (netTerms != null)
            {
                this.NetTerms = netTerms;
            }

            if (storedCredentialTransactionId != null)
            {
                this.StoredCredentialTransactionId = storedCredentialTransactionId;
            }

            if (reference != null)
            {
                this.Reference = reference;
            }

            if (onHoldAt != null)
            {
                this.OnHoldAt = onHoldAt;
            }

            this.PrepaidDunning = prepaidDunning;
            this.Coupons = coupons;
            this.DunningCommunicationDelayEnabled = dunningCommunicationDelayEnabled;
            if (dunningCommunicationDelayTimeZone != null)
            {
                this.DunningCommunicationDelayTimeZone = dunningCommunicationDelayTimeZone;
            }

            if (receivesInvoiceEmails != null)
            {
                this.ReceivesInvoiceEmails = receivesInvoiceEmails;
            }

            if (locale != null)
            {
                this.Locale = locale;
            }

            this.Currency = currency;
            if (scheduledCancellationAt != null)
            {
                this.ScheduledCancellationAt = scheduledCancellationAt;
            }

            this.CreditBalanceInCents = creditBalanceInCents;
            this.PrepaymentBalanceInCents = prepaymentBalanceInCents;
        }

        /// <summary>
        /// The subscription unique id within Chargify.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The current state of the subscription. Please see the documentation for [Subscription States](https://help.chargify.com/subscriptions/subscription-states.html)
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gives the current outstanding subscription balance in the number of cents.
        /// </summary>
        [JsonProperty("balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? BalanceInCents { get; set; }

        /// <summary>
        /// Gives the total revenue from the subscription in the number of cents.
        /// </summary>
        [JsonProperty("total_revenue_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRevenueInCents { get; set; }

        /// <summary>
        /// (Added Nov 5 2013) The recurring amount of the product (and version),currently subscribed. NOTE: this may differ from the current price of,the product, if you’ve changed the price of the product but haven’t,moved this subscription to a newer version.
        /// </summary>
        [JsonProperty("product_price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPriceInCents { get; set; }

        /// <summary>
        /// The version of the product for the subscription. Note that this is a deprecated field kept for backwards-compatibility.
        /// </summary>
        [JsonProperty("product_version_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductVersionNumber { get; set; }

        /// <summary>
        /// Timestamp relating to the end of the current (recurring) period (i.e.,when the next regularly scheduled attempted charge will occur)
        /// </summary>
        [JsonProperty("current_period_ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPeriodEndsAt { get; set; }

        /// <summary>
        /// Timestamp that indicates when capture of payment will be tried or,retried. This value will usually track the current_period_ends_at, but,will diverge if a renewal payment fails and must be retried. In that,case, the current_period_ends_at will advance to the end of the next,period (time doesn’t stop because a payment was missed) but the,next_assessment_at will be scheduled for the auto-retry time (i.e. 24,hours in the future, in some cases)
        /// </summary>
        [JsonProperty("next_assessment_at", NullValueHandling = NullValueHandling.Ignore)]
        public string NextAssessmentAt { get; set; }

        /// <summary>
        /// Timestamp for when the trial period (if any) began
        /// </summary>
        [JsonProperty("trial_started_at")]
        public string TrialStartedAt
        {
            get
            {
                return this.trialStartedAt;
            }

            set
            {
                this.shouldSerialize["trial_started_at"] = true;
                this.trialStartedAt = value;
            }
        }

        /// <summary>
        /// Timestamp for when the trial period (if any) ended
        /// </summary>
        [JsonProperty("trial_ended_at")]
        public string TrialEndedAt
        {
            get
            {
                return this.trialEndedAt;
            }

            set
            {
                this.shouldSerialize["trial_ended_at"] = true;
                this.trialEndedAt = value;
            }
        }

        /// <summary>
        /// Timestamp for when the subscription began (i.e. when it came out of trial, or when it began in the case of no trial)
        /// </summary>
        [JsonProperty("activated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivatedAt { get; set; }

        /// <summary>
        /// Timestamp giving the expiration date of this subscription (if any)
        /// </summary>
        [JsonProperty("expires_at")]
        public string ExpiresAt
        {
            get
            {
                return this.expiresAt;
            }

            set
            {
                this.shouldSerialize["expires_at"] = true;
                this.expiresAt = value;
            }
        }

        /// <summary>
        /// The creation date for this subscription
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The date of last update for this subscription
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Seller-provided reason for, or note about, the cancellation.
        /// </summary>
        [JsonProperty("cancellation_message")]
        public string CancellationMessage
        {
            get
            {
                return this.cancellationMessage;
            }

            set
            {
                this.shouldSerialize["cancellation_message"] = true;
                this.cancellationMessage = value;
            }
        }

        /// <summary>
        /// The process used to cancel the subscription, if the subscription has been canceled. It is nil if the subscription's state is not canceled.
        /// </summary>
        [JsonProperty("cancellation_method")]
        public SubscriptionCancellationMethod CancellationMethod
        {
            get
            {
                return this.cancellationMethod;
            }

            set
            {
                this.shouldSerialize["cancellation_method"] = true;
                this.cancellationMethod = value;
            }
        }

        /// <summary>
        /// Whether or not the subscription will (or has) canceled at the end of the period.
        /// </summary>
        [JsonProperty("cancel_at_end_of_period")]
        public bool? CancelAtEndOfPeriod
        {
            get
            {
                return this.cancelAtEndOfPeriod;
            }

            set
            {
                this.shouldSerialize["cancel_at_end_of_period"] = true;
                this.cancelAtEndOfPeriod = value;
            }
        }

        /// <summary>
        /// The timestamp of the most recent cancellation
        /// </summary>
        [JsonProperty("canceled_at")]
        public string CanceledAt
        {
            get
            {
                return this.canceledAt;
            }

            set
            {
                this.shouldSerialize["canceled_at"] = true;
                this.canceledAt = value;
            }
        }

        /// <summary>
        /// Timestamp relating to the start of the current (recurring) period
        /// </summary>
        [JsonProperty("current_period_started_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPeriodStartedAt { get; set; }

        /// <summary>
        /// Only valid for webhook payloads The previous state for webhooks that have indicated a change in state. For normal API calls, this will always be the same as the state (current state)
        /// </summary>
        [JsonProperty("previous_state", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousState { get; set; }

        /// <summary>
        /// The ID of the transaction that generated the revenue
        /// </summary>
        [JsonProperty("signup_payment_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SignupPaymentId { get; set; }

        /// <summary>
        /// The revenue, formatted as a string of decimal separated dollars and,cents, from the subscription signup ($50.00 would be formatted as,50.00)
        /// </summary>
        [JsonProperty("signup_revenue", NullValueHandling = NullValueHandling.Ignore)]
        public string SignupRevenue { get; set; }

        /// <summary>
        /// Timestamp for when the subscription is currently set to cancel.
        /// </summary>
        [JsonProperty("delayed_cancel_at")]
        public string DelayedCancelAt
        {
            get
            {
                return this.delayedCancelAt;
            }

            set
            {
                this.shouldSerialize["delayed_cancel_at"] = true;
                this.delayedCancelAt = value;
            }
        }

        /// <summary>
        /// (deprecated) The coupon code of the single coupon currently applied to the subscription. See coupon_codes instead as subscriptions can now have more than one coupon.
        /// </summary>
        [JsonProperty("coupon_code")]
        public string CouponCode
        {
            get
            {
                return this.couponCode;
            }

            set
            {
                this.shouldSerialize["coupon_code"] = true;
                this.couponCode = value;
            }
        }

        /// <summary>
        /// The day of the month that the subscription will charge according to calendar billing rules, if used.
        /// </summary>
        [JsonProperty("snap_day")]
        public string SnapDay
        {
            get
            {
                return this.snapDay;
            }

            set
            {
                this.shouldSerialize["snap_day"] = true;
                this.snapDay = value;
            }
        }

        /// <summary>
        /// Gets or sets PaymentCollectionMethod.
        /// </summary>
        [JsonProperty("payment_collection_method")]
        public SubscriptionPaymentCollectionMethod PaymentCollectionMethod
        {
            get
            {
                return this.paymentCollectionMethod;
            }

            set
            {
                this.shouldSerialize["payment_collection_method"] = true;
                this.paymentCollectionMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets Product.
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Product Product { get; set; }

        /// <summary>
        /// Gets or sets CreditCard.
        /// </summary>
        [JsonProperty("credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentProfile CreditCard { get; set; }

        /// <summary>
        /// Gets or sets MGroup.
        /// </summary>
        [JsonProperty("group")]
        public SubscriptionGroup2 MGroup
        {
            get
            {
                return this.mGroup;
            }

            set
            {
                this.shouldSerialize["group"] = true;
                this.mGroup = value;
            }
        }

        /// <summary>
        /// Gets or sets BankAccount.
        /// </summary>
        [JsonProperty("bank_account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionBankAccount BankAccount { get; set; }

        /// <summary>
        /// The payment profile type for the active profile on file.
        /// </summary>
        [JsonProperty("payment_type")]
        public string PaymentType
        {
            get
            {
                return this.paymentType;
            }

            set
            {
                this.shouldSerialize["payment_type"] = true;
                this.paymentType = value;
            }
        }

        /// <summary>
        /// The subscription's unique code that can be given to referrals.
        /// </summary>
        [JsonProperty("referral_code")]
        public string ReferralCode
        {
            get
            {
                return this.referralCode;
            }

            set
            {
                this.shouldSerialize["referral_code"] = true;
                this.referralCode = value;
            }
        }

        /// <summary>
        /// If a delayed product change is scheduled, the ID of the product that the subscription will be changed to at the next renewal.
        /// </summary>
        [JsonProperty("next_product_id")]
        public int? NextProductId
        {
            get
            {
                return this.nextProductId;
            }

            set
            {
                this.shouldSerialize["next_product_id"] = true;
                this.nextProductId = value;
            }
        }

        /// <summary>
        /// If a delayed product change is scheduled, the handle of the product that the subscription will be changed to at the next renewal.
        /// </summary>
        [JsonProperty("next_product_handle")]
        public string NextProductHandle
        {
            get
            {
                return this.nextProductHandle;
            }

            set
            {
                this.shouldSerialize["next_product_handle"] = true;
                this.nextProductHandle = value;
            }
        }

        /// <summary>
        /// (deprecated) How many times the subscription's single coupon has been used. This field has no replacement for multiple coupons.
        /// </summary>
        [JsonProperty("coupon_use_count")]
        public int? CouponUseCount
        {
            get
            {
                return this.couponUseCount;
            }

            set
            {
                this.shouldSerialize["coupon_use_count"] = true;
                this.couponUseCount = value;
            }
        }

        /// <summary>
        /// (deprecated) How many times the subscription's single coupon may be used. This field has no replacement for multiple coupons.
        /// </summary>
        [JsonProperty("coupon_uses_allowed")]
        public int? CouponUsesAllowed
        {
            get
            {
                return this.couponUsesAllowed;
            }

            set
            {
                this.shouldSerialize["coupon_uses_allowed"] = true;
                this.couponUsesAllowed = value;
            }
        }

        /// <summary>
        /// If the subscription is canceled, this is their churn code.
        /// </summary>
        [JsonProperty("reason_code")]
        public string ReasonCode
        {
            get
            {
                return this.reasonCode;
            }

            set
            {
                this.shouldSerialize["reason_code"] = true;
                this.reasonCode = value;
            }
        }

        /// <summary>
        /// The date the subscription is scheduled to automatically resume from the on_hold state.
        /// </summary>
        [JsonProperty("automatically_resume_at")]
        public string AutomaticallyResumeAt
        {
            get
            {
                return this.automaticallyResumeAt;
            }

            set
            {
                this.shouldSerialize["automatically_resume_at"] = true;
                this.automaticallyResumeAt = value;
            }
        }

        /// <summary>
        /// An array for all the coupons attached to the subscription.
        /// </summary>
        [JsonProperty("coupon_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// The ID of the offer associated with the subscription.
        /// </summary>
        [JsonProperty("offer_id")]
        public int? OfferId
        {
            get
            {
                return this.offerId;
            }

            set
            {
                this.shouldSerialize["offer_id"] = true;
                this.offerId = value;
            }
        }

        /// <summary>
        /// On Relationship Invoicing, the ID of the individual paying for the subscription. Defaults to the Customer ID unless the 'Customer Hierarchies & WhoPays' feature is enabled.
        /// </summary>
        [JsonProperty("payer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// The balance in cents plus the estimated renewal amount in cents.
        /// </summary>
        [JsonProperty("current_billing_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentBillingAmountInCents { get; set; }

        /// <summary>
        /// The product price point currently subscribed to.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// One of the following: custom, default, catalog.
        /// </summary>
        [JsonProperty("product_price_point_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointType { get; set; }

        /// <summary>
        /// If a delayed product change is scheduled, the ID of the product price point that the subscription will be changed to at the next renewal.
        /// </summary>
        [JsonProperty("next_product_price_point_id")]
        public int? NextProductPricePointId
        {
            get
            {
                return this.nextProductPricePointId;
            }

            set
            {
                this.shouldSerialize["next_product_price_point_id"] = true;
                this.nextProductPricePointId = value;
            }
        }

        /// <summary>
        /// On Relationship Invoicing, the number of days before a renewal invoice is due.
        /// </summary>
        [JsonProperty("net_terms")]
        public int? NetTerms
        {
            get
            {
                return this.netTerms;
            }

            set
            {
                this.shouldSerialize["net_terms"] = true;
                this.netTerms = value;
            }
        }

        /// <summary>
        /// For European sites subject to PSD2 and using 3D Secure, this can be used to reference a previous transaction for the customer. This will ensure the card will be charged successfully at renewal.
        /// </summary>
        [JsonProperty("stored_credential_transaction_id")]
        public int? StoredCredentialTransactionId
        {
            get
            {
                return this.storedCredentialTransactionId;
            }

            set
            {
                this.shouldSerialize["stored_credential_transaction_id"] = true;
                this.storedCredentialTransactionId = value;
            }
        }

        /// <summary>
        /// The reference value (provided by your app) for the subscription itelf.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference
        {
            get
            {
                return this.reference;
            }

            set
            {
                this.shouldSerialize["reference"] = true;
                this.reference = value;
            }
        }

        /// <summary>
        /// The timestamp of the most recent on hold action.
        /// </summary>
        [JsonProperty("on_hold_at")]
        public string OnHoldAt
        {
            get
            {
                return this.onHoldAt;
            }

            set
            {
                this.shouldSerialize["on_hold_at"] = true;
                this.onHoldAt = value;
            }
        }

        /// <summary>
        /// Boolean representing whether the subscription is prepaid and currently in dunning. Only returned for Relationship Invoicing sites with the feature enabled
        /// </summary>
        [JsonProperty("prepaid_dunning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrepaidDunning { get; set; }

        /// <summary>
        /// Additional coupon data. To use this data you also have to include the following param in the request`include[]=coupons`.
        /// Only in Read Subscription Endpoint.
        /// </summary>
        [JsonProperty("coupons", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionIncludedCoupon> Coupons { get; set; }

        /// <summary>
        /// Enable Communication Delay feature, making sure no communication (email or SMS) is sent to the Customer between 9PM and 8AM in time zone set by the `dunning_communication_delay_time_zone` attribute.
        /// </summary>
        [JsonProperty("dunning_communication_delay_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DunningCommunicationDelayEnabled { get; set; }

        /// <summary>
        /// Time zone for the Dunning Communication Delay feature.
        /// </summary>
        [JsonProperty("dunning_communication_delay_time_zone")]
        public string DunningCommunicationDelayTimeZone
        {
            get
            {
                return this.dunningCommunicationDelayTimeZone;
            }

            set
            {
                this.shouldSerialize["dunning_communication_delay_time_zone"] = true;
                this.dunningCommunicationDelayTimeZone = value;
            }
        }

        /// <summary>
        /// Gets or sets ReceivesInvoiceEmails.
        /// </summary>
        [JsonProperty("receives_invoice_emails")]
        public bool? ReceivesInvoiceEmails
        {
            get
            {
                return this.receivesInvoiceEmails;
            }

            set
            {
                this.shouldSerialize["receives_invoice_emails"] = true;
                this.receivesInvoiceEmails = value;
            }
        }

        /// <summary>
        /// Gets or sets Locale.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale
        {
            get
            {
                return this.locale;
            }

            set
            {
                this.shouldSerialize["locale"] = true;
                this.locale = value;
            }
        }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets ScheduledCancellationAt.
        /// </summary>
        [JsonProperty("scheduled_cancellation_at")]
        public string ScheduledCancellationAt
        {
            get
            {
                return this.scheduledCancellationAt;
            }

            set
            {
                this.shouldSerialize["scheduled_cancellation_at"] = true;
                this.scheduledCancellationAt = value;
            }
        }

        /// <summary>
        /// Gets or sets CreditBalanceInCents.
        /// </summary>
        [JsonProperty("credit_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreditBalanceInCents { get; set; }

        /// <summary>
        /// Gets or sets PrepaymentBalanceInCents.
        /// </summary>
        [JsonProperty("prepayment_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrepaymentBalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Subscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrialStartedAt()
        {
            this.shouldSerialize["trial_started_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrialEndedAt()
        {
            this.shouldSerialize["trial_ended_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCancellationMessage()
        {
            this.shouldSerialize["cancellation_message"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCancellationMethod()
        {
            this.shouldSerialize["cancellation_method"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCancelAtEndOfPeriod()
        {
            this.shouldSerialize["cancel_at_end_of_period"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCanceledAt()
        {
            this.shouldSerialize["canceled_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelayedCancelAt()
        {
            this.shouldSerialize["delayed_cancel_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCouponCode()
        {
            this.shouldSerialize["coupon_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSnapDay()
        {
            this.shouldSerialize["snap_day"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentCollectionMethod()
        {
            this.shouldSerialize["payment_collection_method"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGroup()
        {
            this.shouldSerialize["group"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentType()
        {
            this.shouldSerialize["payment_type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReferralCode()
        {
            this.shouldSerialize["referral_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNextProductId()
        {
            this.shouldSerialize["next_product_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNextProductHandle()
        {
            this.shouldSerialize["next_product_handle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCouponUseCount()
        {
            this.shouldSerialize["coupon_use_count"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCouponUsesAllowed()
        {
            this.shouldSerialize["coupon_uses_allowed"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReasonCode()
        {
            this.shouldSerialize["reason_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAutomaticallyResumeAt()
        {
            this.shouldSerialize["automatically_resume_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOfferId()
        {
            this.shouldSerialize["offer_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNextProductPricePointId()
        {
            this.shouldSerialize["next_product_price_point_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetTerms()
        {
            this.shouldSerialize["net_terms"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStoredCredentialTransactionId()
        {
            this.shouldSerialize["stored_credential_transaction_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReference()
        {
            this.shouldSerialize["reference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOnHoldAt()
        {
            this.shouldSerialize["on_hold_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDunningCommunicationDelayTimeZone()
        {
            this.shouldSerialize["dunning_communication_delay_time_zone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReceivesInvoiceEmails()
        {
            this.shouldSerialize["receives_invoice_emails"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocale()
        {
            this.shouldSerialize["locale"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetScheduledCancellationAt()
        {
            this.shouldSerialize["scheduled_cancellation_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrialStartedAt()
        {
            return this.shouldSerialize["trial_started_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrialEndedAt()
        {
            return this.shouldSerialize["trial_ended_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return this.shouldSerialize["expires_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCancellationMessage()
        {
            return this.shouldSerialize["cancellation_message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCancellationMethod()
        {
            return this.shouldSerialize["cancellation_method"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCancelAtEndOfPeriod()
        {
            return this.shouldSerialize["cancel_at_end_of_period"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCanceledAt()
        {
            return this.shouldSerialize["canceled_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelayedCancelAt()
        {
            return this.shouldSerialize["delayed_cancel_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCouponCode()
        {
            return this.shouldSerialize["coupon_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSnapDay()
        {
            return this.shouldSerialize["snap_day"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentCollectionMethod()
        {
            return this.shouldSerialize["payment_collection_method"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGroup()
        {
            return this.shouldSerialize["group"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentType()
        {
            return this.shouldSerialize["payment_type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReferralCode()
        {
            return this.shouldSerialize["referral_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextProductId()
        {
            return this.shouldSerialize["next_product_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextProductHandle()
        {
            return this.shouldSerialize["next_product_handle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCouponUseCount()
        {
            return this.shouldSerialize["coupon_use_count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCouponUsesAllowed()
        {
            return this.shouldSerialize["coupon_uses_allowed"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReasonCode()
        {
            return this.shouldSerialize["reason_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutomaticallyResumeAt()
        {
            return this.shouldSerialize["automatically_resume_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOfferId()
        {
            return this.shouldSerialize["offer_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextProductPricePointId()
        {
            return this.shouldSerialize["next_product_price_point_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetTerms()
        {
            return this.shouldSerialize["net_terms"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStoredCredentialTransactionId()
        {
            return this.shouldSerialize["stored_credential_transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReference()
        {
            return this.shouldSerialize["reference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOnHoldAt()
        {
            return this.shouldSerialize["on_hold_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDunningCommunicationDelayTimeZone()
        {
            return this.shouldSerialize["dunning_communication_delay_time_zone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReceivesInvoiceEmails()
        {
            return this.shouldSerialize["receives_invoice_emails"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocale()
        {
            return this.shouldSerialize["locale"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeScheduledCancellationAt()
        {
            return this.shouldSerialize["scheduled_cancellation_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Subscription other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.BalanceInCents == null && other.BalanceInCents == null) || (this.BalanceInCents?.Equals(other.BalanceInCents) == true)) &&
                ((this.TotalRevenueInCents == null && other.TotalRevenueInCents == null) || (this.TotalRevenueInCents?.Equals(other.TotalRevenueInCents) == true)) &&
                ((this.ProductPriceInCents == null && other.ProductPriceInCents == null) || (this.ProductPriceInCents?.Equals(other.ProductPriceInCents) == true)) &&
                ((this.ProductVersionNumber == null && other.ProductVersionNumber == null) || (this.ProductVersionNumber?.Equals(other.ProductVersionNumber) == true)) &&
                ((this.CurrentPeriodEndsAt == null && other.CurrentPeriodEndsAt == null) || (this.CurrentPeriodEndsAt?.Equals(other.CurrentPeriodEndsAt) == true)) &&
                ((this.NextAssessmentAt == null && other.NextAssessmentAt == null) || (this.NextAssessmentAt?.Equals(other.NextAssessmentAt) == true)) &&
                ((this.TrialStartedAt == null && other.TrialStartedAt == null) || (this.TrialStartedAt?.Equals(other.TrialStartedAt) == true)) &&
                ((this.TrialEndedAt == null && other.TrialEndedAt == null) || (this.TrialEndedAt?.Equals(other.TrialEndedAt) == true)) &&
                ((this.ActivatedAt == null && other.ActivatedAt == null) || (this.ActivatedAt?.Equals(other.ActivatedAt) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.CancellationMessage == null && other.CancellationMessage == null) || (this.CancellationMessage?.Equals(other.CancellationMessage) == true)) &&
                ((this.CancellationMethod == null && other.CancellationMethod == null) || (this.CancellationMethod?.Equals(other.CancellationMethod) == true)) &&
                ((this.CancelAtEndOfPeriod == null && other.CancelAtEndOfPeriod == null) || (this.CancelAtEndOfPeriod?.Equals(other.CancelAtEndOfPeriod) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.CurrentPeriodStartedAt == null && other.CurrentPeriodStartedAt == null) || (this.CurrentPeriodStartedAt?.Equals(other.CurrentPeriodStartedAt) == true)) &&
                ((this.PreviousState == null && other.PreviousState == null) || (this.PreviousState?.Equals(other.PreviousState) == true)) &&
                ((this.SignupPaymentId == null && other.SignupPaymentId == null) || (this.SignupPaymentId?.Equals(other.SignupPaymentId) == true)) &&
                ((this.SignupRevenue == null && other.SignupRevenue == null) || (this.SignupRevenue?.Equals(other.SignupRevenue) == true)) &&
                ((this.DelayedCancelAt == null && other.DelayedCancelAt == null) || (this.DelayedCancelAt?.Equals(other.DelayedCancelAt) == true)) &&
                ((this.CouponCode == null && other.CouponCode == null) || (this.CouponCode?.Equals(other.CouponCode) == true)) &&
                ((this.SnapDay == null && other.SnapDay == null) || (this.SnapDay?.Equals(other.SnapDay) == true)) &&
                ((this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null) || (this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true)) &&
                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true)) &&
                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true)) &&
                ((this.CreditCard == null && other.CreditCard == null) || (this.CreditCard?.Equals(other.CreditCard) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.BankAccount == null && other.BankAccount == null) || (this.BankAccount?.Equals(other.BankAccount) == true)) &&
                ((this.PaymentType == null && other.PaymentType == null) || (this.PaymentType?.Equals(other.PaymentType) == true)) &&
                ((this.ReferralCode == null && other.ReferralCode == null) || (this.ReferralCode?.Equals(other.ReferralCode) == true)) &&
                ((this.NextProductId == null && other.NextProductId == null) || (this.NextProductId?.Equals(other.NextProductId) == true)) &&
                ((this.NextProductHandle == null && other.NextProductHandle == null) || (this.NextProductHandle?.Equals(other.NextProductHandle) == true)) &&
                ((this.CouponUseCount == null && other.CouponUseCount == null) || (this.CouponUseCount?.Equals(other.CouponUseCount) == true)) &&
                ((this.CouponUsesAllowed == null && other.CouponUsesAllowed == null) || (this.CouponUsesAllowed?.Equals(other.CouponUsesAllowed) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                ((this.AutomaticallyResumeAt == null && other.AutomaticallyResumeAt == null) || (this.AutomaticallyResumeAt?.Equals(other.AutomaticallyResumeAt) == true)) &&
                ((this.CouponCodes == null && other.CouponCodes == null) || (this.CouponCodes?.Equals(other.CouponCodes) == true)) &&
                ((this.OfferId == null && other.OfferId == null) || (this.OfferId?.Equals(other.OfferId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.CurrentBillingAmountInCents == null && other.CurrentBillingAmountInCents == null) || (this.CurrentBillingAmountInCents?.Equals(other.CurrentBillingAmountInCents) == true)) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.ProductPricePointType == null && other.ProductPricePointType == null) || (this.ProductPricePointType?.Equals(other.ProductPricePointType) == true)) &&
                ((this.NextProductPricePointId == null && other.NextProductPricePointId == null) || (this.NextProductPricePointId?.Equals(other.NextProductPricePointId) == true)) &&
                ((this.NetTerms == null && other.NetTerms == null) || (this.NetTerms?.Equals(other.NetTerms) == true)) &&
                ((this.StoredCredentialTransactionId == null && other.StoredCredentialTransactionId == null) || (this.StoredCredentialTransactionId?.Equals(other.StoredCredentialTransactionId) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.OnHoldAt == null && other.OnHoldAt == null) || (this.OnHoldAt?.Equals(other.OnHoldAt) == true)) &&
                ((this.PrepaidDunning == null && other.PrepaidDunning == null) || (this.PrepaidDunning?.Equals(other.PrepaidDunning) == true)) &&
                ((this.Coupons == null && other.Coupons == null) || (this.Coupons?.Equals(other.Coupons) == true)) &&
                ((this.DunningCommunicationDelayEnabled == null && other.DunningCommunicationDelayEnabled == null) || (this.DunningCommunicationDelayEnabled?.Equals(other.DunningCommunicationDelayEnabled) == true)) &&
                ((this.DunningCommunicationDelayTimeZone == null && other.DunningCommunicationDelayTimeZone == null) || (this.DunningCommunicationDelayTimeZone?.Equals(other.DunningCommunicationDelayTimeZone) == true)) &&
                ((this.ReceivesInvoiceEmails == null && other.ReceivesInvoiceEmails == null) || (this.ReceivesInvoiceEmails?.Equals(other.ReceivesInvoiceEmails) == true)) &&
                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.ScheduledCancellationAt == null && other.ScheduledCancellationAt == null) || (this.ScheduledCancellationAt?.Equals(other.ScheduledCancellationAt) == true)) &&
                ((this.CreditBalanceInCents == null && other.CreditBalanceInCents == null) || (this.CreditBalanceInCents?.Equals(other.CreditBalanceInCents) == true)) &&
                ((this.PrepaymentBalanceInCents == null && other.PrepaymentBalanceInCents == null) || (this.PrepaymentBalanceInCents?.Equals(other.PrepaymentBalanceInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.BalanceInCents = {(this.BalanceInCents == null ? "null" : this.BalanceInCents.ToString())}");
            toStringOutput.Add($"this.TotalRevenueInCents = {(this.TotalRevenueInCents == null ? "null" : this.TotalRevenueInCents.ToString())}");
            toStringOutput.Add($"this.ProductPriceInCents = {(this.ProductPriceInCents == null ? "null" : this.ProductPriceInCents.ToString())}");
            toStringOutput.Add($"this.ProductVersionNumber = {(this.ProductVersionNumber == null ? "null" : this.ProductVersionNumber.ToString())}");
            toStringOutput.Add($"this.CurrentPeriodEndsAt = {(this.CurrentPeriodEndsAt == null ? "null" : this.CurrentPeriodEndsAt)}");
            toStringOutput.Add($"this.NextAssessmentAt = {(this.NextAssessmentAt == null ? "null" : this.NextAssessmentAt)}");
            toStringOutput.Add($"this.TrialStartedAt = {(this.TrialStartedAt == null ? "null" : this.TrialStartedAt)}");
            toStringOutput.Add($"this.TrialEndedAt = {(this.TrialEndedAt == null ? "null" : this.TrialEndedAt)}");
            toStringOutput.Add($"this.ActivatedAt = {(this.ActivatedAt == null ? "null" : this.ActivatedAt)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt)}");
            toStringOutput.Add($"this.CancellationMessage = {(this.CancellationMessage == null ? "null" : this.CancellationMessage)}");
            toStringOutput.Add($"CancellationMethod = {(this.CancellationMethod == null ? "null" : this.CancellationMethod.ToString())}");
            toStringOutput.Add($"this.CancelAtEndOfPeriod = {(this.CancelAtEndOfPeriod == null ? "null" : this.CancelAtEndOfPeriod.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt)}");
            toStringOutput.Add($"this.CurrentPeriodStartedAt = {(this.CurrentPeriodStartedAt == null ? "null" : this.CurrentPeriodStartedAt)}");
            toStringOutput.Add($"this.PreviousState = {(this.PreviousState == null ? "null" : this.PreviousState)}");
            toStringOutput.Add($"this.SignupPaymentId = {(this.SignupPaymentId == null ? "null" : this.SignupPaymentId.ToString())}");
            toStringOutput.Add($"this.SignupRevenue = {(this.SignupRevenue == null ? "null" : this.SignupRevenue)}");
            toStringOutput.Add($"this.DelayedCancelAt = {(this.DelayedCancelAt == null ? "null" : this.DelayedCancelAt)}");
            toStringOutput.Add($"this.CouponCode = {(this.CouponCode == null ? "null" : this.CouponCode)}");
            toStringOutput.Add($"this.SnapDay = {(this.SnapDay == null ? "null" : this.SnapDay)}");
            toStringOutput.Add($"PaymentCollectionMethod = {(this.PaymentCollectionMethod == null ? "null" : this.PaymentCollectionMethod.ToString())}");
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : this.Product.ToString())}");
            toStringOutput.Add($"this.CreditCard = {(this.CreditCard == null ? "null" : this.CreditCard.ToString())}");
            toStringOutput.Add($"MGroup = {(this.MGroup == null ? "null" : this.MGroup.ToString())}");
            toStringOutput.Add($"this.BankAccount = {(this.BankAccount == null ? "null" : this.BankAccount.ToString())}");
            toStringOutput.Add($"this.PaymentType = {(this.PaymentType == null ? "null" : this.PaymentType)}");
            toStringOutput.Add($"this.ReferralCode = {(this.ReferralCode == null ? "null" : this.ReferralCode)}");
            toStringOutput.Add($"this.NextProductId = {(this.NextProductId == null ? "null" : this.NextProductId.ToString())}");
            toStringOutput.Add($"this.NextProductHandle = {(this.NextProductHandle == null ? "null" : this.NextProductHandle)}");
            toStringOutput.Add($"this.CouponUseCount = {(this.CouponUseCount == null ? "null" : this.CouponUseCount.ToString())}");
            toStringOutput.Add($"this.CouponUsesAllowed = {(this.CouponUsesAllowed == null ? "null" : this.CouponUsesAllowed.ToString())}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
            toStringOutput.Add($"this.AutomaticallyResumeAt = {(this.AutomaticallyResumeAt == null ? "null" : this.AutomaticallyResumeAt)}");
            toStringOutput.Add($"this.CouponCodes = {(this.CouponCodes == null ? "null" : $"[{string.Join(", ", this.CouponCodes)} ]")}");
            toStringOutput.Add($"this.OfferId = {(this.OfferId == null ? "null" : this.OfferId.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.CurrentBillingAmountInCents = {(this.CurrentBillingAmountInCents == null ? "null" : this.CurrentBillingAmountInCents.ToString())}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointType = {(this.ProductPricePointType == null ? "null" : this.ProductPricePointType)}");
            toStringOutput.Add($"this.NextProductPricePointId = {(this.NextProductPricePointId == null ? "null" : this.NextProductPricePointId.ToString())}");
            toStringOutput.Add($"this.NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms.ToString())}");
            toStringOutput.Add($"this.StoredCredentialTransactionId = {(this.StoredCredentialTransactionId == null ? "null" : this.StoredCredentialTransactionId.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.OnHoldAt = {(this.OnHoldAt == null ? "null" : this.OnHoldAt)}");
            toStringOutput.Add($"this.PrepaidDunning = {(this.PrepaidDunning == null ? "null" : this.PrepaidDunning.ToString())}");
            toStringOutput.Add($"this.Coupons = {(this.Coupons == null ? "null" : $"[{string.Join(", ", this.Coupons)} ]")}");
            toStringOutput.Add($"this.DunningCommunicationDelayEnabled = {(this.DunningCommunicationDelayEnabled == null ? "null" : this.DunningCommunicationDelayEnabled.ToString())}");
            toStringOutput.Add($"this.DunningCommunicationDelayTimeZone = {(this.DunningCommunicationDelayTimeZone == null ? "null" : this.DunningCommunicationDelayTimeZone)}");
            toStringOutput.Add($"this.ReceivesInvoiceEmails = {(this.ReceivesInvoiceEmails == null ? "null" : this.ReceivesInvoiceEmails.ToString())}");
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.ScheduledCancellationAt = {(this.ScheduledCancellationAt == null ? "null" : this.ScheduledCancellationAt)}");
            toStringOutput.Add($"this.CreditBalanceInCents = {(this.CreditBalanceInCents == null ? "null" : this.CreditBalanceInCents.ToString())}");
            toStringOutput.Add($"this.PrepaymentBalanceInCents = {(this.PrepaymentBalanceInCents == null ? "null" : this.PrepaymentBalanceInCents.ToString())}");
        }
    }
}