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
    /// DecryptionPolicyClientActionDecrypt
    /// </summary>
    [DataContract(Name = "decryption_policy_client_action_decrypt")]
    public partial class DecryptionPolicyClientActionDecrypt : IEquatable<DecryptionPolicyClientActionDecrypt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecryptionPolicyClientActionDecrypt" /> class.
        /// </summary>
        /// <param name="decrypt">Decrypt traffic matching the criteria..</param>
        public DecryptionPolicyClientActionDecrypt(bool decrypt = default(bool))
        {
            this.Decrypt = decrypt;
        }

        /// <summary>
        /// Decrypt traffic matching the criteria.
        /// </summary>
        /// <value>Decrypt traffic matching the criteria.</value>
        [DataMember(Name = "decrypt", EmitDefaultValue = true)]
        public bool Decrypt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DecryptionPolicyClientActionDecrypt {\n");
            sb.Append("  Decrypt: ").Append(Decrypt).Append("\n");
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
            return this.Equals(input as DecryptionPolicyClientActionDecrypt);
        }

        /// <summary>
        /// Returns true if DecryptionPolicyClientActionDecrypt instances are equal
        /// </summary>
        /// <param name="input">Instance of DecryptionPolicyClientActionDecrypt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecryptionPolicyClientActionDecrypt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Decrypt == input.Decrypt ||
                    this.Decrypt.Equals(input.Decrypt)
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
                hashCode = (hashCode * 59) + this.Decrypt.GetHashCode();
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