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
    /// Enable what to collect aggregate report data for.
    /// </summary>
    [DataContract(Name = "appflow_appflow_aggregate_collect_for")]
    public partial class AppflowAppflowAggregateCollectFor : IEquatable<AppflowAppflowAggregateCollectFor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppflowAppflowAggregateCollectFor" /> class.
        /// </summary>
        /// <param name="applications">Applications report..</param>
        /// <param name="user">User report..</param>
        /// <param name="ip">Ip report..</param>
        /// <param name="threat">Threat report..</param>
        /// <param name="geoIp">Geo-IP report..</param>
        /// <param name="url">URL report..</param>
        public AppflowAppflowAggregateCollectFor(bool applications = default(bool), bool user = default(bool), bool ip = default(bool), bool threat = default(bool), bool geoIp = default(bool), bool url = default(bool))
        {
            this.Applications = applications;
            this.User = user;
            this.Ip = ip;
            this.Threat = threat;
            this.GeoIp = geoIp;
            this.Url = url;
        }

        /// <summary>
        /// Applications report.
        /// </summary>
        /// <value>Applications report.</value>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public bool Applications { get; set; }

        /// <summary>
        /// User report.
        /// </summary>
        /// <value>User report.</value>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public bool User { get; set; }

        /// <summary>
        /// Ip report.
        /// </summary>
        /// <value>Ip report.</value>
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public bool Ip { get; set; }

        /// <summary>
        /// Threat report.
        /// </summary>
        /// <value>Threat report.</value>
        [DataMember(Name = "threat", EmitDefaultValue = true)]
        public bool Threat { get; set; }

        /// <summary>
        /// Geo-IP report.
        /// </summary>
        /// <value>Geo-IP report.</value>
        [DataMember(Name = "geo_ip", EmitDefaultValue = true)]
        public bool GeoIp { get; set; }

        /// <summary>
        /// URL report.
        /// </summary>
        /// <value>URL report.</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public bool Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppflowAppflowAggregateCollectFor {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Threat: ").Append(Threat).Append("\n");
            sb.Append("  GeoIp: ").Append(GeoIp).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as AppflowAppflowAggregateCollectFor);
        }

        /// <summary>
        /// Returns true if AppflowAppflowAggregateCollectFor instances are equal
        /// </summary>
        /// <param name="input">Instance of AppflowAppflowAggregateCollectFor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppflowAppflowAggregateCollectFor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications.Equals(input.Applications)
                ) && 
                (
                    this.User == input.User ||
                    this.User.Equals(input.User)
                ) && 
                (
                    this.Ip == input.Ip ||
                    this.Ip.Equals(input.Ip)
                ) && 
                (
                    this.Threat == input.Threat ||
                    this.Threat.Equals(input.Threat)
                ) && 
                (
                    this.GeoIp == input.GeoIp ||
                    this.GeoIp.Equals(input.GeoIp)
                ) && 
                (
                    this.Url == input.Url ||
                    this.Url.Equals(input.Url)
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
                hashCode = (hashCode * 59) + this.Applications.GetHashCode();
                hashCode = (hashCode * 59) + this.User.GetHashCode();
                hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                hashCode = (hashCode * 59) + this.Threat.GetHashCode();
                hashCode = (hashCode * 59) + this.GeoIp.GetHashCode();
                hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
