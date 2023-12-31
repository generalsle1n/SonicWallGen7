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
    /// HTTPS protocol.
    /// </summary>
    [DataContract(Name = "botnet_botnet_dynamic_list_https")]
    public partial class BotnetBotnetDynamicListHttps : IEquatable<BotnetBotnetDynamicListHttps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotnetBotnetDynamicListHttps" /> class.
        /// </summary>
        /// <param name="urlName">Set server url name..</param>
        /// <param name="login">Set login ID..</param>
        /// <param name="password">Set password..</param>
        public BotnetBotnetDynamicListHttps(string urlName = default(string), string login = default(string), string password = default(string))
        {
            this.UrlName = urlName;
            this.Login = login;
            this.Password = password;
        }

        /// <summary>
        /// Set server url name.
        /// </summary>
        /// <value>Set server url name.</value>
        [DataMember(Name = "url_name", EmitDefaultValue = false)]
        public string UrlName { get; set; }

        /// <summary>
        /// Set login ID.
        /// </summary>
        /// <value>Set login ID.</value>
        [DataMember(Name = "login", EmitDefaultValue = false)]
        public string Login { get; set; }

        /// <summary>
        /// Set password.
        /// </summary>
        /// <value>Set password.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BotnetBotnetDynamicListHttps {\n");
            sb.Append("  UrlName: ").Append(UrlName).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
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
            return this.Equals(input as BotnetBotnetDynamicListHttps);
        }

        /// <summary>
        /// Returns true if BotnetBotnetDynamicListHttps instances are equal
        /// </summary>
        /// <param name="input">Instance of BotnetBotnetDynamicListHttps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotnetBotnetDynamicListHttps input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UrlName == input.UrlName ||
                    (this.UrlName != null &&
                    this.UrlName.Equals(input.UrlName))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.UrlName != null)
                {
                    hashCode = (hashCode * 59) + this.UrlName.GetHashCode();
                }
                if (this.Login != null)
                {
                    hashCode = (hashCode * 59) + this.Login.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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
