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
    /// Custom match group configuration.
    /// </summary>
    [DataContract(Name = "custom_match_group")]
    public partial class CustomMatchGroup : IEquatable<CustomMatchGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMatchGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomMatchGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMatchGroup" /> class.
        /// </summary>
        /// <param name="name">Custom match group name. (required).</param>
        /// <param name="customMatch">Add specified custom match..</param>
        /// <param name="varCustomMatchGroup">Add specified custom match group..</param>
        public CustomMatchGroup(string name = default(string), List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> customMatch = default(List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner>), List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> varCustomMatchGroup = default(List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CustomMatchGroup and cannot be null");
            }
            this.Name = name;
            this.CustomMatch = customMatch;
            this.VarCustomMatchGroup = varCustomMatchGroup;
        }

        /// <summary>
        /// Custom match group name.
        /// </summary>
        /// <value>Custom match group name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Custom match group UUID.
        /// </summary>
        /// <value>Custom match group UUID.</value>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns false as Uuid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUuid()
        {
            return false;
        }
        /// <summary>
        /// Add specified custom match.
        /// </summary>
        /// <value>Add specified custom match.</value>
        [DataMember(Name = "custom_match", EmitDefaultValue = false)]
        public List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> CustomMatch { get; set; }

        /// <summary>
        /// Add specified custom match group.
        /// </summary>
        /// <value>Add specified custom match group.</value>
        [DataMember(Name = "custom_match_group", EmitDefaultValue = false)]
        public List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> VarCustomMatchGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomMatchGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  CustomMatch: ").Append(CustomMatch).Append("\n");
            sb.Append("  VarCustomMatchGroup: ").Append(VarCustomMatchGroup).Append("\n");
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
            return this.Equals(input as CustomMatchGroup);
        }

        /// <summary>
        /// Returns true if CustomMatchGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomMatchGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomMatchGroup input)
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
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.CustomMatch == input.CustomMatch ||
                    this.CustomMatch != null &&
                    input.CustomMatch != null &&
                    this.CustomMatch.SequenceEqual(input.CustomMatch)
                ) && 
                (
                    this.VarCustomMatchGroup == input.VarCustomMatchGroup ||
                    this.VarCustomMatchGroup != null &&
                    input.VarCustomMatchGroup != null &&
                    this.VarCustomMatchGroup.SequenceEqual(input.VarCustomMatchGroup)
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
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.CustomMatch != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMatch.GetHashCode();
                }
                if (this.VarCustomMatchGroup != null)
                {
                    hashCode = (hashCode * 59) + this.VarCustomMatchGroup.GetHashCode();
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
