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
    /// IPv4 SD-WAN SLA Probe.
    /// </summary>
    [DataContract(Name = "sdwan_sla_probe_ipv4_ipv4")]
    public partial class SdwanSlaProbeIpv4Ipv4 : IEquatable<SdwanSlaProbeIpv4Ipv4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SdwanSlaProbeIpv4Ipv4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SdwanSlaProbeIpv4Ipv4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SdwanSlaProbeIpv4Ipv4" /> class.
        /// </summary>
        /// <param name="name">Edit a SD-WAN SLA Probe name. (required).</param>
        /// <param name="comment">Set SD-WAN SLA Probe comment. * Set to null to represent an unconfigured state..</param>
        /// <param name="sdwanGroup">Set a SD-WAN SLA Probe interface group..</param>
        /// <param name="probe">probe.</param>
        /// <param name="interval">interval.</param>
        /// <param name="replyTimeout">Set probing reply timeout..</param>
        /// <param name="rstAsMiss">Enable RST response counts as miss..</param>
        public SdwanSlaProbeIpv4Ipv4(string name = default(string), string comment = default(string), string sdwanGroup = default(string), SdwanSlaProbeIpv4Ipv4Probe probe = default(SdwanSlaProbeIpv4Ipv4Probe), SdwanSlaProbeIpv4Ipv4Interval interval = default(SdwanSlaProbeIpv4Ipv4Interval), decimal replyTimeout = default(decimal), bool rstAsMiss = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SdwanSlaProbeIpv4Ipv4 and cannot be null");
            }
            this.Name = name;
            this.Comment = comment;
            this.SdwanGroup = sdwanGroup;
            this.Probe = probe;
            this.Interval = interval;
            this.ReplyTimeout = replyTimeout;
            this.RstAsMiss = rstAsMiss;
        }

        /// <summary>
        /// Edit a SD-WAN SLA Probe name.
        /// </summary>
        /// <value>Edit a SD-WAN SLA Probe name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Set SD-WAN SLA Probe comment. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set SD-WAN SLA Probe comment. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Set a SD-WAN SLA Probe interface group.
        /// </summary>
        /// <value>Set a SD-WAN SLA Probe interface group.</value>
        [DataMember(Name = "sdwan_group", EmitDefaultValue = false)]
        public string SdwanGroup { get; set; }

        /// <summary>
        /// Gets or Sets Probe
        /// </summary>
        [DataMember(Name = "probe", EmitDefaultValue = false)]
        public SdwanSlaProbeIpv4Ipv4Probe Probe { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public SdwanSlaProbeIpv4Ipv4Interval Interval { get; set; }

        /// <summary>
        /// Set probing reply timeout.
        /// </summary>
        /// <value>Set probing reply timeout.</value>
        [DataMember(Name = "reply_timeout", EmitDefaultValue = false)]
        public decimal ReplyTimeout { get; set; }

        /// <summary>
        /// Enable RST response counts as miss.
        /// </summary>
        /// <value>Enable RST response counts as miss.</value>
        [DataMember(Name = "rst_as_miss", EmitDefaultValue = true)]
        public bool RstAsMiss { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SdwanSlaProbeIpv4Ipv4 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  SdwanGroup: ").Append(SdwanGroup).Append("\n");
            sb.Append("  Probe: ").Append(Probe).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  ReplyTimeout: ").Append(ReplyTimeout).Append("\n");
            sb.Append("  RstAsMiss: ").Append(RstAsMiss).Append("\n");
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
            return this.Equals(input as SdwanSlaProbeIpv4Ipv4);
        }

        /// <summary>
        /// Returns true if SdwanSlaProbeIpv4Ipv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of SdwanSlaProbeIpv4Ipv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SdwanSlaProbeIpv4Ipv4 input)
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
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.SdwanGroup == input.SdwanGroup ||
                    (this.SdwanGroup != null &&
                    this.SdwanGroup.Equals(input.SdwanGroup))
                ) && 
                (
                    this.Probe == input.Probe ||
                    (this.Probe != null &&
                    this.Probe.Equals(input.Probe))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.ReplyTimeout == input.ReplyTimeout ||
                    this.ReplyTimeout.Equals(input.ReplyTimeout)
                ) && 
                (
                    this.RstAsMiss == input.RstAsMiss ||
                    this.RstAsMiss.Equals(input.RstAsMiss)
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
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.SdwanGroup != null)
                {
                    hashCode = (hashCode * 59) + this.SdwanGroup.GetHashCode();
                }
                if (this.Probe != null)
                {
                    hashCode = (hashCode * 59) + this.Probe.GetHashCode();
                }
                if (this.Interval != null)
                {
                    hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReplyTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.RstAsMiss.GetHashCode();
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