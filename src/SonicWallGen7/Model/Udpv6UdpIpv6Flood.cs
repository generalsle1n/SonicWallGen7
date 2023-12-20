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
    /// UDP flood protection.
    /// </summary>
    [DataContract(Name = "udpv6_udp_ipv6_flood")]
    public partial class Udpv6UdpIpv6Flood : IEquatable<Udpv6UdpIpv6Flood>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Udpv6UdpIpv6Flood" /> class.
        /// </summary>
        /// <param name="protection">Enable UDP flood protection..</param>
        /// <param name="attackThreshold">Set UDP flood attack threshold (UDP packets / sec)..</param>
        /// <param name="blockTimeout">Set UDP flood attack blocking time (sec)..</param>
        /// <param name="protectedDestList">protectedDestList.</param>
        public Udpv6UdpIpv6Flood(bool protection = default(bool), decimal attackThreshold = default(decimal), decimal blockTimeout = default(decimal), Udpv6UdpIpv6FloodProtectedDestList protectedDestList = default(Udpv6UdpIpv6FloodProtectedDestList))
        {
            this.Protection = protection;
            this.AttackThreshold = attackThreshold;
            this.BlockTimeout = blockTimeout;
            this.ProtectedDestList = protectedDestList;
        }

        /// <summary>
        /// Enable UDP flood protection.
        /// </summary>
        /// <value>Enable UDP flood protection.</value>
        [DataMember(Name = "protection", EmitDefaultValue = true)]
        public bool Protection { get; set; }

        /// <summary>
        /// Set UDP flood attack threshold (UDP packets / sec).
        /// </summary>
        /// <value>Set UDP flood attack threshold (UDP packets / sec).</value>
        [DataMember(Name = "attack_threshold", EmitDefaultValue = false)]
        public decimal AttackThreshold { get; set; }

        /// <summary>
        /// Set UDP flood attack blocking time (sec).
        /// </summary>
        /// <value>Set UDP flood attack blocking time (sec).</value>
        [DataMember(Name = "block_timeout", EmitDefaultValue = false)]
        public decimal BlockTimeout { get; set; }

        /// <summary>
        /// Gets or Sets ProtectedDestList
        /// </summary>
        [DataMember(Name = "protected_dest_list", EmitDefaultValue = false)]
        public Udpv6UdpIpv6FloodProtectedDestList ProtectedDestList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Udpv6UdpIpv6Flood {\n");
            sb.Append("  Protection: ").Append(Protection).Append("\n");
            sb.Append("  AttackThreshold: ").Append(AttackThreshold).Append("\n");
            sb.Append("  BlockTimeout: ").Append(BlockTimeout).Append("\n");
            sb.Append("  ProtectedDestList: ").Append(ProtectedDestList).Append("\n");
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
            return this.Equals(input as Udpv6UdpIpv6Flood);
        }

        /// <summary>
        /// Returns true if Udpv6UdpIpv6Flood instances are equal
        /// </summary>
        /// <param name="input">Instance of Udpv6UdpIpv6Flood to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Udpv6UdpIpv6Flood input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Protection == input.Protection ||
                    this.Protection.Equals(input.Protection)
                ) && 
                (
                    this.AttackThreshold == input.AttackThreshold ||
                    this.AttackThreshold.Equals(input.AttackThreshold)
                ) && 
                (
                    this.BlockTimeout == input.BlockTimeout ||
                    this.BlockTimeout.Equals(input.BlockTimeout)
                ) && 
                (
                    this.ProtectedDestList == input.ProtectedDestList ||
                    (this.ProtectedDestList != null &&
                    this.ProtectedDestList.Equals(input.ProtectedDestList))
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
                hashCode = (hashCode * 59) + this.Protection.GetHashCode();
                hashCode = (hashCode * 59) + this.AttackThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockTimeout.GetHashCode();
                if (this.ProtectedDestList != null)
                {
                    hashCode = (hashCode * 59) + this.ProtectedDestList.GetHashCode();
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
