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
    /// Enable event report.
    /// </summary>
    [DataContract(Name = "reporting_profiles_event")]
    public partial class ReportingProfilesEvent : IEquatable<ReportingProfilesEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingProfilesEvent" /> class.
        /// </summary>
        /// <param name="matched">Enable report matched event..</param>
        /// <param name="begin">Enable report event begin..</param>
        /// <param name="end">Enable report end event..</param>
        public ReportingProfilesEvent(bool matched = default(bool), bool begin = default(bool), bool end = default(bool))
        {
            this.Matched = matched;
            this.Begin = begin;
            this.End = end;
        }

        /// <summary>
        /// Enable report matched event.
        /// </summary>
        /// <value>Enable report matched event.</value>
        [DataMember(Name = "matched", EmitDefaultValue = true)]
        public bool Matched { get; set; }

        /// <summary>
        /// Enable report event begin.
        /// </summary>
        /// <value>Enable report event begin.</value>
        [DataMember(Name = "begin", EmitDefaultValue = true)]
        public bool Begin { get; set; }

        /// <summary>
        /// Enable report end event.
        /// </summary>
        /// <value>Enable report end event.</value>
        [DataMember(Name = "end", EmitDefaultValue = true)]
        public bool End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportingProfilesEvent {\n");
            sb.Append("  Matched: ").Append(Matched).Append("\n");
            sb.Append("  Begin: ").Append(Begin).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(input as ReportingProfilesEvent);
        }

        /// <summary>
        /// Returns true if ReportingProfilesEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportingProfilesEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingProfilesEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Matched == input.Matched ||
                    this.Matched.Equals(input.Matched)
                ) && 
                (
                    this.Begin == input.Begin ||
                    this.Begin.Equals(input.Begin)
                ) && 
                (
                    this.End == input.End ||
                    this.End.Equals(input.End)
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
                hashCode = (hashCode * 59) + this.Matched.GetHashCode();
                hashCode = (hashCode * 59) + this.Begin.GetHashCode();
                hashCode = (hashCode * 59) + this.End.GetHashCode();
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
