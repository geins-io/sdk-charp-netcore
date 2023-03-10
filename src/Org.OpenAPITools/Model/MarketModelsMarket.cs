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
    /// MarketModelsMarket
    /// </summary>
    [DataContract(Name = "Market.Models.Market")]
    public partial class MarketModelsMarket : IEquatable<MarketModelsMarket>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketModelsMarket" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="currency">currency.</param>
        /// <param name="vatRate">vatRate.</param>
        /// <param name="marketPrefix">marketPrefix.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="currencyId">currencyId.</param>
        /// <param name="currencyRate">currencyRate.</param>
        /// <param name="languageId">languageId.</param>
        /// <param name="language">language.</param>
        public MarketModelsMarket(int id = default(int), string name = default(string), string displayName = default(string), string currency = default(string), double vatRate = default(double), string marketPrefix = default(string), int countryId = default(int), int currencyId = default(int), double currencyRate = default(double), int languageId = default(int), string language = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.DisplayName = displayName;
            this.Currency = currency;
            this.VatRate = vatRate;
            this.MarketPrefix = marketPrefix;
            this.CountryId = countryId;
            this.CurrencyId = currencyId;
            this.CurrencyRate = currencyRate;
            this.LanguageId = languageId;
            this.Language = language;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "DisplayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "Currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets VatRate
        /// </summary>
        [DataMember(Name = "VatRate", EmitDefaultValue = false)]
        public double VatRate { get; set; }

        /// <summary>
        /// Gets or Sets MarketPrefix
        /// </summary>
        [DataMember(Name = "MarketPrefix", EmitDefaultValue = false)]
        public string MarketPrefix { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name = "CurrencyId", EmitDefaultValue = false)]
        public int CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyRate
        /// </summary>
        [DataMember(Name = "CurrencyRate", EmitDefaultValue = false)]
        public double CurrencyRate { get; set; }

        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name = "LanguageId", EmitDefaultValue = false)]
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "Language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketModelsMarket {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  VatRate: ").Append(VatRate).Append("\n");
            sb.Append("  MarketPrefix: ").Append(MarketPrefix).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
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
            return this.Equals(input as MarketModelsMarket);
        }

        /// <summary>
        /// Returns true if MarketModelsMarket instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketModelsMarket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketModelsMarket input)
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
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.VatRate == input.VatRate ||
                    this.VatRate.Equals(input.VatRate)
                ) && 
                (
                    this.MarketPrefix == input.MarketPrefix ||
                    (this.MarketPrefix != null &&
                    this.MarketPrefix.Equals(input.MarketPrefix))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    this.CountryId.Equals(input.CountryId)
                ) && 
                (
                    this.CurrencyId == input.CurrencyId ||
                    this.CurrencyId.Equals(input.CurrencyId)
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    this.CurrencyRate.Equals(input.CurrencyRate)
                ) && 
                (
                    this.LanguageId == input.LanguageId ||
                    this.LanguageId.Equals(input.LanguageId)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VatRate.GetHashCode();
                if (this.MarketPrefix != null)
                {
                    hashCode = (hashCode * 59) + this.MarketPrefix.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CountryId.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrencyId.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrencyRate.GetHashCode();
                hashCode = (hashCode * 59) + this.LanguageId.GetHashCode();
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
