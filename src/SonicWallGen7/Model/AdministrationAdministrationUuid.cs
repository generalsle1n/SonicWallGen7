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
    /// Configure UUID settings.
    /// </summary>
    [DataContract(Name = "administration_administration_uuid")]
    public partial class AdministrationAdministrationUuid : IEquatable<AdministrationAdministrationUuid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationAdministrationUuid" /> class.
        /// </summary>
        /// <param name="all">Enable all uuid settings..</param>
        /// <param name="addressObjects">Enable Address Objects in uuid settings..</param>
        /// <param name="serviceObjects">Enable Address Objects in uuid ..</param>
        /// <param name="userObjects">Enable Address Objects in uuid settings..</param>
        /// <param name="scheduleObjects">Enable schedule-objects in uuid settings..</param>
        /// <param name="zoneObjects">Enable zone-objects in uuid settings..</param>
        /// <param name="accessRules">Enable access-rules in uuid settings..</param>
        /// <param name="natPolicy">Enable SonicOS API..</param>
        /// <param name="routingPolicy">Enable routing-policy..</param>
        /// <param name="contentFilterObjects">Enable SonicOS API..</param>
        /// <param name="contentFilterPolicies">Enable content-filter-policies in uuid settings..</param>
        /// <param name="networkMonitorPolicy">Enable network-monitor-policy in uuid settings..</param>
        /// <param name="sdwanPerformanceProbes">Enable sdwan-performance-probes in uuid settings..</param>
        public AdministrationAdministrationUuid(bool all = default(bool), bool addressObjects = default(bool), bool serviceObjects = default(bool), bool userObjects = default(bool), bool scheduleObjects = default(bool), bool zoneObjects = default(bool), bool accessRules = default(bool), bool natPolicy = default(bool), bool routingPolicy = default(bool), bool contentFilterObjects = default(bool), bool contentFilterPolicies = default(bool), bool networkMonitorPolicy = default(bool), bool sdwanPerformanceProbes = default(bool))
        {
            this.All = all;
            this.AddressObjects = addressObjects;
            this.ServiceObjects = serviceObjects;
            this.UserObjects = userObjects;
            this.ScheduleObjects = scheduleObjects;
            this.ZoneObjects = zoneObjects;
            this.AccessRules = accessRules;
            this.NatPolicy = natPolicy;
            this.RoutingPolicy = routingPolicy;
            this.ContentFilterObjects = contentFilterObjects;
            this.ContentFilterPolicies = contentFilterPolicies;
            this.NetworkMonitorPolicy = networkMonitorPolicy;
            this.SdwanPerformanceProbes = sdwanPerformanceProbes;
        }

        /// <summary>
        /// Enable all uuid settings.
        /// </summary>
        /// <value>Enable all uuid settings.</value>
        [DataMember(Name = "all", EmitDefaultValue = true)]
        public bool All { get; set; }

        /// <summary>
        /// Enable Address Objects in uuid settings.
        /// </summary>
        /// <value>Enable Address Objects in uuid settings.</value>
        [DataMember(Name = "address_objects", EmitDefaultValue = true)]
        public bool AddressObjects { get; set; }

        /// <summary>
        /// Enable Address Objects in uuid .
        /// </summary>
        /// <value>Enable Address Objects in uuid .</value>
        [DataMember(Name = "service_objects", EmitDefaultValue = true)]
        public bool ServiceObjects { get; set; }

        /// <summary>
        /// Enable Address Objects in uuid settings.
        /// </summary>
        /// <value>Enable Address Objects in uuid settings.</value>
        [DataMember(Name = "user_objects", EmitDefaultValue = true)]
        public bool UserObjects { get; set; }

        /// <summary>
        /// Enable schedule-objects in uuid settings.
        /// </summary>
        /// <value>Enable schedule-objects in uuid settings.</value>
        [DataMember(Name = "schedule_objects", EmitDefaultValue = true)]
        public bool ScheduleObjects { get; set; }

        /// <summary>
        /// Enable zone-objects in uuid settings.
        /// </summary>
        /// <value>Enable zone-objects in uuid settings.</value>
        [DataMember(Name = "zone_objects", EmitDefaultValue = true)]
        public bool ZoneObjects { get; set; }

        /// <summary>
        /// Enable access-rules in uuid settings.
        /// </summary>
        /// <value>Enable access-rules in uuid settings.</value>
        [DataMember(Name = "access_rules", EmitDefaultValue = true)]
        public bool AccessRules { get; set; }

        /// <summary>
        /// Enable SonicOS API.
        /// </summary>
        /// <value>Enable SonicOS API.</value>
        [DataMember(Name = "nat_policy", EmitDefaultValue = true)]
        public bool NatPolicy { get; set; }

        /// <summary>
        /// Enable routing-policy.
        /// </summary>
        /// <value>Enable routing-policy.</value>
        [DataMember(Name = "routing_policy", EmitDefaultValue = true)]
        public bool RoutingPolicy { get; set; }

        /// <summary>
        /// Enable SonicOS API.
        /// </summary>
        /// <value>Enable SonicOS API.</value>
        [DataMember(Name = "content_filter_objects", EmitDefaultValue = true)]
        public bool ContentFilterObjects { get; set; }

        /// <summary>
        /// Enable content-filter-policies in uuid settings.
        /// </summary>
        /// <value>Enable content-filter-policies in uuid settings.</value>
        [DataMember(Name = "content_filter_policies", EmitDefaultValue = true)]
        public bool ContentFilterPolicies { get; set; }

        /// <summary>
        /// Enable network-monitor-policy in uuid settings.
        /// </summary>
        /// <value>Enable network-monitor-policy in uuid settings.</value>
        [DataMember(Name = "network_monitor_policy", EmitDefaultValue = true)]
        public bool NetworkMonitorPolicy { get; set; }

        /// <summary>
        /// Enable sdwan-performance-probes in uuid settings.
        /// </summary>
        /// <value>Enable sdwan-performance-probes in uuid settings.</value>
        [DataMember(Name = "sdwan_performance_probes", EmitDefaultValue = true)]
        public bool SdwanPerformanceProbes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdministrationAdministrationUuid {\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  AddressObjects: ").Append(AddressObjects).Append("\n");
            sb.Append("  ServiceObjects: ").Append(ServiceObjects).Append("\n");
            sb.Append("  UserObjects: ").Append(UserObjects).Append("\n");
            sb.Append("  ScheduleObjects: ").Append(ScheduleObjects).Append("\n");
            sb.Append("  ZoneObjects: ").Append(ZoneObjects).Append("\n");
            sb.Append("  AccessRules: ").Append(AccessRules).Append("\n");
            sb.Append("  NatPolicy: ").Append(NatPolicy).Append("\n");
            sb.Append("  RoutingPolicy: ").Append(RoutingPolicy).Append("\n");
            sb.Append("  ContentFilterObjects: ").Append(ContentFilterObjects).Append("\n");
            sb.Append("  ContentFilterPolicies: ").Append(ContentFilterPolicies).Append("\n");
            sb.Append("  NetworkMonitorPolicy: ").Append(NetworkMonitorPolicy).Append("\n");
            sb.Append("  SdwanPerformanceProbes: ").Append(SdwanPerformanceProbes).Append("\n");
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
            return this.Equals(input as AdministrationAdministrationUuid);
        }

        /// <summary>
        /// Returns true if AdministrationAdministrationUuid instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministrationAdministrationUuid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministrationAdministrationUuid input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.All == input.All ||
                    this.All.Equals(input.All)
                ) && 
                (
                    this.AddressObjects == input.AddressObjects ||
                    this.AddressObjects.Equals(input.AddressObjects)
                ) && 
                (
                    this.ServiceObjects == input.ServiceObjects ||
                    this.ServiceObjects.Equals(input.ServiceObjects)
                ) && 
                (
                    this.UserObjects == input.UserObjects ||
                    this.UserObjects.Equals(input.UserObjects)
                ) && 
                (
                    this.ScheduleObjects == input.ScheduleObjects ||
                    this.ScheduleObjects.Equals(input.ScheduleObjects)
                ) && 
                (
                    this.ZoneObjects == input.ZoneObjects ||
                    this.ZoneObjects.Equals(input.ZoneObjects)
                ) && 
                (
                    this.AccessRules == input.AccessRules ||
                    this.AccessRules.Equals(input.AccessRules)
                ) && 
                (
                    this.NatPolicy == input.NatPolicy ||
                    this.NatPolicy.Equals(input.NatPolicy)
                ) && 
                (
                    this.RoutingPolicy == input.RoutingPolicy ||
                    this.RoutingPolicy.Equals(input.RoutingPolicy)
                ) && 
                (
                    this.ContentFilterObjects == input.ContentFilterObjects ||
                    this.ContentFilterObjects.Equals(input.ContentFilterObjects)
                ) && 
                (
                    this.ContentFilterPolicies == input.ContentFilterPolicies ||
                    this.ContentFilterPolicies.Equals(input.ContentFilterPolicies)
                ) && 
                (
                    this.NetworkMonitorPolicy == input.NetworkMonitorPolicy ||
                    this.NetworkMonitorPolicy.Equals(input.NetworkMonitorPolicy)
                ) && 
                (
                    this.SdwanPerformanceProbes == input.SdwanPerformanceProbes ||
                    this.SdwanPerformanceProbes.Equals(input.SdwanPerformanceProbes)
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
                hashCode = (hashCode * 59) + this.All.GetHashCode();
                hashCode = (hashCode * 59) + this.AddressObjects.GetHashCode();
                hashCode = (hashCode * 59) + this.ServiceObjects.GetHashCode();
                hashCode = (hashCode * 59) + this.UserObjects.GetHashCode();
                hashCode = (hashCode * 59) + this.ScheduleObjects.GetHashCode();
                hashCode = (hashCode * 59) + this.ZoneObjects.GetHashCode();
                hashCode = (hashCode * 59) + this.AccessRules.GetHashCode();
                hashCode = (hashCode * 59) + this.NatPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.RoutingPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.ContentFilterObjects.GetHashCode();
                hashCode = (hashCode * 59) + this.ContentFilterPolicies.GetHashCode();
                hashCode = (hashCode * 59) + this.NetworkMonitorPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.SdwanPerformanceProbes.GetHashCode();
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
