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
    /// ShowStatusLogCategoriesEventCountListInner
    /// </summary>
    [DataContract(Name = "show_status_log_categories_event_count_list_inner")]
    public partial class ShowStatusLogCategoriesEventCountListInner : IEquatable<ShowStatusLogCategoriesEventCountListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusLogCategoriesEventCountListInner" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="level">level.</param>
        /// <param name="eventCount">eventCount.</param>
        /// <param name="overflow">overflow.</param>
        /// <param name="gui">gui.</param>
        /// <param name="alert">alert.</param>
        /// <param name="syslog">syslog.</param>
        /// <param name="email">email.</param>
        /// <param name="priority">priority.</param>
        /// <param name="eventRate">eventRate.</param>
        /// <param name="dataRate">dataRate.</param>
        public ShowStatusLogCategoriesEventCountListInner(string name = default(string), string id = default(string), string level = default(string), string eventCount = default(string), string overflow = default(string), string gui = default(string), string alert = default(string), string syslog = default(string), string email = default(string), string priority = default(string), string eventRate = default(string), string dataRate = default(string))
        {
            this.Name = name;
            this.Id = id;
            this.Level = level;
            this.EventCount = eventCount;
            this.Overflow = overflow;
            this.Gui = gui;
            this.Alert = alert;
            this.Syslog = syslog;
            this.Email = email;
            this.Priority = priority;
            this.EventRate = eventRate;
            this.DataRate = dataRate;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets EventCount
        /// </summary>
        [DataMember(Name = "event_count", EmitDefaultValue = false)]
        public string EventCount { get; set; }

        /// <summary>
        /// Gets or Sets Overflow
        /// </summary>
        [DataMember(Name = "overflow", EmitDefaultValue = false)]
        public string Overflow { get; set; }

        /// <summary>
        /// Gets or Sets Gui
        /// </summary>
        [DataMember(Name = "gui", EmitDefaultValue = false)]
        public string Gui { get; set; }

        /// <summary>
        /// Gets or Sets Alert
        /// </summary>
        [DataMember(Name = "alert", EmitDefaultValue = false)]
        public string Alert { get; set; }

        /// <summary>
        /// Gets or Sets Syslog
        /// </summary>
        [DataMember(Name = "syslog", EmitDefaultValue = false)]
        public string Syslog { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets EventRate
        /// </summary>
        [DataMember(Name = "event_rate", EmitDefaultValue = false)]
        public string EventRate { get; set; }

        /// <summary>
        /// Gets or Sets DataRate
        /// </summary>
        [DataMember(Name = "data_rate", EmitDefaultValue = false)]
        public string DataRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusLogCategoriesEventCountListInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  EventCount: ").Append(EventCount).Append("\n");
            sb.Append("  Overflow: ").Append(Overflow).Append("\n");
            sb.Append("  Gui: ").Append(Gui).Append("\n");
            sb.Append("  Alert: ").Append(Alert).Append("\n");
            sb.Append("  Syslog: ").Append(Syslog).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  EventRate: ").Append(EventRate).Append("\n");
            sb.Append("  DataRate: ").Append(DataRate).Append("\n");
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
            return this.Equals(input as ShowStatusLogCategoriesEventCountListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusLogCategoriesEventCountListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusLogCategoriesEventCountListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusLogCategoriesEventCountListInner input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.EventCount == input.EventCount ||
                    (this.EventCount != null &&
                    this.EventCount.Equals(input.EventCount))
                ) && 
                (
                    this.Overflow == input.Overflow ||
                    (this.Overflow != null &&
                    this.Overflow.Equals(input.Overflow))
                ) && 
                (
                    this.Gui == input.Gui ||
                    (this.Gui != null &&
                    this.Gui.Equals(input.Gui))
                ) && 
                (
                    this.Alert == input.Alert ||
                    (this.Alert != null &&
                    this.Alert.Equals(input.Alert))
                ) && 
                (
                    this.Syslog == input.Syslog ||
                    (this.Syslog != null &&
                    this.Syslog.Equals(input.Syslog))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.EventRate == input.EventRate ||
                    (this.EventRate != null &&
                    this.EventRate.Equals(input.EventRate))
                ) && 
                (
                    this.DataRate == input.DataRate ||
                    (this.DataRate != null &&
                    this.DataRate.Equals(input.DataRate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.EventCount != null)
                {
                    hashCode = (hashCode * 59) + this.EventCount.GetHashCode();
                }
                if (this.Overflow != null)
                {
                    hashCode = (hashCode * 59) + this.Overflow.GetHashCode();
                }
                if (this.Gui != null)
                {
                    hashCode = (hashCode * 59) + this.Gui.GetHashCode();
                }
                if (this.Alert != null)
                {
                    hashCode = (hashCode * 59) + this.Alert.GetHashCode();
                }
                if (this.Syslog != null)
                {
                    hashCode = (hashCode * 59) + this.Syslog.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.EventRate != null)
                {
                    hashCode = (hashCode * 59) + this.EventRate.GetHashCode();
                }
                if (this.DataRate != null)
                {
                    hashCode = (hashCode * 59) + this.DataRate.GetHashCode();
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
