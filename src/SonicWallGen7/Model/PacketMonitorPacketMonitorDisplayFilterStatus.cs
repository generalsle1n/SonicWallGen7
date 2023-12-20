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
    /// Enable display filtering for the specified status.
    /// </summary>
    [DataContract(Name = "packet_monitor_packet_monitor_display_filter_status")]
    public partial class PacketMonitorPacketMonitorDisplayFilterStatus : IEquatable<PacketMonitorPacketMonitorDisplayFilterStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketMonitorPacketMonitorDisplayFilterStatus" /> class.
        /// </summary>
        /// <param name="forwarded">Forwarded..</param>
        /// <param name="generated">Generated..</param>
        /// <param name="consumed">Consumed..</param>
        /// <param name="dropped">Dropped..</param>
        public PacketMonitorPacketMonitorDisplayFilterStatus(bool forwarded = default(bool), bool generated = default(bool), bool consumed = default(bool), bool dropped = default(bool))
        {
            this.Forwarded = forwarded;
            this.Generated = generated;
            this.Consumed = consumed;
            this.Dropped = dropped;
        }

        /// <summary>
        /// Forwarded.
        /// </summary>
        /// <value>Forwarded.</value>
        [DataMember(Name = "forwarded", EmitDefaultValue = true)]
        public bool Forwarded { get; set; }

        /// <summary>
        /// Generated.
        /// </summary>
        /// <value>Generated.</value>
        [DataMember(Name = "generated", EmitDefaultValue = true)]
        public bool Generated { get; set; }

        /// <summary>
        /// Consumed.
        /// </summary>
        /// <value>Consumed.</value>
        [DataMember(Name = "consumed", EmitDefaultValue = true)]
        public bool Consumed { get; set; }

        /// <summary>
        /// Dropped.
        /// </summary>
        /// <value>Dropped.</value>
        [DataMember(Name = "dropped", EmitDefaultValue = true)]
        public bool Dropped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketMonitorPacketMonitorDisplayFilterStatus {\n");
            sb.Append("  Forwarded: ").Append(Forwarded).Append("\n");
            sb.Append("  Generated: ").Append(Generated).Append("\n");
            sb.Append("  Consumed: ").Append(Consumed).Append("\n");
            sb.Append("  Dropped: ").Append(Dropped).Append("\n");
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
            return this.Equals(input as PacketMonitorPacketMonitorDisplayFilterStatus);
        }

        /// <summary>
        /// Returns true if PacketMonitorPacketMonitorDisplayFilterStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketMonitorPacketMonitorDisplayFilterStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketMonitorPacketMonitorDisplayFilterStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Forwarded == input.Forwarded ||
                    this.Forwarded.Equals(input.Forwarded)
                ) && 
                (
                    this.Generated == input.Generated ||
                    this.Generated.Equals(input.Generated)
                ) && 
                (
                    this.Consumed == input.Consumed ||
                    this.Consumed.Equals(input.Consumed)
                ) && 
                (
                    this.Dropped == input.Dropped ||
                    this.Dropped.Equals(input.Dropped)
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
                hashCode = (hashCode * 59) + this.Forwarded.GetHashCode();
                hashCode = (hashCode * 59) + this.Generated.GetHashCode();
                hashCode = (hashCode * 59) + this.Consumed.GetHashCode();
                hashCode = (hashCode * 59) + this.Dropped.GetHashCode();
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
