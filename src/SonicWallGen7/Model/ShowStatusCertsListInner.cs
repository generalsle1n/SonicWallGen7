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
    /// ShowStatusCertsListInner
    /// </summary>
    [DataContract(Name = "show_status_certs_list_inner")]
    public partial class ShowStatusCertsListInner : IEquatable<ShowStatusCertsListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusCertsListInner" /> class.
        /// </summary>
        /// <param name="certificate">certificate.</param>
        /// <param name="type">type.</param>
        /// <param name="validated">validated.</param>
        /// <param name="expiresOn">expiresOn.</param>
        /// <param name="expiredOn">expiredOn.</param>
        public ShowStatusCertsListInner(string certificate = default(string), string type = default(string), string validated = default(string), string expiresOn = default(string), string expiredOn = default(string))
        {
            this.Certificate = certificate;
            this.Type = type;
            this.Validated = validated;
            this.ExpiresOn = expiresOn;
            this.ExpiredOn = expiredOn;
        }

        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Validated
        /// </summary>
        [DataMember(Name = "validated", EmitDefaultValue = false)]
        public string Validated { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresOn
        /// </summary>
        [DataMember(Name = "expires_on", EmitDefaultValue = false)]
        public string ExpiresOn { get; set; }

        /// <summary>
        /// Gets or Sets ExpiredOn
        /// </summary>
        [DataMember(Name = "expired_on", EmitDefaultValue = false)]
        public string ExpiredOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusCertsListInner {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Validated: ").Append(Validated).Append("\n");
            sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
            sb.Append("  ExpiredOn: ").Append(ExpiredOn).Append("\n");
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
            return this.Equals(input as ShowStatusCertsListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusCertsListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusCertsListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusCertsListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Validated == input.Validated ||
                    (this.Validated != null &&
                    this.Validated.Equals(input.Validated))
                ) && 
                (
                    this.ExpiresOn == input.ExpiresOn ||
                    (this.ExpiresOn != null &&
                    this.ExpiresOn.Equals(input.ExpiresOn))
                ) && 
                (
                    this.ExpiredOn == input.ExpiredOn ||
                    (this.ExpiredOn != null &&
                    this.ExpiredOn.Equals(input.ExpiredOn))
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
                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Validated != null)
                {
                    hashCode = (hashCode * 59) + this.Validated.GetHashCode();
                }
                if (this.ExpiresOn != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresOn.GetHashCode();
                }
                if (this.ExpiredOn != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiredOn.GetHashCode();
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
