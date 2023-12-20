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
    /// gre4to6 tunnel.
    /// </summary>
    [DataContract(Name = "tunnel_interface_4to6_type_gre4to6_gre4to6")]
    public partial class TunnelInterface4to6TypeGre4to6Gre4to6 : IEquatable<TunnelInterface4to6TypeGre4to6Gre4to6>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterface4to6TypeGre4to6Gre4to6" /> class.
        /// </summary>
        /// <param name="boundTo">boundTo.</param>
        /// <param name="remote">remote.</param>
        /// <param name="local">local.</param>
        /// <param name="ip">Set gre4to6 tunnel interface IP address..</param>
        /// <param name="netmask">Set interface netmask..</param>
        public TunnelInterface4to6TypeGre4to6Gre4to6(TunnelInterface4to6TypeDsliteDsliteBoundTo boundTo = default(TunnelInterface4to6TypeDsliteDsliteBoundTo), TunnelInterface4to6TypeGre4to6Gre4to6Remote remote = default(TunnelInterface4to6TypeGre4to6Gre4to6Remote), TunnelInterface4to6TypeGre4to6Gre4to6Local local = default(TunnelInterface4to6TypeGre4to6Gre4to6Local), string ip = default(string), string netmask = default(string))
        {
            this.BoundTo = boundTo;
            this.Remote = remote;
            this.Local = local;
            this.Ip = ip;
            this.Netmask = netmask;
        }

        /// <summary>
        /// Gets or Sets BoundTo
        /// </summary>
        [DataMember(Name = "bound_to", EmitDefaultValue = true)]
        public TunnelInterface4to6TypeDsliteDsliteBoundTo BoundTo { get; set; }

        /// <summary>
        /// Gets or Sets Remote
        /// </summary>
        [DataMember(Name = "remote", EmitDefaultValue = true)]
        public TunnelInterface4to6TypeGre4to6Gre4to6Remote Remote { get; set; }

        /// <summary>
        /// Gets or Sets Local
        /// </summary>
        [DataMember(Name = "local", EmitDefaultValue = false)]
        public TunnelInterface4to6TypeGre4to6Gre4to6Local Local { get; set; }

        /// <summary>
        /// Set gre4to6 tunnel interface IP address.
        /// </summary>
        /// <value>Set gre4to6 tunnel interface IP address.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Set interface netmask.
        /// </summary>
        /// <value>Set interface netmask.</value>
        [DataMember(Name = "netmask", EmitDefaultValue = false)]
        public string Netmask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TunnelInterface4to6TypeGre4to6Gre4to6 {\n");
            sb.Append("  BoundTo: ").Append(BoundTo).Append("\n");
            sb.Append("  Remote: ").Append(Remote).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Netmask: ").Append(Netmask).Append("\n");
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
            return this.Equals(input as TunnelInterface4to6TypeGre4to6Gre4to6);
        }

        /// <summary>
        /// Returns true if TunnelInterface4to6TypeGre4to6Gre4to6 instances are equal
        /// </summary>
        /// <param name="input">Instance of TunnelInterface4to6TypeGre4to6Gre4to6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TunnelInterface4to6TypeGre4to6Gre4to6 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BoundTo == input.BoundTo ||
                    (this.BoundTo != null &&
                    this.BoundTo.Equals(input.BoundTo))
                ) && 
                (
                    this.Remote == input.Remote ||
                    (this.Remote != null &&
                    this.Remote.Equals(input.Remote))
                ) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Netmask == input.Netmask ||
                    (this.Netmask != null &&
                    this.Netmask.Equals(input.Netmask))
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
                if (this.BoundTo != null)
                {
                    hashCode = (hashCode * 59) + this.BoundTo.GetHashCode();
                }
                if (this.Remote != null)
                {
                    hashCode = (hashCode * 59) + this.Remote.GetHashCode();
                }
                if (this.Local != null)
                {
                    hashCode = (hashCode * 59) + this.Local.GetHashCode();
                }
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                if (this.Netmask != null)
                {
                    hashCode = (hashCode * 59) + this.Netmask.GetHashCode();
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