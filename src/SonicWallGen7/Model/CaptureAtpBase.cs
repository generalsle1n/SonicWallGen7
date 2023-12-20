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
    /// Capture ATP base settings.
    /// </summary>
    [DataContract(Name = "capture_atp_base")]
    public partial class CaptureAtpBase : IEquatable<CaptureAtpBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureAtpBase" /> class.
        /// </summary>
        /// <param name="captureAtp">captureAtp.</param>
        public CaptureAtpBase(CaptureAtpBaseCaptureAtp captureAtp = default(CaptureAtpBaseCaptureAtp))
        {
            this.CaptureAtp = captureAtp;
        }

        /// <summary>
        /// Gets or Sets CaptureAtp
        /// </summary>
        [DataMember(Name = "capture_atp", EmitDefaultValue = false)]
        public CaptureAtpBaseCaptureAtp CaptureAtp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CaptureAtpBase {\n");
            sb.Append("  CaptureAtp: ").Append(CaptureAtp).Append("\n");
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
            return this.Equals(input as CaptureAtpBase);
        }

        /// <summary>
        /// Returns true if CaptureAtpBase instances are equal
        /// </summary>
        /// <param name="input">Instance of CaptureAtpBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaptureAtpBase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CaptureAtp == input.CaptureAtp ||
                    (this.CaptureAtp != null &&
                    this.CaptureAtp.Equals(input.CaptureAtp))
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
                if (this.CaptureAtp != null)
                {
                    hashCode = (hashCode * 59) + this.CaptureAtp.GetHashCode();
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
