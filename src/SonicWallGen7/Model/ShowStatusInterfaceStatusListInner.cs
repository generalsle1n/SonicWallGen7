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
    /// ShowStatusInterfaceStatusListInner
    /// </summary>
    [DataContract(Name = "show_status_interface_status_list_inner")]
    public partial class ShowStatusInterfaceStatusListInner : IEquatable<ShowStatusInterfaceStatusListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusInterfaceStatusListInner" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="zone">zone.</param>
        /// <param name="type">type.</param>
        /// <param name="ipMode">ipMode.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="subnetMask">subnetMask.</param>
        /// <param name="connected">connected.</param>
        /// <param name="status">status.</param>
        /// <param name="linkSetting">linkSetting.</param>
        /// <param name="linkIsgigbit">linkIsgigbit.</param>
        /// <param name="linkAbilityBmpLow">linkAbilityBmpLow.</param>
        /// <param name="linkAbilityBmpHigh">linkAbilityBmpHigh.</param>
        /// <param name="group">group.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="configurable">configurable.</param>
        /// <param name="deletable">deletable.</param>
        /// <param name="comment">comment.</param>
        public ShowStatusInterfaceStatusListInner(string name = default(string), string zone = default(string), string type = default(string), string ipMode = default(string), string ipAddress = default(string), string subnetMask = default(string), string connected = default(string), string status = default(string), string linkSetting = default(string), string linkIsgigbit = default(string), string linkAbilityBmpLow = default(string), string linkAbilityBmpHigh = default(string), string group = default(string), string enabled = default(string), string configurable = default(string), string deletable = default(string), string comment = default(string))
        {
            this.Name = name;
            this.Zone = zone;
            this.Type = type;
            this.IpMode = ipMode;
            this.IpAddress = ipAddress;
            this.SubnetMask = subnetMask;
            this.Connected = connected;
            this.Status = status;
            this.LinkSetting = linkSetting;
            this.LinkIsgigbit = linkIsgigbit;
            this.LinkAbilityBmpLow = linkAbilityBmpLow;
            this.LinkAbilityBmpHigh = linkAbilityBmpHigh;
            this.Group = group;
            this.Enabled = enabled;
            this.Configurable = configurable;
            this.Deletable = deletable;
            this.Comment = comment;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Zone
        /// </summary>
        [DataMember(Name = "zone", EmitDefaultValue = false)]
        public string Zone { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IpMode
        /// </summary>
        [DataMember(Name = "ip_mode", EmitDefaultValue = false)]
        public string IpMode { get; set; }

        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name = "ip_address", EmitDefaultValue = false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or Sets SubnetMask
        /// </summary>
        [DataMember(Name = "subnet_mask", EmitDefaultValue = false)]
        public string SubnetMask { get; set; }

        /// <summary>
        /// Gets or Sets Connected
        /// </summary>
        [DataMember(Name = "connected", EmitDefaultValue = false)]
        public string Connected { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets LinkSetting
        /// </summary>
        [DataMember(Name = "link_setting", EmitDefaultValue = false)]
        public string LinkSetting { get; set; }

        /// <summary>
        /// Gets or Sets LinkIsgigbit
        /// </summary>
        [DataMember(Name = "link_isgigbit", EmitDefaultValue = false)]
        public string LinkIsgigbit { get; set; }

        /// <summary>
        /// Gets or Sets LinkAbilityBmpLow
        /// </summary>
        [DataMember(Name = "link_ability_bmp_low", EmitDefaultValue = false)]
        public string LinkAbilityBmpLow { get; set; }

        /// <summary>
        /// Gets or Sets LinkAbilityBmpHigh
        /// </summary>
        [DataMember(Name = "link_ability_bmp_high", EmitDefaultValue = false)]
        public string LinkAbilityBmpHigh { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public string Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Configurable
        /// </summary>
        [DataMember(Name = "configurable", EmitDefaultValue = false)]
        public string Configurable { get; set; }

        /// <summary>
        /// Gets or Sets Deletable
        /// </summary>
        [DataMember(Name = "deletable", EmitDefaultValue = false)]
        public string Deletable { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusInterfaceStatusListInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Zone: ").Append(Zone).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IpMode: ").Append(IpMode).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  SubnetMask: ").Append(SubnetMask).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LinkSetting: ").Append(LinkSetting).Append("\n");
            sb.Append("  LinkIsgigbit: ").Append(LinkIsgigbit).Append("\n");
            sb.Append("  LinkAbilityBmpLow: ").Append(LinkAbilityBmpLow).Append("\n");
            sb.Append("  LinkAbilityBmpHigh: ").Append(LinkAbilityBmpHigh).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Configurable: ").Append(Configurable).Append("\n");
            sb.Append("  Deletable: ").Append(Deletable).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as ShowStatusInterfaceStatusListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusInterfaceStatusListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusInterfaceStatusListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusInterfaceStatusListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Zone == input.Zone ||
                    (this.Zone != null &&
                    this.Zone.Equals(input.Zone))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IpMode == input.IpMode ||
                    (this.IpMode != null &&
                    this.IpMode.Equals(input.IpMode))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.SubnetMask == input.SubnetMask ||
                    (this.SubnetMask != null &&
                    this.SubnetMask.Equals(input.SubnetMask))
                ) && 
                (
                    this.Connected == input.Connected ||
                    (this.Connected != null &&
                    this.Connected.Equals(input.Connected))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LinkSetting == input.LinkSetting ||
                    (this.LinkSetting != null &&
                    this.LinkSetting.Equals(input.LinkSetting))
                ) && 
                (
                    this.LinkIsgigbit == input.LinkIsgigbit ||
                    (this.LinkIsgigbit != null &&
                    this.LinkIsgigbit.Equals(input.LinkIsgigbit))
                ) && 
                (
                    this.LinkAbilityBmpLow == input.LinkAbilityBmpLow ||
                    (this.LinkAbilityBmpLow != null &&
                    this.LinkAbilityBmpLow.Equals(input.LinkAbilityBmpLow))
                ) && 
                (
                    this.LinkAbilityBmpHigh == input.LinkAbilityBmpHigh ||
                    (this.LinkAbilityBmpHigh != null &&
                    this.LinkAbilityBmpHigh.Equals(input.LinkAbilityBmpHigh))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Configurable == input.Configurable ||
                    (this.Configurable != null &&
                    this.Configurable.Equals(input.Configurable))
                ) && 
                (
                    this.Deletable == input.Deletable ||
                    (this.Deletable != null &&
                    this.Deletable.Equals(input.Deletable))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Zone != null)
                {
                    hashCode = (hashCode * 59) + this.Zone.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.IpMode != null)
                {
                    hashCode = (hashCode * 59) + this.IpMode.GetHashCode();
                }
                if (this.IpAddress != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddress.GetHashCode();
                }
                if (this.SubnetMask != null)
                {
                    hashCode = (hashCode * 59) + this.SubnetMask.GetHashCode();
                }
                if (this.Connected != null)
                {
                    hashCode = (hashCode * 59) + this.Connected.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.LinkSetting != null)
                {
                    hashCode = (hashCode * 59) + this.LinkSetting.GetHashCode();
                }
                if (this.LinkIsgigbit != null)
                {
                    hashCode = (hashCode * 59) + this.LinkIsgigbit.GetHashCode();
                }
                if (this.LinkAbilityBmpLow != null)
                {
                    hashCode = (hashCode * 59) + this.LinkAbilityBmpLow.GetHashCode();
                }
                if (this.LinkAbilityBmpHigh != null)
                {
                    hashCode = (hashCode * 59) + this.LinkAbilityBmpHigh.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                if (this.Enabled != null)
                {
                    hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                }
                if (this.Configurable != null)
                {
                    hashCode = (hashCode * 59) + this.Configurable.GetHashCode();
                }
                if (this.Deletable != null)
                {
                    hashCode = (hashCode * 59) + this.Deletable.GetHashCode();
                }
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
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
