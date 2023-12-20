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
    /// system detail schema.
    /// </summary>
    [DataContract(Name = "show_status_system_detail")]
    public partial class ShowStatusSystemDetail : IEquatable<ShowStatusSystemDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusSystemDetail" /> class.
        /// </summary>
        /// <param name="model">model.</param>
        /// <param name="productCode">productCode.</param>
        /// <param name="firewallName">firewallName.</param>
        /// <param name="guid">guid.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="authenticationCode">authenticationCode.</param>
        /// <param name="firmwareVersion">firmwareVersion.</param>
        /// <param name="safemodeVersion">safemodeVersion.</param>
        /// <param name="romVersion">romVersion.</param>
        /// <param name="systemTime">systemTime.</param>
        /// <param name="upTime">upTime.</param>
        /// <param name="primaryWan">primaryWan.</param>
        /// <param name="peakConnections">peakConnections.</param>
        /// <param name="currentConnections">currentConnections.</param>
        /// <param name="maxAllowedConnections">maxAllowedConnections.</param>
        /// <param name="maxConnections">maxConnections.</param>
        /// <param name="connectionUsage">connectionUsage.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="assignToken">assignToken.</param>
        /// <param name="registrationCode">registrationCode.</param>
        /// <param name="globalMode">globalMode.</param>
        /// <param name="restartRequired">restartRequired.</param>
        /// <param name="serviceRemainingMessage">serviceRemainingMessage.</param>
        public ShowStatusSystemDetail(string model = default(string), string productCode = default(string), string firewallName = default(string), string guid = default(string), string serialNumber = default(string), string authenticationCode = default(string), string firmwareVersion = default(string), string safemodeVersion = default(string), string romVersion = default(string), string systemTime = default(string), string upTime = default(string), string primaryWan = default(string), string peakConnections = default(string), string currentConnections = default(string), string maxAllowedConnections = default(string), string maxConnections = default(string), string connectionUsage = default(string), string lastModifiedBy = default(string), string assignToken = default(string), string registrationCode = default(string), string globalMode = default(string), string restartRequired = default(string), string serviceRemainingMessage = default(string))
        {
            this.Model = model;
            this.ProductCode = productCode;
            this.FirewallName = firewallName;
            this.Guid = guid;
            this.SerialNumber = serialNumber;
            this.AuthenticationCode = authenticationCode;
            this.FirmwareVersion = firmwareVersion;
            this.SafemodeVersion = safemodeVersion;
            this.RomVersion = romVersion;
            this.SystemTime = systemTime;
            this.UpTime = upTime;
            this.PrimaryWan = primaryWan;
            this.PeakConnections = peakConnections;
            this.CurrentConnections = currentConnections;
            this.MaxAllowedConnections = maxAllowedConnections;
            this.MaxConnections = maxConnections;
            this.ConnectionUsage = connectionUsage;
            this.LastModifiedBy = lastModifiedBy;
            this.AssignToken = assignToken;
            this.RegistrationCode = registrationCode;
            this.GlobalMode = globalMode;
            this.RestartRequired = restartRequired;
            this.ServiceRemainingMessage = serviceRemainingMessage;
        }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets FirewallName
        /// </summary>
        [DataMember(Name = "firewall_name", EmitDefaultValue = false)]
        public string FirewallName { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name = "guid", EmitDefaultValue = false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationCode
        /// </summary>
        [DataMember(Name = "authentication_code", EmitDefaultValue = false)]
        public string AuthenticationCode { get; set; }

        /// <summary>
        /// Gets or Sets FirmwareVersion
        /// </summary>
        [DataMember(Name = "firmware_version", EmitDefaultValue = false)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or Sets SafemodeVersion
        /// </summary>
        [DataMember(Name = "safemode_version", EmitDefaultValue = false)]
        public string SafemodeVersion { get; set; }

        /// <summary>
        /// Gets or Sets RomVersion
        /// </summary>
        [DataMember(Name = "rom_version", EmitDefaultValue = false)]
        public string RomVersion { get; set; }

        /// <summary>
        /// Gets or Sets SystemTime
        /// </summary>
        [DataMember(Name = "system_time", EmitDefaultValue = false)]
        public string SystemTime { get; set; }

        /// <summary>
        /// Gets or Sets UpTime
        /// </summary>
        [DataMember(Name = "up_time", EmitDefaultValue = false)]
        public string UpTime { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryWan
        /// </summary>
        [DataMember(Name = "primary_wan", EmitDefaultValue = false)]
        public string PrimaryWan { get; set; }

        /// <summary>
        /// Gets or Sets PeakConnections
        /// </summary>
        [DataMember(Name = "peak_connections", EmitDefaultValue = false)]
        public string PeakConnections { get; set; }

        /// <summary>
        /// Gets or Sets CurrentConnections
        /// </summary>
        [DataMember(Name = "current_connections", EmitDefaultValue = false)]
        public string CurrentConnections { get; set; }

        /// <summary>
        /// Gets or Sets MaxAllowedConnections
        /// </summary>
        [DataMember(Name = "max_allowed_connections", EmitDefaultValue = false)]
        public string MaxAllowedConnections { get; set; }

        /// <summary>
        /// Gets or Sets MaxConnections
        /// </summary>
        [DataMember(Name = "max_connections", EmitDefaultValue = false)]
        public string MaxConnections { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionUsage
        /// </summary>
        [DataMember(Name = "connection_usage", EmitDefaultValue = false)]
        public string ConnectionUsage { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name = "last_modified_by", EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets AssignToken
        /// </summary>
        [DataMember(Name = "assign_token", EmitDefaultValue = false)]
        public string AssignToken { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationCode
        /// </summary>
        [DataMember(Name = "registration_code", EmitDefaultValue = false)]
        public string RegistrationCode { get; set; }

        /// <summary>
        /// Gets or Sets GlobalMode
        /// </summary>
        [DataMember(Name = "global_mode", EmitDefaultValue = false)]
        public string GlobalMode { get; set; }

        /// <summary>
        /// Gets or Sets RestartRequired
        /// </summary>
        [DataMember(Name = "restart_required", EmitDefaultValue = false)]
        public string RestartRequired { get; set; }

        /// <summary>
        /// Gets or Sets ServiceRemainingMessage
        /// </summary>
        [DataMember(Name = "service_remaining_message", EmitDefaultValue = false)]
        public string ServiceRemainingMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusSystemDetail {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  FirewallName: ").Append(FirewallName).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  AuthenticationCode: ").Append(AuthenticationCode).Append("\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
            sb.Append("  SafemodeVersion: ").Append(SafemodeVersion).Append("\n");
            sb.Append("  RomVersion: ").Append(RomVersion).Append("\n");
            sb.Append("  SystemTime: ").Append(SystemTime).Append("\n");
            sb.Append("  UpTime: ").Append(UpTime).Append("\n");
            sb.Append("  PrimaryWan: ").Append(PrimaryWan).Append("\n");
            sb.Append("  PeakConnections: ").Append(PeakConnections).Append("\n");
            sb.Append("  CurrentConnections: ").Append(CurrentConnections).Append("\n");
            sb.Append("  MaxAllowedConnections: ").Append(MaxAllowedConnections).Append("\n");
            sb.Append("  MaxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("  ConnectionUsage: ").Append(ConnectionUsage).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  AssignToken: ").Append(AssignToken).Append("\n");
            sb.Append("  RegistrationCode: ").Append(RegistrationCode).Append("\n");
            sb.Append("  GlobalMode: ").Append(GlobalMode).Append("\n");
            sb.Append("  RestartRequired: ").Append(RestartRequired).Append("\n");
            sb.Append("  ServiceRemainingMessage: ").Append(ServiceRemainingMessage).Append("\n");
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
            return this.Equals(input as ShowStatusSystemDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusSystemDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusSystemDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusSystemDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.FirewallName == input.FirewallName ||
                    (this.FirewallName != null &&
                    this.FirewallName.Equals(input.FirewallName))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.AuthenticationCode == input.AuthenticationCode ||
                    (this.AuthenticationCode != null &&
                    this.AuthenticationCode.Equals(input.AuthenticationCode))
                ) && 
                (
                    this.FirmwareVersion == input.FirmwareVersion ||
                    (this.FirmwareVersion != null &&
                    this.FirmwareVersion.Equals(input.FirmwareVersion))
                ) && 
                (
                    this.SafemodeVersion == input.SafemodeVersion ||
                    (this.SafemodeVersion != null &&
                    this.SafemodeVersion.Equals(input.SafemodeVersion))
                ) && 
                (
                    this.RomVersion == input.RomVersion ||
                    (this.RomVersion != null &&
                    this.RomVersion.Equals(input.RomVersion))
                ) && 
                (
                    this.SystemTime == input.SystemTime ||
                    (this.SystemTime != null &&
                    this.SystemTime.Equals(input.SystemTime))
                ) && 
                (
                    this.UpTime == input.UpTime ||
                    (this.UpTime != null &&
                    this.UpTime.Equals(input.UpTime))
                ) && 
                (
                    this.PrimaryWan == input.PrimaryWan ||
                    (this.PrimaryWan != null &&
                    this.PrimaryWan.Equals(input.PrimaryWan))
                ) && 
                (
                    this.PeakConnections == input.PeakConnections ||
                    (this.PeakConnections != null &&
                    this.PeakConnections.Equals(input.PeakConnections))
                ) && 
                (
                    this.CurrentConnections == input.CurrentConnections ||
                    (this.CurrentConnections != null &&
                    this.CurrentConnections.Equals(input.CurrentConnections))
                ) && 
                (
                    this.MaxAllowedConnections == input.MaxAllowedConnections ||
                    (this.MaxAllowedConnections != null &&
                    this.MaxAllowedConnections.Equals(input.MaxAllowedConnections))
                ) && 
                (
                    this.MaxConnections == input.MaxConnections ||
                    (this.MaxConnections != null &&
                    this.MaxConnections.Equals(input.MaxConnections))
                ) && 
                (
                    this.ConnectionUsage == input.ConnectionUsage ||
                    (this.ConnectionUsage != null &&
                    this.ConnectionUsage.Equals(input.ConnectionUsage))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.AssignToken == input.AssignToken ||
                    (this.AssignToken != null &&
                    this.AssignToken.Equals(input.AssignToken))
                ) && 
                (
                    this.RegistrationCode == input.RegistrationCode ||
                    (this.RegistrationCode != null &&
                    this.RegistrationCode.Equals(input.RegistrationCode))
                ) && 
                (
                    this.GlobalMode == input.GlobalMode ||
                    (this.GlobalMode != null &&
                    this.GlobalMode.Equals(input.GlobalMode))
                ) && 
                (
                    this.RestartRequired == input.RestartRequired ||
                    (this.RestartRequired != null &&
                    this.RestartRequired.Equals(input.RestartRequired))
                ) && 
                (
                    this.ServiceRemainingMessage == input.ServiceRemainingMessage ||
                    (this.ServiceRemainingMessage != null &&
                    this.ServiceRemainingMessage.Equals(input.ServiceRemainingMessage))
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
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.FirewallName != null)
                {
                    hashCode = (hashCode * 59) + this.FirewallName.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }
                if (this.AuthenticationCode != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationCode.GetHashCode();
                }
                if (this.FirmwareVersion != null)
                {
                    hashCode = (hashCode * 59) + this.FirmwareVersion.GetHashCode();
                }
                if (this.SafemodeVersion != null)
                {
                    hashCode = (hashCode * 59) + this.SafemodeVersion.GetHashCode();
                }
                if (this.RomVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RomVersion.GetHashCode();
                }
                if (this.SystemTime != null)
                {
                    hashCode = (hashCode * 59) + this.SystemTime.GetHashCode();
                }
                if (this.UpTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpTime.GetHashCode();
                }
                if (this.PrimaryWan != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryWan.GetHashCode();
                }
                if (this.PeakConnections != null)
                {
                    hashCode = (hashCode * 59) + this.PeakConnections.GetHashCode();
                }
                if (this.CurrentConnections != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentConnections.GetHashCode();
                }
                if (this.MaxAllowedConnections != null)
                {
                    hashCode = (hashCode * 59) + this.MaxAllowedConnections.GetHashCode();
                }
                if (this.MaxConnections != null)
                {
                    hashCode = (hashCode * 59) + this.MaxConnections.GetHashCode();
                }
                if (this.ConnectionUsage != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionUsage.GetHashCode();
                }
                if (this.LastModifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedBy.GetHashCode();
                }
                if (this.AssignToken != null)
                {
                    hashCode = (hashCode * 59) + this.AssignToken.GetHashCode();
                }
                if (this.RegistrationCode != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationCode.GetHashCode();
                }
                if (this.GlobalMode != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalMode.GetHashCode();
                }
                if (this.RestartRequired != null)
                {
                    hashCode = (hashCode * 59) + this.RestartRequired.GetHashCode();
                }
                if (this.ServiceRemainingMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceRemainingMessage.GetHashCode();
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
