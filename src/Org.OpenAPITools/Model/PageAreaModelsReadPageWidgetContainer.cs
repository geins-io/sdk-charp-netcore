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
    /// This class represents a collection of widgets, and defines how they should be layouted in the area they are rendered in.
    /// </summary>
    [DataContract(Name = "PageArea.Models.Read.PageWidgetContainer")]
    public partial class PageAreaModelsReadPageWidgetContainer : IEquatable<PageAreaModelsReadPageWidgetContainer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageAreaModelsReadPageWidgetContainer" /> class.
        /// </summary>
        /// <param name="id">The primary ID of this container.</param>
        /// <param name="name">The descriptive user defined name of this container, which is used to distinguish this container in a container library.</param>
        /// <param name="classNames">The CSS class names this container should use..</param>
        /// <param name="active">active.</param>
        /// <param name="layout">layout.</param>
        /// <param name="responsiveMode">responsiveMode.</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="design">design.</param>
        /// <param name="widgets">The configured widgets held by this container.</param>
        public PageAreaModelsReadPageWidgetContainer(int id = default(int), string name = default(string), List<string> classNames = default(List<string>), bool active = default(bool), string layout = default(string), string responsiveMode = default(string), string visibility = default(string), string design = default(string), List<PageAreaModelsReadPageWidget> widgets = default(List<PageAreaModelsReadPageWidget>))
        {
            this.Id = id;
            this.Name = name;
            this.ClassNames = classNames;
            this.Active = active;
            this.Layout = layout;
            this.ResponsiveMode = responsiveMode;
            this.Visibility = visibility;
            this.Design = design;
            this.Widgets = widgets;
        }

        /// <summary>
        /// The primary ID of this container
        /// </summary>
        /// <value>The primary ID of this container</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The descriptive user defined name of this container, which is used to distinguish this container in a container library
        /// </summary>
        /// <value>The descriptive user defined name of this container, which is used to distinguish this container in a container library</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The CSS class names this container should use.
        /// </summary>
        /// <value>The CSS class names this container should use.</value>
        [DataMember(Name = "ClassNames", EmitDefaultValue = false)]
        public List<string> ClassNames { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "Active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Layout
        /// </summary>
        [DataMember(Name = "Layout", EmitDefaultValue = false)]
        public string Layout { get; set; }

        /// <summary>
        /// Gets or Sets ResponsiveMode
        /// </summary>
        [DataMember(Name = "ResponsiveMode", EmitDefaultValue = false)]
        public string ResponsiveMode { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "Visibility", EmitDefaultValue = false)]
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or Sets Design
        /// </summary>
        [DataMember(Name = "Design", EmitDefaultValue = false)]
        public string Design { get; set; }

        /// <summary>
        /// The configured widgets held by this container
        /// </summary>
        /// <value>The configured widgets held by this container</value>
        [DataMember(Name = "Widgets", EmitDefaultValue = false)]
        public List<PageAreaModelsReadPageWidget> Widgets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageAreaModelsReadPageWidgetContainer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ClassNames: ").Append(ClassNames).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Layout: ").Append(Layout).Append("\n");
            sb.Append("  ResponsiveMode: ").Append(ResponsiveMode).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Design: ").Append(Design).Append("\n");
            sb.Append("  Widgets: ").Append(Widgets).Append("\n");
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
            return this.Equals(input as PageAreaModelsReadPageWidgetContainer);
        }

        /// <summary>
        /// Returns true if PageAreaModelsReadPageWidgetContainer instances are equal
        /// </summary>
        /// <param name="input">Instance of PageAreaModelsReadPageWidgetContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageAreaModelsReadPageWidgetContainer input)
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
                    this.ClassNames == input.ClassNames ||
                    this.ClassNames != null &&
                    input.ClassNames != null &&
                    this.ClassNames.SequenceEqual(input.ClassNames)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
                ) && 
                (
                    this.ResponsiveMode == input.ResponsiveMode ||
                    (this.ResponsiveMode != null &&
                    this.ResponsiveMode.Equals(input.ResponsiveMode))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.Design == input.Design ||
                    (this.Design != null &&
                    this.Design.Equals(input.Design))
                ) && 
                (
                    this.Widgets == input.Widgets ||
                    this.Widgets != null &&
                    input.Widgets != null &&
                    this.Widgets.SequenceEqual(input.Widgets)
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
                if (this.ClassNames != null)
                {
                    hashCode = (hashCode * 59) + this.ClassNames.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Layout != null)
                {
                    hashCode = (hashCode * 59) + this.Layout.GetHashCode();
                }
                if (this.ResponsiveMode != null)
                {
                    hashCode = (hashCode * 59) + this.ResponsiveMode.GetHashCode();
                }
                if (this.Visibility != null)
                {
                    hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                }
                if (this.Design != null)
                {
                    hashCode = (hashCode * 59) + this.Design.GetHashCode();
                }
                if (this.Widgets != null)
                {
                    hashCode = (hashCode * 59) + this.Widgets.GetHashCode();
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
