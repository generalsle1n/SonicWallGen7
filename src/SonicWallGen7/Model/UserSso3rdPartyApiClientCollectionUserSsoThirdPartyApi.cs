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
    /// Enter 3rd Party API configuation mode.
    /// </summary>
    [DataContract(Name = "user_sso_3rd_party_api_client_collection_user_sso_third_party_api")]
    public partial class UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi : IEquatable<UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi" /> class.
        /// </summary>
        /// <param name="varClient">Configure an SSO third party API client..</param>
        public UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi(List<UserSso3rdPartyApiClient> varClient = default(List<UserSso3rdPartyApiClient>))
        {
            this.VarClient = varClient;
        }

        /// <summary>
        /// Configure an SSO third party API client.
        /// </summary>
        /// <value>Configure an SSO third party API client.</value>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public List<UserSso3rdPartyApiClient> VarClient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi {\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
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
            return this.Equals(input as UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi);
        }

        /// <summary>
        /// Returns true if UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSso3rdPartyApiClientCollectionUserSsoThirdPartyApi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarClient == input.VarClient ||
                    this.VarClient != null &&
                    input.VarClient != null &&
                    this.VarClient.SequenceEqual(input.VarClient)
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
                if (this.VarClient != null)
                {
                    hashCode = (hashCode * 59) + this.VarClient.GetHashCode();
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
