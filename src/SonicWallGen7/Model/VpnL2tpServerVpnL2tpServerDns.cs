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
    /// Set the primary and secondary DNS server IP address.
    /// </summary>
    [DataContract(Name = "vpn_l2tp_server_vpn_l2tp_server_dns")]
    public partial class VpnL2tpServerVpnL2tpServerDns : IEquatable<VpnL2tpServerVpnL2tpServerDns>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnL2tpServerVpnL2tpServerDns" /> class.
        /// </summary>
        /// <param name="primary">Primary DNS server IP address..</param>
        /// <param name="secondary">Secondary DNS server IP address..</param>
        public VpnL2tpServerVpnL2tpServerDns(string primary = default(string), string secondary = default(string))
        {
            this.Primary = primary;
            this.Secondary = secondary;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnL2tpServerVpnL2tpServerDns {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
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
            return this.Equals(input as VpnL2tpServerVpnL2tpServerDns);
        }

        /// <summary>
        /// Returns true if VpnL2tpServerVpnL2tpServerDns instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnL2tpServerVpnL2tpServerDns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnL2tpServerVpnL2tpServerDns input)
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
