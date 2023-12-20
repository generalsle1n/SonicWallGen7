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
    /// Configure IPS exclusion list.
    /// </summary>
    [DataContract(Name = "intrusion_prevention_exclusion_list_intrusion_prevention_exclusion")]
    public partial class IntrusionPreventionExclusionListIntrusionPreventionExclusion : IEquatable<IntrusionPreventionExclusionListIntrusionPreventionExclusion>, IValidatableObject
    {
        /// <summary>
        /// Set exclusion list method.
        /// </summary>
        /// <value>Set exclusion list method.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddressEnum
        {
            /// <summary>
            /// Enum Object for value: object
            /// </summary>
            [EnumMember(Value = "object")]
            Object = 1,

            /// <summary>
            /// Enum Range for value: range
            /// </summary>
            [EnumMember(Value = "range")]
            Range = 2
        }


        /// <summary>
        /// Set exclusion list method.
        /// </summary>
        /// <value>Set exclusion list method.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressEnum? Address { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionExclusionListIntrusionPreventionExclusion" /> class.
        /// </summary>
        /// <param name="list">Enable IPS exclusion list..</param>
        /// <param name="address">Set exclusion list method..</param>
        /// <param name="name">Address object name.</param>
        /// <param name="group">Address object group.</param>
        public IntrusionPreventionExclusionListIntrusionPreventionExclusion(bool list = default(bool), AddressEnum? address = default(AddressEnum?), string name = default(string), string group = default(string))
        {
            this.List = list;
            this.Address = address;
            this.Name = name;
            this.Group = group;
        }

        /// <summary>
        /// Enable IPS exclusion list.
        /// </summary>
        /// <value>Enable IPS exclusion list.</value>
        [DataMember(Name = "list", EmitDefaultValue = true)]
        public bool List { get; set; }

        /// <summary>
        /// Address object name
        /// </summary>
        /// <value>Address object name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Address object group
        /// </summary>
        /// <value>Address object group</value>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntrusionPreventionExclusionListIntrusionPreventionExclusion {\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(input as IntrusionPreventionExclusionListIntrusionPreventionExclusion);
        }

        /// <summary>
        /// Returns true if IntrusionPreventionExclusionListIntrusionPreventionExclusion instances are equal
        /// </summary>
        /// <param name="input">Instance of IntrusionPreventionExclusionListIntrusionPreventionExclusion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntrusionPreventionExclusionListIntrusionPreventionExclusion input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.List == input.List ||
                    this.List.Equals(input.List)
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address.Equals(input.Address)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
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
                hashCode = (hashCode * 59) + this.List.GetHashCode();
                hashCode = (hashCode * 59) + this.Address.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
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