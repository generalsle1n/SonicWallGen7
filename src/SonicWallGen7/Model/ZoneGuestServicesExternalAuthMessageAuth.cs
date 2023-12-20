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
    /// External message authentication.
    /// </summary>
    [DataContract(Name = "zone_guest_services_external_auth_message_auth")]
    public partial class ZoneGuestServicesExternalAuthMessageAuth : IEquatable<ZoneGuestServicesExternalAuthMessageAuth>, IValidatableObject
    {
        /// <summary>
        /// Set external message authentication method.
        /// </summary>
        /// <value>Set external message authentication method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum Md5 for value: md5
            /// </summary>
            [EnumMember(Value = "md5")]
            Md5 = 1,

            /// <summary>
            /// Enum Sha1 for value: sha1
            /// </summary>
            [EnumMember(Value = "sha1")]
            Sha1 = 2,

            /// <summary>
            /// Enum Sha256 for value: sha256
            /// </summary>
            [EnumMember(Value = "sha256")]
            Sha256 = 3
        }


        /// <summary>
        /// Set external message authentication method.
        /// </summary>
        /// <value>Set external message authentication method.</value>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneGuestServicesExternalAuthMessageAuth" /> class.
        /// </summary>
        /// <param name="method">Set external message authentication method..</param>
        /// <param name="sharedSecret">Set external message authentication shared secret..</param>
        /// <param name="confirmSecret">Confirm external message authentication shared secret..</param>
        /// <param name="enable">Enable external message authentication..</param>
        public ZoneGuestServicesExternalAuthMessageAuth(MethodEnum? method = default(MethodEnum?), string sharedSecret = default(string), string confirmSecret = default(string), bool enable = default(bool))
        {
            this.Method = method;
            this.SharedSecret = sharedSecret;
            this.ConfirmSecret = confirmSecret;
            this.Enable = enable;
        }

        /// <summary>
        /// Set external message authentication shared secret.
        /// </summary>
        /// <value>Set external message authentication shared secret.</value>
        [DataMember(Name = "shared_secret", EmitDefaultValue = false)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Confirm external message authentication shared secret.
        /// </summary>
        /// <value>Confirm external message authentication shared secret.</value>
        [DataMember(Name = "confirm_secret", EmitDefaultValue = false)]
        public string ConfirmSecret { get; set; }

        /// <summary>
        /// Enable external message authentication.
        /// </summary>
        /// <value>Enable external message authentication.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZoneGuestServicesExternalAuthMessageAuth {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
            sb.Append("  ConfirmSecret: ").Append(ConfirmSecret).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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
            return this.Equals(input as ZoneGuestServicesExternalAuthMessageAuth);
        }

        /// <summary>
        /// Returns true if ZoneGuestServicesExternalAuthMessageAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneGuestServicesExternalAuthMessageAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneGuestServicesExternalAuthMessageAuth input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Method == input.Method ||
                    this.Method.Equals(input.Method)
                ) && 
                (
                    this.SharedSecret == input.SharedSecret ||
                    (this.SharedSecret != null &&
                    this.SharedSecret.Equals(input.SharedSecret))
                ) && 
                (
                    this.ConfirmSecret == input.ConfirmSecret ||
                    (this.ConfirmSecret != null &&
                    this.ConfirmSecret.Equals(input.ConfirmSecret))
                ) && 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
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
                hashCode = (hashCode * 59) + this.Method.GetHashCode();
                if (this.SharedSecret != null)
                {
                    hashCode = (hashCode * 59) + this.SharedSecret.GetHashCode();
                }
                if (this.ConfirmSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmSecret.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
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