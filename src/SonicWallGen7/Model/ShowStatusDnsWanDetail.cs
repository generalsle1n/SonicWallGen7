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
    /// SonicDns wan detail schema.
    /// </summary>
    [DataContract(Name = "show_status_SonicDns_wan_detail")]
    public partial class ShowStatusSonicDnsWanDetail : IEquatable<ShowStatusSonicDnsWanDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusSonicDnsWanDetail" /> class.
        /// </summary>
        /// <param name="SonicDnsServer1">SonicDnsServer1.</param>
        /// <param name="SonicDnsServer2">SonicDnsServer2.</param>
        /// <param name="SonicDnsServer3">SonicDnsServer3.</param>
        public ShowStatusSonicDnsWanDetail(string SonicDnsServer1 = default(string), string SonicDnsServer2 = default(string), string SonicDnsServer3 = default(string))
        {
            this.SonicDnsServer1 = SonicDnsServer1;
            this.SonicDnsServer2 = SonicDnsServer2;
            this.SonicDnsServer3 = SonicDnsServer3;
        }

        /// <summary>
        /// Gets or Sets SonicDnsServer1
        /// </summary>
        [DataMember(Name = "SonicDns_server_1", EmitDefaultValue = false)]
        public string SonicDnsServer1 { get; set; }

        /// <summary>
        /// Gets or Sets SonicDnsServer2
        /// </summary>
        [DataMember(Name = "SonicDns_server_2", EmitDefaultValue = false)]
        public string SonicDnsServer2 { get; set; }

        /// <summary>
        /// Gets or Sets SonicDnsServer3
        /// </summary>
        [DataMember(Name = "SonicDns_server_3", EmitDefaultValue = false)]
        public string SonicDnsServer3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusSonicDnsWanDetail {\n");
            sb.Append("  SonicDnsServer1: ").Append(SonicDnsServer1).Append("\n");
            sb.Append("  SonicDnsServer2: ").Append(SonicDnsServer2).Append("\n");
            sb.Append("  SonicDnsServer3: ").Append(SonicDnsServer3).Append("\n");
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
            return this.Equals(input as ShowStatusSonicDnsWanDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusSonicDnsWanDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusSonicDnsWanDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusSonicDnsWanDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SonicDnsServer1 == input.SonicDnsServer1 ||
                    (this.SonicDnsServer1 != null &&
                    this.SonicDnsServer1.Equals(input.SonicDnsServer1))
                ) && 
                (
                    this.SonicDnsServer2 == input.SonicDnsServer2 ||
                    (this.SonicDnsServer2 != null &&
                    this.SonicDnsServer2.Equals(input.SonicDnsServer2))
                ) && 
                (
                    this.SonicDnsServer3 == input.SonicDnsServer3 ||
                    (this.SonicDnsServer3 != null &&
                    this.SonicDnsServer3.Equals(input.SonicDnsServer3))
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
                if (this.SonicDnsServer1 != null)
                {
                    hashCode = (hashCode * 59) + this.SonicDnsServer1.GetHashCode();
                }
                if (this.SonicDnsServer2 != null)
                {
                    hashCode = (hashCode * 59) + this.SonicDnsServer2.GetHashCode();
                }
                if (this.SonicDnsServer3 != null)
                {
                    hashCode = (hashCode * 59) + this.SonicDnsServer3.GetHashCode();
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
