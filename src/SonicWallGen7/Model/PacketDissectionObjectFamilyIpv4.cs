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
    /// PacketDissectionObjectFamilyIpv4
    /// </summary>
    [DataContract(Name = "packet_dissection_object_family_ipv4")]
    public partial class PacketDissectionObjectFamilyIpv4 : IEquatable<PacketDissectionObjectFamilyIpv4>, IValidatableObject
    {
        /// <summary>
        /// IPv4 header.
        /// </summary>
        /// <value>IPv4 header.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Ipv4Enum
        {
            /// <summary>
            /// Enum Version for value: version
            /// </summary>
            [EnumMember(Value = "version")]
            Version = 1,

            /// <summary>
            /// Enum HeaderLength for value: header-length
            /// </summary>
            [EnumMember(Value = "header-length")]
            HeaderLength = 2,

            /// <summary>
            /// Enum PacketLength for value: packet-length
            /// </summary>
            [EnumMember(Value = "packet-length")]
            PacketLength = 3,

            /// <summary>
            /// Enum Identity for value: identity
            /// </summary>
            [EnumMember(Value = "identity")]
            Identity = 4,

            /// <summary>
            /// Enum Flag for value: flag
            /// </summary>
            [EnumMember(Value = "flag")]
            Flag = 5,

            /// <summary>
            /// Enum FragmentOffset for value: fragment-offset
            /// </summary>
            [EnumMember(Value = "fragment-offset")]
            FragmentOffset = 6,

            /// <summary>
            /// Enum Ttl for value: ttl
            /// </summary>
            [EnumMember(Value = "ttl")]
            Ttl = 7,

            /// <summary>
            /// Enum Protocol for value: protocol
            /// </summary>
            [EnumMember(Value = "protocol")]
            Protocol = 8,

            /// <summary>
            /// Enum HeaderChecksum for value: header-checksum
            /// </summary>
            [EnumMember(Value = "header-checksum")]
            HeaderChecksum = 9,

            /// <summary>
            /// Enum OptionType for value: option-type
            /// </summary>
            [EnumMember(Value = "option-type")]
            OptionType = 10
        }


        /// <summary>
        /// IPv4 header.
        /// </summary>
        /// <value>IPv4 header.</value>
        [DataMember(Name = "ipv4", EmitDefaultValue = false)]
        public Ipv4Enum? Ipv4 { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketDissectionObjectFamilyIpv4" /> class.
        /// </summary>
        /// <param name="ipv4">IPv4 header..</param>
        public PacketDissectionObjectFamilyIpv4(Ipv4Enum? ipv4 = default(Ipv4Enum?))
        {
            this.Ipv4 = ipv4;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketDissectionObjectFamilyIpv4 {\n");
            sb.Append("  Ipv4: ").Append(Ipv4).Append("\n");
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
            return this.Equals(input as PacketDissectionObjectFamilyIpv4);
        }

        /// <summary>
        /// Returns true if PacketDissectionObjectFamilyIpv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketDissectionObjectFamilyIpv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketDissectionObjectFamilyIpv4 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ipv4 == input.Ipv4 ||
                    this.Ipv4.Equals(input.Ipv4)
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
                hashCode = (hashCode * 59) + this.Ipv4.GetHashCode();
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