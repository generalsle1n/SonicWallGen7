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
    /// User authentication test, testing that a given user name and                password can be sent to and authenticated by the LDAP server.
    /// </summary>
    [DataContract(Name = "user_ldap_test_normal_ldap_test_type_user_authentication_user_authentication")]
    public partial class UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication : IEquatable<UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication" /> class.
        /// </summary>
        /// <param name="userName">User name to test..</param>
        /// <param name="userPwd">The user&#39;s password..</param>
        /// <param name="chap">Test LDAP in a CHAP-compatible way..</param>
        public UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication(string userName = default(string), string userPwd = default(string), bool chap = default(bool))
        {
            this.UserName = userName;
            this.UserPwd = userPwd;
            this.Chap = chap;
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
        /// Test LDAP in a CHAP-compatible way.
        /// </summary>
        /// <value>Test LDAP in a CHAP-compatible way.</value>
        [DataMember(Name = "chap", EmitDefaultValue = true)]
        public bool Chap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserPwd: ").Append(UserPwd).Append("\n");
            sb.Append("  Chap: ").Append(Chap).Append("\n");
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
            return this.Equals(input as UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication);
        }

        /// <summary>
        /// Returns true if UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLdapTestNormalLdapTestTypeUserAuthenticationUserAuthentication input)
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
                    this.Chap == input.Chap ||
                    this.Chap.Equals(input.Chap)
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
                hashCode = (hashCode * 59) + this.Chap.GetHashCode();
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
