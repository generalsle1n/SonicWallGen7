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
    /// Configure DHCP over VPN and enter dhcp over vpn mode.
    /// </summary>
    [DataContract(Name = "dhcp_over_vpn_global_vpn_dhcp_over_vpn")]
    public partial class DhcpOverVpnGlobalVpnDhcpOverVpn : IEquatable<DhcpOverVpnGlobalVpnDhcpOverVpn>, IValidatableObject
    {
        /// <summary>
        /// Configure DHCP over VPN mode.
        /// </summary>
        /// <value>Configure DHCP over VPN mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Central for value: central
            /// </summary>
            [EnumMember(Value = "central")]
            Central = 1,

            /// <summary>
            /// Enum Remote for value: remote
            /// </summary>
            [EnumMember(Value = "remote")]
            Remote = 2
        }


        /// <summary>
        /// Configure DHCP over VPN mode.
        /// </summary>
        /// <value>Configure DHCP over VPN mode.</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DhcpOverVpnGlobalVpnDhcpOverVpn" /> class.
        /// </summary>
        /// <param name="mode">Configure DHCP over VPN mode..</param>
        public DhcpOverVpnGlobalVpnDhcpOverVpn(ModeEnum? mode = default(ModeEnum?))
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DhcpOverVpnGlobalVpnDhcpOverVpn {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
            return this.Equals(input as DhcpOverVpnGlobalVpnDhcpOverVpn);
        }

        /// <summary>
        /// Returns true if DhcpOverVpnGlobalVpnDhcpOverVpn instances are equal
        /// </summary>
        /// <param name="input">Instance of DhcpOverVpnGlobalVpnDhcpOverVpn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DhcpOverVpnGlobalVpnDhcpOverVpn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
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
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
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
