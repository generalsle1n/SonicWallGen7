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
    /// Enable protection against ARP storm. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "diag_advanced_arp_diag_advanced_arp_redundant_ip_resolution_rate")]
    public partial class DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate : IEquatable<DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate" /> class.
        /// </summary>
        /// <param name="amount">Set limit for ARP sending rate when resolve a same ip, protect against ARP storm..</param>
        public DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate(decimal amount = default(decimal))
        {
            this.Amount = amount;
        }

        /// <summary>
        /// Set limit for ARP sending rate when resolve a same ip, protect against ARP storm.
        /// </summary>
        /// <value>Set limit for ARP sending rate when resolve a same ip, protect against ARP storm.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate);
        }

        /// <summary>
        /// Returns true if DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedArpDiagAdvancedArpRedundantIpResolutionRate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
