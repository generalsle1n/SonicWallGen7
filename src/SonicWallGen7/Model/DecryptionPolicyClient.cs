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
    /// Client decryption policy config.
    /// </summary>
    [DataContract(Name = "decryption_policy_client")]
    public partial class DecryptionPolicyClient : IEquatable<DecryptionPolicyClient>, IValidatableObject
    {
        /// <summary>
        /// Ip version.
        /// </summary>
        /// <value>Ip version.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IpTypeEnum
        {
            /// <summary>
            /// Enum Ipv4 for value: ipv4
            /// </summary>
            [EnumMember(Value = "ipv4")]
            Ipv4 = 1,

            /// <summary>
            /// Enum Ipv6 for value: ipv6
            /// </summary>
            [EnumMember(Value = "ipv6")]
            Ipv6 = 2
        }


        /// <summary>
        /// Ip version.
        /// </summary>
        /// <value>Ip version.</value>
        [DataMember(Name = "ip_type", EmitDefaultValue = false)]
        public IpTypeEnum? IpType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptionPolicyClient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecryptionPolicyClient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptionPolicyClient" /> class.
        /// </summary>
        /// <param name="uuid">Decryption policy UUID. (required).</param>
        /// <param name="name">Name of decryption policy..</param>
        /// <param name="comment">Decryption policy comment..</param>
        /// <param name="enable">Enable decryption policy..</param>
        /// <param name="priority">priority.</param>
        /// <param name="source">source.</param>
        /// <param name="destination">destination.</param>
        /// <param name="service">service.</param>
        /// <param name="users">users.</param>
        /// <param name="webCategory">webCategory.</param>
        /// <param name="webSite">webSite.</param>
        /// <param name="matchOperation">matchOperation.</param>
        /// <param name="country">country.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="action">action.</param>
        /// <param name="ticket">ticket.</param>
        /// <param name="ipType">Ip version..</param>
        public DecryptionPolicyClient(string uuid = default(string), string name = default(string), string comment = default(string), bool enable = default(bool), DecryptionPolicyClientPriority priority = default(DecryptionPolicyClientPriority), DecryptionPolicyClientSource source = default(DecryptionPolicyClientSource), DecryptionPolicyClientDestination destination = default(DecryptionPolicyClientDestination), DecryptionPolicyClientService service = default(DecryptionPolicyClientService), DecryptionPolicyClientUsers users = default(DecryptionPolicyClientUsers), DecryptionPolicyClientWebCategory webCategory = default(DecryptionPolicyClientWebCategory), DecryptionPolicyClientWebSite webSite = default(DecryptionPolicyClientWebSite), DecryptionPolicyClientMatchOperation matchOperation = default(DecryptionPolicyClientMatchOperation), DecryptionPolicyClientCountry country = default(DecryptionPolicyClientCountry), DecryptionPolicyClientSchedule schedule = default(DecryptionPolicyClientSchedule), DecryptionPolicyClientAction action = default(DecryptionPolicyClientAction), DecryptionPolicyClientTicket ticket = default(DecryptionPolicyClientTicket), IpTypeEnum? ipType = default(IpTypeEnum?))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for DecryptionPolicyClient and cannot be null");
            }
            this.Uuid = uuid;
            this.Name = name;
            this.Comment = comment;
            this.Enable = enable;
            this.Priority = priority;
            this.Source = source;
            this.Destination = destination;
            this.Service = service;
            this.Users = users;
            this.WebCategory = webCategory;
            this.WebSite = webSite;
            this.MatchOperation = matchOperation;
            this.Country = country;
            this.Schedule = schedule;
            this.Action = action;
            this.Ticket = ticket;
            this.IpType = ipType;
        }

        /// <summary>
        /// Decryption policy UUID.
        /// </summary>
        /// <value>Decryption policy UUID.</value>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Name of decryption policy.
        /// </summary>
        /// <value>Name of decryption policy.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Decryption policy comment.
        /// </summary>
        /// <value>Decryption policy comment.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Enable decryption policy.
        /// </summary>
        /// <value>Enable decryption policy.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public DecryptionPolicyClientPriority Priority { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public DecryptionPolicyClientSource Source { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public DecryptionPolicyClientDestination Destination { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public DecryptionPolicyClientService Service { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public DecryptionPolicyClientUsers Users { get; set; }

        /// <summary>
        /// Gets or Sets WebCategory
        /// </summary>
        [DataMember(Name = "web_category", EmitDefaultValue = false)]
        public DecryptionPolicyClientWebCategory WebCategory { get; set; }

        /// <summary>
        /// Gets or Sets WebSite
        /// </summary>
        [DataMember(Name = "web_site", EmitDefaultValue = false)]
        public DecryptionPolicyClientWebSite WebSite { get; set; }

        /// <summary>
        /// Gets or Sets MatchOperation
        /// </summary>
        [DataMember(Name = "match_operation", EmitDefaultValue = false)]
        public DecryptionPolicyClientMatchOperation MatchOperation { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public DecryptionPolicyClientCountry Country { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public DecryptionPolicyClientSchedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public DecryptionPolicyClientAction Action { get; set; }

        /// <summary>
        /// Gets or Sets Ticket
        /// </summary>
        [DataMember(Name = "ticket", EmitDefaultValue = false)]
        public DecryptionPolicyClientTicket Ticket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DecryptionPolicyClient {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  WebCategory: ").Append(WebCategory).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
            sb.Append("  MatchOperation: ").Append(MatchOperation).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Ticket: ").Append(Ticket).Append("\n");
            sb.Append("  IpType: ").Append(IpType).Append("\n");
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
            return this.Equals(input as DecryptionPolicyClient);
        }

        /// <summary>
        /// Returns true if DecryptionPolicyClient instances are equal
        /// </summary>
        /// <param name="input">Instance of DecryptionPolicyClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecryptionPolicyClient input)
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
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                    this.WebCategory == input.WebCategory ||
                    (this.WebCategory != null &&
                    this.WebCategory.Equals(input.WebCategory))
                ) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
                ) && 
                (
                    this.MatchOperation == input.MatchOperation ||
                    (this.MatchOperation != null &&
                    this.MatchOperation.Equals(input.MatchOperation))
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
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Ticket == input.Ticket ||
                    (this.Ticket != null &&
                    this.Ticket.Equals(input.Ticket))
                ) && 
                (
                    this.IpType == input.IpType ||
                    this.IpType.Equals(input.IpType)
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
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
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
                if (this.WebCategory != null)
                {
                    hashCode = (hashCode * 59) + this.WebCategory.GetHashCode();
                }
                if (this.WebSite != null)
                {
                    hashCode = (hashCode * 59) + this.WebSite.GetHashCode();
                }
                if (this.MatchOperation != null)
                {
                    hashCode = (hashCode * 59) + this.MatchOperation.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Ticket != null)
                {
                    hashCode = (hashCode * 59) + this.Ticket.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IpType.GetHashCode();
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