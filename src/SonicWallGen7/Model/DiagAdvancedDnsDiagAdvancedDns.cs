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
    /// Configure advanced diag DNS settings.
    /// </summary>
    [DataContract(Name = "diag_advanced_dns_diag_advanced_dns")]
    public partial class DiagAdvancedDnsDiagAdvancedDns : IEquatable<DiagAdvancedDnsDiagAdvancedDns>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedDnsDiagAdvancedDns" /> class.
        /// </summary>
        /// <param name="preferArpa">Enable prefer arpa as suffix when commit ipv6 DNS reverse name resolution..</param>
        /// <param name="stackTrafficByDp">Enable stack traffic sending by DP core..</param>
        public DiagAdvancedDnsDiagAdvancedDns(bool preferArpa = default(bool), bool stackTrafficByDp = default(bool))
        {
            this.PreferArpa = preferArpa;
            this.StackTrafficByDp = stackTrafficByDp;
        }

        /// <summary>
        /// Enable prefer arpa as suffix when commit ipv6 DNS reverse name resolution.
        /// </summary>
        /// <value>Enable prefer arpa as suffix when commit ipv6 DNS reverse name resolution.</value>
        [DataMember(Name = "prefer_arpa", EmitDefaultValue = true)]
        public bool PreferArpa { get; set; }

        /// <summary>
        /// Enable stack traffic sending by DP core.
        /// </summary>
        /// <value>Enable stack traffic sending by DP core.</value>
        [DataMember(Name = "stack_traffic_by_dp", EmitDefaultValue = true)]
        public bool StackTrafficByDp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedDnsDiagAdvancedDns {\n");
            sb.Append("  PreferArpa: ").Append(PreferArpa).Append("\n");
            sb.Append("  StackTrafficByDp: ").Append(StackTrafficByDp).Append("\n");
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
            return this.Equals(input as DiagAdvancedDnsDiagAdvancedDns);
        }

        /// <summary>
        /// Returns true if DiagAdvancedDnsDiagAdvancedDns instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedDnsDiagAdvancedDns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedDnsDiagAdvancedDns input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PreferArpa == input.PreferArpa ||
                    this.PreferArpa.Equals(input.PreferArpa)
                ) && 
                (
                    this.StackTrafficByDp == input.StackTrafficByDp ||
                    this.StackTrafficByDp.Equals(input.StackTrafficByDp)
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
                hashCode = (hashCode * 59) + this.PreferArpa.GetHashCode();
                hashCode = (hashCode * 59) + this.StackTrafficByDp.GetHashCode();
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