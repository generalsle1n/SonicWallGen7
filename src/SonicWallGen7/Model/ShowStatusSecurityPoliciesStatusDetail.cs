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
    /// security policies status detail schema.
    /// </summary>
    [DataContract(Name = "show_status_security_policies_status_detail")]
    public partial class ShowStatusSecurityPoliciesStatusDetail : IEquatable<ShowStatusSecurityPoliciesStatusDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusSecurityPoliciesStatusDetail" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="id">id.</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="source">source.</param>
        /// <param name="destination">destination.</param>
        /// <param name="sourceport">sourceport.</param>
        /// <param name="service">service.</param>
        /// <param name="action">action.</param>
        /// <param name="enable">enable.</param>
        /// <param name="rxbytes">rxbytes.</param>
        /// <param name="rxpackets">rxpackets.</param>
        /// <param name="txbytes">txbytes.</param>
        /// <param name="txpackets">txpackets.</param>
        /// <param name="usage">usage.</param>
        /// <param name="timeLastHit">timeLastHit.</param>
        /// <param name="timeCreated">timeCreated.</param>
        /// <param name="timeUpdated">timeUpdated.</param>
        /// <param name="iptype">iptype.</param>
        public ShowStatusSecurityPoliciesStatusDetail(string uuid = default(string), string id = default(string), string from = default(string), string to = default(string), string source = default(string), string destination = default(string), string sourceport = default(string), string service = default(string), string action = default(string), string enable = default(string), string rxbytes = default(string), string rxpackets = default(string), string txbytes = default(string), string txpackets = default(string), string usage = default(string), string timeLastHit = default(string), string timeCreated = default(string), string timeUpdated = default(string), string iptype = default(string))
        {
            this.Uuid = uuid;
            this.Id = id;
            this.From = from;
            this.To = to;
            this.Source = source;
            this.Destination = destination;
            this.Sourceport = sourceport;
            this.Service = service;
            this.Action = action;
            this.Enable = enable;
            this.Rxbytes = rxbytes;
            this.Rxpackets = rxpackets;
            this.Txbytes = txbytes;
            this.Txpackets = txpackets;
            this.Usage = usage;
            this.TimeLastHit = timeLastHit;
            this.TimeCreated = timeCreated;
            this.TimeUpdated = timeUpdated;
            this.Iptype = iptype;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Sourceport
        /// </summary>
        [DataMember(Name = "sourceport", EmitDefaultValue = false)]
        public string Sourceport { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name = "enable", EmitDefaultValue = false)]
        public string Enable { get; set; }

        /// <summary>
        /// Gets or Sets Rxbytes
        /// </summary>
        [DataMember(Name = "rxbytes", EmitDefaultValue = false)]
        public string Rxbytes { get; set; }

        /// <summary>
        /// Gets or Sets Rxpackets
        /// </summary>
        [DataMember(Name = "rxpackets", EmitDefaultValue = false)]
        public string Rxpackets { get; set; }

        /// <summary>
        /// Gets or Sets Txbytes
        /// </summary>
        [DataMember(Name = "txbytes", EmitDefaultValue = false)]
        public string Txbytes { get; set; }

        /// <summary>
        /// Gets or Sets Txpackets
        /// </summary>
        [DataMember(Name = "txpackets", EmitDefaultValue = false)]
        public string Txpackets { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        public string Usage { get; set; }

        /// <summary>
        /// Gets or Sets TimeLastHit
        /// </summary>
        [DataMember(Name = "time_last_hit", EmitDefaultValue = false)]
        public string TimeLastHit { get; set; }

        /// <summary>
        /// Gets or Sets TimeCreated
        /// </summary>
        [DataMember(Name = "time_created", EmitDefaultValue = false)]
        public string TimeCreated { get; set; }

        /// <summary>
        /// Gets or Sets TimeUpdated
        /// </summary>
        [DataMember(Name = "time_updated", EmitDefaultValue = false)]
        public string TimeUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Iptype
        /// </summary>
        [DataMember(Name = "iptype", EmitDefaultValue = false)]
        public string Iptype { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusSecurityPoliciesStatusDetail {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Sourceport: ").Append(Sourceport).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Rxbytes: ").Append(Rxbytes).Append("\n");
            sb.Append("  Rxpackets: ").Append(Rxpackets).Append("\n");
            sb.Append("  Txbytes: ").Append(Txbytes).Append("\n");
            sb.Append("  Txpackets: ").Append(Txpackets).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  TimeLastHit: ").Append(TimeLastHit).Append("\n");
            sb.Append("  TimeCreated: ").Append(TimeCreated).Append("\n");
            sb.Append("  TimeUpdated: ").Append(TimeUpdated).Append("\n");
            sb.Append("  Iptype: ").Append(Iptype).Append("\n");
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
            return this.Equals(input as ShowStatusSecurityPoliciesStatusDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusSecurityPoliciesStatusDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusSecurityPoliciesStatusDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusSecurityPoliciesStatusDetail input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Sourceport == input.Sourceport ||
                    (this.Sourceport != null &&
                    this.Sourceport.Equals(input.Sourceport))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.Rxbytes == input.Rxbytes ||
                    (this.Rxbytes != null &&
                    this.Rxbytes.Equals(input.Rxbytes))
                ) && 
                (
                    this.Rxpackets == input.Rxpackets ||
                    (this.Rxpackets != null &&
                    this.Rxpackets.Equals(input.Rxpackets))
                ) && 
                (
                    this.Txbytes == input.Txbytes ||
                    (this.Txbytes != null &&
                    this.Txbytes.Equals(input.Txbytes))
                ) && 
                (
                    this.Txpackets == input.Txpackets ||
                    (this.Txpackets != null &&
                    this.Txpackets.Equals(input.Txpackets))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
                ) && 
                (
                    this.TimeLastHit == input.TimeLastHit ||
                    (this.TimeLastHit != null &&
                    this.TimeLastHit.Equals(input.TimeLastHit))
                ) && 
                (
                    this.TimeCreated == input.TimeCreated ||
                    (this.TimeCreated != null &&
                    this.TimeCreated.Equals(input.TimeCreated))
                ) && 
                (
                    this.TimeUpdated == input.TimeUpdated ||
                    (this.TimeUpdated != null &&
                    this.TimeUpdated.Equals(input.TimeUpdated))
                ) && 
                (
                    this.Iptype == input.Iptype ||
                    (this.Iptype != null &&
                    this.Iptype.Equals(input.Iptype))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
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
                if (this.Sourceport != null)
                {
                    hashCode = (hashCode * 59) + this.Sourceport.GetHashCode();
                }
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Enable != null)
                {
                    hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                }
                if (this.Rxbytes != null)
                {
                    hashCode = (hashCode * 59) + this.Rxbytes.GetHashCode();
                }
                if (this.Rxpackets != null)
                {
                    hashCode = (hashCode * 59) + this.Rxpackets.GetHashCode();
                }
                if (this.Txbytes != null)
                {
                    hashCode = (hashCode * 59) + this.Txbytes.GetHashCode();
                }
                if (this.Txpackets != null)
                {
                    hashCode = (hashCode * 59) + this.Txpackets.GetHashCode();
                }
                if (this.Usage != null)
                {
                    hashCode = (hashCode * 59) + this.Usage.GetHashCode();
                }
                if (this.TimeLastHit != null)
                {
                    hashCode = (hashCode * 59) + this.TimeLastHit.GetHashCode();
                }
                if (this.TimeCreated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeCreated.GetHashCode();
                }
                if (this.TimeUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.TimeUpdated.GetHashCode();
                }
                if (this.Iptype != null)
                {
                    hashCode = (hashCode * 59) + this.Iptype.GetHashCode();
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
