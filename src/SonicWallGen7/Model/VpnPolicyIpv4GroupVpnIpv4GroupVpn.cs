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
    /// Group VPN policy.
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv4_group_vpn_ipv4_group_vpn")]
    public partial class VpnPolicyIpv4GroupVpnIpv4GroupVpn : IEquatable<VpnPolicyIpv4GroupVpnIpv4GroupVpn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VpnPolicyIpv4GroupVpnIpv4GroupVpn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpn" /> class.
        /// </summary>
        /// <param name="name">Policy name. (required).</param>
        /// <param name="enable">Enable VPN policy..</param>
        /// <param name="authMethod">authMethod.</param>
        /// <param name="proposal">proposal.</param>
        /// <param name="varClient">varClient.</param>
        /// <param name="antiReplay">Enable anti replay..</param>
        /// <param name="multicast">Enable VPN policy multicast..</param>
        /// <param name="ocspChecking">Enable and configure OCSP checking..</param>
        /// <param name="responderUrl">OCSP responder URL..</param>
        /// <param name="management">management.</param>
        /// <param name="defaultLanGateway">Configure LAN default gateway..</param>
        /// <param name="clientAuthentication">clientAuthentication.</param>
        /// <param name="acceptMultipleProposals">Enable accept multiple proposals for clients..</param>
        /// <param name="ikeModeConfiguration">ikeModeConfiguration.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpn(string name = default(string), bool enable = default(bool), VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod authMethod = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod), VpnPolicyIpv4GroupVpnIpv4GroupVpnProposal proposal = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnProposal), VpnPolicyIpv4GroupVpnIpv4GroupVpnClient varClient = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnClient), bool antiReplay = default(bool), bool multicast = default(bool), bool ocspChecking = default(bool), string responderUrl = default(string), VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement management = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement), string defaultLanGateway = default(string), VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthentication clientAuthentication = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthentication), bool acceptMultipleProposals = default(bool), VpnPolicyIpv4GroupVpnIpv4GroupVpnIkeModeConfiguration ikeModeConfiguration = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnIkeModeConfiguration))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for VpnPolicyIpv4GroupVpnIpv4GroupVpn and cannot be null");
            }
            this.Name = name;
            this.Enable = enable;
            this.AuthMethod = authMethod;
            this.Proposal = proposal;
            this.VarClient = varClient;
            this.AntiReplay = antiReplay;
            this.Multicast = multicast;
            this.OcspChecking = ocspChecking;
            this.ResponderUrl = responderUrl;
            this.Management = management;
            this.DefaultLanGateway = defaultLanGateway;
            this.ClientAuthentication = clientAuthentication;
            this.AcceptMultipleProposals = acceptMultipleProposals;
            this.IkeModeConfiguration = ikeModeConfiguration;
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
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnAuthMethod AuthMethod { get; set; }

        /// <summary>
        /// Gets or Sets Proposal
        /// </summary>
        [DataMember(Name = "proposal", EmitDefaultValue = false)]
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnProposal Proposal { get; set; }

        /// <summary>
        /// Gets or Sets VarClient
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClient VarClient { get; set; }

        /// <summary>
        /// Enable anti replay.
        /// </summary>
        /// <value>Enable anti replay.</value>
        [DataMember(Name = "anti_replay", EmitDefaultValue = true)]
        public bool AntiReplay { get; set; }

        /// <summary>
        /// Enable VPN policy multicast.
        /// </summary>
        /// <value>Enable VPN policy multicast.</value>
        [DataMember(Name = "multicast", EmitDefaultValue = true)]
        public bool Multicast { get; set; }

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
        /// Configure LAN default gateway.
        /// </summary>
        /// <value>Configure LAN default gateway.</value>
        [DataMember(Name = "default_lan_gateway", EmitDefaultValue = false)]
        public string DefaultLanGateway { get; set; }

        /// <summary>
        /// Gets or Sets ClientAuthentication
        /// </summary>
        [DataMember(Name = "client_authentication", EmitDefaultValue = false)]
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthentication ClientAuthentication { get; set; }

        /// <summary>
        /// Enable accept multiple proposals for clients.
        /// </summary>
        /// <value>Enable accept multiple proposals for clients.</value>
        [DataMember(Name = "accept_multiple_proposals", EmitDefaultValue = true)]
        public bool AcceptMultipleProposals { get; set; }

        /// <summary>
        /// Gets or Sets IkeModeConfiguration
        /// </summary>
        [DataMember(Name = "ike_mode_configuration", EmitDefaultValue = true)]
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnIkeModeConfiguration IkeModeConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4GroupVpnIpv4GroupVpn {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  AuthMethod: ").Append(AuthMethod).Append("\n");
            sb.Append("  Proposal: ").Append(Proposal).Append("\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  AntiReplay: ").Append(AntiReplay).Append("\n");
            sb.Append("  Multicast: ").Append(Multicast).Append("\n");
            sb.Append("  OcspChecking: ").Append(OcspChecking).Append("\n");
            sb.Append("  ResponderUrl: ").Append(ResponderUrl).Append("\n");
            sb.Append("  Management: ").Append(Management).Append("\n");
            sb.Append("  DefaultLanGateway: ").Append(DefaultLanGateway).Append("\n");
            sb.Append("  ClientAuthentication: ").Append(ClientAuthentication).Append("\n");
            sb.Append("  AcceptMultipleProposals: ").Append(AcceptMultipleProposals).Append("\n");
            sb.Append("  IkeModeConfiguration: ").Append(IkeModeConfiguration).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv4GroupVpnIpv4GroupVpn);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4GroupVpnIpv4GroupVpn instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4GroupVpnIpv4GroupVpn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4GroupVpnIpv4GroupVpn input)
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
                    this.Proposal == input.Proposal ||
                    (this.Proposal != null &&
                    this.Proposal.Equals(input.Proposal))
                ) && 
                (
                    this.VarClient == input.VarClient ||
                    (this.VarClient != null &&
                    this.VarClient.Equals(input.VarClient))
                ) && 
                (
                    this.AntiReplay == input.AntiReplay ||
                    this.AntiReplay.Equals(input.AntiReplay)
                ) && 
                (
                    this.Multicast == input.Multicast ||
                    this.Multicast.Equals(input.Multicast)
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
                    this.DefaultLanGateway == input.DefaultLanGateway ||
                    (this.DefaultLanGateway != null &&
                    this.DefaultLanGateway.Equals(input.DefaultLanGateway))
                ) && 
                (
                    this.ClientAuthentication == input.ClientAuthentication ||
                    (this.ClientAuthentication != null &&
                    this.ClientAuthentication.Equals(input.ClientAuthentication))
                ) && 
                (
                    this.AcceptMultipleProposals == input.AcceptMultipleProposals ||
                    this.AcceptMultipleProposals.Equals(input.AcceptMultipleProposals)
                ) && 
                (
                    this.IkeModeConfiguration == input.IkeModeConfiguration ||
                    (this.IkeModeConfiguration != null &&
                    this.IkeModeConfiguration.Equals(input.IkeModeConfiguration))
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
                if (this.Proposal != null)
                {
                    hashCode = (hashCode * 59) + this.Proposal.GetHashCode();
                }
                if (this.VarClient != null)
                {
                    hashCode = (hashCode * 59) + this.VarClient.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AntiReplay.GetHashCode();
                hashCode = (hashCode * 59) + this.Multicast.GetHashCode();
                hashCode = (hashCode * 59) + this.OcspChecking.GetHashCode();
                if (this.ResponderUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ResponderUrl.GetHashCode();
                }
                if (this.Management != null)
                {
                    hashCode = (hashCode * 59) + this.Management.GetHashCode();
                }
                if (this.DefaultLanGateway != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultLanGateway.GetHashCode();
                }
                if (this.ClientAuthentication != null)
                {
                    hashCode = (hashCode * 59) + this.ClientAuthentication.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AcceptMultipleProposals.GetHashCode();
                if (this.IkeModeConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.IkeModeConfiguration.GetHashCode();
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
