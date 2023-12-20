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
    /// SecurityActionProfilesQualityOfServiceClassOfServiceExplicit
    /// </summary>
    [DataContract(Name = "security_action_profiles_quality_of_service_class_of_service_explicit")]
    public partial class SecurityActionProfilesQualityOfServiceClassOfServiceExplicit : IEquatable<SecurityActionProfilesQualityOfServiceClassOfServiceExplicit>, IValidatableObject
    {
        /// <summary>
        /// Set explicit marking.
        /// </summary>
        /// <value>Set explicit marking.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExplicitEnum
        {
            /// <summary>
            /// Enum BestEffort for value: best-effort
            /// </summary>
            [EnumMember(Value = "best-effort")]
            BestEffort = 1,

            /// <summary>
            /// Enum Background for value: background
            /// </summary>
            [EnumMember(Value = "background")]
            Background = 2,

            /// <summary>
            /// Enum Spare for value: spare
            /// </summary>
            [EnumMember(Value = "spare")]
            Spare = 3,

            /// <summary>
            /// Enum ExcellentEffort for value: excellent-effort
            /// </summary>
            [EnumMember(Value = "excellent-effort")]
            ExcellentEffort = 4,

            /// <summary>
            /// Enum ControlledLoad for value: controlled-load
            /// </summary>
            [EnumMember(Value = "controlled-load")]
            ControlledLoad = 5,

            /// <summary>
            /// Enum Video for value: video
            /// </summary>
            [EnumMember(Value = "video")]
            Video = 6,

            /// <summary>
            /// Enum Voice for value: voice
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice = 7,

            /// <summary>
            /// Enum NetworkControl for value: network-control
            /// </summary>
            [EnumMember(Value = "network-control")]
            NetworkControl = 8
        }


        /// <summary>
        /// Set explicit marking.
        /// </summary>
        /// <value>Set explicit marking.</value>
        [DataMember(Name = "explicit", EmitDefaultValue = false)]
        public ExplicitEnum? VarExplicit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityActionProfilesQualityOfServiceClassOfServiceExplicit" /> class.
        /// </summary>
        /// <param name="varExplicit">Set explicit marking..</param>
        public SecurityActionProfilesQualityOfServiceClassOfServiceExplicit(ExplicitEnum? varExplicit = default(ExplicitEnum?))
        {
            this.VarExplicit = varExplicit;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityActionProfilesQualityOfServiceClassOfServiceExplicit {\n");
            sb.Append("  VarExplicit: ").Append(VarExplicit).Append("\n");
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
            return this.Equals(input as SecurityActionProfilesQualityOfServiceClassOfServiceExplicit);
        }

        /// <summary>
        /// Returns true if SecurityActionProfilesQualityOfServiceClassOfServiceExplicit instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityActionProfilesQualityOfServiceClassOfServiceExplicit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityActionProfilesQualityOfServiceClassOfServiceExplicit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarExplicit == input.VarExplicit ||
                    this.VarExplicit.Equals(input.VarExplicit)
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
                hashCode = (hashCode * 59) + this.VarExplicit.GetHashCode();
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
