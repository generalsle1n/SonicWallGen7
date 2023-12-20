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
    /// Enable trap of category. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "log_categories_trap")]
    public partial class LogCategoriesTrap : IEquatable<LogCategoriesTrap>, IValidatableObject
    {
        /// <summary>
        /// Type.
        /// </summary>
        /// <value>Type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Enabled for value: enabled
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled = 1,

            /// <summary>
            /// Enum Mixed for value: mixed
            /// </summary>
            [EnumMember(Value = "mixed")]
            Mixed = 2
        }


        /// <summary>
        /// Type.
        /// </summary>
        /// <value>Type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogCategoriesTrap" /> class.
        /// </summary>
        /// <param name="type">Type..</param>
        /// <param name="redundancyInterval">redundancyInterval.</param>
        public LogCategoriesTrap(TypeEnum? type = default(TypeEnum?), AppRulePolicyLogRedundancyIntervalInterval redundancyInterval = default(AppRulePolicyLogRedundancyIntervalInterval))
        {
            this.Type = type;
            this.RedundancyInterval = redundancyInterval;
        }

        /// <summary>
        /// Gets or Sets RedundancyInterval
        /// </summary>
        [DataMember(Name = "redundancy_interval", EmitDefaultValue = true)]
        public AppRulePolicyLogRedundancyIntervalInterval RedundancyInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogCategoriesTrap {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RedundancyInterval: ").Append(RedundancyInterval).Append("\n");
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
            return this.Equals(input as LogCategoriesTrap);
        }

        /// <summary>
        /// Returns true if LogCategoriesTrap instances are equal
        /// </summary>
        /// <param name="input">Instance of LogCategoriesTrap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogCategoriesTrap input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.RedundancyInterval == input.RedundancyInterval ||
                    (this.RedundancyInterval != null &&
                    this.RedundancyInterval.Equals(input.RedundancyInterval))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.RedundancyInterval != null)
                {
                    hashCode = (hashCode * 59) + this.RedundancyInterval.GetHashCode();
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
