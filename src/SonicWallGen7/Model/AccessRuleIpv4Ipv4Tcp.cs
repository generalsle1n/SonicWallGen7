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
    /// TCP.
    /// </summary>
    [DataContract(Name = "access_rule_ipv4_ipv4_tcp")]
    public partial class AccessRuleIpv4Ipv4Tcp : IEquatable<AccessRuleIpv4Ipv4Tcp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4Tcp" /> class.
        /// </summary>
        /// <param name="urgent">Enable allow TCP urgent packets..</param>
        /// <param name="timeout">Set the TCP connection inactivity timeout (seconds)..</param>
        public AccessRuleIpv4Ipv4Tcp(bool urgent = default(bool), decimal timeout = default(decimal))
        {
            this.Urgent = urgent;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Enable allow TCP urgent packets.
        /// </summary>
        /// <value>Enable allow TCP urgent packets.</value>
        [DataMember(Name = "urgent", EmitDefaultValue = true)]
        public bool Urgent { get; set; }

        /// <summary>
        /// Set the TCP connection inactivity timeout (seconds).
        /// </summary>
        /// <value>Set the TCP connection inactivity timeout (seconds).</value>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public decimal Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessRuleIpv4Ipv4Tcp {\n");
            sb.Append("  Urgent: ").Append(Urgent).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as AccessRuleIpv4Ipv4Tcp);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv4Ipv4Tcp instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv4Ipv4Tcp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv4Ipv4Tcp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Urgent == input.Urgent ||
                    this.Urgent.Equals(input.Urgent)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
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
                hashCode = (hashCode * 59) + this.Urgent.GetHashCode();
                hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
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