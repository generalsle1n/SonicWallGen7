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
    /// Enable enhanced syslog general settings.
    /// </summary>
    [DataContract(Name = "log_syslog_log_syslog_enhanced_general")]
    public partial class LogSyslogLogSyslogEnhancedGeneral : IEquatable<LogSyslogLogSyslogEnhancedGeneral>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogSyslogLogSyslogEnhancedGeneral" /> class.
        /// </summary>
        /// <param name="host">Host..</param>
        /// <param name="eventId">Event ID..</param>
        /// <param name="category">Category..</param>
        /// <param name="groupCategory">Group category..</param>
        /// <param name="message">Message..</param>
        public LogSyslogLogSyslogEnhancedGeneral(bool host = default(bool), bool eventId = default(bool), bool category = default(bool), bool groupCategory = default(bool), bool message = default(bool))
        {
            this.Host = host;
            this.EventId = eventId;
            this.Category = category;
            this.GroupCategory = groupCategory;
            this.Message = message;
        }

        /// <summary>
        /// Host.
        /// </summary>
        /// <value>Host.</value>
        [DataMember(Name = "host", EmitDefaultValue = true)]
        public bool Host { get; set; }

        /// <summary>
        /// Event ID.
        /// </summary>
        /// <value>Event ID.</value>
        [DataMember(Name = "event_id", EmitDefaultValue = true)]
        public bool EventId { get; set; }

        /// <summary>
        /// Category.
        /// </summary>
        /// <value>Category.</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public bool Category { get; set; }

        /// <summary>
        /// Group category.
        /// </summary>
        /// <value>Group category.</value>
        [DataMember(Name = "group_category", EmitDefaultValue = true)]
        public bool GroupCategory { get; set; }

        /// <summary>
        /// Message.
        /// </summary>
        /// <value>Message.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public bool Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogSyslogLogSyslogEnhancedGeneral {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  GroupCategory: ").Append(GroupCategory).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as LogSyslogLogSyslogEnhancedGeneral);
        }

        /// <summary>
        /// Returns true if LogSyslogLogSyslogEnhancedGeneral instances are equal
        /// </summary>
        /// <param name="input">Instance of LogSyslogLogSyslogEnhancedGeneral to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogSyslogLogSyslogEnhancedGeneral input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Host == input.Host ||
                    this.Host.Equals(input.Host)
                ) && 
                (
                    this.EventId == input.EventId ||
                    this.EventId.Equals(input.EventId)
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.GroupCategory == input.GroupCategory ||
                    this.GroupCategory.Equals(input.GroupCategory)
                ) && 
                (
                    this.Message == input.Message ||
                    this.Message.Equals(input.Message)
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
                hashCode = (hashCode * 59) + this.Host.GetHashCode();
                hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                hashCode = (hashCode * 59) + this.GroupCategory.GetHashCode();
                hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
