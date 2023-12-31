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
    /// Set the file types to exclude from blocking the file download until verdict is reached by the capture service.
    /// </summary>
    [DataContract(Name = "capture_atp_base_capture_atp_exclude_file_type")]
    public partial class CaptureAtpBaseCaptureAtpExcludeFileType : IEquatable<CaptureAtpBaseCaptureAtpExcludeFileType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureAtpBaseCaptureAtpExcludeFileType" /> class.
        /// </summary>
        /// <param name="exe">Executables (PE, Mach-O, and DMG)..</param>
        /// <param name="pdf">PDF..</param>
        /// <param name="office">Office 97-2003(.doc , .xls ,...)..</param>
        /// <param name="officex">Office(.docx , .xlsx ,...)..</param>
        /// <param name="archives">Archives (.jar, .apk, .rar, .gz, and .zip)..</param>
        public CaptureAtpBaseCaptureAtpExcludeFileType(bool exe = default(bool), bool pdf = default(bool), bool office = default(bool), bool officex = default(bool), bool archives = default(bool))
        {
            this.Exe = exe;
            this.Pdf = pdf;
            this.Office = office;
            this.Officex = officex;
            this.Archives = archives;
        }

        /// <summary>
        /// Executables (PE, Mach-O, and DMG).
        /// </summary>
        /// <value>Executables (PE, Mach-O, and DMG).</value>
        [DataMember(Name = "exe", EmitDefaultValue = true)]
        public bool Exe { get; set; }

        /// <summary>
        /// PDF.
        /// </summary>
        /// <value>PDF.</value>
        [DataMember(Name = "pdf", EmitDefaultValue = true)]
        public bool Pdf { get; set; }

        /// <summary>
        /// Office 97-2003(.doc , .xls ,...).
        /// </summary>
        /// <value>Office 97-2003(.doc , .xls ,...).</value>
        [DataMember(Name = "office", EmitDefaultValue = true)]
        public bool Office { get; set; }

        /// <summary>
        /// Office(.docx , .xlsx ,...).
        /// </summary>
        /// <value>Office(.docx , .xlsx ,...).</value>
        [DataMember(Name = "officex", EmitDefaultValue = true)]
        public bool Officex { get; set; }

        /// <summary>
        /// Archives (.jar, .apk, .rar, .gz, and .zip).
        /// </summary>
        /// <value>Archives (.jar, .apk, .rar, .gz, and .zip).</value>
        [DataMember(Name = "archives", EmitDefaultValue = true)]
        public bool Archives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CaptureAtpBaseCaptureAtpExcludeFileType {\n");
            sb.Append("  Exe: ").Append(Exe).Append("\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  Officex: ").Append(Officex).Append("\n");
            sb.Append("  Archives: ").Append(Archives).Append("\n");
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
            return this.Equals(input as CaptureAtpBaseCaptureAtpExcludeFileType);
        }

        /// <summary>
        /// Returns true if CaptureAtpBaseCaptureAtpExcludeFileType instances are equal
        /// </summary>
        /// <param name="input">Instance of CaptureAtpBaseCaptureAtpExcludeFileType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaptureAtpBaseCaptureAtpExcludeFileType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Exe == input.Exe ||
                    this.Exe.Equals(input.Exe)
                ) && 
                (
                    this.Pdf == input.Pdf ||
                    this.Pdf.Equals(input.Pdf)
                ) && 
                (
                    this.Office == input.Office ||
                    this.Office.Equals(input.Office)
                ) && 
                (
                    this.Officex == input.Officex ||
                    this.Officex.Equals(input.Officex)
                ) && 
                (
                    this.Archives == input.Archives ||
                    this.Archives.Equals(input.Archives)
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
                hashCode = (hashCode * 59) + this.Exe.GetHashCode();
                hashCode = (hashCode * 59) + this.Pdf.GetHashCode();
                hashCode = (hashCode * 59) + this.Office.GetHashCode();
                hashCode = (hashCode * 59) + this.Officex.GetHashCode();
                hashCode = (hashCode * 59) + this.Archives.GetHashCode();
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
