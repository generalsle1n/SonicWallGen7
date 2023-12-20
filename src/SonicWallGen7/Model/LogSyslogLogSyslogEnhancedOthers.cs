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
    /// Enable enhanced syslog others fields settings.
    /// </summary>
    [DataContract(Name = "log_syslog_log_syslog_enhanced_others")]
    public partial class LogSyslogLogSyslogEnhancedOthers : IEquatable<LogSyslogLogSyslogEnhancedOthers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogSyslogLogSyslogEnhancedOthers" /> class.
        /// </summary>
        /// <param name="counter">Counter..</param>
        /// <param name="npcs">NPCS..</param>
        /// <param name="note">Note..</param>
        /// <param name="idp">IDP..</param>
        /// <param name="antiSpam">Anti-spam..</param>
        /// <param name="appFirewall">App firewall..</param>
        /// <param name="rawData">Raw data..</param>
        /// <param name="fileId">File ID..</param>
        /// <param name="fileTx">File TX status..</param>
        /// <param name="ruleAction">Rule action..</param>
        /// <param name="uuid">UUID..</param>
        public LogSyslogLogSyslogEnhancedOthers(bool counter = default(bool), bool npcs = default(bool), bool note = default(bool), bool idp = default(bool), bool antiSpam = default(bool), bool appFirewall = default(bool), bool rawData = default(bool), bool fileId = default(bool), bool fileTx = default(bool), bool ruleAction = default(bool), bool uuid = default(bool))
        {
            this.Counter = counter;
            this.Npcs = npcs;
            this.Note = note;
            this.Idp = idp;
            this.AntiSpam = antiSpam;
            this.AppFirewall = appFirewall;
            this.RawData = rawData;
            this.FileId = fileId;
            this.FileTx = fileTx;
            this.RuleAction = ruleAction;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Counter.
        /// </summary>
        /// <value>Counter.</value>
        [DataMember(Name = "counter", EmitDefaultValue = true)]
        public bool Counter { get; set; }

        /// <summary>
        /// NPCS.
        /// </summary>
        /// <value>NPCS.</value>
        [DataMember(Name = "npcs", EmitDefaultValue = true)]
        public bool Npcs { get; set; }

        /// <summary>
        /// Note.
        /// </summary>
        /// <value>Note.</value>
        [DataMember(Name = "note", EmitDefaultValue = true)]
        public bool Note { get; set; }

        /// <summary>
        /// IDP.
        /// </summary>
        /// <value>IDP.</value>
        [DataMember(Name = "idp", EmitDefaultValue = true)]
        public bool Idp { get; set; }

        /// <summary>
        /// Anti-spam.
        /// </summary>
        /// <value>Anti-spam.</value>
        [DataMember(Name = "anti_spam", EmitDefaultValue = true)]
        public bool AntiSpam { get; set; }

        /// <summary>
        /// App firewall.
        /// </summary>
        /// <value>App firewall.</value>
        [DataMember(Name = "app_firewall", EmitDefaultValue = true)]
        public bool AppFirewall { get; set; }

        /// <summary>
        /// Raw data.
        /// </summary>
        /// <value>Raw data.</value>
        [DataMember(Name = "raw_data", EmitDefaultValue = true)]
        public bool RawData { get; set; }

        /// <summary>
        /// File ID.
        /// </summary>
        /// <value>File ID.</value>
        [DataMember(Name = "file_id", EmitDefaultValue = true)]
        public bool FileId { get; set; }

        /// <summary>
        /// File TX status.
        /// </summary>
        /// <value>File TX status.</value>
        [DataMember(Name = "file_tx", EmitDefaultValue = true)]
        public bool FileTx { get; set; }

        /// <summary>
        /// Rule action.
        /// </summary>
        /// <value>Rule action.</value>
        [DataMember(Name = "rule_action", EmitDefaultValue = true)]
        public bool RuleAction { get; set; }

        /// <summary>
        /// UUID.
        /// </summary>
        /// <value>UUID.</value>
        [DataMember(Name = "uuid", EmitDefaultValue = true)]
        public bool Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogSyslogLogSyslogEnhancedOthers {\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
            sb.Append("  Npcs: ").Append(Npcs).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Idp: ").Append(Idp).Append("\n");
            sb.Append("  AntiSpam: ").Append(AntiSpam).Append("\n");
            sb.Append("  AppFirewall: ").Append(AppFirewall).Append("\n");
            sb.Append("  RawData: ").Append(RawData).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FileTx: ").Append(FileTx).Append("\n");
            sb.Append("  RuleAction: ").Append(RuleAction).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as LogSyslogLogSyslogEnhancedOthers);
        }

        /// <summary>
        /// Returns true if LogSyslogLogSyslogEnhancedOthers instances are equal
        /// </summary>
        /// <param name="input">Instance of LogSyslogLogSyslogEnhancedOthers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogSyslogLogSyslogEnhancedOthers input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Counter == input.Counter ||
                    this.Counter.Equals(input.Counter)
                ) && 
                (
                    this.Npcs == input.Npcs ||
                    this.Npcs.Equals(input.Npcs)
                ) && 
                (
                    this.Note == input.Note ||
                    this.Note.Equals(input.Note)
                ) && 
                (
                    this.Idp == input.Idp ||
                    this.Idp.Equals(input.Idp)
                ) && 
                (
                    this.AntiSpam == input.AntiSpam ||
                    this.AntiSpam.Equals(input.AntiSpam)
                ) && 
                (
                    this.AppFirewall == input.AppFirewall ||
                    this.AppFirewall.Equals(input.AppFirewall)
                ) && 
                (
                    this.RawData == input.RawData ||
                    this.RawData.Equals(input.RawData)
                ) && 
                (
                    this.FileId == input.FileId ||
                    this.FileId.Equals(input.FileId)
                ) && 
                (
                    this.FileTx == input.FileTx ||
                    this.FileTx.Equals(input.FileTx)
                ) && 
                (
                    this.RuleAction == input.RuleAction ||
                    this.RuleAction.Equals(input.RuleAction)
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    this.Uuid.Equals(input.Uuid)
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
                hashCode = (hashCode * 59) + this.Counter.GetHashCode();
                hashCode = (hashCode * 59) + this.Npcs.GetHashCode();
                hashCode = (hashCode * 59) + this.Note.GetHashCode();
                hashCode = (hashCode * 59) + this.Idp.GetHashCode();
                hashCode = (hashCode * 59) + this.AntiSpam.GetHashCode();
                hashCode = (hashCode * 59) + this.AppFirewall.GetHashCode();
                hashCode = (hashCode * 59) + this.RawData.GetHashCode();
                hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                hashCode = (hashCode * 59) + this.FileTx.GetHashCode();
                hashCode = (hashCode * 59) + this.RuleAction.GetHashCode();
                hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
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