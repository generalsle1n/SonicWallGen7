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
    /// Enter bandwidth management configuration mode.
    /// </summary>
    [DataContract(Name = "access_rule_ipv6_ipv6_bandwidth_management")]
    public partial class AccessRuleIpv6Ipv6BandwidthManagement : IEquatable<AccessRuleIpv6Ipv6BandwidthManagement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6BandwidthManagement" /> class.
        /// </summary>
        /// <param name="egress">egress.</param>
        /// <param name="ingress">ingress.</param>
        /// <param name="usageTracking">Enable tracking bandwidth usage..</param>
        public AccessRuleIpv6Ipv6BandwidthManagement(AccessRuleIpv6Ipv6BandwidthManagementEgress egress = default(AccessRuleIpv6Ipv6BandwidthManagementEgress), AccessRuleIpv6Ipv6BandwidthManagementIngress ingress = default(AccessRuleIpv6Ipv6BandwidthManagementIngress), bool usageTracking = default(bool))
        {
            this.Egress = egress;
            this.Ingress = ingress;
            this.UsageTracking = usageTracking;
        }

        /// <summary>
        /// Gets or Sets Egress
        /// </summary>
        [DataMember(Name = "egress", EmitDefaultValue = false)]
        public AccessRuleIpv6Ipv6BandwidthManagementEgress Egress { get; set; }

        /// <summary>
        /// Gets or Sets Ingress
        /// </summary>
        [DataMember(Name = "ingress", EmitDefaultValue = false)]
        public AccessRuleIpv6Ipv6BandwidthManagementIngress Ingress { get; set; }

        /// <summary>
        /// Enable tracking bandwidth usage.
        /// </summary>
        /// <value>Enable tracking bandwidth usage.</value>
        [DataMember(Name = "usage_tracking", EmitDefaultValue = true)]
        public bool UsageTracking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessRuleIpv6Ipv6BandwidthManagement {\n");
            sb.Append("  Egress: ").Append(Egress).Append("\n");
            sb.Append("  Ingress: ").Append(Ingress).Append("\n");
            sb.Append("  UsageTracking: ").Append(UsageTracking).Append("\n");
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
            return this.Equals(input as AccessRuleIpv6Ipv6BandwidthManagement);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv6Ipv6BandwidthManagement instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv6Ipv6BandwidthManagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv6Ipv6BandwidthManagement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Egress == input.Egress ||
                    (this.Egress != null &&
                    this.Egress.Equals(input.Egress))
                ) && 
                (
                    this.Ingress == input.Ingress ||
                    (this.Ingress != null &&
                    this.Ingress.Equals(input.Ingress))
                ) && 
                (
                    this.UsageTracking == input.UsageTracking ||
                    this.UsageTracking.Equals(input.UsageTracking)
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
                if (this.Egress != null)
                {
                    hashCode = (hashCode * 59) + this.Egress.GetHashCode();
                }
                if (this.Ingress != null)
                {
                    hashCode = (hashCode * 59) + this.Ingress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UsageTracking.GetHashCode();
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