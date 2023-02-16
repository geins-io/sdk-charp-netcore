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
    [DataContract(Name = "Variant.Models.Write.VariantGroup")]
    public partial class VariantModelsWriteVariantGroup : IEquatable<VariantModelsWriteVariantGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariantModelsWriteVariantGroup" /> class.
        /// </summary>
        /// <param name="name">The optional internal name of the variant group..</param>
        /// <param name="collapseInLists">A setting to control the display behaviour in product listings of variants belonging to this group..</param>
        /// <param name="variantLabels">The labels of the variant data that this group keeps track of.</param>
        /// <param name="products">Products to be created and connected to the group..</param>
        public VariantModelsWriteVariantGroup(string name = default(string), bool collapseInLists = default(bool), List<string> variantLabels = default(List<string>), List<ProductModelsWriteProduct> products = default(List<ProductModelsWriteProduct>))
        {
            this.Name = name;
            this.CollapseInLists = collapseInLists;
            this.VariantLabels = variantLabels;
            this.Products = products;
        }

        /// <summary>
        /// The optional internal name of the variant group.
        /// </summary>
        /// <value>The optional internal name of the variant group.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A setting to control the display behaviour in product listings of variants belonging to this group.
        /// </summary>
        /// <value>A setting to control the display behaviour in product listings of variants belonging to this group.</value>
        [DataMember(Name = "CollapseInLists", EmitDefaultValue = true)]
        public bool CollapseInLists { get; set; }

        /// <summary>
        /// The labels of the variant data that this group keeps track of
        /// </summary>
        /// <value>The labels of the variant data that this group keeps track of</value>
        [DataMember(Name = "VariantLabels", EmitDefaultValue = false)]
        public List<string> VariantLabels { get; set; }

        /// <summary>
        /// Products to be created and connected to the group.
        /// </summary>
        /// <value>Products to be created and connected to the group.</value>
        [DataMember(Name = "Products", EmitDefaultValue = false)]
        public List<ProductModelsWriteProduct> Products { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VariantModelsWriteVariantGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CollapseInLists: ").Append(CollapseInLists).Append("\n");
            sb.Append("  VariantLabels: ").Append(VariantLabels).Append("\n");
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
            return this.Equals(input as VariantModelsWriteVariantGroup);
        }

        /// <summary>
        /// Returns true if VariantModelsWriteVariantGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of VariantModelsWriteVariantGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariantModelsWriteVariantGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.VariantLabels == input.VariantLabels ||
                    this.VariantLabels != null &&
                    input.VariantLabels != null &&
                    this.VariantLabels.SequenceEqual(input.VariantLabels)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CollapseInLists.GetHashCode();
                if (this.VariantLabels != null)
                {
                    hashCode = (hashCode * 59) + this.VariantLabels.GetHashCode();
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
