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
    /// Configure advanced diag firewall settings.
    /// </summary>
    [DataContract(Name = "diag_advanced_firewall_diag_advanced_firewall")]
    public partial class DiagAdvancedFirewallDiagAdvancedFirewall : IEquatable<DiagAdvancedFirewallDiagAdvancedFirewall>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedFirewallDiagAdvancedFirewall" /> class.
        /// </summary>
        /// <param name="killCacheNoDelay">Enable do not go to TIME_WAIT state when TCP 4-ways FIN completed..</param>
        /// <param name="ftpBounceAttackProtection">Enable FTP bounce attack protection..</param>
        /// <param name="ftpProtocolAnomalyAttackProtection">Enable FTP protocol anomaly attack protection..</param>
        /// <param name="orphanDataConnection">Enable allow orphan data connections..</param>
        /// <param name="allowZeroPort">Enable allow tcp/udp packet with source port being zero to pass through firewall..</param>
        /// <param name="ipSpoofChecking">Enable IP spoof checking..</param>
        /// <param name="portScanDetection">Enable port scan detection..</param>
        /// <param name="ucaplCompliance">Enable UCAPL compliance..</param>
        /// <param name="anticipatedConnectionTimeout">Set timeout for anticipated TCP/UDP connections (seconds)..</param>
        /// <param name="anticipatedConnectionParentTermination">Enable termination of parent on timeout of anticipated TCP/UDP connections..</param>
        /// <param name="cacheIgnoreIcmpReject">Enable don&#39;t allow ICMP TTL exceed or destination Unreachable to kill cache entries..</param>
        /// <param name="anticipatedMediaTimeout">Set timeout for anticipated media connections(seconds)..</param>
        /// <param name="anticipatedMediaParentTermination">Enable termination of parent on timeout of anticipated media connections..</param>
        /// <param name="traceConnectionsPort">Set TCP port to trace connections to..</param>
        /// <param name="includeTcpDataConnection">Enable include TCP data connections in traces..</param>
        /// <param name="trackBandwidthUsage">Enable tracking bandwidth usage for default traffic..</param>
        /// <param name="decreaseConnectionCountAfterClose">Enable decreasing connection count immediately after TCP connection close..</param>
        /// <param name="csrfTokenValidation">Enable use CSRF Token Validation..</param>
        /// <param name="secureSessionIdCookie">Enable use secure session id cookie..</param>
        /// <param name="tcpStateManipulationDosProtection">Enable protection against TCP state manipulation DoS..</param>
        /// <param name="sequentialAddresses">Enable allocation of sequential addresses when performing many-to-few NAT..</param>
        /// <param name="defaultPolicyEditable">Enable the ability to remove and fully edit auto-added access rules and NATs..</param>
        /// <param name="autoAddedNatPolicyDisabling">Enable the ability to disable auto-added NAT policies..</param>
        /// <param name="udpIcmpFloodDetecting">Enable aggressive UDP/ICMP flood detecting..</param>
        /// <param name="controlPanelFloodProtection">Set control panel flood protection hold time..</param>
        /// <param name="udpIcmpFloodProtection">Enable enforce UDP/ICMP flood protection with 100-millisecond resolution..</param>
        /// <param name="systemOverloadProtection">Enable system overload protection..</param>
        /// <param name="systemOverloadThreshold">Set control panel flood protection hold time..</param>
        /// <param name="bypassVpnTraffic">Enable bypass VPN traffic from flood protection..</param>
        /// <param name="logObjectName">Enable log packet content, schedule and address object name..</param>
        /// <param name="policiesConnectionLimitation">Enable set connection limitation of management policies..</param>
        /// <param name="resetLoginCounter">Reset user succesful login counter (hours)..</param>
        /// <param name="sendRstOnTimeout">Enable send RST on timeout TCP connection..</param>
        /// <param name="asyncSaveFlashPeriod">Set the async save flash period in seconds..</param>
        public DiagAdvancedFirewallDiagAdvancedFirewall(bool killCacheNoDelay = default(bool), bool ftpBounceAttackProtection = default(bool), bool ftpProtocolAnomalyAttackProtection = default(bool), bool orphanDataConnection = default(bool), bool allowZeroPort = default(bool), bool ipSpoofChecking = default(bool), bool portScanDetection = default(bool), bool ucaplCompliance = default(bool), decimal anticipatedConnectionTimeout = default(decimal), bool anticipatedConnectionParentTermination = default(bool), bool cacheIgnoreIcmpReject = default(bool), decimal anticipatedMediaTimeout = default(decimal), bool anticipatedMediaParentTermination = default(bool), decimal traceConnectionsPort = default(decimal), bool includeTcpDataConnection = default(bool), bool trackBandwidthUsage = default(bool), bool decreaseConnectionCountAfterClose = default(bool), bool csrfTokenValidation = default(bool), bool secureSessionIdCookie = default(bool), bool tcpStateManipulationDosProtection = default(bool), bool sequentialAddresses = default(bool), bool defaultPolicyEditable = default(bool), bool autoAddedNatPolicyDisabling = default(bool), bool udpIcmpFloodDetecting = default(bool), decimal controlPanelFloodProtection = default(decimal), bool udpIcmpFloodProtection = default(bool), bool systemOverloadProtection = default(bool), decimal systemOverloadThreshold = default(decimal), bool bypassVpnTraffic = default(bool), bool logObjectName = default(bool), bool policiesConnectionLimitation = default(bool), decimal resetLoginCounter = default(decimal), bool sendRstOnTimeout = default(bool), decimal asyncSaveFlashPeriod = default(decimal))
        {
            this.KillCacheNoDelay = killCacheNoDelay;
            this.FtpBounceAttackProtection = ftpBounceAttackProtection;
            this.FtpProtocolAnomalyAttackProtection = ftpProtocolAnomalyAttackProtection;
            this.OrphanDataConnection = orphanDataConnection;
            this.AllowZeroPort = allowZeroPort;
            this.IpSpoofChecking = ipSpoofChecking;
            this.PortScanDetection = portScanDetection;
            this.UcaplCompliance = ucaplCompliance;
            this.AnticipatedConnectionTimeout = anticipatedConnectionTimeout;
            this.AnticipatedConnectionParentTermination = anticipatedConnectionParentTermination;
            this.CacheIgnoreIcmpReject = cacheIgnoreIcmpReject;
            this.AnticipatedMediaTimeout = anticipatedMediaTimeout;
            this.AnticipatedMediaParentTermination = anticipatedMediaParentTermination;
            this.TraceConnectionsPort = traceConnectionsPort;
            this.IncludeTcpDataConnection = includeTcpDataConnection;
            this.TrackBandwidthUsage = trackBandwidthUsage;
            this.DecreaseConnectionCountAfterClose = decreaseConnectionCountAfterClose;
            this.CsrfTokenValidation = csrfTokenValidation;
            this.SecureSessionIdCookie = secureSessionIdCookie;
            this.TcpStateManipulationDosProtection = tcpStateManipulationDosProtection;
            this.SequentialAddresses = sequentialAddresses;
            this.DefaultPolicyEditable = defaultPolicyEditable;
            this.AutoAddedNatPolicyDisabling = autoAddedNatPolicyDisabling;
            this.UdpIcmpFloodDetecting = udpIcmpFloodDetecting;
            this.ControlPanelFloodProtection = controlPanelFloodProtection;
            this.UdpIcmpFloodProtection = udpIcmpFloodProtection;
            this.SystemOverloadProtection = systemOverloadProtection;
            this.SystemOverloadThreshold = systemOverloadThreshold;
            this.BypassVpnTraffic = bypassVpnTraffic;
            this.LogObjectName = logObjectName;
            this.PoliciesConnectionLimitation = policiesConnectionLimitation;
            this.ResetLoginCounter = resetLoginCounter;
            this.SendRstOnTimeout = sendRstOnTimeout;
            this.AsyncSaveFlashPeriod = asyncSaveFlashPeriod;
        }

        /// <summary>
        /// Enable do not go to TIME_WAIT state when TCP 4-ways FIN completed.
        /// </summary>
        /// <value>Enable do not go to TIME_WAIT state when TCP 4-ways FIN completed.</value>
        [DataMember(Name = "kill_cache_no_delay", EmitDefaultValue = true)]
        public bool KillCacheNoDelay { get; set; }

        /// <summary>
        /// Enable FTP bounce attack protection.
        /// </summary>
        /// <value>Enable FTP bounce attack protection.</value>
        [DataMember(Name = "ftp_bounce_attack_protection", EmitDefaultValue = true)]
        public bool FtpBounceAttackProtection { get; set; }

        /// <summary>
        /// Enable FTP protocol anomaly attack protection.
        /// </summary>
        /// <value>Enable FTP protocol anomaly attack protection.</value>
        [DataMember(Name = "ftp_protocol_anomaly_attack_protection", EmitDefaultValue = true)]
        public bool FtpProtocolAnomalyAttackProtection { get; set; }

        /// <summary>
        /// Enable allow orphan data connections.
        /// </summary>
        /// <value>Enable allow orphan data connections.</value>
        [DataMember(Name = "orphan_data_connection", EmitDefaultValue = true)]
        public bool OrphanDataConnection { get; set; }

        /// <summary>
        /// Enable allow tcp/udp packet with source port being zero to pass through firewall.
        /// </summary>
        /// <value>Enable allow tcp/udp packet with source port being zero to pass through firewall.</value>
        [DataMember(Name = "allow_zero_Port", EmitDefaultValue = true)]
        public bool AllowZeroPort { get; set; }

        /// <summary>
        /// Enable IP spoof checking.
        /// </summary>
        /// <value>Enable IP spoof checking.</value>
        [DataMember(Name = "ip_spoof_checking", EmitDefaultValue = true)]
        public bool IpSpoofChecking { get; set; }

        /// <summary>
        /// Enable port scan detection.
        /// </summary>
        /// <value>Enable port scan detection.</value>
        [DataMember(Name = "port_scan_detection", EmitDefaultValue = true)]
        public bool PortScanDetection { get; set; }

        /// <summary>
        /// Enable UCAPL compliance.
        /// </summary>
        /// <value>Enable UCAPL compliance.</value>
        [DataMember(Name = "ucapl_compliance", EmitDefaultValue = true)]
        public bool UcaplCompliance { get; set; }

        /// <summary>
        /// Set timeout for anticipated TCP/UDP connections (seconds).
        /// </summary>
        /// <value>Set timeout for anticipated TCP/UDP connections (seconds).</value>
        [DataMember(Name = "anticipated_connection_timeout", EmitDefaultValue = false)]
        public decimal AnticipatedConnectionTimeout { get; set; }

        /// <summary>
        /// Enable termination of parent on timeout of anticipated TCP/UDP connections.
        /// </summary>
        /// <value>Enable termination of parent on timeout of anticipated TCP/UDP connections.</value>
        [DataMember(Name = "anticipated_connection_parent_termination", EmitDefaultValue = true)]
        public bool AnticipatedConnectionParentTermination { get; set; }

        /// <summary>
        /// Enable don&#39;t allow ICMP TTL exceed or destination Unreachable to kill cache entries.
        /// </summary>
        /// <value>Enable don&#39;t allow ICMP TTL exceed or destination Unreachable to kill cache entries.</value>
        [DataMember(Name = "cache_ignore_icmp_reject", EmitDefaultValue = true)]
        public bool CacheIgnoreIcmpReject { get; set; }

        /// <summary>
        /// Set timeout for anticipated media connections(seconds).
        /// </summary>
        /// <value>Set timeout for anticipated media connections(seconds).</value>
        [DataMember(Name = "anticipated_media_timeout", EmitDefaultValue = false)]
        public decimal AnticipatedMediaTimeout { get; set; }

        /// <summary>
        /// Enable termination of parent on timeout of anticipated media connections.
        /// </summary>
        /// <value>Enable termination of parent on timeout of anticipated media connections.</value>
        [DataMember(Name = "anticipated_media_parent_termination", EmitDefaultValue = true)]
        public bool AnticipatedMediaParentTermination { get; set; }

        /// <summary>
        /// Set TCP port to trace connections to.
        /// </summary>
        /// <value>Set TCP port to trace connections to.</value>
        [DataMember(Name = "trace_connections_port", EmitDefaultValue = false)]
        public decimal TraceConnectionsPort { get; set; }

        /// <summary>
        /// Enable include TCP data connections in traces.
        /// </summary>
        /// <value>Enable include TCP data connections in traces.</value>
        [DataMember(Name = "include_tcp_data_connection", EmitDefaultValue = true)]
        public bool IncludeTcpDataConnection { get; set; }

        /// <summary>
        /// Enable tracking bandwidth usage for default traffic.
        /// </summary>
        /// <value>Enable tracking bandwidth usage for default traffic.</value>
        [DataMember(Name = "track_bandwidth_usage", EmitDefaultValue = true)]
        public bool TrackBandwidthUsage { get; set; }

        /// <summary>
        /// Enable decreasing connection count immediately after TCP connection close.
        /// </summary>
        /// <value>Enable decreasing connection count immediately after TCP connection close.</value>
        [DataMember(Name = "decrease_connection_count_after_close", EmitDefaultValue = true)]
        public bool DecreaseConnectionCountAfterClose { get; set; }

        /// <summary>
        /// Enable use CSRF Token Validation.
        /// </summary>
        /// <value>Enable use CSRF Token Validation.</value>
        [DataMember(Name = "csrf_token_validation", EmitDefaultValue = true)]
        public bool CsrfTokenValidation { get; set; }

        /// <summary>
        /// Enable use secure session id cookie.
        /// </summary>
        /// <value>Enable use secure session id cookie.</value>
        [DataMember(Name = "secure_session_id_cookie", EmitDefaultValue = true)]
        public bool SecureSessionIdCookie { get; set; }

        /// <summary>
        /// Enable protection against TCP state manipulation DoS.
        /// </summary>
        /// <value>Enable protection against TCP state manipulation DoS.</value>
        [DataMember(Name = "tcp_state_manipulation_dos_protection", EmitDefaultValue = true)]
        public bool TcpStateManipulationDosProtection { get; set; }

        /// <summary>
        /// Enable allocation of sequential addresses when performing many-to-few NAT.
        /// </summary>
        /// <value>Enable allocation of sequential addresses when performing many-to-few NAT.</value>
        [DataMember(Name = "sequential_addresses", EmitDefaultValue = true)]
        public bool SequentialAddresses { get; set; }

        /// <summary>
        /// Enable the ability to remove and fully edit auto-added access rules and NATs.
        /// </summary>
        /// <value>Enable the ability to remove and fully edit auto-added access rules and NATs.</value>
        [DataMember(Name = "default_policy_editable", EmitDefaultValue = true)]
        public bool DefaultPolicyEditable { get; set; }

        /// <summary>
        /// Enable the ability to disable auto-added NAT policies.
        /// </summary>
        /// <value>Enable the ability to disable auto-added NAT policies.</value>
        [DataMember(Name = "auto_added_nat_policy_disabling", EmitDefaultValue = true)]
        public bool AutoAddedNatPolicyDisabling { get; set; }

        /// <summary>
        /// Enable aggressive UDP/ICMP flood detecting.
        /// </summary>
        /// <value>Enable aggressive UDP/ICMP flood detecting.</value>
        [DataMember(Name = "udp_icmp_flood_detecting", EmitDefaultValue = true)]
        public bool UdpIcmpFloodDetecting { get; set; }

        /// <summary>
        /// Set control panel flood protection hold time.
        /// </summary>
        /// <value>Set control panel flood protection hold time.</value>
        [DataMember(Name = "control_panel_flood_protection", EmitDefaultValue = false)]
        public decimal ControlPanelFloodProtection { get; set; }

        /// <summary>
        /// Enable enforce UDP/ICMP flood protection with 100-millisecond resolution.
        /// </summary>
        /// <value>Enable enforce UDP/ICMP flood protection with 100-millisecond resolution.</value>
        [DataMember(Name = "udp_icmp_flood_protection", EmitDefaultValue = true)]
        public bool UdpIcmpFloodProtection { get; set; }

        /// <summary>
        /// Enable system overload protection.
        /// </summary>
        /// <value>Enable system overload protection.</value>
        [DataMember(Name = "system_overload_protection", EmitDefaultValue = true)]
        public bool SystemOverloadProtection { get; set; }

        /// <summary>
        /// Set control panel flood protection hold time.
        /// </summary>
        /// <value>Set control panel flood protection hold time.</value>
        [DataMember(Name = "system_overload_threshold", EmitDefaultValue = false)]
        public decimal SystemOverloadThreshold { get; set; }

        /// <summary>
        /// Enable bypass VPN traffic from flood protection.
        /// </summary>
        /// <value>Enable bypass VPN traffic from flood protection.</value>
        [DataMember(Name = "bypass_vpn_traffic", EmitDefaultValue = true)]
        public bool BypassVpnTraffic { get; set; }

        /// <summary>
        /// Enable log packet content, schedule and address object name.
        /// </summary>
        /// <value>Enable log packet content, schedule and address object name.</value>
        [DataMember(Name = "log_object_name", EmitDefaultValue = true)]
        public bool LogObjectName { get; set; }

        /// <summary>
        /// Enable set connection limitation of management policies.
        /// </summary>
        /// <value>Enable set connection limitation of management policies.</value>
        [DataMember(Name = "policies_connection_limitation", EmitDefaultValue = true)]
        public bool PoliciesConnectionLimitation { get; set; }

        /// <summary>
        /// Reset user succesful login counter (hours).
        /// </summary>
        /// <value>Reset user succesful login counter (hours).</value>
        [DataMember(Name = "reset_login_counter", EmitDefaultValue = false)]
        public decimal ResetLoginCounter { get; set; }

        /// <summary>
        /// Enable send RST on timeout TCP connection.
        /// </summary>
        /// <value>Enable send RST on timeout TCP connection.</value>
        [DataMember(Name = "send_rst_on_timeout", EmitDefaultValue = true)]
        public bool SendRstOnTimeout { get; set; }

        /// <summary>
        /// Set the async save flash period in seconds.
        /// </summary>
        /// <value>Set the async save flash period in seconds.</value>
        [DataMember(Name = "async_save_flash_period", EmitDefaultValue = false)]
        public decimal AsyncSaveFlashPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedFirewallDiagAdvancedFirewall {\n");
            sb.Append("  KillCacheNoDelay: ").Append(KillCacheNoDelay).Append("\n");
            sb.Append("  FtpBounceAttackProtection: ").Append(FtpBounceAttackProtection).Append("\n");
            sb.Append("  FtpProtocolAnomalyAttackProtection: ").Append(FtpProtocolAnomalyAttackProtection).Append("\n");
            sb.Append("  OrphanDataConnection: ").Append(OrphanDataConnection).Append("\n");
            sb.Append("  AllowZeroPort: ").Append(AllowZeroPort).Append("\n");
            sb.Append("  IpSpoofChecking: ").Append(IpSpoofChecking).Append("\n");
            sb.Append("  PortScanDetection: ").Append(PortScanDetection).Append("\n");
            sb.Append("  UcaplCompliance: ").Append(UcaplCompliance).Append("\n");
            sb.Append("  AnticipatedConnectionTimeout: ").Append(AnticipatedConnectionTimeout).Append("\n");
            sb.Append("  AnticipatedConnectionParentTermination: ").Append(AnticipatedConnectionParentTermination).Append("\n");
            sb.Append("  CacheIgnoreIcmpReject: ").Append(CacheIgnoreIcmpReject).Append("\n");
            sb.Append("  AnticipatedMediaTimeout: ").Append(AnticipatedMediaTimeout).Append("\n");
            sb.Append("  AnticipatedMediaParentTermination: ").Append(AnticipatedMediaParentTermination).Append("\n");
            sb.Append("  TraceConnectionsPort: ").Append(TraceConnectionsPort).Append("\n");
            sb.Append("  IncludeTcpDataConnection: ").Append(IncludeTcpDataConnection).Append("\n");
            sb.Append("  TrackBandwidthUsage: ").Append(TrackBandwidthUsage).Append("\n");
            sb.Append("  DecreaseConnectionCountAfterClose: ").Append(DecreaseConnectionCountAfterClose).Append("\n");
            sb.Append("  CsrfTokenValidation: ").Append(CsrfTokenValidation).Append("\n");
            sb.Append("  SecureSessionIdCookie: ").Append(SecureSessionIdCookie).Append("\n");
            sb.Append("  TcpStateManipulationDosProtection: ").Append(TcpStateManipulationDosProtection).Append("\n");
            sb.Append("  SequentialAddresses: ").Append(SequentialAddresses).Append("\n");
            sb.Append("  DefaultPolicyEditable: ").Append(DefaultPolicyEditable).Append("\n");
            sb.Append("  AutoAddedNatPolicyDisabling: ").Append(AutoAddedNatPolicyDisabling).Append("\n");
            sb.Append("  UdpIcmpFloodDetecting: ").Append(UdpIcmpFloodDetecting).Append("\n");
            sb.Append("  ControlPanelFloodProtection: ").Append(ControlPanelFloodProtection).Append("\n");
            sb.Append("  UdpIcmpFloodProtection: ").Append(UdpIcmpFloodProtection).Append("\n");
            sb.Append("  SystemOverloadProtection: ").Append(SystemOverloadProtection).Append("\n");
            sb.Append("  SystemOverloadThreshold: ").Append(SystemOverloadThreshold).Append("\n");
            sb.Append("  BypassVpnTraffic: ").Append(BypassVpnTraffic).Append("\n");
            sb.Append("  LogObjectName: ").Append(LogObjectName).Append("\n");
            sb.Append("  PoliciesConnectionLimitation: ").Append(PoliciesConnectionLimitation).Append("\n");
            sb.Append("  ResetLoginCounter: ").Append(ResetLoginCounter).Append("\n");
            sb.Append("  SendRstOnTimeout: ").Append(SendRstOnTimeout).Append("\n");
            sb.Append("  AsyncSaveFlashPeriod: ").Append(AsyncSaveFlashPeriod).Append("\n");
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
            return this.Equals(input as DiagAdvancedFirewallDiagAdvancedFirewall);
        }

        /// <summary>
        /// Returns true if DiagAdvancedFirewallDiagAdvancedFirewall instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedFirewallDiagAdvancedFirewall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedFirewallDiagAdvancedFirewall input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KillCacheNoDelay == input.KillCacheNoDelay ||
                    this.KillCacheNoDelay.Equals(input.KillCacheNoDelay)
                ) && 
                (
                    this.FtpBounceAttackProtection == input.FtpBounceAttackProtection ||
                    this.FtpBounceAttackProtection.Equals(input.FtpBounceAttackProtection)
                ) && 
                (
                    this.FtpProtocolAnomalyAttackProtection == input.FtpProtocolAnomalyAttackProtection ||
                    this.FtpProtocolAnomalyAttackProtection.Equals(input.FtpProtocolAnomalyAttackProtection)
                ) && 
                (
                    this.OrphanDataConnection == input.OrphanDataConnection ||
                    this.OrphanDataConnection.Equals(input.OrphanDataConnection)
                ) && 
                (
                    this.AllowZeroPort == input.AllowZeroPort ||
                    this.AllowZeroPort.Equals(input.AllowZeroPort)
                ) && 
                (
                    this.IpSpoofChecking == input.IpSpoofChecking ||
                    this.IpSpoofChecking.Equals(input.IpSpoofChecking)
                ) && 
                (
                    this.PortScanDetection == input.PortScanDetection ||
                    this.PortScanDetection.Equals(input.PortScanDetection)
                ) && 
                (
                    this.UcaplCompliance == input.UcaplCompliance ||
                    this.UcaplCompliance.Equals(input.UcaplCompliance)
                ) && 
                (
                    this.AnticipatedConnectionTimeout == input.AnticipatedConnectionTimeout ||
                    this.AnticipatedConnectionTimeout.Equals(input.AnticipatedConnectionTimeout)
                ) && 
                (
                    this.AnticipatedConnectionParentTermination == input.AnticipatedConnectionParentTermination ||
                    this.AnticipatedConnectionParentTermination.Equals(input.AnticipatedConnectionParentTermination)
                ) && 
                (
                    this.CacheIgnoreIcmpReject == input.CacheIgnoreIcmpReject ||
                    this.CacheIgnoreIcmpReject.Equals(input.CacheIgnoreIcmpReject)
                ) && 
                (
                    this.AnticipatedMediaTimeout == input.AnticipatedMediaTimeout ||
                    this.AnticipatedMediaTimeout.Equals(input.AnticipatedMediaTimeout)
                ) && 
                (
                    this.AnticipatedMediaParentTermination == input.AnticipatedMediaParentTermination ||
                    this.AnticipatedMediaParentTermination.Equals(input.AnticipatedMediaParentTermination)
                ) && 
                (
                    this.TraceConnectionsPort == input.TraceConnectionsPort ||
                    this.TraceConnectionsPort.Equals(input.TraceConnectionsPort)
                ) && 
                (
                    this.IncludeTcpDataConnection == input.IncludeTcpDataConnection ||
                    this.IncludeTcpDataConnection.Equals(input.IncludeTcpDataConnection)
                ) && 
                (
                    this.TrackBandwidthUsage == input.TrackBandwidthUsage ||
                    this.TrackBandwidthUsage.Equals(input.TrackBandwidthUsage)
                ) && 
                (
                    this.DecreaseConnectionCountAfterClose == input.DecreaseConnectionCountAfterClose ||
                    this.DecreaseConnectionCountAfterClose.Equals(input.DecreaseConnectionCountAfterClose)
                ) && 
                (
                    this.CsrfTokenValidation == input.CsrfTokenValidation ||
                    this.CsrfTokenValidation.Equals(input.CsrfTokenValidation)
                ) && 
                (
                    this.SecureSessionIdCookie == input.SecureSessionIdCookie ||
                    this.SecureSessionIdCookie.Equals(input.SecureSessionIdCookie)
                ) && 
                (
                    this.TcpStateManipulationDosProtection == input.TcpStateManipulationDosProtection ||
                    this.TcpStateManipulationDosProtection.Equals(input.TcpStateManipulationDosProtection)
                ) && 
                (
                    this.SequentialAddresses == input.SequentialAddresses ||
                    this.SequentialAddresses.Equals(input.SequentialAddresses)
                ) && 
                (
                    this.DefaultPolicyEditable == input.DefaultPolicyEditable ||
                    this.DefaultPolicyEditable.Equals(input.DefaultPolicyEditable)
                ) && 
                (
                    this.AutoAddedNatPolicyDisabling == input.AutoAddedNatPolicyDisabling ||
                    this.AutoAddedNatPolicyDisabling.Equals(input.AutoAddedNatPolicyDisabling)
                ) && 
                (
                    this.UdpIcmpFloodDetecting == input.UdpIcmpFloodDetecting ||
                    this.UdpIcmpFloodDetecting.Equals(input.UdpIcmpFloodDetecting)
                ) && 
                (
                    this.ControlPanelFloodProtection == input.ControlPanelFloodProtection ||
                    this.ControlPanelFloodProtection.Equals(input.ControlPanelFloodProtection)
                ) && 
                (
                    this.UdpIcmpFloodProtection == input.UdpIcmpFloodProtection ||
                    this.UdpIcmpFloodProtection.Equals(input.UdpIcmpFloodProtection)
                ) && 
                (
                    this.SystemOverloadProtection == input.SystemOverloadProtection ||
                    this.SystemOverloadProtection.Equals(input.SystemOverloadProtection)
                ) && 
                (
                    this.SystemOverloadThreshold == input.SystemOverloadThreshold ||
                    this.SystemOverloadThreshold.Equals(input.SystemOverloadThreshold)
                ) && 
                (
                    this.BypassVpnTraffic == input.BypassVpnTraffic ||
                    this.BypassVpnTraffic.Equals(input.BypassVpnTraffic)
                ) && 
                (
                    this.LogObjectName == input.LogObjectName ||
                    this.LogObjectName.Equals(input.LogObjectName)
                ) && 
                (
                    this.PoliciesConnectionLimitation == input.PoliciesConnectionLimitation ||
                    this.PoliciesConnectionLimitation.Equals(input.PoliciesConnectionLimitation)
                ) && 
                (
                    this.ResetLoginCounter == input.ResetLoginCounter ||
                    this.ResetLoginCounter.Equals(input.ResetLoginCounter)
                ) && 
                (
                    this.SendRstOnTimeout == input.SendRstOnTimeout ||
                    this.SendRstOnTimeout.Equals(input.SendRstOnTimeout)
                ) && 
                (
                    this.AsyncSaveFlashPeriod == input.AsyncSaveFlashPeriod ||
                    this.AsyncSaveFlashPeriod.Equals(input.AsyncSaveFlashPeriod)
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
                hashCode = (hashCode * 59) + this.KillCacheNoDelay.GetHashCode();
                hashCode = (hashCode * 59) + this.FtpBounceAttackProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.FtpProtocolAnomalyAttackProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.OrphanDataConnection.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowZeroPort.GetHashCode();
                hashCode = (hashCode * 59) + this.IpSpoofChecking.GetHashCode();
                hashCode = (hashCode * 59) + this.PortScanDetection.GetHashCode();
                hashCode = (hashCode * 59) + this.UcaplCompliance.GetHashCode();
                hashCode = (hashCode * 59) + this.AnticipatedConnectionTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.AnticipatedConnectionParentTermination.GetHashCode();
                hashCode = (hashCode * 59) + this.CacheIgnoreIcmpReject.GetHashCode();
                hashCode = (hashCode * 59) + this.AnticipatedMediaTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.AnticipatedMediaParentTermination.GetHashCode();
                hashCode = (hashCode * 59) + this.TraceConnectionsPort.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeTcpDataConnection.GetHashCode();
                hashCode = (hashCode * 59) + this.TrackBandwidthUsage.GetHashCode();
                hashCode = (hashCode * 59) + this.DecreaseConnectionCountAfterClose.GetHashCode();
                hashCode = (hashCode * 59) + this.CsrfTokenValidation.GetHashCode();
                hashCode = (hashCode * 59) + this.SecureSessionIdCookie.GetHashCode();
                hashCode = (hashCode * 59) + this.TcpStateManipulationDosProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.SequentialAddresses.GetHashCode();
                hashCode = (hashCode * 59) + this.DefaultPolicyEditable.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoAddedNatPolicyDisabling.GetHashCode();
                hashCode = (hashCode * 59) + this.UdpIcmpFloodDetecting.GetHashCode();
                hashCode = (hashCode * 59) + this.ControlPanelFloodProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.UdpIcmpFloodProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.SystemOverloadProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.SystemOverloadThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.BypassVpnTraffic.GetHashCode();
                hashCode = (hashCode * 59) + this.LogObjectName.GetHashCode();
                hashCode = (hashCode * 59) + this.PoliciesConnectionLimitation.GetHashCode();
                hashCode = (hashCode * 59) + this.ResetLoginCounter.GetHashCode();
                hashCode = (hashCode * 59) + this.SendRstOnTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.AsyncSaveFlashPeriod.GetHashCode();
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
