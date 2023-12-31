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
    /// ShowStatusMacAntiSpoofCacheListInner
    /// </summary>
    [DataContract(Name = "show_status_mac_anti_spoof_cache_list_inner")]
    public partial class ShowStatusMacAntiSpoofCacheListInner : IEquatable<ShowStatusMacAntiSpoofCacheListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusMacAntiSpoofCacheListInner" /> class.
        /// </summary>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="type">type.</param>
        /// <param name="editable">editable.</param>
        /// <param name="varInterface">varInterface.</param>
        /// <param name="macAddress">macAddress.</param>
        /// <param name="vendor">vendor.</param>
        /// <param name="hostName">hostName.</param>
        /// <param name="router">router.</param>
        /// <param name="blacklisted">blacklisted.</param>
        /// <param name="trafficPktsMatched">trafficPktsMatched.</param>
        /// <param name="trafficPktsMatchedAnyIp">trafficPktsMatchedAnyIp.</param>
        /// <param name="trafficPktsDropped">trafficPktsDropped.</param>
        public ShowStatusMacAntiSpoofCacheListInner(string ipAddress = default(string), string type = default(string), string editable = default(string), string varInterface = default(string), string macAddress = default(string), string vendor = default(string), string hostName = default(string), string router = default(string), string blacklisted = default(string), string trafficPktsMatched = default(string), string trafficPktsMatchedAnyIp = default(string), string trafficPktsDropped = default(string))
        {
            this.IpAddress = ipAddress;
            this.Type = type;
            this.Editable = editable;
            this.VarInterface = varInterface;
            this.MacAddress = macAddress;
            this.Vendor = vendor;
            this.HostName = hostName;
            this.Router = router;
            this.Blacklisted = blacklisted;
            this.TrafficPktsMatched = trafficPktsMatched;
            this.TrafficPktsMatchedAnyIp = trafficPktsMatchedAnyIp;
            this.TrafficPktsDropped = trafficPktsDropped;
        }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ip_address", EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Editable
        /// </summary>
        [DataMember(Name = "editable", EmitDefaultValue = false)]
        public string Editable { get; set; }

        /// <summary>
        /// Gets or Sets VarInterface
        /// </summary>
        [DataMember(Name = "interface", EmitDefaultValue = false)]
        public string VarInterface { get; set; }

        /// <summary>
        /// Gets or Sets MacAddress
        /// </summary>
        [DataMember(Name = "mac_address", EmitDefaultValue = false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or Sets HostName
        /// </summary>
        [DataMember(Name = "host_name", EmitDefaultValue = false)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets Router
        /// </summary>
        [DataMember(Name = "router", EmitDefaultValue = false)]
        public string Router { get; set; }

        /// <summary>
        /// Gets or Sets Blacklisted
        /// </summary>
        [DataMember(Name = "blacklisted", EmitDefaultValue = false)]
        public string Blacklisted { get; set; }

        /// <summary>
        /// Gets or Sets TrafficPktsMatched
        /// </summary>
        [DataMember(Name = "traffic_pkts_matched", EmitDefaultValue = false)]
        public string TrafficPktsMatched { get; set; }

        /// <summary>
        /// Gets or Sets TrafficPktsMatchedAnyIp
        /// </summary>
        [DataMember(Name = "traffic_pkts_matched_any_ip", EmitDefaultValue = false)]
        public string TrafficPktsMatchedAnyIp { get; set; }

        /// <summary>
        /// Gets or Sets TrafficPktsDropped
        /// </summary>
        [DataMember(Name = "traffic_pkts_dropped", EmitDefaultValue = false)]
        public string TrafficPktsDropped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusMacAntiSpoofCacheListInner {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  VarInterface: ").Append(VarInterface).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  Router: ").Append(Router).Append("\n");
            sb.Append("  Blacklisted: ").Append(Blacklisted).Append("\n");
            sb.Append("  TrafficPktsMatched: ").Append(TrafficPktsMatched).Append("\n");
            sb.Append("  TrafficPktsMatchedAnyIp: ").Append(TrafficPktsMatchedAnyIp).Append("\n");
            sb.Append("  TrafficPktsDropped: ").Append(TrafficPktsDropped).Append("\n");
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
            return this.Equals(input as ShowStatusMacAntiSpoofCacheListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusMacAntiSpoofCacheListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusMacAntiSpoofCacheListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusMacAntiSpoofCacheListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Editable == input.Editable ||
                    (this.Editable != null &&
                    this.Editable.Equals(input.Editable))
                ) && 
                (
                    this.VarInterface == input.VarInterface ||
                    (this.VarInterface != null &&
                    this.VarInterface.Equals(input.VarInterface))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Router == input.Router ||
                    (this.Router != null &&
                    this.Router.Equals(input.Router))
                ) && 
                (
                    this.Blacklisted == input.Blacklisted ||
                    (this.Blacklisted != null &&
                    this.Blacklisted.Equals(input.Blacklisted))
                ) && 
                (
                    this.TrafficPktsMatched == input.TrafficPktsMatched ||
                    (this.TrafficPktsMatched != null &&
                    this.TrafficPktsMatched.Equals(input.TrafficPktsMatched))
                ) && 
                (
                    this.TrafficPktsMatchedAnyIp == input.TrafficPktsMatchedAnyIp ||
                    (this.TrafficPktsMatchedAnyIp != null &&
                    this.TrafficPktsMatchedAnyIp.Equals(input.TrafficPktsMatchedAnyIp))
                ) && 
                (
                    this.TrafficPktsDropped == input.TrafficPktsDropped ||
                    (this.TrafficPktsDropped != null &&
                    this.TrafficPktsDropped.Equals(input.TrafficPktsDropped))
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
                if (this.IpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddress.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Editable != null)
                {
                    hashCode = (hashCode * 59) + this.Editable.GetHashCode();
                }
                if (this.VarInterface != null)
                {
                    hashCode = (hashCode * 59) + this.VarInterface.GetHashCode();
                }
                if (this.MacAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MacAddress.GetHashCode();
                }
                if (this.Vendor != null)
                {
                    hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                }
                if (this.HostName != null)
                {
                    hashCode = (hashCode * 59) + this.HostName.GetHashCode();
                }
                if (this.Router != null)
                {
                    hashCode = (hashCode * 59) + this.Router.GetHashCode();
                }
                if (this.Blacklisted != null)
                {
                    hashCode = (hashCode * 59) + this.Blacklisted.GetHashCode();
                }
                if (this.TrafficPktsMatched != null)
                {
                    hashCode = (hashCode * 59) + this.TrafficPktsMatched.GetHashCode();
                }
                if (this.TrafficPktsMatchedAnyIp != null)
                {
                    hashCode = (hashCode * 59) + this.TrafficPktsMatchedAnyIp.GetHashCode();
                }
                if (this.TrafficPktsDropped != null)
                {
                    hashCode = (hashCode * 59) + this.TrafficPktsDropped.GetHashCode();
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
