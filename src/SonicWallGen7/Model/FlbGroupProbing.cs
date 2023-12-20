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
    /// Enter probing configuration mode.
    /// </summary>
    [DataContract(Name = "flb_group_probing")]
    public partial class FlbGroupProbing : IEquatable<FlbGroupProbing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlbGroupProbing" /> class.
        /// </summary>
        /// <param name="healthCheck">Set the interval to perform health check of member (logical probing, physical link-check) in seconds..</param>
        /// <param name="missedIntervals">Set the number of intervals to deactivate the member after..</param>
        /// <param name="successfulIntervals">Set the number of intervals to reactivate the member after..</param>
        /// <param name="globalResponder">Enable probing on all members using SonicWall&#39;s global responder..</param>
        public FlbGroupProbing(decimal healthCheck = default(decimal), decimal missedIntervals = default(decimal), decimal successfulIntervals = default(decimal), bool globalResponder = default(bool))
        {
            this.HealthCheck = healthCheck;
            this.MissedIntervals = missedIntervals;
            this.SuccessfulIntervals = successfulIntervals;
            this.GlobalResponder = globalResponder;
        }

        /// <summary>
        /// Set the interval to perform health check of member (logical probing, physical link-check) in seconds.
        /// </summary>
        /// <value>Set the interval to perform health check of member (logical probing, physical link-check) in seconds.</value>
        [DataMember(Name = "health_check", EmitDefaultValue = false)]
        public decimal HealthCheck { get; set; }

        /// <summary>
        /// Set the number of intervals to deactivate the member after.
        /// </summary>
        /// <value>Set the number of intervals to deactivate the member after.</value>
        [DataMember(Name = "missed_intervals", EmitDefaultValue = false)]
        public decimal MissedIntervals { get; set; }

        /// <summary>
        /// Set the number of intervals to reactivate the member after.
        /// </summary>
        /// <value>Set the number of intervals to reactivate the member after.</value>
        [DataMember(Name = "successful_intervals", EmitDefaultValue = false)]
        public decimal SuccessfulIntervals { get; set; }

        /// <summary>
        /// Enable probing on all members using SonicWall&#39;s global responder.
        /// </summary>
        /// <value>Enable probing on all members using SonicWall&#39;s global responder.</value>
        [DataMember(Name = "global_responder", EmitDefaultValue = true)]
        public bool GlobalResponder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlbGroupProbing {\n");
            sb.Append("  HealthCheck: ").Append(HealthCheck).Append("\n");
            sb.Append("  MissedIntervals: ").Append(MissedIntervals).Append("\n");
            sb.Append("  SuccessfulIntervals: ").Append(SuccessfulIntervals).Append("\n");
            sb.Append("  GlobalResponder: ").Append(GlobalResponder).Append("\n");
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
            return this.Equals(input as FlbGroupProbing);
        }

        /// <summary>
        /// Returns true if FlbGroupProbing instances are equal
        /// </summary>
        /// <param name="input">Instance of FlbGroupProbing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlbGroupProbing input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HealthCheck == input.HealthCheck ||
                    this.HealthCheck.Equals(input.HealthCheck)
                ) && 
                (
                    this.MissedIntervals == input.MissedIntervals ||
                    this.MissedIntervals.Equals(input.MissedIntervals)
                ) && 
                (
                    this.SuccessfulIntervals == input.SuccessfulIntervals ||
                    this.SuccessfulIntervals.Equals(input.SuccessfulIntervals)
                ) && 
                (
                    this.GlobalResponder == input.GlobalResponder ||
                    this.GlobalResponder.Equals(input.GlobalResponder)
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
                hashCode = (hashCode * 59) + this.HealthCheck.GetHashCode();
                hashCode = (hashCode * 59) + this.MissedIntervals.GetHashCode();
                hashCode = (hashCode * 59) + this.SuccessfulIntervals.GetHashCode();
                hashCode = (hashCode * 59) + this.GlobalResponder.GetHashCode();
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
