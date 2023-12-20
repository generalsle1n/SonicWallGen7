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
    /// Set Connection Monitor Filter.
    /// </summary>
    [DataContract(Name = "diag_acm_filter_diag_acm_filter")]
    public partial class DiagAcmFilterDiagAcmFilter : IEquatable<DiagAcmFilterDiagAcmFilter>, IValidatableObject
    {
        /// <summary>
        /// Ip type.
        /// </summary>
        /// <value>Ip type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IpTypeEnum
        {
            /// <summary>
            /// Enum Ipv4 for value: ipv4
            /// </summary>
            [EnumMember(Value = "ipv4")]
            Ipv4 = 1,

            /// <summary>
            /// Enum Ipv6 for value: ipv6
            /// </summary>
            [EnumMember(Value = "ipv6")]
            Ipv6 = 2
        }


        /// <summary>
        /// Ip type.
        /// </summary>
        /// <value>Ip type.</value>
        [DataMember(Name = "ip_type", EmitDefaultValue = false)]
        public IpTypeEnum? IpType { get; set; }
        /// <summary>
        /// Flow Type.
        /// </summary>
        /// <value>Flow Type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlowTypeEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum Generic for value: generic
            /// </summary>
            [EnumMember(Value = "generic")]
            Generic = 2,

            /// <summary>
            /// Enum DhcpBootp for value: dhcp-bootp
            /// </summary>
            [EnumMember(Value = "dhcp-bootp")]
            DhcpBootp = 3,

            /// <summary>
            /// Enum Dns for value: dns
            /// </summary>
            [EnumMember(Value = "dns")]
            Dns = 4,

            /// <summary>
            /// Enum EMail for value: e-mail
            /// </summary>
            [EnumMember(Value = "e-mail")]
            EMail = 5,

            /// <summary>
            /// Enum FtpControl for value: ftp-control
            /// </summary>
            [EnumMember(Value = "ftp-control")]
            FtpControl = 6,

            /// <summary>
            /// Enum FtpData for value: ftp-data
            /// </summary>
            [EnumMember(Value = "ftp-data")]
            FtpData = 7,

            /// <summary>
            /// Enum Gopher for value: gopher
            /// </summary>
            [EnumMember(Value = "gopher")]
            Gopher = 8,

            /// <summary>
            /// Enum HControl for value: h-control
            /// </summary>
            [EnumMember(Value = "h-control")]
            HControl = 9,

            /// <summary>
            /// Enum HMedia for value: h-media
            /// </summary>
            [EnumMember(Value = "h-media")]
            HMedia = 10,

            /// <summary>
            /// Enum Http for value: http
            /// </summary>
            [EnumMember(Value = "http")]
            Http = 11,

            /// <summary>
            /// Enum HttpManagement for value: http-management
            /// </summary>
            [EnumMember(Value = "http-management")]
            HttpManagement = 12,

            /// <summary>
            /// Enum Https for value: https
            /// </summary>
            [EnumMember(Value = "https")]
            Https = 13,

            /// <summary>
            /// Enum HttpsManagement for value: https-management
            /// </summary>
            [EnumMember(Value = "https-management")]
            HttpsManagement = 14,

            /// <summary>
            /// Enum Ike for value: ike
            /// </summary>
            [EnumMember(Value = "ike")]
            Ike = 15,

            /// <summary>
            /// Enum Imap for value: imap
            /// </summary>
            [EnumMember(Value = "imap")]
            Imap = 16,

            /// <summary>
            /// Enum Imap3 for value: imap3
            /// </summary>
            [EnumMember(Value = "imap3")]
            Imap3 = 17,

            /// <summary>
            /// Enum Ldap for value: ldap
            /// </summary>
            [EnumMember(Value = "ldap")]
            Ldap = 18,

            /// <summary>
            /// Enum Msn for value: msn
            /// </summary>
            [EnumMember(Value = "msn")]
            Msn = 19,

            /// <summary>
            /// Enum MsnMedia for value: msn-media
            /// </summary>
            [EnumMember(Value = "msn-media")]
            MsnMedia = 20,

            /// <summary>
            /// Enum Netbios for value: netbios
            /// </summary>
            [EnumMember(Value = "netbios")]
            Netbios = 21,

            /// <summary>
            /// Enum Nntp for value: nntp
            /// </summary>
            [EnumMember(Value = "nntp")]
            Nntp = 22,

            /// <summary>
            /// Enum Ntp for value: ntp
            /// </summary>
            [EnumMember(Value = "ntp")]
            Ntp = 23,

            /// <summary>
            /// Enum Pop3 for value: pop3
            /// </summary>
            [EnumMember(Value = "pop3")]
            Pop3 = 24,

            /// <summary>
            /// Enum SqlnetControl for value: sqlnet-control
            /// </summary>
            [EnumMember(Value = "sqlnet-control")]
            SqlnetControl = 25,

            /// <summary>
            /// Enum SqlnetData for value: sqlnet-data
            /// </summary>
            [EnumMember(Value = "sqlnet-data")]
            SqlnetData = 26,

            /// <summary>
            /// Enum PptpControl for value: pptp-control
            /// </summary>
            [EnumMember(Value = "pptp-control")]
            PptpControl = 27,

            /// <summary>
            /// Enum PptpData for value: pptp-data
            /// </summary>
            [EnumMember(Value = "pptp-data")]
            PptpData = 28,

            /// <summary>
            /// Enum Radius for value: radius
            /// </summary>
            [EnumMember(Value = "radius")]
            Radius = 29,

            /// <summary>
            /// Enum RealAudioControl for value: real-audio-control
            /// </summary>
            [EnumMember(Value = "real-audio-control")]
            RealAudioControl = 30,

            /// <summary>
            /// Enum RealAudioMedia for value: real-audio-media
            /// </summary>
            [EnumMember(Value = "real-audio-media")]
            RealAudioMedia = 31,

            /// <summary>
            /// Enum Rip for value: rip
            /// </summary>
            [EnumMember(Value = "rip")]
            Rip = 32,

            /// <summary>
            /// Enum RtspControl for value: rtsp-control
            /// </summary>
            [EnumMember(Value = "rtsp-control")]
            RtspControl = 33,

            /// <summary>
            /// Enum RtspMedia for value: rtsp-media
            /// </summary>
            [EnumMember(Value = "rtsp-media")]
            RtspMedia = 34,

            /// <summary>
            /// Enum SecureImaps for value: secure-imaps
            /// </summary>
            [EnumMember(Value = "secure-imaps")]
            SecureImaps = 35,

            /// <summary>
            /// Enum SecurePop3 for value: secure-pop3
            /// </summary>
            [EnumMember(Value = "secure-pop3")]
            SecurePop3 = 36,

            /// <summary>
            /// Enum SipControl for value: sip-control
            /// </summary>
            [EnumMember(Value = "sip-control")]
            SipControl = 37,

            /// <summary>
            /// Enum SipMedia for value: sip-media
            /// </summary>
            [EnumMember(Value = "sip-media")]
            SipMedia = 38,

            /// <summary>
            /// Enum Smtp for value: smtp
            /// </summary>
            [EnumMember(Value = "smtp")]
            Smtp = 39,

            /// <summary>
            /// Enum Smtps for value: smtps
            /// </summary>
            [EnumMember(Value = "smtps")]
            Smtps = 40,

            /// <summary>
            /// Enum SnmpRequestResponse for value: snmp-request-response
            /// </summary>
            [EnumMember(Value = "snmp-request-response")]
            SnmpRequestResponse = 41,

            /// <summary>
            /// Enum SnmpTrap for value: snmp-trap
            /// </summary>
            [EnumMember(Value = "snmp-trap")]
            SnmpTrap = 42,

            /// <summary>
            /// Enum Ssh for value: ssh
            /// </summary>
            [EnumMember(Value = "ssh")]
            Ssh = 43,

            /// <summary>
            /// Enum SshManagement for value: ssh-management
            /// </summary>
            [EnumMember(Value = "ssh-management")]
            SshManagement = 44,

            /// <summary>
            /// Enum SslTls for value: ssl-tls
            /// </summary>
            [EnumMember(Value = "ssl-tls")]
            SslTls = 45,

            /// <summary>
            /// Enum Syslog for value: syslog
            /// </summary>
            [EnumMember(Value = "syslog")]
            Syslog = 46,

            /// <summary>
            /// Enum Telnet for value: telnet
            /// </summary>
            [EnumMember(Value = "telnet")]
            Telnet = 47,

            /// <summary>
            /// Enum Tftp for value: tftp
            /// </summary>
            [EnumMember(Value = "tftp")]
            Tftp = 48,

            /// <summary>
            /// Enum TftpData for value: tftp-data
            /// </summary>
            [EnumMember(Value = "tftp-data")]
            TftpData = 49,

            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 50
        }


        /// <summary>
        /// Flow Type.
        /// </summary>
        /// <value>Flow Type.</value>
        [DataMember(Name = "flow_type", EmitDefaultValue = false)]
        public FlowTypeEnum? FlowType { get; set; }
        /// <summary>
        /// Protocol.
        /// </summary>
        /// <value>Protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum Icmp for value: icmp
            /// </summary>
            [EnumMember(Value = "icmp")]
            Icmp = 2,

            /// <summary>
            /// Enum Igmp for value: igmp
            /// </summary>
            [EnumMember(Value = "igmp")]
            Igmp = 3,

            /// <summary>
            /// Enum Tcp for value: tcp
            /// </summary>
            [EnumMember(Value = "tcp")]
            Tcp = 4,

            /// <summary>
            /// Enum Udp for value: udp
            /// </summary>
            [EnumMember(Value = "udp")]
            Udp = 5,

            /// <summary>
            /// Enum Gre for value: gre
            /// </summary>
            [EnumMember(Value = "gre")]
            Gre = 6,

            /// <summary>
            /// Enum Esp for value: esp
            /// </summary>
            [EnumMember(Value = "esp")]
            Esp = 7,

            /// <summary>
            /// Enum Ah for value: ah
            /// </summary>
            [EnumMember(Value = "ah")]
            Ah = 8,

            /// <summary>
            /// Enum Icmpv6 for value: icmpv6
            /// </summary>
            [EnumMember(Value = "icmpv6")]
            Icmpv6 = 9,

            /// <summary>
            /// Enum Eigrp for value: eigrp
            /// </summary>
            [EnumMember(Value = "eigrp")]
            Eigrp = 10,

            /// <summary>
            /// Enum Ospf for value: ospf
            /// </summary>
            [EnumMember(Value = "ospf")]
            Ospf = 11,

            /// <summary>
            /// Enum Pimsm for value: pimsm
            /// </summary>
            [EnumMember(Value = "pimsm")]
            Pimsm = 12,

            /// <summary>
            /// Enum L2tp for value: l2tp
            /// </summary>
            [EnumMember(Value = "l2tp")]
            L2tp = 13
        }


        /// <summary>
        /// Protocol.
        /// </summary>
        /// <value>Protocol.</value>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public ProtocolEnum? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAcmFilterDiagAcmFilter" /> class.
        /// </summary>
        /// <param name="ipType">Ip type..</param>
        /// <param name="sourceIp">sourceIp.</param>
        /// <param name="destinationIp">destinationIp.</param>
        /// <param name="port">port.</param>
        /// <param name="sourceInterface">sourceInterface.</param>
        /// <param name="destinationInterface">destinationInterface.</param>
        /// <param name="policyId">policyId.</param>
        /// <param name="status">status.</param>
        /// <param name="groupValue">groupValue.</param>
        /// <param name="flowType">Flow Type..</param>
        /// <param name="protocol">Protocol..</param>
        public DiagAcmFilterDiagAcmFilter(IpTypeEnum? ipType = default(IpTypeEnum?), DiagAcmFilterDiagAcmFilterSourceIp sourceIp = default(DiagAcmFilterDiagAcmFilterSourceIp), DiagAcmFilterDiagAcmFilterDestinationIp destinationIp = default(DiagAcmFilterDiagAcmFilterDestinationIp), DiagAcmFilterDiagAcmFilterPort port = default(DiagAcmFilterDiagAcmFilterPort), DiagAcmFilterDiagAcmFilterSourceInterface sourceInterface = default(DiagAcmFilterDiagAcmFilterSourceInterface), DiagAcmFilterDiagAcmFilterDestinationInterface destinationInterface = default(DiagAcmFilterDiagAcmFilterDestinationInterface), DiagAcmFilterDiagAcmFilterPolicyId policyId = default(DiagAcmFilterDiagAcmFilterPolicyId), DiagAcmFilterDiagAcmFilterStatus status = default(DiagAcmFilterDiagAcmFilterStatus), DiagAcmFilterDiagAcmFilterGroupValue groupValue = default(DiagAcmFilterDiagAcmFilterGroupValue), FlowTypeEnum? flowType = default(FlowTypeEnum?), ProtocolEnum? protocol = default(ProtocolEnum?))
        {
            this.IpType = ipType;
            this.SourceIp = sourceIp;
            this.DestinationIp = destinationIp;
            this.Port = port;
            this.SourceInterface = sourceInterface;
            this.DestinationInterface = destinationInterface;
            this.PolicyId = policyId;
            this.Status = status;
            this.GroupValue = groupValue;
            this.FlowType = flowType;
            this.Protocol = protocol;
        }

        /// <summary>
        /// Gets or Sets SourceIp
        /// </summary>
        [DataMember(Name = "source_ip", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterSourceIp SourceIp { get; set; }

        /// <summary>
        /// Gets or Sets DestinationIp
        /// </summary>
        [DataMember(Name = "destination_ip", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterDestinationIp DestinationIp { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterPort Port { get; set; }

        /// <summary>
        /// Gets or Sets SourceInterface
        /// </summary>
        [DataMember(Name = "source_interface", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterSourceInterface SourceInterface { get; set; }

        /// <summary>
        /// Gets or Sets DestinationInterface
        /// </summary>
        [DataMember(Name = "destination_interface", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterDestinationInterface DestinationInterface { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [DataMember(Name = "policy_id", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterPolicyId PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets GroupValue
        /// </summary>
        [DataMember(Name = "group_value", EmitDefaultValue = true)]
        public DiagAcmFilterDiagAcmFilterGroupValue GroupValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAcmFilterDiagAcmFilter {\n");
            sb.Append("  IpType: ").Append(IpType).Append("\n");
            sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  DestinationIp: ").Append(DestinationIp).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SourceInterface: ").Append(SourceInterface).Append("\n");
            sb.Append("  DestinationInterface: ").Append(DestinationInterface).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  GroupValue: ").Append(GroupValue).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
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
            return this.Equals(input as DiagAcmFilterDiagAcmFilter);
        }

        /// <summary>
        /// Returns true if DiagAcmFilterDiagAcmFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAcmFilterDiagAcmFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAcmFilterDiagAcmFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IpType == input.IpType ||
                    this.IpType.Equals(input.IpType)
                ) && 
                (
                    this.SourceIp == input.SourceIp ||
                    (this.SourceIp != null &&
                    this.SourceIp.Equals(input.SourceIp))
                ) && 
                (
                    this.DestinationIp == input.DestinationIp ||
                    (this.DestinationIp != null &&
                    this.DestinationIp.Equals(input.DestinationIp))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.SourceInterface == input.SourceInterface ||
                    (this.SourceInterface != null &&
                    this.SourceInterface.Equals(input.SourceInterface))
                ) && 
                (
                    this.DestinationInterface == input.DestinationInterface ||
                    (this.DestinationInterface != null &&
                    this.DestinationInterface.Equals(input.DestinationInterface))
                ) && 
                (
                    this.PolicyId == input.PolicyId ||
                    (this.PolicyId != null &&
                    this.PolicyId.Equals(input.PolicyId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.GroupValue == input.GroupValue ||
                    (this.GroupValue != null &&
                    this.GroupValue.Equals(input.GroupValue))
                ) && 
                (
                    this.FlowType == input.FlowType ||
                    this.FlowType.Equals(input.FlowType)
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol.Equals(input.Protocol)
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
                hashCode = (hashCode * 59) + this.IpType.GetHashCode();
                if (this.SourceIp != null)
                {
                    hashCode = (hashCode * 59) + this.SourceIp.GetHashCode();
                }
                if (this.DestinationIp != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationIp.GetHashCode();
                }
                if (this.Port != null)
                {
                    hashCode = (hashCode * 59) + this.Port.GetHashCode();
                }
                if (this.SourceInterface != null)
                {
                    hashCode = (hashCode * 59) + this.SourceInterface.GetHashCode();
                }
                if (this.DestinationInterface != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationInterface.GetHashCode();
                }
                if (this.PolicyId != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.GroupValue != null)
                {
                    hashCode = (hashCode * 59) + this.GroupValue.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FlowType.GetHashCode();
                hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
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