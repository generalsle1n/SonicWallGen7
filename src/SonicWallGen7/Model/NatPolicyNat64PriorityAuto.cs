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
    /// NatPolicyNat64PriorityAuto
    /// </summary>
    [DataContract(Name = "nat_policy_nat64_priority_auto")]
    public partial class NatPolicyNat64PriorityAuto : IEquatable<NatPolicyNat64PriorityAuto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyNat64PriorityAuto" /> class.
        /// </summary>
        /// <param name="auto">Set auto priority(priority &#x3D; 0) for NAT policy..</param>
        public NatPolicyNat64PriorityAuto(bool auto = default(bool))
        {
            this.Auto = auto;
        }

        /// <summary>
        /// Set auto priority(priority &#x3D; 0) for NAT policy.
        /// </summary>
        /// <value>Set auto priority(priority &#x3D; 0) for NAT policy.</value>
        [DataMember(Name = "auto", EmitDefaultValue = true)]
        public bool Auto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NatPolicyNat64PriorityAuto {\n");
            sb.Append("  Auto: ").Append(Auto).Append("\n");
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
            return this.Equals(input as NatPolicyNat64PriorityAuto);
        }

        /// <summary>
        /// Returns true if NatPolicyNat64PriorityAuto instances are equal
        /// </summary>
        /// <param name="input">Instance of NatPolicyNat64PriorityAuto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NatPolicyNat64PriorityAuto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Auto == input.Auto ||
                    this.Auto.Equals(input.Auto)
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
                hashCode = (hashCode * 59) + this.Auto.GetHashCode();
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
