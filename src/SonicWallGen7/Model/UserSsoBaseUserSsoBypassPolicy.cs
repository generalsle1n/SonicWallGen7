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
    /// Select to have per-zone security policies auto-created for the specified service to bypass SSO enforcement.
    /// </summary>
    [DataContract(Name = "user_sso_base_user_sso_bypass_policy")]
    public partial class UserSsoBaseUserSsoBypassPolicy : IEquatable<UserSsoBaseUserSsoBypassPolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSsoBaseUserSsoBypassPolicy" /> class.
        /// </summary>
        /// <param name="voip">Auto-create SSO bypass security policies for VOIP..</param>
        /// <param name="ospf">Auto-create SSO bypass security policies for OSPF..</param>
        /// <param name="ipsec">Auto-create SSO bypass security policies for IPSec..</param>
        /// <param name="dhcp">Auto-create SSO bypass security policies for DHCP..</param>
        /// <param name="rip">Auto-create SSO bypass security policies for RIP..</param>
        public UserSsoBaseUserSsoBypassPolicy(bool voip = default(bool), bool ospf = default(bool), bool ipsec = default(bool), bool dhcp = default(bool), bool rip = default(bool))
        {
            this.Voip = voip;
            this.Ospf = ospf;
            this.Ipsec = ipsec;
            this.Dhcp = dhcp;
            this.Rip = rip;
        }

        /// <summary>
        /// Auto-create SSO bypass security policies for VOIP.
        /// </summary>
        /// <value>Auto-create SSO bypass security policies for VOIP.</value>
        [DataMember(Name = "voip", EmitDefaultValue = true)]
        public bool Voip { get; set; }

        /// <summary>
        /// Auto-create SSO bypass security policies for OSPF.
        /// </summary>
        /// <value>Auto-create SSO bypass security policies for OSPF.</value>
        [DataMember(Name = "ospf", EmitDefaultValue = true)]
        public bool Ospf { get; set; }

        /// <summary>
        /// Auto-create SSO bypass security policies for IPSec.
        /// </summary>
        /// <value>Auto-create SSO bypass security policies for IPSec.</value>
        [DataMember(Name = "ipsec", EmitDefaultValue = true)]
        public bool Ipsec { get; set; }

        /// <summary>
        /// Auto-create SSO bypass security policies for DHCP.
        /// </summary>
        /// <value>Auto-create SSO bypass security policies for DHCP.</value>
        [DataMember(Name = "dhcp", EmitDefaultValue = true)]
        public bool Dhcp { get; set; }

        /// <summary>
        /// Auto-create SSO bypass security policies for RIP.
        /// </summary>
        /// <value>Auto-create SSO bypass security policies for RIP.</value>
        [DataMember(Name = "rip", EmitDefaultValue = true)]
        public bool Rip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSsoBaseUserSsoBypassPolicy {\n");
            sb.Append("  Voip: ").Append(Voip).Append("\n");
            sb.Append("  Ospf: ").Append(Ospf).Append("\n");
            sb.Append("  Ipsec: ").Append(Ipsec).Append("\n");
            sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");
            sb.Append("  Rip: ").Append(Rip).Append("\n");
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
            return this.Equals(input as UserSsoBaseUserSsoBypassPolicy);
        }

        /// <summary>
        /// Returns true if UserSsoBaseUserSsoBypassPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSsoBaseUserSsoBypassPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSsoBaseUserSsoBypassPolicy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Voip == input.Voip ||
                    this.Voip.Equals(input.Voip)
                ) && 
                (
                    this.Ospf == input.Ospf ||
                    this.Ospf.Equals(input.Ospf)
                ) && 
                (
                    this.Ipsec == input.Ipsec ||
                    this.Ipsec.Equals(input.Ipsec)
                ) && 
                (
                    this.Dhcp == input.Dhcp ||
                    this.Dhcp.Equals(input.Dhcp)
                ) && 
                (
                    this.Rip == input.Rip ||
                    this.Rip.Equals(input.Rip)
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
                hashCode = (hashCode * 59) + this.Voip.GetHashCode();
                hashCode = (hashCode * 59) + this.Ospf.GetHashCode();
                hashCode = (hashCode * 59) + this.Ipsec.GetHashCode();
                hashCode = (hashCode * 59) + this.Dhcp.GetHashCode();
                hashCode = (hashCode * 59) + this.Rip.GetHashCode();
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