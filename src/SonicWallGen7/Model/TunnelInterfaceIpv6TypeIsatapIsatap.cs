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
    /// ISATAP tunnel.
    /// </summary>
    [DataContract(Name = "tunnel_interface_ipv6_type_isatap_isatap")]
    public partial class TunnelInterfaceIpv6TypeIsatapIsatap : IEquatable<TunnelInterfaceIpv6TypeIsatapIsatap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TunnelInterfaceIpv6TypeIsatapIsatap" /> class.
        /// </summary>
        /// <param name="boundTo">boundTo.</param>
        /// <param name="prefix">prefix.</param>
        /// <param name="linkMtu">Set tunnel interface link MTU..</param>
        public TunnelInterfaceIpv6TypeIsatapIsatap(TunnelInterfaceIpv6TypeIsatapIsatapBoundTo boundTo = default(TunnelInterfaceIpv6TypeIsatapIsatapBoundTo), TunnelInterfaceIpv6TypeIsatapIsatapPrefix prefix = default(TunnelInterfaceIpv6TypeIsatapIsatapPrefix), decimal linkMtu = default(decimal))
        {
            this.BoundTo = boundTo;
            this.Prefix = prefix;
            this.LinkMtu = linkMtu;
        }

        /// <summary>
        /// Gets or Sets BoundTo
        /// </summary>
        [DataMember(Name = "bound_to", EmitDefaultValue = false)]
        public TunnelInterfaceIpv6TypeIsatapIsatapBoundTo BoundTo { get; set; }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "prefix", EmitDefaultValue = true)]
        public TunnelInterfaceIpv6TypeIsatapIsatapPrefix Prefix { get; set; }

        /// <summary>
        /// Set tunnel interface link MTU.
        /// </summary>
        /// <value>Set tunnel interface link MTU.</value>
        [DataMember(Name = "link_mtu", EmitDefaultValue = false)]
        public decimal LinkMtu { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TunnelInterfaceIpv6TypeIsatapIsatap {\n");
            sb.Append("  BoundTo: ").Append(BoundTo).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  LinkMtu: ").Append(LinkMtu).Append("\n");
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
            return this.Equals(input as TunnelInterfaceIpv6TypeIsatapIsatap);
        }

        /// <summary>
        /// Returns true if TunnelInterfaceIpv6TypeIsatapIsatap instances are equal
        /// </summary>
        /// <param name="input">Instance of TunnelInterfaceIpv6TypeIsatapIsatap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TunnelInterfaceIpv6TypeIsatapIsatap input)
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
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.LinkMtu == input.LinkMtu ||
                    this.LinkMtu.Equals(input.LinkMtu)
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
                if (this.Prefix != null)
                {
                    hashCode = (hashCode * 59) + this.Prefix.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LinkMtu.GetHashCode();
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