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
    /// Run the TACACS user test with the given user name/password.
    /// </summary>
    [DataContract(Name = "user_tacacs_test_user_tacacs_test_user")]
    public partial class UserTacacsTestUserTacacsTestUser : IEquatable<UserTacacsTestUserTacacsTestUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTacacsTestUserTacacsTestUser" /> class.
        /// </summary>
        /// <param name="userName">User name to test..</param>
        /// <param name="userPwd">The user&#39;s password..</param>
        /// <param name="authMethod">authMethod.</param>
        public UserTacacsTestUserTacacsTestUser(string userName = default(string), string userPwd = default(string), UserTacacsTestUserTacacsTestUserAuthMethod authMethod = default(UserTacacsTestUserTacacsTestUserAuthMethod))
        {
            this.UserName = userName;
            this.UserPwd = userPwd;
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// User name to test.
        /// </summary>
        /// <value>User name to test.</value>
        [DataMember(Name = "userName", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// The user&#39;s password.
        /// </summary>
        /// <value>The user&#39;s password.</value>
        [DataMember(Name = "userPwd", EmitDefaultValue = false)]
        public string UserPwd { get; set; }

        /// <summary>
        /// Gets or Sets AuthMethod
        /// </summary>
        [DataMember(Name = "auth_method", EmitDefaultValue = false)]
        public UserTacacsTestUserTacacsTestUserAuthMethod AuthMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserTacacsTestUserTacacsTestUser {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserPwd: ").Append(UserPwd).Append("\n");
            sb.Append("  AuthMethod: ").Append(AuthMethod).Append("\n");
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
            return this.Equals(input as UserTacacsTestUserTacacsTestUser);
        }

        /// <summary>
        /// Returns true if UserTacacsTestUserTacacsTestUser instances are equal
        /// </summary>
        /// <param name="input">Instance of UserTacacsTestUserTacacsTestUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTacacsTestUserTacacsTestUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserPwd == input.UserPwd ||
                    (this.UserPwd != null &&
                    this.UserPwd.Equals(input.UserPwd))
                ) && 
                (
                    this.AuthMethod == input.AuthMethod ||
                    (this.AuthMethod != null &&
                    this.AuthMethod.Equals(input.AuthMethod))
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
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.UserPwd != null)
                {
                    hashCode = (hashCode * 59) + this.UserPwd.GetHashCode();
                }
                if (this.AuthMethod != null)
                {
                    hashCode = (hashCode * 59) + this.AuthMethod.GetHashCode();
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
