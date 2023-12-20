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
    /// Config the administrator settings.
    /// </summary>
    [DataContract(Name = "administration_password_administration_admin_password")]
    public partial class AdministrationPasswordAdministrationAdminPassword : IEquatable<AdministrationPasswordAdministrationAdminPassword>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationPasswordAdministrationAdminPassword" /> class.
        /// </summary>
        /// <param name="old">Enter the old password..</param>
        /// <param name="varNew">Enter the new password..</param>
        public AdministrationPasswordAdministrationAdminPassword(string old = default(string), string varNew = default(string))
        {
            this.Old = old;
            this.VarNew = varNew;
        }

        /// <summary>
        /// Enter the old password.
        /// </summary>
        /// <value>Enter the old password.</value>
        [DataMember(Name = "old", EmitDefaultValue = false)]
        public string Old { get; set; }

        /// <summary>
        /// Enter the new password.
        /// </summary>
        /// <value>Enter the new password.</value>
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public string VarNew { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdministrationPasswordAdministrationAdminPassword {\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
            sb.Append("  VarNew: ").Append(VarNew).Append("\n");
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
            return this.Equals(input as AdministrationPasswordAdministrationAdminPassword);
        }

        /// <summary>
        /// Returns true if AdministrationPasswordAdministrationAdminPassword instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministrationPasswordAdministrationAdminPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministrationPasswordAdministrationAdminPassword input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Old == input.Old ||
                    (this.Old != null &&
                    this.Old.Equals(input.Old))
                ) && 
                (
                    this.VarNew == input.VarNew ||
                    (this.VarNew != null &&
                    this.VarNew.Equals(input.VarNew))
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
                if (this.Old != null)
                {
                    hashCode = (hashCode * 59) + this.Old.GetHashCode();
                }
                if (this.VarNew != null)
                {
                    hashCode = (hashCode * 59) + this.VarNew.GetHashCode();
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
