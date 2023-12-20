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
    /// ShowStatusAccessRuleConnLimitSourceListInner
    /// </summary>
    [DataContract(Name = "show_status_access_rule_conn_limit_source_list_inner")]
    public partial class ShowStatusAccessRuleConnLimitSourceListInner : IEquatable<ShowStatusAccessRuleConnLimitSourceListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusAccessRuleConnLimitSourceListInner" /> class.
        /// </summary>
        /// <param name="sourceIpAddress">sourceIpAddress.</param>
        /// <param name="sourceCount">sourceCount.</param>
        public ShowStatusAccessRuleConnLimitSourceListInner(string sourceIpAddress = default(string), string sourceCount = default(string))
        {
            this.SourceIpAddress = sourceIpAddress;
            this.SourceCount = sourceCount;
        }

        /// <summary>
        /// Gets or Sets SourceIpAddress
        /// </summary>
        [DataMember(Name = "source_ip_address", EmitDefaultValue = false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// Gets or Sets SourceCount
        /// </summary>
        [DataMember(Name = "source_count", EmitDefaultValue = false)]
        public string SourceCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusAccessRuleConnLimitSourceListInner {\n");
            sb.Append("  SourceIpAddress: ").Append(SourceIpAddress).Append("\n");
            sb.Append("  SourceCount: ").Append(SourceCount).Append("\n");
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
            return this.Equals(input as ShowStatusAccessRuleConnLimitSourceListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusAccessRuleConnLimitSourceListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusAccessRuleConnLimitSourceListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusAccessRuleConnLimitSourceListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceIpAddress == input.SourceIpAddress ||
                    (this.SourceIpAddress != null &&
                    this.SourceIpAddress.Equals(input.SourceIpAddress))
                ) && 
                (
                    this.SourceCount == input.SourceCount ||
                    (this.SourceCount != null &&
                    this.SourceCount.Equals(input.SourceCount))
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
                if (this.SourceIpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SourceIpAddress.GetHashCode();
                }
                if (this.SourceCount != null)
                {
                    hashCode = (hashCode * 59) + this.SourceCount.GetHashCode();
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