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
    /// NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp
    /// </summary>
    [DataContract(Name = "network_monitor_ipv6_policy_ipv6_probe_type_tcp")]
    public partial class NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp : IEquatable<NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp" /> class.
        /// </summary>
        /// <param name="tcp">tcp.</param>
        public NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp(NetworkMonitorIpv6PolicyIpv6ProbeTypeTcpTcp tcp = default(NetworkMonitorIpv6PolicyIpv6ProbeTypeTcpTcp))
        {
            this.Tcp = tcp;
        }

        /// <summary>
        /// Gets or Sets Tcp
        /// </summary>
        [DataMember(Name = "tcp", EmitDefaultValue = false)]
        public NetworkMonitorIpv6PolicyIpv6ProbeTypeTcpTcp Tcp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp {\n");
            sb.Append("  Tcp: ").Append(Tcp).Append("\n");
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
            return this.Equals(input as NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp);
        }

        /// <summary>
        /// Returns true if NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkMonitorIpv6PolicyIpv6ProbeTypeTcp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Tcp == input.Tcp ||
                    (this.Tcp != null &&
                    this.Tcp.Equals(input.Tcp))
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
                if (this.Tcp != null)
                {
                    hashCode = (hashCode * 59) + this.Tcp.GetHashCode();
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
