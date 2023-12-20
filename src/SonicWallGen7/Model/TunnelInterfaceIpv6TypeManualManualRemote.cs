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
    /// Associated remote address.
    /// </summary>
    [DataContract(Name = "tunnel_interface_ipv6_type_manual_manual_remote")]
    public partial class TunnelInterfaceIpv6TypeManualManualRemote : IEquatable<TunnelInterfaceIpv6TypeManualManualRemote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterfaceIpv6TypeManualManualRemote" /> class.
        /// </summary>
        /// <param name="ipv4Address">ipv4Address.</param>
        /// <param name="ipv6Network">ipv6Network.</param>
        public TunnelInterfaceIpv6TypeManualManualRemote(TunnelInterfaceIpv6TypeManualManualRemoteIpv4Address ipv4Address = default(TunnelInterfaceIpv6TypeManualManualRemoteIpv4Address), TunnelInterfaceIpv6TypeManualManualRemoteIpv6Network ipv6Network = default(TunnelInterfaceIpv6TypeManualManualRemoteIpv6Network))
        {
            this.Ipv4Address = ipv4Address;
            this.Ipv6Network = ipv6Network;
        }

        /// <summary>
        /// Gets or Sets Ipv4Address
        /// </summary>
        [DataMember(Name = "ipv4_address", EmitDefaultValue = true)]
        public TunnelInterfaceIpv6TypeManualManualRemoteIpv4Address Ipv4Address { get; set; }

        /// <summary>
        /// Gets or Sets Ipv6Network
        /// </summary>
        [DataMember(Name = "ipv6_network", EmitDefaultValue = false)]
        public TunnelInterfaceIpv6TypeManualManualRemoteIpv6Network Ipv6Network { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TunnelInterfaceIpv6TypeManualManualRemote {\n");
            sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
            sb.Append("  Ipv6Network: ").Append(Ipv6Network).Append("\n");
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
            return this.Equals(input as TunnelInterfaceIpv6TypeManualManualRemote);
        }

        /// <summary>
        /// Returns true if TunnelInterfaceIpv6TypeManualManualRemote instances are equal
        /// </summary>
        /// <param name="input">Instance of TunnelInterfaceIpv6TypeManualManualRemote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TunnelInterfaceIpv6TypeManualManualRemote input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ipv4Address == input.Ipv4Address ||
                    (this.Ipv4Address != null &&
                    this.Ipv4Address.Equals(input.Ipv4Address))
                ) && 
                (
                    this.Ipv6Network == input.Ipv6Network ||
                    (this.Ipv6Network != null &&
                    this.Ipv6Network.Equals(input.Ipv6Network))
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
                if (this.Ipv4Address != null)
                {
                    hashCode = (hashCode * 59) + this.Ipv4Address.GetHashCode();
                }
                if (this.Ipv6Network != null)
                {
                    hashCode = (hashCode * 59) + this.Ipv6Network.GetHashCode();
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