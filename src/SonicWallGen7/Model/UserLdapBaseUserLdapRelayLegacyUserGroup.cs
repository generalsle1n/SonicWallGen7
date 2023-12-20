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
    /// Set the user group that corresponds to the legacy                access privileges.
    /// </summary>
    [DataContract(Name = "user_ldap_base_user_ldap_relay_legacy_user_group")]
    public partial class UserLdapBaseUserLdapRelayLegacyUserGroup : IEquatable<UserLdapBaseUserLdapRelayLegacyUserGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLdapBaseUserLdapRelayLegacyUserGroup" /> class.
        /// </summary>
        /// <param name="vpn">Set the user group for VPN users..</param>
        /// <param name="vpnClient">Set the user group for VPN client users..</param>
        /// <param name="l2tp">Set the user group for L2TP users..</param>
        /// <param name="internet">Set the user group for users with Internet access..</param>
        public UserLdapBaseUserLdapRelayLegacyUserGroup(string vpn = default(string), string vpnClient = default(string), string l2tp = default(string), string internet = default(string))
        {
            this.Vpn = vpn;
            this.VpnClient = vpnClient;
            this.L2tp = l2tp;
            this.Internet = internet;
        }

        /// <summary>
        /// Set the user group for VPN users.
        /// </summary>
        /// <value>Set the user group for VPN users.</value>
        [DataMember(Name = "vpn", EmitDefaultValue = false)]
        public string Vpn { get; set; }

        /// <summary>
        /// Set the user group for VPN client users.
        /// </summary>
        /// <value>Set the user group for VPN client users.</value>
        [DataMember(Name = "vpn_client", EmitDefaultValue = false)]
        public string VpnClient { get; set; }

        /// <summary>
        /// Set the user group for L2TP users.
        /// </summary>
        /// <value>Set the user group for L2TP users.</value>
        [DataMember(Name = "l2tp", EmitDefaultValue = false)]
        public string L2tp { get; set; }

        /// <summary>
        /// Set the user group for users with Internet access.
        /// </summary>
        /// <value>Set the user group for users with Internet access.</value>
        [DataMember(Name = "internet", EmitDefaultValue = false)]
        public string Internet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLdapBaseUserLdapRelayLegacyUserGroup {\n");
            sb.Append("  Vpn: ").Append(Vpn).Append("\n");
            sb.Append("  VpnClient: ").Append(VpnClient).Append("\n");
            sb.Append("  L2tp: ").Append(L2tp).Append("\n");
            sb.Append("  Internet: ").Append(Internet).Append("\n");
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
            return this.Equals(input as UserLdapBaseUserLdapRelayLegacyUserGroup);
        }

        /// <summary>
        /// Returns true if UserLdapBaseUserLdapRelayLegacyUserGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLdapBaseUserLdapRelayLegacyUserGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLdapBaseUserLdapRelayLegacyUserGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Vpn == input.Vpn ||
                    (this.Vpn != null &&
                    this.Vpn.Equals(input.Vpn))
                ) && 
                (
                    this.VpnClient == input.VpnClient ||
                    (this.VpnClient != null &&
                    this.VpnClient.Equals(input.VpnClient))
                ) && 
                (
                    this.L2tp == input.L2tp ||
                    (this.L2tp != null &&
                    this.L2tp.Equals(input.L2tp))
                ) && 
                (
                    this.Internet == input.Internet ||
                    (this.Internet != null &&
                    this.Internet.Equals(input.Internet))
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
                if (this.Vpn != null)
                {
                    hashCode = (hashCode * 59) + this.Vpn.GetHashCode();
                }
                if (this.VpnClient != null)
                {
                    hashCode = (hashCode * 59) + this.VpnClient.GetHashCode();
                }
                if (this.L2tp != null)
                {
                    hashCode = (hashCode * 59) + this.L2tp.GetHashCode();
                }
                if (this.Internet != null)
                {
                    hashCode = (hashCode * 59) + this.Internet.GetHashCode();
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