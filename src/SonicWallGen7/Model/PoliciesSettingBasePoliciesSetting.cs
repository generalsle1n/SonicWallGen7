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
    /// Enter policies setting configuration mode.
    /// </summary>
    [DataContract(Name = "policies_setting_base_policies_setting")]
    public partial class PoliciesSettingBasePoliciesSetting : IEquatable<PoliciesSettingBasePoliciesSetting>, IValidatableObject
    {
        /// <summary>
        /// Set application, custom match and malware (threats, virus and spyware) control plus prevention mode.
        /// </summary>
        /// <value>Set application, custom match and malware (threats, virus and spyware) control plus prevention mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppCustomMalwareModeEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set application, custom match and malware (threats, virus and spyware) control plus prevention mode.
        /// </summary>
        /// <value>Set application, custom match and malware (threats, virus and spyware) control plus prevention mode.</value>
        [DataMember(Name = "app_custom_malware_mode", EmitDefaultValue = false)]
        public AppCustomMalwareModeEnum? AppCustomMalwareMode { get; set; }
        /// <summary>
        /// Set what application classification (identification) is based on.
        /// </summary>
        /// <value>Set what application classification (identification) is based on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationBasedOnEnum
        {
            /// <summary>
            /// Enum Zone for value: zone
            /// </summary>
            [EnumMember(Value = "zone")]
            Zone = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set what application classification (identification) is based on.
        /// </summary>
        /// <value>Set what application classification (identification) is based on.</value>
        [DataMember(Name = "application_based_on", EmitDefaultValue = false)]
        public ApplicationBasedOnEnum? ApplicationBasedOn { get; set; }
        /// <summary>
        /// Set what threat detection and prevention is based on.
        /// </summary>
        /// <value>Set what threat detection and prevention is based on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ThreatBasedOnEnum
        {
            /// <summary>
            /// Enum Zone for value: zone
            /// </summary>
            [EnumMember(Value = "zone")]
            Zone = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set what threat detection and prevention is based on.
        /// </summary>
        /// <value>Set what threat detection and prevention is based on.</value>
        [DataMember(Name = "threat_based_on", EmitDefaultValue = false)]
        public ThreatBasedOnEnum? ThreatBasedOn { get; set; }
        /// <summary>
        /// Set what Anti-Spyware prevention profile is based on.
        /// </summary>
        /// <value>Set what Anti-Spyware prevention profile is based on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AntispywareBasedOnEnum
        {
            /// <summary>
            /// Enum Zone for value: zone
            /// </summary>
            [EnumMember(Value = "zone")]
            Zone = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set what Anti-Spyware prevention profile is based on.
        /// </summary>
        /// <value>Set what Anti-Spyware prevention profile is based on.</value>
        [DataMember(Name = "antispyware_based_on", EmitDefaultValue = false)]
        public AntispywareBasedOnEnum? AntispywareBasedOn { get; set; }
        /// <summary>
        /// Set what Anti-Virus prevention profile is based on.
        /// </summary>
        /// <value>Set what Anti-Virus prevention profile is based on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AntivirusBasedOnEnum
        {
            /// <summary>
            /// Enum Zone for value: zone
            /// </summary>
            [EnumMember(Value = "zone")]
            Zone = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set what Anti-Virus prevention profile is based on.
        /// </summary>
        /// <value>Set what Anti-Virus prevention profile is based on.</value>
        [DataMember(Name = "antivirus_based_on", EmitDefaultValue = false)]
        public AntivirusBasedOnEnum? AntivirusBasedOn { get; set; }
        /// <summary>
        /// Set Geo-IP control and enforcement mode.
        /// </summary>
        /// <value>Set Geo-IP control and enforcement mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GeoipModeEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set Geo-IP control and enforcement mode.
        /// </summary>
        /// <value>Set Geo-IP control and enforcement mode.</value>
        [DataMember(Name = "geoip_mode", EmitDefaultValue = false)]
        public GeoipModeEnum? GeoipMode { get; set; }
        /// <summary>
        /// Set what Geo-IP resolution and inspection is based on.
        /// </summary>
        /// <value>Set what Geo-IP resolution and inspection is based on.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GeoipInspectionBasedOnEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set what Geo-IP resolution and inspection is based on.
        /// </summary>
        /// <value>Set what Geo-IP resolution and inspection is based on.</value>
        [DataMember(Name = "geoip_inspection_based_on", EmitDefaultValue = false)]
        public GeoipInspectionBasedOnEnum? GeoipInspectionBasedOn { get; set; }
        /// <summary>
        /// Set Botnet filter control and enforcement mode.
        /// </summary>
        /// <value>Set Botnet filter control and enforcement mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BotnetModeEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set Botnet filter control and enforcement mode.
        /// </summary>
        /// <value>Set Botnet filter control and enforcement mode.</value>
        [DataMember(Name = "botnet_mode", EmitDefaultValue = false)]
        public BotnetModeEnum? BotnetMode { get; set; }
        /// <summary>
        /// Set decryption (DPI-SSL) control and enforcement mode.
        /// </summary>
        /// <value>Set decryption (DPI-SSL) control and enforcement mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DpisslModeEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set decryption (DPI-SSL) control and enforcement mode.
        /// </summary>
        /// <value>Set decryption (DPI-SSL) control and enforcement mode.</value>
        [DataMember(Name = "dpissl_mode", EmitDefaultValue = false)]
        public DpisslModeEnum? DpisslMode { get; set; }
        /// <summary>
        /// Set decryption (DPI-SSH) control and enforcement mode.
        /// </summary>
        /// <value>Set decryption (DPI-SSH) control and enforcement mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DpisshModeEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set decryption (DPI-SSH) control and enforcement mode.
        /// </summary>
        /// <value>Set decryption (DPI-SSH) control and enforcement mode.</value>
        [DataMember(Name = "dpissh_mode", EmitDefaultValue = false)]
        public DpisshModeEnum? DpisshMode { get; set; }
        /// <summary>
        /// Set DoS control and enforcement mode.
        /// </summary>
        /// <value>Set DoS control and enforcement mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DosModeEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set DoS control and enforcement mode.
        /// </summary>
        /// <value>Set DoS control and enforcement mode.</value>
        [DataMember(Name = "dos_mode", EmitDefaultValue = false)]
        public DosModeEnum? DosMode { get; set; }
        /// <summary>
        /// Set SYN flood protection mode.
        /// </summary>
        /// <value>Set SYN flood protection mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SynFloodEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set SYN flood protection mode.
        /// </summary>
        /// <value>Set SYN flood protection mode.</value>
        [DataMember(Name = "syn_flood", EmitDefaultValue = false)]
        public SynFloodEnum? SynFlood { get; set; }
        /// <summary>
        /// Set UDP flood protection mode.
        /// </summary>
        /// <value>Set UDP flood protection mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UdpFloodEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set UDP flood protection mode.
        /// </summary>
        /// <value>Set UDP flood protection mode.</value>
        [DataMember(Name = "udp_flood", EmitDefaultValue = false)]
        public UdpFloodEnum? UdpFlood { get; set; }
        /// <summary>
        /// Set ICMP flood protection mode.
        /// </summary>
        /// <value>Set ICMP flood protection mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IcmpFloodEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set ICMP flood protection mode.
        /// </summary>
        /// <value>Set ICMP flood protection mode.</value>
        [DataMember(Name = "icmp_flood", EmitDefaultValue = false)]
        public IcmpFloodEnum? IcmpFlood { get; set; }
        /// <summary>
        /// Set attack protection mode.
        /// </summary>
        /// <value>Set attack protection mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AttackEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set attack protection mode.
        /// </summary>
        /// <value>Set attack protection mode.</value>
        [DataMember(Name = "attack", EmitDefaultValue = false)]
        public AttackEnum? Attack { get; set; }
        /// <summary>
        /// Set DDoS protection mode.
        /// </summary>
        /// <value>Set DDoS protection mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DdosEnum
        {
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 1,

            /// <summary>
            /// Enum Policy for value: policy
            /// </summary>
            [EnumMember(Value = "policy")]
            Policy = 2
        }


        /// <summary>
        /// Set DDoS protection mode.
        /// </summary>
        /// <value>Set DDoS protection mode.</value>
        [DataMember(Name = "ddos", EmitDefaultValue = false)]
        public DdosEnum? Ddos { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliciesSettingBasePoliciesSetting" /> class.
        /// </summary>
        /// <param name="blockConnections">blockConnections.</param>
        /// <param name="activeApplicationCaching">Enable active application caching..</param>
        /// <param name="cachedApplicationBypass">Enable cached applications to bypass DPI..</param>
        /// <param name="applicationCache">applicationCache.</param>
        /// <param name="sslServerInspection">Enable SSL server inspection..</param>
        /// <param name="bypassDecryption">bypassDecryption.</param>
        /// <param name="policyBasedDosProtection">Enable policy-based DoS protection..</param>
        /// <param name="appCustomMalwareMode">Set application, custom match and malware (threats, virus and spyware) control plus prevention mode..</param>
        /// <param name="applicationBasedOn">Set what application classification (identification) is based on..</param>
        /// <param name="threatBasedOn">Set what threat detection and prevention is based on..</param>
        /// <param name="antispywareBasedOn">Set what Anti-Spyware prevention profile is based on..</param>
        /// <param name="antivirusBasedOn">Set what Anti-Virus prevention profile is based on..</param>
        /// <param name="geoipMode">Set Geo-IP control and enforcement mode..</param>
        /// <param name="geoipInspectionBasedOn">Set what Geo-IP resolution and inspection is based on..</param>
        /// <param name="botnetMode">Set Botnet filter control and enforcement mode..</param>
        /// <param name="dpisslMode">Set decryption (DPI-SSL) control and enforcement mode..</param>
        /// <param name="dpisshMode">Set decryption (DPI-SSH) control and enforcement mode..</param>
        /// <param name="dosMode">Set DoS control and enforcement mode..</param>
        /// <param name="synFlood">Set SYN flood protection mode..</param>
        /// <param name="udpFlood">Set UDP flood protection mode..</param>
        /// <param name="icmpFlood">Set ICMP flood protection mode..</param>
        /// <param name="attack">Set attack protection mode..</param>
        /// <param name="ddos">Set DDoS protection mode..</param>
        /// <param name="threatProfileForZone">threatProfileForZone.</param>
        /// <param name="antispywareProfileForZone">antispywareProfileForZone.</param>
        /// <param name="antivirusProfileForZone">antivirusProfileForZone.</param>
        public PoliciesSettingBasePoliciesSetting(PoliciesSettingBasePoliciesSettingBlockConnections blockConnections = default(PoliciesSettingBasePoliciesSettingBlockConnections), bool activeApplicationCaching = default(bool), bool cachedApplicationBypass = default(bool), PoliciesSettingBasePoliciesSettingApplicationCache applicationCache = default(PoliciesSettingBasePoliciesSettingApplicationCache), bool sslServerInspection = default(bool), PoliciesSettingBasePoliciesSettingBypassDecryption bypassDecryption = default(PoliciesSettingBasePoliciesSettingBypassDecryption), bool policyBasedDosProtection = default(bool), AppCustomMalwareModeEnum? appCustomMalwareMode = default(AppCustomMalwareModeEnum?), ApplicationBasedOnEnum? applicationBasedOn = default(ApplicationBasedOnEnum?), ThreatBasedOnEnum? threatBasedOn = default(ThreatBasedOnEnum?), AntispywareBasedOnEnum? antispywareBasedOn = default(AntispywareBasedOnEnum?), AntivirusBasedOnEnum? antivirusBasedOn = default(AntivirusBasedOnEnum?), GeoipModeEnum? geoipMode = default(GeoipModeEnum?), GeoipInspectionBasedOnEnum? geoipInspectionBasedOn = default(GeoipInspectionBasedOnEnum?), BotnetModeEnum? botnetMode = default(BotnetModeEnum?), DpisslModeEnum? dpisslMode = default(DpisslModeEnum?), DpisshModeEnum? dpisshMode = default(DpisshModeEnum?), DosModeEnum? dosMode = default(DosModeEnum?), SynFloodEnum? synFlood = default(SynFloodEnum?), UdpFloodEnum? udpFlood = default(UdpFloodEnum?), IcmpFloodEnum? icmpFlood = default(IcmpFloodEnum?), AttackEnum? attack = default(AttackEnum?), DdosEnum? ddos = default(DdosEnum?), PoliciesSettingBasePoliciesSettingThreatProfileForZone threatProfileForZone = default(PoliciesSettingBasePoliciesSettingThreatProfileForZone), PoliciesSettingBasePoliciesSettingAntispywareProfileForZone antispywareProfileForZone = default(PoliciesSettingBasePoliciesSettingAntispywareProfileForZone), PoliciesSettingBasePoliciesSettingAntivirusProfileForZone antivirusProfileForZone = default(PoliciesSettingBasePoliciesSettingAntivirusProfileForZone))
        {
            this.BlockConnections = blockConnections;
            this.ActiveApplicationCaching = activeApplicationCaching;
            this.CachedApplicationBypass = cachedApplicationBypass;
            this.ApplicationCache = applicationCache;
            this.SslServerInspection = sslServerInspection;
            this.BypassDecryption = bypassDecryption;
            this.PolicyBasedDosProtection = policyBasedDosProtection;
            this.AppCustomMalwareMode = appCustomMalwareMode;
            this.ApplicationBasedOn = applicationBasedOn;
            this.ThreatBasedOn = threatBasedOn;
            this.AntispywareBasedOn = antispywareBasedOn;
            this.AntivirusBasedOn = antivirusBasedOn;
            this.GeoipMode = geoipMode;
            this.GeoipInspectionBasedOn = geoipInspectionBasedOn;
            this.BotnetMode = botnetMode;
            this.DpisslMode = dpisslMode;
            this.DpisshMode = dpisshMode;
            this.DosMode = dosMode;
            this.SynFlood = synFlood;
            this.UdpFlood = udpFlood;
            this.IcmpFlood = icmpFlood;
            this.Attack = attack;
            this.Ddos = ddos;
            this.ThreatProfileForZone = threatProfileForZone;
            this.AntispywareProfileForZone = antispywareProfileForZone;
            this.AntivirusProfileForZone = antivirusProfileForZone;
        }

        /// <summary>
        /// Gets or Sets BlockConnections
        /// </summary>
        [DataMember(Name = "block_connections", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingBlockConnections BlockConnections { get; set; }

        /// <summary>
        /// Enable active application caching.
        /// </summary>
        /// <value>Enable active application caching.</value>
        [DataMember(Name = "active_application_caching", EmitDefaultValue = true)]
        public bool ActiveApplicationCaching { get; set; }

        /// <summary>
        /// Enable cached applications to bypass DPI.
        /// </summary>
        /// <value>Enable cached applications to bypass DPI.</value>
        [DataMember(Name = "cached_application_bypass", EmitDefaultValue = true)]
        public bool CachedApplicationBypass { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationCache
        /// </summary>
        [DataMember(Name = "application_cache", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingApplicationCache ApplicationCache { get; set; }

        /// <summary>
        /// Enable SSL server inspection.
        /// </summary>
        /// <value>Enable SSL server inspection.</value>
        [DataMember(Name = "ssl_server_inspection", EmitDefaultValue = true)]
        public bool SslServerInspection { get; set; }

        /// <summary>
        /// Gets or Sets BypassDecryption
        /// </summary>
        [DataMember(Name = "bypass_decryption", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingBypassDecryption BypassDecryption { get; set; }

        /// <summary>
        /// Enable policy-based DoS protection.
        /// </summary>
        /// <value>Enable policy-based DoS protection.</value>
        [DataMember(Name = "policy_based_dos_protection", EmitDefaultValue = true)]
        public bool PolicyBasedDosProtection { get; set; }

        /// <summary>
        /// Gets or Sets ThreatProfileForZone
        /// </summary>
        [DataMember(Name = "threat_profile_for_zone", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingThreatProfileForZone ThreatProfileForZone { get; set; }

        /// <summary>
        /// Gets or Sets AntispywareProfileForZone
        /// </summary>
        [DataMember(Name = "antispyware_profile_for_zone", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingAntispywareProfileForZone AntispywareProfileForZone { get; set; }

        /// <summary>
        /// Gets or Sets AntivirusProfileForZone
        /// </summary>
        [DataMember(Name = "antivirus_profile_for_zone", EmitDefaultValue = false)]
        public PoliciesSettingBasePoliciesSettingAntivirusProfileForZone AntivirusProfileForZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PoliciesSettingBasePoliciesSetting {\n");
            sb.Append("  BlockConnections: ").Append(BlockConnections).Append("\n");
            sb.Append("  ActiveApplicationCaching: ").Append(ActiveApplicationCaching).Append("\n");
            sb.Append("  CachedApplicationBypass: ").Append(CachedApplicationBypass).Append("\n");
            sb.Append("  ApplicationCache: ").Append(ApplicationCache).Append("\n");
            sb.Append("  SslServerInspection: ").Append(SslServerInspection).Append("\n");
            sb.Append("  BypassDecryption: ").Append(BypassDecryption).Append("\n");
            sb.Append("  PolicyBasedDosProtection: ").Append(PolicyBasedDosProtection).Append("\n");
            sb.Append("  AppCustomMalwareMode: ").Append(AppCustomMalwareMode).Append("\n");
            sb.Append("  ApplicationBasedOn: ").Append(ApplicationBasedOn).Append("\n");
            sb.Append("  ThreatBasedOn: ").Append(ThreatBasedOn).Append("\n");
            sb.Append("  AntispywareBasedOn: ").Append(AntispywareBasedOn).Append("\n");
            sb.Append("  AntivirusBasedOn: ").Append(AntivirusBasedOn).Append("\n");
            sb.Append("  GeoipMode: ").Append(GeoipMode).Append("\n");
            sb.Append("  GeoipInspectionBasedOn: ").Append(GeoipInspectionBasedOn).Append("\n");
            sb.Append("  BotnetMode: ").Append(BotnetMode).Append("\n");
            sb.Append("  DpisslMode: ").Append(DpisslMode).Append("\n");
            sb.Append("  DpisshMode: ").Append(DpisshMode).Append("\n");
            sb.Append("  DosMode: ").Append(DosMode).Append("\n");
            sb.Append("  SynFlood: ").Append(SynFlood).Append("\n");
            sb.Append("  UdpFlood: ").Append(UdpFlood).Append("\n");
            sb.Append("  IcmpFlood: ").Append(IcmpFlood).Append("\n");
            sb.Append("  Attack: ").Append(Attack).Append("\n");
            sb.Append("  Ddos: ").Append(Ddos).Append("\n");
            sb.Append("  ThreatProfileForZone: ").Append(ThreatProfileForZone).Append("\n");
            sb.Append("  AntispywareProfileForZone: ").Append(AntispywareProfileForZone).Append("\n");
            sb.Append("  AntivirusProfileForZone: ").Append(AntivirusProfileForZone).Append("\n");
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
            return this.Equals(input as PoliciesSettingBasePoliciesSetting);
        }

        /// <summary>
        /// Returns true if PoliciesSettingBasePoliciesSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of PoliciesSettingBasePoliciesSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoliciesSettingBasePoliciesSetting input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlockConnections == input.BlockConnections ||
                    (this.BlockConnections != null &&
                    this.BlockConnections.Equals(input.BlockConnections))
                ) && 
                (
                    this.ActiveApplicationCaching == input.ActiveApplicationCaching ||
                    this.ActiveApplicationCaching.Equals(input.ActiveApplicationCaching)
                ) && 
                (
                    this.CachedApplicationBypass == input.CachedApplicationBypass ||
                    this.CachedApplicationBypass.Equals(input.CachedApplicationBypass)
                ) && 
                (
                    this.ApplicationCache == input.ApplicationCache ||
                    (this.ApplicationCache != null &&
                    this.ApplicationCache.Equals(input.ApplicationCache))
                ) && 
                (
                    this.SslServerInspection == input.SslServerInspection ||
                    this.SslServerInspection.Equals(input.SslServerInspection)
                ) && 
                (
                    this.BypassDecryption == input.BypassDecryption ||
                    (this.BypassDecryption != null &&
                    this.BypassDecryption.Equals(input.BypassDecryption))
                ) && 
                (
                    this.PolicyBasedDosProtection == input.PolicyBasedDosProtection ||
                    this.PolicyBasedDosProtection.Equals(input.PolicyBasedDosProtection)
                ) && 
                (
                    this.AppCustomMalwareMode == input.AppCustomMalwareMode ||
                    this.AppCustomMalwareMode.Equals(input.AppCustomMalwareMode)
                ) && 
                (
                    this.ApplicationBasedOn == input.ApplicationBasedOn ||
                    this.ApplicationBasedOn.Equals(input.ApplicationBasedOn)
                ) && 
                (
                    this.ThreatBasedOn == input.ThreatBasedOn ||
                    this.ThreatBasedOn.Equals(input.ThreatBasedOn)
                ) && 
                (
                    this.AntispywareBasedOn == input.AntispywareBasedOn ||
                    this.AntispywareBasedOn.Equals(input.AntispywareBasedOn)
                ) && 
                (
                    this.AntivirusBasedOn == input.AntivirusBasedOn ||
                    this.AntivirusBasedOn.Equals(input.AntivirusBasedOn)
                ) && 
                (
                    this.GeoipMode == input.GeoipMode ||
                    this.GeoipMode.Equals(input.GeoipMode)
                ) && 
                (
                    this.GeoipInspectionBasedOn == input.GeoipInspectionBasedOn ||
                    this.GeoipInspectionBasedOn.Equals(input.GeoipInspectionBasedOn)
                ) && 
                (
                    this.BotnetMode == input.BotnetMode ||
                    this.BotnetMode.Equals(input.BotnetMode)
                ) && 
                (
                    this.DpisslMode == input.DpisslMode ||
                    this.DpisslMode.Equals(input.DpisslMode)
                ) && 
                (
                    this.DpisshMode == input.DpisshMode ||
                    this.DpisshMode.Equals(input.DpisshMode)
                ) && 
                (
                    this.DosMode == input.DosMode ||
                    this.DosMode.Equals(input.DosMode)
                ) && 
                (
                    this.SynFlood == input.SynFlood ||
                    this.SynFlood.Equals(input.SynFlood)
                ) && 
                (
                    this.UdpFlood == input.UdpFlood ||
                    this.UdpFlood.Equals(input.UdpFlood)
                ) && 
                (
                    this.IcmpFlood == input.IcmpFlood ||
                    this.IcmpFlood.Equals(input.IcmpFlood)
                ) && 
                (
                    this.Attack == input.Attack ||
                    this.Attack.Equals(input.Attack)
                ) && 
                (
                    this.Ddos == input.Ddos ||
                    this.Ddos.Equals(input.Ddos)
                ) && 
                (
                    this.ThreatProfileForZone == input.ThreatProfileForZone ||
                    (this.ThreatProfileForZone != null &&
                    this.ThreatProfileForZone.Equals(input.ThreatProfileForZone))
                ) && 
                (
                    this.AntispywareProfileForZone == input.AntispywareProfileForZone ||
                    (this.AntispywareProfileForZone != null &&
                    this.AntispywareProfileForZone.Equals(input.AntispywareProfileForZone))
                ) && 
                (
                    this.AntivirusProfileForZone == input.AntivirusProfileForZone ||
                    (this.AntivirusProfileForZone != null &&
                    this.AntivirusProfileForZone.Equals(input.AntivirusProfileForZone))
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
                if (this.BlockConnections != null)
                {
                    hashCode = (hashCode * 59) + this.BlockConnections.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ActiveApplicationCaching.GetHashCode();
                hashCode = (hashCode * 59) + this.CachedApplicationBypass.GetHashCode();
                if (this.ApplicationCache != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationCache.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SslServerInspection.GetHashCode();
                if (this.BypassDecryption != null)
                {
                    hashCode = (hashCode * 59) + this.BypassDecryption.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PolicyBasedDosProtection.GetHashCode();
                hashCode = (hashCode * 59) + this.AppCustomMalwareMode.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplicationBasedOn.GetHashCode();
                hashCode = (hashCode * 59) + this.ThreatBasedOn.GetHashCode();
                hashCode = (hashCode * 59) + this.AntispywareBasedOn.GetHashCode();
                hashCode = (hashCode * 59) + this.AntivirusBasedOn.GetHashCode();
                hashCode = (hashCode * 59) + this.GeoipMode.GetHashCode();
                hashCode = (hashCode * 59) + this.GeoipInspectionBasedOn.GetHashCode();
                hashCode = (hashCode * 59) + this.BotnetMode.GetHashCode();
                hashCode = (hashCode * 59) + this.DpisslMode.GetHashCode();
                hashCode = (hashCode * 59) + this.DpisshMode.GetHashCode();
                hashCode = (hashCode * 59) + this.DosMode.GetHashCode();
                hashCode = (hashCode * 59) + this.SynFlood.GetHashCode();
                hashCode = (hashCode * 59) + this.UdpFlood.GetHashCode();
                hashCode = (hashCode * 59) + this.IcmpFlood.GetHashCode();
                hashCode = (hashCode * 59) + this.Attack.GetHashCode();
                hashCode = (hashCode * 59) + this.Ddos.GetHashCode();
                if (this.ThreatProfileForZone != null)
                {
                    hashCode = (hashCode * 59) + this.ThreatProfileForZone.GetHashCode();
                }
                if (this.AntispywareProfileForZone != null)
                {
                    hashCode = (hashCode * 59) + this.AntispywareProfileForZone.GetHashCode();
                }
                if (this.AntivirusProfileForZone != null)
                {
                    hashCode = (hashCode * 59) + this.AntivirusProfileForZone.GetHashCode();
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