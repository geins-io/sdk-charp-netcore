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
    /// Data carrying class for order queries
    /// </summary>
    [DataContract(Name = "Order.Models.OrderQuery")]
    public partial class OrderModelsOrderQuery : IEquatable<OrderModelsOrderQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderModelsOrderQuery" /> class.
        /// </summary>
        /// <param name="updated">Given a date, only orders updated after the provided date will be returned..</param>
        /// <param name="statusList">Comma separated list of statuses to filter on..</param>
        /// <param name="marketId">Id of a market..</param>
        /// <param name="paymentName">Name of a payment method.</param>
        /// <param name="parcelGroupId">Id of a parcel group..</param>
        /// <param name="customerId">The ID of a customer.</param>
        /// <param name="email">The email of a customer.</param>
        /// <param name="include">Comma separated list of child-collections to also include in the query result..</param>
        /// <param name="externalOrderStatus">This status can be used by external systems to change the status of an order. Such as failed or done..</param>
        /// <param name="combineProductContainerRows">If true, will combine all order rows that are part of a container into a single container row..</param>
        /// <param name="packingLocationId">The packing place to get orders from..</param>
        public OrderModelsOrderQuery(DateTime updated = default(DateTime), string statusList = default(string), int marketId = default(int), string paymentName = default(string), int parcelGroupId = default(int), int customerId = default(int), string email = default(string), string include = default(string), int externalOrderStatus = default(int), bool combineProductContainerRows = default(bool), int packingLocationId = default(int))
        {
            this.Updated = updated;
            this.StatusList = statusList;
            this.MarketId = marketId;
            this.PaymentName = paymentName;
            this.ParcelGroupId = parcelGroupId;
            this.CustomerId = customerId;
            this.Email = email;
            this.Include = include;
            this.ExternalOrderStatus = externalOrderStatus;
            this.CombineProductContainerRows = combineProductContainerRows;
            this.PackingLocationId = packingLocationId;
        }

        /// <summary>
        /// Given a date, only orders updated after the provided date will be returned.
        /// </summary>
        /// <value>Given a date, only orders updated after the provided date will be returned.</value>
        [DataMember(Name = "Updated", EmitDefaultValue = false)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Comma separated list of statuses to filter on.
        /// </summary>
        /// <value>Comma separated list of statuses to filter on.</value>
        [DataMember(Name = "StatusList", EmitDefaultValue = false)]
        public string StatusList { get; set; }

        /// <summary>
        /// Id of a market.
        /// </summary>
        /// <value>Id of a market.</value>
        [DataMember(Name = "MarketId", EmitDefaultValue = false)]
        public int MarketId { get; set; }

        /// <summary>
        /// Name of a payment method
        /// </summary>
        /// <value>Name of a payment method</value>
        [DataMember(Name = "PaymentName", EmitDefaultValue = false)]
        public string PaymentName { get; set; }

        /// <summary>
        /// Id of a parcel group.
        /// </summary>
        /// <value>Id of a parcel group.</value>
        [DataMember(Name = "ParcelGroupId", EmitDefaultValue = false)]
        public int ParcelGroupId { get; set; }

        /// <summary>
        /// The ID of a customer
        /// </summary>
        /// <value>The ID of a customer</value>
        [DataMember(Name = "CustomerId", EmitDefaultValue = false)]
        public int CustomerId { get; set; }

        /// <summary>
        /// The email of a customer
        /// </summary>
        /// <value>The email of a customer</value>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Comma separated list of child-collections to also include in the query result.
        /// </summary>
        /// <value>Comma separated list of child-collections to also include in the query result.</value>
        [DataMember(Name = "Include", EmitDefaultValue = false)]
        public string Include { get; set; }

        /// <summary>
        /// This status can be used by external systems to change the status of an order. Such as failed or done.
        /// </summary>
        /// <value>This status can be used by external systems to change the status of an order. Such as failed or done.</value>
        [DataMember(Name = "ExternalOrderStatus", EmitDefaultValue = false)]
        public int ExternalOrderStatus { get; set; }

        /// <summary>
        /// If true, will combine all order rows that are part of a container into a single container row.
        /// </summary>
        /// <value>If true, will combine all order rows that are part of a container into a single container row.</value>
        [DataMember(Name = "CombineProductContainerRows", EmitDefaultValue = true)]
        public bool CombineProductContainerRows { get; set; }

        /// <summary>
        /// The packing place to get orders from.
        /// </summary>
        /// <value>The packing place to get orders from.</value>
        [DataMember(Name = "PackingLocationId", EmitDefaultValue = false)]
        public int PackingLocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderModelsOrderQuery {\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  StatusList: ").Append(StatusList).Append("\n");
            sb.Append("  MarketId: ").Append(MarketId).Append("\n");
            sb.Append("  PaymentName: ").Append(PaymentName).Append("\n");
            sb.Append("  ParcelGroupId: ").Append(ParcelGroupId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Include: ").Append(Include).Append("\n");
            sb.Append("  ExternalOrderStatus: ").Append(ExternalOrderStatus).Append("\n");
            sb.Append("  CombineProductContainerRows: ").Append(CombineProductContainerRows).Append("\n");
            sb.Append("  PackingLocationId: ").Append(PackingLocationId).Append("\n");
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
            return this.Equals(input as OrderModelsOrderQuery);
        }

        /// <summary>
        /// Returns true if OrderModelsOrderQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderModelsOrderQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderModelsOrderQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.StatusList == input.StatusList ||
                    (this.StatusList != null &&
                    this.StatusList.Equals(input.StatusList))
                ) && 
                (
                    this.MarketId == input.MarketId ||
                    this.MarketId.Equals(input.MarketId)
                ) && 
                (
                    this.PaymentName == input.PaymentName ||
                    (this.PaymentName != null &&
                    this.PaymentName.Equals(input.PaymentName))
                ) && 
                (
                    this.ParcelGroupId == input.ParcelGroupId ||
                    this.ParcelGroupId.Equals(input.ParcelGroupId)
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    this.CustomerId.Equals(input.CustomerId)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Include == input.Include ||
                    (this.Include != null &&
                    this.Include.Equals(input.Include))
                ) && 
                (
                    this.ExternalOrderStatus == input.ExternalOrderStatus ||
                    this.ExternalOrderStatus.Equals(input.ExternalOrderStatus)
                ) && 
                (
                    this.CombineProductContainerRows == input.CombineProductContainerRows ||
                    this.CombineProductContainerRows.Equals(input.CombineProductContainerRows)
                ) && 
                (
                    this.PackingLocationId == input.PackingLocationId ||
                    this.PackingLocationId.Equals(input.PackingLocationId)
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
                if (this.Updated != null)
                {
                    hashCode = (hashCode * 59) + this.Updated.GetHashCode();
                }
                if (this.StatusList != null)
                {
                    hashCode = (hashCode * 59) + this.StatusList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MarketId.GetHashCode();
                if (this.PaymentName != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ParcelGroupId.GetHashCode();
                hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Include != null)
                {
                    hashCode = (hashCode * 59) + this.Include.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExternalOrderStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.CombineProductContainerRows.GetHashCode();
                hashCode = (hashCode * 59) + this.PackingLocationId.GetHashCode();
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
