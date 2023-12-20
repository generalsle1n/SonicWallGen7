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
    /// IPv4 access rule.
    /// </summary>
    [DataContract(Name = "access_rule_ipv4_ipv4")]
    public partial class AccessRuleIpv4Ipv4 : IEquatable<AccessRuleIpv4Ipv4>, IValidatableObject
    {
        /// <summary>
        /// Set the action for this access rule.
        /// </summary>
        /// <value>Set the action for this access rule.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Allow for value: allow
            /// </summary>
            [EnumMember(Value = "allow")]
            Allow = 1,

            /// <summary>
            /// Enum Deny for value: deny
            /// </summary>
            [EnumMember(Value = "deny")]
            Deny = 2,

            /// <summary>
            /// Enum Discard for value: discard
            /// </summary>
            [EnumMember(Value = "discard")]
            Discard = 3
        }


        /// <summary>
        /// Set the action for this access rule.
        /// </summary>
        /// <value>Set the action for this access rule.</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessRuleIpv4Ipv4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4" /> class.
        /// </summary>
        /// <param name="from">Source zone. (required).</param>
        /// <param name="to">Destination zone. (required).</param>
        /// <param name="action">Set the action for this access rule. (required).</param>
        /// <param name="source">source (required).</param>
        /// <param name="service">service (required).</param>
        /// <param name="destination">destination (required).</param>
        /// <param name="schedule">schedule (required).</param>
        /// <param name="users">users.</param>
        /// <param name="uuid">Access rule UUID..</param>
        /// <param name="name">Name of access rule..</param>
        /// <param name="comment">Set comment to help identify this access rule..</param>
        /// <param name="enable">Enable this access rule..</param>
        /// <param name="autoRule">Indicate it is an auto rule..</param>
        /// <param name="reflexive">Configure a reflexive rule..</param>
        /// <param name="maxConnections">Set the number of connections allowed (% maximum connections)..</param>
        /// <param name="logging">Enable logging when this access rule is used..</param>
        /// <param name="sip">Enable SIP transformation..</param>
        /// <param name="h323">Enable H.323 transformation..</param>
        /// <param name="management">Allow management traffic..</param>
        /// <param name="packetMonitoring">Enable packet monitoring..</param>
        /// <param name="packetDissectionFilter">packetDissectionFilter.</param>
        /// <param name="priority">priority.</param>
        /// <param name="tcp">tcp.</param>
        /// <param name="udp">udp.</param>
        /// <param name="fragments">Allow fragmented packets on this access rule..</param>
        /// <param name="botnetFilter">Enable Botnet filter..</param>
        /// <param name="connectionLimit">connectionLimit.</param>
        /// <param name="dpi">Enable DPI..</param>
        /// <param name="dpiSsl">dpiSsl.</param>
        /// <param name="flowReporting">Enable flow reporting..</param>
        /// <param name="geoIpFilter">geoIpFilter.</param>
        /// <param name="block">block.</param>
        /// <param name="qualityOfService">qualityOfService.</param>
        /// <param name="cosOverride">Allow 802.1p marking to override DSCP values..</param>
        /// <param name="bandwidthManagement">bandwidthManagement.</param>
        /// <param name="ticket">ticket.</param>
        /// <param name="singleSignOn">Invoke single sign on to authenticate users..</param>
        /// <param name="redirectUnauthenticatedUsersToLogIn">Enable redirect unauthenticated users to log in..</param>
        /// <param name="blockTrafficForSingleSignOn">Block traffic while waiting for Single Sign On to authenticate users..</param>
        public AccessRuleIpv4Ipv4(string from = default(string), string to = default(string), ActionEnum action = default(ActionEnum), AccessRuleIpv4Ipv4Source source = default(AccessRuleIpv4Ipv4Source), AccessRuleIpv4Ipv4Service service = default(AccessRuleIpv4Ipv4Service), AccessRuleIpv4Ipv4Destination destination = default(AccessRuleIpv4Ipv4Destination), AccessRuleIpv4Ipv4Schedule schedule = default(AccessRuleIpv4Ipv4Schedule), AccessRuleIpv4Ipv4Users users = default(AccessRuleIpv4Ipv4Users), string uuid = default(string), string name = default(string), string comment = default(string), bool enable = default(bool), bool autoRule = default(bool), bool reflexive = default(bool), decimal maxConnections = default(decimal), bool logging = default(bool), bool sip = default(bool), bool h323 = default(bool), bool management = default(bool), bool packetMonitoring = default(bool), AccessRuleIpv4Ipv4PacketDissectionFilter packetDissectionFilter = default(AccessRuleIpv4Ipv4PacketDissectionFilter), AccessRuleIpv4Ipv4Priority priority = default(AccessRuleIpv4Ipv4Priority), AccessRuleIpv4Ipv4Tcp tcp = default(AccessRuleIpv4Ipv4Tcp), SecurityActionProfilesUdp udp = default(SecurityActionProfilesUdp), bool fragments = default(bool), bool botnetFilter = default(bool), AccessRuleIpv4Ipv4ConnectionLimit connectionLimit = default(AccessRuleIpv4Ipv4ConnectionLimit), bool dpi = default(bool), AccessRuleIpv4Ipv4DpiSsl dpiSsl = default(AccessRuleIpv4Ipv4DpiSsl), bool flowReporting = default(bool), AccessRuleIpv4Ipv4GeoIpFilter geoIpFilter = default(AccessRuleIpv4Ipv4GeoIpFilter), AccessRuleIpv4Ipv4Block block = default(AccessRuleIpv4Ipv4Block), AccessRuleIpv4Ipv4QualityOfService qualityOfService = default(AccessRuleIpv4Ipv4QualityOfService), bool cosOverride = default(bool), AccessRuleIpv4Ipv4BandwidthManagement bandwidthManagement = default(AccessRuleIpv4Ipv4BandwidthManagement), AccessRuleIpv4Ipv4Ticket ticket = default(AccessRuleIpv4Ipv4Ticket), bool singleSignOn = default(bool), bool redirectUnauthenticatedUsersToLogIn = default(bool), bool blockTrafficForSingleSignOn = default(bool))
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for AccessRuleIpv4Ipv4 and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for AccessRuleIpv4Ipv4 and cannot be null");
            }
            this.To = to;
            this.Action = action;
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for AccessRuleIpv4Ipv4 and cannot be null");
            }
            this.Source = source;
            // to ensure "service" is required (not null)
            if (service == null)
            {
                throw new ArgumentNullException("service is a required property for AccessRuleIpv4Ipv4 and cannot be null");
            }
            this.Service = service;
            // to ensure "destination" is required (not null)
            if (destination == null)
            {
                throw new ArgumentNullException("destination is a required property for AccessRuleIpv4Ipv4 and cannot be null");
            }
            this.Destination = destination;
            // to ensure "schedule" is required (not null)
            if (schedule == null)
            {
                throw new ArgumentNullException("schedule is a required property for AccessRuleIpv4Ipv4 and cannot be null");
            }
            this.Schedule = schedule;
            this.Users = users;
            this.Uuid = uuid;
            this.Name = name;
            this.Comment = comment;
            this.Enable = enable;
            this.AutoRule = autoRule;
            this.Reflexive = reflexive;
            this.MaxConnections = maxConnections;
            this.Logging = logging;
            this.Sip = sip;
            this.H323 = h323;
            this.Management = management;
            this.PacketMonitoring = packetMonitoring;
            this.PacketDissectionFilter = packetDissectionFilter;
            this.Priority = priority;
            this.Tcp = tcp;
            this.Udp = udp;
            this.Fragments = fragments;
            this.BotnetFilter = botnetFilter;
            this.ConnectionLimit = connectionLimit;
            this.Dpi = dpi;
            this.DpiSsl = dpiSsl;
            this.FlowReporting = flowReporting;
            this.GeoIpFilter = geoIpFilter;
            this.Block = block;
            this.QualityOfService = qualityOfService;
            this.CosOverride = cosOverride;
            this.BandwidthManagement = bandwidthManagement;
            this.Ticket = ticket;
            this.SingleSignOn = singleSignOn;
            this.RedirectUnauthenticatedUsersToLogIn = redirectUnauthenticatedUsersToLogIn;
            this.BlockTrafficForSingleSignOn = blockTrafficForSingleSignOn;
        }

        /// <summary>
        /// Source zone.
        /// </summary>
        /// <value>Source zone.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Destination zone.
        /// </summary>
        /// <value>Destination zone.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public AccessRuleIpv4Ipv4Source Source { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", IsRequired = true, EmitDefaultValue = true)]
        public AccessRuleIpv4Ipv4Service Service { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", IsRequired = true, EmitDefaultValue = true)]
        public AccessRuleIpv4Ipv4Destination Destination { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", IsRequired = true, EmitDefaultValue = true)]
        public AccessRuleIpv4Ipv4Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4Users Users { get; set; }

        /// <summary>
        /// Access rule UUID.
        /// </summary>
        /// <value>Access rule UUID.</value>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Name of access rule.
        /// </summary>
        /// <value>Name of access rule.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Set comment to help identify this access rule.
        /// </summary>
        /// <value>Set comment to help identify this access rule.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Enable this access rule.
        /// </summary>
        /// <value>Enable this access rule.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Indicate it is an auto rule.
        /// </summary>
        /// <value>Indicate it is an auto rule.</value>
        [DataMember(Name = "auto_rule", EmitDefaultValue = true)]
        public bool AutoRule { get; set; }

        /// <summary>
        /// Configure a reflexive rule.
        /// </summary>
        /// <value>Configure a reflexive rule.</value>
        [DataMember(Name = "reflexive", EmitDefaultValue = true)]
        public bool Reflexive { get; set; }

        /// <summary>
        /// Set the number of connections allowed (% maximum connections).
        /// </summary>
        /// <value>Set the number of connections allowed (% maximum connections).</value>
        [DataMember(Name = "max_connections", EmitDefaultValue = false)]
        public decimal MaxConnections { get; set; }

        /// <summary>
        /// Enable logging when this access rule is used.
        /// </summary>
        /// <value>Enable logging when this access rule is used.</value>
        [DataMember(Name = "logging", EmitDefaultValue = true)]
        public bool Logging { get; set; }

        /// <summary>
        /// Enable SIP transformation.
        /// </summary>
        /// <value>Enable SIP transformation.</value>
        [DataMember(Name = "sip", EmitDefaultValue = true)]
        public bool Sip { get; set; }

        /// <summary>
        /// Enable H.323 transformation.
        /// </summary>
        /// <value>Enable H.323 transformation.</value>
        [DataMember(Name = "h323", EmitDefaultValue = true)]
        public bool H323 { get; set; }

        /// <summary>
        /// Allow management traffic.
        /// </summary>
        /// <value>Allow management traffic.</value>
        [DataMember(Name = "management", EmitDefaultValue = true)]
        public bool Management { get; set; }

        /// <summary>
        /// Enable packet monitoring.
        /// </summary>
        /// <value>Enable packet monitoring.</value>
        [DataMember(Name = "packet_monitoring", EmitDefaultValue = true)]
        public bool PacketMonitoring { get; set; }

        /// <summary>
        /// Gets or Sets PacketDissectionFilter
        /// </summary>
        [DataMember(Name = "packet_dissection_filter", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4PacketDissectionFilter PacketDissectionFilter { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4Priority Priority { get; set; }

        /// <summary>
        /// Gets or Sets Tcp
        /// </summary>
        [DataMember(Name = "tcp", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4Tcp Tcp { get; set; }

        /// <summary>
        /// Gets or Sets Udp
        /// </summary>
        [DataMember(Name = "udp", EmitDefaultValue = false)]
        public SecurityActionProfilesUdp Udp { get; set; }

        /// <summary>
        /// Allow fragmented packets on this access rule.
        /// </summary>
        /// <value>Allow fragmented packets on this access rule.</value>
        [DataMember(Name = "fragments", EmitDefaultValue = true)]
        public bool Fragments { get; set; }

        /// <summary>
        /// Enable Botnet filter.
        /// </summary>
        /// <value>Enable Botnet filter.</value>
        [DataMember(Name = "botnet_filter", EmitDefaultValue = true)]
        public bool BotnetFilter { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionLimit
        /// </summary>
        [DataMember(Name = "connection_limit", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4ConnectionLimit ConnectionLimit { get; set; }

        /// <summary>
        /// Enable DPI.
        /// </summary>
        /// <value>Enable DPI.</value>
        [DataMember(Name = "dpi", EmitDefaultValue = true)]
        public bool Dpi { get; set; }

        /// <summary>
        /// Gets or Sets DpiSsl
        /// </summary>
        [DataMember(Name = "dpi_ssl", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4DpiSsl DpiSsl { get; set; }

        /// <summary>
        /// Enable flow reporting.
        /// </summary>
        /// <value>Enable flow reporting.</value>
        [DataMember(Name = "flow_reporting", EmitDefaultValue = true)]
        public bool FlowReporting { get; set; }

        /// <summary>
        /// Gets or Sets GeoIpFilter
        /// </summary>
        [DataMember(Name = "geo_ip_filter", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4GeoIpFilter GeoIpFilter { get; set; }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name = "block", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4Block Block { get; set; }

        /// <summary>
        /// Gets or Sets QualityOfService
        /// </summary>
        [DataMember(Name = "quality_of_service", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4QualityOfService QualityOfService { get; set; }

        /// <summary>
        /// Allow 802.1p marking to override DSCP values.
        /// </summary>
        /// <value>Allow 802.1p marking to override DSCP values.</value>
        [DataMember(Name = "cos_override", EmitDefaultValue = true)]
        public bool CosOverride { get; set; }

        /// <summary>
        /// Gets or Sets BandwidthManagement
        /// </summary>
        [DataMember(Name = "bandwidth_management", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4BandwidthManagement BandwidthManagement { get; set; }

        /// <summary>
        /// Gets or Sets Ticket
        /// </summary>
        [DataMember(Name = "ticket", EmitDefaultValue = false)]
        public AccessRuleIpv4Ipv4Ticket Ticket { get; set; }

        /// <summary>
        /// Invoke single sign on to authenticate users.
        /// </summary>
        /// <value>Invoke single sign on to authenticate users.</value>
        [DataMember(Name = "single_sign_on", EmitDefaultValue = true)]
        public bool SingleSignOn { get; set; }

        /// <summary>
        /// Enable redirect unauthenticated users to log in.
        /// </summary>
        /// <value>Enable redirect unauthenticated users to log in.</value>
        [DataMember(Name = "redirect_unauthenticated_users_to_log_in", EmitDefaultValue = true)]
        public bool RedirectUnauthenticatedUsersToLogIn { get; set; }

        /// <summary>
        /// Block traffic while waiting for Single Sign On to authenticate users.
        /// </summary>
        /// <value>Block traffic while waiting for Single Sign On to authenticate users.</value>
        [DataMember(Name = "block_traffic_for_single_sign_on", EmitDefaultValue = true)]
        public bool BlockTrafficForSingleSignOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessRuleIpv4Ipv4 {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  AutoRule: ").Append(AutoRule).Append("\n");
            sb.Append("  Reflexive: ").Append(Reflexive).Append("\n");
            sb.Append("  MaxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("  Logging: ").Append(Logging).Append("\n");
            sb.Append("  Sip: ").Append(Sip).Append("\n");
            sb.Append("  H323: ").Append(H323).Append("\n");
            sb.Append("  Management: ").Append(Management).Append("\n");
            sb.Append("  PacketMonitoring: ").Append(PacketMonitoring).Append("\n");
            sb.Append("  PacketDissectionFilter: ").Append(PacketDissectionFilter).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Tcp: ").Append(Tcp).Append("\n");
            sb.Append("  Udp: ").Append(Udp).Append("\n");
            sb.Append("  Fragments: ").Append(Fragments).Append("\n");
            sb.Append("  BotnetFilter: ").Append(BotnetFilter).Append("\n");
            sb.Append("  ConnectionLimit: ").Append(ConnectionLimit).Append("\n");
            sb.Append("  Dpi: ").Append(Dpi).Append("\n");
            sb.Append("  DpiSsl: ").Append(DpiSsl).Append("\n");
            sb.Append("  FlowReporting: ").Append(FlowReporting).Append("\n");
            sb.Append("  GeoIpFilter: ").Append(GeoIpFilter).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  QualityOfService: ").Append(QualityOfService).Append("\n");
            sb.Append("  CosOverride: ").Append(CosOverride).Append("\n");
            sb.Append("  BandwidthManagement: ").Append(BandwidthManagement).Append("\n");
            sb.Append("  Ticket: ").Append(Ticket).Append("\n");
            sb.Append("  SingleSignOn: ").Append(SingleSignOn).Append("\n");
            sb.Append("  RedirectUnauthenticatedUsersToLogIn: ").Append(RedirectUnauthenticatedUsersToLogIn).Append("\n");
            sb.Append("  BlockTrafficForSingleSignOn: ").Append(BlockTrafficForSingleSignOn).Append("\n");
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
            return this.Equals(input as AccessRuleIpv4Ipv4);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv4Ipv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv4Ipv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv4Ipv4 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.AutoRule == input.AutoRule ||
                    this.AutoRule.Equals(input.AutoRule)
                ) && 
                (
                    this.Reflexive == input.Reflexive ||
                    this.Reflexive.Equals(input.Reflexive)
                ) && 
                (
                    this.MaxConnections == input.MaxConnections ||
                    this.MaxConnections.Equals(input.MaxConnections)
                ) && 
                (
                    this.Logging == input.Logging ||
                    this.Logging.Equals(input.Logging)
                ) && 
                (
                    this.Sip == input.Sip ||
                    this.Sip.Equals(input.Sip)
                ) && 
                (
                    this.H323 == input.H323 ||
                    this.H323.Equals(input.H323)
                ) && 
                (
                    this.Management == input.Management ||
                    this.Management.Equals(input.Management)
                ) && 
                (
                    this.PacketMonitoring == input.PacketMonitoring ||
                    this.PacketMonitoring.Equals(input.PacketMonitoring)
                ) && 
                (
                    this.PacketDissectionFilter == input.PacketDissectionFilter ||
                    (this.PacketDissectionFilter != null &&
                    this.PacketDissectionFilter.Equals(input.PacketDissectionFilter))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Tcp == input.Tcp ||
                    (this.Tcp != null &&
                    this.Tcp.Equals(input.Tcp))
                ) && 
                (
                    this.Udp == input.Udp ||
                    (this.Udp != null &&
                    this.Udp.Equals(input.Udp))
                ) && 
                (
                    this.Fragments == input.Fragments ||
                    this.Fragments.Equals(input.Fragments)
                ) && 
                (
                    this.BotnetFilter == input.BotnetFilter ||
                    this.BotnetFilter.Equals(input.BotnetFilter)
                ) && 
                (
                    this.ConnectionLimit == input.ConnectionLimit ||
                    (this.ConnectionLimit != null &&
                    this.ConnectionLimit.Equals(input.ConnectionLimit))
                ) && 
                (
                    this.Dpi == input.Dpi ||
                    this.Dpi.Equals(input.Dpi)
                ) && 
                (
                    this.DpiSsl == input.DpiSsl ||
                    (this.DpiSsl != null &&
                    this.DpiSsl.Equals(input.DpiSsl))
                ) && 
                (
                    this.FlowReporting == input.FlowReporting ||
                    this.FlowReporting.Equals(input.FlowReporting)
                ) && 
                (
                    this.GeoIpFilter == input.GeoIpFilter ||
                    (this.GeoIpFilter != null &&
                    this.GeoIpFilter.Equals(input.GeoIpFilter))
                ) && 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.QualityOfService == input.QualityOfService ||
                    (this.QualityOfService != null &&
                    this.QualityOfService.Equals(input.QualityOfService))
                ) && 
                (
                    this.CosOverride == input.CosOverride ||
                    this.CosOverride.Equals(input.CosOverride)
                ) && 
                (
                    this.BandwidthManagement == input.BandwidthManagement ||
                    (this.BandwidthManagement != null &&
                    this.BandwidthManagement.Equals(input.BandwidthManagement))
                ) && 
                (
                    this.Ticket == input.Ticket ||
                    (this.Ticket != null &&
                    this.Ticket.Equals(input.Ticket))
                ) && 
                (
                    this.SingleSignOn == input.SingleSignOn ||
                    this.SingleSignOn.Equals(input.SingleSignOn)
                ) && 
                (
                    this.RedirectUnauthenticatedUsersToLogIn == input.RedirectUnauthenticatedUsersToLogIn ||
                    this.RedirectUnauthenticatedUsersToLogIn.Equals(input.RedirectUnauthenticatedUsersToLogIn)
                ) && 
                (
                    this.BlockTrafficForSingleSignOn == input.BlockTrafficForSingleSignOn ||
                    this.BlockTrafficForSingleSignOn.Equals(input.BlockTrafficForSingleSignOn)
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
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoRule.GetHashCode();
                hashCode = (hashCode * 59) + this.Reflexive.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxConnections.GetHashCode();
                hashCode = (hashCode * 59) + this.Logging.GetHashCode();
                hashCode = (hashCode * 59) + this.Sip.GetHashCode();
                hashCode = (hashCode * 59) + this.H323.GetHashCode();
                hashCode = (hashCode * 59) + this.Management.GetHashCode();
                hashCode = (hashCode * 59) + this.PacketMonitoring.GetHashCode();
                if (this.PacketDissectionFilter != null)
                {
                    hashCode = (hashCode * 59) + this.PacketDissectionFilter.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.Tcp != null)
                {
                    hashCode = (hashCode * 59) + this.Tcp.GetHashCode();
                }
                if (this.Udp != null)
                {
                    hashCode = (hashCode * 59) + this.Udp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Fragments.GetHashCode();
                hashCode = (hashCode * 59) + this.BotnetFilter.GetHashCode();
                if (this.ConnectionLimit != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionLimit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Dpi.GetHashCode();
                if (this.DpiSsl != null)
                {
                    hashCode = (hashCode * 59) + this.DpiSsl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FlowReporting.GetHashCode();
                if (this.GeoIpFilter != null)
                {
                    hashCode = (hashCode * 59) + this.GeoIpFilter.GetHashCode();
                }
                if (this.Block != null)
                {
                    hashCode = (hashCode * 59) + this.Block.GetHashCode();
                }
                if (this.QualityOfService != null)
                {
                    hashCode = (hashCode * 59) + this.QualityOfService.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CosOverride.GetHashCode();
                if (this.BandwidthManagement != null)
                {
                    hashCode = (hashCode * 59) + this.BandwidthManagement.GetHashCode();
                }
                if (this.Ticket != null)
                {
                    hashCode = (hashCode * 59) + this.Ticket.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SingleSignOn.GetHashCode();
                hashCode = (hashCode * 59) + this.RedirectUnauthenticatedUsersToLogIn.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockTrafficForSingleSignOn.GetHashCode();
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
