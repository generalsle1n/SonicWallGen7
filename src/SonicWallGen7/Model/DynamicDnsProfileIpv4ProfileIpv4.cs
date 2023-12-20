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
    /// IPv4 Dynamic DNS profile.
    /// </summary>
    [DataContract(Name = "dynamic_dns_profile_ipv4_profile_ipv4")]
    public partial class DynamicDnsProfileIpv4ProfileIpv4 : IEquatable<DynamicDnsProfileIpv4ProfileIpv4>, IValidatableObject
    {
        /// <summary>
        /// Select dynamic DNS provider.
        /// </summary>
        /// <value>Select dynamic DNS provider.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProviderEnum
        {
            /// <summary>
            /// Enum Dyn for value: dyn
            /// </summary>
            [EnumMember(Value = "dyn")]
            Dyn = 1,

            /// <summary>
            /// Enum Changeip for value: changeip
            /// </summary>
            [EnumMember(Value = "changeip")]
            Changeip = 2,

            /// <summary>
            /// Enum Noip for value: noip
            /// </summary>
            [EnumMember(Value = "noip")]
            Noip = 3
        }


        /// <summary>
        /// Select dynamic DNS provider.
        /// </summary>
        /// <value>Select dynamic DNS provider.</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public ProviderEnum? Provider { get; set; }
        /// <summary>
        /// Configure dynamic DNS service type.
        /// </summary>
        /// <value>Configure dynamic DNS service type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceTypeEnum
        {
            /// <summary>
            /// Enum Dynamic for value: dynamic
            /// </summary>
            [EnumMember(Value = "dynamic")]
            Dynamic = 1,

            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom = 2,

            /// <summary>
            /// Enum Static for value: static
            /// </summary>
            [EnumMember(Value = "static")]
            Static = 3
        }


        /// <summary>
        /// Configure dynamic DNS service type.
        /// </summary>
        /// <value>Configure dynamic DNS service type.</value>
        [DataMember(Name = "service_type", EmitDefaultValue = false)]
        public ServiceTypeEnum? ServiceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDnsProfileIpv4ProfileIpv4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicDnsProfileIpv4ProfileIpv4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDnsProfileIpv4ProfileIpv4" /> class.
        /// </summary>
        /// <param name="profileName">Edit a dynamic DNS profile name. (required).</param>
        /// <param name="enable">Enable dynamic DNS profile..</param>
        /// <param name="useOnline">Enable use online settings..</param>
        /// <param name="provider">Select dynamic DNS provider..</param>
        /// <param name="userName">Set dynamic DNS user name..</param>
        /// <param name="password">Set dynamic DNS password..</param>
        /// <param name="domain">Set dynamic DNS domain..</param>
        /// <param name="boundTo">boundTo.</param>
        /// <param name="onlineSettings">onlineSettings.</param>
        /// <param name="offlineSettings">offlineSettings.</param>
        /// <param name="serviceType">Configure dynamic DNS service type..</param>
        public DynamicDnsProfileIpv4ProfileIpv4(string profileName = default(string), bool enable = default(bool), bool useOnline = default(bool), ProviderEnum? provider = default(ProviderEnum?), string userName = default(string), string password = default(string), string domain = default(string), DynamicDnsProfileIpv4ProfileIpv4BoundTo boundTo = default(DynamicDnsProfileIpv4ProfileIpv4BoundTo), DynamicDnsProfileIpv4ProfileIpv4OnlineSettings onlineSettings = default(DynamicDnsProfileIpv4ProfileIpv4OnlineSettings), DynamicDnsProfileIpv4ProfileIpv4OfflineSettings offlineSettings = default(DynamicDnsProfileIpv4ProfileIpv4OfflineSettings), ServiceTypeEnum? serviceType = default(ServiceTypeEnum?))
        {
            // to ensure "profileName" is required (not null)
            if (profileName == null)
            {
                throw new ArgumentNullException("profileName is a required property for DynamicDnsProfileIpv4ProfileIpv4 and cannot be null");
            }
            this.ProfileName = profileName;
            this.Enable = enable;
            this.UseOnline = useOnline;
            this.Provider = provider;
            this.UserName = userName;
            this.Password = password;
            this.Domain = domain;
            this.BoundTo = boundTo;
            this.OnlineSettings = onlineSettings;
            this.OfflineSettings = offlineSettings;
            this.ServiceType = serviceType;
        }

        /// <summary>
        /// Edit a dynamic DNS profile name.
        /// </summary>
        /// <value>Edit a dynamic DNS profile name.</value>
        [DataMember(Name = "profile_name", IsRequired = true, EmitDefaultValue = true)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Enable dynamic DNS profile.
        /// </summary>
        /// <value>Enable dynamic DNS profile.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Enable use online settings.
        /// </summary>
        /// <value>Enable use online settings.</value>
        [DataMember(Name = "use_online", EmitDefaultValue = true)]
        public bool UseOnline { get; set; }

        /// <summary>
        /// Set dynamic DNS user name.
        /// </summary>
        /// <value>Set dynamic DNS user name.</value>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Set dynamic DNS password.
        /// </summary>
        /// <value>Set dynamic DNS password.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Set dynamic DNS domain.
        /// </summary>
        /// <value>Set dynamic DNS domain.</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets BoundTo
        /// </summary>
        [DataMember(Name = "bound_to", EmitDefaultValue = false)]
        public DynamicDnsProfileIpv4ProfileIpv4BoundTo BoundTo { get; set; }

        /// <summary>
        /// Gets or Sets OnlineSettings
        /// </summary>
        [DataMember(Name = "online_settings", EmitDefaultValue = false)]
        public DynamicDnsProfileIpv4ProfileIpv4OnlineSettings OnlineSettings { get; set; }

        /// <summary>
        /// Gets or Sets OfflineSettings
        /// </summary>
        [DataMember(Name = "offline_settings", EmitDefaultValue = false)]
        public DynamicDnsProfileIpv4ProfileIpv4OfflineSettings OfflineSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicDnsProfileIpv4ProfileIpv4 {\n");
            sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  UseOnline: ").Append(UseOnline).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  BoundTo: ").Append(BoundTo).Append("\n");
            sb.Append("  OnlineSettings: ").Append(OnlineSettings).Append("\n");
            sb.Append("  OfflineSettings: ").Append(OfflineSettings).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
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
            return this.Equals(input as DynamicDnsProfileIpv4ProfileIpv4);
        }

        /// <summary>
        /// Returns true if DynamicDnsProfileIpv4ProfileIpv4 instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicDnsProfileIpv4ProfileIpv4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicDnsProfileIpv4ProfileIpv4 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProfileName == input.ProfileName ||
                    (this.ProfileName != null &&
                    this.ProfileName.Equals(input.ProfileName))
                ) && 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.UseOnline == input.UseOnline ||
                    this.UseOnline.Equals(input.UseOnline)
                ) && 
                (
                    this.Provider == input.Provider ||
                    this.Provider.Equals(input.Provider)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.BoundTo == input.BoundTo ||
                    (this.BoundTo != null &&
                    this.BoundTo.Equals(input.BoundTo))
                ) && 
                (
                    this.OnlineSettings == input.OnlineSettings ||
                    (this.OnlineSettings != null &&
                    this.OnlineSettings.Equals(input.OnlineSettings))
                ) && 
                (
                    this.OfflineSettings == input.OfflineSettings ||
                    (this.OfflineSettings != null &&
                    this.OfflineSettings.Equals(input.OfflineSettings))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
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
                if (this.ProfileName != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.UseOnline.GetHashCode();
                hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.BoundTo != null)
                {
                    hashCode = (hashCode * 59) + this.BoundTo.GetHashCode();
                }
                if (this.OnlineSettings != null)
                {
                    hashCode = (hashCode * 59) + this.OnlineSettings.GetHashCode();
                }
                if (this.OfflineSettings != null)
                {
                    hashCode = (hashCode * 59) + this.OfflineSettings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ServiceType.GetHashCode();
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