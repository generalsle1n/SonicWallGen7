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
    /// UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll
    /// </summary>
    [DataContract(Name = "user_sso_radius_accounting_client_proxy_forward_type_forward_to_all")]
    public partial class UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll : IEquatable<UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll" /> class.
        /// </summary>
        /// <param name="forwardToAll">Proxy forword to all servers..</param>
        public UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll(bool forwardToAll = default(bool))
        {
            this.ForwardToAll = forwardToAll;
        }

        /// <summary>
        /// Proxy forword to all servers.
        /// </summary>
        /// <value>Proxy forword to all servers.</value>
        [DataMember(Name = "forward_to_all", EmitDefaultValue = true)]
        public bool ForwardToAll { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll {\n");
            sb.Append("  ForwardToAll: ").Append(ForwardToAll).Append("\n");
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
            return this.Equals(input as UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll);
        }

        /// <summary>
        /// Returns true if UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSsoRadiusAccountingClientProxyForwardTypeForwardToAll input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ForwardToAll == input.ForwardToAll ||
                    this.ForwardToAll.Equals(input.ForwardToAll)
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
                hashCode = (hashCode * 59) + this.ForwardToAll.GetHashCode();
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