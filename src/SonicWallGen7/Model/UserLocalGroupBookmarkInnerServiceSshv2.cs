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
    /// Secure shell version 2 (SSHv2).
    /// </summary>
    [DataContract(Name = "user_local_group_bookmark_inner_service_sshv2")]
    public partial class UserLocalGroupBookmarkInnerServiceSshv2 : IEquatable<UserLocalGroupBookmarkInnerServiceSshv2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocalGroupBookmarkInnerServiceSshv2" /> class.
        /// </summary>
        /// <param name="automaticAcceptHostKey">Enable automatically accept host key..</param>
        /// <param name="displayOnMobile">Enable display bookmark to mobile connect clients..</param>
        public UserLocalGroupBookmarkInnerServiceSshv2(bool automaticAcceptHostKey = default(bool), bool displayOnMobile = default(bool))
        {
            this.AutomaticAcceptHostKey = automaticAcceptHostKey;
            this.DisplayOnMobile = displayOnMobile;
        }

        /// <summary>
        /// Enable automatically accept host key.
        /// </summary>
        /// <value>Enable automatically accept host key.</value>
        [DataMember(Name = "automatic_accept_host_key", EmitDefaultValue = true)]
        public bool AutomaticAcceptHostKey { get; set; }

        /// <summary>
        /// Enable display bookmark to mobile connect clients.
        /// </summary>
        /// <value>Enable display bookmark to mobile connect clients.</value>
        [DataMember(Name = "display_on_mobile", EmitDefaultValue = true)]
        public bool DisplayOnMobile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLocalGroupBookmarkInnerServiceSshv2 {\n");
            sb.Append("  AutomaticAcceptHostKey: ").Append(AutomaticAcceptHostKey).Append("\n");
            sb.Append("  DisplayOnMobile: ").Append(DisplayOnMobile).Append("\n");
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
            return this.Equals(input as UserLocalGroupBookmarkInnerServiceSshv2);
        }

        /// <summary>
        /// Returns true if UserLocalGroupBookmarkInnerServiceSshv2 instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLocalGroupBookmarkInnerServiceSshv2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLocalGroupBookmarkInnerServiceSshv2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AutomaticAcceptHostKey == input.AutomaticAcceptHostKey ||
                    this.AutomaticAcceptHostKey.Equals(input.AutomaticAcceptHostKey)
                ) && 
                (
                    this.DisplayOnMobile == input.DisplayOnMobile ||
                    this.DisplayOnMobile.Equals(input.DisplayOnMobile)
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
                hashCode = (hashCode * 59) + this.AutomaticAcceptHostKey.GetHashCode();
                hashCode = (hashCode * 59) + this.DisplayOnMobile.GetHashCode();
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
