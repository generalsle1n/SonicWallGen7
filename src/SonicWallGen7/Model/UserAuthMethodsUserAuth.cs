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
    /// Configure user authentication related settings.
    /// </summary>
    [DataContract(Name = "user_auth_methods_user_auth")]
    public partial class UserAuthMethodsUserAuth : IEquatable<UserAuthMethodsUserAuth>, IValidatableObject
    {
        /// <summary>
        /// Set the user authentication method.
        /// </summary>
        /// <value>Set the user authentication method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthMethodEnum
        {
            /// <summary>
            /// Enum Local for value: local
            /// </summary>
            [EnumMember(Value = "local")]
            Local = 1,

            /// <summary>
            /// Enum Radius for value: radius
            /// </summary>
            [EnumMember(Value = "radius")]
            Radius = 2,

            /// <summary>
            /// Enum RadiusLocal for value: radius-local
            /// </summary>
            [EnumMember(Value = "radius-local")]
            RadiusLocal = 3,

            /// <summary>
            /// Enum Tacacs for value: tacacs
            /// </summary>
            [EnumMember(Value = "tacacs")]
            Tacacs = 4,

            /// <summary>
            /// Enum TacacsLocal for value: tacacs-local
            /// </summary>
            [EnumMember(Value = "tacacs-local")]
            TacacsLocal = 5,

            /// <summary>
            /// Enum Ldap for value: ldap
            /// </summary>
            [EnumMember(Value = "ldap")]
            Ldap = 6,

            /// <summary>
            /// Enum LdapLocal for value: ldap-local
            /// </summary>
            [EnumMember(Value = "ldap-local")]
            LdapLocal = 7
        }


        /// <summary>
        /// Set the user authentication method.
        /// </summary>
        /// <value>Set the user authentication method.</value>
        [DataMember(Name = "auth_method", EmitDefaultValue = false)]
        public AuthMethodEnum? AuthMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthMethodsUserAuth" /> class.
        /// </summary>
        /// <param name="authMethod">Set the user authentication method..</param>
        /// <param name="ssoMethod">ssoMethod.</param>
        /// <param name="partition">Set the user authentication method for the select partition..</param>
        public UserAuthMethodsUserAuth(AuthMethodEnum? authMethod = default(AuthMethodEnum?), UserAuthMethodsUserAuthSsoMethod ssoMethod = default(UserAuthMethodsUserAuthSsoMethod), List<UserAuthMethodsUserAuthPartitionInner> partition = default(List<UserAuthMethodsUserAuthPartitionInner>))
        {
            this.AuthMethod = authMethod;
            this.SsoMethod = ssoMethod;
            this.Partition = partition;
        }

        /// <summary>
        /// Gets or Sets SsoMethod
        /// </summary>
        [DataMember(Name = "sso_method", EmitDefaultValue = false)]
        public UserAuthMethodsUserAuthSsoMethod SsoMethod { get; set; }

        /// <summary>
        /// Set the user authentication method for the select partition.
        /// </summary>
        /// <value>Set the user authentication method for the select partition.</value>
        [DataMember(Name = "partition", EmitDefaultValue = false)]
        public List<UserAuthMethodsUserAuthPartitionInner> Partition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAuthMethodsUserAuth {\n");
            sb.Append("  AuthMethod: ").Append(AuthMethod).Append("\n");
            sb.Append("  SsoMethod: ").Append(SsoMethod).Append("\n");
            sb.Append("  Partition: ").Append(Partition).Append("\n");
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
            return this.Equals(input as UserAuthMethodsUserAuth);
        }

        /// <summary>
        /// Returns true if UserAuthMethodsUserAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAuthMethodsUserAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthMethodsUserAuth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthMethod == input.AuthMethod ||
                    this.AuthMethod.Equals(input.AuthMethod)
                ) && 
                (
                    this.SsoMethod == input.SsoMethod ||
                    (this.SsoMethod != null &&
                    this.SsoMethod.Equals(input.SsoMethod))
                ) && 
                (
                    this.Partition == input.Partition ||
                    this.Partition != null &&
                    input.Partition != null &&
                    this.Partition.SequenceEqual(input.Partition)
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
                hashCode = (hashCode * 59) + this.AuthMethod.GetHashCode();
                if (this.SsoMethod != null)
                {
                    hashCode = (hashCode * 59) + this.SsoMethod.GetHashCode();
                }
                if (this.Partition != null)
                {
                    hashCode = (hashCode * 59) + this.Partition.GetHashCode();
                }
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
