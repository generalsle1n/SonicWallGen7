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
    /// Intrusion prevention category configuration.
    /// </summary>
    [DataContract(Name = "intrusion_prevention_category")]
    public partial class IntrusionPreventionCategory : IEquatable<IntrusionPreventionCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntrusionPreventionCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionCategory" /> class.
        /// </summary>
        /// <param name="id">Category ID or polcy ID. (required).</param>
        /// <param name="name">Category name or policy name..</param>
        /// <param name="prevention">prevention.</param>
        /// <param name="detection">detection.</param>
        /// <param name="included">included.</param>
        /// <param name="excluded">excluded.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="logRedundancy">logRedundancy.</param>
        public IntrusionPreventionCategory(decimal id = default(decimal), string name = default(string), IntrusionPreventionCategoryPrevention prevention = default(IntrusionPreventionCategoryPrevention), IntrusionPreventionCategoryDetection detection = default(IntrusionPreventionCategoryDetection), IntrusionPreventionCategoryIncluded included = default(IntrusionPreventionCategoryIncluded), IntrusionPreventionCategoryExcluded excluded = default(IntrusionPreventionCategoryExcluded), IntrusionPreventionCategorySchedule schedule = default(IntrusionPreventionCategorySchedule), IntrusionPreventionCategoryLogRedundancy logRedundancy = default(IntrusionPreventionCategoryLogRedundancy))
        {
            this.Id = id;
            this.Name = name;
            this.Prevention = prevention;
            this.Detection = detection;
            this.Included = included;
            this.Excluded = excluded;
            this.Schedule = schedule;
            this.LogRedundancy = logRedundancy;
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
        /// Gets or Sets Prevention
        /// </summary>
        [DataMember(Name = "prevention", EmitDefaultValue = false)]
        public IntrusionPreventionCategoryPrevention Prevention { get; set; }

        /// <summary>
        /// Gets or Sets Detection
        /// </summary>
        [DataMember(Name = "detection", EmitDefaultValue = false)]
        public IntrusionPreventionCategoryDetection Detection { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name = "included", EmitDefaultValue = false)]
        public IntrusionPreventionCategoryIncluded Included { get; set; }

        /// <summary>
        /// Gets or Sets Excluded
        /// </summary>
        [DataMember(Name = "excluded", EmitDefaultValue = false)]
        public IntrusionPreventionCategoryExcluded Excluded { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public IntrusionPreventionCategorySchedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets LogRedundancy
        /// </summary>
        [DataMember(Name = "log_redundancy", EmitDefaultValue = false)]
        public IntrusionPreventionCategoryLogRedundancy LogRedundancy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntrusionPreventionCategory {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Prevention: ").Append(Prevention).Append("\n");
            sb.Append("  Detection: ").Append(Detection).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Excluded: ").Append(Excluded).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  LogRedundancy: ").Append(LogRedundancy).Append("\n");
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
            return this.Equals(input as IntrusionPreventionCategory);
        }

        /// <summary>
        /// Returns true if IntrusionPreventionCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of IntrusionPreventionCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntrusionPreventionCategory input)
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
