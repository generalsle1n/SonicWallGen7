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
    /// SNMP users configuration.
    /// </summary>
    [DataContract(Name = "snmp_user")]
    public partial class SnmpUser : IEquatable<SnmpUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SnmpUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpUser" /> class.
        /// </summary>
        /// <param name="name">Set an SNMP user name. (required).</param>
        /// <param name="securityLevel">securityLevel.</param>
        /// <param name="authentication">authentication.</param>
        /// <param name="encryption">encryption.</param>
        /// <param name="group">Assign an SNMP group..</param>
        public SnmpUser(string name = default(string), SnmpUserSecurityLevel securityLevel = default(SnmpUserSecurityLevel), SnmpUserAuthentication authentication = default(SnmpUserAuthentication), SnmpUserEncryption encryption = default(SnmpUserEncryption), string group = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SnmpUser and cannot be null");
            }
            this.Name = name;
            this.SecurityLevel = securityLevel;
            this.Authentication = authentication;
            this.Encryption = encryption;
            this.Group = group;
        }

        /// <summary>
        /// Set an SNMP user name.
        /// </summary>
        /// <value>Set an SNMP user name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SecurityLevel
        /// </summary>
        [DataMember(Name = "security_level", EmitDefaultValue = false)]
        public SnmpUserSecurityLevel SecurityLevel { get; set; }

        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", EmitDefaultValue = false)]
        public SnmpUserAuthentication Authentication { get; set; }

        /// <summary>
        /// Gets or Sets Encryption
        /// </summary>
        [DataMember(Name = "encryption", EmitDefaultValue = false)]
        public SnmpUserEncryption Encryption { get; set; }

        /// <summary>
        /// Assign an SNMP group.
        /// </summary>
        /// <value>Assign an SNMP group.</value>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SnmpUser {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(input as SnmpUser);
        }

        /// <summary>
        /// Returns true if SnmpUser instances are equal
        /// </summary>
        /// <param name="input">Instance of SnmpUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnmpUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SecurityLevel == input.SecurityLevel ||
                    (this.SecurityLevel != null &&
                    this.SecurityLevel.Equals(input.SecurityLevel))
                ) && 
                (
                    this.Authentication == input.Authentication ||
                    (this.Authentication != null &&
                    this.Authentication.Equals(input.Authentication))
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    (this.Encryption != null &&
                    this.Encryption.Equals(input.Encryption))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SecurityLevel != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityLevel.GetHashCode();
                }
                if (this.Authentication != null)
                {
                    hashCode = (hashCode * 59) + this.Authentication.GetHashCode();
                }
                if (this.Encryption != null)
                {
                    hashCode = (hashCode * 59) + this.Encryption.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
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