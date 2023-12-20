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
    /// SonicWALL auto provisoning server VPN policy.
    /// </summary>
    [DataContract(Name = "vpn_policy_ipv4_provision_server_ipv4_provision_server")]
    public partial class VpnPolicyIpv4ProvisionServerIpv4ProvisionServer : IEquatable<VpnPolicyIpv4ProvisionServerIpv4ProvisionServer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VpnPolicyIpv4ProvisionServerIpv4ProvisionServer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServer" /> class.
        /// </summary>
        /// <param name="name">Policy name. (required).</param>
        /// <param name="enable">Enable VPN policy..</param>
        /// <param name="authMethod">authMethod.</param>
        /// <param name="network">network.</param>
        /// <param name="proposal">proposal.</param>
        /// <param name="antiReplay">Enable anti replay..</param>
        /// <param name="multicast">Enable VPN policy multicast..</param>
        /// <param name="management">management.</param>
        /// <param name="userLogin">userLogin.</param>
        /// <param name="defaultLanGateway">Configure LAN default gateway..</param>
        /// <param name="boundTo">boundTo.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServer(string name = default(string), bool enable = default(bool), VpnPolicyIpv4ProvisionServerIpv4ProvisionServerAuthMethod authMethod = default(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerAuthMethod), VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetwork network = default(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetwork), VpnPolicyIpv4ProvisionServerIpv4ProvisionServerProposal proposal = default(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerProposal), bool antiReplay = default(bool), bool multicast = default(bool), VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement management = default(VpnPolicyIpv4GroupVpnIpv4GroupVpnManagement), VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin userLogin = default(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteUserLogin), string defaultLanGateway = default(string), VpnPolicyIpv4ProvisionServerIpv4ProvisionServerBoundTo boundTo = default(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerBoundTo))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for VpnPolicyIpv4ProvisionServerIpv4ProvisionServer and cannot be null");
            }
            this.Name = name;
            this.Enable = enable;
            this.AuthMethod = authMethod;
            this.Network = network;
            this.Proposal = proposal;
            this.AntiReplay = antiReplay;
            this.Multicast = multicast;
            this.Management = management;
            this.UserLogin = userLogin;
            this.DefaultLanGateway = defaultLanGateway;
            this.BoundTo = boundTo;
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
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerAuthMethod AuthMethod { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetwork Network { get; set; }

        /// <summary>
        /// Gets or Sets Proposal
        /// </summary>
        [DataMember(Name = "proposal", EmitDefaultValue = false)]
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerProposal Proposal { get; set; }

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
        /// Configure LAN default gateway.
        /// </summary>
        /// <value>Configure LAN default gateway.</value>
        [DataMember(Name = "default_lan_gateway", EmitDefaultValue = false)]
        public string DefaultLanGateway { get; set; }

        /// <summary>
        /// Gets or Sets BoundTo
        /// </summary>
        [DataMember(Name = "bound_to", EmitDefaultValue = false)]
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerBoundTo BoundTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4ProvisionServerIpv4ProvisionServer {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  AuthMethod: ").Append(AuthMethod).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Proposal: ").Append(Proposal).Append("\n");
            sb.Append("  AntiReplay: ").Append(AntiReplay).Append("\n");
            sb.Append("  Multicast: ").Append(Multicast).Append("\n");
            sb.Append("  Management: ").Append(Management).Append("\n");
            sb.Append("  UserLogin: ").Append(UserLogin).Append("\n");
            sb.Append("  DefaultLanGateway: ").Append(DefaultLanGateway).Append("\n");
            sb.Append("  BoundTo: ").Append(BoundTo).Append("\n");
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
            return this.Equals(input as VpnPolicyIpv4ProvisionServerIpv4ProvisionServer);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4ProvisionServerIpv4ProvisionServer instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4ProvisionServerIpv4ProvisionServer input)
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
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Proposal == input.Proposal ||
                    (this.Proposal != null &&
                    this.Proposal.Equals(input.Proposal))
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
                    this.DefaultLanGateway == input.DefaultLanGateway ||
                    (this.DefaultLanGateway != null &&
                    this.DefaultLanGateway.Equals(input.DefaultLanGateway))
                ) && 
                (
                    this.BoundTo == input.BoundTo ||
                    (this.BoundTo != null &&
                    this.BoundTo.Equals(input.BoundTo))
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
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.Proposal != null)
                {
                    hashCode = (hashCode * 59) + this.Proposal.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AntiReplay.GetHashCode();
                hashCode = (hashCode * 59) + this.Multicast.GetHashCode();
                if (this.Management != null)
                {
                    hashCode = (hashCode * 59) + this.Management.GetHashCode();
                }
                if (this.UserLogin != null)
                {
                    hashCode = (hashCode * 59) + this.UserLogin.GetHashCode();
                }
                if (this.DefaultLanGateway != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultLanGateway.GetHashCode();
                }
                if (this.BoundTo != null)
                {
                    hashCode = (hashCode * 59) + this.BoundTo.GetHashCode();
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
