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
    /// Threat API schema.
    /// </summary>
    [DataContract(Name = "threat")]
    public partial class Threat : IEquatable<Threat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Threat" /> class.
        /// </summary>
        /// <param name="userName">Set threat user name..</param>
        /// <param name="sourceIp">Set threat user name..</param>
        /// <param name="userRole">Set threat user role..</param>
        /// <param name="deviceType">Set threat device type..</param>
        /// <param name="domainName">Set threat domain name..</param>
        /// <param name="hostname">Set threat hostname..</param>
        /// <param name="posture">Set threat posture..</param>
        public Threat(string userName = default(string), string sourceIp = default(string), string userRole = default(string), string deviceType = default(string), string domainName = default(string), string hostname = default(string), string posture = default(string))
        {
            this.UserName = userName;
            this.SourceIp = sourceIp;
            this.UserRole = userRole;
            this.DeviceType = deviceType;
            this.DomainName = domainName;
            this.Hostname = hostname;
            this.Posture = posture;
        }

        /// <summary>
        /// Set threat user name.
        /// </summary>
        /// <value>Set threat user name.</value>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Set threat user name.
        /// </summary>
        /// <value>Set threat user name.</value>
        [DataMember(Name = "source_ip", EmitDefaultValue = false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// Set threat user role.
        /// </summary>
        /// <value>Set threat user role.</value>
        [DataMember(Name = "user_role", EmitDefaultValue = false)]
        public string UserRole { get; set; }

        /// <summary>
        /// Set threat device type.
        /// </summary>
        /// <value>Set threat device type.</value>
        [DataMember(Name = "device_type", EmitDefaultValue = false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Set threat domain name.
        /// </summary>
        /// <value>Set threat domain name.</value>
        [DataMember(Name = "domain_name", EmitDefaultValue = false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Set threat hostname.
        /// </summary>
        /// <value>Set threat hostname.</value>
        [DataMember(Name = "hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Set threat posture.
        /// </summary>
        /// <value>Set threat posture.</value>
        [DataMember(Name = "posture", EmitDefaultValue = false)]
        public string Posture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Threat {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  SourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  UserRole: ").Append(UserRole).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Posture: ").Append(Posture).Append("\n");
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
            return this.Equals(input as Threat);
        }

        /// <summary>
        /// Returns true if Threat instances are equal
        /// </summary>
        /// <param name="input">Instance of Threat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Threat input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.SourceIp == input.SourceIp ||
                    (this.SourceIp != null &&
                    this.SourceIp.Equals(input.SourceIp))
                ) && 
                (
                    this.UserRole == input.UserRole ||
                    (this.UserRole != null &&
                    this.UserRole.Equals(input.UserRole))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.Posture == input.Posture ||
                    (this.Posture != null &&
                    this.Posture.Equals(input.Posture))
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
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.SourceIp != null)
                {
                    hashCode = (hashCode * 59) + this.SourceIp.GetHashCode();
                }
                if (this.UserRole != null)
                {
                    hashCode = (hashCode * 59) + this.UserRole.GetHashCode();
                }
                if (this.DeviceType != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceType.GetHashCode();
                }
                if (this.DomainName != null)
                {
                    hashCode = (hashCode * 59) + this.DomainName.GetHashCode();
                }
                if (this.Hostname != null)
                {
                    hashCode = (hashCode * 59) + this.Hostname.GetHashCode();
                }
                if (this.Posture != null)
                {
                    hashCode = (hashCode * 59) + this.Posture.GetHashCode();
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
