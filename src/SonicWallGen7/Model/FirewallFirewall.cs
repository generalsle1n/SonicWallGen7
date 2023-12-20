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
    /// Configure firewall settings.
    /// </summary>
    [DataContract(Name = "firewall_firewall")]
    public partial class FirewallFirewall : IEquatable<FirewallFirewall>, IValidatableObject
    {
        /// <summary>
        /// Set the type of connections.
        /// </summary>
        /// <value>Set the type of connections.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectionsEnum
        {
            /// <summary>
            /// Enum Highest for value: highest
            /// </summary>
            [EnumMember(Value = "highest")]
            Highest = 1,

            /// <summary>
            /// Enum Recommended for value: recommended
            /// </summary>
            [EnumMember(Value = "recommended")]
            Recommended = 2,

            /// <summary>
            /// Enum Optimized for value: optimized
            /// </summary>
            [EnumMember(Value = "optimized")]
            Optimized = 3
        }


        /// <summary>
        /// Set the type of connections.
        /// </summary>
        /// <value>Set the type of connections.</value>
        [DataMember(Name = "connections", EmitDefaultValue = false)]
        public ConnectionsEnum? Connections { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallFirewall" /> class.
        /// </summary>
        /// <param name="stealthMode">Enable stealth mode..</param>
        /// <param name="randomizeId">Enable randomize IP ID..</param>
        /// <param name="decrement">decrement.</param>
        /// <param name="icmp">icmp.</param>
        /// <param name="ftpTransformsInServiceObject">ftpTransformsInServiceObject.</param>
        /// <param name="sqlnet">Enable support for oracle (SQLNet)..</param>
        /// <param name="rtspTransformations">Enable RTSP transformations..</param>
        /// <param name="drop">drop.</param>
        /// <param name="connections">Set the type of connections..</param>
        /// <param name="forceFtpData">Force inbound and outbound FTP data connections to use the default port: 20..</param>
        /// <param name="applyRulesForIntraLan">Enable apply firewall rules for intra-LAN traffic to/from the same interface..</param>
        /// <param name="issueRstForOutgoingDiscards">Enable always issue RST for discarded outgoing TCP connections..</param>
        /// <param name="ip">ip.</param>
        /// <param name="udp">udp.</param>
        /// <param name="jumboFrame">Enable support jumbo frame..</param>
        /// <param name="ipv6">ipv6.</param>
        /// <param name="controlPlaneFloodProtection">Enable control plane flood protection..</param>
        /// <param name="controlPlaneFloodProtectionThreshold">Set the threshold (CPU %)..</param>
        public FirewallFirewall(bool stealthMode = default(bool), bool randomizeId = default(bool), FirewallFirewallDecrement decrement = default(FirewallFirewallDecrement), FirewallFirewallIcmp icmp = default(FirewallFirewallIcmp), FirewallFirewallFtpTransformsInServiceObject ftpTransformsInServiceObject = default(FirewallFirewallFtpTransformsInServiceObject), bool sqlnet = default(bool), bool rtspTransformations = default(bool), FirewallFirewallDrop drop = default(FirewallFirewallDrop), ConnectionsEnum? connections = default(ConnectionsEnum?), bool forceFtpData = default(bool), bool applyRulesForIntraLan = default(bool), bool issueRstForOutgoingDiscards = default(bool), FirewallFirewallIp ip = default(FirewallFirewallIp), FirewallFirewallUdp udp = default(FirewallFirewallUdp), bool jumboFrame = default(bool), FirewallFirewallIpv6 ipv6 = default(FirewallFirewallIpv6), bool controlPlaneFloodProtection = default(bool), decimal controlPlaneFloodProtectionThreshold = default(decimal))
        {
            this.StealthMode = stealthMode;
            this.RandomizeId = randomizeId;
            this.Decrement = decrement;
            this.Icmp = icmp;
            this.FtpTransformsInServiceObject = ftpTransformsInServiceObject;
            this.Sqlnet = sqlnet;
            this.RtspTransformations = rtspTransformations;
            this.Drop = drop;
            this.Connections = connections;
            this.ForceFtpData = forceFtpData;
            this.ApplyRulesForIntraLan = applyRulesForIntraLan;
            this.IssueRstForOutgoingDiscards = issueRstForOutgoingDiscards;
            this.Ip = ip;
            this.Udp = udp;
            this.JumboFrame = jumboFrame;
            this.Ipv6 = ipv6;
            this.ControlPlaneFloodProtection = controlPlaneFloodProtection;
            this.ControlPlaneFloodProtectionThreshold = controlPlaneFloodProtectionThreshold;
        }

        /// <summary>
        /// Enable stealth mode.
        /// </summary>
        /// <value>Enable stealth mode.</value>
        [DataMember(Name = "stealth_mode", EmitDefaultValue = true)]
        public bool StealthMode { get; set; }

        /// <summary>
        /// Enable randomize IP ID.
        /// </summary>
        /// <value>Enable randomize IP ID.</value>
        [DataMember(Name = "randomize_id", EmitDefaultValue = true)]
        public bool RandomizeId { get; set; }

        /// <summary>
        /// Gets or Sets Decrement
        /// </summary>
        [DataMember(Name = "decrement", EmitDefaultValue = false)]
        public FirewallFirewallDecrement Decrement { get; set; }

        /// <summary>
        /// Gets or Sets Icmp
        /// </summary>
        [DataMember(Name = "icmp", EmitDefaultValue = false)]
        public FirewallFirewallIcmp Icmp { get; set; }

        /// <summary>
        /// Gets or Sets FtpTransformsInServiceObject
        /// </summary>
        [DataMember(Name = "ftp_transforms_in_service_object", EmitDefaultValue = false)]
        public FirewallFirewallFtpTransformsInServiceObject FtpTransformsInServiceObject { get; set; }

        /// <summary>
        /// Enable support for oracle (SQLNet).
        /// </summary>
        /// <value>Enable support for oracle (SQLNet).</value>
        [DataMember(Name = "sqlnet", EmitDefaultValue = true)]
        public bool Sqlnet { get; set; }

        /// <summary>
        /// Enable RTSP transformations.
        /// </summary>
        /// <value>Enable RTSP transformations.</value>
        [DataMember(Name = "rtsp_transformations", EmitDefaultValue = true)]
        public bool RtspTransformations { get; set; }

        /// <summary>
        /// Gets or Sets Drop
        /// </summary>
        [DataMember(Name = "drop", EmitDefaultValue = false)]
        public FirewallFirewallDrop Drop { get; set; }

        /// <summary>
        /// Force inbound and outbound FTP data connections to use the default port: 20.
        /// </summary>
        /// <value>Force inbound and outbound FTP data connections to use the default port: 20.</value>
        [DataMember(Name = "force_ftp_data", EmitDefaultValue = true)]
        public bool ForceFtpData { get; set; }

        /// <summary>
        /// Enable apply firewall rules for intra-LAN traffic to/from the same interface.
        /// </summary>
        /// <value>Enable apply firewall rules for intra-LAN traffic to/from the same interface.</value>
        [DataMember(Name = "apply_rules_for_intra_lan", EmitDefaultValue = true)]
        public bool ApplyRulesForIntraLan { get; set; }

        /// <summary>
        /// Enable always issue RST for discarded outgoing TCP connections.
        /// </summary>
        /// <value>Enable always issue RST for discarded outgoing TCP connections.</value>
        [DataMember(Name = "issue_rst_for_outgoing_discards", EmitDefaultValue = true)]
        public bool IssueRstForOutgoingDiscards { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public FirewallFirewallIp Ip { get; set; }

        /// <summary>
        /// Gets or Sets Udp
        /// </summary>
        [DataMember(Name = "udp", EmitDefaultValue = false)]
        public FirewallFirewallUdp Udp { get; set; }

        /// <summary>
        /// Enable support jumbo frame.
        /// </summary>
        /// <value>Enable support jumbo frame.</value>
        [DataMember(Name = "jumbo_frame", EmitDefaultValue = true)]
        public bool JumboFrame { get; set; }

        /// <summary>
        /// Gets or Sets Ipv6
        /// </summary>
        [DataMember(Name = "ipv6", EmitDefaultValue = false)]
        public FirewallFirewallIpv6 Ipv6 { get; set; }

        /// <summary>
        /// Enable control plane flood protection.
        /// </summary>
        /// <value>Enable control plane flood protection.</value>
        [DataMember(Name = "control_plane_flood_protection", EmitDefaultValue = true)]
        public bool ControlPlaneFloodProtection { get; set; }

        /// <summary>
        /// Set the threshold (CPU %).
        /// </summary>
        /// <value>Set the threshold (CPU %).</value>
        [DataMember(Name = "control_plane_flood_protection_threshold", EmitDefaultValue = false)]
        public decimal ControlPlaneFloodProtectionThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirewallFirewall {\n");
            sb.Append("  StealthMode: ").Append(StealthMode).Append("\n");
            sb.Append("  RandomizeId: ").Append(RandomizeId).Append("\n");
            sb.Append("  Decrement: ").Append(Decrement).Append("\n");
            sb.Append("  Icmp: ").Append(Icmp).Append("\n");
            sb.Append("  FtpTransformsInServiceObject: ").Append(FtpTransformsInServiceObject).Append("\n");
            sb.Append("  Sqlnet: ").Append(Sqlnet).Append("\n");
            sb.Append("  RtspTransformations: ").Append(RtspTransformations).Append("\n");
            sb.Append("  Drop: ").Append(Drop).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  ForceFtpData: ").Append(ForceFtpData).Append("\n");
            sb.Append("  ApplyRulesForIntraLan: ").Append(ApplyRulesForIntraLan).Append("\n");
            sb.Append("  IssueRstForOutgoingDiscards: ").Append(IssueRstForOutgoingDiscards).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Udp: ").Append(Udp).Append("\n");
            sb.Append("  JumboFrame: ").Append(JumboFrame).Append("\n");
            sb.Append("  Ipv6: ").Append(Ipv6).Append("\n");
            sb.Append("  ControlPlaneFloodProtection: ").Append(ControlPlaneFloodProtection).Append("\n");
            sb.Append("  ControlPlaneFloodProtectionThreshold: ").Append(ControlPlaneFloodProtectionThreshold).Append("\n");
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
            return this.Equals(input as FirewallFirewall);
        }

        /// <summary>
        /// Returns true if FirewallFirewall instances are equal
        /// </summary>
        /// <param name="input">Instance of FirewallFirewall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirewallFirewall input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StealthMode == input.StealthMode ||
                    this.StealthMode.Equals(input.StealthMode)
                ) && 
                (
                    this.RandomizeId == input.RandomizeId ||
                    this.RandomizeId.Equals(input.RandomizeId)
                ) && 
                (
                    this.Decrement == input.Decrement ||
                    (this.Decrement != null &&
                    this.Decrement.Equals(input.Decrement))
                ) && 
                (
                    this.Icmp == input.Icmp ||
                    (this.Icmp != null &&
                    this.Icmp.Equals(input.Icmp))
                ) && 
                (
                    this.FtpTransformsInServiceObject == input.FtpTransformsInServiceObject ||
                    (this.FtpTransformsInServiceObject != null &&
                    this.FtpTransformsInServiceObject.Equals(input.FtpTransformsInServiceObject))
                ) && 
                (
                    this.Sqlnet == input.Sqlnet ||
                    this.Sqlnet.Equals(input.Sqlnet)
                ) && 
                (
                    this.RtspTransformations == input.RtspTransformations ||
                    this.RtspTransformations.Equals(input.RtspTransformations)
                ) && 
                (
                    this.Drop == input.Drop ||
                    (this.Drop != null &&
                    this.Drop.Equals(input.Drop))
                ) && 
                (
                    this.Connections == input.Connections ||
                    this.Connections.Equals(input.Connections)
                ) && 
                (
                    this.ForceFtpData == input.ForceFtpData ||
                    this.ForceFtpData.Equals(input.ForceFtpData)
                ) && 
                (
                    this.ApplyRulesForIntraLan == input.ApplyRulesForIntraLan ||
                    this.ApplyRulesForIntraLan.Equals(input.ApplyRulesForIntraLan)
                ) && 
                (
                    this.IssueRstForOutgoingDiscards == input.IssueRstForOutgoingDiscards ||
                    this.IssueRstForOutgoingDiscards.Equals(input.IssueRstForOutgoingDiscards)
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Udp == input.Udp ||
                    (this.Udp != null &&
                    this.Udp.Equals(input.Udp))
                ) && 
                (
                    this.JumboFrame == input.JumboFrame ||
                    this.JumboFrame.Equals(input.JumboFrame)
                ) && 
                (
                    this.Ipv6 == input.Ipv6 ||
                    (this.Ipv6 != null &&
                    this.Ipv6.Equals(input.Ipv6))
                ) && 
                (
                    this.ControlPlaneFloodProtection == input.ControlPlaneFloodProtection ||
                    this.ControlPlaneFloodProtection.Equals(input.ControlPlaneFloodProtection)
                ) && 
                (
                    this.ControlPlaneFloodProtectionThreshold == input.ControlPlaneFloodProtectionThreshold ||
                    this.ControlPlaneFloodProtectionThreshold.Equals(input.ControlPlaneFloodProtectionThreshold)
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
                hashCode = (hashCode * 59) + this.StealthMode.GetHashCode();
                hashCode = (hashCode * 59) + this.RandomizeId.GetHashCode();
                if (this.Decrement != null)
                {
                    hashCode = (hashCode * 59) + this.Decrement.GetHashCode();
                }
                if (this.Icmp != null)
                {
                    hashCode = (hashCode * 59) + this.Icmp.GetHashCode();
                }
                if (this.FtpTransformsInServiceObject != null)
                {
                    hashCode = (hashCode * 59) + this.FtpTransformsInServiceObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Sqlnet.GetHashCode();
                hashCode = (hashCode * 59) + this.RtspTransformations.GetHashCode();
                if (this.Drop != null)
                {
                    hashCode = (hashCode * 59) + this.Drop.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Connections.GetHashCode();
                hashCode = (hashCode * 59) + this.ForceFtpData.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplyRulesForIntraLan.GetHashCode();
                hashCode = (hashCode * 59) + this.IssueRstForOutgoingDiscards.GetHashCode();
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                if (this.Udp != null)
                {
                    hashCode = (hashCode * 59) + this.Udp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JumboFrame.GetHashCode();
                if (this.Ipv6 != null)
                {
                    hashCode = (hashCode * 59) + this.Ipv6.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ControlPlaneFloodProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.ControlPlaneFloodProtectionThreshold.GetHashCode();
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