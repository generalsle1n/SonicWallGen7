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
    /// IPV4 bitset.
    /// </summary>
    [DataContract(Name = "packet_dissection_object_data_type_ipv4_bitset_ipv4_bitset")]
    public partial class PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset : IEquatable<PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset" /> class.
        /// </summary>
        /// <param name="reserved">Enable reserved in bitset..</param>
        /// <param name="dontFragment">Enable dont-fragment in bitset..</param>
        /// <param name="moreFragments">Enable more-fragments in bitset..</param>
        public PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset(bool reserved = default(bool), bool dontFragment = default(bool), bool moreFragments = default(bool))
        {
            this.Reserved = reserved;
            this.DontFragment = dontFragment;
            this.MoreFragments = moreFragments;
        }

        /// <summary>
        /// Enable reserved in bitset.
        /// </summary>
        /// <value>Enable reserved in bitset.</value>
        [DataMember(Name = "reserved", EmitDefaultValue = true)]
        public bool Reserved { get; set; }

        /// <summary>
        /// Enable dont-fragment in bitset.
        /// </summary>
        /// <value>Enable dont-fragment in bitset.</value>
        [DataMember(Name = "dont_fragment", EmitDefaultValue = true)]
        public bool DontFragment { get; set; }

        /// <summary>
        /// Enable more-fragments in bitset.
        /// </summary>
        /// <value>Enable more-fragments in bitset.</value>
        [DataMember(Name = "more_fragments", EmitDefaultValue = true)]
        public bool MoreFragments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset {\n");
            sb.Append("  Reserved: ").Append(Reserved).Append("\n");
            sb.Append("  DontFragment: ").Append(DontFragment).Append("\n");
            sb.Append("  MoreFragments: ").Append(MoreFragments).Append("\n");
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
            return this.Equals(input as PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset);
        }

        /// <summary>
        /// Returns true if PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketDissectionObjectDataTypeIpv4BitsetIpv4Bitset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reserved == input.Reserved ||
                    this.Reserved.Equals(input.Reserved)
                ) && 
                (
                    this.DontFragment == input.DontFragment ||
                    this.DontFragment.Equals(input.DontFragment)
                ) && 
                (
                    this.MoreFragments == input.MoreFragments ||
                    this.MoreFragments.Equals(input.MoreFragments)
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
                hashCode = (hashCode * 59) + this.Reserved.GetHashCode();
                hashCode = (hashCode * 59) + this.DontFragment.GetHashCode();
                hashCode = (hashCode * 59) + this.MoreFragments.GetHashCode();
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
