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
    /// Configure consent.
    /// </summary>
    [DataContract(Name = "content_filter_profile_consent")]
    public partial class ContentFilterProfileConsent : IEquatable<ContentFilterProfileConsent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterProfileConsent" /> class.
        /// </summary>
        /// <param name="required">Enable consent..</param>
        /// <param name="userIdleTimeout">Set user idle timeout..</param>
        /// <param name="optional">optional.</param>
        /// <param name="mandatory">mandatory.</param>
        public ContentFilterProfileConsent(bool required = default(bool), decimal userIdleTimeout = default(decimal), ContentFilterProfileConsentOptional optional = default(ContentFilterProfileConsentOptional), ContentFilterProfileConsentMandatory mandatory = default(ContentFilterProfileConsentMandatory))
        {
            this.Required = required;
            this.UserIdleTimeout = userIdleTimeout;
            this.Optional = optional;
            this.Mandatory = mandatory;
        }

        /// <summary>
        /// Enable consent.
        /// </summary>
        /// <value>Enable consent.</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Set user idle timeout.
        /// </summary>
        /// <value>Set user idle timeout.</value>
        [DataMember(Name = "user_idle_timeout", EmitDefaultValue = false)]
        public decimal UserIdleTimeout { get; set; }

        /// <summary>
        /// Gets or Sets Optional
        /// </summary>
        [DataMember(Name = "optional", EmitDefaultValue = false)]
        public ContentFilterProfileConsentOptional Optional { get; set; }

        /// <summary>
        /// Gets or Sets Mandatory
        /// </summary>
        [DataMember(Name = "mandatory", EmitDefaultValue = false)]
        public ContentFilterProfileConsentMandatory Mandatory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentFilterProfileConsent {\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  UserIdleTimeout: ").Append(UserIdleTimeout).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Mandatory: ").Append(Mandatory).Append("\n");
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
            return this.Equals(input as ContentFilterProfileConsent);
        }

        /// <summary>
        /// Returns true if ContentFilterProfileConsent instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentFilterProfileConsent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentFilterProfileConsent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.UserIdleTimeout == input.UserIdleTimeout ||
                    this.UserIdleTimeout.Equals(input.UserIdleTimeout)
                ) && 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.Mandatory == input.Mandatory ||
                    (this.Mandatory != null &&
                    this.Mandatory.Equals(input.Mandatory))
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
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                hashCode = (hashCode * 59) + this.UserIdleTimeout.GetHashCode();
                if (this.Optional != null)
                {
                    hashCode = (hashCode * 59) + this.Optional.GetHashCode();
                }
                if (this.Mandatory != null)
                {
                    hashCode = (hashCode * 59) + this.Mandatory.GetHashCode();
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