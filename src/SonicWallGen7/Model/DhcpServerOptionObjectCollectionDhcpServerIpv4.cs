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
    /// Enter IPv4 DHCP server configuration mode.
    /// </summary>
    [DataContract(Name = "dhcp_server_option_object_collection_dhcp_server_ipv4")]
    public partial class DhcpServerOptionObjectCollectionDhcpServerIpv4 : IEquatable<DhcpServerOptionObjectCollectionDhcpServerIpv4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DhcpServerOptionObjectCollectionDhcpServerIpv4" /> class.
        /// </summary>
        /// <param name="option">option.</param>
        public DhcpServerOptionObjectCollectionDhcpServerIpv4(DhcpServerOptionObjectCollectionDhcpServerIpv4Option option = default(DhcpServerOptionObjectCollectionDhcpServerIpv4Option))
        {
            this.Option = option;
        }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name = "option", EmitDefaultValue = false)]
        public DhcpServerOptionObjectCollectionDhcpServerIpv4Option Option { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DhcpServerOptionObjectCollectionDhcpServerIpv4 {\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
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
            return this.Equals(input as DhcpServerOptionObjectCollectionDhcpServerIpv4);
        }

        /// <summary>
        /// Returns true if DhcpServerOptionObjectCollectionDhcpServerIpv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of DhcpServerOptionObjectCollectionDhcpServerIpv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DhcpServerOptionObjectCollectionDhcpServerIpv4 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.Option != null)
                {
                    hashCode = (hashCode * 59) + this.Option.GetHashCode();
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
