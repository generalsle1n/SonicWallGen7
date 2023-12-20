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
    /// Configure SYN flood protection settings.
    /// </summary>
    [DataContract(Name = "dos_action_profile_syn_flood_protection")]
    public partial class DosActionProfileSynFloodProtection : IEquatable<DosActionProfileSynFloodProtection>, IValidatableObject
    {
        /// <summary>
        /// Configure SYN flood protection mode.
        /// </summary>
        /// <value>Configure SYN flood protection mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum WatchAndReport for value: watch-and-report
            /// </summary>
            [EnumMember(Value = "watch-and-report")]
            WatchAndReport = 1,

            /// <summary>
            /// Enum ProxySuspectAttack for value: proxy-suspect-attack
            /// </summary>
            [EnumMember(Value = "proxy-suspect-attack")]
            ProxySuspectAttack = 2,

            /// <summary>
            /// Enum AlwaysProxy for value: always-proxy
            /// </summary>
            [EnumMember(Value = "always-proxy")]
            AlwaysProxy = 3
        }


        /// <summary>
        /// Configure SYN flood protection mode.
        /// </summary>
        /// <value>Configure SYN flood protection mode.</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DosActionProfileSynFloodProtection" /> class.
        /// </summary>
        /// <param name="enable">Enable SYN Flood Protection..</param>
        /// <param name="mode">Configure SYN flood protection mode..</param>
        public DosActionProfileSynFloodProtection(bool enable = default(bool), ModeEnum? mode = default(ModeEnum?))
        {
            this.Enable = enable;
            this.Mode = mode;
        }

        /// <summary>
        /// Enable SYN Flood Protection.
        /// </summary>
        /// <value>Enable SYN Flood Protection.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DosActionProfileSynFloodProtection {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
            return this.Equals(input as DosActionProfileSynFloodProtection);
        }

        /// <summary>
        /// Returns true if DosActionProfileSynFloodProtection instances are equal
        /// </summary>
        /// <param name="input">Instance of DosActionProfileSynFloodProtection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DosActionProfileSynFloodProtection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
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
