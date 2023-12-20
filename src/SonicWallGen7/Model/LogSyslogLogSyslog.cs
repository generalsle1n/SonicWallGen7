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
    /// Syslog configuration.
    /// </summary>
    [DataContract(Name = "log_syslog_log_syslog")]
    public partial class LogSyslogLogSyslog : IEquatable<LogSyslogLogSyslog>, IValidatableObject
    {
        /// <summary>
        /// Set syslog facility for all the servers.
        /// </summary>
        /// <value>Set syslog facility for all the servers.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FacilityEnum
        {
            /// <summary>
            /// Enum Kernel for value: kernel
            /// </summary>
            [EnumMember(Value = "kernel")]
            Kernel = 1,

            /// <summary>
            /// Enum UserLevelMessages for value: user-level-messages
            /// </summary>
            [EnumMember(Value = "user-level-messages")]
            UserLevelMessages = 2,

            /// <summary>
            /// Enum MailSystem for value: mail-system
            /// </summary>
            [EnumMember(Value = "mail-system")]
            MailSystem = 3,

            /// <summary>
            /// Enum SystemDaemons for value: system-daemons
            /// </summary>
            [EnumMember(Value = "system-daemons")]
            SystemDaemons = 4,

            /// <summary>
            /// Enum SecurityAuthorizationMessages for value: security-authorization-messages
            /// </summary>
            [EnumMember(Value = "security-authorization-messages")]
            SecurityAuthorizationMessages = 5,

            /// <summary>
            /// Enum GeneratedInternally for value: generated-internally
            /// </summary>
            [EnumMember(Value = "generated-internally")]
            GeneratedInternally = 6,

            /// <summary>
            /// Enum LinePrinterSubsystem for value: line-printer-subsystem
            /// </summary>
            [EnumMember(Value = "line-printer-subsystem")]
            LinePrinterSubsystem = 7,

            /// <summary>
            /// Enum NetworkNewsSubsystem for value: network-news-subsystem
            /// </summary>
            [EnumMember(Value = "network-news-subsystem")]
            NetworkNewsSubsystem = 8,

            /// <summary>
            /// Enum UucpSubsystem for value: uucp-subsystem
            /// </summary>
            [EnumMember(Value = "uucp-subsystem")]
            UucpSubsystem = 9,

            /// <summary>
            /// Enum ClockDaemonLinuxBsd for value: clock-daemon-linux-bsd
            /// </summary>
            [EnumMember(Value = "clock-daemon-linux-bsd")]
            ClockDaemonLinuxBsd = 10,

            /// <summary>
            /// Enum AuthprivMessages for value: authpriv-messages
            /// </summary>
            [EnumMember(Value = "authpriv-messages")]
            AuthprivMessages = 11,

            /// <summary>
            /// Enum FtpDaemon for value: ftp-daemon
            /// </summary>
            [EnumMember(Value = "ftp-daemon")]
            FtpDaemon = 12,

            /// <summary>
            /// Enum NtpSubsystem for value: ntp-subsystem
            /// </summary>
            [EnumMember(Value = "ntp-subsystem")]
            NtpSubsystem = 13,

            /// <summary>
            /// Enum LogAudit for value: log-audit
            /// </summary>
            [EnumMember(Value = "log-audit")]
            LogAudit = 14,

            /// <summary>
            /// Enum LogAlert for value: log-alert
            /// </summary>
            [EnumMember(Value = "log-alert")]
            LogAlert = 15,

            /// <summary>
            /// Enum ClockDaemonSolaris for value: clock-daemon-solaris
            /// </summary>
            [EnumMember(Value = "clock-daemon-solaris")]
            ClockDaemonSolaris = 16,

            /// <summary>
            /// Enum LocalUse0 for value: local-use0
            /// </summary>
            [EnumMember(Value = "local-use0")]
            LocalUse0 = 17,

            /// <summary>
            /// Enum LocalUse1 for value: local-use1
            /// </summary>
            [EnumMember(Value = "local-use1")]
            LocalUse1 = 18,

            /// <summary>
            /// Enum LocalUse2 for value: local-use2
            /// </summary>
            [EnumMember(Value = "local-use2")]
            LocalUse2 = 19,

            /// <summary>
            /// Enum LocalUse3 for value: local-use3
            /// </summary>
            [EnumMember(Value = "local-use3")]
            LocalUse3 = 20,

            /// <summary>
            /// Enum LocalUse4 for value: local-use4
            /// </summary>
            [EnumMember(Value = "local-use4")]
            LocalUse4 = 21,

            /// <summary>
            /// Enum LocalUse5 for value: local-use5
            /// </summary>
            [EnumMember(Value = "local-use5")]
            LocalUse5 = 22,

            /// <summary>
            /// Enum LocalUse6 for value: local-use6
            /// </summary>
            [EnumMember(Value = "local-use6")]
            LocalUse6 = 23,

            /// <summary>
            /// Enum LocalUse7 for value: local-use7
            /// </summary>
            [EnumMember(Value = "local-use7")]
            LocalUse7 = 24
        }


        /// <summary>
        /// Set syslog facility for all the servers.
        /// </summary>
        /// <value>Set syslog facility for all the servers.</value>
        [DataMember(Name = "facility", EmitDefaultValue = false)]
        public FacilityEnum? Facility { get; set; }
        /// <summary>
        /// Set syslog format for all the servers.
        /// </summary>
        /// <value>Set syslog format for all the servers.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Webtrends for value: webtrends
            /// </summary>
            [EnumMember(Value = "webtrends")]
            Webtrends = 2,

            /// <summary>
            /// Enum EnhancedSyslog for value: enhanced-syslog
            /// </summary>
            [EnumMember(Value = "enhanced-syslog")]
            EnhancedSyslog = 3,

            /// <summary>
            /// Enum ArcSight for value: arcSight
            /// </summary>
            [EnumMember(Value = "arcSight")]
            ArcSight = 4
        }


        /// <summary>
        /// Set syslog format for all the servers.
        /// </summary>
        /// <value>Set syslog format for all the servers.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogSyslogLogSyslog" /> class.
        /// </summary>
        /// <param name="id">Set syslog ID for all the servers..</param>
        /// <param name="facility">Set syslog facility for all the servers..</param>
        /// <param name="format">Set syslog format for all the servers..</param>
        /// <param name="eventRateLimiting">eventRateLimiting.</param>
        /// <param name="displayTimestampUtc">Enable display time stamp in UTC..</param>
        /// <param name="dataRateLimiting">dataRateLimiting.</param>
        /// <param name="enhanced">enhanced.</param>
        /// <param name="arcsight">arcsight.</param>
        /// <param name="ndpp">Enable NDPP enforcement for syslog server..</param>
        public LogSyslogLogSyslog(string id = default(string), FacilityEnum? facility = default(FacilityEnum?), FormatEnum? format = default(FormatEnum?), LogSyslogLogSyslogEventRateLimiting eventRateLimiting = default(LogSyslogLogSyslogEventRateLimiting), bool displayTimestampUtc = default(bool), LogSyslogLogSyslogDataRateLimiting dataRateLimiting = default(LogSyslogLogSyslogDataRateLimiting), LogSyslogLogSyslogEnhanced enhanced = default(LogSyslogLogSyslogEnhanced), LogSyslogLogSyslogArcsight arcsight = default(LogSyslogLogSyslogArcsight), bool ndpp = default(bool))
        {
            this.Id = id;
            this.Facility = facility;
            this.Format = format;
            this.EventRateLimiting = eventRateLimiting;
            this.DisplayTimestampUtc = displayTimestampUtc;
            this.DataRateLimiting = dataRateLimiting;
            this.Enhanced = enhanced;
            this.Arcsight = arcsight;
            this.Ndpp = ndpp;
        }

        /// <summary>
        /// Set syslog ID for all the servers.
        /// </summary>
        /// <value>Set syslog ID for all the servers.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EventRateLimiting
        /// </summary>
        [DataMember(Name = "event_rate_limiting", EmitDefaultValue = true)]
        public LogSyslogLogSyslogEventRateLimiting EventRateLimiting { get; set; }

        /// <summary>
        /// Enable display time stamp in UTC.
        /// </summary>
        /// <value>Enable display time stamp in UTC.</value>
        [DataMember(Name = "display_timestamp_utc", EmitDefaultValue = true)]
        public bool DisplayTimestampUtc { get; set; }

        /// <summary>
        /// Gets or Sets DataRateLimiting
        /// </summary>
        [DataMember(Name = "data_rate_limiting", EmitDefaultValue = true)]
        public LogSyslogLogSyslogDataRateLimiting DataRateLimiting { get; set; }

        /// <summary>
        /// Gets or Sets Enhanced
        /// </summary>
        [DataMember(Name = "enhanced", EmitDefaultValue = false)]
        public LogSyslogLogSyslogEnhanced Enhanced { get; set; }

        /// <summary>
        /// Gets or Sets Arcsight
        /// </summary>
        [DataMember(Name = "arcsight", EmitDefaultValue = false)]
        public LogSyslogLogSyslogArcsight Arcsight { get; set; }

        /// <summary>
        /// Enable NDPP enforcement for syslog server.
        /// </summary>
        /// <value>Enable NDPP enforcement for syslog server.</value>
        [DataMember(Name = "ndpp", EmitDefaultValue = true)]
        public bool Ndpp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogSyslogLogSyslog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Facility: ").Append(Facility).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  EventRateLimiting: ").Append(EventRateLimiting).Append("\n");
            sb.Append("  DisplayTimestampUtc: ").Append(DisplayTimestampUtc).Append("\n");
            sb.Append("  DataRateLimiting: ").Append(DataRateLimiting).Append("\n");
            sb.Append("  Enhanced: ").Append(Enhanced).Append("\n");
            sb.Append("  Arcsight: ").Append(Arcsight).Append("\n");
            sb.Append("  Ndpp: ").Append(Ndpp).Append("\n");
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
            return this.Equals(input as LogSyslogLogSyslog);
        }

        /// <summary>
        /// Returns true if LogSyslogLogSyslog instances are equal
        /// </summary>
        /// <param name="input">Instance of LogSyslogLogSyslog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogSyslogLogSyslog input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Facility == input.Facility ||
                    this.Facility.Equals(input.Facility)
                ) && 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.EventRateLimiting == input.EventRateLimiting ||
                    (this.EventRateLimiting != null &&
                    this.EventRateLimiting.Equals(input.EventRateLimiting))
                ) && 
                (
                    this.DisplayTimestampUtc == input.DisplayTimestampUtc ||
                    this.DisplayTimestampUtc.Equals(input.DisplayTimestampUtc)
                ) && 
                (
                    this.DataRateLimiting == input.DataRateLimiting ||
                    (this.DataRateLimiting != null &&
                    this.DataRateLimiting.Equals(input.DataRateLimiting))
                ) && 
                (
                    this.Enhanced == input.Enhanced ||
                    (this.Enhanced != null &&
                    this.Enhanced.Equals(input.Enhanced))
                ) && 
                (
                    this.Arcsight == input.Arcsight ||
                    (this.Arcsight != null &&
                    this.Arcsight.Equals(input.Arcsight))
                ) && 
                (
                    this.Ndpp == input.Ndpp ||
                    this.Ndpp.Equals(input.Ndpp)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Facility.GetHashCode();
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.EventRateLimiting != null)
                {
                    hashCode = (hashCode * 59) + this.EventRateLimiting.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisplayTimestampUtc.GetHashCode();
                if (this.DataRateLimiting != null)
                {
                    hashCode = (hashCode * 59) + this.DataRateLimiting.GetHashCode();
                }
                if (this.Enhanced != null)
                {
                    hashCode = (hashCode * 59) + this.Enhanced.GetHashCode();
                }
                if (this.Arcsight != null)
                {
                    hashCode = (hashCode * 59) + this.Arcsight.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ndpp.GetHashCode();
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