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
    /// Configure Logging Types for Alert Message to Endpoint Devices via Capture Client Endpoint Security.
    /// </summary>
    [DataContract(Name = "endpoint_security_settings_endpoint_security_log")]
    public partial class EndpointSecuritySettingsEndpointSecurityLog : IEquatable<EndpointSecuritySettingsEndpointSecurityLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointSecuritySettingsEndpointSecurityLog" /> class.
        /// </summary>
        /// <param name="cfs">Enable Alert CFS Message to Endpoint Devices via Capture Client Endpoint Security..</param>
        /// <param name="ips">Enable Alert IPS Message to Endpoint Devices via Capture Client Endpoint Security..</param>
        /// <param name="appctrl">Enable Alert APP Control Message to Endpoint Devices via Capture Client Endpoint Security..</param>
        /// <param name="botnetGeoip">Enable Alert Botnet/Geo-IP Message to Endpoint Devices via Capture Client Endpoint Security..</param>
        /// <param name="gavGasAtp">Enable Alert GAV/GAS/ATP Message to Endpoint Devices via Capture Client Endpoint Security..</param>
        public EndpointSecuritySettingsEndpointSecurityLog(bool cfs = default(bool), bool ips = default(bool), bool appctrl = default(bool), bool botnetGeoip = default(bool), bool gavGasAtp = default(bool))
        {
            this.Cfs = cfs;
            this.Ips = ips;
            this.Appctrl = appctrl;
            this.BotnetGeoip = botnetGeoip;
            this.GavGasAtp = gavGasAtp;
        }

        /// <summary>
        /// Enable Alert CFS Message to Endpoint Devices via Capture Client Endpoint Security.
        /// </summary>
        /// <value>Enable Alert CFS Message to Endpoint Devices via Capture Client Endpoint Security.</value>
        [DataMember(Name = "cfs", EmitDefaultValue = true)]
        public bool Cfs { get; set; }

        /// <summary>
        /// Enable Alert IPS Message to Endpoint Devices via Capture Client Endpoint Security.
        /// </summary>
        /// <value>Enable Alert IPS Message to Endpoint Devices via Capture Client Endpoint Security.</value>
        [DataMember(Name = "ips", EmitDefaultValue = true)]
        public bool Ips { get; set; }

        /// <summary>
        /// Enable Alert APP Control Message to Endpoint Devices via Capture Client Endpoint Security.
        /// </summary>
        /// <value>Enable Alert APP Control Message to Endpoint Devices via Capture Client Endpoint Security.</value>
        [DataMember(Name = "appctrl", EmitDefaultValue = true)]
        public bool Appctrl { get; set; }

        /// <summary>
        /// Enable Alert Botnet/Geo-IP Message to Endpoint Devices via Capture Client Endpoint Security.
        /// </summary>
        /// <value>Enable Alert Botnet/Geo-IP Message to Endpoint Devices via Capture Client Endpoint Security.</value>
        [DataMember(Name = "botnet_geoip", EmitDefaultValue = true)]
        public bool BotnetGeoip { get; set; }

        /// <summary>
        /// Enable Alert GAV/GAS/ATP Message to Endpoint Devices via Capture Client Endpoint Security.
        /// </summary>
        /// <value>Enable Alert GAV/GAS/ATP Message to Endpoint Devices via Capture Client Endpoint Security.</value>
        [DataMember(Name = "gav_gas_atp", EmitDefaultValue = true)]
        public bool GavGasAtp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EndpointSecuritySettingsEndpointSecurityLog {\n");
            sb.Append("  Cfs: ").Append(Cfs).Append("\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
            sb.Append("  Appctrl: ").Append(Appctrl).Append("\n");
            sb.Append("  BotnetGeoip: ").Append(BotnetGeoip).Append("\n");
            sb.Append("  GavGasAtp: ").Append(GavGasAtp).Append("\n");
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
            return this.Equals(input as EndpointSecuritySettingsEndpointSecurityLog);
        }

        /// <summary>
        /// Returns true if EndpointSecuritySettingsEndpointSecurityLog instances are equal
        /// </summary>
        /// <param name="input">Instance of EndpointSecuritySettingsEndpointSecurityLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointSecuritySettingsEndpointSecurityLog input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cfs == input.Cfs ||
                    this.Cfs.Equals(input.Cfs)
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips.Equals(input.Ips)
                ) && 
                (
                    this.Appctrl == input.Appctrl ||
                    this.Appctrl.Equals(input.Appctrl)
                ) && 
                (
                    this.BotnetGeoip == input.BotnetGeoip ||
                    this.BotnetGeoip.Equals(input.BotnetGeoip)
                ) && 
                (
                    this.GavGasAtp == input.GavGasAtp ||
                    this.GavGasAtp.Equals(input.GavGasAtp)
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
                hashCode = (hashCode * 59) + this.Cfs.GetHashCode();
                hashCode = (hashCode * 59) + this.Ips.GetHashCode();
                hashCode = (hashCode * 59) + this.Appctrl.GetHashCode();
                hashCode = (hashCode * 59) + this.BotnetGeoip.GetHashCode();
                hashCode = (hashCode * 59) + this.GavGasAtp.GetHashCode();
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
