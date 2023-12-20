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
    /// system security detail schema.
    /// </summary>
    [DataContract(Name = "show_status_system_security_detail")]
    public partial class ShowStatusSystemSecurityDetail : IEquatable<ShowStatusSystemSecurityDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusSystemSecurityDetail" /> class.
        /// </summary>
        /// <param name="noRegistNodesUsers">noRegistNodesUsers.</param>
        /// <param name="noRegistSslVpnNodesUsers">noRegistSslVpnNodesUsers.</param>
        /// <param name="noRegistVirtualAssistNodesUsers">noRegistVirtualAssistNodesUsers.</param>
        /// <param name="registrationStatus">registrationStatus.</param>
        /// <param name="nodesUsers">nodesUsers.</param>
        /// <param name="sslVpnNodesUsers">sslVpnNodesUsers.</param>
        /// <param name="virtualAssistNodesUsers">virtualAssistNodesUsers.</param>
        /// <param name="endPointControl">endPointControl.</param>
        /// <param name="vpn">vpn.</param>
        /// <param name="globalVpnClient">globalVpnClient.</param>
        /// <param name="cfsContentFilter">cfsContentFilter.</param>
        /// <param name="expandedFeatureSet">expandedFeatureSet.</param>
        /// <param name="endpointSecurity">endpointSecurity.</param>
        /// <param name="gatewayAntiVirus">gatewayAntiVirus.</param>
        /// <param name="captureAtp">captureAtp.</param>
        /// <param name="antiSpyware">antiSpyware.</param>
        /// <param name="intrusionPrevention">intrusionPrevention.</param>
        /// <param name="appControl">appControl.</param>
        /// <param name="appVisualization">appVisualization.</param>
        /// <param name="eMailFilter">eMailFilter.</param>
        /// <param name="antiSpam">antiSpam.</param>
        /// <param name="viewPoint">viewPoint.</param>
        /// <param name="analyzer">analyzer.</param>
        /// <param name="dpiSsl">dpiSsl.</param>
        /// <param name="dpiSsh">dpiSsh.</param>
        /// <param name="wanAcceleration">wanAcceleration.</param>
        /// <param name="wxacAcceleration">wxacAcceleration.</param>
        /// <param name="botnet">botnet.</param>
        public ShowStatusSystemSecurityDetail(string noRegistNodesUsers = default(string), string noRegistSslVpnNodesUsers = default(string), string noRegistVirtualAssistNodesUsers = default(string), string registrationStatus = default(string), string nodesUsers = default(string), string sslVpnNodesUsers = default(string), string virtualAssistNodesUsers = default(string), string endPointControl = default(string), string vpn = default(string), string globalVpnClient = default(string), string cfsContentFilter = default(string), string expandedFeatureSet = default(string), string endpointSecurity = default(string), string gatewayAntiVirus = default(string), string captureAtp = default(string), string antiSpyware = default(string), string intrusionPrevention = default(string), string appControl = default(string), string appVisualization = default(string), string eMailFilter = default(string), string antiSpam = default(string), string viewPoint = default(string), string analyzer = default(string), string dpiSsl = default(string), string dpiSsh = default(string), string wanAcceleration = default(string), string wxacAcceleration = default(string), string botnet = default(string))
        {
            this.NoRegistNodesUsers = noRegistNodesUsers;
            this.NoRegistSslVpnNodesUsers = noRegistSslVpnNodesUsers;
            this.NoRegistVirtualAssistNodesUsers = noRegistVirtualAssistNodesUsers;
            this.RegistrationStatus = registrationStatus;
            this.NodesUsers = nodesUsers;
            this.SslVpnNodesUsers = sslVpnNodesUsers;
            this.VirtualAssistNodesUsers = virtualAssistNodesUsers;
            this.EndPointControl = endPointControl;
            this.Vpn = vpn;
            this.GlobalVpnClient = globalVpnClient;
            this.CfsContentFilter = cfsContentFilter;
            this.ExpandedFeatureSet = expandedFeatureSet;
            this.EndpointSecurity = endpointSecurity;
            this.GatewayAntiVirus = gatewayAntiVirus;
            this.CaptureAtp = captureAtp;
            this.AntiSpyware = antiSpyware;
            this.IntrusionPrevention = intrusionPrevention;
            this.AppControl = appControl;
            this.AppVisualization = appVisualization;
            this.EMailFilter = eMailFilter;
            this.AntiSpam = antiSpam;
            this.ViewPoint = viewPoint;
            this.Analyzer = analyzer;
            this.DpiSsl = dpiSsl;
            this.DpiSsh = dpiSsh;
            this.WanAcceleration = wanAcceleration;
            this.WxacAcceleration = wxacAcceleration;
            this.Botnet = botnet;
        }

        /// <summary>
        /// Gets or Sets NoRegistNodesUsers
        /// </summary>
        [DataMember(Name = "no_regist_nodes_users", EmitDefaultValue = false)]
        public string NoRegistNodesUsers { get; set; }

        /// <summary>
        /// Gets or Sets NoRegistSslVpnNodesUsers
        /// </summary>
        [DataMember(Name = "no_regist_ssl_vpn_nodes_users", EmitDefaultValue = false)]
        public string NoRegistSslVpnNodesUsers { get; set; }

        /// <summary>
        /// Gets or Sets NoRegistVirtualAssistNodesUsers
        /// </summary>
        [DataMember(Name = "no_regist_virtual_assist_nodes_users", EmitDefaultValue = false)]
        public string NoRegistVirtualAssistNodesUsers { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationStatus
        /// </summary>
        [DataMember(Name = "registration_status", EmitDefaultValue = false)]
        public string RegistrationStatus { get; set; }

        /// <summary>
        /// Gets or Sets NodesUsers
        /// </summary>
        [DataMember(Name = "nodes_users", EmitDefaultValue = false)]
        public string NodesUsers { get; set; }

        /// <summary>
        /// Gets or Sets SslVpnNodesUsers
        /// </summary>
        [DataMember(Name = "ssl_vpn_nodes_users", EmitDefaultValue = false)]
        public string SslVpnNodesUsers { get; set; }

        /// <summary>
        /// Gets or Sets VirtualAssistNodesUsers
        /// </summary>
        [DataMember(Name = "virtual_assist_nodes_users", EmitDefaultValue = false)]
        public string VirtualAssistNodesUsers { get; set; }

        /// <summary>
        /// Gets or Sets EndPointControl
        /// </summary>
        [DataMember(Name = "end_point_control", EmitDefaultValue = false)]
        public string EndPointControl { get; set; }

        /// <summary>
        /// Gets or Sets Vpn
        /// </summary>
        [DataMember(Name = "vpn", EmitDefaultValue = false)]
        public string Vpn { get; set; }

        /// <summary>
        /// Gets or Sets GlobalVpnClient
        /// </summary>
        [DataMember(Name = "global_vpn_client", EmitDefaultValue = false)]
        public string GlobalVpnClient { get; set; }

        /// <summary>
        /// Gets or Sets CfsContentFilter
        /// </summary>
        [DataMember(Name = "cfs_content_filter", EmitDefaultValue = false)]
        public string CfsContentFilter { get; set; }

        /// <summary>
        /// Gets or Sets ExpandedFeatureSet
        /// </summary>
        [DataMember(Name = "expanded_feature_set", EmitDefaultValue = false)]
        public string ExpandedFeatureSet { get; set; }

        /// <summary>
        /// Gets or Sets EndpointSecurity
        /// </summary>
        [DataMember(Name = "endpoint_security", EmitDefaultValue = false)]
        public string EndpointSecurity { get; set; }

        /// <summary>
        /// Gets or Sets GatewayAntiVirus
        /// </summary>
        [DataMember(Name = "gateway_anti_virus", EmitDefaultValue = false)]
        public string GatewayAntiVirus { get; set; }

        /// <summary>
        /// Gets or Sets CaptureAtp
        /// </summary>
        [DataMember(Name = "capture_atp", EmitDefaultValue = false)]
        public string CaptureAtp { get; set; }

        /// <summary>
        /// Gets or Sets AntiSpyware
        /// </summary>
        [DataMember(Name = "anti_spyware", EmitDefaultValue = false)]
        public string AntiSpyware { get; set; }

        /// <summary>
        /// Gets or Sets IntrusionPrevention
        /// </summary>
        [DataMember(Name = "intrusion_prevention", EmitDefaultValue = false)]
        public string IntrusionPrevention { get; set; }

        /// <summary>
        /// Gets or Sets AppControl
        /// </summary>
        [DataMember(Name = "app_control", EmitDefaultValue = false)]
        public string AppControl { get; set; }

        /// <summary>
        /// Gets or Sets AppVisualization
        /// </summary>
        [DataMember(Name = "app_visualization", EmitDefaultValue = false)]
        public string AppVisualization { get; set; }

        /// <summary>
        /// Gets or Sets EMailFilter
        /// </summary>
        [DataMember(Name = "e_mail_filter", EmitDefaultValue = false)]
        public string EMailFilter { get; set; }

        /// <summary>
        /// Gets or Sets AntiSpam
        /// </summary>
        [DataMember(Name = "anti_spam", EmitDefaultValue = false)]
        public string AntiSpam { get; set; }

        /// <summary>
        /// Gets or Sets ViewPoint
        /// </summary>
        [DataMember(Name = "view_point", EmitDefaultValue = false)]
        public string ViewPoint { get; set; }

        /// <summary>
        /// Gets or Sets Analyzer
        /// </summary>
        [DataMember(Name = "analyzer", EmitDefaultValue = false)]
        public string Analyzer { get; set; }

        /// <summary>
        /// Gets or Sets DpiSsl
        /// </summary>
        [DataMember(Name = "dpi_ssl", EmitDefaultValue = false)]
        public string DpiSsl { get; set; }

        /// <summary>
        /// Gets or Sets DpiSsh
        /// </summary>
        [DataMember(Name = "dpi_ssh", EmitDefaultValue = false)]
        public string DpiSsh { get; set; }

        /// <summary>
        /// Gets or Sets WanAcceleration
        /// </summary>
        [DataMember(Name = "wan_acceleration", EmitDefaultValue = false)]
        public string WanAcceleration { get; set; }

        /// <summary>
        /// Gets or Sets WxacAcceleration
        /// </summary>
        [DataMember(Name = "wxac_acceleration", EmitDefaultValue = false)]
        public string WxacAcceleration { get; set; }

        /// <summary>
        /// Gets or Sets Botnet
        /// </summary>
        [DataMember(Name = "botnet", EmitDefaultValue = false)]
        public string Botnet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusSystemSecurityDetail {\n");
            sb.Append("  NoRegistNodesUsers: ").Append(NoRegistNodesUsers).Append("\n");
            sb.Append("  NoRegistSslVpnNodesUsers: ").Append(NoRegistSslVpnNodesUsers).Append("\n");
            sb.Append("  NoRegistVirtualAssistNodesUsers: ").Append(NoRegistVirtualAssistNodesUsers).Append("\n");
            sb.Append("  RegistrationStatus: ").Append(RegistrationStatus).Append("\n");
            sb.Append("  NodesUsers: ").Append(NodesUsers).Append("\n");
            sb.Append("  SslVpnNodesUsers: ").Append(SslVpnNodesUsers).Append("\n");
            sb.Append("  VirtualAssistNodesUsers: ").Append(VirtualAssistNodesUsers).Append("\n");
            sb.Append("  EndPointControl: ").Append(EndPointControl).Append("\n");
            sb.Append("  Vpn: ").Append(Vpn).Append("\n");
            sb.Append("  GlobalVpnClient: ").Append(GlobalVpnClient).Append("\n");
            sb.Append("  CfsContentFilter: ").Append(CfsContentFilter).Append("\n");
            sb.Append("  ExpandedFeatureSet: ").Append(ExpandedFeatureSet).Append("\n");
            sb.Append("  EndpointSecurity: ").Append(EndpointSecurity).Append("\n");
            sb.Append("  GatewayAntiVirus: ").Append(GatewayAntiVirus).Append("\n");
            sb.Append("  CaptureAtp: ").Append(CaptureAtp).Append("\n");
            sb.Append("  AntiSpyware: ").Append(AntiSpyware).Append("\n");
            sb.Append("  IntrusionPrevention: ").Append(IntrusionPrevention).Append("\n");
            sb.Append("  AppControl: ").Append(AppControl).Append("\n");
            sb.Append("  AppVisualization: ").Append(AppVisualization).Append("\n");
            sb.Append("  EMailFilter: ").Append(EMailFilter).Append("\n");
            sb.Append("  AntiSpam: ").Append(AntiSpam).Append("\n");
            sb.Append("  ViewPoint: ").Append(ViewPoint).Append("\n");
            sb.Append("  Analyzer: ").Append(Analyzer).Append("\n");
            sb.Append("  DpiSsl: ").Append(DpiSsl).Append("\n");
            sb.Append("  DpiSsh: ").Append(DpiSsh).Append("\n");
            sb.Append("  WanAcceleration: ").Append(WanAcceleration).Append("\n");
            sb.Append("  WxacAcceleration: ").Append(WxacAcceleration).Append("\n");
            sb.Append("  Botnet: ").Append(Botnet).Append("\n");
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
            return this.Equals(input as ShowStatusSystemSecurityDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusSystemSecurityDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusSystemSecurityDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusSystemSecurityDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NoRegistNodesUsers == input.NoRegistNodesUsers ||
                    (this.NoRegistNodesUsers != null &&
                    this.NoRegistNodesUsers.Equals(input.NoRegistNodesUsers))
                ) && 
                (
                    this.NoRegistSslVpnNodesUsers == input.NoRegistSslVpnNodesUsers ||
                    (this.NoRegistSslVpnNodesUsers != null &&
                    this.NoRegistSslVpnNodesUsers.Equals(input.NoRegistSslVpnNodesUsers))
                ) && 
                (
                    this.NoRegistVirtualAssistNodesUsers == input.NoRegistVirtualAssistNodesUsers ||
                    (this.NoRegistVirtualAssistNodesUsers != null &&
                    this.NoRegistVirtualAssistNodesUsers.Equals(input.NoRegistVirtualAssistNodesUsers))
                ) && 
                (
                    this.RegistrationStatus == input.RegistrationStatus ||
                    (this.RegistrationStatus != null &&
                    this.RegistrationStatus.Equals(input.RegistrationStatus))
                ) && 
                (
                    this.NodesUsers == input.NodesUsers ||
                    (this.NodesUsers != null &&
                    this.NodesUsers.Equals(input.NodesUsers))
                ) && 
                (
                    this.SslVpnNodesUsers == input.SslVpnNodesUsers ||
                    (this.SslVpnNodesUsers != null &&
                    this.SslVpnNodesUsers.Equals(input.SslVpnNodesUsers))
                ) && 
                (
                    this.VirtualAssistNodesUsers == input.VirtualAssistNodesUsers ||
                    (this.VirtualAssistNodesUsers != null &&
                    this.VirtualAssistNodesUsers.Equals(input.VirtualAssistNodesUsers))
                ) && 
                (
                    this.EndPointControl == input.EndPointControl ||
                    (this.EndPointControl != null &&
                    this.EndPointControl.Equals(input.EndPointControl))
                ) && 
                (
                    this.Vpn == input.Vpn ||
                    (this.Vpn != null &&
                    this.Vpn.Equals(input.Vpn))
                ) && 
                (
                    this.GlobalVpnClient == input.GlobalVpnClient ||
                    (this.GlobalVpnClient != null &&
                    this.GlobalVpnClient.Equals(input.GlobalVpnClient))
                ) && 
                (
                    this.CfsContentFilter == input.CfsContentFilter ||
                    (this.CfsContentFilter != null &&
                    this.CfsContentFilter.Equals(input.CfsContentFilter))
                ) && 
                (
                    this.ExpandedFeatureSet == input.ExpandedFeatureSet ||
                    (this.ExpandedFeatureSet != null &&
                    this.ExpandedFeatureSet.Equals(input.ExpandedFeatureSet))
                ) && 
                (
                    this.EndpointSecurity == input.EndpointSecurity ||
                    (this.EndpointSecurity != null &&
                    this.EndpointSecurity.Equals(input.EndpointSecurity))
                ) && 
                (
                    this.GatewayAntiVirus == input.GatewayAntiVirus ||
                    (this.GatewayAntiVirus != null &&
                    this.GatewayAntiVirus.Equals(input.GatewayAntiVirus))
                ) && 
                (
                    this.CaptureAtp == input.CaptureAtp ||
                    (this.CaptureAtp != null &&
                    this.CaptureAtp.Equals(input.CaptureAtp))
                ) && 
                (
                    this.AntiSpyware == input.AntiSpyware ||
                    (this.AntiSpyware != null &&
                    this.AntiSpyware.Equals(input.AntiSpyware))
                ) && 
                (
                    this.IntrusionPrevention == input.IntrusionPrevention ||
                    (this.IntrusionPrevention != null &&
                    this.IntrusionPrevention.Equals(input.IntrusionPrevention))
                ) && 
                (
                    this.AppControl == input.AppControl ||
                    (this.AppControl != null &&
                    this.AppControl.Equals(input.AppControl))
                ) && 
                (
                    this.AppVisualization == input.AppVisualization ||
                    (this.AppVisualization != null &&
                    this.AppVisualization.Equals(input.AppVisualization))
                ) && 
                (
                    this.EMailFilter == input.EMailFilter ||
                    (this.EMailFilter != null &&
                    this.EMailFilter.Equals(input.EMailFilter))
                ) && 
                (
                    this.AntiSpam == input.AntiSpam ||
                    (this.AntiSpam != null &&
                    this.AntiSpam.Equals(input.AntiSpam))
                ) && 
                (
                    this.ViewPoint == input.ViewPoint ||
                    (this.ViewPoint != null &&
                    this.ViewPoint.Equals(input.ViewPoint))
                ) && 
                (
                    this.Analyzer == input.Analyzer ||
                    (this.Analyzer != null &&
                    this.Analyzer.Equals(input.Analyzer))
                ) && 
                (
                    this.DpiSsl == input.DpiSsl ||
                    (this.DpiSsl != null &&
                    this.DpiSsl.Equals(input.DpiSsl))
                ) && 
                (
                    this.DpiSsh == input.DpiSsh ||
                    (this.DpiSsh != null &&
                    this.DpiSsh.Equals(input.DpiSsh))
                ) && 
                (
                    this.WanAcceleration == input.WanAcceleration ||
                    (this.WanAcceleration != null &&
                    this.WanAcceleration.Equals(input.WanAcceleration))
                ) && 
                (
                    this.WxacAcceleration == input.WxacAcceleration ||
                    (this.WxacAcceleration != null &&
                    this.WxacAcceleration.Equals(input.WxacAcceleration))
                ) && 
                (
                    this.Botnet == input.Botnet ||
                    (this.Botnet != null &&
                    this.Botnet.Equals(input.Botnet))
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
                if (this.NoRegistNodesUsers != null)
                {
                    hashCode = (hashCode * 59) + this.NoRegistNodesUsers.GetHashCode();
                }
                if (this.NoRegistSslVpnNodesUsers != null)
                {
                    hashCode = (hashCode * 59) + this.NoRegistSslVpnNodesUsers.GetHashCode();
                }
                if (this.NoRegistVirtualAssistNodesUsers != null)
                {
                    hashCode = (hashCode * 59) + this.NoRegistVirtualAssistNodesUsers.GetHashCode();
                }
                if (this.RegistrationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationStatus.GetHashCode();
                }
                if (this.NodesUsers != null)
                {
                    hashCode = (hashCode * 59) + this.NodesUsers.GetHashCode();
                }
                if (this.SslVpnNodesUsers != null)
                {
                    hashCode = (hashCode * 59) + this.SslVpnNodesUsers.GetHashCode();
                }
                if (this.VirtualAssistNodesUsers != null)
                {
                    hashCode = (hashCode * 59) + this.VirtualAssistNodesUsers.GetHashCode();
                }
                if (this.EndPointControl != null)
                {
                    hashCode = (hashCode * 59) + this.EndPointControl.GetHashCode();
                }
                if (this.Vpn != null)
                {
                    hashCode = (hashCode * 59) + this.Vpn.GetHashCode();
                }
                if (this.GlobalVpnClient != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalVpnClient.GetHashCode();
                }
                if (this.CfsContentFilter != null)
                {
                    hashCode = (hashCode * 59) + this.CfsContentFilter.GetHashCode();
                }
                if (this.ExpandedFeatureSet != null)
                {
                    hashCode = (hashCode * 59) + this.ExpandedFeatureSet.GetHashCode();
                }
                if (this.EndpointSecurity != null)
                {
                    hashCode = (hashCode * 59) + this.EndpointSecurity.GetHashCode();
                }
                if (this.GatewayAntiVirus != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayAntiVirus.GetHashCode();
                }
                if (this.CaptureAtp != null)
                {
                    hashCode = (hashCode * 59) + this.CaptureAtp.GetHashCode();
                }
                if (this.AntiSpyware != null)
                {
                    hashCode = (hashCode * 59) + this.AntiSpyware.GetHashCode();
                }
                if (this.IntrusionPrevention != null)
                {
                    hashCode = (hashCode * 59) + this.IntrusionPrevention.GetHashCode();
                }
                if (this.AppControl != null)
                {
                    hashCode = (hashCode * 59) + this.AppControl.GetHashCode();
                }
                if (this.AppVisualization != null)
                {
                    hashCode = (hashCode * 59) + this.AppVisualization.GetHashCode();
                }
                if (this.EMailFilter != null)
                {
                    hashCode = (hashCode * 59) + this.EMailFilter.GetHashCode();
                }
                if (this.AntiSpam != null)
                {
                    hashCode = (hashCode * 59) + this.AntiSpam.GetHashCode();
                }
                if (this.ViewPoint != null)
                {
                    hashCode = (hashCode * 59) + this.ViewPoint.GetHashCode();
                }
                if (this.Analyzer != null)
                {
                    hashCode = (hashCode * 59) + this.Analyzer.GetHashCode();
                }
                if (this.DpiSsl != null)
                {
                    hashCode = (hashCode * 59) + this.DpiSsl.GetHashCode();
                }
                if (this.DpiSsh != null)
                {
                    hashCode = (hashCode * 59) + this.DpiSsh.GetHashCode();
                }
                if (this.WanAcceleration != null)
                {
                    hashCode = (hashCode * 59) + this.WanAcceleration.GetHashCode();
                }
                if (this.WxacAcceleration != null)
                {
                    hashCode = (hashCode * 59) + this.WxacAcceleration.GetHashCode();
                }
                if (this.Botnet != null)
                {
                    hashCode = (hashCode * 59) + this.Botnet.GetHashCode();
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
