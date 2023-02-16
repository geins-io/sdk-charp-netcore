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
    /// An envelope for the result of and action taken on a resource.
    /// </summary>
    [DataContract(Name = "Envelope-Brand.Models.Read.Brand")]
    public partial class EnvelopeBrandModelsReadBrand : IEquatable<EnvelopeBrandModelsReadBrand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeBrandModelsReadBrand" /> class.
        /// </summary>
        /// <param name="message">A status message for the action taken..</param>
        /// <param name="details">Any validation messages for the data on the current action..</param>
        /// <param name="resource">resource.</param>
        /// <param name="pageResult">pageResult.</param>
        public EnvelopeBrandModelsReadBrand(string message = default(string), List<string> details = default(List<string>), BrandModelsReadBrand resource = default(BrandModelsReadBrand), PageResult pageResult = default(PageResult))
        {
            this.Message = message;
            this.Details = details;
            this.Resource = resource;
            this.PageResult = pageResult;
        }

        /// <summary>
        /// A status message for the action taken.
        /// </summary>
        /// <value>A status message for the action taken.</value>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Any validation messages for the data on the current action.
        /// </summary>
        /// <value>Any validation messages for the data on the current action.</value>
        [DataMember(Name = "Details", EmitDefaultValue = false)]
        public List<string> Details { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "Resource", EmitDefaultValue = false)]
        public BrandModelsReadBrand Resource { get; set; }

        /// <summary>
        /// Gets or Sets PageResult
        /// </summary>
        [DataMember(Name = "PageResult", EmitDefaultValue = false)]
        public PageResult PageResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnvelopeBrandModelsReadBrand {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  PageResult: ").Append(PageResult).Append("\n");
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
            return this.Equals(input as EnvelopeBrandModelsReadBrand);
        }

        /// <summary>
        /// Returns true if EnvelopeBrandModelsReadBrand instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvelopeBrandModelsReadBrand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeBrandModelsReadBrand input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.PageResult == input.PageResult ||
                    (this.PageResult != null &&
                    this.PageResult.Equals(input.PageResult))
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
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
                }
                if (this.PageResult != null)
                {
                    hashCode = (hashCode * 59) + this.PageResult.GetHashCode();
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
