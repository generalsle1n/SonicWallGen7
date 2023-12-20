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
    /// Tech support report options.
    /// </summary>
    [DataContract(Name = "tsr_options_tech_support_report_options")]
    public partial class TsrOptionsTechSupportReportOptions : IEquatable<TsrOptionsTechSupportReportOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsrOptionsTechSupportReportOptions" /> class.
        /// </summary>
        /// <param name="sensitiveKeys">Enable display of sensitive keys in tech support report..</param>
        /// <param name="arpCache">Enable display of ARP cache in tech support report..</param>
        /// <param name="dhcpBindings">Enable display of DHCP bindings in tech support report..</param>
        /// <param name="ikeInfo">Enable display of IKE information in tech support report..</param>
        /// <param name="users">users.</param>
        /// <param name="ipStackInfo">Enable display of IP stack info in tech support report..</param>
        /// <param name="SonicDnsProxyCache">Enable display of SonicDns proxy cache info in tech support report..</param>
        /// <param name="debugInfo">Enable display of debug info in tech support report..</param>
        /// <param name="userName">Enable display of user name in tech support report..</param>
        /// <param name="ipv6">ipv6.</param>
        /// <param name="geoIpCache">Enable display of geo-ip/botnet cache in report in tech support report..</param>
        /// <param name="extraRouting">Enable display of additional routing commands output in tech support report..</param>
        /// <param name="atpCache">Enable display of Capture ATP cache in tech support report..</param>
        /// <param name="vendorOui">Enable display of vendor name resolution in tech support report..</param>
        /// <param name="ipReport">Disable display of Ip Report in tech support report..</param>
        /// <param name="applicationSignature">Enable  display of application signature in tech support report..</param>
        /// <param name="abrEntries">Enable display of ABR entries in tech support report..</param>
        /// <param name="securedCrashAnalysis">Enable automatic report secure crash analysis..</param>
        /// <param name="secureBackup">secureBackup.</param>
        /// <param name="cscReportTimeInterval">Set csc reporting time interval (minutes)..</param>
        /// <param name="sendRawFlowData">Enable include raw flow table data entries when sending diagnostic report..</param>
        public TsrOptionsTechSupportReportOptions(bool sensitiveKeys = default(bool), bool arpCache = default(bool), bool dhcpBindings = default(bool), bool ikeInfo = default(bool), TsrOptionsTechSupportReportOptionsUsers users = default(TsrOptionsTechSupportReportOptionsUsers), bool ipStackInfo = default(bool), bool SonicDnsProxyCache = default(bool), bool debugInfo = default(bool), bool userName = default(bool), TsrOptionsTechSupportReportOptionsIpv6 ipv6 = default(TsrOptionsTechSupportReportOptionsIpv6), bool geoIpCache = default(bool), bool extraRouting = default(bool), bool atpCache = default(bool), bool vendorOui = default(bool), bool ipReport = default(bool), bool applicationSignature = default(bool), bool abrEntries = default(bool), bool securedCrashAnalysis = default(bool), TsrOptionsTechSupportReportOptionsSecureBackup secureBackup = default(TsrOptionsTechSupportReportOptionsSecureBackup), decimal cscReportTimeInterval = default(decimal), bool sendRawFlowData = default(bool))
        {
            this.SensitiveKeys = sensitiveKeys;
            this.ArpCache = arpCache;
            this.DhcpBindings = dhcpBindings;
            this.IkeInfo = ikeInfo;
            this.Users = users;
            this.IpStackInfo = ipStackInfo;
            this.SonicDnsProxyCache = SonicDnsProxyCache;
            this.DebugInfo = debugInfo;
            this.UserName = userName;
            this.Ipv6 = ipv6;
            this.GeoIpCache = geoIpCache;
            this.ExtraRouting = extraRouting;
            this.AtpCache = atpCache;
            this.VendorOui = vendorOui;
            this.IpReport = ipReport;
            this.ApplicationSignature = applicationSignature;
            this.AbrEntries = abrEntries;
            this.SecuredCrashAnalysis = securedCrashAnalysis;
            this.SecureBackup = secureBackup;
            this.CscReportTimeInterval = cscReportTimeInterval;
            this.SendRawFlowData = sendRawFlowData;
        }

        /// <summary>
        /// Enable display of sensitive keys in tech support report.
        /// </summary>
        /// <value>Enable display of sensitive keys in tech support report.</value>
        [DataMember(Name = "sensitive_keys", EmitDefaultValue = true)]
        public bool SensitiveKeys { get; set; }

        /// <summary>
        /// Enable display of ARP cache in tech support report.
        /// </summary>
        /// <value>Enable display of ARP cache in tech support report.</value>
        [DataMember(Name = "arp_cache", EmitDefaultValue = true)]
        public bool ArpCache { get; set; }

        /// <summary>
        /// Enable display of DHCP bindings in tech support report.
        /// </summary>
        /// <value>Enable display of DHCP bindings in tech support report.</value>
        [DataMember(Name = "dhcp_bindings", EmitDefaultValue = true)]
        public bool DhcpBindings { get; set; }

        /// <summary>
        /// Enable display of IKE information in tech support report.
        /// </summary>
        /// <value>Enable display of IKE information in tech support report.</value>
        [DataMember(Name = "ike_info", EmitDefaultValue = true)]
        public bool IkeInfo { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public TsrOptionsTechSupportReportOptionsUsers Users { get; set; }

        /// <summary>
        /// Enable display of IP stack info in tech support report.
        /// </summary>
        /// <value>Enable display of IP stack info in tech support report.</value>
        [DataMember(Name = "ip_stack_info", EmitDefaultValue = true)]
        public bool IpStackInfo { get; set; }

        /// <summary>
        /// Enable display of SonicDns proxy cache info in tech support report.
        /// </summary>
        /// <value>Enable display of SonicDns proxy cache info in tech support report.</value>
        [DataMember(Name = "SonicDns_proxy_cache", EmitDefaultValue = true)]
        public bool SonicDnsProxyCache { get; set; }

        /// <summary>
        /// Enable display of debug info in tech support report.
        /// </summary>
        /// <value>Enable display of debug info in tech support report.</value>
        [DataMember(Name = "debug_info", EmitDefaultValue = true)]
        public bool DebugInfo { get; set; }

        /// <summary>
        /// Enable display of user name in tech support report.
        /// </summary>
        /// <value>Enable display of user name in tech support report.</value>
        [DataMember(Name = "user_name", EmitDefaultValue = true)]
        public bool UserName { get; set; }

        /// <summary>
        /// Gets or Sets Ipv6
        /// </summary>
        [DataMember(Name = "ipv6", EmitDefaultValue = false)]
        public TsrOptionsTechSupportReportOptionsIpv6 Ipv6 { get; set; }

        /// <summary>
        /// Enable display of geo-ip/botnet cache in report in tech support report.
        /// </summary>
        /// <value>Enable display of geo-ip/botnet cache in report in tech support report.</value>
        [DataMember(Name = "geo_ip_cache", EmitDefaultValue = true)]
        public bool GeoIpCache { get; set; }

        /// <summary>
        /// Enable display of additional routing commands output in tech support report.
        /// </summary>
        /// <value>Enable display of additional routing commands output in tech support report.</value>
        [DataMember(Name = "extra_routing", EmitDefaultValue = true)]
        public bool ExtraRouting { get; set; }

        /// <summary>
        /// Enable display of Capture ATP cache in tech support report.
        /// </summary>
        /// <value>Enable display of Capture ATP cache in tech support report.</value>
        [DataMember(Name = "atp_cache", EmitDefaultValue = true)]
        public bool AtpCache { get; set; }

        /// <summary>
        /// Enable display of vendor name resolution in tech support report.
        /// </summary>
        /// <value>Enable display of vendor name resolution in tech support report.</value>
        [DataMember(Name = "vendor_oui", EmitDefaultValue = true)]
        public bool VendorOui { get; set; }

        /// <summary>
        /// Disable display of Ip Report in tech support report.
        /// </summary>
        /// <value>Disable display of Ip Report in tech support report.</value>
        [DataMember(Name = "ip_report", EmitDefaultValue = true)]
        public bool IpReport { get; set; }

        /// <summary>
        /// Enable  display of application signature in tech support report.
        /// </summary>
        /// <value>Enable  display of application signature in tech support report.</value>
        [DataMember(Name = "application_signature", EmitDefaultValue = true)]
        public bool ApplicationSignature { get; set; }

        /// <summary>
        /// Enable display of ABR entries in tech support report.
        /// </summary>
        /// <value>Enable display of ABR entries in tech support report.</value>
        [DataMember(Name = "abr_entries", EmitDefaultValue = true)]
        public bool AbrEntries { get; set; }

        /// <summary>
        /// Enable automatic report secure crash analysis.
        /// </summary>
        /// <value>Enable automatic report secure crash analysis.</value>
        [DataMember(Name = "secured_crash_analysis", EmitDefaultValue = true)]
        public bool SecuredCrashAnalysis { get; set; }

        /// <summary>
        /// Gets or Sets SecureBackup
        /// </summary>
        [DataMember(Name = "secure_backup", EmitDefaultValue = true)]
        public TsrOptionsTechSupportReportOptionsSecureBackup SecureBackup { get; set; }

        /// <summary>
        /// Set csc reporting time interval (minutes).
        /// </summary>
        /// <value>Set csc reporting time interval (minutes).</value>
        [DataMember(Name = "csc_report_time_interval", EmitDefaultValue = false)]
        public decimal CscReportTimeInterval { get; set; }

        /// <summary>
        /// Enable include raw flow table data entries when sending diagnostic report.
        /// </summary>
        /// <value>Enable include raw flow table data entries when sending diagnostic report.</value>
        [DataMember(Name = "send_raw_flow_data", EmitDefaultValue = true)]
        public bool SendRawFlowData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TsrOptionsTechSupportReportOptions {\n");
            sb.Append("  SensitiveKeys: ").Append(SensitiveKeys).Append("\n");
            sb.Append("  ArpCache: ").Append(ArpCache).Append("\n");
            sb.Append("  DhcpBindings: ").Append(DhcpBindings).Append("\n");
            sb.Append("  IkeInfo: ").Append(IkeInfo).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  IpStackInfo: ").Append(IpStackInfo).Append("\n");
            sb.Append("  SonicDnsProxyCache: ").Append(SonicDnsProxyCache).Append("\n");
            sb.Append("  DebugInfo: ").Append(DebugInfo).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Ipv6: ").Append(Ipv6).Append("\n");
            sb.Append("  GeoIpCache: ").Append(GeoIpCache).Append("\n");
            sb.Append("  ExtraRouting: ").Append(ExtraRouting).Append("\n");
            sb.Append("  AtpCache: ").Append(AtpCache).Append("\n");
            sb.Append("  VendorOui: ").Append(VendorOui).Append("\n");
            sb.Append("  IpReport: ").Append(IpReport).Append("\n");
            sb.Append("  ApplicationSignature: ").Append(ApplicationSignature).Append("\n");
            sb.Append("  AbrEntries: ").Append(AbrEntries).Append("\n");
            sb.Append("  SecuredCrashAnalysis: ").Append(SecuredCrashAnalysis).Append("\n");
            sb.Append("  SecureBackup: ").Append(SecureBackup).Append("\n");
            sb.Append("  CscReportTimeInterval: ").Append(CscReportTimeInterval).Append("\n");
            sb.Append("  SendRawFlowData: ").Append(SendRawFlowData).Append("\n");
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
            return this.Equals(input as TsrOptionsTechSupportReportOptions);
        }

        /// <summary>
        /// Returns true if TsrOptionsTechSupportReportOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of TsrOptionsTechSupportReportOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsrOptionsTechSupportReportOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SensitiveKeys == input.SensitiveKeys ||
                    this.SensitiveKeys.Equals(input.SensitiveKeys)
                ) && 
                (
                    this.ArpCache == input.ArpCache ||
                    this.ArpCache.Equals(input.ArpCache)
                ) && 
                (
                    this.DhcpBindings == input.DhcpBindings ||
                    this.DhcpBindings.Equals(input.DhcpBindings)
                ) && 
                (
                    this.IkeInfo == input.IkeInfo ||
                    this.IkeInfo.Equals(input.IkeInfo)
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.IpStackInfo == input.IpStackInfo ||
                    this.IpStackInfo.Equals(input.IpStackInfo)
                ) && 
                (
                    this.SonicDnsProxyCache == input.SonicDnsProxyCache ||
                    this.SonicDnsProxyCache.Equals(input.SonicDnsProxyCache)
                ) && 
                (
                    this.DebugInfo == input.DebugInfo ||
                    this.DebugInfo.Equals(input.DebugInfo)
                ) && 
                (
                    this.UserName == input.UserName ||
                    this.UserName.Equals(input.UserName)
                ) && 
                (
                    this.Ipv6 == input.Ipv6 ||
                    (this.Ipv6 != null &&
                    this.Ipv6.Equals(input.Ipv6))
                ) && 
                (
                    this.GeoIpCache == input.GeoIpCache ||
                    this.GeoIpCache.Equals(input.GeoIpCache)
                ) && 
                (
                    this.ExtraRouting == input.ExtraRouting ||
                    this.ExtraRouting.Equals(input.ExtraRouting)
                ) && 
                (
                    this.AtpCache == input.AtpCache ||
                    this.AtpCache.Equals(input.AtpCache)
                ) && 
                (
                    this.VendorOui == input.VendorOui ||
                    this.VendorOui.Equals(input.VendorOui)
                ) && 
                (
                    this.IpReport == input.IpReport ||
                    this.IpReport.Equals(input.IpReport)
                ) && 
                (
                    this.ApplicationSignature == input.ApplicationSignature ||
                    this.ApplicationSignature.Equals(input.ApplicationSignature)
                ) && 
                (
                    this.AbrEntries == input.AbrEntries ||
                    this.AbrEntries.Equals(input.AbrEntries)
                ) && 
                (
                    this.SecuredCrashAnalysis == input.SecuredCrashAnalysis ||
                    this.SecuredCrashAnalysis.Equals(input.SecuredCrashAnalysis)
                ) && 
                (
                    this.SecureBackup == input.SecureBackup ||
                    (this.SecureBackup != null &&
                    this.SecureBackup.Equals(input.SecureBackup))
                ) && 
                (
                    this.CscReportTimeInterval == input.CscReportTimeInterval ||
                    this.CscReportTimeInterval.Equals(input.CscReportTimeInterval)
                ) && 
                (
                    this.SendRawFlowData == input.SendRawFlowData ||
                    this.SendRawFlowData.Equals(input.SendRawFlowData)
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
                hashCode = (hashCode * 59) + this.SensitiveKeys.GetHashCode();
                hashCode = (hashCode * 59) + this.ArpCache.GetHashCode();
                hashCode = (hashCode * 59) + this.DhcpBindings.GetHashCode();
                hashCode = (hashCode * 59) + this.IkeInfo.GetHashCode();
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IpStackInfo.GetHashCode();
                hashCode = (hashCode * 59) + this.SonicDnsProxyCache.GetHashCode();
                hashCode = (hashCode * 59) + this.DebugInfo.GetHashCode();
                hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                if (this.Ipv6 != null)
                {
                    hashCode = (hashCode * 59) + this.Ipv6.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GeoIpCache.GetHashCode();
                hashCode = (hashCode * 59) + this.ExtraRouting.GetHashCode();
                hashCode = (hashCode * 59) + this.AtpCache.GetHashCode();
                hashCode = (hashCode * 59) + this.VendorOui.GetHashCode();
                hashCode = (hashCode * 59) + this.IpReport.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplicationSignature.GetHashCode();
                hashCode = (hashCode * 59) + this.AbrEntries.GetHashCode();
                hashCode = (hashCode * 59) + this.SecuredCrashAnalysis.GetHashCode();
                if (this.SecureBackup != null)
                {
                    hashCode = (hashCode * 59) + this.SecureBackup.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CscReportTimeInterval.GetHashCode();
                hashCode = (hashCode * 59) + this.SendRawFlowData.GetHashCode();
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
