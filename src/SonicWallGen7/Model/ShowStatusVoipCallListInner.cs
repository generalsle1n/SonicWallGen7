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
    /// ShowStatusVoipCallListInner
    /// </summary>
    [DataContract(Name = "show_status_voip_call_list_inner")]
    public partial class ShowStatusVoipCallListInner : IEquatable<ShowStatusVoipCallListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusVoipCallListInner" /> class.
        /// </summary>
        /// <param name="callerIp">callerIp.</param>
        /// <param name="callerId">callerId.</param>
        /// <param name="calledIp">calledIp.</param>
        /// <param name="calledId">calledId.</param>
        /// <param name="protocol">protocol.</param>
        /// <param name="bandwith">bandwith.</param>
        /// <param name="timeStarted">timeStarted.</param>
        public ShowStatusVoipCallListInner(string callerIp = default(string), string callerId = default(string), string calledIp = default(string), string calledId = default(string), string protocol = default(string), string bandwith = default(string), string timeStarted = default(string))
        {
            this.CallerIp = callerIp;
            this.CallerId = callerId;
            this.CalledIp = calledIp;
            this.CalledId = calledId;
            this.Protocol = protocol;
            this.Bandwith = bandwith;
            this.TimeStarted = timeStarted;
        }

        /// <summary>
        /// Gets or Sets CallerIp
        /// </summary>
        [DataMember(Name = "caller_ip", EmitDefaultValue = false)]
        public string CallerIp { get; set; }

        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name = "caller_id", EmitDefaultValue = false)]
        public string CallerId { get; set; }

        /// <summary>
        /// Gets or Sets CalledIp
        /// </summary>
        [DataMember(Name = "called_ip", EmitDefaultValue = false)]
        public string CalledIp { get; set; }

        /// <summary>
        /// Gets or Sets CalledId
        /// </summary>
        [DataMember(Name = "called_id", EmitDefaultValue = false)]
        public string CalledId { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or Sets Bandwith
        /// </summary>
        [DataMember(Name = "bandwith", EmitDefaultValue = false)]
        public string Bandwith { get; set; }

        /// <summary>
        /// Gets or Sets TimeStarted
        /// </summary>
        [DataMember(Name = "time_started", EmitDefaultValue = false)]
        public string TimeStarted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusVoipCallListInner {\n");
            sb.Append("  CallerIp: ").Append(CallerIp).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  CalledIp: ").Append(CalledIp).Append("\n");
            sb.Append("  CalledId: ").Append(CalledId).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Bandwith: ").Append(Bandwith).Append("\n");
            sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
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
            return this.Equals(input as ShowStatusVoipCallListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusVoipCallListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusVoipCallListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusVoipCallListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CallerIp == input.CallerIp ||
                    (this.CallerIp != null &&
                    this.CallerIp.Equals(input.CallerIp))
                ) && 
                (
                    this.CallerId == input.CallerId ||
                    (this.CallerId != null &&
                    this.CallerId.Equals(input.CallerId))
                ) && 
                (
                    this.CalledIp == input.CalledIp ||
                    (this.CalledIp != null &&
                    this.CalledIp.Equals(input.CalledIp))
                ) && 
                (
                    this.CalledId == input.CalledId ||
                    (this.CalledId != null &&
                    this.CalledId.Equals(input.CalledId))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Bandwith == input.Bandwith ||
                    (this.Bandwith != null &&
                    this.Bandwith.Equals(input.Bandwith))
                ) && 
                (
                    this.TimeStarted == input.TimeStarted ||
                    (this.TimeStarted != null &&
                    this.TimeStarted.Equals(input.TimeStarted))
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
                if (this.CallerIp != null)
                {
                    hashCode = (hashCode * 59) + this.CallerIp.GetHashCode();
                }
                if (this.CallerId != null)
                {
                    hashCode = (hashCode * 59) + this.CallerId.GetHashCode();
                }
                if (this.CalledIp != null)
                {
                    hashCode = (hashCode * 59) + this.CalledIp.GetHashCode();
                }
                if (this.CalledId != null)
                {
                    hashCode = (hashCode * 59) + this.CalledId.GetHashCode();
                }
                if (this.Protocol != null)
                {
                    hashCode = (hashCode * 59) + this.Protocol.GetHashCode();
                }
                if (this.Bandwith != null)
                {
                    hashCode = (hashCode * 59) + this.Bandwith.GetHashCode();
                }
                if (this.TimeStarted != null)
                {
                    hashCode = (hashCode * 59) + this.TimeStarted.GetHashCode();
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
