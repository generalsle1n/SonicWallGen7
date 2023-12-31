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
    /// Add downstream IPv6 address delegated from DHCP-PD
    /// </summary>
    [DataContract(Name = "interface_ipv6_extra_ip_ipv6_ip_assignment_mode_static_extra_ip_type_prefix_delegation_prefix_delegation")]
    public partial class InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation : IEquatable<InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation" /> class.
        /// </summary>
        /// <param name="preferredIp">Set interface preferred IPv6 address. (required).</param>
        /// <param name="preferredPrefixLength">Set interface IPv6 preferred prefix length..</param>
        /// <param name="delegatedPrefix">Set delegated prefix assignment..</param>
        /// <param name="advertiseSubnetPrefix">Subnet prefix of IPv6 address..</param>
        public InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation(string preferredIp = default(string), decimal preferredPrefixLength = default(decimal), string delegatedPrefix = default(string), bool advertiseSubnetPrefix = default(bool))
        {
            // to ensure "preferredIp" is required (not null)
            if (preferredIp == null)
            {
                throw new ArgumentNullException("preferredIp is a required property for InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation and cannot be null");
            }
            this.PreferredIp = preferredIp;
            this.PreferredPrefixLength = preferredPrefixLength;
            this.DelegatedPrefix = delegatedPrefix;
            this.AdvertiseSubnetPrefix = advertiseSubnetPrefix;
        }

        /// <summary>
        /// Set interface preferred IPv6 address.
        /// </summary>
        /// <value>Set interface preferred IPv6 address.</value>
        [DataMember(Name = "preferred_ip", IsRequired = true, EmitDefaultValue = true)]
        public string PreferredIp { get; set; }

        /// <summary>
        /// Set interface IPv6 preferred prefix length.
        /// </summary>
        /// <value>Set interface IPv6 preferred prefix length.</value>
        [DataMember(Name = "preferred_prefix_length", EmitDefaultValue = false)]
        public decimal PreferredPrefixLength { get; set; }

        /// <summary>
        /// Set delegated prefix assignment.
        /// </summary>
        /// <value>Set delegated prefix assignment.</value>
        [DataMember(Name = "delegated_prefix", EmitDefaultValue = false)]
        public string DelegatedPrefix { get; set; }

        /// <summary>
        /// Subnet prefix of IPv6 address.
        /// </summary>
        /// <value>Subnet prefix of IPv6 address.</value>
        [DataMember(Name = "advertise_subnet_prefix", EmitDefaultValue = true)]
        public bool AdvertiseSubnetPrefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation {\n");
            sb.Append("  PreferredIp: ").Append(PreferredIp).Append("\n");
            sb.Append("  PreferredPrefixLength: ").Append(PreferredPrefixLength).Append("\n");
            sb.Append("  DelegatedPrefix: ").Append(DelegatedPrefix).Append("\n");
            sb.Append("  AdvertiseSubnetPrefix: ").Append(AdvertiseSubnetPrefix).Append("\n");
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
            return this.Equals(input as InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation);
        }

        /// <summary>
        /// Returns true if InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv6ExtraIpIpv6IpAssignmentModeStaticExtraIpTypePrefixDelegationPrefixDelegation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PreferredIp == input.PreferredIp ||
                    (this.PreferredIp != null &&
                    this.PreferredIp.Equals(input.PreferredIp))
                ) && 
                (
                    this.PreferredPrefixLength == input.PreferredPrefixLength ||
                    this.PreferredPrefixLength.Equals(input.PreferredPrefixLength)
                ) && 
                (
                    this.DelegatedPrefix == input.DelegatedPrefix ||
                    (this.DelegatedPrefix != null &&
                    this.DelegatedPrefix.Equals(input.DelegatedPrefix))
                ) && 
                (
                    this.AdvertiseSubnetPrefix == input.AdvertiseSubnetPrefix ||
                    this.AdvertiseSubnetPrefix.Equals(input.AdvertiseSubnetPrefix)
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
                if (this.PreferredIp != null)
                {
                    hashCode = (hashCode * 59) + this.PreferredIp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PreferredPrefixLength.GetHashCode();
                if (this.DelegatedPrefix != null)
                {
                    hashCode = (hashCode * 59) + this.DelegatedPrefix.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AdvertiseSubnetPrefix.GetHashCode();
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
