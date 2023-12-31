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
    /// VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv6_site_to_site_proposal_ipsec_authentication_md5")]
    public partial class VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5 : IEquatable<VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5" /> class.
        /// </summary>
        /// <param name="md5">Message-digest algorithm 5 (MD5)..</param>
        public VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5(bool md5 = default(bool))
        {
            this.Md5 = md5;
        }

        /// <summary>
        /// Message-digest algorithm 5 (MD5).
        /// </summary>
        /// <value>Message-digest algorithm 5 (MD5).</value>
        [DataMember(Name = "md5", EmitDefaultValue = true)]
        public bool Md5 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5 {\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5 instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv6SiteToSiteProposalIpsecAuthenticationMd5 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Md5 == input.Md5 ||
                    this.Md5.Equals(input.Md5)
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
                hashCode = (hashCode * 59) + this.Md5.GetHashCode();
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
