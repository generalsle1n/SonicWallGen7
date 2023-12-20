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
    /// Medium danger attacks.
    /// </summary>
    [DataContract(Name = "policies_setting_base_policies_setting_antispyware_profile_for_zone_medium_danger")]
    public partial class PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger : IEquatable<PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger" /> class.
        /// </summary>
        /// <param name="preventAll">Prevent all..</param>
        /// <param name="packetMonitorAll">Packet monitor all..</param>
        /// <param name="logAll">Log all..</param>
        /// <param name="logRedundancy">Set log redundancy in seconds..</param>
        public PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger(bool preventAll = default(bool), bool packetMonitorAll = default(bool), bool logAll = default(bool), decimal logRedundancy = default(decimal))
        {
            this.PreventAll = preventAll;
            this.PacketMonitorAll = packetMonitorAll;
            this.LogAll = logAll;
            this.LogRedundancy = logRedundancy;
        }

        /// <summary>
        /// Prevent all.
        /// </summary>
        /// <value>Prevent all.</value>
        [DataMember(Name = "prevent_all", EmitDefaultValue = true)]
        public bool PreventAll { get; set; }

        /// <summary>
        /// Packet monitor all.
        /// </summary>
        /// <value>Packet monitor all.</value>
        [DataMember(Name = "packet_monitor_all", EmitDefaultValue = true)]
        public bool PacketMonitorAll { get; set; }

        /// <summary>
        /// Log all.
        /// </summary>
        /// <value>Log all.</value>
        [DataMember(Name = "log_all", EmitDefaultValue = true)]
        public bool LogAll { get; set; }

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
            sb.Append("class PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger {\n");
            sb.Append("  PreventAll: ").Append(PreventAll).Append("\n");
            sb.Append("  PacketMonitorAll: ").Append(PacketMonitorAll).Append("\n");
            sb.Append("  LogAll: ").Append(LogAll).Append("\n");
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
            return this.Equals(input as PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger);
        }

        /// <summary>
        /// Returns true if PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger instances are equal
        /// </summary>
        /// <param name="input">Instance of PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoliciesSettingBasePoliciesSettingAntispywareProfileForZoneMediumDanger input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PreventAll == input.PreventAll ||
                    this.PreventAll.Equals(input.PreventAll)
                ) && 
                (
                    this.PacketMonitorAll == input.PacketMonitorAll ||
                    this.PacketMonitorAll.Equals(input.PacketMonitorAll)
                ) && 
                (
                    this.LogAll == input.LogAll ||
                    this.LogAll.Equals(input.LogAll)
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
                hashCode = (hashCode * 59) + this.PreventAll.GetHashCode();
                hashCode = (hashCode * 59) + this.PacketMonitorAll.GetHashCode();
                hashCode = (hashCode * 59) + this.LogAll.GetHashCode();
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
