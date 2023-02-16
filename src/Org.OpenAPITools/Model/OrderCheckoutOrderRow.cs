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
    /// OrderCheckoutOrderRow
    /// </summary>
    [DataContract(Name = "Order.CheckoutOrderRow")]
    public partial class OrderCheckoutOrderRow : IEquatable<OrderCheckoutOrderRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCheckoutOrderRow" /> class.
        /// </summary>
        /// <param name="sku">sku.</param>
        /// <param name="productId">productId.</param>
        /// <param name="externalId">externalId.</param>
        /// <param name="discountRate">discountRate.</param>
        /// <param name="cartRowId">cartRowId.</param>
        /// <param name="productContainerBuildId">productContainerBuildId.</param>
        /// <param name="message">message.</param>
        /// <param name="articleNumber">articleNumber.</param>
        /// <param name="gtin">gtin.</param>
        /// <param name="brand">brand.</param>
        /// <param name="categories">categories.</param>
        /// <param name="name">name.</param>
        /// <param name="variant">variant.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="priceIncVat">priceIncVat.</param>
        /// <param name="priceExVat">priceExVat.</param>
        /// <param name="expectedTotalPriceIncVat">expectedTotalPriceIncVat.</param>
        /// <param name="discountIncVat">discountIncVat.</param>
        /// <param name="discountExVat">discountExVat.</param>
        /// <param name="expectedTotalDiscountIncVat">expectedTotalDiscountIncVat.</param>
        /// <param name="productUrl">productUrl.</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="weight">weight.</param>
        /// <param name="height">height.</param>
        /// <param name="width">width.</param>
        /// <param name="length">length.</param>
        /// <param name="campaignIds">campaignIds.</param>
        /// <param name="campaignGroupData">campaignGroupData.</param>
        /// <param name="campaignNames">campaignNames.</param>
        /// <param name="productPriceCampaignId">productPriceCampaignId.</param>
        /// <param name="productPriceListId">productPriceListId.</param>
        public OrderCheckoutOrderRow(string sku = default(string), int productId = default(int), string externalId = default(string), double discountRate = default(double), int cartRowId = default(int), int productContainerBuildId = default(int), string message = default(string), string articleNumber = default(string), string gtin = default(string), string brand = default(string), List<string> categories = default(List<string>), string name = default(string), string variant = default(string), int quantity = default(int), double priceIncVat = default(double), double priceExVat = default(double), double expectedTotalPriceIncVat = default(double), double discountIncVat = default(double), double discountExVat = default(double), double expectedTotalDiscountIncVat = default(double), string productUrl = default(string), string imageUrl = default(string), int weight = default(int), int height = default(int), int width = default(int), int length = default(int), List<string> campaignIds = default(List<string>), string campaignGroupData = default(string), List<string> campaignNames = default(List<string>), int productPriceCampaignId = default(int), int productPriceListId = default(int))
        {
            this.Sku = sku;
            this.ProductId = productId;
            this.ExternalId = externalId;
            this.DiscountRate = discountRate;
            this.CartRowId = cartRowId;
            this.ProductContainerBuildId = productContainerBuildId;
            this.Message = message;
            this.ArticleNumber = articleNumber;
            this.Gtin = gtin;
            this.Brand = brand;
            this.Categories = categories;
            this.Name = name;
            this.Variant = variant;
            this.Quantity = quantity;
            this.PriceIncVat = priceIncVat;
            this.PriceExVat = priceExVat;
            this.ExpectedTotalPriceIncVat = expectedTotalPriceIncVat;
            this.DiscountIncVat = discountIncVat;
            this.DiscountExVat = discountExVat;
            this.ExpectedTotalDiscountIncVat = expectedTotalDiscountIncVat;
            this.ProductUrl = productUrl;
            this.ImageUrl = imageUrl;
            this.Weight = weight;
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.CampaignIds = campaignIds;
            this.CampaignGroupData = campaignGroupData;
            this.CampaignNames = campaignNames;
            this.ProductPriceCampaignId = productPriceCampaignId;
            this.ProductPriceListId = productPriceListId;
        }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name = "Sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name = "ProductId", EmitDefaultValue = false)]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name = "ExternalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets DiscountRate
        /// </summary>
        [DataMember(Name = "DiscountRate", EmitDefaultValue = false)]
        public double DiscountRate { get; set; }

        /// <summary>
        /// Gets or Sets CartRowId
        /// </summary>
        [DataMember(Name = "CartRowId", EmitDefaultValue = false)]
        public int CartRowId { get; set; }

        /// <summary>
        /// Gets or Sets ProductContainerBuildId
        /// </summary>
        [DataMember(Name = "ProductContainerBuildId", EmitDefaultValue = false)]
        public int ProductContainerBuildId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ArticleNumber
        /// </summary>
        [DataMember(Name = "ArticleNumber", EmitDefaultValue = false)]
        public string ArticleNumber { get; set; }

        /// <summary>
        /// Gets or Sets Gtin
        /// </summary>
        [DataMember(Name = "Gtin", EmitDefaultValue = false)]
        public string Gtin { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name = "Brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "Categories", EmitDefaultValue = false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Variant
        /// </summary>
        [DataMember(Name = "Variant", EmitDefaultValue = false)]
        public string Variant { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets PriceIncVat
        /// </summary>
        [DataMember(Name = "PriceIncVat", EmitDefaultValue = false)]
        public double PriceIncVat { get; set; }

        /// <summary>
        /// Gets or Sets PriceExVat
        /// </summary>
        [DataMember(Name = "PriceExVat", EmitDefaultValue = false)]
        public double PriceExVat { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedTotalPriceIncVat
        /// </summary>
        [DataMember(Name = "ExpectedTotalPriceIncVat", EmitDefaultValue = false)]
        public double ExpectedTotalPriceIncVat { get; set; }

        /// <summary>
        /// Gets or Sets DiscountIncVat
        /// </summary>
        [DataMember(Name = "DiscountIncVat", EmitDefaultValue = false)]
        public double DiscountIncVat { get; set; }

        /// <summary>
        /// Gets or Sets DiscountExVat
        /// </summary>
        [DataMember(Name = "DiscountExVat", EmitDefaultValue = false)]
        public double DiscountExVat { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedTotalDiscountIncVat
        /// </summary>
        [DataMember(Name = "ExpectedTotalDiscountIncVat", EmitDefaultValue = false)]
        public double ExpectedTotalDiscountIncVat { get; set; }

        /// <summary>
        /// Gets or Sets ProductUrl
        /// </summary>
        [DataMember(Name = "ProductUrl", EmitDefaultValue = false)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "ImageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
        public int Weight { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "Height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "Width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name = "Length", EmitDefaultValue = false)]
        public int Length { get; set; }

        /// <summary>
        /// Gets or Sets CampaignIds
        /// </summary>
        [DataMember(Name = "CampaignIds", EmitDefaultValue = false)]
        public List<string> CampaignIds { get; set; }

        /// <summary>
        /// Gets or Sets CampaignGroupData
        /// </summary>
        [DataMember(Name = "CampaignGroupData", EmitDefaultValue = false)]
        public string CampaignGroupData { get; set; }

        /// <summary>
        /// Gets or Sets CampaignNames
        /// </summary>
        [DataMember(Name = "CampaignNames", EmitDefaultValue = false)]
        public List<string> CampaignNames { get; set; }

        /// <summary>
        /// Gets or Sets ProductPriceCampaignId
        /// </summary>
        [DataMember(Name = "ProductPriceCampaignId", EmitDefaultValue = false)]
        public int ProductPriceCampaignId { get; set; }

        /// <summary>
        /// Gets or Sets ProductPriceListId
        /// </summary>
        [DataMember(Name = "ProductPriceListId", EmitDefaultValue = false)]
        public int ProductPriceListId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCheckoutOrderRow {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  DiscountRate: ").Append(DiscountRate).Append("\n");
            sb.Append("  CartRowId: ").Append(CartRowId).Append("\n");
            sb.Append("  ProductContainerBuildId: ").Append(ProductContainerBuildId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ArticleNumber: ").Append(ArticleNumber).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Variant: ").Append(Variant).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  PriceIncVat: ").Append(PriceIncVat).Append("\n");
            sb.Append("  PriceExVat: ").Append(PriceExVat).Append("\n");
            sb.Append("  ExpectedTotalPriceIncVat: ").Append(ExpectedTotalPriceIncVat).Append("\n");
            sb.Append("  DiscountIncVat: ").Append(DiscountIncVat).Append("\n");
            sb.Append("  DiscountExVat: ").Append(DiscountExVat).Append("\n");
            sb.Append("  ExpectedTotalDiscountIncVat: ").Append(ExpectedTotalDiscountIncVat).Append("\n");
            sb.Append("  ProductUrl: ").Append(ProductUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  CampaignIds: ").Append(CampaignIds).Append("\n");
            sb.Append("  CampaignGroupData: ").Append(CampaignGroupData).Append("\n");
            sb.Append("  CampaignNames: ").Append(CampaignNames).Append("\n");
            sb.Append("  ProductPriceCampaignId: ").Append(ProductPriceCampaignId).Append("\n");
            sb.Append("  ProductPriceListId: ").Append(ProductPriceListId).Append("\n");
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
            return this.Equals(input as OrderCheckoutOrderRow);
        }

        /// <summary>
        /// Returns true if OrderCheckoutOrderRow instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCheckoutOrderRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCheckoutOrderRow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    this.ProductId.Equals(input.ProductId)
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.DiscountRate == input.DiscountRate ||
                    this.DiscountRate.Equals(input.DiscountRate)
                ) && 
                (
                    this.CartRowId == input.CartRowId ||
                    this.CartRowId.Equals(input.CartRowId)
                ) && 
                (
                    this.ProductContainerBuildId == input.ProductContainerBuildId ||
                    this.ProductContainerBuildId.Equals(input.ProductContainerBuildId)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ArticleNumber == input.ArticleNumber ||
                    (this.ArticleNumber != null &&
                    this.ArticleNumber.Equals(input.ArticleNumber))
                ) && 
                (
                    this.Gtin == input.Gtin ||
                    (this.Gtin != null &&
                    this.Gtin.Equals(input.Gtin))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Variant == input.Variant ||
                    (this.Variant != null &&
                    this.Variant.Equals(input.Variant))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.PriceIncVat == input.PriceIncVat ||
                    this.PriceIncVat.Equals(input.PriceIncVat)
                ) && 
                (
                    this.PriceExVat == input.PriceExVat ||
                    this.PriceExVat.Equals(input.PriceExVat)
                ) && 
                (
                    this.ExpectedTotalPriceIncVat == input.ExpectedTotalPriceIncVat ||
                    this.ExpectedTotalPriceIncVat.Equals(input.ExpectedTotalPriceIncVat)
                ) && 
                (
                    this.DiscountIncVat == input.DiscountIncVat ||
                    this.DiscountIncVat.Equals(input.DiscountIncVat)
                ) && 
                (
                    this.DiscountExVat == input.DiscountExVat ||
                    this.DiscountExVat.Equals(input.DiscountExVat)
                ) && 
                (
                    this.ExpectedTotalDiscountIncVat == input.ExpectedTotalDiscountIncVat ||
                    this.ExpectedTotalDiscountIncVat.Equals(input.ExpectedTotalDiscountIncVat)
                ) && 
                (
                    this.ProductUrl == input.ProductUrl ||
                    (this.ProductUrl != null &&
                    this.ProductUrl.Equals(input.ProductUrl))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.CampaignIds == input.CampaignIds ||
                    this.CampaignIds != null &&
                    input.CampaignIds != null &&
                    this.CampaignIds.SequenceEqual(input.CampaignIds)
                ) && 
                (
                    this.CampaignGroupData == input.CampaignGroupData ||
                    (this.CampaignGroupData != null &&
                    this.CampaignGroupData.Equals(input.CampaignGroupData))
                ) && 
                (
                    this.CampaignNames == input.CampaignNames ||
                    this.CampaignNames != null &&
                    input.CampaignNames != null &&
                    this.CampaignNames.SequenceEqual(input.CampaignNames)
                ) && 
                (
                    this.ProductPriceCampaignId == input.ProductPriceCampaignId ||
                    this.ProductPriceCampaignId.Equals(input.ProductPriceCampaignId)
                ) && 
                (
                    this.ProductPriceListId == input.ProductPriceListId ||
                    this.ProductPriceListId.Equals(input.ProductPriceListId)
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
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                if (this.ExternalId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DiscountRate.GetHashCode();
                hashCode = (hashCode * 59) + this.CartRowId.GetHashCode();
                hashCode = (hashCode * 59) + this.ProductContainerBuildId.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.ArticleNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ArticleNumber.GetHashCode();
                }
                if (this.Gtin != null)
                {
                    hashCode = (hashCode * 59) + this.Gtin.GetHashCode();
                }
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Variant != null)
                {
                    hashCode = (hashCode * 59) + this.Variant.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.PriceIncVat.GetHashCode();
                hashCode = (hashCode * 59) + this.PriceExVat.GetHashCode();
                hashCode = (hashCode * 59) + this.ExpectedTotalPriceIncVat.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountIncVat.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountExVat.GetHashCode();
                hashCode = (hashCode * 59) + this.ExpectedTotalDiscountIncVat.GetHashCode();
                if (this.ProductUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ProductUrl.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                hashCode = (hashCode * 59) + this.Width.GetHashCode();
                hashCode = (hashCode * 59) + this.Length.GetHashCode();
                if (this.CampaignIds != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignIds.GetHashCode();
                }
                if (this.CampaignGroupData != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignGroupData.GetHashCode();
                }
                if (this.CampaignNames != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignNames.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProductPriceCampaignId.GetHashCode();
                hashCode = (hashCode * 59) + this.ProductPriceListId.GetHashCode();
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
