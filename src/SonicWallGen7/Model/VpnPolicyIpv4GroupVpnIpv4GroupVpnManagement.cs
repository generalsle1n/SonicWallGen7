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
    /// Enable management for VPN policy.
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv4_group_vpn_ipv4_group_vpn_management")]
    public partial class VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement : IEquatable<VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement" /> class.
        /// </summary>
        /// <param name="http">Enable HTTP management for VPN policy..</param>
        /// <param name="https">Enable HTTPS management for VPN policy..</param>
        /// <param name="ssh">Enable SSH management for VPN policy..</param>
        /// <param name="snmp">Enable SNMP management for VPN policy..</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement(bool http = default(bool), bool https = default(bool), bool ssh = default(bool), bool snmp = default(bool))
        {
            this.Http = http;
            this.Https = https;
            this.Ssh = ssh;
            this.Snmp = snmp;
        }

        /// <summary>
        /// Enable HTTP management for VPN policy.
        /// </summary>
        /// <value>Enable HTTP management for VPN policy.</value>
        [DataMember(Name = "http", EmitDefaultValue = true)]
        public bool Http { get; set; }

        /// <summary>
        /// Enable HTTPS management for VPN policy.
        /// </summary>
        /// <value>Enable HTTPS management for VPN policy.</value>
        [DataMember(Name = "https", EmitDefaultValue = true)]
        public bool Https { get; set; }

        /// <summary>
        /// Enable SSH management for VPN policy.
        /// </summary>
        /// <value>Enable SSH management for VPN policy.</value>
        [DataMember(Name = "ssh", EmitDefaultValue = true)]
        public bool Ssh { get; set; }

        /// <summary>
        /// Enable SNMP management for VPN policy.
        /// </summary>
        /// <value>Enable SNMP management for VPN policy.</value>
        [DataMember(Name = "snmp", EmitDefaultValue = true)]
        public bool Snmp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement {\n");
            sb.Append("  Http: ").Append(Http).Append("\n");
            sb.Append("  Https: ").Append(Https).Append("\n");
            sb.Append("  Ssh: ").Append(Ssh).Append("\n");
            sb.Append("  Snmp: ").Append(Snmp).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Http == input.Http ||
                    this.Http.Equals(input.Http)
                ) && 
                (
                    this.Https == input.Https ||
                    this.Https.Equals(input.Https)
                ) && 
                (
                    this.Ssh == input.Ssh ||
                    this.Ssh.Equals(input.Ssh)
                ) && 
                (
                    this.Snmp == input.Snmp ||
                    this.Snmp.Equals(input.Snmp)
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
                hashCode = (hashCode * 59) + this.Http.GetHashCode();
                hashCode = (hashCode * 59) + this.Https.GetHashCode();
                hashCode = (hashCode * 59) + this.Ssh.GetHashCode();
                hashCode = (hashCode * 59) + this.Snmp.GetHashCode();
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