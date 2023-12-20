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
    /// Enable send dynamic appflow for specified tables.
    /// </summary>
    [DataContract(Name = "appflow_gmsflow_server_appflow_gmsflow_server_dynamic_flows")]
    public partial class AppflowGmsflowServerAppflowGmsflowServerDynamicFlows : IEquatable<AppflowGmsflowServerAppflowGmsflowServerDynamicFlows>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppflowGmsflowServerAppflowGmsflowServerDynamicFlows" /> class.
        /// </summary>
        /// <param name="connections">Connections..</param>
        /// <param name="users">Users..</param>
        /// <param name="urls">URLs..</param>
        /// <param name="urlRatings">URL ratings..</param>
        /// <param name="vpns">VPNs..</param>
        /// <param name="devices">Devices..</param>
        /// <param name="spams">SPAMs.</param>
        /// <param name="locations">Locations..</param>
        /// <param name="voips">VOIPs..</param>
        public AppflowGmsflowServerAppflowGmsflowServerDynamicFlows(bool connections = default(bool), bool users = default(bool), bool urls = default(bool), bool urlRatings = default(bool), bool vpns = default(bool), bool devices = default(bool), bool spams = default(bool), bool locations = default(bool), bool voips = default(bool))
        {
            this.Connections = connections;
            this.Users = users;
            this.Urls = urls;
            this.UrlRatings = urlRatings;
            this.Vpns = vpns;
            this.Devices = devices;
            this.Spams = spams;
            this.Locations = locations;
            this.Voips = voips;
        }

        /// <summary>
        /// Connections.
        /// </summary>
        /// <value>Connections.</value>
        [DataMember(Name = "connections", EmitDefaultValue = true)]
        public bool Connections { get; set; }

        /// <summary>
        /// Users.
        /// </summary>
        /// <value>Users.</value>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public bool Users { get; set; }

        /// <summary>
        /// URLs.
        /// </summary>
        /// <value>URLs.</value>
        [DataMember(Name = "urls", EmitDefaultValue = true)]
        public bool Urls { get; set; }

        /// <summary>
        /// URL ratings.
        /// </summary>
        /// <value>URL ratings.</value>
        [DataMember(Name = "url_ratings", EmitDefaultValue = true)]
        public bool UrlRatings { get; set; }

        /// <summary>
        /// VPNs.
        /// </summary>
        /// <value>VPNs.</value>
        [DataMember(Name = "vpns", EmitDefaultValue = true)]
        public bool Vpns { get; set; }

        /// <summary>
        /// Devices.
        /// </summary>
        /// <value>Devices.</value>
        [DataMember(Name = "devices", EmitDefaultValue = true)]
        public bool Devices { get; set; }

        /// <summary>
        /// SPAMs
        /// </summary>
        /// <value>SPAMs</value>
        [DataMember(Name = "spams", EmitDefaultValue = true)]
        public bool Spams { get; set; }

        /// <summary>
        /// Locations.
        /// </summary>
        /// <value>Locations.</value>
        [DataMember(Name = "locations", EmitDefaultValue = true)]
        public bool Locations { get; set; }

        /// <summary>
        /// VOIPs.
        /// </summary>
        /// <value>VOIPs.</value>
        [DataMember(Name = "voips", EmitDefaultValue = true)]
        public bool Voips { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppflowGmsflowServerAppflowGmsflowServerDynamicFlows {\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  UrlRatings: ").Append(UrlRatings).Append("\n");
            sb.Append("  Vpns: ").Append(Vpns).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  Spams: ").Append(Spams).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Voips: ").Append(Voips).Append("\n");
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
            return this.Equals(input as AppflowGmsflowServerAppflowGmsflowServerDynamicFlows);
        }

        /// <summary>
        /// Returns true if AppflowGmsflowServerAppflowGmsflowServerDynamicFlows instances are equal
        /// </summary>
        /// <param name="input">Instance of AppflowGmsflowServerAppflowGmsflowServerDynamicFlows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppflowGmsflowServerAppflowGmsflowServerDynamicFlows input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Connections == input.Connections ||
                    this.Connections.Equals(input.Connections)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users.Equals(input.Users)
                ) && 
                (
                    this.Urls == input.Urls ||
                    this.Urls.Equals(input.Urls)
                ) && 
                (
                    this.UrlRatings == input.UrlRatings ||
                    this.UrlRatings.Equals(input.UrlRatings)
                ) && 
                (
                    this.Vpns == input.Vpns ||
                    this.Vpns.Equals(input.Vpns)
                ) && 
                (
                    this.Devices == input.Devices ||
                    this.Devices.Equals(input.Devices)
                ) && 
                (
                    this.Spams == input.Spams ||
                    this.Spams.Equals(input.Spams)
                ) && 
                (
                    this.Locations == input.Locations ||
                    this.Locations.Equals(input.Locations)
                ) && 
                (
                    this.Voips == input.Voips ||
                    this.Voips.Equals(input.Voips)
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
                hashCode = (hashCode * 59) + this.Connections.GetHashCode();
                hashCode = (hashCode * 59) + this.Users.GetHashCode();
                hashCode = (hashCode * 59) + this.Urls.GetHashCode();
                hashCode = (hashCode * 59) + this.UrlRatings.GetHashCode();
                hashCode = (hashCode * 59) + this.Vpns.GetHashCode();
                hashCode = (hashCode * 59) + this.Devices.GetHashCode();
                hashCode = (hashCode * 59) + this.Spams.GetHashCode();
                hashCode = (hashCode * 59) + this.Locations.GetHashCode();
                hashCode = (hashCode * 59) + this.Voips.GetHashCode();
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
