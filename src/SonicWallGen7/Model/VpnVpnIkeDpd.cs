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
    /// Enter IKE dead peer detection mode.
    /// </summary>
    [DataContract(Name = "vpn_vpn_ike_dpd")]
    public partial class VpnVpnIkeDpd : IEquatable<VpnVpnIkeDpd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnVpnIkeDpd" /> class.
        /// </summary>
        /// <param name="enable">Enable IKE dead peer detection..</param>
        /// <param name="interval">Dead peer detection interval (in seconds)..</param>
        /// <param name="trigger">Configure failure trigger level in number of heartbeats..</param>
        /// <param name="idleDpd">Enable dead peer detection for idle VPN sessions..</param>
        /// <param name="idleDpdInterval">Dead peer detection interval for idle VPN sessions in seconds..</param>
        public VpnVpnIkeDpd(bool enable = default(bool), decimal interval = default(decimal), decimal trigger = default(decimal), bool idleDpd = default(bool), decimal idleDpdInterval = default(decimal))
        {
            this.Enable = enable;
            this.Interval = interval;
            this.Trigger = trigger;
            this.IdleDpd = idleDpd;
            this.IdleDpdInterval = idleDpdInterval;
        }

        /// <summary>
        /// Enable IKE dead peer detection.
        /// </summary>
        /// <value>Enable IKE dead peer detection.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Dead peer detection interval (in seconds).
        /// </summary>
        /// <value>Dead peer detection interval (in seconds).</value>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public decimal Interval { get; set; }

        /// <summary>
        /// Configure failure trigger level in number of heartbeats.
        /// </summary>
        /// <value>Configure failure trigger level in number of heartbeats.</value>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public decimal Trigger { get; set; }

        /// <summary>
        /// Enable dead peer detection for idle VPN sessions.
        /// </summary>
        /// <value>Enable dead peer detection for idle VPN sessions.</value>
        [DataMember(Name = "idle_dpd", EmitDefaultValue = true)]
        public bool IdleDpd { get; set; }

        /// <summary>
        /// Dead peer detection interval for idle VPN sessions in seconds.
        /// </summary>
        /// <value>Dead peer detection interval for idle VPN sessions in seconds.</value>
        [DataMember(Name = "idle_dpd_interval", EmitDefaultValue = false)]
        public decimal IdleDpdInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VpnVpnIkeDpd {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  IdleDpd: ").Append(IdleDpd).Append("\n");
            sb.Append("  IdleDpdInterval: ").Append(IdleDpdInterval).Append("\n");
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
            return this.Equals(input as VpnVpnIkeDpd);
        }

        /// <summary>
        /// Returns true if VpnVpnIkeDpd instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnVpnIkeDpd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnVpnIkeDpd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    this.Trigger.Equals(input.Trigger)
                ) && 
                (
                    this.IdleDpd == input.IdleDpd ||
                    this.IdleDpd.Equals(input.IdleDpd)
                ) && 
                (
                    this.IdleDpdInterval == input.IdleDpdInterval ||
                    this.IdleDpdInterval.Equals(input.IdleDpdInterval)
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
                hashCode = (hashCode * 59) + this.IdleDpd.GetHashCode();
                hashCode = (hashCode * 59) + this.IdleDpdInterval.GetHashCode();
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
