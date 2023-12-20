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
    /// arp cache detail schema.
    /// </summary>
    [DataContract(Name = "show_status_arp_cache_detail")]
    public partial class ShowStatusArpCacheDetail : IEquatable<ShowStatusArpCacheDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusArpCacheDetail" /> class.
        /// </summary>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="type">type.</param>
        /// <param name="macAddress">macAddress.</param>
        /// <param name="vendor">vendor.</param>
        /// <param name="varInterface">varInterface.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="expiresInMinutes">expiresInMinutes.</param>
        public ShowStatusArpCacheDetail(string ipAddress = default(string), string type = default(string), string macAddress = default(string), string vendor = default(string), string varInterface = default(string), string timeout = default(string), string expiresInMinutes = default(string))
        {
            this.IpAddress = ipAddress;
            this.Type = type;
            this.MacAddress = macAddress;
            this.Vendor = vendor;
            this.VarInterface = varInterface;
            this.Timeout = timeout;
            this.ExpiresInMinutes = expiresInMinutes;
        }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ip_address", EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MacAddress
        /// </summary>
        [DataMember(Name = "mac_address", EmitDefaultValue = false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or Sets VarInterface
        /// </summary>
        [DataMember(Name = "interface", EmitDefaultValue = false)]
        public string VarInterface { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public string Timeout { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresInMinutes
        /// </summary>
        [DataMember(Name = "expires_in_minutes", EmitDefaultValue = false)]
        public string ExpiresInMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusArpCacheDetail {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  VarInterface: ").Append(VarInterface).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  ExpiresInMinutes: ").Append(ExpiresInMinutes).Append("\n");
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
            return this.Equals(input as ShowStatusArpCacheDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusArpCacheDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusArpCacheDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusArpCacheDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) && 
                (
                    this.VarInterface == input.VarInterface ||
                    (this.VarInterface != null &&
                    this.VarInterface.Equals(input.VarInterface))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.ExpiresInMinutes == input.ExpiresInMinutes ||
                    (this.ExpiresInMinutes != null &&
                    this.ExpiresInMinutes.Equals(input.ExpiresInMinutes))
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
                if (this.IpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddress.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.MacAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MacAddress.GetHashCode();
                }
                if (this.Vendor != null)
                {
                    hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                }
                if (this.VarInterface != null)
                {
                    hashCode = (hashCode * 59) + this.VarInterface.GetHashCode();
                }
                if (this.Timeout != null)
                {
                    hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                }
                if (this.ExpiresInMinutes != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresInMinutes.GetHashCode();
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