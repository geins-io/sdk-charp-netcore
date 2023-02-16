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
    /// ContainerRestrictionSetupContainerRestrictionConfiguration
    /// </summary>
    [DataContract(Name = "ContainerRestrictionSetup.ContainerRestrictionConfiguration")]
    public partial class ContainerRestrictionSetupContainerRestrictionConfiguration : IEquatable<ContainerRestrictionSetupContainerRestrictionConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Defines AllowedLayouts
        /// </summary>
        public enum AllowedLayoutsEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6,

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            NUMBER_7 = 7,

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            NUMBER_8 = 8

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRestrictionSetupContainerRestrictionConfiguration" /> class.
        /// </summary>
        /// <param name="allowedLayouts">allowedLayouts.</param>
        /// <param name="bannedWidgets">bannedWidgets.</param>
        public ContainerRestrictionSetupContainerRestrictionConfiguration(List<AllowedLayoutsEnum> allowedLayouts = default(List<AllowedLayoutsEnum>), List<Guid> bannedWidgets = default(List<Guid>))
        {
            this.AllowedLayouts = allowedLayouts;
            this.BannedWidgets = bannedWidgets;
        }

        /// <summary>
        /// Gets or Sets AllowedLayouts
        /// </summary>
        [DataMember(Name = "AllowedLayouts", EmitDefaultValue = false)]
        public List<ContainerRestrictionSetupContainerRestrictionConfiguration.AllowedLayoutsEnum> AllowedLayouts { get; set; }

        /// <summary>
        /// Gets or Sets BannedWidgets
        /// </summary>
        [DataMember(Name = "BannedWidgets", EmitDefaultValue = false)]
        public List<Guid> BannedWidgets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContainerRestrictionSetupContainerRestrictionConfiguration {\n");
            sb.Append("  AllowedLayouts: ").Append(AllowedLayouts).Append("\n");
            sb.Append("  BannedWidgets: ").Append(BannedWidgets).Append("\n");
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
            return this.Equals(input as ContainerRestrictionSetupContainerRestrictionConfiguration);
        }

        /// <summary>
        /// Returns true if ContainerRestrictionSetupContainerRestrictionConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerRestrictionSetupContainerRestrictionConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerRestrictionSetupContainerRestrictionConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowedLayouts == input.AllowedLayouts ||
                    this.AllowedLayouts != null &&
                    input.AllowedLayouts != null &&
                    this.AllowedLayouts.SequenceEqual(input.AllowedLayouts)
                ) && 
                (
                    this.BannedWidgets == input.BannedWidgets ||
                    this.BannedWidgets != null &&
                    input.BannedWidgets != null &&
                    this.BannedWidgets.SequenceEqual(input.BannedWidgets)
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
                if (this.AllowedLayouts != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedLayouts.GetHashCode();
                }
                if (this.BannedWidgets != null)
                {
                    hashCode = (hashCode * 59) + this.BannedWidgets.GetHashCode();
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