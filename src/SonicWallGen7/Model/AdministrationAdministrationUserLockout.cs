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
    /// Enable administrator / user lockout and set conditions.
    /// </summary>
    [DataContract(Name = "administration_administration_user_lockout")]
    public partial class AdministrationAdministrationUserLockout : IEquatable<AdministrationAdministrationUserLockout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationAdministrationUserLockout" /> class.
        /// </summary>
        /// <param name="enable">Enable administrator / user lockout configure..</param>
        /// <param name="failuresRate">Set the failed login attempts in designed duration before lockout..</param>
        /// <param name="failuresDuration">Set the failed in designed duration before lockout..</param>
        /// <param name="lockoutDuration">Set number of minutes a user should be locked out. * Set to null to represent an unconfigured state..</param>
        public AdministrationAdministrationUserLockout(bool enable = default(bool), decimal failuresRate = default(decimal), decimal failuresDuration = default(decimal), decimal? lockoutDuration = default(decimal?))
        {
            this.Enable = enable;
            this.FailuresRate = failuresRate;
            this.FailuresDuration = failuresDuration;
            this.LockoutDuration = lockoutDuration;
        }

        /// <summary>
        /// Enable administrator / user lockout configure.
        /// </summary>
        /// <value>Enable administrator / user lockout configure.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Set the failed login attempts in designed duration before lockout.
        /// </summary>
        /// <value>Set the failed login attempts in designed duration before lockout.</value>
        [DataMember(Name = "failures_rate", EmitDefaultValue = false)]
        public decimal FailuresRate { get; set; }

        /// <summary>
        /// Set the failed in designed duration before lockout.
        /// </summary>
        /// <value>Set the failed in designed duration before lockout.</value>
        [DataMember(Name = "failures_duration", EmitDefaultValue = false)]
        public decimal FailuresDuration { get; set; }

        /// <summary>
        /// Set number of minutes a user should be locked out. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set number of minutes a user should be locked out. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "lockout_duration", EmitDefaultValue = true)]
        public decimal? LockoutDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdministrationAdministrationUserLockout {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  FailuresRate: ").Append(FailuresRate).Append("\n");
            sb.Append("  FailuresDuration: ").Append(FailuresDuration).Append("\n");
            sb.Append("  LockoutDuration: ").Append(LockoutDuration).Append("\n");
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
            return this.Equals(input as AdministrationAdministrationUserLockout);
        }

        /// <summary>
        /// Returns true if AdministrationAdministrationUserLockout instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministrationAdministrationUserLockout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministrationAdministrationUserLockout input)
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
                    this.FailuresRate == input.FailuresRate ||
                    this.FailuresRate.Equals(input.FailuresRate)
                ) && 
                (
                    this.FailuresDuration == input.FailuresDuration ||
                    this.FailuresDuration.Equals(input.FailuresDuration)
                ) && 
                (
                    this.LockoutDuration == input.LockoutDuration ||
                    (this.LockoutDuration != null &&
                    this.LockoutDuration.Equals(input.LockoutDuration))
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
                hashCode = (hashCode * 59) + this.FailuresRate.GetHashCode();
                hashCode = (hashCode * 59) + this.FailuresDuration.GetHashCode();
                if (this.LockoutDuration != null)
                {
                    hashCode = (hashCode * 59) + this.LockoutDuration.GetHashCode();
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
