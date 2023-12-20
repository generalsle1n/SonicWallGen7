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
    /// user authentication partitions configuration.
    /// </summary>
    [DataContract(Name = "user_partitioning_partitions")]
    public partial class UserPartitioningPartitions : IEquatable<UserPartitioningPartitions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPartitioningPartitions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserPartitioningPartitions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPartitioningPartitions" /> class.
        /// </summary>
        /// <param name="name">Set the user partitioning name. (required).</param>
        /// <param name="parentPartition">Set parent partition..</param>
        /// <param name="comment">Set the user partitioning comment..</param>
        /// <param name="domain">Set the user partitioning domain..</param>
        public UserPartitioningPartitions(string name = default(string), string parentPartition = default(string), string comment = default(string), List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> domain = default(List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UserPartitioningPartitions and cannot be null");
            }
            this.Name = name;
            this.ParentPartition = parentPartition;
            this.Comment = comment;
            this.Domain = domain;
        }

        /// <summary>
        /// Set the user partitioning name.
        /// </summary>
        /// <value>Set the user partitioning name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Set parent partition.
        /// </summary>
        /// <value>Set parent partition.</value>
        [DataMember(Name = "parent_partition", EmitDefaultValue = false)]
        public string ParentPartition { get; set; }

        /// <summary>
        /// Set the user partitioning comment.
        /// </summary>
        /// <value>Set the user partitioning comment.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Set the user partitioning domain.
        /// </summary>
        /// <value>Set the user partitioning domain.</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> Domain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserPartitioningPartitions {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentPartition: ").Append(ParentPartition).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
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
            return this.Equals(input as UserPartitioningPartitions);
        }

        /// <summary>
        /// Returns true if UserPartitioningPartitions instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPartitioningPartitions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPartitioningPartitions input)
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
                    this.ParentPartition == input.ParentPartition ||
                    (this.ParentPartition != null &&
                    this.ParentPartition.Equals(input.ParentPartition))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Domain == input.Domain ||
                    this.Domain != null &&
                    input.Domain != null &&
                    this.Domain.SequenceEqual(input.Domain)
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
                if (this.ParentPartition != null)
                {
                    hashCode = (hashCode * 59) + this.ParentPartition.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
                }
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
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
