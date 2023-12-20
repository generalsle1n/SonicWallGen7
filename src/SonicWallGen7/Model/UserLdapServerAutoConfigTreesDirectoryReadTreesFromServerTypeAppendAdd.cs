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
    /// UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd
    /// </summary>
    [DataContract(Name = "user_ldap_server_auto_config_trees_directory_read_trees_from_server_type_append_add")]
    public partial class UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd : IEquatable<UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd" /> class.
        /// </summary>
        /// <param name="add">For append method, we need append trees found on that server to                its own configuration, and for replace method, we need to replace                the trees in that server&#39;s own configuration with those found on it..</param>
        public UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd(bool add = default(bool))
        {
            this.Add = add;
        }

        /// <summary>
        /// For append method, we need append trees found on that server to                its own configuration, and for replace method, we need to replace                the trees in that server&#39;s own configuration with those found on it.
        /// </summary>
        /// <value>For append method, we need append trees found on that server to                its own configuration, and for replace method, we need to replace                the trees in that server&#39;s own configuration with those found on it.</value>
        [DataMember(Name = "add", EmitDefaultValue = true)]
        public bool Add { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
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
            return this.Equals(input as UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd);
        }

        /// <summary>
        /// Returns true if UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLdapServerAutoConfigTreesDirectoryReadTreesFromServerTypeAppendAdd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Add == input.Add ||
                    this.Add.Equals(input.Add)
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
                hashCode = (hashCode * 59) + this.Add.GetHashCode();
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
