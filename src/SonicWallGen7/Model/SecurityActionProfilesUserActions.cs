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
    /// Enter security policy user actions configuration mode.
    /// </summary>
    [DataContract(Name = "security_action_profiles_user_actions")]
    public partial class SecurityActionProfilesUserActions : IEquatable<SecurityActionProfilesUserActions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityActionProfilesUserActions" /> class.
        /// </summary>
        /// <param name="blockPage">blockPage.</param>
        /// <param name="blockDetails">Enable include policy block details.</param>
        /// <param name="bypassSso">Enable bypassing SSO for connections matching the policy.</param>
        public SecurityActionProfilesUserActions(SecurityActionProfilesUserActionsBlockPage blockPage = default(SecurityActionProfilesUserActionsBlockPage), bool blockDetails = default(bool), bool bypassSso = default(bool))
        {
            this.BlockPage = blockPage;
            this.BlockDetails = blockDetails;
            this.BypassSso = bypassSso;
        }

        /// <summary>
        /// Gets or Sets BlockPage
        /// </summary>
        [DataMember(Name = "block_page", EmitDefaultValue = false)]
        public SecurityActionProfilesUserActionsBlockPage BlockPage { get; set; }

        /// <summary>
        /// Enable include policy block details
        /// </summary>
        /// <value>Enable include policy block details</value>
        [DataMember(Name = "block_details", EmitDefaultValue = true)]
        public bool BlockDetails { get; set; }

        /// <summary>
        /// Enable bypassing SSO for connections matching the policy
        /// </summary>
        /// <value>Enable bypassing SSO for connections matching the policy</value>
        [DataMember(Name = "bypass_sso", EmitDefaultValue = true)]
        public bool BypassSso { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityActionProfilesUserActions {\n");
            sb.Append("  BlockPage: ").Append(BlockPage).Append("\n");
            sb.Append("  BlockDetails: ").Append(BlockDetails).Append("\n");
            sb.Append("  BypassSso: ").Append(BypassSso).Append("\n");
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
            return this.Equals(input as SecurityActionProfilesUserActions);
        }

        /// <summary>
        /// Returns true if SecurityActionProfilesUserActions instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityActionProfilesUserActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityActionProfilesUserActions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlockPage == input.BlockPage ||
                    (this.BlockPage != null &&
                    this.BlockPage.Equals(input.BlockPage))
                ) && 
                (
                    this.BlockDetails == input.BlockDetails ||
                    this.BlockDetails.Equals(input.BlockDetails)
                ) && 
                (
                    this.BypassSso == input.BypassSso ||
                    this.BypassSso.Equals(input.BypassSso)
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
                if (this.BlockPage != null)
                {
                    hashCode = (hashCode * 59) + this.BlockPage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BlockDetails.GetHashCode();
                hashCode = (hashCode * 59) + this.BypassSso.GetHashCode();
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
