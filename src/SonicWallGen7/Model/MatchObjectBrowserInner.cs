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
    /// MatchObjectBrowserInner
    /// </summary>
    [DataContract(Name = "match_object_browser_inner")]
    public partial class MatchObjectBrowserInner : IEquatable<MatchObjectBrowserInner>, IValidatableObject
    {
        /// <summary>
        /// Add match object FTP browser.
        /// </summary>
        /// <value>Add match object FTP browser.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BrowserEnum
        {
            /// <summary>
            /// Enum Netscape for value: netscape
            /// </summary>
            [EnumMember(Value = "netscape")]
            Netscape = 1,

            /// <summary>
            /// Enum Msie for value: msie
            /// </summary>
            [EnumMember(Value = "msie")]
            Msie = 2,

            /// <summary>
            /// Enum Firefox for value: firefox
            /// </summary>
            [EnumMember(Value = "firefox")]
            Firefox = 3,

            /// <summary>
            /// Enum Safari for value: safari
            /// </summary>
            [EnumMember(Value = "safari")]
            Safari = 4,

            /// <summary>
            /// Enum Chrome for value: chrome
            /// </summary>
            [EnumMember(Value = "chrome")]
            Chrome = 5
        }


        /// <summary>
        /// Add match object FTP browser.
        /// </summary>
        /// <value>Add match object FTP browser.</value>
        [DataMember(Name = "browser", EmitDefaultValue = false)]
        public BrowserEnum? Browser { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchObjectBrowserInner" /> class.
        /// </summary>
        /// <param name="browser">Add match object FTP browser..</param>
        public MatchObjectBrowserInner(BrowserEnum? browser = default(BrowserEnum?))
        {
            this.Browser = browser;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchObjectBrowserInner {\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
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
            return this.Equals(input as MatchObjectBrowserInner);
        }

        /// <summary>
        /// Returns true if MatchObjectBrowserInner instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchObjectBrowserInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchObjectBrowserInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Browser == input.Browser ||
                    this.Browser.Equals(input.Browser)
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
                hashCode = (hashCode * 59) + this.Browser.GetHashCode();
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
