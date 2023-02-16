/*
 * Geins Management API
 *
 *  Geins Management API is an RESTful api to power your applications who manages your geins services. Geins provides an easy-to-use and scalable solution for managing all aspects of an online store, from product listings and customer information to order processing and payment transactions.   :::tip With this API, you can build custom applications and integrate with third-party systems, dashboards and other bussiness logic apps. :::    ## Getting started Once you have created an account, you can start using the Management API by creating an `API key`. You can create as many API keys as you need. Each `API key` is connected to a specific account so you can keep track of operations and manage keys. You can find your `API key` in the `geins merchant center`.   ### Fast track Use one of our [SDKs](https://docs.geins.io/docs/sdk/introduction) to get started quickly. The SDKs are available for the most popular programming languages and frameworks.  Or, if you prefer to just take it for a test run:  [![Run in Postman](https://run.pstmn.io/button.svg)](https://god.gw.postman.com/run-collection/25895885-aaf6598f-1a7c-4949-85d7-ba846c42d553?action=collection%2Ffork&collection-url=entityId%3D25895885-aaf6598f-1a7c-4949-85d7-ba846c42d553%26entityType%3Dcollection%26workspaceId%3Da2a179ce-158e-46b0-8d06-e9640f45112c)  ### Authentication Two authentication methods are supported:   - `API Key`   - `Basic Auth` 
 *
 * The version of the OpenAPI document: v1.7
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Data carrier for a payment detail
    /// </summary>
    [DataContract(Name = "Order.Models.PaymentDetail")]
    public partial class OrderModelsPaymentDetail : IEquatable<OrderModelsPaymentDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderModelsPaymentDetail" /> class.
        /// </summary>
        /// <param name="id">Unique identifier for this payment detail. Exception: For some payment options this field can be 0. These orders only have one payment detail..</param>
        /// <param name="paymentId">Payment method id.</param>
        /// <param name="name">The name of the payment method.</param>
        /// <param name="displayName">The display name of the payment method.</param>
        /// <param name="transactionId">The transaction id (external reference)..</param>
        /// <param name="secondaryTransactionId">The secondary transaction id, if any (external reference)..</param>
        /// <param name="reservationNumber">The reservation number. This field is not available for all payment methods..</param>
        /// <param name="reservationDate">Reservation date.</param>
        /// <param name="paymentDate">Payment date.</param>
        /// <param name="total">Total.</param>
        /// <param name="payed">Shows if the order is paid using this payment method.</param>
        /// <param name="paymentFee">The payment fee.</param>
        /// <param name="shippingFee">The shipping fee.</param>
        /// <param name="paymentOption">The name of the payment option, if any.  This doesn&#39;t have to be the same as the payment name. Eg \&quot;Direct bank payment\&quot;, \&quot;Card\&quot;, \&quot;Invoice\&quot; etc..</param>
        public OrderModelsPaymentDetail(int id = default(int), int paymentId = default(int), string name = default(string), string displayName = default(string), string transactionId = default(string), string secondaryTransactionId = default(string), string reservationNumber = default(string), DateTime reservationDate = default(DateTime), DateTime paymentDate = default(DateTime), double total = default(double), bool payed = default(bool), double paymentFee = default(double), double shippingFee = default(double), string paymentOption = default(string))
        {
            this.Id = id;
            this.PaymentId = paymentId;
            this.Name = name;
            this.DisplayName = displayName;
            this.TransactionId = transactionId;
            this.SecondaryTransactionId = secondaryTransactionId;
            this.ReservationNumber = reservationNumber;
            this.ReservationDate = reservationDate;
            this.PaymentDate = paymentDate;
            this.Total = total;
            this.Payed = payed;
            this.PaymentFee = paymentFee;
            this.ShippingFee = shippingFee;
            this.PaymentOption = paymentOption;
        }

        /// <summary>
        /// Unique identifier for this payment detail. Exception: For some payment options this field can be 0. These orders only have one payment detail.
        /// </summary>
        /// <value>Unique identifier for this payment detail. Exception: For some payment options this field can be 0. These orders only have one payment detail.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Payment method id
        /// </summary>
        /// <value>Payment method id</value>
        [DataMember(Name = "PaymentId", EmitDefaultValue = false)]
        public int PaymentId { get; set; }

        /// <summary>
        /// The name of the payment method
        /// </summary>
        /// <value>The name of the payment method</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The display name of the payment method
        /// </summary>
        /// <value>The display name of the payment method</value>
        [DataMember(Name = "DisplayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The transaction id (external reference).
        /// </summary>
        /// <value>The transaction id (external reference).</value>
        [DataMember(Name = "TransactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The secondary transaction id, if any (external reference).
        /// </summary>
        /// <value>The secondary transaction id, if any (external reference).</value>
        [DataMember(Name = "SecondaryTransactionId", EmitDefaultValue = false)]
        public string SecondaryTransactionId { get; set; }

        /// <summary>
        /// The reservation number. This field is not available for all payment methods.
        /// </summary>
        /// <value>The reservation number. This field is not available for all payment methods.</value>
        [DataMember(Name = "ReservationNumber", EmitDefaultValue = false)]
        public string ReservationNumber { get; set; }

        /// <summary>
        /// Reservation date
        /// </summary>
        /// <value>Reservation date</value>
        [DataMember(Name = "ReservationDate", EmitDefaultValue = false)]
        public DateTime ReservationDate { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        /// <value>Payment date</value>
        [DataMember(Name = "PaymentDate", EmitDefaultValue = false)]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        /// <value>Total</value>
        [DataMember(Name = "Total", EmitDefaultValue = false)]
        public double Total { get; set; }

        /// <summary>
        /// Shows if the order is paid using this payment method
        /// </summary>
        /// <value>Shows if the order is paid using this payment method</value>
        [DataMember(Name = "Payed", EmitDefaultValue = true)]
        public bool Payed { get; set; }

        /// <summary>
        /// The payment fee
        /// </summary>
        /// <value>The payment fee</value>
        [DataMember(Name = "PaymentFee", EmitDefaultValue = false)]
        public double PaymentFee { get; set; }

        /// <summary>
        /// The shipping fee
        /// </summary>
        /// <value>The shipping fee</value>
        [DataMember(Name = "ShippingFee", EmitDefaultValue = false)]
        public double ShippingFee { get; set; }

        /// <summary>
        /// The name of the payment option, if any.  This doesn&#39;t have to be the same as the payment name. Eg \&quot;Direct bank payment\&quot;, \&quot;Card\&quot;, \&quot;Invoice\&quot; etc.
        /// </summary>
        /// <value>The name of the payment option, if any.  This doesn&#39;t have to be the same as the payment name. Eg \&quot;Direct bank payment\&quot;, \&quot;Card\&quot;, \&quot;Invoice\&quot; etc.</value>
        [DataMember(Name = "PaymentOption", EmitDefaultValue = false)]
        public string PaymentOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderModelsPaymentDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  SecondaryTransactionId: ").Append(SecondaryTransactionId).Append("\n");
            sb.Append("  ReservationNumber: ").Append(ReservationNumber).Append("\n");
            sb.Append("  ReservationDate: ").Append(ReservationDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Payed: ").Append(Payed).Append("\n");
            sb.Append("  PaymentFee: ").Append(PaymentFee).Append("\n");
            sb.Append("  ShippingFee: ").Append(ShippingFee).Append("\n");
            sb.Append("  PaymentOption: ").Append(PaymentOption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderModelsPaymentDetail);
        }

        /// <summary>
        /// Returns true if OrderModelsPaymentDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderModelsPaymentDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderModelsPaymentDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    this.PaymentId.Equals(input.PaymentId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.SecondaryTransactionId == input.SecondaryTransactionId ||
                    (this.SecondaryTransactionId != null &&
                    this.SecondaryTransactionId.Equals(input.SecondaryTransactionId))
                ) && 
                (
                    this.ReservationNumber == input.ReservationNumber ||
                    (this.ReservationNumber != null &&
                    this.ReservationNumber.Equals(input.ReservationNumber))
                ) && 
                (
                    this.ReservationDate == input.ReservationDate ||
                    (this.ReservationDate != null &&
                    this.ReservationDate.Equals(input.ReservationDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Payed == input.Payed ||
                    this.Payed.Equals(input.Payed)
                ) && 
                (
                    this.PaymentFee == input.PaymentFee ||
                    this.PaymentFee.Equals(input.PaymentFee)
                ) && 
                (
                    this.ShippingFee == input.ShippingFee ||
                    this.ShippingFee.Equals(input.ShippingFee)
                ) && 
                (
                    this.PaymentOption == input.PaymentOption ||
                    (this.PaymentOption != null &&
                    this.PaymentOption.Equals(input.PaymentOption))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.SecondaryTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryTransactionId.GetHashCode();
                }
                if (this.ReservationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ReservationNumber.GetHashCode();
                }
                if (this.ReservationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReservationDate.GetHashCode();
                }
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.Payed.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentFee.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingFee.GetHashCode();
                if (this.PaymentOption != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentOption.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}