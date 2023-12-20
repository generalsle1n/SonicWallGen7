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
    /// Set IPv6 DNS server
    /// </summary>
    [DataContract(Name = "dns_dns_server_ipv6")]
    public partial class DnsDnsServerIpv6 : IEquatable<DnsDnsServerIpv6>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DnsDnsServerIpv6" /> class.
        /// </summary>
        /// <param name="preferred">Prefer IPv6 DNS Servers..</param>
        /// <param name="inherit">Inherit DNS servers..</param>
        /// <param name="varStatic">varStatic.</param>
        public DnsDnsServerIpv6(bool preferred = default(bool), bool inherit = default(bool), LogNameResolutionNameResolutionDnsStaticStatic varStatic = default(LogNameResolutionNameResolutionDnsStaticStatic))
        {
            this.Preferred = preferred;
            this.Inherit = inherit;
            this.VarStatic = varStatic;
        }

        /// <summary>
        /// Prefer IPv6 DNS Servers.
        /// </summary>
        /// <value>Prefer IPv6 DNS Servers.</value>
        [DataMember(Name = "preferred", EmitDefaultValue = true)]
        public bool Preferred { get; set; }

        /// <summary>
        /// Inherit DNS servers.
        /// </summary>
        /// <value>Inherit DNS servers.</value>
        [DataMember(Name = "inherit", EmitDefaultValue = true)]
        public bool Inherit { get; set; }

        /// <summary>
        /// Gets or Sets VarStatic
        /// </summary>
        [DataMember(Name = "static", EmitDefaultValue = false)]
        public LogNameResolutionNameResolutionDnsStaticStatic VarStatic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DnsDnsServerIpv6 {\n");
            sb.Append("  Preferred: ").Append(Preferred).Append("\n");
            sb.Append("  Inherit: ").Append(Inherit).Append("\n");
            sb.Append("  VarStatic: ").Append(VarStatic).Append("\n");
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
            return this.Equals(input as DnsDnsServerIpv6);
        }

        /// <summary>
        /// Returns true if DnsDnsServerIpv6 instances are equal
        /// </summary>
        /// <param name="input">Instance of DnsDnsServerIpv6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DnsDnsServerIpv6 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Preferred == input.Preferred ||
                    this.Preferred.Equals(input.Preferred)
                ) && 
                (
                    this.Inherit == input.Inherit ||
                    this.Inherit.Equals(input.Inherit)
                ) && 
                (
                    this.VarStatic == input.VarStatic ||
                    (this.VarStatic != null &&
                    this.VarStatic.Equals(input.VarStatic))
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
                hashCode = (hashCode * 59) + this.Preferred.GetHashCode();
                hashCode = (hashCode * 59) + this.Inherit.GetHashCode();
                if (this.VarStatic != null)
                {
                    hashCode = (hashCode * 59) + this.VarStatic.GetHashCode();
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