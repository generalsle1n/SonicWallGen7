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
    /// Enable the single-sign-on mechanism.
    /// </summary>
    [DataContract(Name = "user_auth_methods_user_auth_partition_inner_sso_method")]
    public partial class UserAuthMethodsUserAuthPartitionInnerSsoMethod : IEquatable<UserAuthMethodsUserAuthPartitionInnerSsoMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthMethodsUserAuthPartitionInnerSsoMethod" /> class.
        /// </summary>
        /// <param name="ssoAgent">Enable SSO agent authentication..</param>
        /// <param name="terminalServicesAgent">Enable terminal services agent authentication..</param>
        /// <param name="browserNtlm">browserNtlm.</param>
        /// <param name="radiusAccounting">Enable RADIUS accounting authentication..</param>
        /// <param name="thirdPartyApi">Enable third party api authentication..</param>
        /// <param name="captureClient">Enable capture client authentication..</param>
        public UserAuthMethodsUserAuthPartitionInnerSsoMethod(bool ssoAgent = default(bool), bool terminalServicesAgent = default(bool), UserAuthMethodsUserAuthPartitionInnerSsoMethodBrowserNtlm browserNtlm = default(UserAuthMethodsUserAuthPartitionInnerSsoMethodBrowserNtlm), bool radiusAccounting = default(bool), bool thirdPartyApi = default(bool), bool captureClient = default(bool))
        {
            this.SsoAgent = ssoAgent;
            this.TerminalServicesAgent = terminalServicesAgent;
            this.BrowserNtlm = browserNtlm;
            this.RadiusAccounting = radiusAccounting;
            this.ThirdPartyApi = thirdPartyApi;
            this.CaptureClient = captureClient;
        }

        /// <summary>
        /// Enable SSO agent authentication.
        /// </summary>
        /// <value>Enable SSO agent authentication.</value>
        [DataMember(Name = "sso_agent", EmitDefaultValue = true)]
        public bool SsoAgent { get; set; }

        /// <summary>
        /// Enable terminal services agent authentication.
        /// </summary>
        /// <value>Enable terminal services agent authentication.</value>
        [DataMember(Name = "terminal_services_agent", EmitDefaultValue = true)]
        public bool TerminalServicesAgent { get; set; }

        /// <summary>
        /// Gets or Sets BrowserNtlm
        /// </summary>
        [DataMember(Name = "browser_ntlm", EmitDefaultValue = false)]
        public UserAuthMethodsUserAuthPartitionInnerSsoMethodBrowserNtlm BrowserNtlm { get; set; }

        /// <summary>
        /// Enable RADIUS accounting authentication.
        /// </summary>
        /// <value>Enable RADIUS accounting authentication.</value>
        [DataMember(Name = "radius_accounting", EmitDefaultValue = true)]
        public bool RadiusAccounting { get; set; }

        /// <summary>
        /// Enable third party api authentication.
        /// </summary>
        /// <value>Enable third party api authentication.</value>
        [DataMember(Name = "third_party_api", EmitDefaultValue = true)]
        public bool ThirdPartyApi { get; set; }

        /// <summary>
        /// Enable capture client authentication.
        /// </summary>
        /// <value>Enable capture client authentication.</value>
        [DataMember(Name = "capture_client", EmitDefaultValue = true)]
        public bool CaptureClient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAuthMethodsUserAuthPartitionInnerSsoMethod {\n");
            sb.Append("  SsoAgent: ").Append(SsoAgent).Append("\n");
            sb.Append("  TerminalServicesAgent: ").Append(TerminalServicesAgent).Append("\n");
            sb.Append("  BrowserNtlm: ").Append(BrowserNtlm).Append("\n");
            sb.Append("  RadiusAccounting: ").Append(RadiusAccounting).Append("\n");
            sb.Append("  ThirdPartyApi: ").Append(ThirdPartyApi).Append("\n");
            sb.Append("  CaptureClient: ").Append(CaptureClient).Append("\n");
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
            return this.Equals(input as UserAuthMethodsUserAuthPartitionInnerSsoMethod);
        }

        /// <summary>
        /// Returns true if UserAuthMethodsUserAuthPartitionInnerSsoMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAuthMethodsUserAuthPartitionInnerSsoMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthMethodsUserAuthPartitionInnerSsoMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SsoAgent == input.SsoAgent ||
                    this.SsoAgent.Equals(input.SsoAgent)
                ) && 
                (
                    this.TerminalServicesAgent == input.TerminalServicesAgent ||
                    this.TerminalServicesAgent.Equals(input.TerminalServicesAgent)
                ) && 
                (
                    this.BrowserNtlm == input.BrowserNtlm ||
                    (this.BrowserNtlm != null &&
                    this.BrowserNtlm.Equals(input.BrowserNtlm))
                ) && 
                (
                    this.RadiusAccounting == input.RadiusAccounting ||
                    this.RadiusAccounting.Equals(input.RadiusAccounting)
                ) && 
                (
                    this.ThirdPartyApi == input.ThirdPartyApi ||
                    this.ThirdPartyApi.Equals(input.ThirdPartyApi)
                ) && 
                (
                    this.CaptureClient == input.CaptureClient ||
                    this.CaptureClient.Equals(input.CaptureClient)
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
                hashCode = (hashCode * 59) + this.SsoAgent.GetHashCode();
                hashCode = (hashCode * 59) + this.TerminalServicesAgent.GetHashCode();
                if (this.BrowserNtlm != null)
                {
                    hashCode = (hashCode * 59) + this.BrowserNtlm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RadiusAccounting.GetHashCode();
                hashCode = (hashCode * 59) + this.ThirdPartyApi.GetHashCode();
                hashCode = (hashCode * 59) + this.CaptureClient.GetHashCode();
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
