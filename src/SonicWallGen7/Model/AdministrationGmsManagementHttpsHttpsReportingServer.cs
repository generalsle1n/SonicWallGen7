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
    /// Enable send syslog messages to a distributed GMS reporting server and configure. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "administration_gms_management_https_https_reporting_server")]
    public partial class AdministrationGmsManagementHttpsHttpsReportingServer : IEquatable<AdministrationGmsManagementHttpsHttpsReportingServer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationGmsManagementHttpsHttpsReportingServer" /> class.
        /// </summary>
        /// <param name="ip">Set distributed GMS reporting server IP address..</param>
        /// <param name="port">Set distributed GMS reporting server port..</param>
        public AdministrationGmsManagementHttpsHttpsReportingServer(string ip = default(string), decimal port = default(decimal))
        {
            this.Ip = ip;
            this.Port = port;
        }

        /// <summary>
        /// Set distributed GMS reporting server IP address.
        /// </summary>
        /// <value>Set distributed GMS reporting server IP address.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Set distributed GMS reporting server port.
        /// </summary>
        /// <value>Set distributed GMS reporting server port.</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public decimal Port { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdministrationGmsManagementHttpsHttpsReportingServer {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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
            return this.Equals(input as AdministrationGmsManagementHttpsHttpsReportingServer);
        }

        /// <summary>
        /// Returns true if AdministrationGmsManagementHttpsHttpsReportingServer instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministrationGmsManagementHttpsHttpsReportingServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministrationGmsManagementHttpsHttpsReportingServer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
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
