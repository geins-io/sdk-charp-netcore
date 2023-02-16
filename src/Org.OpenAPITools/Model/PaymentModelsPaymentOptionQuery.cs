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
    /// PaymentModelsPaymentOptionQuery
    /// </summary>
    [DataContract(Name = "Payment.Models.PaymentOptionQuery")]
    public partial class PaymentModelsPaymentOptionQuery : IEquatable<PaymentModelsPaymentOptionQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentModelsPaymentOptionQuery" /> class.
        /// </summary>
        /// <param name="siteId">siteId.</param>
        /// <param name="email">Customer email address.</param>
        /// <param name="customerTypeId">customerTypeId.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="sum">sum.</param>
        public PaymentModelsPaymentOptionQuery(int siteId = default(int), string email = default(string), int customerTypeId = default(int), int countryId = default(int), double sum = default(double))
        {
            this.SiteId = siteId;
            this.Email = email;
            this.CustomerTypeId = customerTypeId;
            this.CountryId = countryId;
            this.Sum = sum;
        }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "SiteId", EmitDefaultValue = false)]
        public int SiteId { get; set; }

        /// <summary>
        /// Customer email address
        /// </summary>
        /// <value>Customer email address</value>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets CustomerTypeId
        /// </summary>
        [DataMember(Name = "CustomerTypeId", EmitDefaultValue = false)]
        public int CustomerTypeId { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or Sets Sum
        /// </summary>
        [DataMember(Name = "Sum", EmitDefaultValue = false)]
        public double Sum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentModelsPaymentOptionQuery {\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CustomerTypeId: ").Append(CustomerTypeId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
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
            return this.Equals(input as PaymentModelsPaymentOptionQuery);
        }

        /// <summary>
        /// Returns true if PaymentModelsPaymentOptionQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentModelsPaymentOptionQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentModelsPaymentOptionQuery input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CustomerTypeId == input.CustomerTypeId ||
                    this.CustomerTypeId.Equals(input.CustomerTypeId)
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    this.CountryId.Equals(input.CountryId)
                ) && 
                (
                    this.Sum == input.Sum ||
                    this.Sum.Equals(input.Sum)
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CustomerTypeId.GetHashCode();
                hashCode = (hashCode * 59) + this.CountryId.GetHashCode();
                hashCode = (hashCode * 59) + this.Sum.GetHashCode();
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