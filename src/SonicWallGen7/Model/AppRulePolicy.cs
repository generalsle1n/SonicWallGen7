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
    /// App rules policy configuration.
    /// </summary>
    [DataContract(Name = "app_rule_policy")]
    public partial class AppRulePolicy : IEquatable<AppRulePolicy>, IValidatableObject
    {
        /// <summary>
        /// Set connection side.
        /// </summary>
        /// <value>Set connection side.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectionSideEnum
        {
            /// <summary>
            /// Enum Client for value: client
            /// </summary>
            [EnumMember(Value = "client")]
            Client = 1,

            /// <summary>
            /// Enum Server for value: server
            /// </summary>
            [EnumMember(Value = "server")]
            Server = 2,

            /// <summary>
            /// Enum Both for value: both
            /// </summary>
            [EnumMember(Value = "both")]
            Both = 3
        }


        /// <summary>
        /// Set connection side.
        /// </summary>
        /// <value>Set connection side.</value>
        [DataMember(Name = "connection_side", EmitDefaultValue = false)]
        public ConnectionSideEnum? ConnectionSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppRulePolicy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicy" /> class.
        /// </summary>
        /// <param name="name">App rule name. (required).</param>
        /// <param name="enable">Enable app rule policy..</param>
        /// <param name="type">type.</param>
        /// <param name="source">source.</param>
        /// <param name="destination">destination.</param>
        /// <param name="address">address.</param>
        /// <param name="exclusion">exclusion.</param>
        /// <param name="matchObject">matchObject.</param>
        /// <param name="actionObject">Set action object for this app rule policy..</param>
        /// <param name="users">users.</param>
        /// <param name="mailFrom">mailFrom.</param>
        /// <param name="rcptTo">rcptTo.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="flowReporting">Enable flow reporting..</param>
        /// <param name="logging">Enable logging when this app rule is used..</param>
        /// <param name="log">log.</param>
        /// <param name="ipsMessageFormat">Enable log using IPS message format..</param>
        /// <param name="appControlMessageFormat">Enable log using app control message format..</param>
        /// <param name="cfsMessageFormat">Enable log using CFS message format..</param>
        /// <param name="connectionSide">Set connection side..</param>
        /// <param name="direction">direction.</param>
        /// <param name="zone">zone.</param>
        /// <param name="cfsList">cfsList.</param>
        /// <param name="safeSearch">Enable safe search enforcement..</param>
        /// <param name="youtubeForSchools">Enable YouTube for schools..</param>
        /// <param name="schoolId">Set CFS school id..</param>
        public AppRulePolicy(string name = default(string), bool enable = default(bool), AppRulePolicyType type = default(AppRulePolicyType), AppRulePolicySource source = default(AppRulePolicySource), AppRulePolicyDestination destination = default(AppRulePolicyDestination), AppRulePolicyAddress address = default(AppRulePolicyAddress), AppRulePolicyExclusion exclusion = default(AppRulePolicyExclusion), AppRulePolicyMatchObject matchObject = default(AppRulePolicyMatchObject), string actionObject = default(string), AppRulePolicyUsers users = default(AppRulePolicyUsers), AppRulePolicyMailFrom mailFrom = default(AppRulePolicyMailFrom), AppRulePolicyRcptTo rcptTo = default(AppRulePolicyRcptTo), AppRulePolicySchedule schedule = default(AppRulePolicySchedule), bool flowReporting = default(bool), bool logging = default(bool), AppRulePolicyLog log = default(AppRulePolicyLog), bool ipsMessageFormat = default(bool), bool appControlMessageFormat = default(bool), bool cfsMessageFormat = default(bool), ConnectionSideEnum? connectionSide = default(ConnectionSideEnum?), AppRulePolicyDirection direction = default(AppRulePolicyDirection), AppRulePolicyZone zone = default(AppRulePolicyZone), AppRulePolicyCfsList cfsList = default(AppRulePolicyCfsList), bool safeSearch = default(bool), bool youtubeForSchools = default(bool), string schoolId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AppRulePolicy and cannot be null");
            }
            this.Name = name;
            this.Enable = enable;
            this.Type = type;
            this.Source = source;
            this.Destination = destination;
            this.Address = address;
            this.Exclusion = exclusion;
            this.MatchObject = matchObject;
            this.ActionObject = actionObject;
            this.Users = users;
            this.MailFrom = mailFrom;
            this.RcptTo = rcptTo;
            this.Schedule = schedule;
            this.FlowReporting = flowReporting;
            this.Logging = logging;
            this.Log = log;
            this.IpsMessageFormat = ipsMessageFormat;
            this.AppControlMessageFormat = appControlMessageFormat;
            this.CfsMessageFormat = cfsMessageFormat;
            this.ConnectionSide = connectionSide;
            this.Direction = direction;
            this.Zone = zone;
            this.CfsList = cfsList;
            this.SafeSearch = safeSearch;
            this.YoutubeForSchools = youtubeForSchools;
            this.SchoolId = schoolId;
        }

        /// <summary>
        /// App rule name.
        /// </summary>
        /// <value>App rule name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Enable app rule policy.
        /// </summary>
        /// <value>Enable app rule policy.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public AppRulePolicyType Type { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public AppRulePolicySource Source { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public AppRulePolicyDestination Destination { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AppRulePolicyAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Exclusion
        /// </summary>
        [DataMember(Name = "exclusion", EmitDefaultValue = false)]
        public AppRulePolicyExclusion Exclusion { get; set; }

        /// <summary>
        /// Gets or Sets MatchObject
        /// </summary>
        [DataMember(Name = "match_object", EmitDefaultValue = false)]
        public AppRulePolicyMatchObject MatchObject { get; set; }

        /// <summary>
        /// Set action object for this app rule policy.
        /// </summary>
        /// <value>Set action object for this app rule policy.</value>
        [DataMember(Name = "action_object", EmitDefaultValue = false)]
        public string ActionObject { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public AppRulePolicyUsers Users { get; set; }

        /// <summary>
        /// Gets or Sets MailFrom
        /// </summary>
        [DataMember(Name = "mail_from", EmitDefaultValue = false)]
        public AppRulePolicyMailFrom MailFrom { get; set; }

        /// <summary>
        /// Gets or Sets RcptTo
        /// </summary>
        [DataMember(Name = "rcpt_to", EmitDefaultValue = false)]
        public AppRulePolicyRcptTo RcptTo { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public AppRulePolicySchedule Schedule { get; set; }

        /// <summary>
        /// Enable flow reporting.
        /// </summary>
        /// <value>Enable flow reporting.</value>
        [DataMember(Name = "flow_reporting", EmitDefaultValue = true)]
        public bool FlowReporting { get; set; }

        /// <summary>
        /// Enable logging when this app rule is used.
        /// </summary>
        /// <value>Enable logging when this app rule is used.</value>
        [DataMember(Name = "logging", EmitDefaultValue = true)]
        public bool Logging { get; set; }

        /// <summary>
        /// Gets or Sets Log
        /// </summary>
        [DataMember(Name = "log", EmitDefaultValue = false)]
        public AppRulePolicyLog Log { get; set; }

        /// <summary>
        /// Enable log using IPS message format.
        /// </summary>
        /// <value>Enable log using IPS message format.</value>
        [DataMember(Name = "ips_message_format", EmitDefaultValue = true)]
        public bool IpsMessageFormat { get; set; }

        /// <summary>
        /// Enable log using app control message format.
        /// </summary>
        /// <value>Enable log using app control message format.</value>
        [DataMember(Name = "app_control_message_format", EmitDefaultValue = true)]
        public bool AppControlMessageFormat { get; set; }

        /// <summary>
        /// Enable log using CFS message format.
        /// </summary>
        /// <value>Enable log using CFS message format.</value>
        [DataMember(Name = "cfs_message_format", EmitDefaultValue = true)]
        public bool CfsMessageFormat { get; set; }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public AppRulePolicyDirection Direction { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name = "zone", EmitDefaultValue = false)]
        public AppRulePolicyZone Zone { get; set; }

        /// <summary>
        /// Gets or Sets CfsList
        /// </summary>
        [DataMember(Name = "cfs_list", EmitDefaultValue = false)]
        public AppRulePolicyCfsList CfsList { get; set; }

        /// <summary>
        /// Enable safe search enforcement.
        /// </summary>
        /// <value>Enable safe search enforcement.</value>
        [DataMember(Name = "safe_search", EmitDefaultValue = true)]
        public bool SafeSearch { get; set; }

        /// <summary>
        /// Enable YouTube for schools.
        /// </summary>
        /// <value>Enable YouTube for schools.</value>
        [DataMember(Name = "youtube_for_schools", EmitDefaultValue = true)]
        public bool YoutubeForSchools { get; set; }

        /// <summary>
        /// Set CFS school id.
        /// </summary>
        /// <value>Set CFS school id.</value>
        [DataMember(Name = "school_id", EmitDefaultValue = false)]
        public string SchoolId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRulePolicy {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Exclusion: ").Append(Exclusion).Append("\n");
            sb.Append("  MatchObject: ").Append(MatchObject).Append("\n");
            sb.Append("  ActionObject: ").Append(ActionObject).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  MailFrom: ").Append(MailFrom).Append("\n");
            sb.Append("  RcptTo: ").Append(RcptTo).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  FlowReporting: ").Append(FlowReporting).Append("\n");
            sb.Append("  Logging: ").Append(Logging).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
            sb.Append("  IpsMessageFormat: ").Append(IpsMessageFormat).Append("\n");
            sb.Append("  AppControlMessageFormat: ").Append(AppControlMessageFormat).Append("\n");
            sb.Append("  CfsMessageFormat: ").Append(CfsMessageFormat).Append("\n");
            sb.Append("  ConnectionSide: ").Append(ConnectionSide).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  CfsList: ").Append(CfsList).Append("\n");
            sb.Append("  SafeSearch: ").Append(SafeSearch).Append("\n");
            sb.Append("  YoutubeForSchools: ").Append(YoutubeForSchools).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
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
            return this.Equals(input as AppRulePolicy);
        }

        /// <summary>
        /// Returns true if AppRulePolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRulePolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRulePolicy input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Exclusion == input.Exclusion ||
                    (this.Exclusion != null &&
                    this.Exclusion.Equals(input.Exclusion))
                ) && 
                (
                    this.MatchObject == input.MatchObject ||
                    (this.MatchObject != null &&
                    this.MatchObject.Equals(input.MatchObject))
                ) && 
                (
                    this.ActionObject == input.ActionObject ||
                    (this.ActionObject != null &&
                    this.ActionObject.Equals(input.ActionObject))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.MailFrom == input.MailFrom ||
                    (this.MailFrom != null &&
                    this.MailFrom.Equals(input.MailFrom))
                ) && 
                (
                    this.RcptTo == input.RcptTo ||
                    (this.RcptTo != null &&
                    this.RcptTo.Equals(input.RcptTo))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.FlowReporting == input.FlowReporting ||
                    this.FlowReporting.Equals(input.FlowReporting)
                ) && 
                (
                    this.Logging == input.Logging ||
                    this.Logging.Equals(input.Logging)
                ) && 
                (
                    this.Log == input.Log ||
                    (this.Log != null &&
                    this.Log.Equals(input.Log))
                ) && 
                (
                    this.IpsMessageFormat == input.IpsMessageFormat ||
                    this.IpsMessageFormat.Equals(input.IpsMessageFormat)
                ) && 
                (
                    this.AppControlMessageFormat == input.AppControlMessageFormat ||
                    this.AppControlMessageFormat.Equals(input.AppControlMessageFormat)
                ) && 
                (
                    this.CfsMessageFormat == input.CfsMessageFormat ||
                    this.CfsMessageFormat.Equals(input.CfsMessageFormat)
                ) && 
                (
                    this.ConnectionSide == input.ConnectionSide ||
                    this.ConnectionSide.Equals(input.ConnectionSide)
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
                ) && 
                (
                    this.CfsList == input.CfsList ||
                    (this.CfsList != null &&
                    this.CfsList.Equals(input.CfsList))
                ) && 
                (
                    this.SafeSearch == input.SafeSearch ||
                    this.SafeSearch.Equals(input.SafeSearch)
                ) && 
                (
                    this.YoutubeForSchools == input.YoutubeForSchools ||
                    this.YoutubeForSchools.Equals(input.YoutubeForSchools)
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Exclusion != null)
                {
                    hashCode = (hashCode * 59) + this.Exclusion.GetHashCode();
                }
                if (this.MatchObject != null)
                {
                    hashCode = (hashCode * 59) + this.MatchObject.GetHashCode();
                }
                if (this.ActionObject != null)
                {
                    hashCode = (hashCode * 59) + this.ActionObject.GetHashCode();
                }
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
                }
                if (this.MailFrom != null)
                {
                    hashCode = (hashCode * 59) + this.MailFrom.GetHashCode();
                }
                if (this.RcptTo != null)
                {
                    hashCode = (hashCode * 59) + this.RcptTo.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FlowReporting.GetHashCode();
                hashCode = (hashCode * 59) + this.Logging.GetHashCode();
                if (this.Log != null)
                {
                    hashCode = (hashCode * 59) + this.Log.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IpsMessageFormat.GetHashCode();
                hashCode = (hashCode * 59) + this.AppControlMessageFormat.GetHashCode();
                hashCode = (hashCode * 59) + this.CfsMessageFormat.GetHashCode();
                hashCode = (hashCode * 59) + this.ConnectionSide.GetHashCode();
                if (this.Direction != null)
                {
                    hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                }
                if (this.Zone != null)
                {
                    hashCode = (hashCode * 59) + this.Zone.GetHashCode();
                }
                if (this.CfsList != null)
                {
                    hashCode = (hashCode * 59) + this.CfsList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SafeSearch.GetHashCode();
                hashCode = (hashCode * 59) + this.YoutubeForSchools.GetHashCode();
                if (this.SchoolId != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
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
