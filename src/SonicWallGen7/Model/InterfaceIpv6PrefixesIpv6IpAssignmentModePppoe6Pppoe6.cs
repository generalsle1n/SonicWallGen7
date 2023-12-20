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
    /// PPPoE IPv6 configuration assignment.
    /// </summary>
    [DataContract(Name = "interface_ipv6_prefixes_ipv6_ip_assignment_mode_pppoe6_pppoe6")]
    public partial class InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6 : IEquatable<InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6>, IValidatableObject
    {
        /// <summary>
        /// Set PPPoE6 mode.
        /// </summary>
        /// <value>Set PPPoE6 mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeAssignmentEnum
        {
            /// <summary>
            /// Enum Dhcpv6 for value: dhcpv6
            /// </summary>
            [EnumMember(Value = "dhcpv6")]
            Dhcpv6 = 1,

            /// <summary>
            /// Enum Auto for value: auto
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto = 2,

            /// <summary>
            /// Enum Static for value: static
            /// </summary>
            [EnumMember(Value = "static")]
            Static = 3
        }


        /// <summary>
        /// Set PPPoE6 mode.
        /// </summary>
        /// <value>Set PPPoE6 mode.</value>
        [DataMember(Name = "mode_assignment", EmitDefaultValue = false)]
        public ModeAssignmentEnum? ModeAssignment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6" /> class.
        /// </summary>
        /// <param name="modeAssignment">Set PPPoE6 mode..</param>
        /// <param name="routerAdvertisement">routerAdvertisement.</param>
        public InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6(ModeAssignmentEnum? modeAssignment = default(ModeAssignmentEnum?), InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisement routerAdvertisement = default(InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisement))
        {
            this.ModeAssignment = modeAssignment;
            this.RouterAdvertisement = routerAdvertisement;
        }

        /// <summary>
        /// Gets or Sets RouterAdvertisement
        /// </summary>
        [DataMember(Name = "router_advertisement", EmitDefaultValue = false)]
        public InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisement RouterAdvertisement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6 {\n");
            sb.Append("  ModeAssignment: ").Append(ModeAssignment).Append("\n");
            sb.Append("  RouterAdvertisement: ").Append(RouterAdvertisement).Append("\n");
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
            return this.Equals(input as InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6);
        }

        /// <summary>
        /// Returns true if InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6 instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv6PrefixesIpv6IpAssignmentModePppoe6Pppoe6 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModeAssignment == input.ModeAssignment ||
                    this.ModeAssignment.Equals(input.ModeAssignment)
                ) && 
                (
                    this.RouterAdvertisement == input.RouterAdvertisement ||
                    (this.RouterAdvertisement != null &&
                    this.RouterAdvertisement.Equals(input.RouterAdvertisement))
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
                hashCode = (hashCode * 59) + this.ModeAssignment.GetHashCode();
                if (this.RouterAdvertisement != null)
                {
                    hashCode = (hashCode * 59) + this.RouterAdvertisement.GetHashCode();
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