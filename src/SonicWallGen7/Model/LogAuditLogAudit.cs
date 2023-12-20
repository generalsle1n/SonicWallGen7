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
    /// Configuration audit settings.
    /// </summary>
    [DataContract(Name = "log_audit_log_audit")]
    public partial class LogAuditLogAudit : IEquatable<LogAuditLogAudit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogAuditLogAudit" /> class.
        /// </summary>
        /// <param name="enable">Enable logging of configuration changes..</param>
        /// <param name="displayOnConsole">Auditing records are shown on the console as configuration changes are detected..</param>
        /// <param name="supplementalChanges">Enable logging of configuration audit for supplemental parameter changes..</param>
        public LogAuditLogAudit(bool enable = default(bool), bool displayOnConsole = default(bool), bool supplementalChanges = default(bool))
        {
            this.Enable = enable;
            this.DisplayOnConsole = displayOnConsole;
            this.SupplementalChanges = supplementalChanges;
        }

        /// <summary>
        /// Enable logging of configuration changes.
        /// </summary>
        /// <value>Enable logging of configuration changes.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Auditing records are shown on the console as configuration changes are detected.
        /// </summary>
        /// <value>Auditing records are shown on the console as configuration changes are detected.</value>
        [DataMember(Name = "display_on_console", EmitDefaultValue = true)]
        public bool DisplayOnConsole { get; set; }

        /// <summary>
        /// Enable logging of configuration audit for supplemental parameter changes.
        /// </summary>
        /// <value>Enable logging of configuration audit for supplemental parameter changes.</value>
        [DataMember(Name = "supplemental_changes", EmitDefaultValue = true)]
        public bool SupplementalChanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogAuditLogAudit {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  DisplayOnConsole: ").Append(DisplayOnConsole).Append("\n");
            sb.Append("  SupplementalChanges: ").Append(SupplementalChanges).Append("\n");
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
            return this.Equals(input as LogAuditLogAudit);
        }

        /// <summary>
        /// Returns true if LogAuditLogAudit instances are equal
        /// </summary>
        /// <param name="input">Instance of LogAuditLogAudit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogAuditLogAudit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.DisplayOnConsole == input.DisplayOnConsole ||
                    this.DisplayOnConsole.Equals(input.DisplayOnConsole)
                ) && 
                (
                    this.SupplementalChanges == input.SupplementalChanges ||
                    this.SupplementalChanges.Equals(input.SupplementalChanges)
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.DisplayOnConsole.GetHashCode();
                hashCode = (hashCode * 59) + this.SupplementalChanges.GetHashCode();
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
