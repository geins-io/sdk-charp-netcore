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
    /// A product feed.
    /// </summary>
    [DataContract(Name = "Product.Models.Read.Feed")]
    public partial class ProductModelsReadFeed : IEquatable<ProductModelsReadFeed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModelsReadFeed" /> class.
        /// </summary>
        /// <param name="feedId">The feed id..</param>
        /// <param name="name">The feed name..</param>
        /// <param name="url">The url to the feed..</param>
        /// <param name="layout">The name of the feed layout..</param>
        /// <param name="market">The market of the feed..</param>
        /// <param name="language">The language code of the feed..</param>
        /// <param name="defaultCurrency">The default currency for the market.</param>
        /// <param name="defaultCountry">The default country for the market.</param>
        public ProductModelsReadFeed(int feedId = default(int), string name = default(string), string url = default(string), string layout = default(string), int market = default(int), string language = default(string), string defaultCurrency = default(string), string defaultCountry = default(string))
        {
            this.FeedId = feedId;
            this.Name = name;
            this.Url = url;
            this.Layout = layout;
            this.Market = market;
            this.Language = language;
            this.DefaultCurrency = defaultCurrency;
            this.DefaultCountry = defaultCountry;
        }

        /// <summary>
        /// The feed id.
        /// </summary>
        /// <value>The feed id.</value>
        [DataMember(Name = "FeedId", EmitDefaultValue = false)]
        public int FeedId { get; set; }

        /// <summary>
        /// The feed name.
        /// </summary>
        /// <value>The feed name.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The url to the feed.
        /// </summary>
        /// <value>The url to the feed.</value>
        [DataMember(Name = "Url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// The name of the feed layout.
        /// </summary>
        /// <value>The name of the feed layout.</value>
        [DataMember(Name = "Layout", EmitDefaultValue = false)]
        public string Layout { get; set; }

        /// <summary>
        /// The market of the feed.
        /// </summary>
        /// <value>The market of the feed.</value>
        [DataMember(Name = "Market", EmitDefaultValue = false)]
        public int Market { get; set; }

        /// <summary>
        /// The language code of the feed.
        /// </summary>
        /// <value>The language code of the feed.</value>
        [DataMember(Name = "Language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// The default currency for the market
        /// </summary>
        /// <value>The default currency for the market</value>
        [DataMember(Name = "DefaultCurrency", EmitDefaultValue = false)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// The default country for the market
        /// </summary>
        /// <value>The default country for the market</value>
        [DataMember(Name = "DefaultCountry", EmitDefaultValue = false)]
        public string DefaultCountry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductModelsReadFeed {\n");
            sb.Append("  FeedId: ").Append(FeedId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  DefaultCountry: ").Append(DefaultCountry).Append("\n");
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
            return this.Equals(input as ProductModelsReadFeed);
        }

        /// <summary>
        /// Returns true if ProductModelsReadFeed instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductModelsReadFeed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductModelsReadFeed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FeedId == input.FeedId ||
                    this.FeedId.Equals(input.FeedId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.Market == input.Market ||
                    this.Market.Equals(input.Market)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.DefaultCurrency == input.DefaultCurrency ||
                    (this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(input.DefaultCurrency))
                ) && 
                (
                    this.DefaultCountry == input.DefaultCountry ||
                    (this.DefaultCountry != null &&
                    this.DefaultCountry.Equals(input.DefaultCountry))
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
                hashCode = (hashCode * 59) + this.FeedId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Layout != null)
                {
                    hashCode = (hashCode * 59) + this.Layout.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Market.GetHashCode();
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                if (this.DefaultCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultCurrency.GetHashCode();
                }
                if (this.DefaultCountry != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultCountry.GetHashCode();
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
