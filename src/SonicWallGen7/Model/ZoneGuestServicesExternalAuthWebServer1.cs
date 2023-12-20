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
    /// Configure the external web server 1 settings. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "zone_guest_services_external_auth_web_server_1")]
    public partial class ZoneGuestServicesExternalAuthWebServer1 : IEquatable<ZoneGuestServicesExternalAuthWebServer1>, IValidatableObject
    {
        /// <summary>
        /// Configure the external web server protocol.
        /// </summary>
        /// <value>Configure the external web server protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            /// <summary>
            /// Enum Http for value: http
            /// </summary>
            [EnumMember(Value = "http")]
            Http = 1,

            /// <summary>
            /// Enum Https for value: https
            /// </summary>
            [EnumMember(Value = "https")]
            Https = 2
        }


        /// <summary>
        /// Configure the external web server protocol.
        /// </summary>
        /// <value>Configure the external web server protocol.</value>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public ProtocolEnum? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneGuestServicesExternalAuthWebServer1" /> class.
        /// </summary>
        /// <param name="protocol">Configure the external web server protocol..</param>
        /// <param name="name">Configure webserver to named address object..</param>
        /// <param name="port">Configure the external web server port..</param>
        public ZoneGuestServicesExternalAuthWebServer1(ProtocolEnum? protocol = default(ProtocolEnum?), string name = default(string), decimal port = default(decimal))
        {
            this.Protocol = protocol;
            this.Name = name;
            this.Port = port;
        }

        /// <summary>
        /// Configure webserver to named address object.
        /// </summary>
        /// <value>Configure webserver to named address object.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Configure the external web server port.
        /// </summary>
        /// <value>Configure the external web server port.</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public decimal Port { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZoneGuestServicesExternalAuthWebServer1 {\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ZoneGuestServicesExternalAuthWebServer1);
        }

        /// <summary>
        /// Returns true if ZoneGuestServicesExternalAuthWebServer1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ZoneGuestServicesExternalAuthWebServer1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZoneGuestServicesExternalAuthWebServer1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol.Equals(input.Protocol)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Port == input.Port ||
                    this.Port.Equals(input.Port)
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
                hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Port.GetHashCode();
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
