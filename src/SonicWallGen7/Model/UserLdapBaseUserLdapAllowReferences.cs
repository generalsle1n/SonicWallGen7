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
    /// Allow continuation references to other LDAP servers.
    /// </summary>
    [DataContract(Name = "user_ldap_base_user_ldap_allow_references")]
    public partial class UserLdapBaseUserLdapAllowReferences : IEquatable<UserLdapBaseUserLdapAllowReferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLdapBaseUserLdapAllowReferences" /> class.
        /// </summary>
        /// <param name="userAuthentication">Follow continuation references during user authentication..</param>
        /// <param name="autoConfiguration">Follow continuation references during auto-configuration..</param>
        /// <param name="domainSearch">Follow continuation references when searching for domains..</param>
        /// <param name="otherSearch">Follow continuation references in other searches..</param>
        public UserLdapBaseUserLdapAllowReferences(bool userAuthentication = default(bool), bool autoConfiguration = default(bool), bool domainSearch = default(bool), bool otherSearch = default(bool))
        {
            this.UserAuthentication = userAuthentication;
            this.AutoConfiguration = autoConfiguration;
            this.DomainSearch = domainSearch;
            this.OtherSearch = otherSearch;
        }

        /// <summary>
        /// Follow continuation references during user authentication.
        /// </summary>
        /// <value>Follow continuation references during user authentication.</value>
        [DataMember(Name = "user_authentication", EmitDefaultValue = true)]
        public bool UserAuthentication { get; set; }

        /// <summary>
        /// Follow continuation references during auto-configuration.
        /// </summary>
        /// <value>Follow continuation references during auto-configuration.</value>
        [DataMember(Name = "auto_configuration", EmitDefaultValue = true)]
        public bool AutoConfiguration { get; set; }

        /// <summary>
        /// Follow continuation references when searching for domains.
        /// </summary>
        /// <value>Follow continuation references when searching for domains.</value>
        [DataMember(Name = "domain_search", EmitDefaultValue = true)]
        public bool DomainSearch { get; set; }

        /// <summary>
        /// Follow continuation references in other searches.
        /// </summary>
        /// <value>Follow continuation references in other searches.</value>
        [DataMember(Name = "other_search", EmitDefaultValue = true)]
        public bool OtherSearch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLdapBaseUserLdapAllowReferences {\n");
            sb.Append("  UserAuthentication: ").Append(UserAuthentication).Append("\n");
            sb.Append("  AutoConfiguration: ").Append(AutoConfiguration).Append("\n");
            sb.Append("  DomainSearch: ").Append(DomainSearch).Append("\n");
            sb.Append("  OtherSearch: ").Append(OtherSearch).Append("\n");
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
            return this.Equals(input as UserLdapBaseUserLdapAllowReferences);
        }

        /// <summary>
        /// Returns true if UserLdapBaseUserLdapAllowReferences instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLdapBaseUserLdapAllowReferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLdapBaseUserLdapAllowReferences input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UserAuthentication == input.UserAuthentication ||
                    this.UserAuthentication.Equals(input.UserAuthentication)
                ) && 
                (
                    this.AutoConfiguration == input.AutoConfiguration ||
                    this.AutoConfiguration.Equals(input.AutoConfiguration)
                ) && 
                (
                    this.DomainSearch == input.DomainSearch ||
                    this.DomainSearch.Equals(input.DomainSearch)
                ) && 
                (
                    this.OtherSearch == input.OtherSearch ||
                    this.OtherSearch.Equals(input.OtherSearch)
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
                hashCode = (hashCode * 59) + this.UserAuthentication.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoConfiguration.GetHashCode();
                hashCode = (hashCode * 59) + this.DomainSearch.GetHashCode();
                hashCode = (hashCode * 59) + this.OtherSearch.GetHashCode();
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
