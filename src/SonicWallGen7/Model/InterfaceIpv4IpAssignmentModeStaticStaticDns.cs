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
    /// Set the DNS server IP address.
    /// </summary>
    [DataContract(Name = "interface_ipv4_ip_assignment_mode_static_static_dns")]
    public partial class InterfaceIpv4IpAssignmentModeStaticStaticDns : IEquatable<InterfaceIpv4IpAssignmentModeStaticStaticDns>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv4IpAssignmentModeStaticStaticDns" /> class.
        /// </summary>
        /// <param name="primary">Primary DNS server IP address..</param>
        /// <param name="secondary">Secondary DNS server IP address..</param>
        /// <param name="tertiary">Tertiary DNS server IP address..</param>
        public InterfaceIpv4IpAssignmentModeStaticStaticDns(string primary = default(string), string secondary = default(string), string tertiary = default(string))
        {
            this.Primary = primary;
            this.Secondary = secondary;
            this.Tertiary = tertiary;
        }

        /// <summary>
        /// Primary DNS server IP address.
        /// </summary>
        /// <value>Primary DNS server IP address.</value>
        [DataMember(Name = "primary", EmitDefaultValue = false)]
        public string Primary { get; set; }

        /// <summary>
        /// Secondary DNS server IP address.
        /// </summary>
        /// <value>Secondary DNS server IP address.</value>
        [DataMember(Name = "secondary", EmitDefaultValue = false)]
        public string Secondary { get; set; }

        /// <summary>
        /// Tertiary DNS server IP address.
        /// </summary>
        /// <value>Tertiary DNS server IP address.</value>
        [DataMember(Name = "tertiary", EmitDefaultValue = false)]
        public string Tertiary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv4IpAssignmentModeStaticStaticDns {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
            sb.Append("  Tertiary: ").Append(Tertiary).Append("\n");
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
            return this.Equals(input as InterfaceIpv4IpAssignmentModeStaticStaticDns);
        }

        /// <summary>
        /// Returns true if InterfaceIpv4IpAssignmentModeStaticStaticDns instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv4IpAssignmentModeStaticStaticDns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv4IpAssignmentModeStaticStaticDns input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && 
                (
                    this.Secondary == input.Secondary ||
                    (this.Secondary != null &&
                    this.Secondary.Equals(input.Secondary))
                ) && 
                (
                    this.Tertiary == input.Tertiary ||
                    (this.Tertiary != null &&
                    this.Tertiary.Equals(input.Tertiary))
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
                if (this.Primary != null)
                {
                    hashCode = (hashCode * 59) + this.Primary.GetHashCode();
                }
                if (this.Secondary != null)
                {
                    hashCode = (hashCode * 59) + this.Secondary.GetHashCode();
                }
                if (this.Tertiary != null)
                {
                    hashCode = (hashCode * 59) + this.Tertiary.GetHashCode();
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