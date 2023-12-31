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
    /// Enable tables to send static appflows for.
    /// </summary>
    [DataContract(Name = "appflow_external_collector_appflow_external_collector_static_flows")]
    public partial class AppflowExternalCollectorAppflowExternalCollectorStaticFlows : IEquatable<AppflowExternalCollectorAppflowExternalCollectorStaticFlows>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppflowExternalCollectorAppflowExternalCollectorStaticFlows" /> class.
        /// </summary>
        /// <param name="applications">Applications..</param>
        /// <param name="viruses">Viruses..</param>
        /// <param name="spyware">Spyware..</param>
        /// <param name="intrusions">Intrusions..</param>
        /// <param name="locationMap">Location map..</param>
        /// <param name="services">Services..</param>
        /// <param name="ratingMap">Rating map..</param>
        /// <param name="tableMap">Table map..</param>
        /// <param name="columnMap">Column map..</param>
        public AppflowExternalCollectorAppflowExternalCollectorStaticFlows(bool applications = default(bool), bool viruses = default(bool), bool spyware = default(bool), bool intrusions = default(bool), bool locationMap = default(bool), bool services = default(bool), bool ratingMap = default(bool), bool tableMap = default(bool), bool columnMap = default(bool))
        {
            this.Applications = applications;
            this.Viruses = viruses;
            this.Spyware = spyware;
            this.Intrusions = intrusions;
            this.LocationMap = locationMap;
            this.Services = services;
            this.RatingMap = ratingMap;
            this.TableMap = tableMap;
            this.ColumnMap = columnMap;
        }

        /// <summary>
        /// Applications.
        /// </summary>
        /// <value>Applications.</value>
        [DataMember(Name = "applications", EmitDefaultValue = true)]
        public bool Applications { get; set; }

        /// <summary>
        /// Viruses.
        /// </summary>
        /// <value>Viruses.</value>
        [DataMember(Name = "viruses", EmitDefaultValue = true)]
        public bool Viruses { get; set; }

        /// <summary>
        /// Spyware.
        /// </summary>
        /// <value>Spyware.</value>
        [DataMember(Name = "spyware", EmitDefaultValue = true)]
        public bool Spyware { get; set; }

        /// <summary>
        /// Intrusions.
        /// </summary>
        /// <value>Intrusions.</value>
        [DataMember(Name = "intrusions", EmitDefaultValue = true)]
        public bool Intrusions { get; set; }

        /// <summary>
        /// Location map.
        /// </summary>
        /// <value>Location map.</value>
        [DataMember(Name = "location_map", EmitDefaultValue = true)]
        public bool LocationMap { get; set; }

        /// <summary>
        /// Services.
        /// </summary>
        /// <value>Services.</value>
        [DataMember(Name = "services", EmitDefaultValue = true)]
        public bool Services { get; set; }

        /// <summary>
        /// Rating map.
        /// </summary>
        /// <value>Rating map.</value>
        [DataMember(Name = "rating_map", EmitDefaultValue = true)]
        public bool RatingMap { get; set; }

        /// <summary>
        /// Table map.
        /// </summary>
        /// <value>Table map.</value>
        [DataMember(Name = "table_map", EmitDefaultValue = true)]
        public bool TableMap { get; set; }

        /// <summary>
        /// Column map.
        /// </summary>
        /// <value>Column map.</value>
        [DataMember(Name = "column_map", EmitDefaultValue = true)]
        public bool ColumnMap { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppflowExternalCollectorAppflowExternalCollectorStaticFlows {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Viruses: ").Append(Viruses).Append("\n");
            sb.Append("  Spyware: ").Append(Spyware).Append("\n");
            sb.Append("  Intrusions: ").Append(Intrusions).Append("\n");
            sb.Append("  LocationMap: ").Append(LocationMap).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  RatingMap: ").Append(RatingMap).Append("\n");
            sb.Append("  TableMap: ").Append(TableMap).Append("\n");
            sb.Append("  ColumnMap: ").Append(ColumnMap).Append("\n");
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
            return this.Equals(input as AppflowExternalCollectorAppflowExternalCollectorStaticFlows);
        }

        /// <summary>
        /// Returns true if AppflowExternalCollectorAppflowExternalCollectorStaticFlows instances are equal
        /// </summary>
        /// <param name="input">Instance of AppflowExternalCollectorAppflowExternalCollectorStaticFlows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppflowExternalCollectorAppflowExternalCollectorStaticFlows input)
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
                    this.Viruses == input.Viruses ||
                    this.Viruses.Equals(input.Viruses)
                ) && 
                (
                    this.Spyware == input.Spyware ||
                    this.Spyware.Equals(input.Spyware)
                ) && 
                (
                    this.Intrusions == input.Intrusions ||
                    this.Intrusions.Equals(input.Intrusions)
                ) && 
                (
                    this.LocationMap == input.LocationMap ||
                    this.LocationMap.Equals(input.LocationMap)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services.Equals(input.Services)
                ) && 
                (
                    this.RatingMap == input.RatingMap ||
                    this.RatingMap.Equals(input.RatingMap)
                ) && 
                (
                    this.TableMap == input.TableMap ||
                    this.TableMap.Equals(input.TableMap)
                ) && 
                (
                    this.ColumnMap == input.ColumnMap ||
                    this.ColumnMap.Equals(input.ColumnMap)
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
                hashCode = (hashCode * 59) + this.Viruses.GetHashCode();
                hashCode = (hashCode * 59) + this.Spyware.GetHashCode();
                hashCode = (hashCode * 59) + this.Intrusions.GetHashCode();
                hashCode = (hashCode * 59) + this.LocationMap.GetHashCode();
                hashCode = (hashCode * 59) + this.Services.GetHashCode();
                hashCode = (hashCode * 59) + this.RatingMap.GetHashCode();
                hashCode = (hashCode * 59) + this.TableMap.GetHashCode();
                hashCode = (hashCode * 59) + this.ColumnMap.GetHashCode();
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
