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
    /// user sso configuration.
    /// </summary>
    [DataContract(Name = "user_sso_terminal_services_agent")]
    public partial class UserSsoTerminalServicesAgent : IEquatable<UserSsoTerminalServicesAgent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoTerminalServicesAgent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSsoTerminalServicesAgent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoTerminalServicesAgent" /> class.
        /// </summary>
        /// <param name="host">Set the agent&#39;s host name or IP address. (required).</param>
        /// <param name="enable">Enable the terminal services agent..</param>
        /// <param name="port">Set the agent&#39;s UDP port number..</param>
        /// <param name="sharedKey">Set the hexadecimal shared encryption key..</param>
        /// <param name="partition">Set the Terminal Services agent&#39;s user partition..</param>
        public UserSsoTerminalServicesAgent(string host = default(string), bool enable = default(bool), decimal port = default(decimal), string sharedKey = default(string), string partition = default(string))
        {
            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new ArgumentNullException("host is a required property for UserSsoTerminalServicesAgent and cannot be null");
            }
            this.Host = host;
            this.Enable = enable;
            this.Port = port;
            this.SharedKey = sharedKey;
            this.Partition = partition;
        }

        /// <summary>
        /// Set the agent&#39;s host name or IP address.
        /// </summary>
        /// <value>Set the agent&#39;s host name or IP address.</value>
        [DataMember(Name = "host", IsRequired = true, EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// Enable the terminal services agent.
        /// </summary>
        /// <value>Enable the terminal services agent.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Set the agent&#39;s UDP port number.
        /// </summary>
        /// <value>Set the agent&#39;s UDP port number.</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public decimal Port { get; set; }

        /// <summary>
        /// Set the hexadecimal shared encryption key.
        /// </summary>
        /// <value>Set the hexadecimal shared encryption key.</value>
        [DataMember(Name = "shared_key", EmitDefaultValue = false)]
        public string SharedKey { get; set; }

        /// <summary>
        /// Set the Terminal Services agent&#39;s user partition.
        /// </summary>
        /// <value>Set the Terminal Services agent&#39;s user partition.</value>
        [DataMember(Name = "partition", EmitDefaultValue = false)]
        public string Partition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSsoTerminalServicesAgent {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SharedKey: ").Append(SharedKey).Append("\n");
            sb.Append("  Partition: ").Append(Partition).Append("\n");
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
            return this.Equals(input as UserSsoTerminalServicesAgent);
        }

        /// <summary>
        /// Returns true if UserSsoTerminalServicesAgent instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSsoTerminalServicesAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSsoTerminalServicesAgent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.Port == input.Port ||
                    this.Port.Equals(input.Port)
                ) && 
                (
                    this.SharedKey == input.SharedKey ||
                    (this.SharedKey != null &&
                    this.SharedKey.Equals(input.SharedKey))
                ) && 
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))
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
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.Port.GetHashCode();
                if (this.SharedKey != null)
                {
                    hashCode = (hashCode * 59) + this.SharedKey.GetHashCode();
                }
                if (this.Partition != null)
                {
                    hashCode = (hashCode * 59) + this.Partition.GetHashCode();
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
            // SharedKey (string) maxLength
            if (this.SharedKey != null && this.SharedKey.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharedKey, length must be less than 16.", new [] { "SharedKey" });
            }

            // SharedKey (string) minLength
            if (this.SharedKey != null && this.SharedKey.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SharedKey, length must be greater than 0.", new [] { "SharedKey" });
            }

            yield break;
        }
    }

}
