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
    /// Set automatic proxy forwarding (web only).
    /// </summary>
    [DataContract(Name = "web_proxy_web_proxy")]
    public partial class SonicWebProxySonicWebProxy : IEquatable<SonicWebProxySonicWebProxy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SonicWebProxySonicWebProxy" /> class.
        /// </summary>
        /// <param name="server">Set web proxy hostname/IP and port..</param>
        /// <param name="port">port.</param>
        /// <param name="bypassUponFailure">Enable bypass proxy servers upon proxy server failure..</param>
        /// <param name="forwardPublicRequests">Enable forward public zone client requests to proxy server..</param>
        public SonicWebProxySonicWebProxy(string server = default(string), SonicWebProxySonicWebProxyPort port = default(SonicWebProxySonicWebProxyPort), bool bypassUponFailure = default(bool), bool forwardPublicRequests = default(bool))
        {
            this.Server = server;
            this.Port = port;
            this.BypassUponFailure = bypassUponFailure;
            this.ForwardPublicRequests = forwardPublicRequests;
        }

        /// <summary>
        /// Set web proxy hostname/IP and port.
        /// </summary>
        /// <value>Set web proxy hostname/IP and port.</value>
        [DataMember(Name = "server", EmitDefaultValue = false)]
        public string Server { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = true)]
        public SonicWebProxySonicWebProxyPort Port { get; set; }

        /// <summary>
        /// Enable bypass proxy servers upon proxy server failure.
        /// </summary>
        /// <value>Enable bypass proxy servers upon proxy server failure.</value>
        [DataMember(Name = "bypass_upon_failure", EmitDefaultValue = true)]
        public bool BypassUponFailure { get; set; }

        /// <summary>
        /// Enable forward public zone client requests to proxy server.
        /// </summary>
        /// <value>Enable forward public zone client requests to proxy server.</value>
        [DataMember(Name = "forward_public_requests", EmitDefaultValue = true)]
        public bool ForwardPublicRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SonicWebProxySonicWebProxy {\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  BypassUponFailure: ").Append(BypassUponFailure).Append("\n");
            sb.Append("  ForwardPublicRequests: ").Append(ForwardPublicRequests).Append("\n");
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
            return this.Equals(input as SonicWebProxySonicWebProxy);
        }

        /// <summary>
        /// Returns true if SonicWebProxySonicWebProxy instances are equal
        /// </summary>
        /// <param name="input">Instance of SonicWebProxySonicWebProxy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SonicWebProxySonicWebProxy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.BypassUponFailure == input.BypassUponFailure ||
                    this.BypassUponFailure.Equals(input.BypassUponFailure)
                ) && 
                (
                    this.ForwardPublicRequests == input.ForwardPublicRequests ||
                    this.ForwardPublicRequests.Equals(input.ForwardPublicRequests)
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
                if (this.Server != null)
                {
                    hashCode = (hashCode * 59) + this.Server.GetHashCode();
                }
                if (this.Port != null)
                {
                    hashCode = (hashCode * 59) + this.Port.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BypassUponFailure.GetHashCode();
                hashCode = (hashCode * 59) + this.ForwardPublicRequests.GetHashCode();
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
            // Server (string) maxLength
            if (this.Server != null && this.Server.Length > 39)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Server, length must be less than 39.", new [] { "Server" });
            }

            // Server (string) minLength
            if (this.Server != null && this.Server.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Server, length must be greater than 0.", new [] { "Server" });
            }

            yield break;
        }
    }

}
