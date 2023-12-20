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
    /// Configure the RADIUS to LDAP relay.
    /// </summary>
    [DataContract(Name = "user_ldap_base_user_ldap_relay")]
    public partial class UserLdapBaseUserLdapRelay : IEquatable<UserLdapBaseUserLdapRelay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLdapBaseUserLdapRelay" /> class.
        /// </summary>
        /// <param name="enable">Enable RADIUS to LDAP Relay..</param>
        /// <param name="clientsConnect">clientsConnect.</param>
        /// <param name="sharedSecret">Set shared secret. * Set to null to represent an unconfigured state..</param>
        /// <param name="legacyUserGroup">legacyUserGroup.</param>
        public UserLdapBaseUserLdapRelay(bool enable = default(bool), UserLdapBaseUserLdapRelayClientsConnect clientsConnect = default(UserLdapBaseUserLdapRelayClientsConnect), string sharedSecret = default(string), UserLdapBaseUserLdapRelayLegacyUserGroup legacyUserGroup = default(UserLdapBaseUserLdapRelayLegacyUserGroup))
        {
            this.Enable = enable;
            this.ClientsConnect = clientsConnect;
            this.SharedSecret = sharedSecret;
            this.LegacyUserGroup = legacyUserGroup;
        }

        /// <summary>
        /// Enable RADIUS to LDAP Relay.
        /// </summary>
        /// <value>Enable RADIUS to LDAP Relay.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets ClientsConnect
        /// </summary>
        [DataMember(Name = "clients_connect", EmitDefaultValue = false)]
        public UserLdapBaseUserLdapRelayClientsConnect ClientsConnect { get; set; }

        /// <summary>
        /// Set shared secret. * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Set shared secret. * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "shared_secret", EmitDefaultValue = true)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Gets or Sets LegacyUserGroup
        /// </summary>
        [DataMember(Name = "legacy_user_group", EmitDefaultValue = false)]
        public UserLdapBaseUserLdapRelayLegacyUserGroup LegacyUserGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLdapBaseUserLdapRelay {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  ClientsConnect: ").Append(ClientsConnect).Append("\n");
            sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
            sb.Append("  LegacyUserGroup: ").Append(LegacyUserGroup).Append("\n");
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
            return this.Equals(input as UserLdapBaseUserLdapRelay);
        }

        /// <summary>
        /// Returns true if UserLdapBaseUserLdapRelay instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLdapBaseUserLdapRelay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLdapBaseUserLdapRelay input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.ClientsConnect == input.ClientsConnect ||
                    (this.ClientsConnect != null &&
                    this.ClientsConnect.Equals(input.ClientsConnect))
                ) && 
                (
                    this.SharedSecret == input.SharedSecret ||
                    (this.SharedSecret != null &&
                    this.SharedSecret.Equals(input.SharedSecret))
                ) && 
                (
                    this.LegacyUserGroup == input.LegacyUserGroup ||
                    (this.LegacyUserGroup != null &&
                    this.LegacyUserGroup.Equals(input.LegacyUserGroup))
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.ClientsConnect != null)
                {
                    hashCode = (hashCode * 59) + this.ClientsConnect.GetHashCode();
                }
                if (this.SharedSecret != null)
                {
                    hashCode = (hashCode * 59) + this.SharedSecret.GetHashCode();
                }
                if (this.LegacyUserGroup != null)
                {
                    hashCode = (hashCode * 59) + this.LegacyUserGroup.GetHashCode();
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
