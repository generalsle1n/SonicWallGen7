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
    /// TCP bitset.
    /// </summary>
    [DataContract(Name = "packet_dissection_object_data_type_tcp_bitset_tcp_bitset")]
    public partial class PacketDissectionObjectDataTypeTcpBitsetTcpBitset : IEquatable<PacketDissectionObjectDataTypeTcpBitsetTcpBitset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketDissectionObjectDataTypeTcpBitsetTcpBitset" /> class.
        /// </summary>
        /// <param name="fin">Enable FIN in bitset..</param>
        /// <param name="syn">Enable SYN in bitset..</param>
        /// <param name="rst">Enable RST in bitset..</param>
        /// <param name="push">Enable PUSH in bitset..</param>
        /// <param name="ack">Enable ACK in bitset..</param>
        /// <param name="urg">Enable URG in bitset..</param>
        /// <param name="ece">Enable ECE in bitset..</param>
        /// <param name="cwr">Enable CWR in bitset..</param>
        public PacketDissectionObjectDataTypeTcpBitsetTcpBitset(bool fin = default(bool), bool syn = default(bool), bool rst = default(bool), bool push = default(bool), bool ack = default(bool), bool urg = default(bool), bool ece = default(bool), bool cwr = default(bool))
        {
            this.Fin = fin;
            this.Syn = syn;
            this.Rst = rst;
            this.Push = push;
            this.Ack = ack;
            this.Urg = urg;
            this.Ece = ece;
            this.Cwr = cwr;
        }

        /// <summary>
        /// Enable FIN in bitset.
        /// </summary>
        /// <value>Enable FIN in bitset.</value>
        [DataMember(Name = "fin", EmitDefaultValue = true)]
        public bool Fin { get; set; }

        /// <summary>
        /// Enable SYN in bitset.
        /// </summary>
        /// <value>Enable SYN in bitset.</value>
        [DataMember(Name = "syn", EmitDefaultValue = true)]
        public bool Syn { get; set; }

        /// <summary>
        /// Enable RST in bitset.
        /// </summary>
        /// <value>Enable RST in bitset.</value>
        [DataMember(Name = "rst", EmitDefaultValue = true)]
        public bool Rst { get; set; }

        /// <summary>
        /// Enable PUSH in bitset.
        /// </summary>
        /// <value>Enable PUSH in bitset.</value>
        [DataMember(Name = "push", EmitDefaultValue = true)]
        public bool Push { get; set; }

        /// <summary>
        /// Enable ACK in bitset.
        /// </summary>
        /// <value>Enable ACK in bitset.</value>
        [DataMember(Name = "ack", EmitDefaultValue = true)]
        public bool Ack { get; set; }

        /// <summary>
        /// Enable URG in bitset.
        /// </summary>
        /// <value>Enable URG in bitset.</value>
        [DataMember(Name = "urg", EmitDefaultValue = true)]
        public bool Urg { get; set; }

        /// <summary>
        /// Enable ECE in bitset.
        /// </summary>
        /// <value>Enable ECE in bitset.</value>
        [DataMember(Name = "ece", EmitDefaultValue = true)]
        public bool Ece { get; set; }

        /// <summary>
        /// Enable CWR in bitset.
        /// </summary>
        /// <value>Enable CWR in bitset.</value>
        [DataMember(Name = "cwr", EmitDefaultValue = true)]
        public bool Cwr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketDissectionObjectDataTypeTcpBitsetTcpBitset {\n");
            sb.Append("  Fin: ").Append(Fin).Append("\n");
            sb.Append("  Syn: ").Append(Syn).Append("\n");
            sb.Append("  Rst: ").Append(Rst).Append("\n");
            sb.Append("  Push: ").Append(Push).Append("\n");
            sb.Append("  Ack: ").Append(Ack).Append("\n");
            sb.Append("  Urg: ").Append(Urg).Append("\n");
            sb.Append("  Ece: ").Append(Ece).Append("\n");
            sb.Append("  Cwr: ").Append(Cwr).Append("\n");
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
            return this.Equals(input as PacketDissectionObjectDataTypeTcpBitsetTcpBitset);
        }

        /// <summary>
        /// Returns true if PacketDissectionObjectDataTypeTcpBitsetTcpBitset instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketDissectionObjectDataTypeTcpBitsetTcpBitset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketDissectionObjectDataTypeTcpBitsetTcpBitset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Fin == input.Fin ||
                    this.Fin.Equals(input.Fin)
                ) && 
                (
                    this.Syn == input.Syn ||
                    this.Syn.Equals(input.Syn)
                ) && 
                (
                    this.Rst == input.Rst ||
                    this.Rst.Equals(input.Rst)
                ) && 
                (
                    this.Push == input.Push ||
                    this.Push.Equals(input.Push)
                ) && 
                (
                    this.Ack == input.Ack ||
                    this.Ack.Equals(input.Ack)
                ) && 
                (
                    this.Urg == input.Urg ||
                    this.Urg.Equals(input.Urg)
                ) && 
                (
                    this.Ece == input.Ece ||
                    this.Ece.Equals(input.Ece)
                ) && 
                (
                    this.Cwr == input.Cwr ||
                    this.Cwr.Equals(input.Cwr)
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
                hashCode = (hashCode * 59) + this.Fin.GetHashCode();
                hashCode = (hashCode * 59) + this.Syn.GetHashCode();
                hashCode = (hashCode * 59) + this.Rst.GetHashCode();
                hashCode = (hashCode * 59) + this.Push.GetHashCode();
                hashCode = (hashCode * 59) + this.Ack.GetHashCode();
                hashCode = (hashCode * 59) + this.Urg.GetHashCode();
                hashCode = (hashCode * 59) + this.Ece.GetHashCode();
                hashCode = (hashCode * 59) + this.Cwr.GetHashCode();
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
