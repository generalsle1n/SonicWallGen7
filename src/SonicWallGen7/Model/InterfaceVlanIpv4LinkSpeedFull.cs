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
    /// InterfaceVlanIpv4LinkSpeedFull
    /// </summary>
    [DataContract(Name = "interface_vlan_ipv4_link_speed_full")]
    public partial class InterfaceVlanIpv4LinkSpeedFull : IEquatable<InterfaceVlanIpv4LinkSpeedFull>, IValidatableObject
    {
        /// <summary>
        /// Full duplex.
        /// </summary>
        /// <value>Full duplex.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FullEnum
        {
            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 1,

            /// <summary>
            /// Enum _100 for value: 100
            /// </summary>
            [EnumMember(Value = "100")]
            _100 = 2,

            /// <summary>
            /// Enum _1000 for value: 1000
            /// </summary>
            [EnumMember(Value = "1000")]
            _1000 = 3,

            /// <summary>
            /// Enum _2500 for value: 2500
            /// </summary>
            [EnumMember(Value = "2500")]
            _2500 = 4,

            /// <summary>
            /// Enum _5000 for value: 5000
            /// </summary>
            [EnumMember(Value = "5000")]
            _5000 = 5,

            /// <summary>
            /// Enum _10000 for value: 10000
            /// </summary>
            [EnumMember(Value = "10000")]
            _10000 = 6,

            /// <summary>
            /// Enum _40000 for value: 40000
            /// </summary>
            [EnumMember(Value = "40000")]
            _40000 = 7,

            /// <summary>
            /// Enum _100000 for value: 100000
            /// </summary>
            [EnumMember(Value = "100000")]
            _100000 = 8
        }


        /// <summary>
        /// Full duplex.
        /// </summary>
        /// <value>Full duplex.</value>
        [DataMember(Name = "full", EmitDefaultValue = false)]
        public FullEnum? Full { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceVlanIpv4LinkSpeedFull" /> class.
        /// </summary>
        /// <param name="full">Full duplex..</param>
        public InterfaceVlanIpv4LinkSpeedFull(FullEnum? full = default(FullEnum?))
        {
            this.Full = full;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceVlanIpv4LinkSpeedFull {\n");
            sb.Append("  Full: ").Append(Full).Append("\n");
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
            return this.Equals(input as InterfaceVlanIpv4LinkSpeedFull);
        }

        /// <summary>
        /// Returns true if InterfaceVlanIpv4LinkSpeedFull instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceVlanIpv4LinkSpeedFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceVlanIpv4LinkSpeedFull input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Full == input.Full ||
                    this.Full.Equals(input.Full)
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
                hashCode = (hashCode * 59) + this.Full.GetHashCode();
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