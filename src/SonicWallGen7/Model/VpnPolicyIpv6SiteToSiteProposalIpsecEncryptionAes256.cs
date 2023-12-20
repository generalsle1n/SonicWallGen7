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
    /// VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv6_site_to_site_proposal_ipsec_encryption_aes_256")]
    public partial class VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256 : IEquatable<VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256" /> class.
        /// </summary>
        /// <param name="aes256">Advanced encryption standard (AES) - 256 bit..</param>
        public VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256(bool aes256 = default(bool))
        {
            this.Aes256 = aes256;
        }

        /// <summary>
        /// Advanced encryption standard (AES) - 256 bit.
        /// </summary>
        /// <value>Advanced encryption standard (AES) - 256 bit.</value>
        [DataMember(Name = "aes_256", EmitDefaultValue = true)]
        public bool Aes256 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256 {\n");
            sb.Append("  Aes256: ").Append(Aes256).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256 instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv6SiteToSiteProposalIpsecEncryptionAes256 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Aes256 == input.Aes256 ||
                    this.Aes256.Equals(input.Aes256)
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
                hashCode = (hashCode * 59) + this.Aes256.GetHashCode();
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
