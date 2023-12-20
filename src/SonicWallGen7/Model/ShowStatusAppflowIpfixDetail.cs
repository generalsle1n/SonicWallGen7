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
    /// appflow ipfix detail schema.
    /// </summary>
    [DataContract(Name = "show_status_appflow_ipfix_detail")]
    public partial class ShowStatusAppflowIpfixDetail : IEquatable<ShowStatusAppflowIpfixDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusAppflowIpfixDetail" /> class.
        /// </summary>
        /// <param name="totalNetflowIpfixPacketsSent">totalNetflowIpfixPacketsSent.</param>
        /// <param name="netflowIpfixPacketsSentToExternalCollector">netflowIpfixPacketsSentToExternalCollector.</param>
        /// <param name="netflowIpfixPacketsSentToGmsflowServer">netflowIpfixPacketsSentToGmsflowServer.</param>
        /// <param name="netflowIpfixPacketsSentToAppflowServer">netflowIpfixPacketsSentToAppflowServer.</param>
        /// <param name="netflowIpfixPacketsSentToChassisProcessor">netflowIpfixPacketsSentToChassisProcessor.</param>
        /// <param name="netflowIpfixTemplatesSent">netflowIpfixTemplatesSent.</param>
        /// <param name="connectionFlowsSentToExternalCollector">connectionFlowsSentToExternalCollector.</param>
        /// <param name="connectionFlowsSentToGmsflowServer">connectionFlowsSentToGmsflowServer.</param>
        /// <param name="connectionFlowsSentToAppflowServer">connectionFlowsSentToAppflowServer.</param>
        /// <param name="connectionFlowsSentToChassisProcessor">connectionFlowsSentToChassisProcessor.</param>
        /// <param name="nonConnectionRelatedDynamicFlowsSentToExternalCollector">nonConnectionRelatedDynamicFlowsSentToExternalCollector.</param>
        /// <param name="nonConnectionRelatedDynamicFlowsSentToGmsflowServer">nonConnectionRelatedDynamicFlowsSentToGmsflowServer.</param>
        /// <param name="nonConnectionRelatedDynamicFlowsSentToAppflowServer">nonConnectionRelatedDynamicFlowsSentToAppflowServer.</param>
        /// <param name="nonConnectionRelatedDynamicFlowsSentToChassisProcessor">nonConnectionRelatedDynamicFlowsSentToChassisProcessor.</param>
        /// <param name="nonConnectionRelatedStaticFlowsSentToExternalCollector">nonConnectionRelatedStaticFlowsSentToExternalCollector.</param>
        /// <param name="nonConnectionRelatedStaticFlowsSentToGmsflowServer">nonConnectionRelatedStaticFlowsSentToGmsflowServer.</param>
        /// <param name="nonConnectionRelatedStaticFlowsSentToAppflowServer">nonConnectionRelatedStaticFlowsSentToAppflowServer.</param>
        /// <param name="nonConnectionRelatedStaticFlowsSentToChassisProcessor">nonConnectionRelatedStaticFlowsSentToChassisProcessor.</param>
        /// <param name="logsReportedByIpfixToExternalCollector">logsReportedByIpfixToExternalCollector.</param>
        /// <param name="logsReportedByIpfixToGmsflowServer">logsReportedByIpfixToGmsflowServer.</param>
        /// <param name="logsReportedByIpfixToAppflowServer">logsReportedByIpfixToAppflowServer.</param>
        public ShowStatusAppflowIpfixDetail(string totalNetflowIpfixPacketsSent = default(string), string netflowIpfixPacketsSentToExternalCollector = default(string), string netflowIpfixPacketsSentToGmsflowServer = default(string), string netflowIpfixPacketsSentToAppflowServer = default(string), string netflowIpfixPacketsSentToChassisProcessor = default(string), string netflowIpfixTemplatesSent = default(string), string connectionFlowsSentToExternalCollector = default(string), string connectionFlowsSentToGmsflowServer = default(string), string connectionFlowsSentToAppflowServer = default(string), string connectionFlowsSentToChassisProcessor = default(string), string nonConnectionRelatedDynamicFlowsSentToExternalCollector = default(string), string nonConnectionRelatedDynamicFlowsSentToGmsflowServer = default(string), string nonConnectionRelatedDynamicFlowsSentToAppflowServer = default(string), string nonConnectionRelatedDynamicFlowsSentToChassisProcessor = default(string), string nonConnectionRelatedStaticFlowsSentToExternalCollector = default(string), string nonConnectionRelatedStaticFlowsSentToGmsflowServer = default(string), string nonConnectionRelatedStaticFlowsSentToAppflowServer = default(string), string nonConnectionRelatedStaticFlowsSentToChassisProcessor = default(string), string logsReportedByIpfixToExternalCollector = default(string), string logsReportedByIpfixToGmsflowServer = default(string), string logsReportedByIpfixToAppflowServer = default(string))
        {
            this.TotalNetflowIpfixPacketsSent = totalNetflowIpfixPacketsSent;
            this.NetflowIpfixPacketsSentToExternalCollector = netflowIpfixPacketsSentToExternalCollector;
            this.NetflowIpfixPacketsSentToGmsflowServer = netflowIpfixPacketsSentToGmsflowServer;
            this.NetflowIpfixPacketsSentToAppflowServer = netflowIpfixPacketsSentToAppflowServer;
            this.NetflowIpfixPacketsSentToChassisProcessor = netflowIpfixPacketsSentToChassisProcessor;
            this.NetflowIpfixTemplatesSent = netflowIpfixTemplatesSent;
            this.ConnectionFlowsSentToExternalCollector = connectionFlowsSentToExternalCollector;
            this.ConnectionFlowsSentToGmsflowServer = connectionFlowsSentToGmsflowServer;
            this.ConnectionFlowsSentToAppflowServer = connectionFlowsSentToAppflowServer;
            this.ConnectionFlowsSentToChassisProcessor = connectionFlowsSentToChassisProcessor;
            this.NonConnectionRelatedDynamicFlowsSentToExternalCollector = nonConnectionRelatedDynamicFlowsSentToExternalCollector;
            this.NonConnectionRelatedDynamicFlowsSentToGmsflowServer = nonConnectionRelatedDynamicFlowsSentToGmsflowServer;
            this.NonConnectionRelatedDynamicFlowsSentToAppflowServer = nonConnectionRelatedDynamicFlowsSentToAppflowServer;
            this.NonConnectionRelatedDynamicFlowsSentToChassisProcessor = nonConnectionRelatedDynamicFlowsSentToChassisProcessor;
            this.NonConnectionRelatedStaticFlowsSentToExternalCollector = nonConnectionRelatedStaticFlowsSentToExternalCollector;
            this.NonConnectionRelatedStaticFlowsSentToGmsflowServer = nonConnectionRelatedStaticFlowsSentToGmsflowServer;
            this.NonConnectionRelatedStaticFlowsSentToAppflowServer = nonConnectionRelatedStaticFlowsSentToAppflowServer;
            this.NonConnectionRelatedStaticFlowsSentToChassisProcessor = nonConnectionRelatedStaticFlowsSentToChassisProcessor;
            this.LogsReportedByIpfixToExternalCollector = logsReportedByIpfixToExternalCollector;
            this.LogsReportedByIpfixToGmsflowServer = logsReportedByIpfixToGmsflowServer;
            this.LogsReportedByIpfixToAppflowServer = logsReportedByIpfixToAppflowServer;
        }

        /// <summary>
        /// Gets or Sets TotalNetflowIpfixPacketsSent
        /// </summary>
        [DataMember(Name = "total_netflow_ipfix_packets_sent", EmitDefaultValue = false)]
        public string TotalNetflowIpfixPacketsSent { get; set; }

        /// <summary>
        /// Gets or Sets NetflowIpfixPacketsSentToExternalCollector
        /// </summary>
        [DataMember(Name = "netflow_ipfix_packets_sent_to_external_collector", EmitDefaultValue = false)]
        public string NetflowIpfixPacketsSentToExternalCollector { get; set; }

        /// <summary>
        /// Gets or Sets NetflowIpfixPacketsSentToGmsflowServer
        /// </summary>
        [DataMember(Name = "netflow_ipfix_packets_sent_to_gmsflow_server", EmitDefaultValue = false)]
        public string NetflowIpfixPacketsSentToGmsflowServer { get; set; }

        /// <summary>
        /// Gets or Sets NetflowIpfixPacketsSentToAppflowServer
        /// </summary>
        [DataMember(Name = "netflow_ipfix_packets_sent_to_appflow_server", EmitDefaultValue = false)]
        public string NetflowIpfixPacketsSentToAppflowServer { get; set; }

        /// <summary>
        /// Gets or Sets NetflowIpfixPacketsSentToChassisProcessor
        /// </summary>
        [DataMember(Name = "netflow_ipfix_packets_sent_to_chassis_processor", EmitDefaultValue = false)]
        public string NetflowIpfixPacketsSentToChassisProcessor { get; set; }

        /// <summary>
        /// Gets or Sets NetflowIpfixTemplatesSent
        /// </summary>
        [DataMember(Name = "netflow_ipfix_templates_sent", EmitDefaultValue = false)]
        public string NetflowIpfixTemplatesSent { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionFlowsSentToExternalCollector
        /// </summary>
        [DataMember(Name = "connection_flows_sent_to_external_collector", EmitDefaultValue = false)]
        public string ConnectionFlowsSentToExternalCollector { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionFlowsSentToGmsflowServer
        /// </summary>
        [DataMember(Name = "connection_flows_sent_to_gmsflow_server", EmitDefaultValue = false)]
        public string ConnectionFlowsSentToGmsflowServer { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionFlowsSentToAppflowServer
        /// </summary>
        [DataMember(Name = "connection_flows_sent_to_appflow_server", EmitDefaultValue = false)]
        public string ConnectionFlowsSentToAppflowServer { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionFlowsSentToChassisProcessor
        /// </summary>
        [DataMember(Name = "connection_flows_sent_to_chassis_processor", EmitDefaultValue = false)]
        public string ConnectionFlowsSentToChassisProcessor { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedDynamicFlowsSentToExternalCollector
        /// </summary>
        [DataMember(Name = "non_connection_related_dynamic_flows_sent_to_external_collector", EmitDefaultValue = false)]
        public string NonConnectionRelatedDynamicFlowsSentToExternalCollector { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedDynamicFlowsSentToGmsflowServer
        /// </summary>
        [DataMember(Name = "non_connection_related_dynamic_flows_sent_to_gmsflow_server", EmitDefaultValue = false)]
        public string NonConnectionRelatedDynamicFlowsSentToGmsflowServer { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedDynamicFlowsSentToAppflowServer
        /// </summary>
        [DataMember(Name = "non_connection_related_dynamic_flows_sent_to_appflow_server", EmitDefaultValue = false)]
        public string NonConnectionRelatedDynamicFlowsSentToAppflowServer { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedDynamicFlowsSentToChassisProcessor
        /// </summary>
        [DataMember(Name = "non_connection_related_dynamic_flows_sent_to_chassis_processor", EmitDefaultValue = false)]
        public string NonConnectionRelatedDynamicFlowsSentToChassisProcessor { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedStaticFlowsSentToExternalCollector
        /// </summary>
        [DataMember(Name = "non_connection_related_static_flows_sent_to_external_collector", EmitDefaultValue = false)]
        public string NonConnectionRelatedStaticFlowsSentToExternalCollector { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedStaticFlowsSentToGmsflowServer
        /// </summary>
        [DataMember(Name = "non_connection_related_static_flows_sent_to_gmsflow_server", EmitDefaultValue = false)]
        public string NonConnectionRelatedStaticFlowsSentToGmsflowServer { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedStaticFlowsSentToAppflowServer
        /// </summary>
        [DataMember(Name = "non_connection_related_static_flows_sent_to_appflow_server", EmitDefaultValue = false)]
        public string NonConnectionRelatedStaticFlowsSentToAppflowServer { get; set; }

        /// <summary>
        /// Gets or Sets NonConnectionRelatedStaticFlowsSentToChassisProcessor
        /// </summary>
        [DataMember(Name = "non_connection_related_static_flows_sent_to_chassis_processor", EmitDefaultValue = false)]
        public string NonConnectionRelatedStaticFlowsSentToChassisProcessor { get; set; }

        /// <summary>
        /// Gets or Sets LogsReportedByIpfixToExternalCollector
        /// </summary>
        [DataMember(Name = "logs_reported_by_ipfix_to_external_collector", EmitDefaultValue = false)]
        public string LogsReportedByIpfixToExternalCollector { get; set; }

        /// <summary>
        /// Gets or Sets LogsReportedByIpfixToGmsflowServer
        /// </summary>
        [DataMember(Name = "logs_reported_by_ipfix_to_gmsflow_server", EmitDefaultValue = false)]
        public string LogsReportedByIpfixToGmsflowServer { get; set; }

        /// <summary>
        /// Gets or Sets LogsReportedByIpfixToAppflowServer
        /// </summary>
        [DataMember(Name = "logs_reported_by_ipfix_to_appflow_server", EmitDefaultValue = false)]
        public string LogsReportedByIpfixToAppflowServer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusAppflowIpfixDetail {\n");
            sb.Append("  TotalNetflowIpfixPacketsSent: ").Append(TotalNetflowIpfixPacketsSent).Append("\n");
            sb.Append("  NetflowIpfixPacketsSentToExternalCollector: ").Append(NetflowIpfixPacketsSentToExternalCollector).Append("\n");
            sb.Append("  NetflowIpfixPacketsSentToGmsflowServer: ").Append(NetflowIpfixPacketsSentToGmsflowServer).Append("\n");
            sb.Append("  NetflowIpfixPacketsSentToAppflowServer: ").Append(NetflowIpfixPacketsSentToAppflowServer).Append("\n");
            sb.Append("  NetflowIpfixPacketsSentToChassisProcessor: ").Append(NetflowIpfixPacketsSentToChassisProcessor).Append("\n");
            sb.Append("  NetflowIpfixTemplatesSent: ").Append(NetflowIpfixTemplatesSent).Append("\n");
            sb.Append("  ConnectionFlowsSentToExternalCollector: ").Append(ConnectionFlowsSentToExternalCollector).Append("\n");
            sb.Append("  ConnectionFlowsSentToGmsflowServer: ").Append(ConnectionFlowsSentToGmsflowServer).Append("\n");
            sb.Append("  ConnectionFlowsSentToAppflowServer: ").Append(ConnectionFlowsSentToAppflowServer).Append("\n");
            sb.Append("  ConnectionFlowsSentToChassisProcessor: ").Append(ConnectionFlowsSentToChassisProcessor).Append("\n");
            sb.Append("  NonConnectionRelatedDynamicFlowsSentToExternalCollector: ").Append(NonConnectionRelatedDynamicFlowsSentToExternalCollector).Append("\n");
            sb.Append("  NonConnectionRelatedDynamicFlowsSentToGmsflowServer: ").Append(NonConnectionRelatedDynamicFlowsSentToGmsflowServer).Append("\n");
            sb.Append("  NonConnectionRelatedDynamicFlowsSentToAppflowServer: ").Append(NonConnectionRelatedDynamicFlowsSentToAppflowServer).Append("\n");
            sb.Append("  NonConnectionRelatedDynamicFlowsSentToChassisProcessor: ").Append(NonConnectionRelatedDynamicFlowsSentToChassisProcessor).Append("\n");
            sb.Append("  NonConnectionRelatedStaticFlowsSentToExternalCollector: ").Append(NonConnectionRelatedStaticFlowsSentToExternalCollector).Append("\n");
            sb.Append("  NonConnectionRelatedStaticFlowsSentToGmsflowServer: ").Append(NonConnectionRelatedStaticFlowsSentToGmsflowServer).Append("\n");
            sb.Append("  NonConnectionRelatedStaticFlowsSentToAppflowServer: ").Append(NonConnectionRelatedStaticFlowsSentToAppflowServer).Append("\n");
            sb.Append("  NonConnectionRelatedStaticFlowsSentToChassisProcessor: ").Append(NonConnectionRelatedStaticFlowsSentToChassisProcessor).Append("\n");
            sb.Append("  LogsReportedByIpfixToExternalCollector: ").Append(LogsReportedByIpfixToExternalCollector).Append("\n");
            sb.Append("  LogsReportedByIpfixToGmsflowServer: ").Append(LogsReportedByIpfixToGmsflowServer).Append("\n");
            sb.Append("  LogsReportedByIpfixToAppflowServer: ").Append(LogsReportedByIpfixToAppflowServer).Append("\n");
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
            return this.Equals(input as ShowStatusAppflowIpfixDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusAppflowIpfixDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusAppflowIpfixDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusAppflowIpfixDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TotalNetflowIpfixPacketsSent == input.TotalNetflowIpfixPacketsSent ||
                    (this.TotalNetflowIpfixPacketsSent != null &&
                    this.TotalNetflowIpfixPacketsSent.Equals(input.TotalNetflowIpfixPacketsSent))
                ) && 
                (
                    this.NetflowIpfixPacketsSentToExternalCollector == input.NetflowIpfixPacketsSentToExternalCollector ||
                    (this.NetflowIpfixPacketsSentToExternalCollector != null &&
                    this.NetflowIpfixPacketsSentToExternalCollector.Equals(input.NetflowIpfixPacketsSentToExternalCollector))
                ) && 
                (
                    this.NetflowIpfixPacketsSentToGmsflowServer == input.NetflowIpfixPacketsSentToGmsflowServer ||
                    (this.NetflowIpfixPacketsSentToGmsflowServer != null &&
                    this.NetflowIpfixPacketsSentToGmsflowServer.Equals(input.NetflowIpfixPacketsSentToGmsflowServer))
                ) && 
                (
                    this.NetflowIpfixPacketsSentToAppflowServer == input.NetflowIpfixPacketsSentToAppflowServer ||
                    (this.NetflowIpfixPacketsSentToAppflowServer != null &&
                    this.NetflowIpfixPacketsSentToAppflowServer.Equals(input.NetflowIpfixPacketsSentToAppflowServer))
                ) && 
                (
                    this.NetflowIpfixPacketsSentToChassisProcessor == input.NetflowIpfixPacketsSentToChassisProcessor ||
                    (this.NetflowIpfixPacketsSentToChassisProcessor != null &&
                    this.NetflowIpfixPacketsSentToChassisProcessor.Equals(input.NetflowIpfixPacketsSentToChassisProcessor))
                ) && 
                (
                    this.NetflowIpfixTemplatesSent == input.NetflowIpfixTemplatesSent ||
                    (this.NetflowIpfixTemplatesSent != null &&
                    this.NetflowIpfixTemplatesSent.Equals(input.NetflowIpfixTemplatesSent))
                ) && 
                (
                    this.ConnectionFlowsSentToExternalCollector == input.ConnectionFlowsSentToExternalCollector ||
                    (this.ConnectionFlowsSentToExternalCollector != null &&
                    this.ConnectionFlowsSentToExternalCollector.Equals(input.ConnectionFlowsSentToExternalCollector))
                ) && 
                (
                    this.ConnectionFlowsSentToGmsflowServer == input.ConnectionFlowsSentToGmsflowServer ||
                    (this.ConnectionFlowsSentToGmsflowServer != null &&
                    this.ConnectionFlowsSentToGmsflowServer.Equals(input.ConnectionFlowsSentToGmsflowServer))
                ) && 
                (
                    this.ConnectionFlowsSentToAppflowServer == input.ConnectionFlowsSentToAppflowServer ||
                    (this.ConnectionFlowsSentToAppflowServer != null &&
                    this.ConnectionFlowsSentToAppflowServer.Equals(input.ConnectionFlowsSentToAppflowServer))
                ) && 
                (
                    this.ConnectionFlowsSentToChassisProcessor == input.ConnectionFlowsSentToChassisProcessor ||
                    (this.ConnectionFlowsSentToChassisProcessor != null &&
                    this.ConnectionFlowsSentToChassisProcessor.Equals(input.ConnectionFlowsSentToChassisProcessor))
                ) && 
                (
                    this.NonConnectionRelatedDynamicFlowsSentToExternalCollector == input.NonConnectionRelatedDynamicFlowsSentToExternalCollector ||
                    (this.NonConnectionRelatedDynamicFlowsSentToExternalCollector != null &&
                    this.NonConnectionRelatedDynamicFlowsSentToExternalCollector.Equals(input.NonConnectionRelatedDynamicFlowsSentToExternalCollector))
                ) && 
                (
                    this.NonConnectionRelatedDynamicFlowsSentToGmsflowServer == input.NonConnectionRelatedDynamicFlowsSentToGmsflowServer ||
                    (this.NonConnectionRelatedDynamicFlowsSentToGmsflowServer != null &&
                    this.NonConnectionRelatedDynamicFlowsSentToGmsflowServer.Equals(input.NonConnectionRelatedDynamicFlowsSentToGmsflowServer))
                ) && 
                (
                    this.NonConnectionRelatedDynamicFlowsSentToAppflowServer == input.NonConnectionRelatedDynamicFlowsSentToAppflowServer ||
                    (this.NonConnectionRelatedDynamicFlowsSentToAppflowServer != null &&
                    this.NonConnectionRelatedDynamicFlowsSentToAppflowServer.Equals(input.NonConnectionRelatedDynamicFlowsSentToAppflowServer))
                ) && 
                (
                    this.NonConnectionRelatedDynamicFlowsSentToChassisProcessor == input.NonConnectionRelatedDynamicFlowsSentToChassisProcessor ||
                    (this.NonConnectionRelatedDynamicFlowsSentToChassisProcessor != null &&
                    this.NonConnectionRelatedDynamicFlowsSentToChassisProcessor.Equals(input.NonConnectionRelatedDynamicFlowsSentToChassisProcessor))
                ) && 
                (
                    this.NonConnectionRelatedStaticFlowsSentToExternalCollector == input.NonConnectionRelatedStaticFlowsSentToExternalCollector ||
                    (this.NonConnectionRelatedStaticFlowsSentToExternalCollector != null &&
                    this.NonConnectionRelatedStaticFlowsSentToExternalCollector.Equals(input.NonConnectionRelatedStaticFlowsSentToExternalCollector))
                ) && 
                (
                    this.NonConnectionRelatedStaticFlowsSentToGmsflowServer == input.NonConnectionRelatedStaticFlowsSentToGmsflowServer ||
                    (this.NonConnectionRelatedStaticFlowsSentToGmsflowServer != null &&
                    this.NonConnectionRelatedStaticFlowsSentToGmsflowServer.Equals(input.NonConnectionRelatedStaticFlowsSentToGmsflowServer))
                ) && 
                (
                    this.NonConnectionRelatedStaticFlowsSentToAppflowServer == input.NonConnectionRelatedStaticFlowsSentToAppflowServer ||
                    (this.NonConnectionRelatedStaticFlowsSentToAppflowServer != null &&
                    this.NonConnectionRelatedStaticFlowsSentToAppflowServer.Equals(input.NonConnectionRelatedStaticFlowsSentToAppflowServer))
                ) && 
                (
                    this.NonConnectionRelatedStaticFlowsSentToChassisProcessor == input.NonConnectionRelatedStaticFlowsSentToChassisProcessor ||
                    (this.NonConnectionRelatedStaticFlowsSentToChassisProcessor != null &&
                    this.NonConnectionRelatedStaticFlowsSentToChassisProcessor.Equals(input.NonConnectionRelatedStaticFlowsSentToChassisProcessor))
                ) && 
                (
                    this.LogsReportedByIpfixToExternalCollector == input.LogsReportedByIpfixToExternalCollector ||
                    (this.LogsReportedByIpfixToExternalCollector != null &&
                    this.LogsReportedByIpfixToExternalCollector.Equals(input.LogsReportedByIpfixToExternalCollector))
                ) && 
                (
                    this.LogsReportedByIpfixToGmsflowServer == input.LogsReportedByIpfixToGmsflowServer ||
                    (this.LogsReportedByIpfixToGmsflowServer != null &&
                    this.LogsReportedByIpfixToGmsflowServer.Equals(input.LogsReportedByIpfixToGmsflowServer))
                ) && 
                (
                    this.LogsReportedByIpfixToAppflowServer == input.LogsReportedByIpfixToAppflowServer ||
                    (this.LogsReportedByIpfixToAppflowServer != null &&
                    this.LogsReportedByIpfixToAppflowServer.Equals(input.LogsReportedByIpfixToAppflowServer))
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
                if (this.TotalNetflowIpfixPacketsSent != null)
                {
                    hashCode = (hashCode * 59) + this.TotalNetflowIpfixPacketsSent.GetHashCode();
                }
                if (this.NetflowIpfixPacketsSentToExternalCollector != null)
                {
                    hashCode = (hashCode * 59) + this.NetflowIpfixPacketsSentToExternalCollector.GetHashCode();
                }
                if (this.NetflowIpfixPacketsSentToGmsflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.NetflowIpfixPacketsSentToGmsflowServer.GetHashCode();
                }
                if (this.NetflowIpfixPacketsSentToAppflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.NetflowIpfixPacketsSentToAppflowServer.GetHashCode();
                }
                if (this.NetflowIpfixPacketsSentToChassisProcessor != null)
                {
                    hashCode = (hashCode * 59) + this.NetflowIpfixPacketsSentToChassisProcessor.GetHashCode();
                }
                if (this.NetflowIpfixTemplatesSent != null)
                {
                    hashCode = (hashCode * 59) + this.NetflowIpfixTemplatesSent.GetHashCode();
                }
                if (this.ConnectionFlowsSentToExternalCollector != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionFlowsSentToExternalCollector.GetHashCode();
                }
                if (this.ConnectionFlowsSentToGmsflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionFlowsSentToGmsflowServer.GetHashCode();
                }
                if (this.ConnectionFlowsSentToAppflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionFlowsSentToAppflowServer.GetHashCode();
                }
                if (this.ConnectionFlowsSentToChassisProcessor != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionFlowsSentToChassisProcessor.GetHashCode();
                }
                if (this.NonConnectionRelatedDynamicFlowsSentToExternalCollector != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedDynamicFlowsSentToExternalCollector.GetHashCode();
                }
                if (this.NonConnectionRelatedDynamicFlowsSentToGmsflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedDynamicFlowsSentToGmsflowServer.GetHashCode();
                }
                if (this.NonConnectionRelatedDynamicFlowsSentToAppflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedDynamicFlowsSentToAppflowServer.GetHashCode();
                }
                if (this.NonConnectionRelatedDynamicFlowsSentToChassisProcessor != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedDynamicFlowsSentToChassisProcessor.GetHashCode();
                }
                if (this.NonConnectionRelatedStaticFlowsSentToExternalCollector != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedStaticFlowsSentToExternalCollector.GetHashCode();
                }
                if (this.NonConnectionRelatedStaticFlowsSentToGmsflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedStaticFlowsSentToGmsflowServer.GetHashCode();
                }
                if (this.NonConnectionRelatedStaticFlowsSentToAppflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedStaticFlowsSentToAppflowServer.GetHashCode();
                }
                if (this.NonConnectionRelatedStaticFlowsSentToChassisProcessor != null)
                {
                    hashCode = (hashCode * 59) + this.NonConnectionRelatedStaticFlowsSentToChassisProcessor.GetHashCode();
                }
                if (this.LogsReportedByIpfixToExternalCollector != null)
                {
                    hashCode = (hashCode * 59) + this.LogsReportedByIpfixToExternalCollector.GetHashCode();
                }
                if (this.LogsReportedByIpfixToGmsflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.LogsReportedByIpfixToGmsflowServer.GetHashCode();
                }
                if (this.LogsReportedByIpfixToAppflowServer != null)
                {
                    hashCode = (hashCode * 59) + this.LogsReportedByIpfixToAppflowServer.GetHashCode();
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
