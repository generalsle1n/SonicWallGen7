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
    /// Service object protocol.
    /// </summary>
    [DataContract(Name = "tcp_proxy_connections_service_protocol_protocol")]
    public partial class TcpProxyConnectionsServiceProtocolProtocol : IEquatable<TcpProxyConnectionsServiceProtocolProtocol>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TcpProxyConnectionsServiceProtocolProtocol" /> class.
        /// </summary>
        /// <param name="protocol">protocol.</param>
        /// <param name="begin">begin.</param>
        /// <param name="end">end.</param>
        public TcpProxyConnectionsServiceProtocolProtocol(string protocol = default(string), decimal begin = default(decimal), decimal end = default(decimal))
        {
            this.Protocol = protocol;
            this.Begin = begin;
            this.End = end;
        }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or Sets Begin
        /// </summary>
        [DataMember(Name = "begin", EmitDefaultValue = false)]
        public decimal Begin { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public decimal End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TcpProxyConnectionsServiceProtocolProtocol {\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Begin: ").Append(Begin).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(input as TcpProxyConnectionsServiceProtocolProtocol);
        }

        /// <summary>
        /// Returns true if TcpProxyConnectionsServiceProtocolProtocol instances are equal
        /// </summary>
        /// <param name="input">Instance of TcpProxyConnectionsServiceProtocolProtocol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TcpProxyConnectionsServiceProtocolProtocol input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Begin == input.Begin ||
                    this.Begin.Equals(input.Begin)
                ) && 
                (
                    this.End == input.End ||
                    this.End.Equals(input.End)
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
                if (this.Protocol != null)
                {
                    hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Begin.GetHashCode();
                hashCode = (hashCode * 59) + this.End.GetHashCode();
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
