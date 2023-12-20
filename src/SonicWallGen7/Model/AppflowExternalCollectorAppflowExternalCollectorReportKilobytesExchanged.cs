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
    /// Enable report connection on kilobytes exchanged. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "appflow_external_collector_appflow_external_collector_report_kilobytes_exchanged")]
    public partial class AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged : IEquatable<AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged" /> class.
        /// </summary>
        /// <param name="kilobytes">Specify kilobytes..</param>
        /// <param name="once">Report once..</param>
        public AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged(decimal kilobytes = default(decimal), bool once = default(bool))
        {
            this.Kilobytes = kilobytes;
            this.Once = once;
        }

        /// <summary>
        /// Specify kilobytes.
        /// </summary>
        /// <value>Specify kilobytes.</value>
        [DataMember(Name = "kilobytes", EmitDefaultValue = false)]
        public decimal Kilobytes { get; set; }

        /// <summary>
        /// Report once.
        /// </summary>
        /// <value>Report once.</value>
        [DataMember(Name = "once", EmitDefaultValue = true)]
        public bool Once { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged {\n");
            sb.Append("  Kilobytes: ").Append(Kilobytes).Append("\n");
            sb.Append("  Once: ").Append(Once).Append("\n");
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
            return this.Equals(input as AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged);
        }

        /// <summary>
        /// Returns true if AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged instances are equal
        /// </summary>
        /// <param name="input">Instance of AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppflowExternalCollectorAppflowExternalCollectorReportKilobytesExchanged input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Kilobytes == input.Kilobytes ||
                    this.Kilobytes.Equals(input.Kilobytes)
                ) && 
                (
                    this.Once == input.Once ||
                    this.Once.Equals(input.Once)
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
                hashCode = (hashCode * 59) + this.Kilobytes.GetHashCode();
                hashCode = (hashCode * 59) + this.Once.GetHashCode();
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