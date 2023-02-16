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
    /// A supplier query.
    /// </summary>
    [DataContract(Name = "Supplier.Models.SupplierQuery")]
    public partial class SupplierModelsSupplierQuery : IEquatable<SupplierModelsSupplierQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplierModelsSupplierQuery" /> class.
        /// </summary>
        /// <param name="nameContains">Limits query to suppliers with a name containing the specified string..</param>
        /// <param name="externalIds">Limits query to externalIds.</param>
        public SupplierModelsSupplierQuery(string nameContains = default(string), List<string> externalIds = default(List<string>))
        {
            this.NameContains = nameContains;
            this.ExternalIds = externalIds;
        }

        /// <summary>
        /// Limits query to suppliers with a name containing the specified string.
        /// </summary>
        /// <value>Limits query to suppliers with a name containing the specified string.</value>
        [DataMember(Name = "NameContains", EmitDefaultValue = false)]
        public string NameContains { get; set; }

        /// <summary>
        /// Limits query to externalIds
        /// </summary>
        /// <value>Limits query to externalIds</value>
        [DataMember(Name = "ExternalIds", EmitDefaultValue = false)]
        public List<string> ExternalIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupplierModelsSupplierQuery {\n");
            sb.Append("  NameContains: ").Append(NameContains).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
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
            return this.Equals(input as SupplierModelsSupplierQuery);
        }

        /// <summary>
        /// Returns true if SupplierModelsSupplierQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of SupplierModelsSupplierQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupplierModelsSupplierQuery input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NameContains == input.NameContains ||
                    (this.NameContains != null &&
                    this.NameContains.Equals(input.NameContains))
                ) && 
                (
                    this.ExternalIds == input.ExternalIds ||
                    this.ExternalIds != null &&
                    input.ExternalIds != null &&
                    this.ExternalIds.SequenceEqual(input.ExternalIds)
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
                if (this.NameContains != null)
                {
                    hashCode = (hashCode * 59) + this.NameContains.GetHashCode();
                }
                if (this.ExternalIds != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalIds.GetHashCode();
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
