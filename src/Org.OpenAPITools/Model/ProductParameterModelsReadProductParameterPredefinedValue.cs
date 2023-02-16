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
    /// A predefined value for a product parameter.
    /// </summary>
    [DataContract(Name = "ProductParameter.Models.Read.ProductParameterPredefinedValue")]
    public partial class ProductParameterModelsReadProductParameterPredefinedValue : IEquatable<ProductParameterModelsReadProductParameterPredefinedValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductParameterModelsReadProductParameterPredefinedValue" /> class.
        /// </summary>
        /// <param name="parameterId">The unique identifier for the parameter..</param>
        /// <param name="predefinedValueId">The predefined value id of the parameter..</param>
        /// <param name="name">The non-localized predefined value name of the parameter..</param>
        /// <param name="localizedNames">The localized predefined value names of the parameter..</param>
        public ProductParameterModelsReadProductParameterPredefinedValue(int parameterId = default(int), int predefinedValueId = default(int), string name = default(string), List<SharedModelsLocalizableContent> localizedNames = default(List<SharedModelsLocalizableContent>))
        {
            this.ParameterId = parameterId;
            this.PredefinedValueId = predefinedValueId;
            this.Name = name;
            this.LocalizedNames = localizedNames;
        }

        /// <summary>
        /// The unique identifier for the parameter.
        /// </summary>
        /// <value>The unique identifier for the parameter.</value>
        [DataMember(Name = "ParameterId", EmitDefaultValue = false)]
        public int ParameterId { get; set; }

        /// <summary>
        /// The predefined value id of the parameter.
        /// </summary>
        /// <value>The predefined value id of the parameter.</value>
        [DataMember(Name = "PredefinedValueId", EmitDefaultValue = false)]
        public int PredefinedValueId { get; set; }

        /// <summary>
        /// The non-localized predefined value name of the parameter.
        /// </summary>
        /// <value>The non-localized predefined value name of the parameter.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The localized predefined value names of the parameter.
        /// </summary>
        /// <value>The localized predefined value names of the parameter.</value>
        [DataMember(Name = "LocalizedNames", EmitDefaultValue = false)]
        public List<SharedModelsLocalizableContent> LocalizedNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductParameterModelsReadProductParameterPredefinedValue {\n");
            sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
            sb.Append("  PredefinedValueId: ").Append(PredefinedValueId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocalizedNames: ").Append(LocalizedNames).Append("\n");
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
            return this.Equals(input as ProductParameterModelsReadProductParameterPredefinedValue);
        }

        /// <summary>
        /// Returns true if ProductParameterModelsReadProductParameterPredefinedValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductParameterModelsReadProductParameterPredefinedValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductParameterModelsReadProductParameterPredefinedValue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParameterId == input.ParameterId ||
                    this.ParameterId.Equals(input.ParameterId)
                ) && 
                (
                    this.PredefinedValueId == input.PredefinedValueId ||
                    this.PredefinedValueId.Equals(input.PredefinedValueId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocalizedNames == input.LocalizedNames ||
                    this.LocalizedNames != null &&
                    input.LocalizedNames != null &&
                    this.LocalizedNames.SequenceEqual(input.LocalizedNames)
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
                hashCode = (hashCode * 59) + this.ParameterId.GetHashCode();
                hashCode = (hashCode * 59) + this.PredefinedValueId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LocalizedNames != null)
                {
                    hashCode = (hashCode * 59) + this.LocalizedNames.GetHashCode();
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