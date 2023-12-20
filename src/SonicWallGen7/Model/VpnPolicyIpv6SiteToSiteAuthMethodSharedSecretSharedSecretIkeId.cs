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
    /// IKE authentication associated identifiers.
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv6_site_to_site_auth_method_shared_secret_shared_secret_ike_id")]
    public partial class VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId : IEquatable<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId" /> class.
        /// </summary>
        /// <param name="local">local.</param>
        /// <param name="peer">peer.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal local = default(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal), VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdPeer peer = default(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdPeer))
        {
            this.Local = local;
            this.Peer = peer;
        }

        /// <summary>
        /// Gets or Sets Local
        /// </summary>
        [DataMember(Name = "local", EmitDefaultValue = false)]
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal Local { get; set; }

        /// <summary>
        /// Gets or Sets Peer
        /// </summary>
        [DataMember(Name = "peer", EmitDefaultValue = false)]
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdPeer Peer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId {\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Peer: ").Append(Peer).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.Peer == input.Peer ||
                    (this.Peer != null &&
                    this.Peer.Equals(input.Peer))
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
                if (this.Local != null)
                {
                    hashCode = (hashCode * 59) + this.Local.GetHashCode();
                }
                if (this.Peer != null)
                {
                    hashCode = (hashCode * 59) + this.Peer.GetHashCode();
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
