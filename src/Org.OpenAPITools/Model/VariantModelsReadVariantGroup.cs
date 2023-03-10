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
    /// A variant group for a collection of related variants.
    /// </summary>
    [DataContract(Name = "Variant.Models.Read.VariantGroup")]
    public partial class VariantModelsReadVariantGroup : IEquatable<VariantModelsReadVariantGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariantModelsReadVariantGroup" /> class.
        /// </summary>
        /// <param name="groupId">The id of variant goup..</param>
        /// <param name="name">The optional internal name of the variant group..</param>
        /// <param name="collapseInLists">Determine visibility of non-main products of this group in lists..</param>
        /// <param name="mainProductId">The main product of this group. If the group is collapsed in lists, this will be the only visible product..</param>
        /// <param name="productIds">The product ids of the variants that belong to this group..</param>
        /// <param name="products">Products belonging to the Variant group. Only included when parameter \&quot;include\&quot; is supplied in the query string.</param>
        public VariantModelsReadVariantGroup(int groupId = default(int), string name = default(string), bool collapseInLists = default(bool), int mainProductId = default(int), List<int> productIds = default(List<int>), List<ProductModelsReadProduct> products = default(List<ProductModelsReadProduct>))
        {
            this.GroupId = groupId;
            this.Name = name;
            this.CollapseInLists = collapseInLists;
            this.MainProductId = mainProductId;
            this.ProductIds = productIds;
            this.Products = products;
        }

        /// <summary>
        /// The id of variant goup.
        /// </summary>
        /// <value>The id of variant goup.</value>
        [DataMember(Name = "GroupId", EmitDefaultValue = false)]
        public int GroupId { get; set; }

        /// <summary>
        /// The optional internal name of the variant group.
        /// </summary>
        /// <value>The optional internal name of the variant group.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Determine visibility of non-main products of this group in lists.
        /// </summary>
        /// <value>Determine visibility of non-main products of this group in lists.</value>
        [DataMember(Name = "CollapseInLists", EmitDefaultValue = true)]
        public bool CollapseInLists { get; set; }

        /// <summary>
        /// The main product of this group. If the group is collapsed in lists, this will be the only visible product.
        /// </summary>
        /// <value>The main product of this group. If the group is collapsed in lists, this will be the only visible product.</value>
        [DataMember(Name = "MainProductId", EmitDefaultValue = false)]
        public int MainProductId { get; set; }

        /// <summary>
        /// The product ids of the variants that belong to this group.
        /// </summary>
        /// <value>The product ids of the variants that belong to this group.</value>
        [DataMember(Name = "ProductIds", EmitDefaultValue = false)]
        public List<int> ProductIds { get; set; }

        /// <summary>
        /// Products belonging to the Variant group. Only included when parameter \&quot;include\&quot; is supplied in the query string
        /// </summary>
        /// <value>Products belonging to the Variant group. Only included when parameter \&quot;include\&quot; is supplied in the query string</value>
        [DataMember(Name = "Products", EmitDefaultValue = false)]
        public List<ProductModelsReadProduct> Products { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VariantModelsReadVariantGroup {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CollapseInLists: ").Append(CollapseInLists).Append("\n");
            sb.Append("  MainProductId: ").Append(MainProductId).Append("\n");
            sb.Append("  ProductIds: ").Append(ProductIds).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
            return this.Equals(input as VariantModelsReadVariantGroup);
        }

        /// <summary>
        /// Returns true if VariantModelsReadVariantGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of VariantModelsReadVariantGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariantModelsReadVariantGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupId == input.GroupId ||
                    this.GroupId.Equals(input.GroupId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CollapseInLists == input.CollapseInLists ||
                    this.CollapseInLists.Equals(input.CollapseInLists)
                ) && 
                (
                    this.MainProductId == input.MainProductId ||
                    this.MainProductId.Equals(input.MainProductId)
                ) && 
                (
                    this.ProductIds == input.ProductIds ||
                    this.ProductIds != null &&
                    input.ProductIds != null &&
                    this.ProductIds.SequenceEqual(input.ProductIds)
                ) && 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
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
                hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CollapseInLists.GetHashCode();
                hashCode = (hashCode * 59) + this.MainProductId.GetHashCode();
                if (this.ProductIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProductIds.GetHashCode();
                }
                if (this.Products != null)
                {
                    hashCode = (hashCode * 59) + this.Products.GetHashCode();
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
