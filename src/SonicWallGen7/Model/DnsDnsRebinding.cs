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
    /// Enable and configure DNS rebinding attack prevention.
    /// </summary>
    [DataContract(Name = "dns_dns_rebinding")]
    public partial class DnsDnsRebinding : IEquatable<DnsDnsRebinding>, IValidatableObject
    {
        /// <summary>
        /// Set action when experiencing attack.
        /// </summary>
        /// <value>Set action when experiencing attack.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum LogAttackOnly for value: log-attack-only
            /// </summary>
            [EnumMember(Value = "log-attack-only")]
            LogAttackOnly = 1,

            /// <summary>
            /// Enum ReturnQueryRefused for value: return-query-refused
            /// </summary>
            [EnumMember(Value = "return-query-refused")]
            ReturnQueryRefused = 2,

            /// <summary>
            /// Enum DropDnsReply for value: drop-dns-reply
            /// </summary>
            [EnumMember(Value = "drop-dns-reply")]
            DropDnsReply = 3
        }


        /// <summary>
        /// Set action when experiencing attack.
        /// </summary>
        /// <value>Set action when experiencing attack.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DnsDnsRebinding" /> class.
        /// </summary>
        /// <param name="enable">Enable DNS rebinding attack prevention..</param>
        /// <param name="action">Set action when experiencing attack..</param>
        /// <param name="allowedDomains">allowedDomains.</param>
        public DnsDnsRebinding(bool enable = default(bool), ActionEnum? action = default(ActionEnum?), DnsDnsRebindingAllowedDomains allowedDomains = default(DnsDnsRebindingAllowedDomains))
        {
            this.Enable = enable;
            this.Action = action;
            this.AllowedDomains = allowedDomains;
        }

        /// <summary>
        /// Enable DNS rebinding attack prevention.
        /// </summary>
        /// <value>Enable DNS rebinding attack prevention.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets AllowedDomains
        /// </summary>
        [DataMember(Name = "allowed_domains", EmitDefaultValue = false)]
        public DnsDnsRebindingAllowedDomains AllowedDomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DnsDnsRebinding {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
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
            return this.Equals(input as DnsDnsRebinding);
        }

        /// <summary>
        /// Returns true if DnsDnsRebinding instances are equal
        /// </summary>
        /// <param name="input">Instance of DnsDnsRebinding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DnsDnsRebinding input)
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
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.AllowedDomains == input.AllowedDomains ||
                    (this.AllowedDomains != null &&
                    this.AllowedDomains.Equals(input.AllowedDomains))
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
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                if (this.AllowedDomains != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedDomains.GetHashCode();
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