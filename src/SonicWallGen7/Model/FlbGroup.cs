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
    /// Failover load balancing group objects configuration schema.
    /// </summary>
    [DataContract(Name = "flb_group")]
    public partial class FlbGroup : IEquatable<FlbGroup>, IValidatableObject
    {
        /// <summary>
        /// Configure failover and load balancing type.
        /// </summary>
        /// <value>Configure failover and load balancing type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Basic for value: basic
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic = 1,

            /// <summary>
            /// Enum RoundRobin for value: round-robin
            /// </summary>
            [EnumMember(Value = "round-robin")]
            RoundRobin = 2,

            /// <summary>
            /// Enum Spillover for value: spillover
            /// </summary>
            [EnumMember(Value = "spillover")]
            Spillover = 3,

            /// <summary>
            /// Enum Ratio for value: ratio
            /// </summary>
            [EnumMember(Value = "ratio")]
            Ratio = 4
        }


        /// <summary>
        /// Configure failover and load balancing type.
        /// </summary>
        /// <value>Configure failover and load balancing type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlbGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlbGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlbGroup" /> class.
        /// </summary>
        /// <param name="name">Edit load balancing group name. (required).</param>
        /// <param name="type">Configure failover and load balancing type..</param>
        /// <param name="preempt">Enable Preempt and failback to preferred member when possible..</param>
        /// <param name="spilloverBandwidth">spilloverBandwidth.</param>
        /// <param name="addressBinding">Enable use source and destination IP address binding..</param>
        /// <param name="finalBackup">Add/Replace final backup interface in load balancing group..</param>
        /// <param name="varInterface">Add/edit interface load balancing group member..</param>
        /// <param name="percent">Set the member usage percent..</param>
        /// <param name="probing">probing.</param>
        public FlbGroup(string name = default(string), TypeEnum? type = default(TypeEnum?), bool preempt = default(bool), FlbGroupSpilloverBandwidth spilloverBandwidth = default(FlbGroupSpilloverBandwidth), bool addressBinding = default(bool), string finalBackup = default(string), List<FlbGroupInterfaceInner> varInterface = default(List<FlbGroupInterfaceInner>), List<FlbGroupPercentInner> percent = default(List<FlbGroupPercentInner>), FlbGroupProbing probing = default(FlbGroupProbing))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FlbGroup and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.Preempt = preempt;
            this.SpilloverBandwidth = spilloverBandwidth;
            this.AddressBinding = addressBinding;
            this.FinalBackup = finalBackup;
            this.VarInterface = varInterface;
            this.Percent = percent;
            this.Probing = probing;
        }

        /// <summary>
        /// Edit load balancing group name.
        /// </summary>
        /// <value>Edit load balancing group name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Enable Preempt and failback to preferred member when possible.
        /// </summary>
        /// <value>Enable Preempt and failback to preferred member when possible.</value>
        [DataMember(Name = "preempt", EmitDefaultValue = true)]
        public bool Preempt { get; set; }

        /// <summary>
        /// Gets or Sets SpilloverBandwidth
        /// </summary>
        [DataMember(Name = "spillover_bandwidth", EmitDefaultValue = true)]
        public FlbGroupSpilloverBandwidth SpilloverBandwidth { get; set; }

        /// <summary>
        /// Enable use source and destination IP address binding.
        /// </summary>
        /// <value>Enable use source and destination IP address binding.</value>
        [DataMember(Name = "address_binding", EmitDefaultValue = true)]
        public bool AddressBinding { get; set; }

        /// <summary>
        /// Add/Replace final backup interface in load balancing group.
        /// </summary>
        /// <value>Add/Replace final backup interface in load balancing group.</value>
        [DataMember(Name = "final_backup", EmitDefaultValue = false)]
        public string FinalBackup { get; set; }

        /// <summary>
        /// Add/edit interface load balancing group member.
        /// </summary>
        /// <value>Add/edit interface load balancing group member.</value>
        [DataMember(Name = "interface", EmitDefaultValue = false)]
        public List<FlbGroupInterfaceInner> VarInterface { get; set; }

        /// <summary>
        /// Set the member usage percent.
        /// </summary>
        /// <value>Set the member usage percent.</value>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public List<FlbGroupPercentInner> Percent { get; set; }

        /// <summary>
        /// Gets or Sets Probing
        /// </summary>
        [DataMember(Name = "probing", EmitDefaultValue = false)]
        public FlbGroupProbing Probing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlbGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Preempt: ").Append(Preempt).Append("\n");
            sb.Append("  SpilloverBandwidth: ").Append(SpilloverBandwidth).Append("\n");
            sb.Append("  AddressBinding: ").Append(AddressBinding).Append("\n");
            sb.Append("  FinalBackup: ").Append(FinalBackup).Append("\n");
            sb.Append("  VarInterface: ").Append(VarInterface).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Probing: ").Append(Probing).Append("\n");
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
            return this.Equals(input as FlbGroup);
        }

        /// <summary>
        /// Returns true if FlbGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of FlbGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlbGroup input)
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Preempt == input.Preempt ||
                    this.Preempt.Equals(input.Preempt)
                ) && 
                (
                    this.SpilloverBandwidth == input.SpilloverBandwidth ||
                    (this.SpilloverBandwidth != null &&
                    this.SpilloverBandwidth.Equals(input.SpilloverBandwidth))
                ) && 
                (
                    this.AddressBinding == input.AddressBinding ||
                    this.AddressBinding.Equals(input.AddressBinding)
                ) && 
                (
                    this.FinalBackup == input.FinalBackup ||
                    (this.FinalBackup != null &&
                    this.FinalBackup.Equals(input.FinalBackup))
                ) && 
                (
                    this.VarInterface == input.VarInterface ||
                    this.VarInterface != null &&
                    input.VarInterface != null &&
                    this.VarInterface.SequenceEqual(input.VarInterface)
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent != null &&
                    input.Percent != null &&
                    this.Percent.SequenceEqual(input.Percent)
                ) && 
                (
                    this.Probing == input.Probing ||
                    (this.Probing != null &&
                    this.Probing.Equals(input.Probing))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Preempt.GetHashCode();
                if (this.SpilloverBandwidth != null)
                {
                    hashCode = (hashCode * 59) + this.SpilloverBandwidth.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AddressBinding.GetHashCode();
                if (this.FinalBackup != null)
                {
                    hashCode = (hashCode * 59) + this.FinalBackup.GetHashCode();
                }
                if (this.VarInterface != null)
                {
                    hashCode = (hashCode * 59) + this.VarInterface.GetHashCode();
                }
                if (this.Percent != null)
                {
                    hashCode = (hashCode * 59) + this.Percent.GetHashCode();
                }
                if (this.Probing != null)
                {
                    hashCode = (hashCode * 59) + this.Probing.GetHashCode();
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