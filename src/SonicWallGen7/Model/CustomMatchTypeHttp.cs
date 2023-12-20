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
    /// CustomMatchTypeHttp
    /// </summary>
    [DataContract(Name = "custom_match_type_http")]
    public partial class CustomMatchTypeHttp : IEquatable<CustomMatchTypeHttp>, IValidatableObject
    {
        /// <summary>
        /// HTTP.
        /// </summary>
        /// <value>HTTP.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpEnum
        {
            /// <summary>
            /// Enum Client for value: client
            /// </summary>
            [EnumMember(Value = "client")]
            Client = 1,

            /// <summary>
            /// Enum Server for value: server
            /// </summary>
            [EnumMember(Value = "server")]
            Server = 2
        }


        /// <summary>
        /// HTTP.
        /// </summary>
        /// <value>HTTP.</value>
        [DataMember(Name = "http", EmitDefaultValue = false)]
        public HttpEnum? Http { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMatchTypeHttp" /> class.
        /// </summary>
        /// <param name="http">HTTP..</param>
        public CustomMatchTypeHttp(HttpEnum? http = default(HttpEnum?))
        {
            this.Http = http;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomMatchTypeHttp {\n");
            sb.Append("  Http: ").Append(Http).Append("\n");
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
            return this.Equals(input as CustomMatchTypeHttp);
        }

        /// <summary>
        /// Returns true if CustomMatchTypeHttp instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomMatchTypeHttp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomMatchTypeHttp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Http == input.Http ||
                    this.Http.Equals(input.Http)
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
                hashCode = (hashCode * 59) + this.Http.GetHashCode();
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
