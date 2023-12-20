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
    /// LogViewpointLog
    /// </summary>
    [DataContract(Name = "log_viewpoint_log")]
    public partial class LogViewpointLog : IEquatable<LogViewpointLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogViewpointLog" /> class.
        /// </summary>
        /// <param name="viewpoint">viewpoint.</param>
        public LogViewpointLog(LogViewpointLogViewpoint viewpoint = default(LogViewpointLogViewpoint))
        {
            this.Viewpoint = viewpoint;
        }

        /// <summary>
        /// Gets or Sets Viewpoint
        /// </summary>
        [DataMember(Name = "viewpoint", EmitDefaultValue = false)]
        public LogViewpointLogViewpoint Viewpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogViewpointLog {\n");
            sb.Append("  Viewpoint: ").Append(Viewpoint).Append("\n");
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
            return this.Equals(input as LogViewpointLog);
        }

        /// <summary>
        /// Returns true if LogViewpointLog instances are equal
        /// </summary>
        /// <param name="input">Instance of LogViewpointLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogViewpointLog input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Viewpoint == input.Viewpoint ||
                    (this.Viewpoint != null &&
                    this.Viewpoint.Equals(input.Viewpoint))
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
                if (this.Viewpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Viewpoint.GetHashCode();
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
