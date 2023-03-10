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
    /// UserModelsWriteUserProfile
    /// </summary>
    [DataContract(Name = "User.Models.Write.UserProfile")]
    public partial class UserModelsWriteUserProfile : IEquatable<UserModelsWriteUserProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserModelsWriteUserProfile" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="siteId">siteId.</param>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="phoneNr">phoneNr.</param>
        /// <param name="mobilePhoneNr">mobilePhoneNr.</param>
        /// <param name="company">company.</param>
        /// <param name="userTypeId">userTypeId.</param>
        /// <param name="address">address.</param>
        /// <param name="address2">address2.</param>
        /// <param name="address3">address3.</param>
        /// <param name="doorCode">doorCode.</param>
        /// <param name="personalId">personalId.</param>
        /// <param name="birthyear">birthyear.</param>
        /// <param name="zip">zip.</param>
        /// <param name="city">city.</param>
        /// <param name="careOf">careOf.</param>
        /// <param name="country">country.</param>
        /// <param name="countryId">countryId.</param>
        /// <param name="gender">gender.</param>
        /// <param name="newsletter">Decides whether the user should be subscribed to the newsletter..</param>
        /// <param name="hasExternalAuth">Set this to true if the management platform will not be the main way of authentication..</param>
        public UserModelsWriteUserProfile(int userId = default(int), int siteId = default(int), string email = default(string), string password = default(string), string firstName = default(string), string lastName = default(string), string phoneNr = default(string), string mobilePhoneNr = default(string), string company = default(string), int userTypeId = default(int), string address = default(string), string address2 = default(string), string address3 = default(string), string doorCode = default(string), string personalId = default(string), string birthyear = default(string), string zip = default(string), string city = default(string), string careOf = default(string), string country = default(string), int countryId = default(int), bool gender = default(bool), bool newsletter = default(bool), bool hasExternalAuth = default(bool))
        {
            this.UserId = userId;
            this.SiteId = siteId;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNr = phoneNr;
            this.MobilePhoneNr = mobilePhoneNr;
            this.Company = company;
            this.UserTypeId = userTypeId;
            this.Address = address;
            this.Address2 = address2;
            this.Address3 = address3;
            this.DoorCode = doorCode;
            this.PersonalId = personalId;
            this.Birthyear = birthyear;
            this.Zip = zip;
            this.City = city;
            this.CareOf = careOf;
            this.Country = country;
            this.CountryId = countryId;
            this.Gender = gender;
            this.Newsletter = newsletter;
            this.HasExternalAuth = hasExternalAuth;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "UserId", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "SiteId", EmitDefaultValue = false)]
        public int SiteId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "Password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "FirstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "LastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNr
        /// </summary>
        [DataMember(Name = "PhoneNr", EmitDefaultValue = false)]
        public string PhoneNr { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhoneNr
        /// </summary>
        [DataMember(Name = "MobilePhoneNr", EmitDefaultValue = false)]
        public string MobilePhoneNr { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "Company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets UserTypeId
        /// </summary>
        [DataMember(Name = "UserTypeId", EmitDefaultValue = false)]
        public int UserTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "Address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets Address3
        /// </summary>
        [DataMember(Name = "Address3", EmitDefaultValue = false)]
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or Sets DoorCode
        /// </summary>
        [DataMember(Name = "DoorCode", EmitDefaultValue = false)]
        public string DoorCode { get; set; }

        /// <summary>
        /// Gets or Sets PersonalId
        /// </summary>
        [DataMember(Name = "PersonalId", EmitDefaultValue = false)]
        public string PersonalId { get; set; }

        /// <summary>
        /// Gets or Sets Birthyear
        /// </summary>
        [DataMember(Name = "Birthyear", EmitDefaultValue = false)]
        public string Birthyear { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "Zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CareOf
        /// </summary>
        [DataMember(Name = "CareOf", EmitDefaultValue = false)]
        public string CareOf { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name = "CountryId", EmitDefaultValue = false)]
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "Gender", EmitDefaultValue = true)]
        public bool Gender { get; set; }

        /// <summary>
        /// Decides whether the user should be subscribed to the newsletter.
        /// </summary>
        /// <value>Decides whether the user should be subscribed to the newsletter.</value>
        [DataMember(Name = "Newsletter", EmitDefaultValue = true)]
        public bool Newsletter { get; set; }

        /// <summary>
        /// Set this to true if the management platform will not be the main way of authentication.
        /// </summary>
        /// <value>Set this to true if the management platform will not be the main way of authentication.</value>
        [DataMember(Name = "HasExternalAuth", EmitDefaultValue = true)]
        public bool HasExternalAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserModelsWriteUserProfile {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNr: ").Append(PhoneNr).Append("\n");
            sb.Append("  MobilePhoneNr: ").Append(MobilePhoneNr).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  UserTypeId: ").Append(UserTypeId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  DoorCode: ").Append(DoorCode).Append("\n");
            sb.Append("  PersonalId: ").Append(PersonalId).Append("\n");
            sb.Append("  Birthyear: ").Append(Birthyear).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CareOf: ").Append(CareOf).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Newsletter: ").Append(Newsletter).Append("\n");
            sb.Append("  HasExternalAuth: ").Append(HasExternalAuth).Append("\n");
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
            return this.Equals(input as UserModelsWriteUserProfile);
        }

        /// <summary>
        /// Returns true if UserModelsWriteUserProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of UserModelsWriteUserProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserModelsWriteUserProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    this.SiteId.Equals(input.SiteId)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PhoneNr == input.PhoneNr ||
                    (this.PhoneNr != null &&
                    this.PhoneNr.Equals(input.PhoneNr))
                ) && 
                (
                    this.MobilePhoneNr == input.MobilePhoneNr ||
                    (this.MobilePhoneNr != null &&
                    this.MobilePhoneNr.Equals(input.MobilePhoneNr))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.UserTypeId == input.UserTypeId ||
                    this.UserTypeId.Equals(input.UserTypeId)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.Address3 == input.Address3 ||
                    (this.Address3 != null &&
                    this.Address3.Equals(input.Address3))
                ) && 
                (
                    this.DoorCode == input.DoorCode ||
                    (this.DoorCode != null &&
                    this.DoorCode.Equals(input.DoorCode))
                ) && 
                (
                    this.PersonalId == input.PersonalId ||
                    (this.PersonalId != null &&
                    this.PersonalId.Equals(input.PersonalId))
                ) && 
                (
                    this.Birthyear == input.Birthyear ||
                    (this.Birthyear != null &&
                    this.Birthyear.Equals(input.Birthyear))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CareOf == input.CareOf ||
                    (this.CareOf != null &&
                    this.CareOf.Equals(input.CareOf))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    this.CountryId.Equals(input.CountryId)
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.Newsletter == input.Newsletter ||
                    this.Newsletter.Equals(input.Newsletter)
                ) && 
                (
                    this.HasExternalAuth == input.HasExternalAuth ||
                    this.HasExternalAuth.Equals(input.HasExternalAuth)
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
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                hashCode = (hashCode * 59) + this.SiteId.GetHashCode();
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.PhoneNr != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNr.GetHashCode();
                }
                if (this.MobilePhoneNr != null)
                {
                    hashCode = (hashCode * 59) + this.MobilePhoneNr.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserTypeId.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Address2 != null)
                {
                    hashCode = (hashCode * 59) + this.Address2.GetHashCode();
                }
                if (this.Address3 != null)
                {
                    hashCode = (hashCode * 59) + this.Address3.GetHashCode();
                }
                if (this.DoorCode != null)
                {
                    hashCode = (hashCode * 59) + this.DoorCode.GetHashCode();
                }
                if (this.PersonalId != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalId.GetHashCode();
                }
                if (this.Birthyear != null)
                {
                    hashCode = (hashCode * 59) + this.Birthyear.GetHashCode();
                }
                if (this.Zip != null)
                {
                    hashCode = (hashCode * 59) + this.Zip.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.CareOf != null)
                {
                    hashCode = (hashCode * 59) + this.CareOf.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CountryId.GetHashCode();
                hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                hashCode = (hashCode * 59) + this.Newsletter.GetHashCode();
                hashCode = (hashCode * 59) + this.HasExternalAuth.GetHashCode();
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
