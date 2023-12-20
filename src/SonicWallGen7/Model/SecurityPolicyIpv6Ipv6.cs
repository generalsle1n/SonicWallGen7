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
    /// IPv6 security policy.
    /// </summary>
    [DataContract(Name = "security_policy_ipv6_ipv6")]
    public partial class SecurityPolicyIpv6Ipv6 : IEquatable<SecurityPolicyIpv6Ipv6>, IValidatableObject
    {
        /// <summary>
        /// Specify the match operation for this security policy.
        /// </summary>
        /// <value>Specify the match operation for this security policy.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatchOperationEnum
        {
            /// <summary>
            /// Enum Or for value: or
            /// </summary>
            [EnumMember(Value = "or")]
            Or = 1,

            /// <summary>
            /// Enum And for value: and
            /// </summary>
            [EnumMember(Value = "and")]
            And = 2
        }


        /// <summary>
        /// Specify the match operation for this security policy.
        /// </summary>
        /// <value>Specify the match operation for this security policy.</value>
        [DataMember(Name = "match_operation", EmitDefaultValue = false)]
        public MatchOperationEnum? MatchOperation { get; set; }
        /// <summary>
        /// Set the action for this security policy.
        /// </summary>
        /// <value>Set the action for this security policy.</value>
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
        /// Set the action for this security policy.
        /// </summary>
        /// <value>Set the action for this security policy.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityPolicyIpv6Ipv6" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecurityPolicyIpv6Ipv6() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityPolicyIpv6Ipv6" /> class.
        /// </summary>
        /// <param name="uuid">Security policy UUID. (required).</param>
        /// <param name="name">Name of security policy..</param>
        /// <param name="priority">priority.</param>
        /// <param name="comment">Security policy comment..</param>
        /// <param name="enable">Enable security policy..</param>
        /// <param name="from">From..</param>
        /// <param name="to">Destination..</param>
        /// <param name="source">source.</param>
        /// <param name="destination">destination.</param>
        /// <param name="service">service.</param>
        /// <param name="users">users.</param>
        /// <param name="matchOperation">Specify the match operation for this security policy..</param>
        /// <param name="application">application.</param>
        /// <param name="andAllMatchedApplications">AND all matched applicationsr..</param>
        /// <param name="webCategory">webCategory.</param>
        /// <param name="urlList">urlList.</param>
        /// <param name="customMatch">customMatch.</param>
        /// <param name="country">country.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="action">Set the action for this security policy..</param>
        /// <param name="actionProfile">Assign action profile to security policy..</param>
        /// <param name="ticket">ticket.</param>
        public SecurityPolicyIpv6Ipv6(string uuid = default(string), string name = default(string), SecurityPolicyIpv6Ipv6Priority priority = default(SecurityPolicyIpv6Ipv6Priority), string comment = default(string), bool enable = default(bool), string from = default(string), string to = default(string), SecurityPolicyIpv6Ipv6Source source = default(SecurityPolicyIpv6Ipv6Source), SecurityPolicyIpv6Ipv6Destination destination = default(SecurityPolicyIpv6Ipv6Destination), SecurityPolicyIpv6Ipv6Service service = default(SecurityPolicyIpv6Ipv6Service), SecurityPolicyIpv6Ipv6Users users = default(SecurityPolicyIpv6Ipv6Users), MatchOperationEnum? matchOperation = default(MatchOperationEnum?), SecurityPolicyIpv6Ipv6Application application = default(SecurityPolicyIpv6Ipv6Application), bool andAllMatchedApplications = default(bool), SecurityPolicyIpv6Ipv6WebCategory webCategory = default(SecurityPolicyIpv6Ipv6WebCategory), SecurityPolicyIpv6Ipv6UrlList urlList = default(SecurityPolicyIpv6Ipv6UrlList), SecurityPolicyIpv6Ipv6CustomMatch customMatch = default(SecurityPolicyIpv6Ipv6CustomMatch), SecurityPolicyIpv6Ipv6Country country = default(SecurityPolicyIpv6Ipv6Country), SecurityPolicyIpv6Ipv6Schedule schedule = default(SecurityPolicyIpv6Ipv6Schedule), ActionEnum? action = default(ActionEnum?), string actionProfile = default(string), SecurityPolicyIpv4Ipv4Ticket ticket = default(SecurityPolicyIpv4Ipv4Ticket))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for SecurityPolicyIpv6Ipv6 and cannot be null");
            }
            this.Uuid = uuid;
            this.Name = name;
            this.Priority = priority;
            this.Comment = comment;
            this.Enable = enable;
            this.From = from;
            this.To = to;
            this.Source = source;
            this.Destination = destination;
            this.Service = service;
            this.Users = users;
            this.MatchOperation = matchOperation;
            this.Application = application;
            this.AndAllMatchedApplications = andAllMatchedApplications;
            this.WebCategory = webCategory;
            this.UrlList = urlList;
            this.CustomMatch = customMatch;
            this.Country = country;
            this.Schedule = schedule;
            this.Action = action;
            this.ActionProfile = actionProfile;
            this.Ticket = ticket;
        }

        /// <summary>
        /// Security policy UUID.
        /// </summary>
        /// <value>Security policy UUID.</value>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Name of security policy.
        /// </summary>
        /// <value>Name of security policy.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Priority Priority { get; set; }

        /// <summary>
        /// Security policy comment.
        /// </summary>
        /// <value>Security policy comment.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Enable security policy.
        /// </summary>
        /// <value>Enable security policy.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// From.
        /// </summary>
        /// <value>From.</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Destination.
        /// </summary>
        /// <value>Destination.</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Source Source { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Destination Destination { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Service Service { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Users Users { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Application Application { get; set; }

        /// <summary>
        /// AND all matched applicationsr.
        /// </summary>
        /// <value>AND all matched applicationsr.</value>
        [DataMember(Name = "and_all_matched_applications", EmitDefaultValue = true)]
        public bool AndAllMatchedApplications { get; set; }

        /// <summary>
        /// Gets or Sets WebCategory
        /// </summary>
        [DataMember(Name = "web_category", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6WebCategory WebCategory { get; set; }

        /// <summary>
        /// Gets or Sets UrlList
        /// </summary>
        [DataMember(Name = "url_list", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6UrlList UrlList { get; set; }

        /// <summary>
        /// Gets or Sets CustomMatch
        /// </summary>
        [DataMember(Name = "custom_match", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6CustomMatch CustomMatch { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Country Country { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public SecurityPolicyIpv6Ipv6Schedule Schedule { get; set; }

        /// <summary>
        /// Assign action profile to security policy.
        /// </summary>
        /// <value>Assign action profile to security policy.</value>
        [DataMember(Name = "action_profile", EmitDefaultValue = false)]
        public string ActionProfile { get; set; }

        /// <summary>
        /// Gets or Sets Ticket
        /// </summary>
        [DataMember(Name = "ticket", EmitDefaultValue = false)]
        public SecurityPolicyIpv4Ipv4Ticket Ticket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityPolicyIpv6Ipv6 {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  MatchOperation: ").Append(MatchOperation).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  AndAllMatchedApplications: ").Append(AndAllMatchedApplications).Append("\n");
            sb.Append("  WebCategory: ").Append(WebCategory).Append("\n");
            sb.Append("  UrlList: ").Append(UrlList).Append("\n");
            sb.Append("  CustomMatch: ").Append(CustomMatch).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionProfile: ").Append(ActionProfile).Append("\n");
            sb.Append("  Ticket: ").Append(Ticket).Append("\n");
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
            return this.Equals(input as SecurityPolicyIpv6Ipv6);
        }

        /// <summary>
        /// Returns true if SecurityPolicyIpv6Ipv6 instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityPolicyIpv6Ipv6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityPolicyIpv6Ipv6 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.MatchOperation == input.MatchOperation ||
                    this.MatchOperation.Equals(input.MatchOperation)
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.AndAllMatchedApplications == input.AndAllMatchedApplications ||
                    this.AndAllMatchedApplications.Equals(input.AndAllMatchedApplications)
                ) && 
                (
                    this.WebCategory == input.WebCategory ||
                    (this.WebCategory != null &&
                    this.WebCategory.Equals(input.WebCategory))
                ) && 
                (
                    this.UrlList == input.UrlList ||
                    (this.UrlList != null &&
                    this.UrlList.Equals(input.UrlList))
                ) && 
                (
                    this.CustomMatch == input.CustomMatch ||
                    (this.CustomMatch != null &&
                    this.CustomMatch.Equals(input.CustomMatch))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.ActionProfile == input.ActionProfile ||
                    (this.ActionProfile != null &&
                    this.ActionProfile.Equals(input.ActionProfile))
                ) && 
                (
                    this.Ticket == input.Ticket ||
                    (this.Ticket != null &&
                    this.Ticket.Equals(input.Ticket))
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
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.Users != null)
                {
                    hashCode = (hashCode * 59) + this.Users.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MatchOperation.GetHashCode();
                if (this.Application != null)
                {
                    hashCode = (hashCode * 59) + this.Application.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AndAllMatchedApplications.GetHashCode();
                if (this.WebCategory != null)
                {
                    hashCode = (hashCode * 59) + this.WebCategory.GetHashCode();
                }
                if (this.UrlList != null)
                {
                    hashCode = (hashCode * 59) + this.UrlList.GetHashCode();
                }
                if (this.CustomMatch != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMatch.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                if (this.ActionProfile != null)
                {
                    hashCode = (hashCode * 59) + this.ActionProfile.GetHashCode();
                }
                if (this.Ticket != null)
                {
                    hashCode = (hashCode * 59) + this.Ticket.GetHashCode();
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
