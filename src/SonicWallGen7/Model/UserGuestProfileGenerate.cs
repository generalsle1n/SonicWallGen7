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
    /// Auto generate names or passwords for created guest accounts.
    /// </summary>
    [DataContract(Name = "user_guest_profile_generate")]
    public partial class UserGuestProfileGenerate : IEquatable<UserGuestProfileGenerate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGuestProfileGenerate" /> class.
        /// </summary>
        /// <param name="name">Auto-generate names for created guest accounts..</param>
        /// <param name="password">Auto generate passwords for created guest accounts..</param>
        public UserGuestProfileGenerate(bool name = default(bool), bool password = default(bool))
        {
            this.Name = name;
            this.Password = password;
        }

        /// <summary>
        /// Auto-generate names for created guest accounts.
        /// </summary>
        /// <value>Auto-generate names for created guest accounts.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public bool Name { get; set; }

        /// <summary>
        /// Auto generate passwords for created guest accounts.
        /// </summary>
        /// <value>Auto generate passwords for created guest accounts.</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public bool Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserGuestProfileGenerate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as UserGuestProfileGenerate);
        }

        /// <summary>
        /// Returns true if UserGuestProfileGenerate instances are equal
        /// </summary>
        /// <param name="input">Instance of UserGuestProfileGenerate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserGuestProfileGenerate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.Password == input.Password ||
                    this.Password.Equals(input.Password)
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
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                hashCode = (hashCode * 59) + this.Password.GetHashCode();
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
