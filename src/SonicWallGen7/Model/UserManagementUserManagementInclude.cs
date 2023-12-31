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
    /// Enable include other users to show.
    /// </summary>
    [DataContract(Name = "user_management_user_management_include")]
    public partial class UserManagementUserManagementInclude : IEquatable<UserManagementUserManagementInclude>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementUserManagementInclude" /> class.
        /// </summary>
        /// <param name="inactiveUsers">Enable show inactive users&#39; status..</param>
        /// <param name="unauthenticatedUsers">Enable show unauthenticated users&#39; status..</param>
        public UserManagementUserManagementInclude(bool inactiveUsers = default(bool), bool unauthenticatedUsers = default(bool))
        {
            this.InactiveUsers = inactiveUsers;
            this.UnauthenticatedUsers = unauthenticatedUsers;
        }

        /// <summary>
        /// Enable show inactive users&#39; status.
        /// </summary>
        /// <value>Enable show inactive users&#39; status.</value>
        [DataMember(Name = "inactive_users", EmitDefaultValue = true)]
        public bool InactiveUsers { get; set; }

        /// <summary>
        /// Enable show unauthenticated users&#39; status.
        /// </summary>
        /// <value>Enable show unauthenticated users&#39; status.</value>
        [DataMember(Name = "unauthenticated_users", EmitDefaultValue = true)]
        public bool UnauthenticatedUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserManagementUserManagementInclude {\n");
            sb.Append("  InactiveUsers: ").Append(InactiveUsers).Append("\n");
            sb.Append("  UnauthenticatedUsers: ").Append(UnauthenticatedUsers).Append("\n");
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
            return this.Equals(input as UserManagementUserManagementInclude);
        }

        /// <summary>
        /// Returns true if UserManagementUserManagementInclude instances are equal
        /// </summary>
        /// <param name="input">Instance of UserManagementUserManagementInclude to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserManagementUserManagementInclude input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InactiveUsers == input.InactiveUsers ||
                    this.InactiveUsers.Equals(input.InactiveUsers)
                ) && 
                (
                    this.UnauthenticatedUsers == input.UnauthenticatedUsers ||
                    this.UnauthenticatedUsers.Equals(input.UnauthenticatedUsers)
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
                hashCode = (hashCode * 59) + this.InactiveUsers.GetHashCode();
                hashCode = (hashCode * 59) + this.UnauthenticatedUsers.GetHashCode();
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
