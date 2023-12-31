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
    /// Configure advanced diag flow reporting.
    /// </summary>
    [DataContract(Name = "diag_advanced_flow_reporting_diag_advanced_flow_reporting")]
    public partial class DiagAdvancedFlowReportingDiagAdvancedFlowReporting : IEquatable<DiagAdvancedFlowReportingDiagAdvancedFlowReporting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagAdvancedFlowReportingDiagAdvancedFlowReporting" /> class.
        /// </summary>
        /// <param name="exportRawDatabase">Enable export of raw flow-related database table entries..</param>
        /// <param name="sqlConsole">Enable SQL console in System &gt; Diagnostics page..</param>
        /// <param name="appflowMonitorBrowserFrameLaunch">Enable launching of AppFlow monitor in a stand-alone browser frame..</param>
        /// <param name="nonAdminVisualization">Enable visualization UI for Non-Admin/Config users..</param>
        /// <param name="databaseBusyTimeout">Set database busy timeout in msec..</param>
        /// <param name="hideAppflowServer">Hide AppFlow server feature..</param>
        /// <param name="hideGmsflowServer">Hide GmsFlow Server feature..</param>
        /// <param name="reportServerAddress">reportServerAddress.</param>
        public DiagAdvancedFlowReportingDiagAdvancedFlowReporting(bool exportRawDatabase = default(bool), bool sqlConsole = default(bool), bool appflowMonitorBrowserFrameLaunch = default(bool), bool nonAdminVisualization = default(bool), decimal databaseBusyTimeout = default(decimal), bool hideAppflowServer = default(bool), bool hideGmsflowServer = default(bool), DiagAdvancedFlowReportingDiagAdvancedFlowReportingReportServerAddress reportServerAddress = default(DiagAdvancedFlowReportingDiagAdvancedFlowReportingReportServerAddress))
        {
            this.ExportRawDatabase = exportRawDatabase;
            this.SqlConsole = sqlConsole;
            this.AppflowMonitorBrowserFrameLaunch = appflowMonitorBrowserFrameLaunch;
            this.NonAdminVisualization = nonAdminVisualization;
            this.DatabaseBusyTimeout = databaseBusyTimeout;
            this.HideAppflowServer = hideAppflowServer;
            this.HideGmsflowServer = hideGmsflowServer;
            this.ReportServerAddress = reportServerAddress;
        }

        /// <summary>
        /// Enable export of raw flow-related database table entries.
        /// </summary>
        /// <value>Enable export of raw flow-related database table entries.</value>
        [DataMember(Name = "export_raw_database", EmitDefaultValue = true)]
        public bool ExportRawDatabase { get; set; }

        /// <summary>
        /// Enable SQL console in System &gt; Diagnostics page.
        /// </summary>
        /// <value>Enable SQL console in System &gt; Diagnostics page.</value>
        [DataMember(Name = "sql_console", EmitDefaultValue = true)]
        public bool SqlConsole { get; set; }

        /// <summary>
        /// Enable launching of AppFlow monitor in a stand-alone browser frame.
        /// </summary>
        /// <value>Enable launching of AppFlow monitor in a stand-alone browser frame.</value>
        [DataMember(Name = "appflow_monitor_browser_frame_launch", EmitDefaultValue = true)]
        public bool AppflowMonitorBrowserFrameLaunch { get; set; }

        /// <summary>
        /// Enable visualization UI for Non-Admin/Config users.
        /// </summary>
        /// <value>Enable visualization UI for Non-Admin/Config users.</value>
        [DataMember(Name = "non_admin_visualization", EmitDefaultValue = true)]
        public bool NonAdminVisualization { get; set; }

        /// <summary>
        /// Set database busy timeout in msec.
        /// </summary>
        /// <value>Set database busy timeout in msec.</value>
        [DataMember(Name = "database_busy_timeout", EmitDefaultValue = false)]
        public decimal DatabaseBusyTimeout { get; set; }

        /// <summary>
        /// Hide AppFlow server feature.
        /// </summary>
        /// <value>Hide AppFlow server feature.</value>
        [DataMember(Name = "hide_appflow_server", EmitDefaultValue = true)]
        public bool HideAppflowServer { get; set; }

        /// <summary>
        /// Hide GmsFlow Server feature.
        /// </summary>
        /// <value>Hide GmsFlow Server feature.</value>
        [DataMember(Name = "hide_gmsflow_server", EmitDefaultValue = true)]
        public bool HideGmsflowServer { get; set; }

        /// <summary>
        /// Gets or Sets ReportServerAddress
        /// </summary>
        [DataMember(Name = "report_server_address", EmitDefaultValue = false)]
        public DiagAdvancedFlowReportingDiagAdvancedFlowReportingReportServerAddress ReportServerAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiagAdvancedFlowReportingDiagAdvancedFlowReporting {\n");
            sb.Append("  ExportRawDatabase: ").Append(ExportRawDatabase).Append("\n");
            sb.Append("  SqlConsole: ").Append(SqlConsole).Append("\n");
            sb.Append("  AppflowMonitorBrowserFrameLaunch: ").Append(AppflowMonitorBrowserFrameLaunch).Append("\n");
            sb.Append("  NonAdminVisualization: ").Append(NonAdminVisualization).Append("\n");
            sb.Append("  DatabaseBusyTimeout: ").Append(DatabaseBusyTimeout).Append("\n");
            sb.Append("  HideAppflowServer: ").Append(HideAppflowServer).Append("\n");
            sb.Append("  HideGmsflowServer: ").Append(HideGmsflowServer).Append("\n");
            sb.Append("  ReportServerAddress: ").Append(ReportServerAddress).Append("\n");
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
            return this.Equals(input as DiagAdvancedFlowReportingDiagAdvancedFlowReporting);
        }

        /// <summary>
        /// Returns true if DiagAdvancedFlowReportingDiagAdvancedFlowReporting instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagAdvancedFlowReportingDiagAdvancedFlowReporting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagAdvancedFlowReportingDiagAdvancedFlowReporting input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExportRawDatabase == input.ExportRawDatabase ||
                    this.ExportRawDatabase.Equals(input.ExportRawDatabase)
                ) && 
                (
                    this.SqlConsole == input.SqlConsole ||
                    this.SqlConsole.Equals(input.SqlConsole)
                ) && 
                (
                    this.AppflowMonitorBrowserFrameLaunch == input.AppflowMonitorBrowserFrameLaunch ||
                    this.AppflowMonitorBrowserFrameLaunch.Equals(input.AppflowMonitorBrowserFrameLaunch)
                ) && 
                (
                    this.NonAdminVisualization == input.NonAdminVisualization ||
                    this.NonAdminVisualization.Equals(input.NonAdminVisualization)
                ) && 
                (
                    this.DatabaseBusyTimeout == input.DatabaseBusyTimeout ||
                    this.DatabaseBusyTimeout.Equals(input.DatabaseBusyTimeout)
                ) && 
                (
                    this.HideAppflowServer == input.HideAppflowServer ||
                    this.HideAppflowServer.Equals(input.HideAppflowServer)
                ) && 
                (
                    this.HideGmsflowServer == input.HideGmsflowServer ||
                    this.HideGmsflowServer.Equals(input.HideGmsflowServer)
                ) && 
                (
                    this.ReportServerAddress == input.ReportServerAddress ||
                    (this.ReportServerAddress != null &&
                    this.ReportServerAddress.Equals(input.ReportServerAddress))
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
                hashCode = (hashCode * 59) + this.ExportRawDatabase.GetHashCode();
                hashCode = (hashCode * 59) + this.SqlConsole.GetHashCode();
                hashCode = (hashCode * 59) + this.AppflowMonitorBrowserFrameLaunch.GetHashCode();
                hashCode = (hashCode * 59) + this.NonAdminVisualization.GetHashCode();
                hashCode = (hashCode * 59) + this.DatabaseBusyTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.HideAppflowServer.GetHashCode();
                hashCode = (hashCode * 59) + this.HideGmsflowServer.GetHashCode();
                if (this.ReportServerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ReportServerAddress.GetHashCode();
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
