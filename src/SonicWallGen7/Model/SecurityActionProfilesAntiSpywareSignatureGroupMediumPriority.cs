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
    /// Medium priority attacks.
    /// </summary>
    [DataContract(Name = "security_action_profiles_anti_spyware_signature_group_medium_priority")]
    public partial class SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority : IEquatable<SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority" /> class.
        /// </summary>
        /// <param name="prevent">Prevent all..</param>
        /// <param name="packetMonitor">Packet monitor all..</param>
        /// <param name="log">Log all..</param>
        /// <param name="logRedundancy">Set log redundancy in seconds..</param>
        public SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority(bool prevent = default(bool), bool packetMonitor = default(bool), bool log = default(bool), decimal logRedundancy = default(decimal))
        {
            this.Prevent = prevent;
            this.PacketMonitor = packetMonitor;
            this.Log = log;
            this.LogRedundancy = logRedundancy;
        }

        /// <summary>
        /// Prevent all.
        /// </summary>
        /// <value>Prevent all.</value>
        [DataMember(Name = "prevent", EmitDefaultValue = true)]
        public bool Prevent { get; set; }

        /// <summary>
        /// Packet monitor all.
        /// </summary>
        /// <value>Packet monitor all.</value>
        [DataMember(Name = "packet_monitor", EmitDefaultValue = true)]
        public bool PacketMonitor { get; set; }

        /// <summary>
        /// Log all.
        /// </summary>
        /// <value>Log all.</value>
        [DataMember(Name = "log", EmitDefaultValue = true)]
        public bool Log { get; set; }

        /// <summary>
        /// Set log redundancy in seconds.
        /// </summary>
        /// <value>Set log redundancy in seconds.</value>
        [DataMember(Name = "log_redundancy", EmitDefaultValue = false)]
        public decimal LogRedundancy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority {\n");
            sb.Append("  Prevent: ").Append(Prevent).Append("\n");
            sb.Append("  PacketMonitor: ").Append(PacketMonitor).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
            sb.Append("  LogRedundancy: ").Append(LogRedundancy).Append("\n");
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
            return this.Equals(input as SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority);
        }

        /// <summary>
        /// Returns true if SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityActionProfilesAntiSpywareSignatureGroupMediumPriority input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Prevent == input.Prevent ||
                    this.Prevent.Equals(input.Prevent)
                ) && 
                (
                    this.PacketMonitor == input.PacketMonitor ||
                    this.PacketMonitor.Equals(input.PacketMonitor)
                ) && 
                (
                    this.Log == input.Log ||
                    this.Log.Equals(input.Log)
                ) && 
                (
                    this.LogRedundancy == input.LogRedundancy ||
                    this.LogRedundancy.Equals(input.LogRedundancy)
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
                hashCode = (hashCode * 59) + this.Prevent.GetHashCode();
                hashCode = (hashCode * 59) + this.PacketMonitor.GetHashCode();
                hashCode = (hashCode * 59) + this.Log.GetHashCode();
                hashCode = (hashCode * 59) + this.LogRedundancy.GetHashCode();
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