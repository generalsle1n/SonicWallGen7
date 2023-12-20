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
    /// Low danger attacks.
    /// </summary>
    [DataContract(Name = "anti_spyware_global_anti_spyware_signature_group_low_danger")]
    public partial class AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger : IEquatable<AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger" /> class.
        /// </summary>
        /// <param name="preventAll">Prevent all..</param>
        /// <param name="detectAll">Detect all..</param>
        /// <param name="logRedundancy">logRedundancy.</param>
        public AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger(bool preventAll = default(bool), bool detectAll = default(bool), AntiSpywareGlobalAntiSpywareSignatureGroupHighDangerLogRedundancy logRedundancy = default(AntiSpywareGlobalAntiSpywareSignatureGroupHighDangerLogRedundancy))
        {
            this.PreventAll = preventAll;
            this.DetectAll = detectAll;
            this.LogRedundancy = logRedundancy;
        }

        /// <summary>
        /// Prevent all.
        /// </summary>
        /// <value>Prevent all.</value>
        [DataMember(Name = "prevent_all", EmitDefaultValue = true)]
        public bool PreventAll { get; set; }

        /// <summary>
        /// Detect all.
        /// </summary>
        /// <value>Detect all.</value>
        [DataMember(Name = "detect_all", EmitDefaultValue = true)]
        public bool DetectAll { get; set; }

        /// <summary>
        /// Gets or Sets LogRedundancy
        /// </summary>
        [DataMember(Name = "log_redundancy", EmitDefaultValue = true)]
        public AntiSpywareGlobalAntiSpywareSignatureGroupHighDangerLogRedundancy LogRedundancy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger {\n");
            sb.Append("  PreventAll: ").Append(PreventAll).Append("\n");
            sb.Append("  DetectAll: ").Append(DetectAll).Append("\n");
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
            return this.Equals(input as AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger);
        }

        /// <summary>
        /// Returns true if AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger instances are equal
        /// </summary>
        /// <param name="input">Instance of AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntiSpywareGlobalAntiSpywareSignatureGroupLowDanger input)
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
                    this.DetectAll == input.DetectAll ||
                    this.DetectAll.Equals(input.DetectAll)
                ) && 
                (
                    this.LogRedundancy == input.LogRedundancy ||
                    (this.LogRedundancy != null &&
                    this.LogRedundancy.Equals(input.LogRedundancy))
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
                hashCode = (hashCode * 59) + this.DetectAll.GetHashCode();
                if (this.LogRedundancy != null)
                {
                    hashCode = (hashCode * 59) + this.LogRedundancy.GetHashCode();
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
