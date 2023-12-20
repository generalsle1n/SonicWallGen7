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
    /// VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv4_tunnel_interface_ipv4_tunnel_interface_auth_method_shared_secret_ike_id_local_key_id")]
    public partial class VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId : IEquatable<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId" /> class.
        /// </summary>
        /// <param name="keyId">Key ID identifier..</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId(string keyId = default(string))
        {
            this.KeyId = keyId;
        }

        /// <summary>
        /// Key ID identifier.
        /// </summary>
        /// <value>Key ID identifier.</value>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]
        public string KeyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId {\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethodSharedSecretIkeIdLocalKeyId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
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
                if (this.KeyId != null)
                {
                    hashCode = (hashCode * 59) + this.KeyId.GetHashCode();
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
