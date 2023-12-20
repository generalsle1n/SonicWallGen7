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
    /// ShowStatusFirewallConnectionsListInner
    /// </summary>
    [DataContract(Name = "show_status_firewall_connections_list_inner")]
    public partial class ShowStatusFirewallConnectionsListInner : IEquatable<ShowStatusFirewallConnectionsListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusFirewallConnectionsListInner" /> class.
        /// </summary>
        /// <param name="appflow">appflow.</param>
        /// <param name="externalCollector">externalCollector.</param>
        /// <param name="maximumSpiConnections">maximumSpiConnections.</param>
        /// <param name="maximumDpiConnections">maximumDpiConnections.</param>
        /// <param name="dpiConnections">dpiConnections.</param>
        public ShowStatusFirewallConnectionsListInner(string appflow = default(string), string externalCollector = default(string), string maximumSpiConnections = default(string), string maximumDpiConnections = default(string), string dpiConnections = default(string))
        {
            this.Appflow = appflow;
            this.ExternalCollector = externalCollector;
            this.MaximumSpiConnections = maximumSpiConnections;
            this.MaximumDpiConnections = maximumDpiConnections;
            this.DpiConnections = dpiConnections;
        }

        /// <summary>
        /// Gets or Sets Appflow
        /// </summary>
        [DataMember(Name = "appflow", EmitDefaultValue = false)]
        public string Appflow { get; set; }

        /// <summary>
        /// Gets or Sets ExternalCollector
        /// </summary>
        [DataMember(Name = "external_collector", EmitDefaultValue = false)]
        public string ExternalCollector { get; set; }

        /// <summary>
        /// Gets or Sets MaximumSpiConnections
        /// </summary>
        [DataMember(Name = "maximum_spi_connections", EmitDefaultValue = false)]
        public string MaximumSpiConnections { get; set; }

        /// <summary>
        /// Gets or Sets MaximumDpiConnections
        /// </summary>
        [DataMember(Name = "maximum_dpi_connections", EmitDefaultValue = false)]
        public string MaximumDpiConnections { get; set; }

        /// <summary>
        /// Gets or Sets DpiConnections
        /// </summary>
        [DataMember(Name = "dpi_connections", EmitDefaultValue = false)]
        public string DpiConnections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusFirewallConnectionsListInner {\n");
            sb.Append("  Appflow: ").Append(Appflow).Append("\n");
            sb.Append("  ExternalCollector: ").Append(ExternalCollector).Append("\n");
            sb.Append("  MaximumSpiConnections: ").Append(MaximumSpiConnections).Append("\n");
            sb.Append("  MaximumDpiConnections: ").Append(MaximumDpiConnections).Append("\n");
            sb.Append("  DpiConnections: ").Append(DpiConnections).Append("\n");
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
            return this.Equals(input as ShowStatusFirewallConnectionsListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusFirewallConnectionsListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusFirewallConnectionsListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusFirewallConnectionsListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Appflow == input.Appflow ||
                    (this.Appflow != null &&
                    this.Appflow.Equals(input.Appflow))
                ) && 
                (
                    this.ExternalCollector == input.ExternalCollector ||
                    (this.ExternalCollector != null &&
                    this.ExternalCollector.Equals(input.ExternalCollector))
                ) && 
                (
                    this.MaximumSpiConnections == input.MaximumSpiConnections ||
                    (this.MaximumSpiConnections != null &&
                    this.MaximumSpiConnections.Equals(input.MaximumSpiConnections))
                ) && 
                (
                    this.MaximumDpiConnections == input.MaximumDpiConnections ||
                    (this.MaximumDpiConnections != null &&
                    this.MaximumDpiConnections.Equals(input.MaximumDpiConnections))
                ) && 
                (
                    this.DpiConnections == input.DpiConnections ||
                    (this.DpiConnections != null &&
                    this.DpiConnections.Equals(input.DpiConnections))
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
                if (this.Appflow != null)
                {
                    hashCode = (hashCode * 59) + this.Appflow.GetHashCode();
                }
                if (this.ExternalCollector != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalCollector.GetHashCode();
                }
                if (this.MaximumSpiConnections != null)
                {
                    hashCode = (hashCode * 59) + this.MaximumSpiConnections.GetHashCode();
                }
                if (this.MaximumDpiConnections != null)
                {
                    hashCode = (hashCode * 59) + this.MaximumDpiConnections.GetHashCode();
                }
                if (this.DpiConnections != null)
                {
                    hashCode = (hashCode * 59) + this.DpiConnections.GetHashCode();
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