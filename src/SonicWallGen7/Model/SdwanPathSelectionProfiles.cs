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
    /// SD-WAN path selection profile configuration.
    /// </summary>
    [DataContract(Name = "sdwan_path_selection_profiles")]
    public partial class SdwanPathSelectionProfiles : IEquatable<SdwanPathSelectionProfiles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SdwanPathSelectionProfiles" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SdwanPathSelectionProfiles() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SdwanPathSelectionProfiles" /> class.
        /// </summary>
        /// <param name="name">Edit path selection profile name. (required).</param>
        /// <param name="sdwanGroup">Set sdwan group..</param>
        /// <param name="slaProbe">Set SLA probe..</param>
        /// <param name="slaClass">Set SLA class..</param>
        /// <param name="backupInterface">Set backup interface..</param>
        /// <param name="probeDefaultUp">Enable SLA probe default state is UP..</param>
        /// <param name="resetConnections">Enable reset connections if path does not meet the performance criteria..</param>
        public SdwanPathSelectionProfiles(string name = default(string), string sdwanGroup = default(string), string slaProbe = default(string), string slaClass = default(string), string backupInterface = default(string), bool probeDefaultUp = default(bool), bool resetConnections = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SdwanPathSelectionProfiles and cannot be null");
            }
            this.Name = name;
            this.SdwanGroup = sdwanGroup;
            this.SlaProbe = slaProbe;
            this.SlaClass = slaClass;
            this.BackupInterface = backupInterface;
            this.ProbeDefaultUp = probeDefaultUp;
            this.ResetConnections = resetConnections;
        }

        /// <summary>
        /// Edit path selection profile name.
        /// </summary>
        /// <value>Edit path selection profile name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Set sdwan group.
        /// </summary>
        /// <value>Set sdwan group.</value>
        [DataMember(Name = "sdwan_group", EmitDefaultValue = false)]
        public string SdwanGroup { get; set; }

        /// <summary>
        /// Set SLA probe.
        /// </summary>
        /// <value>Set SLA probe.</value>
        [DataMember(Name = "sla_probe", EmitDefaultValue = false)]
        public string SlaProbe { get; set; }

        /// <summary>
        /// Set SLA class.
        /// </summary>
        /// <value>Set SLA class.</value>
        [DataMember(Name = "sla_class", EmitDefaultValue = false)]
        public string SlaClass { get; set; }

        /// <summary>
        /// Set backup interface.
        /// </summary>
        /// <value>Set backup interface.</value>
        [DataMember(Name = "backup_interface", EmitDefaultValue = false)]
        public string BackupInterface { get; set; }

        /// <summary>
        /// Enable SLA probe default state is UP.
        /// </summary>
        /// <value>Enable SLA probe default state is UP.</value>
        [DataMember(Name = "probe_default_up", EmitDefaultValue = true)]
        public bool ProbeDefaultUp { get; set; }

        /// <summary>
        /// Enable reset connections if path does not meet the performance criteria.
        /// </summary>
        /// <value>Enable reset connections if path does not meet the performance criteria.</value>
        [DataMember(Name = "reset_connections", EmitDefaultValue = true)]
        public bool ResetConnections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SdwanPathSelectionProfiles {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SdwanGroup: ").Append(SdwanGroup).Append("\n");
            sb.Append("  SlaProbe: ").Append(SlaProbe).Append("\n");
            sb.Append("  SlaClass: ").Append(SlaClass).Append("\n");
            sb.Append("  BackupInterface: ").Append(BackupInterface).Append("\n");
            sb.Append("  ProbeDefaultUp: ").Append(ProbeDefaultUp).Append("\n");
            sb.Append("  ResetConnections: ").Append(ResetConnections).Append("\n");
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
            return this.Equals(input as SdwanPathSelectionProfiles);
        }

        /// <summary>
        /// Returns true if SdwanPathSelectionProfiles instances are equal
        /// </summary>
        /// <param name="input">Instance of SdwanPathSelectionProfiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SdwanPathSelectionProfiles input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SdwanGroup == input.SdwanGroup ||
                    (this.SdwanGroup != null &&
                    this.SdwanGroup.Equals(input.SdwanGroup))
                ) && 
                (
                    this.SlaProbe == input.SlaProbe ||
                    (this.SlaProbe != null &&
                    this.SlaProbe.Equals(input.SlaProbe))
                ) && 
                (
                    this.SlaClass == input.SlaClass ||
                    (this.SlaClass != null &&
                    this.SlaClass.Equals(input.SlaClass))
                ) && 
                (
                    this.BackupInterface == input.BackupInterface ||
                    (this.BackupInterface != null &&
                    this.BackupInterface.Equals(input.BackupInterface))
                ) && 
                (
                    this.ProbeDefaultUp == input.ProbeDefaultUp ||
                    this.ProbeDefaultUp.Equals(input.ProbeDefaultUp)
                ) && 
                (
                    this.ResetConnections == input.ResetConnections ||
                    this.ResetConnections.Equals(input.ResetConnections)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SdwanGroup != null)
                {
                    hashCode = (hashCode * 59) + this.SdwanGroup.GetHashCode();
                }
                if (this.SlaProbe != null)
                {
                    hashCode = (hashCode * 59) + this.SlaProbe.GetHashCode();
                }
                if (this.SlaClass != null)
                {
                    hashCode = (hashCode * 59) + this.SlaClass.GetHashCode();
                }
                if (this.BackupInterface != null)
                {
                    hashCode = (hashCode * 59) + this.BackupInterface.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProbeDefaultUp.GetHashCode();
                hashCode = (hashCode * 59) + this.ResetConnections.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 49)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 49.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}