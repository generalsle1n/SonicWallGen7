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
    /// Enter global threat profile for zone mode.
    /// </summary>
    [DataContract(Name = "policies_setting_base_policies_setting_threat_profile_for_zone")]
    public partial class PoliciesSettingBasePoliciesSettingThreatProfileForZone : IEquatable<PoliciesSettingBasePoliciesSettingThreatProfileForZone>, IValidatableObject
    {
        /// <summary>
        /// Set what threat profile is based on.
        /// </summary>
        /// <value>Set what threat profile is based on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BasedOnEnum
        {
            /// <summary>
            /// Enum Object for value: object
            /// </summary>
            [EnumMember(Value = "object")]
            Object = 1,

            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 2
        }


        /// <summary>
        /// Set what threat profile is based on.
        /// </summary>
        /// <value>Set what threat profile is based on.</value>
        [DataMember(Name = "based_on", EmitDefaultValue = false)]
        public BasedOnEnum? BasedOn { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesSettingBasePoliciesSettingThreatProfileForZone" /> class.
        /// </summary>
        /// <param name="basedOn">Set what threat profile is based on..</param>
        /// <param name="prevent">prevent.</param>
        /// <param name="packetMonitor">packetMonitor.</param>
        /// <param name="log">log.</param>
        /// <param name="highPriority">highPriority.</param>
        /// <param name="mediumPriority">mediumPriority.</param>
        /// <param name="lowPriority">lowPriority.</param>
        public PoliciesSettingBasePoliciesSettingThreatProfileForZone(BasedOnEnum? basedOn = default(BasedOnEnum?), PoliciesSettingBasePoliciesSettingThreatProfileForZonePrevent prevent = default(PoliciesSettingBasePoliciesSettingThreatProfileForZonePrevent), PoliciesSettingBasePoliciesSettingThreatProfileForZonePacketMonitor packetMonitor = default(PoliciesSettingBasePoliciesSettingThreatProfileForZonePacketMonitor), PoliciesSettingBasePoliciesSettingThreatProfileForZoneLog log = default(PoliciesSettingBasePoliciesSettingThreatProfileForZoneLog), SecurityActionProfilesThreatSignatureGroupHighPriority highPriority = default(SecurityActionProfilesThreatSignatureGroupHighPriority), SecurityActionProfilesThreatSignatureGroupMediumPriority mediumPriority = default(SecurityActionProfilesThreatSignatureGroupMediumPriority), SecurityActionProfilesThreatSignatureGroupLowPriority lowPriority = default(SecurityActionProfilesThreatSignatureGroupLowPriority))
        {
            this.BasedOn = basedOn;
            this.Prevent = prevent;
            this.PacketMonitor = packetMonitor;
            this.Log = log;
            this.HighPriority = highPriority;
            this.MediumPriority = mediumPriority;
            this.LowPriority = lowPriority;
        }

        /// <summary>
        /// Gets or Sets Prevent
        /// </summary>
        [DataMember(Name = "prevent", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingThreatProfileForZonePrevent Prevent { get; set; }

        /// <summary>
        /// Gets or Sets PacketMonitor
        /// </summary>
        [DataMember(Name = "packet_monitor", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingThreatProfileForZonePacketMonitor PacketMonitor { get; set; }

        /// <summary>
        /// Gets or Sets Log
        /// </summary>
        [DataMember(Name = "log", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingThreatProfileForZoneLog Log { get; set; }

        /// <summary>
        /// Gets or Sets HighPriority
        /// </summary>
        [DataMember(Name = "high_priority", EmitDefaultValue = false)]
        public SecurityActionProfilesThreatSignatureGroupHighPriority HighPriority { get; set; }

        /// <summary>
        /// Gets or Sets MediumPriority
        /// </summary>
        [DataMember(Name = "medium_priority", EmitDefaultValue = false)]
        public SecurityActionProfilesThreatSignatureGroupMediumPriority MediumPriority { get; set; }

        /// <summary>
        /// Gets or Sets LowPriority
        /// </summary>
        [DataMember(Name = "low_priority", EmitDefaultValue = false)]
        public SecurityActionProfilesThreatSignatureGroupLowPriority LowPriority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PoliciesSettingBasePoliciesSettingThreatProfileForZone {\n");
            sb.Append("  BasedOn: ").Append(BasedOn).Append("\n");
            sb.Append("  Prevent: ").Append(Prevent).Append("\n");
            sb.Append("  PacketMonitor: ").Append(PacketMonitor).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
            sb.Append("  HighPriority: ").Append(HighPriority).Append("\n");
            sb.Append("  MediumPriority: ").Append(MediumPriority).Append("\n");
            sb.Append("  LowPriority: ").Append(LowPriority).Append("\n");
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
            return this.Equals(input as PoliciesSettingBasePoliciesSettingThreatProfileForZone);
        }

        /// <summary>
        /// Returns true if PoliciesSettingBasePoliciesSettingThreatProfileForZone instances are equal
        /// </summary>
        /// <param name="input">Instance of PoliciesSettingBasePoliciesSettingThreatProfileForZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoliciesSettingBasePoliciesSettingThreatProfileForZone input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BasedOn == input.BasedOn ||
                    this.BasedOn.Equals(input.BasedOn)
                ) && 
                (
                    this.Prevent == input.Prevent ||
                    (this.Prevent != null &&
                    this.Prevent.Equals(input.Prevent))
                ) && 
                (
                    this.PacketMonitor == input.PacketMonitor ||
                    (this.PacketMonitor != null &&
                    this.PacketMonitor.Equals(input.PacketMonitor))
                ) && 
                (
                    this.Log == input.Log ||
                    (this.Log != null &&
                    this.Log.Equals(input.Log))
                ) && 
                (
                    this.HighPriority == input.HighPriority ||
                    (this.HighPriority != null &&
                    this.HighPriority.Equals(input.HighPriority))
                ) && 
                (
                    this.MediumPriority == input.MediumPriority ||
                    (this.MediumPriority != null &&
                    this.MediumPriority.Equals(input.MediumPriority))
                ) && 
                (
                    this.LowPriority == input.LowPriority ||
                    (this.LowPriority != null &&
                    this.LowPriority.Equals(input.LowPriority))
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
                hashCode = (hashCode * 59) + this.BasedOn.GetHashCode();
                if (this.Prevent != null)
                {
                    hashCode = (hashCode * 59) + this.Prevent.GetHashCode();
                }
                if (this.PacketMonitor != null)
                {
                    hashCode = (hashCode * 59) + this.PacketMonitor.GetHashCode();
                }
                if (this.Log != null)
                {
                    hashCode = (hashCode * 59) + this.Log.GetHashCode();
                }
                if (this.HighPriority != null)
                {
                    hashCode = (hashCode * 59) + this.HighPriority.GetHashCode();
                }
                if (this.MediumPriority != null)
                {
                    hashCode = (hashCode * 59) + this.MediumPriority.GetHashCode();
                }
                if (this.LowPriority != null)
                {
                    hashCode = (hashCode * 59) + this.LowPriority.GetHashCode();
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
