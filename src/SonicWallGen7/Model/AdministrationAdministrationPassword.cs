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
    /// Configure password constraints.
    /// </summary>
    [DataContract(Name = "administration_administration_password")]
    public partial class AdministrationAdministrationPassword : IEquatable<AdministrationAdministrationPassword>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationAdministrationPassword" /> class.
        /// </summary>
        /// <param name="aging">aging.</param>
        /// <param name="lastChanged">lastChanged.</param>
        /// <param name="uniqueness">uniqueness.</param>
        /// <param name="enforceCharacterDifference">Enable new password must contain 4 characters different from the old password..</param>
        /// <param name="minimumLength">Set the minimum password length to enforce..</param>
        /// <param name="complexity">complexity.</param>
        /// <param name="constraintsApplyTo">constraintsApplyTo.</param>
        public AdministrationAdministrationPassword(AdministrationAdministrationPasswordAging aging = default(AdministrationAdministrationPasswordAging), AdministrationAdministrationPasswordLastChanged lastChanged = default(AdministrationAdministrationPasswordLastChanged), AdministrationAdministrationPasswordUniqueness uniqueness = default(AdministrationAdministrationPasswordUniqueness), bool enforceCharacterDifference = default(bool), decimal minimumLength = default(decimal), AdministrationAdministrationPasswordComplexity complexity = default(AdministrationAdministrationPasswordComplexity), AdministrationAdministrationPasswordConstraintsApplyTo constraintsApplyTo = default(AdministrationAdministrationPasswordConstraintsApplyTo))
        {
            this.Aging = aging;
            this.LastChanged = lastChanged;
            this.Uniqueness = uniqueness;
            this.EnforceCharacterDifference = enforceCharacterDifference;
            this.MinimumLength = minimumLength;
            this.Complexity = complexity;
            this.ConstraintsApplyTo = constraintsApplyTo;
        }

        /// <summary>
        /// Gets or Sets Aging
        /// </summary>
        [DataMember(Name = "aging", EmitDefaultValue = true)]
        public AdministrationAdministrationPasswordAging Aging { get; set; }

        /// <summary>
        /// Gets or Sets LastChanged
        /// </summary>
        [DataMember(Name = "last_changed", EmitDefaultValue = true)]
        public AdministrationAdministrationPasswordLastChanged LastChanged { get; set; }

        /// <summary>
        /// Gets or Sets Uniqueness
        /// </summary>
        [DataMember(Name = "uniqueness", EmitDefaultValue = true)]
        public AdministrationAdministrationPasswordUniqueness Uniqueness { get; set; }

        /// <summary>
        /// Enable new password must contain 4 characters different from the old password.
        /// </summary>
        /// <value>Enable new password must contain 4 characters different from the old password.</value>
        [DataMember(Name = "enforce_character_difference", EmitDefaultValue = true)]
        public bool EnforceCharacterDifference { get; set; }

        /// <summary>
        /// Set the minimum password length to enforce.
        /// </summary>
        /// <value>Set the minimum password length to enforce.</value>
        [DataMember(Name = "minimum_length", EmitDefaultValue = false)]
        public decimal MinimumLength { get; set; }

        /// <summary>
        /// Gets or Sets Complexity
        /// </summary>
        [DataMember(Name = "complexity", EmitDefaultValue = true)]
        public AdministrationAdministrationPasswordComplexity Complexity { get; set; }

        /// <summary>
        /// Gets or Sets ConstraintsApplyTo
        /// </summary>
        [DataMember(Name = "constraints_apply_to", EmitDefaultValue = true)]
        public AdministrationAdministrationPasswordConstraintsApplyTo ConstraintsApplyTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdministrationAdministrationPassword {\n");
            sb.Append("  Aging: ").Append(Aging).Append("\n");
            sb.Append("  LastChanged: ").Append(LastChanged).Append("\n");
            sb.Append("  Uniqueness: ").Append(Uniqueness).Append("\n");
            sb.Append("  EnforceCharacterDifference: ").Append(EnforceCharacterDifference).Append("\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
            sb.Append("  Complexity: ").Append(Complexity).Append("\n");
            sb.Append("  ConstraintsApplyTo: ").Append(ConstraintsApplyTo).Append("\n");
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
            return this.Equals(input as AdministrationAdministrationPassword);
        }

        /// <summary>
        /// Returns true if AdministrationAdministrationPassword instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministrationAdministrationPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministrationAdministrationPassword input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Aging == input.Aging ||
                    (this.Aging != null &&
                    this.Aging.Equals(input.Aging))
                ) && 
                (
                    this.LastChanged == input.LastChanged ||
                    (this.LastChanged != null &&
                    this.LastChanged.Equals(input.LastChanged))
                ) && 
                (
                    this.Uniqueness == input.Uniqueness ||
                    (this.Uniqueness != null &&
                    this.Uniqueness.Equals(input.Uniqueness))
                ) && 
                (
                    this.EnforceCharacterDifference == input.EnforceCharacterDifference ||
                    this.EnforceCharacterDifference.Equals(input.EnforceCharacterDifference)
                ) && 
                (
                    this.MinimumLength == input.MinimumLength ||
                    this.MinimumLength.Equals(input.MinimumLength)
                ) && 
                (
                    this.Complexity == input.Complexity ||
                    (this.Complexity != null &&
                    this.Complexity.Equals(input.Complexity))
                ) && 
                (
                    this.ConstraintsApplyTo == input.ConstraintsApplyTo ||
                    (this.ConstraintsApplyTo != null &&
                    this.ConstraintsApplyTo.Equals(input.ConstraintsApplyTo))
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
                if (this.Aging != null)
                {
                    hashCode = (hashCode * 59) + this.Aging.GetHashCode();
                }
                if (this.LastChanged != null)
                {
                    hashCode = (hashCode * 59) + this.LastChanged.GetHashCode();
                }
                if (this.Uniqueness != null)
                {
                    hashCode = (hashCode * 59) + this.Uniqueness.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnforceCharacterDifference.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumLength.GetHashCode();
                if (this.Complexity != null)
                {
                    hashCode = (hashCode * 59) + this.Complexity.GetHashCode();
                }
                if (this.ConstraintsApplyTo != null)
                {
                    hashCode = (hashCode * 59) + this.ConstraintsApplyTo.GetHashCode();
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
