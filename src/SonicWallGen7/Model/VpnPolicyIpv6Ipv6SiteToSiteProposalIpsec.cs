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
    /// IPsec (phase 2) proposal.
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv6_ipv6_site_to_site_proposal_ipsec")]
    public partial class VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec : IEquatable<VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec>, IValidatableObject
    {
        /// <summary>
        /// Protocol.
        /// </summary>
        /// <value>Protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            /// <summary>
            /// Enum Esp for value: esp
            /// </summary>
            [EnumMember(Value = "esp")]
            Esp = 1,

            /// <summary>
            /// Enum Ah for value: ah
            /// </summary>
            [EnumMember(Value = "ah")]
            Ah = 2
        }


        /// <summary>
        /// Protocol.
        /// </summary>
        /// <value>Protocol.</value>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public ProtocolEnum? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec" /> class.
        /// </summary>
        /// <param name="protocol">Protocol..</param>
        /// <param name="encryption">encryption.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="perfectForwardSecrecy">perfectForwardSecrecy.</param>
        /// <param name="lifetime">Life time (seconds)..</param>
        /// <param name="lifebytes">Life bytes (kb)..</param>
        /// <param name="inSpi">Configure incoming SPI..</param>
        /// <param name="outSpi">Configure outgoing SPI..</param>
        /// <param name="inEncryptionKey">Configure incoming encryption key..</param>
        /// <param name="inAuthenticationKey">Configure incoming authentication key..</param>
        /// <param name="outEncryptionKey">Configure outgoing encryption key..</param>
        /// <param name="outAuthenticationKey">Configure outgoing authentication key..</param>
        public VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec(ProtocolEnum? protocol = default(ProtocolEnum?), VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecEncryption encryption = default(VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecEncryption), VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecAuthentication authentication = default(VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecAuthentication), VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecPerfectForwardSecrecy perfectForwardSecrecy = default(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecPerfectForwardSecrecy), decimal lifetime = default(decimal), decimal lifebytes = default(decimal), string inSpi = default(string), string outSpi = default(string), string inEncryptionKey = default(string), string inAuthenticationKey = default(string), string outEncryptionKey = default(string), string outAuthenticationKey = default(string))
        {
            this.Protocol = protocol;
            this.Encryption = encryption;
            this.Authentication = authentication;
            this.PerfectForwardSecrecy = perfectForwardSecrecy;
            this.Lifetime = lifetime;
            this.Lifebytes = lifebytes;
            this.InSpi = inSpi;
            this.OutSpi = outSpi;
            this.InEncryptionKey = inEncryptionKey;
            this.InAuthenticationKey = inAuthenticationKey;
            this.OutEncryptionKey = outEncryptionKey;
            this.OutAuthenticationKey = outAuthenticationKey;
        }

        /// <summary>
        /// Gets or Sets Encryption
        /// </summary>
        [DataMember(Name = "encryption", EmitDefaultValue = false)]
        public VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecEncryption Encryption { get; set; }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", EmitDefaultValue = false)]
        public VpnPolicyIpv6Ipv6SiteToSiteProposalIpsecAuthentication Authentication { get; set; }

        /// <summary>
        /// Gets or Sets PerfectForwardSecrecy
        /// </summary>
        [DataMember(Name = "perfect_forward_secrecy", EmitDefaultValue = true)]
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecPerfectForwardSecrecy PerfectForwardSecrecy { get; set; }

        /// <summary>
        /// Life time (seconds).
        /// </summary>
        /// <value>Life time (seconds).</value>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public decimal Lifetime { get; set; }

        /// <summary>
        /// Life bytes (kb).
        /// </summary>
        /// <value>Life bytes (kb).</value>
        [DataMember(Name = "lifebytes", EmitDefaultValue = false)]
        public decimal Lifebytes { get; set; }

        /// <summary>
        /// Configure incoming SPI.
        /// </summary>
        /// <value>Configure incoming SPI.</value>
        [DataMember(Name = "in_spi", EmitDefaultValue = false)]
        public string InSpi { get; set; }

        /// <summary>
        /// Configure outgoing SPI.
        /// </summary>
        /// <value>Configure outgoing SPI.</value>
        [DataMember(Name = "out_spi", EmitDefaultValue = false)]
        public string OutSpi { get; set; }

        /// <summary>
        /// Configure incoming encryption key.
        /// </summary>
        /// <value>Configure incoming encryption key.</value>
        [DataMember(Name = "in_encryption_key", EmitDefaultValue = false)]
        public string InEncryptionKey { get; set; }

        /// <summary>
        /// Configure incoming authentication key.
        /// </summary>
        /// <value>Configure incoming authentication key.</value>
        [DataMember(Name = "in_authentication_key", EmitDefaultValue = false)]
        public string InAuthenticationKey { get; set; }

        /// <summary>
        /// Configure outgoing encryption key.
        /// </summary>
        /// <value>Configure outgoing encryption key.</value>
        [DataMember(Name = "out_encryption_key", EmitDefaultValue = false)]
        public string OutEncryptionKey { get; set; }

        /// <summary>
        /// Configure outgoing authentication key.
        /// </summary>
        /// <value>Configure outgoing authentication key.</value>
        [DataMember(Name = "out_authentication_key", EmitDefaultValue = false)]
        public string OutAuthenticationKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec {\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  PerfectForwardSecrecy: ").Append(PerfectForwardSecrecy).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
            sb.Append("  Lifebytes: ").Append(Lifebytes).Append("\n");
            sb.Append("  InSpi: ").Append(InSpi).Append("\n");
            sb.Append("  OutSpi: ").Append(OutSpi).Append("\n");
            sb.Append("  InEncryptionKey: ").Append(InEncryptionKey).Append("\n");
            sb.Append("  InAuthenticationKey: ").Append(InAuthenticationKey).Append("\n");
            sb.Append("  OutEncryptionKey: ").Append(OutEncryptionKey).Append("\n");
            sb.Append("  OutAuthenticationKey: ").Append(OutAuthenticationKey).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv6Ipv6SiteToSiteProposalIpsec input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol.Equals(input.Protocol)
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
                ) && 
                (
                    this.PerfectForwardSecrecy == input.PerfectForwardSecrecy ||
                    (this.PerfectForwardSecrecy != null &&
                    this.PerfectForwardSecrecy.Equals(input.PerfectForwardSecrecy))
                ) && 
                (
                    this.Lifetime == input.Lifetime ||
                    this.Lifetime.Equals(input.Lifetime)
                ) && 
                (
                    this.Lifebytes == input.Lifebytes ||
                    this.Lifebytes.Equals(input.Lifebytes)
                ) && 
                (
                    this.InSpi == input.InSpi ||
                    (this.InSpi != null &&
                    this.InSpi.Equals(input.InSpi))
                ) && 
                (
                    this.OutSpi == input.OutSpi ||
                    (this.OutSpi != null &&
                    this.OutSpi.Equals(input.OutSpi))
                ) && 
                (
                    this.InEncryptionKey == input.InEncryptionKey ||
                    (this.InEncryptionKey != null &&
                    this.InEncryptionKey.Equals(input.InEncryptionKey))
                ) && 
                (
                    this.InAuthenticationKey == input.InAuthenticationKey ||
                    (this.InAuthenticationKey != null &&
                    this.InAuthenticationKey.Equals(input.InAuthenticationKey))
                ) && 
                (
                    this.OutEncryptionKey == input.OutEncryptionKey ||
                    (this.OutEncryptionKey != null &&
                    this.OutEncryptionKey.Equals(input.OutEncryptionKey))
                ) && 
                (
                    this.OutAuthenticationKey == input.OutAuthenticationKey ||
                    (this.OutAuthenticationKey != null &&
                    this.OutAuthenticationKey.Equals(input.OutAuthenticationKey))
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
                hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
                if (this.Encryption != null)
                {
                    hashCode = (hashCode * 59) + this.Encryption.GetHashCode();
                }
                if (this.Authentication != null)
                {
                    hashCode = (hashCode * 59) + this.Authentication.GetHashCode();
                }
                if (this.PerfectForwardSecrecy != null)
                {
                    hashCode = (hashCode * 59) + this.PerfectForwardSecrecy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Lifetime.GetHashCode();
                hashCode = (hashCode * 59) + this.Lifebytes.GetHashCode();
                if (this.InSpi != null)
                {
                    hashCode = (hashCode * 59) + this.InSpi.GetHashCode();
                }
                if (this.OutSpi != null)
                {
                    hashCode = (hashCode * 59) + this.OutSpi.GetHashCode();
                }
                if (this.InEncryptionKey != null)
                {
                    hashCode = (hashCode * 59) + this.InEncryptionKey.GetHashCode();
                }
                if (this.InAuthenticationKey != null)
                {
                    hashCode = (hashCode * 59) + this.InAuthenticationKey.GetHashCode();
                }
                if (this.OutEncryptionKey != null)
                {
                    hashCode = (hashCode * 59) + this.OutEncryptionKey.GetHashCode();
                }
                if (this.OutAuthenticationKey != null)
                {
                    hashCode = (hashCode * 59) + this.OutAuthenticationKey.GetHashCode();
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
