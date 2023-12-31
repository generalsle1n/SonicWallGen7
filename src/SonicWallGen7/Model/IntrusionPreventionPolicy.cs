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
    /// Intrusion prevention policy configuration.
    /// </summary>
    [DataContract(Name = "intrusion_prevention_policy")]
    public partial class IntrusionPreventionPolicy : IEquatable<IntrusionPreventionPolicy>, IValidatableObject
    {
        /// <summary>
        /// Set IPS policy priority.
        /// </summary>
        /// <value>Set IPS policy priority.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 1,

            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 2,

            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 3
        }


        /// <summary>
        /// Set IPS policy priority.
        /// </summary>
        /// <value>Set IPS policy priority.</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionPolicy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntrusionPreventionPolicy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionPolicy" /> class.
        /// </summary>
        /// <param name="id">Category ID or polcy ID. (required).</param>
        /// <param name="name">Category name or policy name..</param>
        /// <param name="category">IPS policy&#39;s category name..</param>
        /// <param name="prevention">prevention.</param>
        /// <param name="detection">detection.</param>
        /// <param name="included">included.</param>
        /// <param name="excluded">excluded.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="logRedundancy">logRedundancy.</param>
        /// <param name="priority">Set IPS policy priority..</param>
        /// <param name="direction">direction.</param>
        public IntrusionPreventionPolicy(decimal id = default(decimal), string name = default(string), string category = default(string), IntrusionPreventionPolicyPrevention prevention = default(IntrusionPreventionPolicyPrevention), IntrusionPreventionPolicyDetection detection = default(IntrusionPreventionPolicyDetection), IntrusionPreventionPolicyIncluded included = default(IntrusionPreventionPolicyIncluded), IntrusionPreventionPolicyExcluded excluded = default(IntrusionPreventionPolicyExcluded), IntrusionPreventionPolicySchedule schedule = default(IntrusionPreventionPolicySchedule), IntrusionPreventionPolicyLogRedundancy logRedundancy = default(IntrusionPreventionPolicyLogRedundancy), PriorityEnum? priority = default(PriorityEnum?), IntrusionPreventionPolicyDirection direction = default(IntrusionPreventionPolicyDirection))
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Prevention = prevention;
            this.Detection = detection;
            this.Included = included;
            this.Excluded = excluded;
            this.Schedule = schedule;
            this.LogRedundancy = logRedundancy;
            this.Priority = priority;
            this.Direction = direction;
        }

        /// <summary>
        /// Category ID or polcy ID.
        /// </summary>
        /// <value>Category ID or polcy ID.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public decimal Id { get; set; }

        /// <summary>
        /// Category name or policy name.
        /// </summary>
        /// <value>Category name or policy name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// IPS policy&#39;s category name.
        /// </summary>
        /// <value>IPS policy&#39;s category name.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Prevention
        /// </summary>
        [DataMember(Name = "prevention", EmitDefaultValue = false)]
        public IntrusionPreventionPolicyPrevention Prevention { get; set; }

        /// <summary>
        /// Gets or Sets Detection
        /// </summary>
        [DataMember(Name = "detection", EmitDefaultValue = false)]
        public IntrusionPreventionPolicyDetection Detection { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name = "included", EmitDefaultValue = false)]
        public IntrusionPreventionPolicyIncluded Included { get; set; }

        /// <summary>
        /// Gets or Sets Excluded
        /// </summary>
        [DataMember(Name = "excluded", EmitDefaultValue = false)]
        public IntrusionPreventionPolicyExcluded Excluded { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public IntrusionPreventionPolicySchedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets LogRedundancy
        /// </summary>
        [DataMember(Name = "log_redundancy", EmitDefaultValue = false)]
        public IntrusionPreventionPolicyLogRedundancy LogRedundancy { get; set; }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public IntrusionPreventionPolicyDirection Direction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntrusionPreventionPolicy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Prevention: ").Append(Prevention).Append("\n");
            sb.Append("  Detection: ").Append(Detection).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Excluded: ").Append(Excluded).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  LogRedundancy: ").Append(LogRedundancy).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as IntrusionPreventionPolicy);
        }

        /// <summary>
        /// Returns true if IntrusionPreventionPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of IntrusionPreventionPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntrusionPreventionPolicy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Prevention == input.Prevention ||
                    (this.Prevention != null &&
                    this.Prevention.Equals(input.Prevention))
                ) && 
                (
                    this.Detection == input.Detection ||
                    (this.Detection != null &&
                    this.Detection.Equals(input.Detection))
                ) && 
                (
                    this.Included == input.Included ||
                    (this.Included != null &&
                    this.Included.Equals(input.Included))
                ) && 
                (
                    this.Excluded == input.Excluded ||
                    (this.Excluded != null &&
                    this.Excluded.Equals(input.Excluded))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.LogRedundancy == input.LogRedundancy ||
                    (this.LogRedundancy != null &&
                    this.LogRedundancy.Equals(input.LogRedundancy))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Prevention != null)
                {
                    hashCode = (hashCode * 59) + this.Prevention.GetHashCode();
                }
                if (this.Detection != null)
                {
                    hashCode = (hashCode * 59) + this.Detection.GetHashCode();
                }
                if (this.Included != null)
                {
                    hashCode = (hashCode * 59) + this.Included.GetHashCode();
                }
                if (this.Excluded != null)
                {
                    hashCode = (hashCode * 59) + this.Excluded.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.LogRedundancy != null)
                {
                    hashCode = (hashCode * 59) + this.LogRedundancy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                if (this.Direction != null)
                {
                    hashCode = (hashCode * 59) + this.Direction.GetHashCode();
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
