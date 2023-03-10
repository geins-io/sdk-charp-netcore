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
    /// A canonical product url for a specific market and language.
    /// </summary>
    [DataContract(Name = "Product.Models.Read.ProductUrl")]
    public partial class ProductModelsReadProductUrl : IEquatable<ProductModelsReadProductUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModelsReadProductUrl" /> class.
        /// </summary>
        /// <param name="url">The canonical url to the product..</param>
        /// <param name="market">The market of the url..</param>
        /// <param name="language">The language code of the url..</param>
        public ProductModelsReadProductUrl(string url = default(string), int market = default(int), string language = default(string))
        {
            this.Url = url;
            this.Market = market;
            this.Language = language;
        }

        /// <summary>
        /// The canonical url to the product.
        /// </summary>
        /// <value>The canonical url to the product.</value>
        [DataMember(Name = "Url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// The market of the url.
        /// </summary>
        /// <value>The market of the url.</value>
        [DataMember(Name = "Market", EmitDefaultValue = false)]
        public int Market { get; set; }

        /// <summary>
        /// The language code of the url.
        /// </summary>
        /// <value>The language code of the url.</value>
        [DataMember(Name = "Language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductModelsReadProductUrl {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(input as ProductModelsReadProductUrl);
        }

        /// <summary>
        /// Returns true if ProductModelsReadProductUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductModelsReadProductUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductModelsReadProductUrl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Market == input.Market ||
                    this.Market.Equals(input.Market)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Market.GetHashCode();
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
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
