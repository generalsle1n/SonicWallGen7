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
    /// Last time range.
    /// </summary>
    [DataContract(Name = "log_display_time_range_last_last")]
    public partial class LogDisplayTimeRangeLastLast : IEquatable<LogDisplayTimeRangeLastLast>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogDisplayTimeRangeLastLast" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="minutes">Minutes..</param>
        /// <param name="hours">Hours..</param>
        /// <param name="days">Days..</param>
        public LogDisplayTimeRangeLastLast(decimal value = default(decimal), bool minutes = default(bool), bool hours = default(bool), bool days = default(bool))
        {
            this.Value = value;
            this.Minutes = minutes;
            this.Hours = hours;
            this.Days = days;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Minutes.
        /// </summary>
        /// <value>Minutes.</value>
        [DataMember(Name = "minutes", EmitDefaultValue = true)]
        public bool Minutes { get; set; }

        /// <summary>
        /// Hours.
        /// </summary>
        /// <value>Hours.</value>
        [DataMember(Name = "hours", EmitDefaultValue = true)]
        public bool Hours { get; set; }

        /// <summary>
        /// Days.
        /// </summary>
        /// <value>Days.</value>
        [DataMember(Name = "days", EmitDefaultValue = true)]
        public bool Days { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogDisplayTimeRangeLastLast {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
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
            return this.Equals(input as LogDisplayTimeRangeLastLast);
        }

        /// <summary>
        /// Returns true if LogDisplayTimeRangeLastLast instances are equal
        /// </summary>
        /// <param name="input">Instance of LogDisplayTimeRangeLastLast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogDisplayTimeRangeLastLast input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Minutes == input.Minutes ||
                    this.Minutes.Equals(input.Minutes)
                ) && 
                (
                    this.Hours == input.Hours ||
                    this.Hours.Equals(input.Hours)
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days.Equals(input.Days)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                hashCode = (hashCode * 59) + this.Minutes.GetHashCode();
                hashCode = (hashCode * 59) + this.Hours.GetHashCode();
                hashCode = (hashCode * 59) + this.Days.GetHashCode();
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
