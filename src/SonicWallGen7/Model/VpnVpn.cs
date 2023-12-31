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
    /// Configure VPN.
    /// </summary>
    [DataContract(Name = "vpn_vpn")]
    public partial class VpnVpn : IEquatable<VpnVpn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnVpn" /> class.
        /// </summary>
        /// <param name="enable">Enable VPN..</param>
        /// <param name="firewallIdentifier">Configure unique firewall identifier..</param>
        /// <param name="ikeDpd">ikeDpd.</param>
        /// <param name="fragPackets">fragPackets.</param>
        /// <param name="natTraversal">Enable NAT traversal..</param>
        /// <param name="cleanupTunnels">Enable clean up active tunnels when peer gateway SonicDns name resolves to a different IP address..</param>
        /// <param name="preserveIkePort">Enable preserve IKE port for pass through connections..</param>
        /// <param name="ocspChecking">Enable OCSP checking..</param>
        /// <param name="responderUrl">OCSP responder URL..</param>
        /// <param name="trapsOnChange">Enable VPN tunnel traps only when tunnel status changes..</param>
        /// <param name="useRadius">useRadius.</param>
        /// <param name="SonicDns">SonicDns.</param>
        /// <param name="wins">wins.</param>
        /// <param name="autoRule">Enable UPE Auto Rule..</param>
        /// <param name="ikev2">ikev2.</param>
        public VpnVpn(bool enable = default(bool), string firewallIdentifier = default(string), VpnVpnIkeDpd ikeDpd = default(VpnVpnIkeDpd), VpnVpnFragPackets fragPackets = default(VpnVpnFragPackets), bool natTraversal = default(bool), bool cleanupTunnels = default(bool), bool preserveIkePort = default(bool), bool ocspChecking = default(bool), string responderUrl = default(string), bool trapsOnChange = default(bool), VpnVpnUseRadius useRadius = default(VpnVpnUseRadius), VpnVpnSonicDns SonicDns = default(VpnVpnSonicDns), DhcpServerScopeDynamicWins wins = default(DhcpServerScopeDynamicWins), bool autoRule = default(bool), VpnVpnIkev2 ikev2 = default(VpnVpnIkev2))
        {
            this.Enable = enable;
            this.FirewallIdentifier = firewallIdentifier;
            this.IkeDpd = ikeDpd;
            this.FragPackets = fragPackets;
            this.NatTraversal = natTraversal;
            this.CleanupTunnels = cleanupTunnels;
            this.PreserveIkePort = preserveIkePort;
            this.OcspChecking = ocspChecking;
            this.ResponderUrl = responderUrl;
            this.TrapsOnChange = trapsOnChange;
            this.UseRadius = useRadius;
            this.SonicDns = SonicDns;
            this.Wins = wins;
            this.AutoRule = autoRule;
            this.Ikev2 = ikev2;
        }

        /// <summary>
        /// Enable VPN.
        /// </summary>
        /// <value>Enable VPN.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Configure unique firewall identifier.
        /// </summary>
        /// <value>Configure unique firewall identifier.</value>
        [DataMember(Name = "firewall_identifier", EmitDefaultValue = false)]
        public string FirewallIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets IkeDpd
        /// </summary>
        [DataMember(Name = "ike_dpd", EmitDefaultValue = false)]
        public VpnVpnIkeDpd IkeDpd { get; set; }

        /// <summary>
        /// Gets or Sets FragPackets
        /// </summary>
        [DataMember(Name = "frag_packets", EmitDefaultValue = false)]
        public VpnVpnFragPackets FragPackets { get; set; }

        /// <summary>
        /// Enable NAT traversal.
        /// </summary>
        /// <value>Enable NAT traversal.</value>
        [DataMember(Name = "nat_traversal", EmitDefaultValue = true)]
        public bool NatTraversal { get; set; }

        /// <summary>
        /// Enable clean up active tunnels when peer gateway SonicDns name resolves to a different IP address.
        /// </summary>
        /// <value>Enable clean up active tunnels when peer gateway SonicDns name resolves to a different IP address.</value>
        [DataMember(Name = "cleanup_tunnels", EmitDefaultValue = true)]
        public bool CleanupTunnels { get; set; }

        /// <summary>
        /// Enable preserve IKE port for pass through connections.
        /// </summary>
        /// <value>Enable preserve IKE port for pass through connections.</value>
        [DataMember(Name = "preserve_ike_port", EmitDefaultValue = true)]
        public bool PreserveIkePort { get; set; }

        /// <summary>
        /// Enable OCSP checking.
        /// </summary>
        /// <value>Enable OCSP checking.</value>
        [DataMember(Name = "ocsp_checking", EmitDefaultValue = true)]
        public bool OcspChecking { get; set; }

        /// <summary>
        /// OCSP responder URL.
        /// </summary>
        /// <value>OCSP responder URL.</value>
        [DataMember(Name = "responder_url", EmitDefaultValue = false)]
        public string ResponderUrl { get; set; }

        /// <summary>
        /// Enable VPN tunnel traps only when tunnel status changes.
        /// </summary>
        /// <value>Enable VPN tunnel traps only when tunnel status changes.</value>
        [DataMember(Name = "traps_on_change", EmitDefaultValue = true)]
        public bool TrapsOnChange { get; set; }

        /// <summary>
        /// Gets or Sets UseRadius
        /// </summary>
        [DataMember(Name = "use_radius", EmitDefaultValue = false)]
        public VpnVpnUseRadius UseRadius { get; set; }

        /// <summary>
        /// Gets or Sets SonicDns
        /// </summary>
        [DataMember(Name = "SonicDns", EmitDefaultValue = false)]
        public VpnVpnSonicDns SonicDns { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name = "wins", EmitDefaultValue = false)]
        public DhcpServerScopeDynamicWins Wins { get; set; }

        /// <summary>
        /// Enable UPE Auto Rule.
        /// </summary>
        /// <value>Enable UPE Auto Rule.</value>
        [DataMember(Name = "auto_rule", EmitDefaultValue = true)]
        public bool AutoRule { get; set; }

        /// <summary>
        /// Gets or Sets Ikev2
        /// </summary>
        [DataMember(Name = "ikev2", EmitDefaultValue = false)]
        public VpnVpnIkev2 Ikev2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnVpn {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  FirewallIdentifier: ").Append(FirewallIdentifier).Append("\n");
            sb.Append("  IkeDpd: ").Append(IkeDpd).Append("\n");
            sb.Append("  FragPackets: ").Append(FragPackets).Append("\n");
            sb.Append("  NatTraversal: ").Append(NatTraversal).Append("\n");
            sb.Append("  CleanupTunnels: ").Append(CleanupTunnels).Append("\n");
            sb.Append("  PreserveIkePort: ").Append(PreserveIkePort).Append("\n");
            sb.Append("  OcspChecking: ").Append(OcspChecking).Append("\n");
            sb.Append("  ResponderUrl: ").Append(ResponderUrl).Append("\n");
            sb.Append("  TrapsOnChange: ").Append(TrapsOnChange).Append("\n");
            sb.Append("  UseRadius: ").Append(UseRadius).Append("\n");
            sb.Append("  SonicDns: ").Append(SonicDns).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  AutoRule: ").Append(AutoRule).Append("\n");
            sb.Append("  Ikev2: ").Append(Ikev2).Append("\n");
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
            return this.Equals(input as VpnVpn);
        }

        /// <summary>
        /// Returns true if VpnVpn instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnVpn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnVpn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.FirewallIdentifier == input.FirewallIdentifier ||
                    (this.FirewallIdentifier != null &&
                    this.FirewallIdentifier.Equals(input.FirewallIdentifier))
                ) && 
                (
                    this.IkeDpd == input.IkeDpd ||
                    (this.IkeDpd != null &&
                    this.IkeDpd.Equals(input.IkeDpd))
                ) && 
                (
                    this.FragPackets == input.FragPackets ||
                    (this.FragPackets != null &&
                    this.FragPackets.Equals(input.FragPackets))
                ) && 
                (
                    this.NatTraversal == input.NatTraversal ||
                    this.NatTraversal.Equals(input.NatTraversal)
                ) && 
                (
                    this.CleanupTunnels == input.CleanupTunnels ||
                    this.CleanupTunnels.Equals(input.CleanupTunnels)
                ) && 
                (
                    this.PreserveIkePort == input.PreserveIkePort ||
                    this.PreserveIkePort.Equals(input.PreserveIkePort)
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
                    this.TrapsOnChange == input.TrapsOnChange ||
                    this.TrapsOnChange.Equals(input.TrapsOnChange)
                ) && 
                (
                    this.UseRadius == input.UseRadius ||
                    (this.UseRadius != null &&
                    this.UseRadius.Equals(input.UseRadius))
                ) && 
                (
                    this.SonicDns == input.SonicDns ||
                    (this.SonicDns != null &&
                    this.SonicDns.Equals(input.SonicDns))
                ) && 
                (
                    this.Wins == input.Wins ||
                    (this.Wins != null &&
                    this.Wins.Equals(input.Wins))
                ) && 
                (
                    this.AutoRule == input.AutoRule ||
                    this.AutoRule.Equals(input.AutoRule)
                ) && 
                (
                    this.Ikev2 == input.Ikev2 ||
                    (this.Ikev2 != null &&
                    this.Ikev2.Equals(input.Ikev2))
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.FirewallIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.FirewallIdentifier.GetHashCode();
                }
                if (this.IkeDpd != null)
                {
                    hashCode = (hashCode * 59) + this.IkeDpd.GetHashCode();
                }
                if (this.FragPackets != null)
                {
                    hashCode = (hashCode * 59) + this.FragPackets.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NatTraversal.GetHashCode();
                hashCode = (hashCode * 59) + this.CleanupTunnels.GetHashCode();
                hashCode = (hashCode * 59) + this.PreserveIkePort.GetHashCode();
                hashCode = (hashCode * 59) + this.OcspChecking.GetHashCode();
                if (this.ResponderUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ResponderUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TrapsOnChange.GetHashCode();
                if (this.UseRadius != null)
                {
                    hashCode = (hashCode * 59) + this.UseRadius.GetHashCode();
                }
                if (this.SonicDns != null)
                {
                    hashCode = (hashCode * 59) + this.SonicDns.GetHashCode();
                }
                if (this.Wins != null)
                {
                    hashCode = (hashCode * 59) + this.Wins.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoRule.GetHashCode();
                if (this.Ikev2 != null)
                {
                    hashCode = (hashCode * 59) + this.Ikev2.GetHashCode();
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
