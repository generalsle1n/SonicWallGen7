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
    /// SNMP access configuration.
    /// </summary>
    [DataContract(Name = "snmp_access")]
    public partial class SnmpAccess : IEquatable<SnmpAccess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpAccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SnmpAccess() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpAccess" /> class.
        /// </summary>
        /// <param name="name">Set an SNMP access object name. (required).</param>
        /// <param name="readView">Set the SNMP read view..</param>
        /// <param name="masterGroup">Assign a master SNMP3 master group..</param>
        /// <param name="securityLevel">securityLevel.</param>
        public SnmpAccess(string name = default(string), string readView = default(string), string masterGroup = default(string), SnmpAccessSecurityLevel securityLevel = default(SnmpAccessSecurityLevel))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SnmpAccess and cannot be null");
            }
            this.Name = name;
            this.ReadView = readView;
            this.MasterGroup = masterGroup;
            this.SecurityLevel = securityLevel;
        }

        /// <summary>
        /// Set an SNMP access object name.
        /// </summary>
        /// <value>Set an SNMP access object name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Set the SNMP read view.
        /// </summary>
        /// <value>Set the SNMP read view.</value>
        [DataMember(Name = "read_view", EmitDefaultValue = false)]
        public string ReadView { get; set; }

        /// <summary>
        /// Assign a master SNMP3 master group.
        /// </summary>
        /// <value>Assign a master SNMP3 master group.</value>
        [DataMember(Name = "master_group", EmitDefaultValue = false)]
        public string MasterGroup { get; set; }

        /// <summary>
        /// Gets or Sets SecurityLevel
        /// </summary>
        [DataMember(Name = "security_level", EmitDefaultValue = false)]
        public SnmpAccessSecurityLevel SecurityLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SnmpAccess {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReadView: ").Append(ReadView).Append("\n");
            sb.Append("  MasterGroup: ").Append(MasterGroup).Append("\n");
            sb.Append("  SecurityLevel: ").Append(SecurityLevel).Append("\n");
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
            return this.Equals(input as SnmpAccess);
        }

        /// <summary>
        /// Returns true if SnmpAccess instances are equal
        /// </summary>
        /// <param name="input">Instance of SnmpAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnmpAccess input)
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
                    this.ReadView == input.ReadView ||
                    (this.ReadView != null &&
                    this.ReadView.Equals(input.ReadView))
                ) && 
                (
                    this.MasterGroup == input.MasterGroup ||
                    (this.MasterGroup != null &&
                    this.MasterGroup.Equals(input.MasterGroup))
                ) && 
                (
                    this.SecurityLevel == input.SecurityLevel ||
                    (this.SecurityLevel != null &&
                    this.SecurityLevel.Equals(input.SecurityLevel))
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
                if (this.ReadView != null)
                {
                    hashCode = (hashCode * 59) + this.ReadView.GetHashCode();
                }
                if (this.MasterGroup != null)
                {
                    hashCode = (hashCode * 59) + this.MasterGroup.GetHashCode();
                }
                if (this.SecurityLevel != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityLevel.GetHashCode();
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