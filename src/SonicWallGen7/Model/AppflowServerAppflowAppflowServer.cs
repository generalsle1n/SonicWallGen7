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
    /// Enter appflow server configuration mode.
    /// </summary>
    [DataContract(Name = "appflow_server_appflow_appflow_server")]
    public partial class AppflowServerAppflowAppflowServer : IEquatable<AppflowServerAppflowAppflowServer>, IValidatableObject
    {
        /// <summary>
        /// Select appflow reporting format.
        /// </summary>
        /// <value>Select appflow reporting format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportingFormatEnum
        {
            /// <summary>
            /// Enum Extension for value: ipfix-with-extension
            /// </summary>
            [EnumMember(Value = "ipfix-with-extension")]
            Extension = 1,

            /// <summary>
            /// Enum ExtensionV2 for value: ipfix-with-extension-v2
            /// </summary>
            [EnumMember(Value = "ipfix-with-extension-v2")]
            ExtensionV2 = 2
        }


        /// <summary>
        /// Select appflow reporting format.
        /// </summary>
        /// <value>Select appflow reporting format.</value>
        [DataMember(Name = "reporting_format", EmitDefaultValue = false)]
        public ReportingFormatEnum? ReportingFormat { get; set; }
        /// <summary>
        /// Select GMS flow server configuration mode.
        /// </summary>
        /// <value>Select GMS flow server configuration mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Basic for value: basic
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic = 1,

            /// <summary>
            /// Enum Advanced for value: advanced
            /// </summary>
            [EnumMember(Value = "advanced")]
            Advanced = 2
        }


        /// <summary>
        /// Select GMS flow server configuration mode.
        /// </summary>
        /// <value>Select GMS flow server configuration mode.</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Select Advanced APP flow server configuration mode.
        /// </summary>
        /// <value>Select Advanced APP flow server configuration mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdvancedModeEnum
        {
            /// <summary>
            /// Enum ActiveStandby for value: active-standby
            /// </summary>
            [EnumMember(Value = "active-standby")]
            ActiveStandby = 1,

            /// <summary>
            /// Enum LoadBalancing for value: load-balancing
            /// </summary>
            [EnumMember(Value = "load-balancing")]
            LoadBalancing = 2
        }


        /// <summary>
        /// Select Advanced APP flow server configuration mode.
        /// </summary>
        /// <value>Select Advanced APP flow server configuration mode.</value>
        [DataMember(Name = "advanced_mode", EmitDefaultValue = false)]
        public AdvancedModeEnum? AdvancedMode { get; set; }
        /// <summary>
        /// Select load balancing mode.
        /// </summary>
        /// <value>Select load balancing mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LoadBalancingModeEnum
        {
            /// <summary>
            /// Enum ShareLoad for value: share-load
            /// </summary>
            [EnumMember(Value = "share-load")]
            ShareLoad = 1,

            /// <summary>
            /// Enum Mirror for value: mirror
            /// </summary>
            [EnumMember(Value = "mirror")]
            Mirror = 2
        }


        /// <summary>
        /// Select load balancing mode.
        /// </summary>
        /// <value>Select load balancing mode.</value>
        [DataMember(Name = "load_balancing_mode", EmitDefaultValue = false)]
        public LoadBalancingModeEnum? LoadBalancingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppflowServerAppflowAppflowServer" /> class.
        /// </summary>
        /// <param name="flows">Enable sending appflow to SonicWALL appflow server..</param>
        /// <param name="realTime">Enable sending of real-time data to SonicWALL appflow server..</param>
        /// <param name="systemLogs">Enable sending of system log to SonicWALL appflow server..</param>
        /// <param name="report">report.</param>
        /// <param name="reportingFormat">Select appflow reporting format..</param>
        /// <param name="dynamicFlows">dynamicFlows.</param>
        /// <param name="keepAlive">Enable keep-alive with appflow server..</param>
        /// <param name="mode">Select GMS flow server configuration mode..</param>
        /// <param name="autoSynchronize">Enable auto-synchronize for appflow server..</param>
        /// <param name="advancedMode">Select Advanced APP flow server configuration mode..</param>
        /// <param name="loadBalancingMode">Select load balancing mode..</param>
        /// <param name="serverIp">serverIp.</param>
        /// <param name="server2Ip">server2Ip.</param>
        /// <param name="angEncryption">Enable Analyzer Next Gen encryption..</param>
        public AppflowServerAppflowAppflowServer(bool flows = default(bool), bool realTime = default(bool), bool systemLogs = default(bool), AppflowGmsflowServerAppflowGmsflowServerReport report = default(AppflowGmsflowServerAppflowGmsflowServerReport), ReportingFormatEnum? reportingFormat = default(ReportingFormatEnum?), AppflowGmsflowServerAppflowGmsflowServerDynamicFlows dynamicFlows = default(AppflowGmsflowServerAppflowGmsflowServerDynamicFlows), bool keepAlive = default(bool), ModeEnum? mode = default(ModeEnum?), bool autoSynchronize = default(bool), AdvancedModeEnum? advancedMode = default(AdvancedModeEnum?), LoadBalancingModeEnum? loadBalancingMode = default(LoadBalancingModeEnum?), AppflowServerAppflowAppflowServerServerIp serverIp = default(AppflowServerAppflowAppflowServerServerIp), AppflowServerAppflowAppflowServerServer2Ip server2Ip = default(AppflowServerAppflowAppflowServerServer2Ip), bool angEncryption = default(bool))
        {
            this.Flows = flows;
            this.RealTime = realTime;
            this.SystemLogs = systemLogs;
            this.Report = report;
            this.ReportingFormat = reportingFormat;
            this.DynamicFlows = dynamicFlows;
            this.KeepAlive = keepAlive;
            this.Mode = mode;
            this.AutoSynchronize = autoSynchronize;
            this.AdvancedMode = advancedMode;
            this.LoadBalancingMode = loadBalancingMode;
            this.ServerIp = serverIp;
            this.Server2Ip = server2Ip;
            this.AngEncryption = angEncryption;
        }

        /// <summary>
        /// Enable sending appflow to SonicWALL appflow server.
        /// </summary>
        /// <value>Enable sending appflow to SonicWALL appflow server.</value>
        [DataMember(Name = "flows", EmitDefaultValue = true)]
        public bool Flows { get; set; }

        /// <summary>
        /// Enable sending of real-time data to SonicWALL appflow server.
        /// </summary>
        /// <value>Enable sending of real-time data to SonicWALL appflow server.</value>
        [DataMember(Name = "real_time", EmitDefaultValue = true)]
        public bool RealTime { get; set; }

        /// <summary>
        /// Enable sending of system log to SonicWALL appflow server.
        /// </summary>
        /// <value>Enable sending of system log to SonicWALL appflow server.</value>
        [DataMember(Name = "system_logs", EmitDefaultValue = true)]
        public bool SystemLogs { get; set; }

        /// <summary>
        /// Gets or Sets Report
        /// </summary>
        [DataMember(Name = "report", EmitDefaultValue = false)]
        public AppflowGmsflowServerAppflowGmsflowServerReport Report { get; set; }

        /// <summary>
        /// Gets or Sets DynamicFlows
        /// </summary>
        [DataMember(Name = "dynamic_flows", EmitDefaultValue = false)]
        public AppflowGmsflowServerAppflowGmsflowServerDynamicFlows DynamicFlows { get; set; }

        /// <summary>
        /// Enable keep-alive with appflow server.
        /// </summary>
        /// <value>Enable keep-alive with appflow server.</value>
        [DataMember(Name = "keep_alive", EmitDefaultValue = true)]
        public bool KeepAlive { get; set; }

        /// <summary>
        /// Enable auto-synchronize for appflow server.
        /// </summary>
        /// <value>Enable auto-synchronize for appflow server.</value>
        [DataMember(Name = "auto_synchronize", EmitDefaultValue = true)]
        public bool AutoSynchronize { get; set; }

        /// <summary>
        /// Gets or Sets ServerIp
        /// </summary>
        [DataMember(Name = "server_ip", EmitDefaultValue = false)]
        public AppflowServerAppflowAppflowServerServerIp ServerIp { get; set; }

        /// <summary>
        /// Gets or Sets Server2Ip
        /// </summary>
        [DataMember(Name = "server_2_ip", EmitDefaultValue = false)]
        public AppflowServerAppflowAppflowServerServer2Ip Server2Ip { get; set; }

        /// <summary>
        /// Enable Analyzer Next Gen encryption.
        /// </summary>
        /// <value>Enable Analyzer Next Gen encryption.</value>
        [DataMember(Name = "ang_encryption", EmitDefaultValue = true)]
        public bool AngEncryption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppflowServerAppflowAppflowServer {\n");
            sb.Append("  Flows: ").Append(Flows).Append("\n");
            sb.Append("  RealTime: ").Append(RealTime).Append("\n");
            sb.Append("  SystemLogs: ").Append(SystemLogs).Append("\n");
            sb.Append("  Report: ").Append(Report).Append("\n");
            sb.Append("  ReportingFormat: ").Append(ReportingFormat).Append("\n");
            sb.Append("  DynamicFlows: ").Append(DynamicFlows).Append("\n");
            sb.Append("  KeepAlive: ").Append(KeepAlive).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  AutoSynchronize: ").Append(AutoSynchronize).Append("\n");
            sb.Append("  AdvancedMode: ").Append(AdvancedMode).Append("\n");
            sb.Append("  LoadBalancingMode: ").Append(LoadBalancingMode).Append("\n");
            sb.Append("  ServerIp: ").Append(ServerIp).Append("\n");
            sb.Append("  Server2Ip: ").Append(Server2Ip).Append("\n");
            sb.Append("  AngEncryption: ").Append(AngEncryption).Append("\n");
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
            return this.Equals(input as AppflowServerAppflowAppflowServer);
        }

        /// <summary>
        /// Returns true if AppflowServerAppflowAppflowServer instances are equal
        /// </summary>
        /// <param name="input">Instance of AppflowServerAppflowAppflowServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppflowServerAppflowAppflowServer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Flows == input.Flows ||
                    this.Flows.Equals(input.Flows)
                ) && 
                (
                    this.RealTime == input.RealTime ||
                    this.RealTime.Equals(input.RealTime)
                ) && 
                (
                    this.SystemLogs == input.SystemLogs ||
                    this.SystemLogs.Equals(input.SystemLogs)
                ) && 
                (
                    this.Report == input.Report ||
                    (this.Report != null &&
                    this.Report.Equals(input.Report))
                ) && 
                (
                    this.ReportingFormat == input.ReportingFormat ||
                    this.ReportingFormat.Equals(input.ReportingFormat)
                ) && 
                (
                    this.DynamicFlows == input.DynamicFlows ||
                    (this.DynamicFlows != null &&
                    this.DynamicFlows.Equals(input.DynamicFlows))
                ) && 
                (
                    this.KeepAlive == input.KeepAlive ||
                    this.KeepAlive.Equals(input.KeepAlive)
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.AutoSynchronize == input.AutoSynchronize ||
                    this.AutoSynchronize.Equals(input.AutoSynchronize)
                ) && 
                (
                    this.AdvancedMode == input.AdvancedMode ||
                    this.AdvancedMode.Equals(input.AdvancedMode)
                ) && 
                (
                    this.LoadBalancingMode == input.LoadBalancingMode ||
                    this.LoadBalancingMode.Equals(input.LoadBalancingMode)
                ) && 
                (
                    this.ServerIp == input.ServerIp ||
                    (this.ServerIp != null &&
                    this.ServerIp.Equals(input.ServerIp))
                ) && 
                (
                    this.Server2Ip == input.Server2Ip ||
                    (this.Server2Ip != null &&
                    this.Server2Ip.Equals(input.Server2Ip))
                ) && 
                (
                    this.AngEncryption == input.AngEncryption ||
                    this.AngEncryption.Equals(input.AngEncryption)
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
                hashCode = (hashCode * 59) + this.Flows.GetHashCode();
                hashCode = (hashCode * 59) + this.RealTime.GetHashCode();
                hashCode = (hashCode * 59) + this.SystemLogs.GetHashCode();
                if (this.Report != null)
                {
                    hashCode = (hashCode * 59) + this.Report.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReportingFormat.GetHashCode();
                if (this.DynamicFlows != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicFlows.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeepAlive.GetHashCode();
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoSynchronize.GetHashCode();
                hashCode = (hashCode * 59) + this.AdvancedMode.GetHashCode();
                hashCode = (hashCode * 59) + this.LoadBalancingMode.GetHashCode();
                if (this.ServerIp != null)
                {
                    hashCode = (hashCode * 59) + this.ServerIp.GetHashCode();
                }
                if (this.Server2Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Server2Ip.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AngEncryption.GetHashCode();
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
