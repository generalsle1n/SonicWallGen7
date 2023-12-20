/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
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
using OpenAPIDateConverter = SonicWallGen7.Client.OpenAPIDateConverter;

namespace SonicWallGen7.Model
{
    /// <summary>
    /// User name attribute format.
    /// </summary>
    [DataContract(Name = "user_sso_radius_accounting_client_custom_format_components")]
    public partial class UserSsoRadiusAccountingClientCustomFormatComponents : IEquatable<UserSsoRadiusAccountingClientCustomFormatComponents>, IValidatableObject
    {
        /// <summary>
        /// first component.
        /// </summary>
        /// <value>first component.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Component1Enum
        {
            /// <summary>
            /// Enum NotUse for value: not-use
            /// </summary>
            [EnumMember(Value = "not-use")]
            NotUse = 1,

            /// <summary>
            /// Enum UserName for value: user-name
            /// </summary>
            [EnumMember(Value = "user-name")]
            UserName = 2,

            /// <summary>
            /// Enum Domain for value: domain
            /// </summary>
            [EnumMember(Value = "domain")]
            Domain = 3,

            /// <summary>
            /// Enum Dn for value: dn
            /// </summary>
            [EnumMember(Value = "dn")]
            Dn = 4
        }


        /// <summary>
        /// first component.
        /// </summary>
        /// <value>first component.</value>
        [DataMember(Name = "component1", EmitDefaultValue = false)]
        public Component1Enum? Component1 { get; set; }
        /// <summary>
        /// second component.
        /// </summary>
        /// <value>second component.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Component2Enum
        {
            /// <summary>
            /// Enum NotUse for value: not-use
            /// </summary>
            [EnumMember(Value = "not-use")]
            NotUse = 1,

            /// <summary>
            /// Enum UserName for value: user-name
            /// </summary>
            [EnumMember(Value = "user-name")]
            UserName = 2,

            /// <summary>
            /// Enum Domain for value: domain
            /// </summary>
            [EnumMember(Value = "domain")]
            Domain = 3,

            /// <summary>
            /// Enum Dn for value: dn
            /// </summary>
            [EnumMember(Value = "dn")]
            Dn = 4
        }


        /// <summary>
        /// second component.
        /// </summary>
        /// <value>second component.</value>
        [DataMember(Name = "component2", EmitDefaultValue = false)]
        public Component2Enum? Component2 { get; set; }
        /// <summary>
        /// third component.
        /// </summary>
        /// <value>third component.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Component3Enum
        {
            /// <summary>
            /// Enum NotUse for value: not-use
            /// </summary>
            [EnumMember(Value = "not-use")]
            NotUse = 1,

            /// <summary>
            /// Enum UserName for value: user-name
            /// </summary>
            [EnumMember(Value = "user-name")]
            UserName = 2,

            /// <summary>
            /// Enum Domain for value: domain
            /// </summary>
            [EnumMember(Value = "domain")]
            Domain = 3,

            /// <summary>
            /// Enum Dn for value: dn
            /// </summary>
            [EnumMember(Value = "dn")]
            Dn = 4
        }


        /// <summary>
        /// third component.
        /// </summary>
        /// <value>third component.</value>
        [DataMember(Name = "component3", EmitDefaultValue = false)]
        public Component3Enum? Component3 { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoRadiusAccountingClientCustomFormatComponents" /> class.
        /// </summary>
        /// <param name="component1">first component..</param>
        /// <param name="component2">second component..</param>
        /// <param name="component3">third component..</param>
        public UserSsoRadiusAccountingClientCustomFormatComponents(Component1Enum? component1 = default(Component1Enum?), Component2Enum? component2 = default(Component2Enum?), Component3Enum? component3 = default(Component3Enum?))
        {
            this.Component1 = component1;
            this.Component2 = component2;
            this.Component3 = component3;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSsoRadiusAccountingClientCustomFormatComponents {\n");
            sb.Append("  Component1: ").Append(Component1).Append("\n");
            sb.Append("  Component2: ").Append(Component2).Append("\n");
            sb.Append("  Component3: ").Append(Component3).Append("\n");
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
            return this.Equals(input as UserSsoRadiusAccountingClientCustomFormatComponents);
        }

        /// <summary>
        /// Returns true if UserSsoRadiusAccountingClientCustomFormatComponents instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSsoRadiusAccountingClientCustomFormatComponents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSsoRadiusAccountingClientCustomFormatComponents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Component1 == input.Component1 ||
                    this.Component1.Equals(input.Component1)
                ) && 
                (
                    this.Component2 == input.Component2 ||
                    this.Component2.Equals(input.Component2)
                ) && 
                (
                    this.Component3 == input.Component3 ||
                    this.Component3.Equals(input.Component3)
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
                hashCode = (hashCode * 59) + this.Component1.GetHashCode();
                hashCode = (hashCode * 59) + this.Component2.GetHashCode();
                hashCode = (hashCode * 59) + this.Component3.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
