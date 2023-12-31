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
    /// PPPoE IPv6 configuration assignment.
    /// </summary>
    [DataContract(Name = "interface_ipv6_base_ipv6_ip_assignment_mode_pppoe6_pppoe6")]
    public partial class InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6 : IEquatable<InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6>, IValidatableObject
    {
        /// <summary>
        /// Set PPPoE6 mode.
        /// </summary>
        /// <value>Set PPPoE6 mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeAssignmentEnum
        {
            /// <summary>
            /// Enum Dhcpv6 for value: dhcpv6
            /// </summary>
            [EnumMember(Value = "dhcpv6")]
            Dhcpv6 = 1,

            /// <summary>
            /// Enum Auto for value: auto
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto = 2,

            /// <summary>
            /// Enum Static for value: static
            /// </summary>
            [EnumMember(Value = "static")]
            Static = 3
        }


        /// <summary>
        /// Set PPPoE6 mode.
        /// </summary>
        /// <value>Set PPPoE6 mode.</value>
        [DataMember(Name = "mode_assignment", EmitDefaultValue = false)]
        public ModeAssignmentEnum? ModeAssignment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6" /> class.
        /// </summary>
        /// <param name="modeAssignment">Set PPPoE6 mode..</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="inactivity">inactivity.</param>
        /// <param name="lcpEchoPackets">Enable strictly use LCP echo packets for server keep-alive..</param>
        /// <param name="reconnect">reconnect.</param>
        /// <param name="ncpNegRetrans">Set the retransmission time during NCP negotiation.</param>
        /// <param name="ip">Set interface IPv6 address..</param>
        /// <param name="prefixLength">Set interface IPv6 prefix length..</param>
        /// <param name="SonicDns">SonicDns.</param>
        /// <param name="gateway">Set interface gateway..</param>
        /// <param name="advertiseSubnetPrefix">subnet prefix of IPv6 primary static address..</param>
        /// <param name="routerAdvertisement">routerAdvertisement.</param>
        /// <param name="prefixDelegation">Enable DHCPv6 prefix delegation..</param>
        /// <param name="rapidCommit">Enable use rapid commit option..</param>
        public InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6(ModeAssignmentEnum? modeAssignment = default(ModeAssignmentEnum?), InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Schedule schedule = default(InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Schedule), InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Inactivity inactivity = default(InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Inactivity), bool lcpEchoPackets = default(bool), InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Reconnect reconnect = default(InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Reconnect), decimal ncpNegRetrans = default(decimal), string ip = default(string), decimal prefixLength = default(decimal), InterfaceIpv4IpAssignmentModeStaticStaticSonicDns SonicDns = default(InterfaceIpv4IpAssignmentModeStaticStaticSonicDns), string gateway = default(string), bool advertiseSubnetPrefix = default(bool), InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement routerAdvertisement = default(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement), bool prefixDelegation = default(bool), bool rapidCommit = default(bool))
        {
            this.ModeAssignment = modeAssignment;
            this.Schedule = schedule;
            this.Inactivity = inactivity;
            this.LcpEchoPackets = lcpEchoPackets;
            this.Reconnect = reconnect;
            this.NcpNegRetrans = ncpNegRetrans;
            this.Ip = ip;
            this.PrefixLength = prefixLength;
            this.SonicDns = SonicDns;
            this.Gateway = gateway;
            this.AdvertiseSubnetPrefix = advertiseSubnetPrefix;
            this.RouterAdvertisement = routerAdvertisement;
            this.PrefixDelegation = prefixDelegation;
            this.RapidCommit = rapidCommit;
        }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Inactivity
        /// </summary>
        [DataMember(Name = "inactivity", EmitDefaultValue = true)]
        public InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Inactivity Inactivity { get; set; }

        /// <summary>
        /// Enable strictly use LCP echo packets for server keep-alive.
        /// </summary>
        /// <value>Enable strictly use LCP echo packets for server keep-alive.</value>
        [DataMember(Name = "lcp_echo_packets", EmitDefaultValue = true)]
        public bool LcpEchoPackets { get; set; }

        /// <summary>
        /// Gets or Sets Reconnect
        /// </summary>
        [DataMember(Name = "reconnect", EmitDefaultValue = true)]
        public InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6Reconnect Reconnect { get; set; }

        /// <summary>
        /// Set the retransmission time during NCP negotiation
        /// </summary>
        /// <value>Set the retransmission time during NCP negotiation</value>
        [DataMember(Name = "ncp_neg_retrans", EmitDefaultValue = false)]
        public decimal NcpNegRetrans { get; set; }

        /// <summary>
        /// Set interface IPv6 address.
        /// </summary>
        /// <value>Set interface IPv6 address.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Set interface IPv6 prefix length.
        /// </summary>
        /// <value>Set interface IPv6 prefix length.</value>
        [DataMember(Name = "prefix_length", EmitDefaultValue = false)]
        public decimal PrefixLength { get; set; }

        /// <summary>
        /// Gets or Sets SonicDns
        /// </summary>
        [DataMember(Name = "SonicDns", EmitDefaultValue = false)]
        public InterfaceIpv4IpAssignmentModeStaticStaticSonicDns SonicDns { get; set; }

        /// <summary>
        /// Set interface gateway.
        /// </summary>
        /// <value>Set interface gateway.</value>
        [DataMember(Name = "gateway", EmitDefaultValue = false)]
        public string Gateway { get; set; }

        /// <summary>
        /// subnet prefix of IPv6 primary static address.
        /// </summary>
        /// <value>subnet prefix of IPv6 primary static address.</value>
        [DataMember(Name = "advertise_subnet_prefix", EmitDefaultValue = true)]
        public bool AdvertiseSubnetPrefix { get; set; }

        /// <summary>
        /// Gets or Sets RouterAdvertisement
        /// </summary>
        [DataMember(Name = "router_advertisement", EmitDefaultValue = false)]
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement RouterAdvertisement { get; set; }

        /// <summary>
        /// Enable DHCPv6 prefix delegation.
        /// </summary>
        /// <value>Enable DHCPv6 prefix delegation.</value>
        [DataMember(Name = "prefix_delegation", EmitDefaultValue = true)]
        public bool PrefixDelegation { get; set; }

        /// <summary>
        /// Enable use rapid commit option.
        /// </summary>
        /// <value>Enable use rapid commit option.</value>
        [DataMember(Name = "rapid_commit", EmitDefaultValue = true)]
        public bool RapidCommit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6 {\n");
            sb.Append("  ModeAssignment: ").Append(ModeAssignment).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Inactivity: ").Append(Inactivity).Append("\n");
            sb.Append("  LcpEchoPackets: ").Append(LcpEchoPackets).Append("\n");
            sb.Append("  Reconnect: ").Append(Reconnect).Append("\n");
            sb.Append("  NcpNegRetrans: ").Append(NcpNegRetrans).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  PrefixLength: ").Append(PrefixLength).Append("\n");
            sb.Append("  SonicDns: ").Append(SonicDns).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  AdvertiseSubnetPrefix: ").Append(AdvertiseSubnetPrefix).Append("\n");
            sb.Append("  RouterAdvertisement: ").Append(RouterAdvertisement).Append("\n");
            sb.Append("  PrefixDelegation: ").Append(PrefixDelegation).Append("\n");
            sb.Append("  RapidCommit: ").Append(RapidCommit).Append("\n");
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
            return this.Equals(input as InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6);
        }

        /// <summary>
        /// Returns true if InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6 instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv6BaseIpv6IpAssignmentModePppoe6Pppoe6 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModeAssignment == input.ModeAssignment ||
                    this.ModeAssignment.Equals(input.ModeAssignment)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Inactivity == input.Inactivity ||
                    (this.Inactivity != null &&
                    this.Inactivity.Equals(input.Inactivity))
                ) && 
                (
                    this.LcpEchoPackets == input.LcpEchoPackets ||
                    this.LcpEchoPackets.Equals(input.LcpEchoPackets)
                ) && 
                (
                    this.Reconnect == input.Reconnect ||
                    (this.Reconnect != null &&
                    this.Reconnect.Equals(input.Reconnect))
                ) && 
                (
                    this.NcpNegRetrans == input.NcpNegRetrans ||
                    this.NcpNegRetrans.Equals(input.NcpNegRetrans)
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.PrefixLength == input.PrefixLength ||
                    this.PrefixLength.Equals(input.PrefixLength)
                ) && 
                (
                    this.SonicDns == input.SonicDns ||
                    (this.SonicDns != null &&
                    this.SonicDns.Equals(input.SonicDns))
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.AdvertiseSubnetPrefix == input.AdvertiseSubnetPrefix ||
                    this.AdvertiseSubnetPrefix.Equals(input.AdvertiseSubnetPrefix)
                ) && 
                (
                    this.RouterAdvertisement == input.RouterAdvertisement ||
                    (this.RouterAdvertisement != null &&
                    this.RouterAdvertisement.Equals(input.RouterAdvertisement))
                ) && 
                (
                    this.PrefixDelegation == input.PrefixDelegation ||
                    this.PrefixDelegation.Equals(input.PrefixDelegation)
                ) && 
                (
                    this.RapidCommit == input.RapidCommit ||
                    this.RapidCommit.Equals(input.RapidCommit)
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
                hashCode = (hashCode * 59) + this.ModeAssignment.GetHashCode();
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.Inactivity != null)
                {
                    hashCode = (hashCode * 59) + this.Inactivity.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LcpEchoPackets.GetHashCode();
                if (this.Reconnect != null)
                {
                    hashCode = (hashCode * 59) + this.Reconnect.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NcpNegRetrans.GetHashCode();
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PrefixLength.GetHashCode();
                if (this.SonicDns != null)
                {
                    hashCode = (hashCode * 59) + this.SonicDns.GetHashCode();
                }
                if (this.Gateway != null)
                {
                    hashCode = (hashCode * 59) + this.Gateway.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AdvertiseSubnetPrefix.GetHashCode();
                if (this.RouterAdvertisement != null)
                {
                    hashCode = (hashCode * 59) + this.RouterAdvertisement.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PrefixDelegation.GetHashCode();
                hashCode = (hashCode * 59) + this.RapidCommit.GetHashCode();
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
