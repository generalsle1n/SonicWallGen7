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
    /// Advanced device settings to be used under direction of SonicWall support.
    /// </summary>
    [DataContract(Name = "diag_advanced_diag_advanced")]
    public partial class DiagAdvancedDiagAdvanced : IEquatable<DiagAdvancedDiagAdvanced>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedDiagAdvanced" /> class.
        /// </summary>
        /// <param name="unifiedPolicyEngine">unifiedPolicyEngine.</param>
        /// <param name="tooltipNoDescription">Enable tooltip with no descriptions..</param>
        /// <param name="remoteAssistance">Enable remote assistance..</param>
        /// <param name="ipv6">ipv6.</param>
        /// <param name="icmp">icmp.</param>
        /// <param name="debug">debug.</param>
        public DiagAdvancedDiagAdvanced(DiagAdvancedDiagAdvancedUnifiedPolicyEngine unifiedPolicyEngine = default(DiagAdvancedDiagAdvancedUnifiedPolicyEngine), bool tooltipNoDescription = default(bool), bool remoteAssistance = default(bool), DiagAdvancedDiagAdvancedIpv6 ipv6 = default(DiagAdvancedDiagAdvancedIpv6), DiagAdvancedDiagAdvancedIcmp icmp = default(DiagAdvancedDiagAdvancedIcmp), DiagAdvancedDiagAdvancedDebug debug = default(DiagAdvancedDiagAdvancedDebug))
        {
            this.UnifiedPolicyEngine = unifiedPolicyEngine;
            this.TooltipNoDescription = tooltipNoDescription;
            this.RemoteAssistance = remoteAssistance;
            this.Ipv6 = ipv6;
            this.Icmp = icmp;
            this.Debug = debug;
        }

        /// <summary>
        /// Gets or Sets UnifiedPolicyEngine
        /// </summary>
        [DataMember(Name = "unified_policy_engine", EmitDefaultValue = false)]
        public DiagAdvancedDiagAdvancedUnifiedPolicyEngine UnifiedPolicyEngine { get; set; }

        /// <summary>
        /// Enable tooltip with no descriptions.
        /// </summary>
        /// <value>Enable tooltip with no descriptions.</value>
        [DataMember(Name = "tooltip_no_description", EmitDefaultValue = true)]
        public bool TooltipNoDescription { get; set; }

        /// <summary>
        /// Enable remote assistance.
        /// </summary>
        /// <value>Enable remote assistance.</value>
        [DataMember(Name = "remote_assistance", EmitDefaultValue = true)]
        public bool RemoteAssistance { get; set; }

        /// <summary>
        /// Gets or Sets Ipv6
        /// </summary>
        [DataMember(Name = "ipv6", EmitDefaultValue = false)]
        public DiagAdvancedDiagAdvancedIpv6 Ipv6 { get; set; }

        /// <summary>
        /// Gets or Sets Icmp
        /// </summary>
        [DataMember(Name = "icmp", EmitDefaultValue = false)]
        public DiagAdvancedDiagAdvancedIcmp Icmp { get; set; }

        /// <summary>
        /// Gets or Sets Debug
        /// </summary>
        [DataMember(Name = "debug", EmitDefaultValue = false)]
        public DiagAdvancedDiagAdvancedDebug Debug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedDiagAdvanced {\n");
            sb.Append("  UnifiedPolicyEngine: ").Append(UnifiedPolicyEngine).Append("\n");
            sb.Append("  TooltipNoDescription: ").Append(TooltipNoDescription).Append("\n");
            sb.Append("  RemoteAssistance: ").Append(RemoteAssistance).Append("\n");
            sb.Append("  Ipv6: ").Append(Ipv6).Append("\n");
            sb.Append("  Icmp: ").Append(Icmp).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
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
            return this.Equals(input as DiagAdvancedDiagAdvanced);
        }

        /// <summary>
        /// Returns true if DiagAdvancedDiagAdvanced instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedDiagAdvanced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedDiagAdvanced input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnifiedPolicyEngine == input.UnifiedPolicyEngine ||
                    (this.UnifiedPolicyEngine != null &&
                    this.UnifiedPolicyEngine.Equals(input.UnifiedPolicyEngine))
                ) && 
                (
                    this.TooltipNoDescription == input.TooltipNoDescription ||
                    this.TooltipNoDescription.Equals(input.TooltipNoDescription)
                ) && 
                (
                    this.RemoteAssistance == input.RemoteAssistance ||
                    this.RemoteAssistance.Equals(input.RemoteAssistance)
                ) && 
                (
                    this.Ipv6 == input.Ipv6 ||
                    (this.Ipv6 != null &&
                    this.Ipv6.Equals(input.Ipv6))
                ) && 
                (
                    this.Icmp == input.Icmp ||
                    (this.Icmp != null &&
                    this.Icmp.Equals(input.Icmp))
                ) && 
                (
                    this.Debug == input.Debug ||
                    (this.Debug != null &&
                    this.Debug.Equals(input.Debug))
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
                if (this.UnifiedPolicyEngine != null)
                {
                    hashCode = (hashCode * 59) + this.UnifiedPolicyEngine.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TooltipNoDescription.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoteAssistance.GetHashCode();
                if (this.Ipv6 != null)
                {
                    hashCode = (hashCode * 59) + this.Ipv6.GetHashCode();
                }
                if (this.Icmp != null)
                {
                    hashCode = (hashCode * 59) + this.Icmp.GetHashCode();
                }
                if (this.Debug != null)
                {
                    hashCode = (hashCode * 59) + this.Debug.GetHashCode();
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
