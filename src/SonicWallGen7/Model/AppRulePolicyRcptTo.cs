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
    /// Set RCPT to e-mail address object for the app rule policy.
    /// </summary>
    [DataContract(Name = "app_rule_policy_rcpt_to")]
    public partial class AppRulePolicyRcptTo : IEquatable<AppRulePolicyRcptTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRulePolicyRcptTo" /> class.
        /// </summary>
        /// <param name="included">Set the included RCPT to e-mail address object for the app rule policy..</param>
        /// <param name="excluded">Set the excluded RCPT to e-mail address object for the app rule policy..</param>
        public AppRulePolicyRcptTo(string included = default(string), string excluded = default(string))
        {
            this.Included = included;
            this.Excluded = excluded;
        }

        /// <summary>
        /// Set the included RCPT to e-mail address object for the app rule policy.
        /// </summary>
        /// <value>Set the included RCPT to e-mail address object for the app rule policy.</value>
        [DataMember(Name = "included", EmitDefaultValue = false)]
        public string Included { get; set; }

        /// <summary>
        /// Set the excluded RCPT to e-mail address object for the app rule policy.
        /// </summary>
        /// <value>Set the excluded RCPT to e-mail address object for the app rule policy.</value>
        [DataMember(Name = "excluded", EmitDefaultValue = false)]
        public string Excluded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRulePolicyRcptTo {\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Excluded: ").Append(Excluded).Append("\n");
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
            return this.Equals(input as AppRulePolicyRcptTo);
        }

        /// <summary>
        /// Returns true if AppRulePolicyRcptTo instances are equal
        /// </summary>
        /// <param name="input">Instance of AppRulePolicyRcptTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppRulePolicyRcptTo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Included == input.Included ||
                    (this.Included != null &&
                    this.Included.Equals(input.Included))
                ) && 
                (
                    this.Excluded == input.Excluded ||
                    (this.Excluded != null &&
                    this.Excluded.Equals(input.Excluded))
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
                if (this.Included != null)
                {
                    hashCode = (hashCode * 59) + this.Included.GetHashCode();
                }
                if (this.Excluded != null)
                {
                    hashCode = (hashCode * 59) + this.Excluded.GetHashCode();
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
