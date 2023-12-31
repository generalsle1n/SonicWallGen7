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
    /// Configure uri list of profile object.
    /// </summary>
    [DataContract(Name = "content_filter_profile_uri_list")]
    public partial class ContentFilterProfileUriList : IEquatable<ContentFilterProfileUriList>, IValidatableObject
    {
        /// <summary>
        /// Set uri list search order.
        /// </summary>
        /// <value>Set uri list search order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchOrderEnum
        {
            /// <summary>
            /// Enum AllowedFirst for value: allowed-first
            /// </summary>
            [EnumMember(Value = "allowed-first")]
            AllowedFirst = 1,

            /// <summary>
            /// Enum ForbiddenFirst for value: forbidden-first
            /// </summary>
            [EnumMember(Value = "forbidden-first")]
            ForbiddenFirst = 2
        }


        /// <summary>
        /// Set uri list search order.
        /// </summary>
        /// <value>Set uri list search order.</value>
        [DataMember(Name = "search_order", EmitDefaultValue = false)]
        public SearchOrderEnum? SearchOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterProfileUriList" /> class.
        /// </summary>
        /// <param name="allowed">Set allowed uri list..</param>
        /// <param name="forbidden">Set forbidden uri list..</param>
        /// <param name="searchOrder">Set uri list search order..</param>
        /// <param name="forbiddenOperation">Set operation of forbidden uri list..</param>
        public ContentFilterProfileUriList(List<ContentFilterProfileUriListAllowedInner> allowed = default(List<ContentFilterProfileUriListAllowedInner>), List<ContentFilterProfileUriListAllowedInner> forbidden = default(List<ContentFilterProfileUriListAllowedInner>), SearchOrderEnum? searchOrder = default(SearchOrderEnum?), string forbiddenOperation = default(string))
        {
            this.Allowed = allowed;
            this.Forbidden = forbidden;
            this.SearchOrder = searchOrder;
            this.ForbiddenOperation = forbiddenOperation;
        }

        /// <summary>
        /// Set allowed uri list.
        /// </summary>
        /// <value>Set allowed uri list.</value>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public List<ContentFilterProfileUriListAllowedInner> Allowed { get; set; }

        /// <summary>
        /// Set forbidden uri list.
        /// </summary>
        /// <value>Set forbidden uri list.</value>
        [DataMember(Name = "forbidden", EmitDefaultValue = false)]
        public List<ContentFilterProfileUriListAllowedInner> Forbidden { get; set; }

        /// <summary>
        /// Set operation of forbidden uri list.
        /// </summary>
        /// <value>Set operation of forbidden uri list.</value>
        [DataMember(Name = "forbidden_operation", EmitDefaultValue = false)]
        public string ForbiddenOperation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentFilterProfileUriList {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Forbidden: ").Append(Forbidden).Append("\n");
            sb.Append("  SearchOrder: ").Append(SearchOrder).Append("\n");
            sb.Append("  ForbiddenOperation: ").Append(ForbiddenOperation).Append("\n");
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
            return this.Equals(input as ContentFilterProfileUriList);
        }

        /// <summary>
        /// Returns true if ContentFilterProfileUriList instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentFilterProfileUriList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentFilterProfileUriList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allowed == input.Allowed ||
                    this.Allowed != null &&
                    input.Allowed != null &&
                    this.Allowed.SequenceEqual(input.Allowed)
                ) && 
                (
                    this.Forbidden == input.Forbidden ||
                    this.Forbidden != null &&
                    input.Forbidden != null &&
                    this.Forbidden.SequenceEqual(input.Forbidden)
                ) && 
                (
                    this.SearchOrder == input.SearchOrder ||
                    this.SearchOrder.Equals(input.SearchOrder)
                ) && 
                (
                    this.ForbiddenOperation == input.ForbiddenOperation ||
                    (this.ForbiddenOperation != null &&
                    this.ForbiddenOperation.Equals(input.ForbiddenOperation))
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
                if (this.Allowed != null)
                {
                    hashCode = (hashCode * 59) + this.Allowed.GetHashCode();
                }
                if (this.Forbidden != null)
                {
                    hashCode = (hashCode * 59) + this.Forbidden.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SearchOrder.GetHashCode();
                if (this.ForbiddenOperation != null)
                {
                    hashCode = (hashCode * 59) + this.ForbiddenOperation.GetHashCode();
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
