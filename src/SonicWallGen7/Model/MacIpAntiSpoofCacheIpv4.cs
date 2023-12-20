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
    /// MAC IP anti-spoof IPv4 cache entries configuration schema.
    /// </summary>
    [DataContract(Name = "mac_ip_anti_spoof_cache_ipv4")]
    public partial class MacIpAntiSpoofCacheIpv4 : IEquatable<MacIpAntiSpoofCacheIpv4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacIpAntiSpoofCacheIpv4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MacIpAntiSpoofCacheIpv4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MacIpAntiSpoofCacheIpv4" /> class.
        /// </summary>
        /// <param name="ip">IP address. * Set to null to represent an unconfigured state. (required).</param>
        /// <param name="mac">MAC address. (required).</param>
        /// <param name="varInterface">Interface. (required).</param>
        /// <param name="router">Device is a router(a network exist behind this device)..</param>
        /// <param name="blacklisted">Device is blacklisted..</param>
        public MacIpAntiSpoofCacheIpv4(string ip = default(string), string mac = default(string), string varInterface = default(string), bool router = default(bool), bool blacklisted = default(bool))
        {
            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new ArgumentNullException("ip is a required property for MacIpAntiSpoofCacheIpv4 and cannot be null");
            }
            this.Ip = ip;
            // to ensure "mac" is required (not null)
            if (mac == null)
            {
                throw new ArgumentNullException("mac is a required property for MacIpAntiSpoofCacheIpv4 and cannot be null");
            }
            this.Mac = mac;
            // to ensure "varInterface" is required (not null)
            if (varInterface == null)
            {
                throw new ArgumentNullException("varInterface is a required property for MacIpAntiSpoofCacheIpv4 and cannot be null");
            }
            this.VarInterface = varInterface;
            this.Router = router;
            this.Blacklisted = blacklisted;
        }

        /// <summary>
        /// IP address. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>IP address. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "ip", IsRequired = true, EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// MAC address.
        /// </summary>
        /// <value>MAC address.</value>
        [DataMember(Name = "mac", IsRequired = true, EmitDefaultValue = true)]
        public string Mac { get; set; }

        /// <summary>
        /// Interface.
        /// </summary>
        /// <value>Interface.</value>
        [DataMember(Name = "interface", IsRequired = true, EmitDefaultValue = true)]
        public string VarInterface { get; set; }

        /// <summary>
        /// Device is a router(a network exist behind this device).
        /// </summary>
        /// <value>Device is a router(a network exist behind this device).</value>
        [DataMember(Name = "router", EmitDefaultValue = true)]
        public bool Router { get; set; }

        /// <summary>
        /// Device is blacklisted.
        /// </summary>
        /// <value>Device is blacklisted.</value>
        [DataMember(Name = "blacklisted", EmitDefaultValue = true)]
        public bool Blacklisted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MacIpAntiSpoofCacheIpv4 {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  VarInterface: ").Append(VarInterface).Append("\n");
            sb.Append("  Router: ").Append(Router).Append("\n");
            sb.Append("  Blacklisted: ").Append(Blacklisted).Append("\n");
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
            return this.Equals(input as MacIpAntiSpoofCacheIpv4);
        }

        /// <summary>
        /// Returns true if MacIpAntiSpoofCacheIpv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of MacIpAntiSpoofCacheIpv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MacIpAntiSpoofCacheIpv4 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.VarInterface == input.VarInterface ||
                    (this.VarInterface != null &&
                    this.VarInterface.Equals(input.VarInterface))
                ) && 
                (
                    this.Router == input.Router ||
                    this.Router.Equals(input.Router)
                ) && 
                (
                    this.Blacklisted == input.Blacklisted ||
                    this.Blacklisted.Equals(input.Blacklisted)
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
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                if (this.Mac != null)
                {
                    hashCode = (hashCode * 59) + this.Mac.GetHashCode();
                }
                if (this.VarInterface != null)
                {
                    hashCode = (hashCode * 59) + this.VarInterface.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Router.GetHashCode();
                hashCode = (hashCode * 59) + this.Blacklisted.GetHashCode();
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