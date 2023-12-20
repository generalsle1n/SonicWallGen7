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
    /// Enable enhanced syslog connection fields settings.
    /// </summary>
    [DataContract(Name = "log_syslog_log_syslog_enhanced_connection")]
    public partial class LogSyslogLogSyslogEnhancedConnection : IEquatable<LogSyslogLogSyslogEnhancedConnection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogSyslogLogSyslogEnhancedConnection" /> class.
        /// </summary>
        /// <param name="bytesRcvd">Bytes received..</param>
        /// <param name="bytesSent">Bytes send..</param>
        /// <param name="pktsRcvd">Packets received..</param>
        /// <param name="pktsSent">Packets send..</param>
        /// <param name="user">User..</param>
        /// <param name="connDuration">Connection duration..</param>
        /// <param name="sessionType">Session type..</param>
        /// <param name="sessionTime">Session time..</param>
        /// <param name="srcVpn">Source VPN policy..</param>
        /// <param name="dstVpn">Destination VPN policy..</param>
        /// <param name="srcZone">Source zone..</param>
        /// <param name="dstZone">Destination zone..</param>
        /// <param name="clientPolicy">Client policy..</param>
        /// <param name="interfaceStats">Interface statistics..</param>
        /// <param name="sonicpointStats">Sonicpoint statistics..</param>
        public LogSyslogLogSyslogEnhancedConnection(bool bytesRcvd = default(bool), bool bytesSent = default(bool), bool pktsRcvd = default(bool), bool pktsSent = default(bool), bool user = default(bool), bool connDuration = default(bool), bool sessionType = default(bool), bool sessionTime = default(bool), bool srcVpn = default(bool), bool dstVpn = default(bool), bool srcZone = default(bool), bool dstZone = default(bool), bool clientPolicy = default(bool), bool interfaceStats = default(bool), bool sonicpointStats = default(bool))
        {
            this.BytesRcvd = bytesRcvd;
            this.BytesSent = bytesSent;
            this.PktsRcvd = pktsRcvd;
            this.PktsSent = pktsSent;
            this.User = user;
            this.ConnDuration = connDuration;
            this.SessionType = sessionType;
            this.SessionTime = sessionTime;
            this.SrcVpn = srcVpn;
            this.DstVpn = dstVpn;
            this.SrcZone = srcZone;
            this.DstZone = dstZone;
            this.ClientPolicy = clientPolicy;
            this.InterfaceStats = interfaceStats;
            this.SonicpointStats = sonicpointStats;
        }

        /// <summary>
        /// Bytes received.
        /// </summary>
        /// <value>Bytes received.</value>
        [DataMember(Name = "bytes_rcvd", EmitDefaultValue = true)]
        public bool BytesRcvd { get; set; }

        /// <summary>
        /// Bytes send.
        /// </summary>
        /// <value>Bytes send.</value>
        [DataMember(Name = "bytes_sent", EmitDefaultValue = true)]
        public bool BytesSent { get; set; }

        /// <summary>
        /// Packets received.
        /// </summary>
        /// <value>Packets received.</value>
        [DataMember(Name = "pkts_rcvd", EmitDefaultValue = true)]
        public bool PktsRcvd { get; set; }

        /// <summary>
        /// Packets send.
        /// </summary>
        /// <value>Packets send.</value>
        [DataMember(Name = "pkts_sent", EmitDefaultValue = true)]
        public bool PktsSent { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        /// <value>User.</value>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public bool User { get; set; }

        /// <summary>
        /// Connection duration.
        /// </summary>
        /// <value>Connection duration.</value>
        [DataMember(Name = "conn_duration", EmitDefaultValue = true)]
        public bool ConnDuration { get; set; }

        /// <summary>
        /// Session type.
        /// </summary>
        /// <value>Session type.</value>
        [DataMember(Name = "session_type", EmitDefaultValue = true)]
        public bool SessionType { get; set; }

        /// <summary>
        /// Session time.
        /// </summary>
        /// <value>Session time.</value>
        [DataMember(Name = "session_time", EmitDefaultValue = true)]
        public bool SessionTime { get; set; }

        /// <summary>
        /// Source VPN policy.
        /// </summary>
        /// <value>Source VPN policy.</value>
        [DataMember(Name = "src_vpn", EmitDefaultValue = true)]
        public bool SrcVpn { get; set; }

        /// <summary>
        /// Destination VPN policy.
        /// </summary>
        /// <value>Destination VPN policy.</value>
        [DataMember(Name = "dst_vpn", EmitDefaultValue = true)]
        public bool DstVpn { get; set; }

        /// <summary>
        /// Source zone.
        /// </summary>
        /// <value>Source zone.</value>
        [DataMember(Name = "src_zone", EmitDefaultValue = true)]
        public bool SrcZone { get; set; }

        /// <summary>
        /// Destination zone.
        /// </summary>
        /// <value>Destination zone.</value>
        [DataMember(Name = "dst_zone", EmitDefaultValue = true)]
        public bool DstZone { get; set; }

        /// <summary>
        /// Client policy.
        /// </summary>
        /// <value>Client policy.</value>
        [DataMember(Name = "client_policy", EmitDefaultValue = true)]
        public bool ClientPolicy { get; set; }

        /// <summary>
        /// Interface statistics.
        /// </summary>
        /// <value>Interface statistics.</value>
        [DataMember(Name = "interface_stats", EmitDefaultValue = true)]
        public bool InterfaceStats { get; set; }

        /// <summary>
        /// Sonicpoint statistics.
        /// </summary>
        /// <value>Sonicpoint statistics.</value>
        [DataMember(Name = "sonicpoint_stats", EmitDefaultValue = true)]
        public bool SonicpointStats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogSyslogLogSyslogEnhancedConnection {\n");
            sb.Append("  BytesRcvd: ").Append(BytesRcvd).Append("\n");
            sb.Append("  BytesSent: ").Append(BytesSent).Append("\n");
            sb.Append("  PktsRcvd: ").Append(PktsRcvd).Append("\n");
            sb.Append("  PktsSent: ").Append(PktsSent).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ConnDuration: ").Append(ConnDuration).Append("\n");
            sb.Append("  SessionType: ").Append(SessionType).Append("\n");
            sb.Append("  SessionTime: ").Append(SessionTime).Append("\n");
            sb.Append("  SrcVpn: ").Append(SrcVpn).Append("\n");
            sb.Append("  DstVpn: ").Append(DstVpn).Append("\n");
            sb.Append("  SrcZone: ").Append(SrcZone).Append("\n");
            sb.Append("  DstZone: ").Append(DstZone).Append("\n");
            sb.Append("  ClientPolicy: ").Append(ClientPolicy).Append("\n");
            sb.Append("  InterfaceStats: ").Append(InterfaceStats).Append("\n");
            sb.Append("  SonicpointStats: ").Append(SonicpointStats).Append("\n");
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
            return this.Equals(input as LogSyslogLogSyslogEnhancedConnection);
        }

        /// <summary>
        /// Returns true if LogSyslogLogSyslogEnhancedConnection instances are equal
        /// </summary>
        /// <param name="input">Instance of LogSyslogLogSyslogEnhancedConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogSyslogLogSyslogEnhancedConnection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BytesRcvd == input.BytesRcvd ||
                    this.BytesRcvd.Equals(input.BytesRcvd)
                ) && 
                (
                    this.BytesSent == input.BytesSent ||
                    this.BytesSent.Equals(input.BytesSent)
                ) && 
                (
                    this.PktsRcvd == input.PktsRcvd ||
                    this.PktsRcvd.Equals(input.PktsRcvd)
                ) && 
                (
                    this.PktsSent == input.PktsSent ||
                    this.PktsSent.Equals(input.PktsSent)
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.ConnDuration == input.ConnDuration ||
                    this.ConnDuration.Equals(input.ConnDuration)
                ) && 
                (
                    this.SessionType == input.SessionType ||
                    this.SessionType.Equals(input.SessionType)
                ) && 
                (
                    this.SessionTime == input.SessionTime ||
                    this.SessionTime.Equals(input.SessionTime)
                ) && 
                (
                    this.SrcVpn == input.SrcVpn ||
                    this.SrcVpn.Equals(input.SrcVpn)
                ) && 
                (
                    this.DstVpn == input.DstVpn ||
                    this.DstVpn.Equals(input.DstVpn)
                ) && 
                (
                    this.SrcZone == input.SrcZone ||
                    this.SrcZone.Equals(input.SrcZone)
                ) && 
                (
                    this.DstZone == input.DstZone ||
                    this.DstZone.Equals(input.DstZone)
                ) && 
                (
                    this.ClientPolicy == input.ClientPolicy ||
                    this.ClientPolicy.Equals(input.ClientPolicy)
                ) && 
                (
                    this.InterfaceStats == input.InterfaceStats ||
                    this.InterfaceStats.Equals(input.InterfaceStats)
                ) && 
                (
                    this.SonicpointStats == input.SonicpointStats ||
                    this.SonicpointStats.Equals(input.SonicpointStats)
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
                hashCode = (hashCode * 59) + this.BytesRcvd.GetHashCode();
                hashCode = (hashCode * 59) + this.BytesSent.GetHashCode();
                hashCode = (hashCode * 59) + this.PktsRcvd.GetHashCode();
                hashCode = (hashCode * 59) + this.PktsSent.GetHashCode();
                hashCode = (hashCode * 59) + this.User.GetHashCode();
                hashCode = (hashCode * 59) + this.ConnDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.SessionType.GetHashCode();
                hashCode = (hashCode * 59) + this.SessionTime.GetHashCode();
                hashCode = (hashCode * 59) + this.SrcVpn.GetHashCode();
                hashCode = (hashCode * 59) + this.DstVpn.GetHashCode();
                hashCode = (hashCode * 59) + this.SrcZone.GetHashCode();
                hashCode = (hashCode * 59) + this.DstZone.GetHashCode();
                hashCode = (hashCode * 59) + this.ClientPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.InterfaceStats.GetHashCode();
                hashCode = (hashCode * 59) + this.SonicpointStats.GetHashCode();
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
