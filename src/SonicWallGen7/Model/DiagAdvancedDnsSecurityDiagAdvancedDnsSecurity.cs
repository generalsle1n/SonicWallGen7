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
    /// Configure advanced diag SonicDns security settings.
    /// </summary>
    [DataContract(Name = "diag_advanced_SonicDns_security_diag_advanced_SonicDns_security")]
    public partial class DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity : IEquatable<DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity" /> class.
        /// </summary>
        /// <param name="SonicDnsTunnelMinimumPacketNumber">Configure the minimum SonicDns packet number for SonicDns tunnel detection..</param>
        /// <param name="SonicDnsTunnelRatioThreshold">Configure the ratio threshold for corner SonicDns types..</param>
        /// <param name="SonicDnsTunnelNumberThreshold">Configure the number threshold for normal SonicDns types..</param>
        public DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity(decimal SonicDnsTunnelMinimumPacketNumber = default(decimal), decimal SonicDnsTunnelRatioThreshold = default(decimal), decimal SonicDnsTunnelNumberThreshold = default(decimal))
        {
            this.SonicDnsTunnelMinimumPacketNumber = SonicDnsTunnelMinimumPacketNumber;
            this.SonicDnsTunnelRatioThreshold = SonicDnsTunnelRatioThreshold;
            this.SonicDnsTunnelNumberThreshold = SonicDnsTunnelNumberThreshold;
        }

        /// <summary>
        /// Configure the minimum SonicDns packet number for SonicDns tunnel detection.
        /// </summary>
        /// <value>Configure the minimum SonicDns packet number for SonicDns tunnel detection.</value>
        [DataMember(Name = "SonicDns_tunnel_minimum_packet_number", EmitDefaultValue = false)]
        public decimal SonicDnsTunnelMinimumPacketNumber { get; set; }

        /// <summary>
        /// Configure the ratio threshold for corner SonicDns types.
        /// </summary>
        /// <value>Configure the ratio threshold for corner SonicDns types.</value>
        [DataMember(Name = "SonicDns_tunnel_ratio_threshold", EmitDefaultValue = false)]
        public decimal SonicDnsTunnelRatioThreshold { get; set; }

        /// <summary>
        /// Configure the number threshold for normal SonicDns types.
        /// </summary>
        /// <value>Configure the number threshold for normal SonicDns types.</value>
        [DataMember(Name = "SonicDns_tunnel_number_threshold", EmitDefaultValue = false)]
        public decimal SonicDnsTunnelNumberThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity {\n");
            sb.Append("  SonicDnsTunnelMinimumPacketNumber: ").Append(SonicDnsTunnelMinimumPacketNumber).Append("\n");
            sb.Append("  SonicDnsTunnelRatioThreshold: ").Append(SonicDnsTunnelRatioThreshold).Append("\n");
            sb.Append("  SonicDnsTunnelNumberThreshold: ").Append(SonicDnsTunnelNumberThreshold).Append("\n");
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
            return this.Equals(input as DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity);
        }

        /// <summary>
        /// Returns true if DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedSonicDnsSecurityDiagAdvancedSonicDnsSecurity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SonicDnsTunnelMinimumPacketNumber == input.SonicDnsTunnelMinimumPacketNumber ||
                    this.SonicDnsTunnelMinimumPacketNumber.Equals(input.SonicDnsTunnelMinimumPacketNumber)
                ) && 
                (
                    this.SonicDnsTunnelRatioThreshold == input.SonicDnsTunnelRatioThreshold ||
                    this.SonicDnsTunnelRatioThreshold.Equals(input.SonicDnsTunnelRatioThreshold)
                ) && 
                (
                    this.SonicDnsTunnelNumberThreshold == input.SonicDnsTunnelNumberThreshold ||
                    this.SonicDnsTunnelNumberThreshold.Equals(input.SonicDnsTunnelNumberThreshold)
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
                hashCode = (hashCode * 59) + this.SonicDnsTunnelMinimumPacketNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.SonicDnsTunnelRatioThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.SonicDnsTunnelNumberThreshold.GetHashCode();
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
