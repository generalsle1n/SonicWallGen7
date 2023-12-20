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
    /// Enable make user into an inactive state.
    /// </summary>
    [DataContract(Name = "user_auth_base_user_auth_inactive_user")]
    public partial class UserAuthBaseUserAuthInactiveUser : IEquatable<UserAuthBaseUserAuthInactiveUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthBaseUserAuthInactiveUser" /> class.
        /// </summary>
        /// <param name="login">Enable make the user initially inactive until they send traffic on being notified of a login..</param>
        /// <param name="timeout">Enable make all users inactive instead of logging out on inactivity timeout..</param>
        public UserAuthBaseUserAuthInactiveUser(bool login = default(bool), bool timeout = default(bool))
        {
            this.Login = login;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Enable make the user initially inactive until they send traffic on being notified of a login.
        /// </summary>
        /// <value>Enable make the user initially inactive until they send traffic on being notified of a login.</value>
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public bool Login { get; set; }

        /// <summary>
        /// Enable make all users inactive instead of logging out on inactivity timeout.
        /// </summary>
        /// <value>Enable make all users inactive instead of logging out on inactivity timeout.</value>
        [DataMember(Name = "timeout", EmitDefaultValue = true)]
        public bool Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAuthBaseUserAuthInactiveUser {\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(input as UserAuthBaseUserAuthInactiveUser);
        }

        /// <summary>
        /// Returns true if UserAuthBaseUserAuthInactiveUser instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAuthBaseUserAuthInactiveUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthBaseUserAuthInactiveUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Login == input.Login ||
                    this.Login.Equals(input.Login)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
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
                hashCode = (hashCode * 59) + this.Login.GetHashCode();
                hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
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