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
    /// MatchObjectArgumentInner
    /// </summary>
    [DataContract(Name = "match_object_argument_inner")]
    public partial class MatchObjectArgumentInner : IEquatable<MatchObjectArgumentInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchObjectArgumentInner" /> class.
        /// </summary>
        /// <param name="argument">argument.</param>
        public MatchObjectArgumentInner(string argument = default(string))
        {
            this.Argument = argument;
        }

        /// <summary>
        /// Gets or Sets Argument
        /// </summary>
        [DataMember(Name = "argument", EmitDefaultValue = false)]
        public string Argument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchObjectArgumentInner {\n");
            sb.Append("  Argument: ").Append(Argument).Append("\n");
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
            return this.Equals(input as MatchObjectArgumentInner);
        }

        /// <summary>
        /// Returns true if MatchObjectArgumentInner instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchObjectArgumentInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchObjectArgumentInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Argument == input.Argument ||
                    (this.Argument != null &&
                    this.Argument.Equals(input.Argument))
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
                if (this.Argument != null)
                {
                    hashCode = (hashCode * 59) + this.Argument.GetHashCode();
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
