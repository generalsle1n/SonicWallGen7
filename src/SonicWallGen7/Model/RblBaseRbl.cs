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
    /// Enter real-time blacklist configuration mode.
    /// </summary>
    [DataContract(Name = "rbl_base_rbl")]
    public partial class RblBaseRbl : IEquatable<RblBaseRbl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RblBaseRbl" /> class.
        /// </summary>
        /// <param name="enable">Enable real-time blacklist blocking..</param>
        /// <param name="SonicDns">SonicDns.</param>
        public RblBaseRbl(bool enable = default(bool), RblBaseRblSonicDns SonicDns = default(RblBaseRblSonicDns))
        {
            this.Enable = enable;
            this.SonicDns = SonicDns;
        }

        /// <summary>
        /// Enable real-time blacklist blocking.
        /// </summary>
        /// <value>Enable real-time blacklist blocking.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets SonicDns
        /// </summary>
        [DataMember(Name = "SonicDns", EmitDefaultValue = false)]
        public RblBaseRblSonicDns SonicDns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RblBaseRbl {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  SonicDns: ").Append(SonicDns).Append("\n");
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
            return this.Equals(input as RblBaseRbl);
        }

        /// <summary>
        /// Returns true if RblBaseRbl instances are equal
        /// </summary>
        /// <param name="input">Instance of RblBaseRbl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RblBaseRbl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.SonicDns == input.SonicDns ||
                    (this.SonicDns != null &&
                    this.SonicDns.Equals(input.SonicDns))
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.SonicDns != null)
                {
                    hashCode = (hashCode * 59) + this.SonicDns.GetHashCode();
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
