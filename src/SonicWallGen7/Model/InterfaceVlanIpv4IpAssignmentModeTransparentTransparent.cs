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
    /// Interface uses transparent bridging (splice L3 subnet).
    /// </summary>
    [DataContract(Name = "interface_vlan_ipv4_ip_assignment_mode_transparent_transparent")]
    public partial class InterfaceVlanIpv4IpAssignmentModeTransparentTransparent : IEquatable<InterfaceVlanIpv4IpAssignmentModeTransparentTransparent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceVlanIpv4IpAssignmentModeTransparentTransparent" /> class.
        /// </summary>
        /// <param name="transparentRange">transparentRange.</param>
        /// <param name="gratuitousArpWanForwarding">Enable gratuitous ARP forwarding towards WAN..</param>
        /// <param name="gratuitousArpWanGeneration">Enable automatic gratuitous ARP generation towards WAN..</param>
        public InterfaceVlanIpv4IpAssignmentModeTransparentTransparent(InterfaceVlanIpv4IpAssignmentModeTransparentTransparentTransparentRange transparentRange = default(InterfaceVlanIpv4IpAssignmentModeTransparentTransparentTransparentRange), bool gratuitousArpWanForwarding = default(bool), bool gratuitousArpWanGeneration = default(bool))
        {
            this.TransparentRange = transparentRange;
            this.GratuitousArpWanForwarding = gratuitousArpWanForwarding;
            this.GratuitousArpWanGeneration = gratuitousArpWanGeneration;
        }

        /// <summary>
        /// Gets or Sets TransparentRange
        /// </summary>
        [DataMember(Name = "transparent_range", EmitDefaultValue = false)]
        public InterfaceVlanIpv4IpAssignmentModeTransparentTransparentTransparentRange TransparentRange { get; set; }

        /// <summary>
        /// Enable gratuitous ARP forwarding towards WAN.
        /// </summary>
        /// <value>Enable gratuitous ARP forwarding towards WAN.</value>
        [DataMember(Name = "gratuitous_arp_wan_forwarding", EmitDefaultValue = true)]
        public bool GratuitousArpWanForwarding { get; set; }

        /// <summary>
        /// Enable automatic gratuitous ARP generation towards WAN.
        /// </summary>
        /// <value>Enable automatic gratuitous ARP generation towards WAN.</value>
        [DataMember(Name = "gratuitous_arp_wan_generation", EmitDefaultValue = true)]
        public bool GratuitousArpWanGeneration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceVlanIpv4IpAssignmentModeTransparentTransparent {\n");
            sb.Append("  TransparentRange: ").Append(TransparentRange).Append("\n");
            sb.Append("  GratuitousArpWanForwarding: ").Append(GratuitousArpWanForwarding).Append("\n");
            sb.Append("  GratuitousArpWanGeneration: ").Append(GratuitousArpWanGeneration).Append("\n");
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
            return this.Equals(input as InterfaceVlanIpv4IpAssignmentModeTransparentTransparent);
        }

        /// <summary>
        /// Returns true if InterfaceVlanIpv4IpAssignmentModeTransparentTransparent instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceVlanIpv4IpAssignmentModeTransparentTransparent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceVlanIpv4IpAssignmentModeTransparentTransparent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransparentRange == input.TransparentRange ||
                    (this.TransparentRange != null &&
                    this.TransparentRange.Equals(input.TransparentRange))
                ) && 
                (
                    this.GratuitousArpWanForwarding == input.GratuitousArpWanForwarding ||
                    this.GratuitousArpWanForwarding.Equals(input.GratuitousArpWanForwarding)
                ) && 
                (
                    this.GratuitousArpWanGeneration == input.GratuitousArpWanGeneration ||
                    this.GratuitousArpWanGeneration.Equals(input.GratuitousArpWanGeneration)
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
                if (this.TransparentRange != null)
                {
                    hashCode = (hashCode * 59) + this.TransparentRange.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GratuitousArpWanForwarding.GetHashCode();
                hashCode = (hashCode * 59) + this.GratuitousArpWanGeneration.GetHashCode();
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
