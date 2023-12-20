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
    /// ShowStatusDhcpLeasesListInner
    /// </summary>
    [DataContract(Name = "show_status_dhcp_leases_list_inner")]
    public partial class ShowStatusDhcpLeasesListInner : IEquatable<ShowStatusDhcpLeasesListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusDhcpLeasesListInner" /> class.
        /// </summary>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="hostName">hostName.</param>
        /// <param name="leaseExpires">leaseExpires.</param>
        /// <param name="macAddress">macAddress.</param>
        /// <param name="vendor">vendor.</param>
        /// <param name="type">type.</param>
        public ShowStatusDhcpLeasesListInner(string ipAddress = default(string), string hostName = default(string), string leaseExpires = default(string), string macAddress = default(string), string vendor = default(string), string type = default(string))
        {
            this.IpAddress = ipAddress;
            this.HostName = hostName;
            this.LeaseExpires = leaseExpires;
            this.MacAddress = macAddress;
            this.Vendor = vendor;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ip_address", EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets HostName
        /// </summary>
        [DataMember(Name = "host_name", EmitDefaultValue = false)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets LeaseExpires
        /// </summary>
        [DataMember(Name = "lease_expires", EmitDefaultValue = false)]
        public string LeaseExpires { get; set; }

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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusDhcpLeasesListInner {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  LeaseExpires: ").Append(LeaseExpires).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ShowStatusDhcpLeasesListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusDhcpLeasesListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusDhcpLeasesListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusDhcpLeasesListInner input)
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
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.LeaseExpires == input.LeaseExpires ||
                    (this.LeaseExpires != null &&
                    this.LeaseExpires.Equals(input.LeaseExpires))
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.HostName != null)
                {
                    hashCode = (hashCode * 59) + this.HostName.GetHashCode();
                }
                if (this.LeaseExpires != null)
                {
                    hashCode = (hashCode * 59) + this.LeaseExpires.GetHashCode();
                }
                if (this.MacAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MacAddress.GetHashCode();
                }
                if (this.Vendor != null)
                {
                    hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
