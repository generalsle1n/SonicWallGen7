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
    /// appflow internal detail schema.
    /// </summary>
    [DataContract(Name = "show_status_appflow_internal_detail")]
    public partial class ShowStatusAppflowInternalDetail : IEquatable<ShowStatusAppflowInternalDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusAppflowInternalDetail" /> class.
        /// </summary>
        /// <param name="dataFlowsEnqueued">dataFlowsEnqueued.</param>
        /// <param name="dataFlowsDequeued">dataFlowsDequeued.</param>
        /// <param name="dataFlowsDropped">dataFlowsDropped.</param>
        /// <param name="dataFlowsSkippedReporting">dataFlowsSkippedReporting.</param>
        /// <param name="generalFlowsEnqueued">generalFlowsEnqueued.</param>
        /// <param name="generalFlowsDequeued">generalFlowsDequeued.</param>
        /// <param name="generalFlowsDropped">generalFlowsDropped.</param>
        /// <param name="generalStaticFlowsDequeued">generalStaticFlowsDequeued.</param>
        /// <param name="appflowCollectorErrors">appflowCollectorErrors.</param>
        /// <param name="totalFlowsInDb">totalFlowsInDb.</param>
        public ShowStatusAppflowInternalDetail(string dataFlowsEnqueued = default(string), string dataFlowsDequeued = default(string), string dataFlowsDropped = default(string), string dataFlowsSkippedReporting = default(string), string generalFlowsEnqueued = default(string), string generalFlowsDequeued = default(string), string generalFlowsDropped = default(string), string generalStaticFlowsDequeued = default(string), string appflowCollectorErrors = default(string), string totalFlowsInDb = default(string))
        {
            this.DataFlowsEnqueued = dataFlowsEnqueued;
            this.DataFlowsDequeued = dataFlowsDequeued;
            this.DataFlowsDropped = dataFlowsDropped;
            this.DataFlowsSkippedReporting = dataFlowsSkippedReporting;
            this.GeneralFlowsEnqueued = generalFlowsEnqueued;
            this.GeneralFlowsDequeued = generalFlowsDequeued;
            this.GeneralFlowsDropped = generalFlowsDropped;
            this.GeneralStaticFlowsDequeued = generalStaticFlowsDequeued;
            this.AppflowCollectorErrors = appflowCollectorErrors;
            this.TotalFlowsInDb = totalFlowsInDb;
        }

        /// <summary>
        /// Gets or Sets DataFlowsEnqueued
        /// </summary>
        [DataMember(Name = "data_flows_enqueued", EmitDefaultValue = false)]
        public string DataFlowsEnqueued { get; set; }

        /// <summary>
        /// Gets or Sets DataFlowsDequeued
        /// </summary>
        [DataMember(Name = "data_flows_dequeued", EmitDefaultValue = false)]
        public string DataFlowsDequeued { get; set; }

        /// <summary>
        /// Gets or Sets DataFlowsDropped
        /// </summary>
        [DataMember(Name = "data_flows_dropped", EmitDefaultValue = false)]
        public string DataFlowsDropped { get; set; }

        /// <summary>
        /// Gets or Sets DataFlowsSkippedReporting
        /// </summary>
        [DataMember(Name = "data_flows_skipped_reporting", EmitDefaultValue = false)]
        public string DataFlowsSkippedReporting { get; set; }

        /// <summary>
        /// Gets or Sets GeneralFlowsEnqueued
        /// </summary>
        [DataMember(Name = "general_flows_enqueued", EmitDefaultValue = false)]
        public string GeneralFlowsEnqueued { get; set; }

        /// <summary>
        /// Gets or Sets GeneralFlowsDequeued
        /// </summary>
        [DataMember(Name = "general_flows_dequeued", EmitDefaultValue = false)]
        public string GeneralFlowsDequeued { get; set; }

        /// <summary>
        /// Gets or Sets GeneralFlowsDropped
        /// </summary>
        [DataMember(Name = "general_flows_dropped", EmitDefaultValue = false)]
        public string GeneralFlowsDropped { get; set; }

        /// <summary>
        /// Gets or Sets GeneralStaticFlowsDequeued
        /// </summary>
        [DataMember(Name = "general_static_flows_dequeued", EmitDefaultValue = false)]
        public string GeneralStaticFlowsDequeued { get; set; }

        /// <summary>
        /// Gets or Sets AppflowCollectorErrors
        /// </summary>
        [DataMember(Name = "appflow_collector_errors", EmitDefaultValue = false)]
        public string AppflowCollectorErrors { get; set; }

        /// <summary>
        /// Gets or Sets TotalFlowsInDb
        /// </summary>
        [DataMember(Name = "total_flows_in_db", EmitDefaultValue = false)]
        public string TotalFlowsInDb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusAppflowInternalDetail {\n");
            sb.Append("  DataFlowsEnqueued: ").Append(DataFlowsEnqueued).Append("\n");
            sb.Append("  DataFlowsDequeued: ").Append(DataFlowsDequeued).Append("\n");
            sb.Append("  DataFlowsDropped: ").Append(DataFlowsDropped).Append("\n");
            sb.Append("  DataFlowsSkippedReporting: ").Append(DataFlowsSkippedReporting).Append("\n");
            sb.Append("  GeneralFlowsEnqueued: ").Append(GeneralFlowsEnqueued).Append("\n");
            sb.Append("  GeneralFlowsDequeued: ").Append(GeneralFlowsDequeued).Append("\n");
            sb.Append("  GeneralFlowsDropped: ").Append(GeneralFlowsDropped).Append("\n");
            sb.Append("  GeneralStaticFlowsDequeued: ").Append(GeneralStaticFlowsDequeued).Append("\n");
            sb.Append("  AppflowCollectorErrors: ").Append(AppflowCollectorErrors).Append("\n");
            sb.Append("  TotalFlowsInDb: ").Append(TotalFlowsInDb).Append("\n");
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
            return this.Equals(input as ShowStatusAppflowInternalDetail);
        }

        /// <summary>
        /// Returns true if ShowStatusAppflowInternalDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusAppflowInternalDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusAppflowInternalDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataFlowsEnqueued == input.DataFlowsEnqueued ||
                    (this.DataFlowsEnqueued != null &&
                    this.DataFlowsEnqueued.Equals(input.DataFlowsEnqueued))
                ) && 
                (
                    this.DataFlowsDequeued == input.DataFlowsDequeued ||
                    (this.DataFlowsDequeued != null &&
                    this.DataFlowsDequeued.Equals(input.DataFlowsDequeued))
                ) && 
                (
                    this.DataFlowsDropped == input.DataFlowsDropped ||
                    (this.DataFlowsDropped != null &&
                    this.DataFlowsDropped.Equals(input.DataFlowsDropped))
                ) && 
                (
                    this.DataFlowsSkippedReporting == input.DataFlowsSkippedReporting ||
                    (this.DataFlowsSkippedReporting != null &&
                    this.DataFlowsSkippedReporting.Equals(input.DataFlowsSkippedReporting))
                ) && 
                (
                    this.GeneralFlowsEnqueued == input.GeneralFlowsEnqueued ||
                    (this.GeneralFlowsEnqueued != null &&
                    this.GeneralFlowsEnqueued.Equals(input.GeneralFlowsEnqueued))
                ) && 
                (
                    this.GeneralFlowsDequeued == input.GeneralFlowsDequeued ||
                    (this.GeneralFlowsDequeued != null &&
                    this.GeneralFlowsDequeued.Equals(input.GeneralFlowsDequeued))
                ) && 
                (
                    this.GeneralFlowsDropped == input.GeneralFlowsDropped ||
                    (this.GeneralFlowsDropped != null &&
                    this.GeneralFlowsDropped.Equals(input.GeneralFlowsDropped))
                ) && 
                (
                    this.GeneralStaticFlowsDequeued == input.GeneralStaticFlowsDequeued ||
                    (this.GeneralStaticFlowsDequeued != null &&
                    this.GeneralStaticFlowsDequeued.Equals(input.GeneralStaticFlowsDequeued))
                ) && 
                (
                    this.AppflowCollectorErrors == input.AppflowCollectorErrors ||
                    (this.AppflowCollectorErrors != null &&
                    this.AppflowCollectorErrors.Equals(input.AppflowCollectorErrors))
                ) && 
                (
                    this.TotalFlowsInDb == input.TotalFlowsInDb ||
                    (this.TotalFlowsInDb != null &&
                    this.TotalFlowsInDb.Equals(input.TotalFlowsInDb))
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
                if (this.DataFlowsEnqueued != null)
                {
                    hashCode = (hashCode * 59) + this.DataFlowsEnqueued.GetHashCode();
                }
                if (this.DataFlowsDequeued != null)
                {
                    hashCode = (hashCode * 59) + this.DataFlowsDequeued.GetHashCode();
                }
                if (this.DataFlowsDropped != null)
                {
                    hashCode = (hashCode * 59) + this.DataFlowsDropped.GetHashCode();
                }
                if (this.DataFlowsSkippedReporting != null)
                {
                    hashCode = (hashCode * 59) + this.DataFlowsSkippedReporting.GetHashCode();
                }
                if (this.GeneralFlowsEnqueued != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralFlowsEnqueued.GetHashCode();
                }
                if (this.GeneralFlowsDequeued != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralFlowsDequeued.GetHashCode();
                }
                if (this.GeneralFlowsDropped != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralFlowsDropped.GetHashCode();
                }
                if (this.GeneralStaticFlowsDequeued != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralStaticFlowsDequeued.GetHashCode();
                }
                if (this.AppflowCollectorErrors != null)
                {
                    hashCode = (hashCode * 59) + this.AppflowCollectorErrors.GetHashCode();
                }
                if (this.TotalFlowsInDb != null)
                {
                    hashCode = (hashCode * 59) + this.TotalFlowsInDb.GetHashCode();
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
