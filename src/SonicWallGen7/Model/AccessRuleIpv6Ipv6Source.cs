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
    /// Source.
    /// </summary>
    [DataContract(Name = "access_rule_ipv6_ipv6_source")]
    public partial class AccessRuleIpv6Ipv6Source : IEquatable<AccessRuleIpv6Ipv6Source>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6Source" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessRuleIpv6Ipv6Source() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6Source" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="port">port (required).</param>
        public AccessRuleIpv6Ipv6Source(AccessRuleIpv6Ipv6SourceAddress address = default(AccessRuleIpv6Ipv6SourceAddress), AccessRuleIpv6Ipv6SourcePort port = default(AccessRuleIpv6Ipv6SourcePort))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for AccessRuleIpv6Ipv6Source and cannot be null");
            }
            this.Address = address;
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new ArgumentNullException("port is a required property for AccessRuleIpv6Ipv6Source and cannot be null");
            }
            this.Port = port;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public AccessRuleIpv6Ipv6SourceAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", IsRequired = true, EmitDefaultValue = true)]
        public AccessRuleIpv6Ipv6SourcePort Port { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessRuleIpv6Ipv6Source {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
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
            return this.Equals(input as AccessRuleIpv6Ipv6Source);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv6Ipv6Source instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv6Ipv6Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv6Ipv6Source input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Port != null)
                {
                    hashCode = (hashCode * 59) + this.Port.GetHashCode();
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