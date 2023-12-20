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
    /// IKE (phase 1) proposal.
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv4_site_to_site_ipv4_site_to_site_proposal_ike")]
    public partial class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke : IEquatable<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke>, IValidatableObject
    {
        /// <summary>
        /// Exchange.
        /// </summary>
        /// <value>Exchange.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExchangeEnum
        {
            /// <summary>
            /// Enum Main for value: main
            /// </summary>
            [EnumMember(Value = "main")]
            Main = 1,

            /// <summary>
            /// Enum Aggressive for value: aggressive
            /// </summary>
            [EnumMember(Value = "aggressive")]
            Aggressive = 2,

            /// <summary>
            /// Enum Ikev2 for value: ikev2
            /// </summary>
            [EnumMember(Value = "ikev2")]
            Ikev2 = 3
        }


        /// <summary>
        /// Exchange.
        /// </summary>
        /// <value>Exchange.</value>
        [DataMember(Name = "exchange", EmitDefaultValue = false)]
        public ExchangeEnum? Exchange { get; set; }
        /// <summary>
        /// Encryption algorithm.
        /// </summary>
        /// <value>Encryption algorithm.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionEnum
        {
            /// <summary>
            /// Enum Des for value: des
            /// </summary>
            [EnumMember(Value = "des")]
            Des = 1,

            /// <summary>
            /// Enum TripleDes for value: triple-des
            /// </summary>
            [EnumMember(Value = "triple-des")]
            TripleDes = 2,

            /// <summary>
            /// Enum Aes128 for value: aes-128
            /// </summary>
            [EnumMember(Value = "aes-128")]
            Aes128 = 3,

            /// <summary>
            /// Enum Aes192 for value: aes-192
            /// </summary>
            [EnumMember(Value = "aes-192")]
            Aes192 = 4,

            /// <summary>
            /// Enum Aes256 for value: aes-256
            /// </summary>
            [EnumMember(Value = "aes-256")]
            Aes256 = 5
        }


        /// <summary>
        /// Encryption algorithm.
        /// </summary>
        /// <value>Encryption algorithm.</value>
        [DataMember(Name = "encryption", EmitDefaultValue = false)]
        public EncryptionEnum? Encryption { get; set; }
        /// <summary>
        /// Authentication hashing encryption algorithm.
        /// </summary>
        /// <value>Authentication hashing encryption algorithm.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationEnum
        {
            /// <summary>
            /// Enum Md5 for value: md5
            /// </summary>
            [EnumMember(Value = "md5")]
            Md5 = 1,

            /// <summary>
            /// Enum Sha1 for value: sha-1
            /// </summary>
            [EnumMember(Value = "sha-1")]
            Sha1 = 2,

            /// <summary>
            /// Enum Sha256 for value: sha-256
            /// </summary>
            [EnumMember(Value = "sha-256")]
            Sha256 = 3,

            /// <summary>
            /// Enum Sha384 for value: sha-384
            /// </summary>
            [EnumMember(Value = "sha-384")]
            Sha384 = 4,

            /// <summary>
            /// Enum Sha512 for value: sha-512
            /// </summary>
            [EnumMember(Value = "sha-512")]
            Sha512 = 5
        }


        /// <summary>
        /// Authentication hashing encryption algorithm.
        /// </summary>
        /// <value>Authentication hashing encryption algorithm.</value>
        [DataMember(Name = "authentication", EmitDefaultValue = false)]
        public AuthenticationEnum? Authentication { get; set; }
        /// <summary>
        /// DH group.
        /// </summary>
        /// <value>DH group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DhGroupEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 3,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 4,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 5,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 6,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 7,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 8,

            /// <summary>
            /// Enum _26 for value: 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26 = 9
        }


        /// <summary>
        /// DH group.
        /// </summary>
        /// <value>DH group.</value>
        [DataMember(Name = "dh_group", EmitDefaultValue = false)]
        public DhGroupEnum? DhGroup { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke" /> class.
        /// </summary>
        /// <param name="exchange">Exchange..</param>
        /// <param name="encryption">Encryption algorithm..</param>
        /// <param name="authentication">Authentication hashing encryption algorithm..</param>
        /// <param name="dhGroup">DH group..</param>
        /// <param name="lifetime">Life time (seconds)..</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke(ExchangeEnum? exchange = default(ExchangeEnum?), EncryptionEnum? encryption = default(EncryptionEnum?), AuthenticationEnum? authentication = default(AuthenticationEnum?), DhGroupEnum? dhGroup = default(DhGroupEnum?), decimal lifetime = default(decimal))
        {
            this.Exchange = exchange;
            this.Encryption = encryption;
            this.Authentication = authentication;
            this.DhGroup = dhGroup;
            this.Lifetime = lifetime;
        }

        /// <summary>
        /// Life time (seconds).
        /// </summary>
        /// <value>Life time (seconds).</value>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public decimal Lifetime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke {\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  DhGroup: ").Append(DhGroup).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIke input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Exchange == input.Exchange ||
                    this.Exchange.Equals(input.Exchange)
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    this.Encryption.Equals(input.Encryption)
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    this.Authentication.Equals(input.Authentication)
                ) && 
                (
                    this.DhGroup == input.DhGroup ||
                    this.DhGroup.Equals(input.DhGroup)
                ) && 
                (
                    this.Lifetime == input.Lifetime ||
                    this.Lifetime.Equals(input.Lifetime)
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
                hashCode = (hashCode * 59) + this.Exchange.GetHashCode();
                hashCode = (hashCode * 59) + this.Encryption.GetHashCode();
                hashCode = (hashCode * 59) + this.Authentication.GetHashCode();
                hashCode = (hashCode * 59) + this.DhGroup.GetHashCode();
                hashCode = (hashCode * 59) + this.Lifetime.GetHashCode();
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
