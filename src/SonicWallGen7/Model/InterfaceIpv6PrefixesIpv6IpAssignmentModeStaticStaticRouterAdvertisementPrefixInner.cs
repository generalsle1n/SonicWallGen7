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
    /// InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner
    /// </summary>
    [DataContract(Name = "interface_ipv6_prefixes_ipv6_ip_assignment_mode_static_static_router_advertisement_prefix_inner")]
    public partial class InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner : IEquatable<InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner" /> class.
        /// </summary>
        /// <param name="prefix">Set advertising prefix. (required).</param>
        /// <param name="validLifetime">Set advertising prefix valid lifetime in minutes..</param>
        /// <param name="preferred">preferred.</param>
        /// <param name="onLink">Enable using prefix for on-link determination..</param>
        /// <param name="autonomous">Enable autonomous address configuration indicating prefix can be used for stateless address configuration..</param>
        public InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner(string prefix = default(string), decimal validLifetime = default(decimal), InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInnerPreferred preferred = default(InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInnerPreferred), bool onLink = default(bool), bool autonomous = default(bool))
        {
            // to ensure "prefix" is required (not null)
            if (prefix == null)
            {
                throw new ArgumentNullException("prefix is a required property for InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner and cannot be null");
            }
            this.Prefix = prefix;
            this.ValidLifetime = validLifetime;
            this.Preferred = preferred;
            this.OnLink = onLink;
            this.Autonomous = autonomous;
        }

        /// <summary>
        /// Set advertising prefix.
        /// </summary>
        /// <value>Set advertising prefix.</value>
        [DataMember(Name = "prefix", IsRequired = true, EmitDefaultValue = true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Set advertising prefix valid lifetime in minutes.
        /// </summary>
        /// <value>Set advertising prefix valid lifetime in minutes.</value>
        [DataMember(Name = "valid_lifetime", EmitDefaultValue = false)]
        public decimal ValidLifetime { get; set; }

        /// <summary>
        /// Gets or Sets Preferred
        /// </summary>
        [DataMember(Name = "preferred", EmitDefaultValue = false)]
        public InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInnerPreferred Preferred { get; set; }

        /// <summary>
        /// Enable using prefix for on-link determination.
        /// </summary>
        /// <value>Enable using prefix for on-link determination.</value>
        [DataMember(Name = "on_link", EmitDefaultValue = true)]
        public bool OnLink { get; set; }

        /// <summary>
        /// Enable autonomous address configuration indicating prefix can be used for stateless address configuration.
        /// </summary>
        /// <value>Enable autonomous address configuration indicating prefix can be used for stateless address configuration.</value>
        [DataMember(Name = "autonomous", EmitDefaultValue = true)]
        public bool Autonomous { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  ValidLifetime: ").Append(ValidLifetime).Append("\n");
            sb.Append("  Preferred: ").Append(Preferred).Append("\n");
            sb.Append("  OnLink: ").Append(OnLink).Append("\n");
            sb.Append("  Autonomous: ").Append(Autonomous).Append("\n");
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
            return this.Equals(input as InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner);
        }

        /// <summary>
        /// Returns true if InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv6PrefixesIpv6IpAssignmentModeStaticStaticRouterAdvertisementPrefixInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.ValidLifetime == input.ValidLifetime ||
                    this.ValidLifetime.Equals(input.ValidLifetime)
                ) && 
                (
                    this.Preferred == input.Preferred ||
                    (this.Preferred != null &&
                    this.Preferred.Equals(input.Preferred))
                ) && 
                (
                    this.OnLink == input.OnLink ||
                    this.OnLink.Equals(input.OnLink)
                ) && 
                (
                    this.Autonomous == input.Autonomous ||
                    this.Autonomous.Equals(input.Autonomous)
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
                if (this.Prefix != null)
                {
                    hashCode = (hashCode * 59) + this.Prefix.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValidLifetime.GetHashCode();
                if (this.Preferred != null)
                {
                    hashCode = (hashCode * 59) + this.Preferred.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OnLink.GetHashCode();
                hashCode = (hashCode * 59) + this.Autonomous.GetHashCode();
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
