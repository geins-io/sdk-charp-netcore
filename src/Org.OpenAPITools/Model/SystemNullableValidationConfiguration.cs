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
    /// SystemNullableValidationConfiguration
    /// </summary>
    [DataContract(Name = "System.Nullable-ValidationConfiguration")]
    public partial class SystemNullableValidationConfiguration : IEquatable<SystemNullableValidationConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemNullableValidationConfiguration" /> class.
        /// </summary>
        /// <param name="lazyLoadConfiguration">lazyLoadConfiguration.</param>
        /// <param name="lazyLoadCollectionConfigurations">lazyLoadCollectionConfigurations.</param>
        /// <param name="widgetRestrictions">widgetRestrictions.</param>
        /// <param name="containerRestrictions">containerRestrictions.</param>
        public SystemNullableValidationConfiguration(PageWidgetLazyLoadSetupLazyLoadConfiguration lazyLoadConfiguration = default(PageWidgetLazyLoadSetupLazyLoadConfiguration), List<PageWidgetLazyLoadSetupLazyLoadCollectionConfiguration> lazyLoadCollectionConfigurations = default(List<PageWidgetLazyLoadSetupLazyLoadCollectionConfiguration>), Dictionary<string, WidgetRestrictionSetupWidgetRestrictionConfiguration> widgetRestrictions = default(Dictionary<string, WidgetRestrictionSetupWidgetRestrictionConfiguration>), ContainerRestrictionSetupContainerRestrictionConfiguration containerRestrictions = default(ContainerRestrictionSetupContainerRestrictionConfiguration))
        {
            this.LazyLoadConfiguration = lazyLoadConfiguration;
            this.LazyLoadCollectionConfigurations = lazyLoadCollectionConfigurations;
            this.WidgetRestrictions = widgetRestrictions;
            this.ContainerRestrictions = containerRestrictions;
        }

        /// <summary>
        /// Gets or Sets LazyLoadConfiguration
        /// </summary>
        [DataMember(Name = "LazyLoadConfiguration", EmitDefaultValue = false)]
        public PageWidgetLazyLoadSetupLazyLoadConfiguration LazyLoadConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets LazyLoadCollectionConfigurations
        /// </summary>
        [DataMember(Name = "LazyLoadCollectionConfigurations", EmitDefaultValue = false)]
        public List<PageWidgetLazyLoadSetupLazyLoadCollectionConfiguration> LazyLoadCollectionConfigurations { get; set; }

        /// <summary>
        /// Gets or Sets WidgetRestrictions
        /// </summary>
        [DataMember(Name = "WidgetRestrictions", EmitDefaultValue = false)]
        public Dictionary<string, WidgetRestrictionSetupWidgetRestrictionConfiguration> WidgetRestrictions { get; set; }

        /// <summary>
        /// Gets or Sets ContainerRestrictions
        /// </summary>
        [DataMember(Name = "ContainerRestrictions", EmitDefaultValue = false)]
        public ContainerRestrictionSetupContainerRestrictionConfiguration ContainerRestrictions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemNullableValidationConfiguration {\n");
            sb.Append("  LazyLoadConfiguration: ").Append(LazyLoadConfiguration).Append("\n");
            sb.Append("  LazyLoadCollectionConfigurations: ").Append(LazyLoadCollectionConfigurations).Append("\n");
            sb.Append("  WidgetRestrictions: ").Append(WidgetRestrictions).Append("\n");
            sb.Append("  ContainerRestrictions: ").Append(ContainerRestrictions).Append("\n");
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
            return this.Equals(input as SystemNullableValidationConfiguration);
        }

        /// <summary>
        /// Returns true if SystemNullableValidationConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemNullableValidationConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemNullableValidationConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LazyLoadConfiguration == input.LazyLoadConfiguration ||
                    (this.LazyLoadConfiguration != null &&
                    this.LazyLoadConfiguration.Equals(input.LazyLoadConfiguration))
                ) && 
                (
                    this.LazyLoadCollectionConfigurations == input.LazyLoadCollectionConfigurations ||
                    this.LazyLoadCollectionConfigurations != null &&
                    input.LazyLoadCollectionConfigurations != null &&
                    this.LazyLoadCollectionConfigurations.SequenceEqual(input.LazyLoadCollectionConfigurations)
                ) && 
                (
                    this.WidgetRestrictions == input.WidgetRestrictions ||
                    this.WidgetRestrictions != null &&
                    input.WidgetRestrictions != null &&
                    this.WidgetRestrictions.SequenceEqual(input.WidgetRestrictions)
                ) && 
                (
                    this.ContainerRestrictions == input.ContainerRestrictions ||
                    (this.ContainerRestrictions != null &&
                    this.ContainerRestrictions.Equals(input.ContainerRestrictions))
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
                if (this.LazyLoadConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.LazyLoadConfiguration.GetHashCode();
                }
                if (this.LazyLoadCollectionConfigurations != null)
                {
                    hashCode = (hashCode * 59) + this.LazyLoadCollectionConfigurations.GetHashCode();
                }
                if (this.WidgetRestrictions != null)
                {
                    hashCode = (hashCode * 59) + this.WidgetRestrictions.GetHashCode();
                }
                if (this.ContainerRestrictions != null)
                {
                    hashCode = (hashCode * 59) + this.ContainerRestrictions.GetHashCode();
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
