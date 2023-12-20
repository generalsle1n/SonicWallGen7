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
    /// FirmwareFirmwareAuto
    /// </summary>
    [DataContract(Name = "firmware_firmware_auto")]
    public partial class FirmwareFirmwareAuto : IEquatable<FirmwareFirmwareAuto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareFirmwareAuto" /> class.
        /// </summary>
        /// <param name="update">update.</param>
        /// <param name="download">download.</param>
        public FirmwareFirmwareAuto(bool update = default(bool), bool download = default(bool))
        {
            this.Update = update;
            this.Download = download;
        }

        /// <summary>
        /// Gets or Sets Update
        /// </summary>
        [DataMember(Name = "update", EmitDefaultValue = true)]
        public bool Update { get; set; }

        /// <summary>
        /// Gets or Sets Download
        /// </summary>
        [DataMember(Name = "download", EmitDefaultValue = true)]
        public bool Download { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirmwareFirmwareAuto {\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
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
            return this.Equals(input as FirmwareFirmwareAuto);
        }

        /// <summary>
        /// Returns true if FirmwareFirmwareAuto instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmwareFirmwareAuto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareFirmwareAuto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Update == input.Update ||
                    this.Update.Equals(input.Update)
                ) && 
                (
                    this.Download == input.Download ||
                    this.Download.Equals(input.Download)
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
                hashCode = (hashCode * 59) + this.Update.GetHashCode();
                hashCode = (hashCode * 59) + this.Download.GetHashCode();
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