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
    /// Configure TCP settings.
    /// </summary>
    [DataContract(Name = "tcp_tcp")]
    public partial class TcpTcp : IEquatable<TcpTcp>, IValidatableObject
    {
        /// <summary>
        /// Set TCP SYN flood protection mode.
        /// </summary>
        /// <value>Set TCP SYN flood protection mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SynFloodProtectionModeEnum
        {
            /// <summary>
            /// Enum WatchAndReport for value: watch-and-report
            /// </summary>
            [EnumMember(Value = "watch-and-report")]
            WatchAndReport = 1,

            /// <summary>
            /// Enum ProxySuspectAttack for value: proxy-suspect-attack
            /// </summary>
            [EnumMember(Value = "proxy-suspect-attack")]
            ProxySuspectAttack = 2,

            /// <summary>
            /// Enum AlwaysProxy for value: always-proxy
            /// </summary>
            [EnumMember(Value = "always-proxy")]
            AlwaysProxy = 3
        }


        /// <summary>
        /// Set TCP SYN flood protection mode.
        /// </summary>
        /// <value>Set TCP SYN flood protection mode.</value>
        [DataMember(Name = "syn_flood_protection_mode", EmitDefaultValue = false)]
        public SynFloodProtectionModeEnum? SynFloodProtectionMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TcpTcp" /> class.
        /// </summary>
        /// <param name="enforceStrictCompliance">Enable enforcement of strict TCP compliance with RFC 793 and RFC 1122..</param>
        /// <param name="handshakeEnforcement">Enable TCP handshake enforcement..</param>
        /// <param name="checksumEnforcement">Enable TCP checksum enforcement..</param>
        /// <param name="drop">drop.</param>
        /// <param name="enableHandshakeTimeout">Enable the TCP handshake timeout configure..</param>
        /// <param name="handshakeTimeout">Set the TCP handshake timeout in seconds..</param>
        /// <param name="defaultConnectionTimeout">Set default TCP connection timeout in minutes..</param>
        /// <param name="maximumSegmentLifetime">Set maximum segment lifetime in seconds..</param>
        /// <param name="halfOpenThreshold">Enable half open TCP connections threshold..</param>
        /// <param name="maximumHalfOpenConnections">Set maximum half open TCP connections..</param>
        /// <param name="synFloodProtectionMode">Set TCP SYN flood protection mode..</param>
        /// <param name="synAttackThreshold">Set attack threshold (incomplete connection attempts / second)..</param>
        /// <param name="supportTcpSack">Enable all LAN/DMZ servers support the TCP SACK option..</param>
        /// <param name="enableLimitMss">Enable limit MSS sent to WAN clients (when connections are proxied)..</param>
        /// <param name="limitMssMax">Set maximum TCP MSS sent to WAN clients..</param>
        /// <param name="alwaysLogSynPackets">Enable always log SYN packets received..</param>
        /// <param name="proxyConnections">proxyConnections.</param>
        /// <param name="synFloodBlacklisting">Enable SYN/RST/FIN flood blacklisting on all interfaces..</param>
        /// <param name="blacklistThreshold">Set threshold for SYN/RST/FIN flood blacklisting (packets / sec)..</param>
        /// <param name="neverBlacklistWan">Enable never blacklist WAN machines..</param>
        /// <param name="alwaysAllowManagement">Enable always allow SonicWall management traffic..</param>
        /// <param name="ddos">ddos.</param>
        public TcpTcp(bool enforceStrictCompliance = default(bool), bool handshakeEnforcement = default(bool), bool checksumEnforcement = default(bool), TcpTcpDrop drop = default(TcpTcpDrop), bool enableHandshakeTimeout = default(bool), decimal handshakeTimeout = default(decimal), decimal defaultConnectionTimeout = default(decimal), decimal maximumSegmentLifetime = default(decimal), bool halfOpenThreshold = default(bool), decimal maximumHalfOpenConnections = default(decimal), SynFloodProtectionModeEnum? synFloodProtectionMode = default(SynFloodProtectionModeEnum?), decimal synAttackThreshold = default(decimal), bool supportTcpSack = default(bool), bool enableLimitMss = default(bool), decimal limitMssMax = default(decimal), bool alwaysLogSynPackets = default(bool), TcpTcpProxyConnections proxyConnections = default(TcpTcpProxyConnections), bool synFloodBlacklisting = default(bool), decimal blacklistThreshold = default(decimal), bool neverBlacklistWan = default(bool), bool alwaysAllowManagement = default(bool), TcpTcpDdos ddos = default(TcpTcpDdos))
        {
            this.EnforceStrictCompliance = enforceStrictCompliance;
            this.HandshakeEnforcement = handshakeEnforcement;
            this.ChecksumEnforcement = checksumEnforcement;
            this.Drop = drop;
            this.EnableHandshakeTimeout = enableHandshakeTimeout;
            this.HandshakeTimeout = handshakeTimeout;
            this.DefaultConnectionTimeout = defaultConnectionTimeout;
            this.MaximumSegmentLifetime = maximumSegmentLifetime;
            this.HalfOpenThreshold = halfOpenThreshold;
            this.MaximumHalfOpenConnections = maximumHalfOpenConnections;
            this.SynFloodProtectionMode = synFloodProtectionMode;
            this.SynAttackThreshold = synAttackThreshold;
            this.SupportTcpSack = supportTcpSack;
            this.EnableLimitMss = enableLimitMss;
            this.LimitMssMax = limitMssMax;
            this.AlwaysLogSynPackets = alwaysLogSynPackets;
            this.ProxyConnections = proxyConnections;
            this.SynFloodBlacklisting = synFloodBlacklisting;
            this.BlacklistThreshold = blacklistThreshold;
            this.NeverBlacklistWan = neverBlacklistWan;
            this.AlwaysAllowManagement = alwaysAllowManagement;
            this.Ddos = ddos;
        }

        /// <summary>
        /// Enable enforcement of strict TCP compliance with RFC 793 and RFC 1122.
        /// </summary>
        /// <value>Enable enforcement of strict TCP compliance with RFC 793 and RFC 1122.</value>
        [DataMember(Name = "enforce_strict_compliance", EmitDefaultValue = true)]
        public bool EnforceStrictCompliance { get; set; }

        /// <summary>
        /// Enable TCP handshake enforcement.
        /// </summary>
        /// <value>Enable TCP handshake enforcement.</value>
        [DataMember(Name = "handshake_enforcement", EmitDefaultValue = true)]
        public bool HandshakeEnforcement { get; set; }

        /// <summary>
        /// Enable TCP checksum enforcement.
        /// </summary>
        /// <value>Enable TCP checksum enforcement.</value>
        [DataMember(Name = "checksum_enforcement", EmitDefaultValue = true)]
        public bool ChecksumEnforcement { get; set; }

        /// <summary>
        /// Gets or Sets Drop
        /// </summary>
        [DataMember(Name = "drop", EmitDefaultValue = false)]
        public TcpTcpDrop Drop { get; set; }

        /// <summary>
        /// Enable the TCP handshake timeout configure.
        /// </summary>
        /// <value>Enable the TCP handshake timeout configure.</value>
        [DataMember(Name = "enable_handshake_timeout", EmitDefaultValue = true)]
        public bool EnableHandshakeTimeout { get; set; }

        /// <summary>
        /// Set the TCP handshake timeout in seconds.
        /// </summary>
        /// <value>Set the TCP handshake timeout in seconds.</value>
        [DataMember(Name = "handshake_timeout", EmitDefaultValue = false)]
        public decimal HandshakeTimeout { get; set; }

        /// <summary>
        /// Set default TCP connection timeout in minutes.
        /// </summary>
        /// <value>Set default TCP connection timeout in minutes.</value>
        [DataMember(Name = "default_connection_timeout", EmitDefaultValue = false)]
        public decimal DefaultConnectionTimeout { get; set; }

        /// <summary>
        /// Set maximum segment lifetime in seconds.
        /// </summary>
        /// <value>Set maximum segment lifetime in seconds.</value>
        [DataMember(Name = "maximum_segment_lifetime", EmitDefaultValue = false)]
        public decimal MaximumSegmentLifetime { get; set; }

        /// <summary>
        /// Enable half open TCP connections threshold.
        /// </summary>
        /// <value>Enable half open TCP connections threshold.</value>
        [DataMember(Name = "half_open_threshold", EmitDefaultValue = true)]
        public bool HalfOpenThreshold { get; set; }

        /// <summary>
        /// Set maximum half open TCP connections.
        /// </summary>
        /// <value>Set maximum half open TCP connections.</value>
        [DataMember(Name = "maximum_half_open_connections", EmitDefaultValue = false)]
        public decimal MaximumHalfOpenConnections { get; set; }

        /// <summary>
        /// Set attack threshold (incomplete connection attempts / second).
        /// </summary>
        /// <value>Set attack threshold (incomplete connection attempts / second).</value>
        [DataMember(Name = "syn_attack_threshold", EmitDefaultValue = false)]
        public decimal SynAttackThreshold { get; set; }

        /// <summary>
        /// Enable all LAN/DMZ servers support the TCP SACK option.
        /// </summary>
        /// <value>Enable all LAN/DMZ servers support the TCP SACK option.</value>
        [DataMember(Name = "support_tcp_sack", EmitDefaultValue = true)]
        public bool SupportTcpSack { get; set; }

        /// <summary>
        /// Enable limit MSS sent to WAN clients (when connections are proxied).
        /// </summary>
        /// <value>Enable limit MSS sent to WAN clients (when connections are proxied).</value>
        [DataMember(Name = "enable_limit_mss", EmitDefaultValue = true)]
        public bool EnableLimitMss { get; set; }

        /// <summary>
        /// Set maximum TCP MSS sent to WAN clients.
        /// </summary>
        /// <value>Set maximum TCP MSS sent to WAN clients.</value>
        [DataMember(Name = "limit_mss_max", EmitDefaultValue = false)]
        public decimal LimitMssMax { get; set; }

        /// <summary>
        /// Enable always log SYN packets received.
        /// </summary>
        /// <value>Enable always log SYN packets received.</value>
        [DataMember(Name = "always_log_syn_packets", EmitDefaultValue = true)]
        public bool AlwaysLogSynPackets { get; set; }

        /// <summary>
        /// Gets or Sets ProxyConnections
        /// </summary>
        [DataMember(Name = "proxy_connections", EmitDefaultValue = true)]
        public TcpTcpProxyConnections ProxyConnections { get; set; }

        /// <summary>
        /// Enable SYN/RST/FIN flood blacklisting on all interfaces.
        /// </summary>
        /// <value>Enable SYN/RST/FIN flood blacklisting on all interfaces.</value>
        [DataMember(Name = "syn_flood_blacklisting", EmitDefaultValue = true)]
        public bool SynFloodBlacklisting { get; set; }

        /// <summary>
        /// Set threshold for SYN/RST/FIN flood blacklisting (packets / sec).
        /// </summary>
        /// <value>Set threshold for SYN/RST/FIN flood blacklisting (packets / sec).</value>
        [DataMember(Name = "blacklist_threshold", EmitDefaultValue = false)]
        public decimal BlacklistThreshold { get; set; }

        /// <summary>
        /// Enable never blacklist WAN machines.
        /// </summary>
        /// <value>Enable never blacklist WAN machines.</value>
        [DataMember(Name = "never_blacklist_wan", EmitDefaultValue = true)]
        public bool NeverBlacklistWan { get; set; }

        /// <summary>
        /// Enable always allow SonicWall management traffic.
        /// </summary>
        /// <value>Enable always allow SonicWall management traffic.</value>
        [DataMember(Name = "always_allow_management", EmitDefaultValue = true)]
        public bool AlwaysAllowManagement { get; set; }

        /// <summary>
        /// Gets or Sets Ddos
        /// </summary>
        [DataMember(Name = "ddos", EmitDefaultValue = false)]
        public TcpTcpDdos Ddos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TcpTcp {\n");
            sb.Append("  EnforceStrictCompliance: ").Append(EnforceStrictCompliance).Append("\n");
            sb.Append("  HandshakeEnforcement: ").Append(HandshakeEnforcement).Append("\n");
            sb.Append("  ChecksumEnforcement: ").Append(ChecksumEnforcement).Append("\n");
            sb.Append("  Drop: ").Append(Drop).Append("\n");
            sb.Append("  EnableHandshakeTimeout: ").Append(EnableHandshakeTimeout).Append("\n");
            sb.Append("  HandshakeTimeout: ").Append(HandshakeTimeout).Append("\n");
            sb.Append("  DefaultConnectionTimeout: ").Append(DefaultConnectionTimeout).Append("\n");
            sb.Append("  MaximumSegmentLifetime: ").Append(MaximumSegmentLifetime).Append("\n");
            sb.Append("  HalfOpenThreshold: ").Append(HalfOpenThreshold).Append("\n");
            sb.Append("  MaximumHalfOpenConnections: ").Append(MaximumHalfOpenConnections).Append("\n");
            sb.Append("  SynFloodProtectionMode: ").Append(SynFloodProtectionMode).Append("\n");
            sb.Append("  SynAttackThreshold: ").Append(SynAttackThreshold).Append("\n");
            sb.Append("  SupportTcpSack: ").Append(SupportTcpSack).Append("\n");
            sb.Append("  EnableLimitMss: ").Append(EnableLimitMss).Append("\n");
            sb.Append("  LimitMssMax: ").Append(LimitMssMax).Append("\n");
            sb.Append("  AlwaysLogSynPackets: ").Append(AlwaysLogSynPackets).Append("\n");
            sb.Append("  ProxyConnections: ").Append(ProxyConnections).Append("\n");
            sb.Append("  SynFloodBlacklisting: ").Append(SynFloodBlacklisting).Append("\n");
            sb.Append("  BlacklistThreshold: ").Append(BlacklistThreshold).Append("\n");
            sb.Append("  NeverBlacklistWan: ").Append(NeverBlacklistWan).Append("\n");
            sb.Append("  AlwaysAllowManagement: ").Append(AlwaysAllowManagement).Append("\n");
            sb.Append("  Ddos: ").Append(Ddos).Append("\n");
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
            return this.Equals(input as TcpTcp);
        }

        /// <summary>
        /// Returns true if TcpTcp instances are equal
        /// </summary>
        /// <param name="input">Instance of TcpTcp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TcpTcp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnforceStrictCompliance == input.EnforceStrictCompliance ||
                    this.EnforceStrictCompliance.Equals(input.EnforceStrictCompliance)
                ) && 
                (
                    this.HandshakeEnforcement == input.HandshakeEnforcement ||
                    this.HandshakeEnforcement.Equals(input.HandshakeEnforcement)
                ) && 
                (
                    this.ChecksumEnforcement == input.ChecksumEnforcement ||
                    this.ChecksumEnforcement.Equals(input.ChecksumEnforcement)
                ) && 
                (
                    this.Drop == input.Drop ||
                    (this.Drop != null &&
                    this.Drop.Equals(input.Drop))
                ) && 
                (
                    this.EnableHandshakeTimeout == input.EnableHandshakeTimeout ||
                    this.EnableHandshakeTimeout.Equals(input.EnableHandshakeTimeout)
                ) && 
                (
                    this.HandshakeTimeout == input.HandshakeTimeout ||
                    this.HandshakeTimeout.Equals(input.HandshakeTimeout)
                ) && 
                (
                    this.DefaultConnectionTimeout == input.DefaultConnectionTimeout ||
                    this.DefaultConnectionTimeout.Equals(input.DefaultConnectionTimeout)
                ) && 
                (
                    this.MaximumSegmentLifetime == input.MaximumSegmentLifetime ||
                    this.MaximumSegmentLifetime.Equals(input.MaximumSegmentLifetime)
                ) && 
                (
                    this.HalfOpenThreshold == input.HalfOpenThreshold ||
                    this.HalfOpenThreshold.Equals(input.HalfOpenThreshold)
                ) && 
                (
                    this.MaximumHalfOpenConnections == input.MaximumHalfOpenConnections ||
                    this.MaximumHalfOpenConnections.Equals(input.MaximumHalfOpenConnections)
                ) && 
                (
                    this.SynFloodProtectionMode == input.SynFloodProtectionMode ||
                    this.SynFloodProtectionMode.Equals(input.SynFloodProtectionMode)
                ) && 
                (
                    this.SynAttackThreshold == input.SynAttackThreshold ||
                    this.SynAttackThreshold.Equals(input.SynAttackThreshold)
                ) && 
                (
                    this.SupportTcpSack == input.SupportTcpSack ||
                    this.SupportTcpSack.Equals(input.SupportTcpSack)
                ) && 
                (
                    this.EnableLimitMss == input.EnableLimitMss ||
                    this.EnableLimitMss.Equals(input.EnableLimitMss)
                ) && 
                (
                    this.LimitMssMax == input.LimitMssMax ||
                    this.LimitMssMax.Equals(input.LimitMssMax)
                ) && 
                (
                    this.AlwaysLogSynPackets == input.AlwaysLogSynPackets ||
                    this.AlwaysLogSynPackets.Equals(input.AlwaysLogSynPackets)
                ) && 
                (
                    this.ProxyConnections == input.ProxyConnections ||
                    (this.ProxyConnections != null &&
                    this.ProxyConnections.Equals(input.ProxyConnections))
                ) && 
                (
                    this.SynFloodBlacklisting == input.SynFloodBlacklisting ||
                    this.SynFloodBlacklisting.Equals(input.SynFloodBlacklisting)
                ) && 
                (
                    this.BlacklistThreshold == input.BlacklistThreshold ||
                    this.BlacklistThreshold.Equals(input.BlacklistThreshold)
                ) && 
                (
                    this.NeverBlacklistWan == input.NeverBlacklistWan ||
                    this.NeverBlacklistWan.Equals(input.NeverBlacklistWan)
                ) && 
                (
                    this.AlwaysAllowManagement == input.AlwaysAllowManagement ||
                    this.AlwaysAllowManagement.Equals(input.AlwaysAllowManagement)
                ) && 
                (
                    this.Ddos == input.Ddos ||
                    (this.Ddos != null &&
                    this.Ddos.Equals(input.Ddos))
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
                hashCode = (hashCode * 59) + this.EnforceStrictCompliance.GetHashCode();
                hashCode = (hashCode * 59) + this.HandshakeEnforcement.GetHashCode();
                hashCode = (hashCode * 59) + this.ChecksumEnforcement.GetHashCode();
                if (this.Drop != null)
                {
                    hashCode = (hashCode * 59) + this.Drop.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableHandshakeTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.HandshakeTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.DefaultConnectionTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumSegmentLifetime.GetHashCode();
                hashCode = (hashCode * 59) + this.HalfOpenThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumHalfOpenConnections.GetHashCode();
                hashCode = (hashCode * 59) + this.SynFloodProtectionMode.GetHashCode();
                hashCode = (hashCode * 59) + this.SynAttackThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.SupportTcpSack.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableLimitMss.GetHashCode();
                hashCode = (hashCode * 59) + this.LimitMssMax.GetHashCode();
                hashCode = (hashCode * 59) + this.AlwaysLogSynPackets.GetHashCode();
                if (this.ProxyConnections != null)
                {
                    hashCode = (hashCode * 59) + this.ProxyConnections.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SynFloodBlacklisting.GetHashCode();
                hashCode = (hashCode * 59) + this.BlacklistThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.NeverBlacklistWan.GetHashCode();
                hashCode = (hashCode * 59) + this.AlwaysAllowManagement.GetHashCode();
                if (this.Ddos != null)
                {
                    hashCode = (hashCode * 59) + this.Ddos.GetHashCode();
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
            // MaximumHalfOpenConnections (decimal) minimum
            if (this.MaximumHalfOpenConnections < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaximumHalfOpenConnections, must be a value greater than or equal to 0.", new [] { "MaximumHalfOpenConnections" });
            }

            yield break;
        }
    }

}