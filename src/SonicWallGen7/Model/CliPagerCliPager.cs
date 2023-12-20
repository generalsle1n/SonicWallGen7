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
    /// Enable cli pager.
    /// </summary>
    [DataContract(Name = "cli_pager_cli_pager")]
    public partial class CliPagerCliPager : IEquatable<CliPagerCliPager>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CliPagerCliPager" /> class.
        /// </summary>
        /// <param name="varDefault">Default setting (changes take effect upon next login)..</param>
        public CliPagerCliPager(bool varDefault = default(bool))
        {
            this.VarDefault = varDefault;
        }

        /// <summary>
        /// Default setting (changes take effect upon next login).
        /// </summary>
        /// <value>Default setting (changes take effect upon next login).</value>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool VarDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CliPagerCliPager {\n");
            sb.Append("  VarDefault: ").Append(VarDefault).Append("\n");
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
            return this.Equals(input as CliPagerCliPager);
        }

        /// <summary>
        /// Returns true if CliPagerCliPager instances are equal
        /// </summary>
        /// <param name="input">Instance of CliPagerCliPager to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CliPagerCliPager input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarDefault == input.VarDefault ||
                    this.VarDefault.Equals(input.VarDefault)
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
                hashCode = (hashCode * 59) + this.VarDefault.GetHashCode();
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
