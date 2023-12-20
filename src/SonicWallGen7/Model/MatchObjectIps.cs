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
    /// Intrusion prevention.
    /// </summary>
    [DataContract(Name = "match_object_ips")]
    public partial class MatchObjectIps : IEquatable<MatchObjectIps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchObjectIps" /> class.
        /// </summary>
        /// <param name="category">Add an IPS category..</param>
        /// <param name="policy">Add an IPS policy..</param>
        public MatchObjectIps(List<MatchObjectIpsCategoryInner> category = default(List<MatchObjectIpsCategoryInner>), List<MatchObjectIpsPolicyInner> policy = default(List<MatchObjectIpsPolicyInner>))
        {
            this.Category = category;
            this.Policy = policy;
        }

        /// <summary>
        /// Add an IPS category.
        /// </summary>
        /// <value>Add an IPS category.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public List<MatchObjectIpsCategoryInner> Category { get; set; }

        /// <summary>
        /// Add an IPS policy.
        /// </summary>
        /// <value>Add an IPS policy.</value>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public List<MatchObjectIpsPolicyInner> Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchObjectIps {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(input as MatchObjectIps);
        }

        /// <summary>
        /// Returns true if MatchObjectIps instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchObjectIps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchObjectIps input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    this.Category != null &&
                    input.Category != null &&
                    this.Category.SequenceEqual(input.Category)
                ) && 
                (
                    this.Policy == input.Policy ||
                    this.Policy != null &&
                    input.Policy != null &&
                    this.Policy.SequenceEqual(input.Policy)
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
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
