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
    /// Tunnel interface VPN policy.
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv4_tunnel_interface_ipv4_tunnel_interface")]
    public partial class VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface : IEquatable<VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface" /> class.
        /// </summary>
        /// <param name="name">Policy name. (required).</param>
        /// <param name="enable">Enable VPN policy..</param>
        /// <param name="authMethod">authMethod.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="proposal">proposal.</param>
        /// <param name="keepAlive">Enable VPN policy keep alive..</param>
        /// <param name="antiReplay">Enable anti replay..</param>
        /// <param name="advancedRouting">Enable allow advanced routing..</param>
        /// <param name="transportMode">Enable transport mode..</param>
        /// <param name="netbios">Enable VPN policy NetBIOS..</param>
        /// <param name="multicast">Enable VPN policy multicast..</param>
        /// <param name="applyNat">Enable apply NAT policies..</param>
        /// <param name="ocspChecking">Enable and configure OCSP checking..</param>
        /// <param name="responderUrl">OCSP responder URL..</param>
        /// <param name="management">management.</param>
        /// <param name="userLogin">userLogin.</param>
        /// <param name="boundTo">boundTo.</param>
        /// <param name="suppressTriggerPacket">Do not send trigger packet during IKE SA negotiation for IKEv2..</param>
        /// <param name="acceptHash">Accept hash &amp; URL certificate type for IKEv2..</param>
        /// <param name="sendHash">Enable send hash &amp; URL certificate type for IKEv2 and specify url..</param>
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface(string name = default(string), bool enable = default(bool), VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethod authMethod = default(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethod), VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceGateway gateway = default(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceGateway), VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposal proposal = default(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposal), bool keepAlive = default(bool), bool antiReplay = default(bool), bool advancedRouting = default(bool), bool transportMode = default(bool), bool netbios = default(bool), bool multicast = default(bool), bool applyNat = default(bool), bool ocspChecking = default(bool), string responderUrl = default(string), VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement management = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement), VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin userLogin = default(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin), VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceBoundTo boundTo = default(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceBoundTo), bool suppressTriggerPacket = default(bool), bool acceptHash = default(bool), string sendHash = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface and cannot be null");
            }
            this.Name = name;
            this.Enable = enable;
            this.AuthMethod = authMethod;
            this.Gateway = gateway;
            this.Proposal = proposal;
            this.KeepAlive = keepAlive;
            this.AntiReplay = antiReplay;
            this.AdvancedRouting = advancedRouting;
            this.TransportMode = transportMode;
            this.Netbios = netbios;
            this.Multicast = multicast;
            this.ApplyNat = applyNat;
            this.OcspChecking = ocspChecking;
            this.ResponderUrl = responderUrl;
            this.Management = management;
            this.UserLogin = userLogin;
            this.BoundTo = boundTo;
            this.SuppressTriggerPacket = suppressTriggerPacket;
            this.AcceptHash = acceptHash;
            this.SendHash = sendHash;
        }

        /// <summary>
        /// Policy name.
        /// </summary>
        /// <value>Policy name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Enable VPN policy.
        /// </summary>
        /// <value>Enable VPN policy.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethod
        /// </summary>
        [DataMember(Name = "auth_method", EmitDefaultValue = false)]
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceAuthMethod AuthMethod { get; set; }

        /// <summary>
        /// Gets or Sets Gateway
        /// </summary>
        [DataMember(Name = "gateway", EmitDefaultValue = false)]
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceGateway Gateway { get; set; }

        /// <summary>
        /// Gets or Sets Proposal
        /// </summary>
        [DataMember(Name = "proposal", EmitDefaultValue = false)]
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceProposal Proposal { get; set; }

        /// <summary>
        /// Enable VPN policy keep alive.
        /// </summary>
        /// <value>Enable VPN policy keep alive.</value>
        [DataMember(Name = "keep_alive", EmitDefaultValue = true)]
        public bool KeepAlive { get; set; }

        /// <summary>
        /// Enable anti replay.
        /// </summary>
        /// <value>Enable anti replay.</value>
        [DataMember(Name = "anti_replay", EmitDefaultValue = true)]
        public bool AntiReplay { get; set; }

        /// <summary>
        /// Enable allow advanced routing.
        /// </summary>
        /// <value>Enable allow advanced routing.</value>
        [DataMember(Name = "advanced_routing", EmitDefaultValue = true)]
        public bool AdvancedRouting { get; set; }

        /// <summary>
        /// Enable transport mode.
        /// </summary>
        /// <value>Enable transport mode.</value>
        [DataMember(Name = "transport_mode", EmitDefaultValue = true)]
        public bool TransportMode { get; set; }

        /// <summary>
        /// Enable VPN policy NetBIOS.
        /// </summary>
        /// <value>Enable VPN policy NetBIOS.</value>
        [DataMember(Name = "netbios", EmitDefaultValue = true)]
        public bool Netbios { get; set; }

        /// <summary>
        /// Enable VPN policy multicast.
        /// </summary>
        /// <value>Enable VPN policy multicast.</value>
        [DataMember(Name = "multicast", EmitDefaultValue = true)]
        public bool Multicast { get; set; }

        /// <summary>
        /// Enable apply NAT policies.
        /// </summary>
        /// <value>Enable apply NAT policies.</value>
        [DataMember(Name = "apply_nat", EmitDefaultValue = true)]
        public bool ApplyNat { get; set; }

        /// <summary>
        /// Enable and configure OCSP checking.
        /// </summary>
        /// <value>Enable and configure OCSP checking.</value>
        [DataMember(Name = "ocsp_checking", EmitDefaultValue = true)]
        public bool OcspChecking { get; set; }

        /// <summary>
        /// OCSP responder URL.
        /// </summary>
        /// <value>OCSP responder URL.</value>
        [DataMember(Name = "responder_url", EmitDefaultValue = false)]
        public string ResponderUrl { get; set; }

        /// <summary>
        /// Gets or Sets Management
        /// </summary>
        [DataMember(Name = "management", EmitDefaultValue = false)]
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement Management { get; set; }

        /// <summary>
        /// Gets or Sets UserLogin
        /// </summary>
        [DataMember(Name = "user_login", EmitDefaultValue = false)]
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin UserLogin { get; set; }

        /// <summary>
        /// Gets or Sets BoundTo
        /// </summary>
        [DataMember(Name = "bound_to", EmitDefaultValue = false)]
        public VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterfaceBoundTo BoundTo { get; set; }

        /// <summary>
        /// Do not send trigger packet during IKE SA negotiation for IKEv2.
        /// </summary>
        /// <value>Do not send trigger packet during IKE SA negotiation for IKEv2.</value>
        [DataMember(Name = "suppress_trigger_packet", EmitDefaultValue = true)]
        public bool SuppressTriggerPacket { get; set; }

        /// <summary>
        /// Accept hash &amp; URL certificate type for IKEv2.
        /// </summary>
        /// <value>Accept hash &amp; URL certificate type for IKEv2.</value>
        [DataMember(Name = "accept_hash", EmitDefaultValue = true)]
        public bool AcceptHash { get; set; }

        /// <summary>
        /// Enable send hash &amp; URL certificate type for IKEv2 and specify url.
        /// </summary>
        /// <value>Enable send hash &amp; URL certificate type for IKEv2 and specify url.</value>
        [DataMember(Name = "send_hash", EmitDefaultValue = false)]
        public string SendHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  AuthMethod: ").Append(AuthMethod).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  Proposal: ").Append(Proposal).Append("\n");
            sb.Append("  KeepAlive: ").Append(KeepAlive).Append("\n");
            sb.Append("  AntiReplay: ").Append(AntiReplay).Append("\n");
            sb.Append("  AdvancedRouting: ").Append(AdvancedRouting).Append("\n");
            sb.Append("  TransportMode: ").Append(TransportMode).Append("\n");
            sb.Append("  Netbios: ").Append(Netbios).Append("\n");
            sb.Append("  Multicast: ").Append(Multicast).Append("\n");
            sb.Append("  ApplyNat: ").Append(ApplyNat).Append("\n");
            sb.Append("  OcspChecking: ").Append(OcspChecking).Append("\n");
            sb.Append("  ResponderUrl: ").Append(ResponderUrl).Append("\n");
            sb.Append("  Management: ").Append(Management).Append("\n");
            sb.Append("  UserLogin: ").Append(UserLogin).Append("\n");
            sb.Append("  BoundTo: ").Append(BoundTo).Append("\n");
            sb.Append("  SuppressTriggerPacket: ").Append(SuppressTriggerPacket).Append("\n");
            sb.Append("  AcceptHash: ").Append(AcceptHash).Append("\n");
            sb.Append("  SendHash: ").Append(SendHash).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4TunnelInterfaceIpv4TunnelInterface input)
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
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.AuthMethod == input.AuthMethod ||
                    (this.AuthMethod != null &&
                    this.AuthMethod.Equals(input.AuthMethod))
                ) && 
                (
                    this.Gateway == input.Gateway ||
                    (this.Gateway != null &&
                    this.Gateway.Equals(input.Gateway))
                ) && 
                (
                    this.Proposal == input.Proposal ||
                    (this.Proposal != null &&
                    this.Proposal.Equals(input.Proposal))
                ) && 
                (
                    this.KeepAlive == input.KeepAlive ||
                    this.KeepAlive.Equals(input.KeepAlive)
                ) && 
                (
                    this.AntiReplay == input.AntiReplay ||
                    this.AntiReplay.Equals(input.AntiReplay)
                ) && 
                (
                    this.AdvancedRouting == input.AdvancedRouting ||
                    this.AdvancedRouting.Equals(input.AdvancedRouting)
                ) && 
                (
                    this.TransportMode == input.TransportMode ||
                    this.TransportMode.Equals(input.TransportMode)
                ) && 
                (
                    this.Netbios == input.Netbios ||
                    this.Netbios.Equals(input.Netbios)
                ) && 
                (
                    this.Multicast == input.Multicast ||
                    this.Multicast.Equals(input.Multicast)
                ) && 
                (
                    this.ApplyNat == input.ApplyNat ||
                    this.ApplyNat.Equals(input.ApplyNat)
                ) && 
                (
                    this.OcspChecking == input.OcspChecking ||
                    this.OcspChecking.Equals(input.OcspChecking)
                ) && 
                (
                    this.ResponderUrl == input.ResponderUrl ||
                    (this.ResponderUrl != null &&
                    this.ResponderUrl.Equals(input.ResponderUrl))
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
                    this.BoundTo == input.BoundTo ||
                    (this.BoundTo != null &&
                    this.BoundTo.Equals(input.BoundTo))
                ) && 
                (
                    this.SuppressTriggerPacket == input.SuppressTriggerPacket ||
                    this.SuppressTriggerPacket.Equals(input.SuppressTriggerPacket)
                ) && 
                (
                    this.AcceptHash == input.AcceptHash ||
                    this.AcceptHash.Equals(input.AcceptHash)
                ) && 
                (
                    this.SendHash == input.SendHash ||
                    (this.SendHash != null &&
                    this.SendHash.Equals(input.SendHash))
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.AuthMethod != null)
                {
                    hashCode = (hashCode * 59) + this.AuthMethod.GetHashCode();
                }
                if (this.Gateway != null)
                {
                    hashCode = (hashCode * 59) + this.Gateway.GetHashCode();
                }
                if (this.Proposal != null)
                {
                    hashCode = (hashCode * 59) + this.Proposal.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeepAlive.GetHashCode();
                hashCode = (hashCode * 59) + this.AntiReplay.GetHashCode();
                hashCode = (hashCode * 59) + this.AdvancedRouting.GetHashCode();
                hashCode = (hashCode * 59) + this.TransportMode.GetHashCode();
                hashCode = (hashCode * 59) + this.Netbios.GetHashCode();
                hashCode = (hashCode * 59) + this.Multicast.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplyNat.GetHashCode();
                hashCode = (hashCode * 59) + this.OcspChecking.GetHashCode();
                if (this.ResponderUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ResponderUrl.GetHashCode();
                }
                if (this.Management != null)
                {
                    hashCode = (hashCode * 59) + this.Management.GetHashCode();
                }
                if (this.UserLogin != null)
                {
                    hashCode = (hashCode * 59) + this.UserLogin.GetHashCode();
                }
                if (this.BoundTo != null)
                {
                    hashCode = (hashCode * 59) + this.BoundTo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SuppressTriggerPacket.GetHashCode();
                hashCode = (hashCode * 59) + this.AcceptHash.GetHashCode();
                if (this.SendHash != null)
                {
                    hashCode = (hashCode * 59) + this.SendHash.GetHashCode();
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
