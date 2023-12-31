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
    /// Reporting profile settings.
    /// </summary>
    [DataContract(Name = "reporting_profiles")]
    public partial class ReportingProfiles : IEquatable<ReportingProfiles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingProfiles" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportingProfiles() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingProfiles" /> class.
        /// </summary>
        /// <param name="name">Reporting profile name. (required).</param>
        /// <param name="frequency">Set the frequency filter interval in seconds..</param>
        /// <param name="logMonitor">Enable display in Log Monitor..</param>
        /// <param name="emailAlert">Enable email alert..</param>
        /// <param name="emailAddress">Set the email address to send alerts to..</param>
        /// <param name="syslog">Enable report events via Syslog..</param>
        /// <param name="syslogProfile">Set syslog profile..</param>
        /// <param name="ipfix">Enable reporting of events via ipfix..</param>
        /// <param name="color">color.</param>
        /// <param name="varEvent">varEvent.</param>
        public ReportingProfiles(string name = default(string), decimal frequency = default(decimal), bool logMonitor = default(bool), bool emailAlert = default(bool), string emailAddress = default(string), bool syslog = default(bool), decimal syslogProfile = default(decimal), bool ipfix = default(bool), ReportingProfilesColor color = default(ReportingProfilesColor), ReportingProfilesEvent varEvent = default(ReportingProfilesEvent))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ReportingProfiles and cannot be null");
            }
            this.Name = name;
            this.Frequency = frequency;
            this.LogMonitor = logMonitor;
            this.EmailAlert = emailAlert;
            this.EmailAddress = emailAddress;
            this.Syslog = syslog;
            this.SyslogProfile = syslogProfile;
            this.Ipfix = ipfix;
            this.Color = color;
            this.VarEvent = varEvent;
        }

        /// <summary>
        /// Reporting profile name.
        /// </summary>
        /// <value>Reporting profile name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Reporting profile UUID.
        /// </summary>
        /// <value>Reporting profile UUID.</value>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns false as Uuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUuid()
        {
            return false;
        }
        /// <summary>
        /// Set the frequency filter interval in seconds.
        /// </summary>
        /// <value>Set the frequency filter interval in seconds.</value>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public decimal Frequency { get; set; }

        /// <summary>
        /// Enable display in Log Monitor.
        /// </summary>
        /// <value>Enable display in Log Monitor.</value>
        [DataMember(Name = "log_monitor", EmitDefaultValue = true)]
        public bool LogMonitor { get; set; }

        /// <summary>
        /// Enable email alert.
        /// </summary>
        /// <value>Enable email alert.</value>
        [DataMember(Name = "email_alert", EmitDefaultValue = true)]
        public bool EmailAlert { get; set; }

        /// <summary>
        /// Set the email address to send alerts to.
        /// </summary>
        /// <value>Set the email address to send alerts to.</value>
        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Enable report events via Syslog.
        /// </summary>
        /// <value>Enable report events via Syslog.</value>
        [DataMember(Name = "syslog", EmitDefaultValue = true)]
        public bool Syslog { get; set; }

        /// <summary>
        /// Set syslog profile.
        /// </summary>
        /// <value>Set syslog profile.</value>
        [DataMember(Name = "syslog_profile", EmitDefaultValue = false)]
        public decimal SyslogProfile { get; set; }

        /// <summary>
        /// Enable reporting of events via ipfix.
        /// </summary>
        /// <value>Enable reporting of events via ipfix.</value>
        [DataMember(Name = "ipfix", EmitDefaultValue = true)]
        public bool Ipfix { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public ReportingProfilesColor Color { get; set; }

        /// <summary>
        /// Gets or Sets VarEvent
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        public ReportingProfilesEvent VarEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReportingProfiles {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  LogMonitor: ").Append(LogMonitor).Append("\n");
            sb.Append("  EmailAlert: ").Append(EmailAlert).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Syslog: ").Append(Syslog).Append("\n");
            sb.Append("  SyslogProfile: ").Append(SyslogProfile).Append("\n");
            sb.Append("  Ipfix: ").Append(Ipfix).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  VarEvent: ").Append(VarEvent).Append("\n");
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
            return this.Equals(input as ReportingProfiles);
        }

        /// <summary>
        /// Returns true if ReportingProfiles instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportingProfiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingProfiles input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.LogMonitor == input.LogMonitor ||
                    this.LogMonitor.Equals(input.LogMonitor)
                ) && 
                (
                    this.EmailAlert == input.EmailAlert ||
                    this.EmailAlert.Equals(input.EmailAlert)
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Syslog == input.Syslog ||
                    this.Syslog.Equals(input.Syslog)
                ) && 
                (
                    this.SyslogProfile == input.SyslogProfile ||
                    this.SyslogProfile.Equals(input.SyslogProfile)
                ) && 
                (
                    this.Ipfix == input.Ipfix ||
                    this.Ipfix.Equals(input.Ipfix)
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.VarEvent == input.VarEvent ||
                    (this.VarEvent != null &&
                    this.VarEvent.Equals(input.VarEvent))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                hashCode = (hashCode * 59) + this.LogMonitor.GetHashCode();
                hashCode = (hashCode * 59) + this.EmailAlert.GetHashCode();
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Syslog.GetHashCode();
                hashCode = (hashCode * 59) + this.SyslogProfile.GetHashCode();
                hashCode = (hashCode * 59) + this.Ipfix.GetHashCode();
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                if (this.VarEvent != null)
                {
                    hashCode = (hashCode * 59) + this.VarEvent.GetHashCode();
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
