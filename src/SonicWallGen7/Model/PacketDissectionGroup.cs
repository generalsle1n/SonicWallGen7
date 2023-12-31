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
    /// Packet dissection group configuration.
    /// </summary>
    [DataContract(Name = "packet_dissection_group")]
    public partial class PacketDissectionGroup : IEquatable<PacketDissectionGroup>, IValidatableObject
    {
        /// <summary>
        /// Set the packet dissection group to match given parameter.
        /// </summary>
        /// <value>Set the packet dissection group to match given parameter.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatchTypeEnum
        {
            /// <summary>
            /// Enum Any for value: any
            /// </summary>
            [EnumMember(Value = "any")]
            Any = 1,

            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 2
        }


        /// <summary>
        /// Set the packet dissection group to match given parameter.
        /// </summary>
        /// <value>Set the packet dissection group to match given parameter.</value>
        [DataMember(Name = "match_type", EmitDefaultValue = false)]
        public MatchTypeEnum? MatchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketDissectionGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PacketDissectionGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketDissectionGroup" /> class.
        /// </summary>
        /// <param name="name">Packet dissection group name. (required).</param>
        /// <param name="negativeMatching">Enable negative matching..</param>
        /// <param name="matchType">Set the packet dissection group to match given parameter..</param>
        /// <param name="packetDissectionObject">Assign packet dissection object to group..</param>
        /// <param name="varPacketDissectionGroup">Remove packet dissection group from group..</param>
        public PacketDissectionGroup(string name = default(string), bool negativeMatching = default(bool), MatchTypeEnum? matchType = default(MatchTypeEnum?), List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> packetDissectionObject = default(List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner>), List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> varPacketDissectionGroup = default(List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PacketDissectionGroup and cannot be null");
            }
            this.Name = name;
            this.NegativeMatching = negativeMatching;
            this.MatchType = matchType;
            this.PacketDissectionObject = packetDissectionObject;
            this.VarPacketDissectionGroup = varPacketDissectionGroup;
        }

        /// <summary>
        /// Packet dissection group name.
        /// </summary>
        /// <value>Packet dissection group name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Enable negative matching.
        /// </summary>
        /// <value>Enable negative matching.</value>
        [DataMember(Name = "negative_matching", EmitDefaultValue = true)]
        public bool NegativeMatching { get; set; }

        /// <summary>
        /// Assign packet dissection object to group.
        /// </summary>
        /// <value>Assign packet dissection object to group.</value>
        [DataMember(Name = "packet_dissection_object", EmitDefaultValue = false)]
        public List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> PacketDissectionObject { get; set; }

        /// <summary>
        /// Remove packet dissection group from group.
        /// </summary>
        /// <value>Remove packet dissection group from group.</value>
        [DataMember(Name = "packet_dissection_group", EmitDefaultValue = false)]
        public List<AddressGroupIpv4Ipv4AddressGroupIpv4Inner> VarPacketDissectionGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketDissectionGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NegativeMatching: ").Append(NegativeMatching).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  PacketDissectionObject: ").Append(PacketDissectionObject).Append("\n");
            sb.Append("  VarPacketDissectionGroup: ").Append(VarPacketDissectionGroup).Append("\n");
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
            return this.Equals(input as PacketDissectionGroup);
        }

        /// <summary>
        /// Returns true if PacketDissectionGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketDissectionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketDissectionGroup input)
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
                    this.NegativeMatching == input.NegativeMatching ||
                    this.NegativeMatching.Equals(input.NegativeMatching)
                ) && 
                (
                    this.MatchType == input.MatchType ||
                    this.MatchType.Equals(input.MatchType)
                ) && 
                (
                    this.PacketDissectionObject == input.PacketDissectionObject ||
                    this.PacketDissectionObject != null &&
                    input.PacketDissectionObject != null &&
                    this.PacketDissectionObject.SequenceEqual(input.PacketDissectionObject)
                ) && 
                (
                    this.VarPacketDissectionGroup == input.VarPacketDissectionGroup ||
                    this.VarPacketDissectionGroup != null &&
                    input.VarPacketDissectionGroup != null &&
                    this.VarPacketDissectionGroup.SequenceEqual(input.VarPacketDissectionGroup)
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
                hashCode = (hashCode * 59) + this.NegativeMatching.GetHashCode();
                hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
                if (this.PacketDissectionObject != null)
                {
                    hashCode = (hashCode * 59) + this.PacketDissectionObject.GetHashCode();
                }
                if (this.VarPacketDissectionGroup != null)
                {
                    hashCode = (hashCode * 59) + this.VarPacketDissectionGroup.GetHashCode();
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
