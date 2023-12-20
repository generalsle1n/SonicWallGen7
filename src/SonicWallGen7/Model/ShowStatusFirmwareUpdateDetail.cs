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
    /// firmware update detail schema.
    /// </summary>
    [DataContract(Name = "show_status_firmware_update_detail")]
    public partial class ShowStatusFirmwareUpdateDetail : IEquatable<ShowStatusFirmwareUpdateDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusFirmwareUpdateDetail" /> class.
        /// </summary>
        /// <param name="currentStatus">currentStatus.</param>
        /// <param name="updateVersion">updateVersion.</param>
        /// <param name="updateUrl">updateUrl.</param>
        public ShowStatusFirmwareUpdateDetail(string currentStatus = default(string), string updateVersion = default(string), string updateUrl = default(string))
        {
            this.CurrentStatus = currentStatus;
            this.UpdateVersion = updateVersion;
            this.UpdateUrl = updateUrl;
        }

        /// <summary>
        /// Gets or Sets CurrentStatus
        /// </summary>
        [DataMember(Name = "current_status", EmitDefaultValue = false)]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// Gets or Sets UpdateVersion
        /// </summary>
        [DataMember(Name = "update_version", EmitDefaultValue = false)]
        public string UpdateVersion { get; set; }

        /// <summary>
        /// Gets or Sets UpdateUrl
        /// </summary>
        [DataMember(Name = "update_url", EmitDefaultValue = false)]
        public string UpdateUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusFirmwareUpdateDetail {\n");
            sb.Append("  CurrentStatus: ").Append(CurrentStatus).Append("\n");
            sb.Append("  UpdateVersion: ").Append(UpdateVersion).Append("\n");
            sb.Append("  UpdateUrl: ").Append(UpdateUrl).Append("\n");
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
            return this.Equals(input as ShowStatusFirmwareUpdateDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusFirmwareUpdateDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusFirmwareUpdateDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusFirmwareUpdateDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentStatus == input.CurrentStatus ||
                    (this.CurrentStatus != null &&
                    this.CurrentStatus.Equals(input.CurrentStatus))
                ) && 
                (
                    this.UpdateVersion == input.UpdateVersion ||
                    (this.UpdateVersion != null &&
                    this.UpdateVersion.Equals(input.UpdateVersion))
                ) && 
                (
                    this.UpdateUrl == input.UpdateUrl ||
                    (this.UpdateUrl != null &&
                    this.UpdateUrl.Equals(input.UpdateUrl))
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
                if (this.CurrentStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentStatus.GetHashCode();
                }
                if (this.UpdateVersion != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateVersion.GetHashCode();
                }
                if (this.UpdateUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUrl.GetHashCode();
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
