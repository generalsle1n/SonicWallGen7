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
    /// IP version IPv4.
    /// </summary>
    [DataContract(Name = "interface_ipv4_ipv4")]
    public partial class InterfaceIpv4Ipv4 : IEquatable<InterfaceIpv4Ipv4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv4Ipv4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InterfaceIpv4Ipv4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv4Ipv4" /> class.
        /// </summary>
        /// <param name="name">Interface name. (required).</param>
        /// <param name="vlan">Interface VLAN ID..</param>
        /// <param name="ipAssignment">ipAssignment.</param>
        /// <param name="comment">Set interface comment..</param>
        /// <param name="mtu">Set interface MTU..</param>
        /// <param name="mac">mac.</param>
        /// <param name="linkSpeed">linkSpeed.</param>
        /// <param name="management">management.</param>
        /// <param name="userLogin">userLogin.</param>
        /// <param name="httpsRedirect">Enable redirection from HTTP to HTTPS..</param>
        /// <param name="sendIcmpFragmentation">Enable ICMP fragmentation needed message generation..</param>
        /// <param name="fragmentPackets">Enable fragment non-VPN outbound packets larger than this interface&#39;s MTU..</param>
        /// <param name="ignoreDfBit">Enable ignore don&#39;t fragment (DF) bit..</param>
        /// <param name="flowReporting">Enable flow reporting on the interface..</param>
        /// <param name="multicast">Enable multicast support..</param>
        /// <param name="cos8021p">Enable 802.1p support..</param>
        /// <param name="excludeRoute">Enable exclude from route advertisement (NSM, OSPF, BGP, RIP)..</param>
        /// <param name="asymmetricRoute">Enable asymmetric route..</param>
        /// <param name="managementTrafficOnly">Enable management traffic only..</param>
        /// <param name="dnsProxy">Enable DNS proxy on the interface..</param>
        /// <param name="shutdownPort">Enable shutdown port..</param>
        /// <param name="secondary">secondary.</param>
        /// <param name="default8021pCos">default8021pCos.</param>
        /// <param name="bandwidthManagement">bandwidthManagement.</param>
        /// <param name="routedMode">routedMode.</param>
        /// <param name="oneArmMode">Enable one-arm mode on the interface.</param>
        /// <param name="oneArmPeer">Set interface one-arm-peer..</param>
        public InterfaceIpv4Ipv4(string name = default(string), decimal vlan = default(decimal), InterfaceIpv4Ipv4IpAssignment ipAssignment = default(InterfaceIpv4Ipv4IpAssignment), string comment = default(string), decimal mtu = default(decimal), InterfaceIpv4Ipv4Mac mac = default(InterfaceIpv4Ipv4Mac), InterfaceIpv4Ipv4LinkSpeed linkSpeed = default(InterfaceIpv4Ipv4LinkSpeed), InterfaceIpv4Ipv4Management management = default(InterfaceIpv4Ipv4Management), InterfaceIpv4Ipv4UserLogin userLogin = default(InterfaceIpv4Ipv4UserLogin), bool httpsRedirect = default(bool), bool sendIcmpFragmentation = default(bool), bool fragmentPackets = default(bool), bool ignoreDfBit = default(bool), bool flowReporting = default(bool), bool multicast = default(bool), bool cos8021p = default(bool), bool excludeRoute = default(bool), bool asymmetricRoute = default(bool), bool managementTrafficOnly = default(bool), bool dnsProxy = default(bool), bool shutdownPort = default(bool), InterfaceIpv4Ipv4Secondary secondary = default(InterfaceIpv4Ipv4Secondary), InterfaceIpv4Ipv4Default8021pCos default8021pCos = default(InterfaceIpv4Ipv4Default8021pCos), InterfaceIpv4Ipv4BandwidthManagement bandwidthManagement = default(InterfaceIpv4Ipv4BandwidthManagement), InterfaceIpv4Ipv4RoutedMode routedMode = default(InterfaceIpv4Ipv4RoutedMode), bool oneArmMode = default(bool), string oneArmPeer = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for InterfaceIpv4Ipv4 and cannot be null");
            }
            this.Name = name;
            this.Vlan = vlan;
            this.IpAssignment = ipAssignment;
            this.Comment = comment;
            this.Mtu = mtu;
            this.Mac = mac;
            this.LinkSpeed = linkSpeed;
            this.Management = management;
            this.UserLogin = userLogin;
            this.HttpsRedirect = httpsRedirect;
            this.SendIcmpFragmentation = sendIcmpFragmentation;
            this.FragmentPackets = fragmentPackets;
            this.IgnoreDfBit = ignoreDfBit;
            this.FlowReporting = flowReporting;
            this.Multicast = multicast;
            this.Cos8021p = cos8021p;
            this.ExcludeRoute = excludeRoute;
            this.AsymmetricRoute = asymmetricRoute;
            this.ManagementTrafficOnly = managementTrafficOnly;
            this.DnsProxy = dnsProxy;
            this.ShutdownPort = shutdownPort;
            this.Secondary = secondary;
            this.Default8021pCos = default8021pCos;
            this.BandwidthManagement = bandwidthManagement;
            this.RoutedMode = routedMode;
            this.OneArmMode = oneArmMode;
            this.OneArmPeer = oneArmPeer;
        }

        /// <summary>
        /// Interface name.
        /// </summary>
        /// <value>Interface name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Interface VLAN ID.
        /// </summary>
        /// <value>Interface VLAN ID.</value>
        [DataMember(Name = "vlan", EmitDefaultValue = false)]
        public decimal Vlan { get; set; }

        /// <summary>
        /// Gets or Sets IpAssignment
        /// </summary>
        [DataMember(Name = "ip_assignment", EmitDefaultValue = true)]
        public InterfaceIpv4Ipv4IpAssignment IpAssignment { get; set; }

        /// <summary>
        /// Set interface comment.
        /// </summary>
        /// <value>Set interface comment.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Set interface MTU.
        /// </summary>
        /// <value>Set interface MTU.</value>
        [DataMember(Name = "mtu", EmitDefaultValue = false)]
        public decimal Mtu { get; set; }

        /// <summary>
        /// Gets or Sets Mac
        /// </summary>
        [DataMember(Name = "mac", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4Mac Mac { get; set; }

        /// <summary>
        /// Gets or Sets LinkSpeed
        /// </summary>
        [DataMember(Name = "link_speed", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4LinkSpeed LinkSpeed { get; set; }

        /// <summary>
        /// Gets or Sets Management
        /// </summary>
        [DataMember(Name = "management", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4Management Management { get; set; }

        /// <summary>
        /// Gets or Sets UserLogin
        /// </summary>
        [DataMember(Name = "user_login", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4UserLogin UserLogin { get; set; }

        /// <summary>
        /// Enable redirection from HTTP to HTTPS.
        /// </summary>
        /// <value>Enable redirection from HTTP to HTTPS.</value>
        [DataMember(Name = "https_redirect", EmitDefaultValue = true)]
        public bool HttpsRedirect { get; set; }

        /// <summary>
        /// Enable ICMP fragmentation needed message generation.
        /// </summary>
        /// <value>Enable ICMP fragmentation needed message generation.</value>
        [DataMember(Name = "send_icmp_fragmentation", EmitDefaultValue = true)]
        public bool SendIcmpFragmentation { get; set; }

        /// <summary>
        /// Enable fragment non-VPN outbound packets larger than this interface&#39;s MTU.
        /// </summary>
        /// <value>Enable fragment non-VPN outbound packets larger than this interface&#39;s MTU.</value>
        [DataMember(Name = "fragment_packets", EmitDefaultValue = true)]
        public bool FragmentPackets { get; set; }

        /// <summary>
        /// Enable ignore don&#39;t fragment (DF) bit.
        /// </summary>
        /// <value>Enable ignore don&#39;t fragment (DF) bit.</value>
        [DataMember(Name = "ignore_df_bit", EmitDefaultValue = true)]
        public bool IgnoreDfBit { get; set; }

        /// <summary>
        /// Enable flow reporting on the interface.
        /// </summary>
        /// <value>Enable flow reporting on the interface.</value>
        [DataMember(Name = "flow_reporting", EmitDefaultValue = true)]
        public bool FlowReporting { get; set; }

        /// <summary>
        /// Enable multicast support.
        /// </summary>
        /// <value>Enable multicast support.</value>
        [DataMember(Name = "multicast", EmitDefaultValue = true)]
        public bool Multicast { get; set; }

        /// <summary>
        /// Enable 802.1p support.
        /// </summary>
        /// <value>Enable 802.1p support.</value>
        [DataMember(Name = "cos_8021p", EmitDefaultValue = true)]
        public bool Cos8021p { get; set; }

        /// <summary>
        /// Enable exclude from route advertisement (NSM, OSPF, BGP, RIP).
        /// </summary>
        /// <value>Enable exclude from route advertisement (NSM, OSPF, BGP, RIP).</value>
        [DataMember(Name = "exclude_route", EmitDefaultValue = true)]
        public bool ExcludeRoute { get; set; }

        /// <summary>
        /// Enable asymmetric route.
        /// </summary>
        /// <value>Enable asymmetric route.</value>
        [DataMember(Name = "asymmetric_route", EmitDefaultValue = true)]
        public bool AsymmetricRoute { get; set; }

        /// <summary>
        /// Enable management traffic only.
        /// </summary>
        /// <value>Enable management traffic only.</value>
        [DataMember(Name = "management_traffic_only", EmitDefaultValue = true)]
        public bool ManagementTrafficOnly { get; set; }

        /// <summary>
        /// Enable DNS proxy on the interface.
        /// </summary>
        /// <value>Enable DNS proxy on the interface.</value>
        [DataMember(Name = "dns_proxy", EmitDefaultValue = true)]
        public bool DnsProxy { get; set; }

        /// <summary>
        /// Enable shutdown port.
        /// </summary>
        /// <value>Enable shutdown port.</value>
        [DataMember(Name = "shutdown_port", EmitDefaultValue = true)]
        public bool ShutdownPort { get; set; }

        /// <summary>
        /// Gets or Sets Secondary
        /// </summary>
        [DataMember(Name = "secondary", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4Secondary Secondary { get; set; }

        /// <summary>
        /// Gets or Sets Default8021pCos
        /// </summary>
        [DataMember(Name = "default_8021p_cos", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4Default8021pCos Default8021pCos { get; set; }

        /// <summary>
        /// Gets or Sets BandwidthManagement
        /// </summary>
        [DataMember(Name = "bandwidth_management", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4BandwidthManagement BandwidthManagement { get; set; }

        /// <summary>
        /// Gets or Sets RoutedMode
        /// </summary>
        [DataMember(Name = "routed_mode", EmitDefaultValue = false)]
        public InterfaceIpv4Ipv4RoutedMode RoutedMode { get; set; }

        /// <summary>
        /// Enable one-arm mode on the interface
        /// </summary>
        /// <value>Enable one-arm mode on the interface</value>
        [DataMember(Name = "one_arm_mode", EmitDefaultValue = true)]
        public bool OneArmMode { get; set; }

        /// <summary>
        /// Set interface one-arm-peer.
        /// </summary>
        /// <value>Set interface one-arm-peer.</value>
        [DataMember(Name = "one_arm_peer", EmitDefaultValue = false)]
        public string OneArmPeer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv4Ipv4 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Vlan: ").Append(Vlan).Append("\n");
            sb.Append("  IpAssignment: ").Append(IpAssignment).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Mtu: ").Append(Mtu).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  LinkSpeed: ").Append(LinkSpeed).Append("\n");
            sb.Append("  Management: ").Append(Management).Append("\n");
            sb.Append("  UserLogin: ").Append(UserLogin).Append("\n");
            sb.Append("  HttpsRedirect: ").Append(HttpsRedirect).Append("\n");
            sb.Append("  SendIcmpFragmentation: ").Append(SendIcmpFragmentation).Append("\n");
            sb.Append("  FragmentPackets: ").Append(FragmentPackets).Append("\n");
            sb.Append("  IgnoreDfBit: ").Append(IgnoreDfBit).Append("\n");
            sb.Append("  FlowReporting: ").Append(FlowReporting).Append("\n");
            sb.Append("  Multicast: ").Append(Multicast).Append("\n");
            sb.Append("  Cos8021p: ").Append(Cos8021p).Append("\n");
            sb.Append("  ExcludeRoute: ").Append(ExcludeRoute).Append("\n");
            sb.Append("  AsymmetricRoute: ").Append(AsymmetricRoute).Append("\n");
            sb.Append("  ManagementTrafficOnly: ").Append(ManagementTrafficOnly).Append("\n");
            sb.Append("  DnsProxy: ").Append(DnsProxy).Append("\n");
            sb.Append("  ShutdownPort: ").Append(ShutdownPort).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
            sb.Append("  Default8021pCos: ").Append(Default8021pCos).Append("\n");
            sb.Append("  BandwidthManagement: ").Append(BandwidthManagement).Append("\n");
            sb.Append("  RoutedMode: ").Append(RoutedMode).Append("\n");
            sb.Append("  OneArmMode: ").Append(OneArmMode).Append("\n");
            sb.Append("  OneArmPeer: ").Append(OneArmPeer).Append("\n");
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
            return this.Equals(input as InterfaceIpv4Ipv4);
        }

        /// <summary>
        /// Returns true if InterfaceIpv4Ipv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv4Ipv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv4Ipv4 input)
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
                    this.Vlan == input.Vlan ||
                    this.Vlan.Equals(input.Vlan)
                ) && 
                (
                    this.IpAssignment == input.IpAssignment ||
                    (this.IpAssignment != null &&
                    this.IpAssignment.Equals(input.IpAssignment))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Mtu == input.Mtu ||
                    this.Mtu.Equals(input.Mtu)
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.LinkSpeed == input.LinkSpeed ||
                    (this.LinkSpeed != null &&
                    this.LinkSpeed.Equals(input.LinkSpeed))
                ) && 
                (
                    this.Management == input.Management ||
                    (this.Management != null &&
                    this.Management.Equals(input.Management))
                ) && 
                (
                    this.UserLogin == input.UserLogin ||
                    (this.UserLogin != null &&
                    this.UserLogin.Equals(input.UserLogin))
                ) && 
                (
                    this.HttpsRedirect == input.HttpsRedirect ||
                    this.HttpsRedirect.Equals(input.HttpsRedirect)
                ) && 
                (
                    this.SendIcmpFragmentation == input.SendIcmpFragmentation ||
                    this.SendIcmpFragmentation.Equals(input.SendIcmpFragmentation)
                ) && 
                (
                    this.FragmentPackets == input.FragmentPackets ||
                    this.FragmentPackets.Equals(input.FragmentPackets)
                ) && 
                (
                    this.IgnoreDfBit == input.IgnoreDfBit ||
                    this.IgnoreDfBit.Equals(input.IgnoreDfBit)
                ) && 
                (
                    this.FlowReporting == input.FlowReporting ||
                    this.FlowReporting.Equals(input.FlowReporting)
                ) && 
                (
                    this.Multicast == input.Multicast ||
                    this.Multicast.Equals(input.Multicast)
                ) && 
                (
                    this.Cos8021p == input.Cos8021p ||
                    this.Cos8021p.Equals(input.Cos8021p)
                ) && 
                (
                    this.ExcludeRoute == input.ExcludeRoute ||
                    this.ExcludeRoute.Equals(input.ExcludeRoute)
                ) && 
                (
                    this.AsymmetricRoute == input.AsymmetricRoute ||
                    this.AsymmetricRoute.Equals(input.AsymmetricRoute)
                ) && 
                (
                    this.ManagementTrafficOnly == input.ManagementTrafficOnly ||
                    this.ManagementTrafficOnly.Equals(input.ManagementTrafficOnly)
                ) && 
                (
                    this.DnsProxy == input.DnsProxy ||
                    this.DnsProxy.Equals(input.DnsProxy)
                ) && 
                (
                    this.ShutdownPort == input.ShutdownPort ||
                    this.ShutdownPort.Equals(input.ShutdownPort)
                ) && 
                (
                    this.Secondary == input.Secondary ||
                    (this.Secondary != null &&
                    this.Secondary.Equals(input.Secondary))
                ) && 
                (
                    this.Default8021pCos == input.Default8021pCos ||
                    (this.Default8021pCos != null &&
                    this.Default8021pCos.Equals(input.Default8021pCos))
                ) && 
                (
                    this.BandwidthManagement == input.BandwidthManagement ||
                    (this.BandwidthManagement != null &&
                    this.BandwidthManagement.Equals(input.BandwidthManagement))
                ) && 
                (
                    this.RoutedMode == input.RoutedMode ||
                    (this.RoutedMode != null &&
                    this.RoutedMode.Equals(input.RoutedMode))
                ) && 
                (
                    this.OneArmMode == input.OneArmMode ||
                    this.OneArmMode.Equals(input.OneArmMode)
                ) && 
                (
                    this.OneArmPeer == input.OneArmPeer ||
                    (this.OneArmPeer != null &&
                    this.OneArmPeer.Equals(input.OneArmPeer))
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
                hashCode = (hashCode * 59) + this.Vlan.GetHashCode();
                if (this.IpAssignment != null)
                {
                    hashCode = (hashCode * 59) + this.IpAssignment.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Mtu.GetHashCode();
                if (this.Mac != null)
                {
                    hashCode = (hashCode * 59) + this.Mac.GetHashCode();
                }
                if (this.LinkSpeed != null)
                {
                    hashCode = (hashCode * 59) + this.LinkSpeed.GetHashCode();
                }
                if (this.Management != null)
                {
                    hashCode = (hashCode * 59) + this.Management.GetHashCode();
                }
                if (this.UserLogin != null)
                {
                    hashCode = (hashCode * 59) + this.UserLogin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HttpsRedirect.GetHashCode();
                hashCode = (hashCode * 59) + this.SendIcmpFragmentation.GetHashCode();
                hashCode = (hashCode * 59) + this.FragmentPackets.GetHashCode();
                hashCode = (hashCode * 59) + this.IgnoreDfBit.GetHashCode();
                hashCode = (hashCode * 59) + this.FlowReporting.GetHashCode();
                hashCode = (hashCode * 59) + this.Multicast.GetHashCode();
                hashCode = (hashCode * 59) + this.Cos8021p.GetHashCode();
                hashCode = (hashCode * 59) + this.ExcludeRoute.GetHashCode();
                hashCode = (hashCode * 59) + this.AsymmetricRoute.GetHashCode();
                hashCode = (hashCode * 59) + this.ManagementTrafficOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.DnsProxy.GetHashCode();
                hashCode = (hashCode * 59) + this.ShutdownPort.GetHashCode();
                if (this.Secondary != null)
                {
                    hashCode = (hashCode * 59) + this.Secondary.GetHashCode();
                }
                if (this.Default8021pCos != null)
                {
                    hashCode = (hashCode * 59) + this.Default8021pCos.GetHashCode();
                }
                if (this.BandwidthManagement != null)
                {
                    hashCode = (hashCode * 59) + this.BandwidthManagement.GetHashCode();
                }
                if (this.RoutedMode != null)
                {
                    hashCode = (hashCode * 59) + this.RoutedMode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OneArmMode.GetHashCode();
                if (this.OneArmPeer != null)
                {
                    hashCode = (hashCode * 59) + this.OneArmPeer.GetHashCode();
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
            yield break;
        }
    }

}
