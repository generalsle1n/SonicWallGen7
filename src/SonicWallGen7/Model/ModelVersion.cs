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
    /// Version configuration.
    /// </summary>
    [DataContract(Name = "version")]
    public partial class ModelVersion : IEquatable<ModelVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersion" /> class.
        /// </summary>
        /// <param name="firmwareVersion">firmwareVersion.</param>
        /// <param name="romVersion">romVersion.</param>
        /// <param name="safemodeVersion">safemodeVersion.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="model">model.</param>
        /// <param name="systemTime">systemTime.</param>
        /// <param name="systemUptime">systemUptime.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        public ModelVersion(string firmwareVersion = default(string), string romVersion = default(string), string safemodeVersion = default(string), string serialNumber = default(string), string model = default(string), string systemTime = default(string), string systemUptime = default(string), string lastModifiedBy = default(string))
        {
            this.FirmwareVersion = firmwareVersion;
            this.RomVersion = romVersion;
            this.SafemodeVersion = safemodeVersion;
            this.SerialNumber = serialNumber;
            this.Model = model;
            this.SystemTime = systemTime;
            this.SystemUptime = systemUptime;
            this.LastModifiedBy = lastModifiedBy;
        }

        /// <summary>
        /// Gets or Sets FirmwareVersion
        /// </summary>
        [DataMember(Name = "firmware_version", EmitDefaultValue = false)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or Sets RomVersion
        /// </summary>
        [DataMember(Name = "rom_version", EmitDefaultValue = false)]
        public string RomVersion { get; set; }

        /// <summary>
        /// Gets or Sets SafemodeVersion
        /// </summary>
        [DataMember(Name = "safemode_version", EmitDefaultValue = false)]
        public string SafemodeVersion { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets SystemTime
        /// </summary>
        [DataMember(Name = "system_time", EmitDefaultValue = false)]
        public string SystemTime { get; set; }

        /// <summary>
        /// Gets or Sets SystemUptime
        /// </summary>
        [DataMember(Name = "system_uptime", EmitDefaultValue = false)]
        public string SystemUptime { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name = "last_modified_by", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelVersion {\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
            sb.Append("  RomVersion: ").Append(RomVersion).Append("\n");
            sb.Append("  SafemodeVersion: ").Append(SafemodeVersion).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  SystemTime: ").Append(SystemTime).Append("\n");
            sb.Append("  SystemUptime: ").Append(SystemUptime).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
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
            return this.Equals(input as ModelVersion);
        }

        /// <summary>
        /// Returns true if ModelVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelVersion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirmwareVersion == input.FirmwareVersion ||
                    (this.FirmwareVersion != null &&
                    this.FirmwareVersion.Equals(input.FirmwareVersion))
                ) && 
                (
                    this.RomVersion == input.RomVersion ||
                    (this.RomVersion != null &&
                    this.RomVersion.Equals(input.RomVersion))
                ) && 
                (
                    this.SafemodeVersion == input.SafemodeVersion ||
                    (this.SafemodeVersion != null &&
                    this.SafemodeVersion.Equals(input.SafemodeVersion))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.SystemTime == input.SystemTime ||
                    (this.SystemTime != null &&
                    this.SystemTime.Equals(input.SystemTime))
                ) && 
                (
                    this.SystemUptime == input.SystemUptime ||
                    (this.SystemUptime != null &&
                    this.SystemUptime.Equals(input.SystemUptime))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
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
                if (this.FirmwareVersion != null)
                {
                    hashCode = (hashCode * 59) + this.FirmwareVersion.GetHashCode();
                }
                if (this.RomVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RomVersion.GetHashCode();
                }
                if (this.SafemodeVersion != null)
                {
                    hashCode = (hashCode * 59) + this.SafemodeVersion.GetHashCode();
                }
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.SystemTime != null)
                {
                    hashCode = (hashCode * 59) + this.SystemTime.GetHashCode();
                }
                if (this.SystemUptime != null)
                {
                    hashCode = (hashCode * 59) + this.SystemUptime.GetHashCode();
                }
                if (this.LastModifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedBy.GetHashCode();
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
