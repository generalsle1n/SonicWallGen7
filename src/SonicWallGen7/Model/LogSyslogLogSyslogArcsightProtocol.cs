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
    /// Enable arcsight syslog protocol fields settings.
    /// </summary>
    [DataContract(Name = "log_syslog_log_syslog_arcsight_protocol")]
    public partial class LogSyslogLogSyslogArcsightProtocol : IEquatable<LogSyslogLogSyslogArcsightProtocol>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogSyslogLogSyslogArcsightProtocol" /> class.
        /// </summary>
        /// <param name="srcIp">Source IP..</param>
        /// <param name="srcNat">Source NAT IP..</param>
        /// <param name="srcPort">Source port..</param>
        /// <param name="srcNatPort">Source NAT port..</param>
        /// <param name="dstIp">Destination IP..</param>
        /// <param name="dstNat">Destination NAT IP..</param>
        /// <param name="dstPort">Destination port..</param>
        /// <param name="dstNatPort">Destination NAT port..</param>
        /// <param name="protocol">Protocol..</param>
        /// <param name="icmpType">ICMP type..</param>
        /// <param name="icmpCode">ICMP code..</param>
        public LogSyslogLogSyslogArcsightProtocol(bool srcIp = default(bool), bool srcNat = default(bool), bool srcPort = default(bool), bool srcNatPort = default(bool), bool dstIp = default(bool), bool dstNat = default(bool), bool dstPort = default(bool), bool dstNatPort = default(bool), bool protocol = default(bool), bool icmpType = default(bool), bool icmpCode = default(bool))
        {
            this.SrcIp = srcIp;
            this.SrcNat = srcNat;
            this.SrcPort = srcPort;
            this.SrcNatPort = srcNatPort;
            this.DstIp = dstIp;
            this.DstNat = dstNat;
            this.DstPort = dstPort;
            this.DstNatPort = dstNatPort;
            this.Protocol = protocol;
            this.IcmpType = icmpType;
            this.IcmpCode = icmpCode;
        }

        /// <summary>
        /// Source IP.
        /// </summary>
        /// <value>Source IP.</value>
        [DataMember(Name = "src_ip", EmitDefaultValue = true)]
        public bool SrcIp { get; set; }

        /// <summary>
        /// Source NAT IP.
        /// </summary>
        /// <value>Source NAT IP.</value>
        [DataMember(Name = "src_nat", EmitDefaultValue = true)]
        public bool SrcNat { get; set; }

        /// <summary>
        /// Source port.
        /// </summary>
        /// <value>Source port.</value>
        [DataMember(Name = "src_port", EmitDefaultValue = true)]
        public bool SrcPort { get; set; }

        /// <summary>
        /// Source NAT port.
        /// </summary>
        /// <value>Source NAT port.</value>
        [DataMember(Name = "src_nat_port", EmitDefaultValue = true)]
        public bool SrcNatPort { get; set; }

        /// <summary>
        /// Destination IP.
        /// </summary>
        /// <value>Destination IP.</value>
        [DataMember(Name = "dst_ip", EmitDefaultValue = true)]
        public bool DstIp { get; set; }

        /// <summary>
        /// Destination NAT IP.
        /// </summary>
        /// <value>Destination NAT IP.</value>
        [DataMember(Name = "dst_nat", EmitDefaultValue = true)]
        public bool DstNat { get; set; }

        /// <summary>
        /// Destination port.
        /// </summary>
        /// <value>Destination port.</value>
        [DataMember(Name = "dst_port", EmitDefaultValue = true)]
        public bool DstPort { get; set; }

        /// <summary>
        /// Destination NAT port.
        /// </summary>
        /// <value>Destination NAT port.</value>
        [DataMember(Name = "dst_nat_port", EmitDefaultValue = true)]
        public bool DstNatPort { get; set; }

        /// <summary>
        /// Protocol.
        /// </summary>
        /// <value>Protocol.</value>
        [DataMember(Name = "protocol", EmitDefaultValue = true)]
        public bool Protocol { get; set; }

        /// <summary>
        /// ICMP type.
        /// </summary>
        /// <value>ICMP type.</value>
        [DataMember(Name = "icmp_type", EmitDefaultValue = true)]
        public bool IcmpType { get; set; }

        /// <summary>
        /// ICMP code.
        /// </summary>
        /// <value>ICMP code.</value>
        [DataMember(Name = "icmp_code", EmitDefaultValue = true)]
        public bool IcmpCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogSyslogLogSyslogArcsightProtocol {\n");
            sb.Append("  SrcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  SrcNat: ").Append(SrcNat).Append("\n");
            sb.Append("  SrcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  SrcNatPort: ").Append(SrcNatPort).Append("\n");
            sb.Append("  DstIp: ").Append(DstIp).Append("\n");
            sb.Append("  DstNat: ").Append(DstNat).Append("\n");
            sb.Append("  DstPort: ").Append(DstPort).Append("\n");
            sb.Append("  DstNatPort: ").Append(DstNatPort).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  IcmpType: ").Append(IcmpType).Append("\n");
            sb.Append("  IcmpCode: ").Append(IcmpCode).Append("\n");
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
            return this.Equals(input as LogSyslogLogSyslogArcsightProtocol);
        }

        /// <summary>
        /// Returns true if LogSyslogLogSyslogArcsightProtocol instances are equal
        /// </summary>
        /// <param name="input">Instance of LogSyslogLogSyslogArcsightProtocol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogSyslogLogSyslogArcsightProtocol input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SrcIp == input.SrcIp ||
                    this.SrcIp.Equals(input.SrcIp)
                ) && 
                (
                    this.SrcNat == input.SrcNat ||
                    this.SrcNat.Equals(input.SrcNat)
                ) && 
                (
                    this.SrcPort == input.SrcPort ||
                    this.SrcPort.Equals(input.SrcPort)
                ) && 
                (
                    this.SrcNatPort == input.SrcNatPort ||
                    this.SrcNatPort.Equals(input.SrcNatPort)
                ) && 
                (
                    this.DstIp == input.DstIp ||
                    this.DstIp.Equals(input.DstIp)
                ) && 
                (
                    this.DstNat == input.DstNat ||
                    this.DstNat.Equals(input.DstNat)
                ) && 
                (
                    this.DstPort == input.DstPort ||
                    this.DstPort.Equals(input.DstPort)
                ) && 
                (
                    this.DstNatPort == input.DstNatPort ||
                    this.DstNatPort.Equals(input.DstNatPort)
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol.Equals(input.Protocol)
                ) && 
                (
                    this.IcmpType == input.IcmpType ||
                    this.IcmpType.Equals(input.IcmpType)
                ) && 
                (
                    this.IcmpCode == input.IcmpCode ||
                    this.IcmpCode.Equals(input.IcmpCode)
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
                hashCode = (hashCode * 59) + this.SrcIp.GetHashCode();
                hashCode = (hashCode * 59) + this.SrcNat.GetHashCode();
                hashCode = (hashCode * 59) + this.SrcPort.GetHashCode();
                hashCode = (hashCode * 59) + this.SrcNatPort.GetHashCode();
                hashCode = (hashCode * 59) + this.DstIp.GetHashCode();
                hashCode = (hashCode * 59) + this.DstNat.GetHashCode();
                hashCode = (hashCode * 59) + this.DstPort.GetHashCode();
                hashCode = (hashCode * 59) + this.DstNatPort.GetHashCode();
                hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
                hashCode = (hashCode * 59) + this.IcmpType.GetHashCode();
                hashCode = (hashCode * 59) + this.IcmpCode.GetHashCode();
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
