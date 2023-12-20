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
    /// user sso configuration.
    /// </summary>
    [DataContract(Name = "user_sso_radius_user_name_exclusion")]
    public partial class UserSsoRadiusUserNameExclusion : IEquatable<UserSsoRadiusUserNameExclusion>, IValidatableObject
    {
        /// <summary>
        /// type
        /// </summary>
        /// <value>type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Begin for value: begin
            /// </summary>
            [EnumMember(Value = "begin")]
            Begin = 1,

            /// <summary>
            /// Enum End for value: end
            /// </summary>
            [EnumMember(Value = "end")]
            End = 2
        }


        /// <summary>
        /// type
        /// </summary>
        /// <value>type</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoRadiusUserNameExclusion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSsoRadiusUserNameExclusion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoRadiusUserNameExclusion" /> class.
        /// </summary>
        /// <param name="name">user name (required).</param>
        /// <param name="type">type (required).</param>
        public UserSsoRadiusUserNameExclusion(string name = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UserSsoRadiusUserNameExclusion and cannot be null");
            }
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// user name
        /// </summary>
        /// <value>user name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSsoRadiusUserNameExclusion {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as UserSsoRadiusUserNameExclusion);
        }

        /// <summary>
        /// Returns true if UserSsoRadiusUserNameExclusion instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSsoRadiusUserNameExclusion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSsoRadiusUserNameExclusion input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
