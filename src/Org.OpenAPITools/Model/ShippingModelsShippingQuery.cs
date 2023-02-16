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
    /// A query to filter shipping options by.
    /// </summary>
    [DataContract(Name = "Shipping.Models.ShippingQuery")]
    public partial class ShippingModelsShippingQuery : IEquatable<ShippingModelsShippingQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingModelsShippingQuery" /> class.
        /// </summary>
        /// <param name="siteId">The site ID the delivery options belong to. Required..</param>
        /// <param name="countryId">The country ID where the order should be shipped to..</param>
        /// <param name="shippingId">Carismar Shipping Option ID.</param>
        /// <param name="deliveryOptionId">Unifaun Delivery Option ID.</param>
        /// <param name="order">order.</param>
        /// <param name="minimumFreeShippingLimit">The cart sum limit for free shipping - to be used for conditions in the delivery checkout portal.</param>
        public ShippingModelsShippingQuery(int siteId = default(int), int countryId = default(int), int shippingId = default(int), Guid deliveryOptionId = default(Guid), OrderCheckoutOrder order = default(OrderCheckoutOrder), double minimumFreeShippingLimit = default(double))
        {
            this.SiteId = siteId;
            this.CountryId = countryId;
            this.ShippingId = shippingId;
            this.DeliveryOptionId = deliveryOptionId;
            this.Order = order;
            this.MinimumFreeShippingLimit = minimumFreeShippingLimit;
        }

        /// <summary>
        /// The site ID the delivery options belong to. Required.
        /// </summary>
        /// <value>The site ID the delivery options belong to. Required.</value>
        [DataMember(Name = "SiteId", EmitDefaultValue = false)]
        public int SiteId { get; set; }

        /// <summary>
        /// The country ID where the order should be shipped to.
        /// </summary>
        /// <value>The country ID where the order should be shipped to.</value>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public int CountryId { get; set; }

        /// <summary>
        /// Carismar Shipping Option ID
        /// </summary>
        /// <value>Carismar Shipping Option ID</value>
        [DataMember(Name = "ShippingId", EmitDefaultValue = false)]
        public int ShippingId { get; set; }

        /// <summary>
        /// Unifaun Delivery Option ID
        /// </summary>
        /// <value>Unifaun Delivery Option ID</value>
        [DataMember(Name = "DeliveryOptionId", EmitDefaultValue = false)]
        public Guid DeliveryOptionId { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "Order", EmitDefaultValue = false)]
        public OrderCheckoutOrder Order { get; set; }

        /// <summary>
        /// The cart sum limit for free shipping - to be used for conditions in the delivery checkout portal
        /// </summary>
        /// <value>The cart sum limit for free shipping - to be used for conditions in the delivery checkout portal</value>
        [DataMember(Name = "MinimumFreeShippingLimit", EmitDefaultValue = false)]
        public double MinimumFreeShippingLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingModelsShippingQuery {\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  ShippingId: ").Append(ShippingId).Append("\n");
            sb.Append("  DeliveryOptionId: ").Append(DeliveryOptionId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  MinimumFreeShippingLimit: ").Append(MinimumFreeShippingLimit).Append("\n");
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
            return this.Equals(input as ShippingModelsShippingQuery);
        }

        /// <summary>
        /// Returns true if ShippingModelsShippingQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingModelsShippingQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingModelsShippingQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SiteId == input.SiteId ||
                    this.SiteId.Equals(input.SiteId)
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    this.CountryId.Equals(input.CountryId)
                ) && 
                (
                    this.ShippingId == input.ShippingId ||
                    this.ShippingId.Equals(input.ShippingId)
                ) && 
                (
                    this.DeliveryOptionId == input.DeliveryOptionId ||
                    (this.DeliveryOptionId != null &&
                    this.DeliveryOptionId.Equals(input.DeliveryOptionId))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.MinimumFreeShippingLimit == input.MinimumFreeShippingLimit ||
                    this.MinimumFreeShippingLimit.Equals(input.MinimumFreeShippingLimit)
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
                hashCode = (hashCode * 59) + this.SiteId.GetHashCode();
                hashCode = (hashCode * 59) + this.CountryId.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippingId.GetHashCode();
                if (this.DeliveryOptionId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryOptionId.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinimumFreeShippingLimit.GetHashCode();
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