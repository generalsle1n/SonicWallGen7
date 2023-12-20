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
    /// action-val for packet crafting using buffer
    /// </summary>
    [DataContract(Name = "packet_replay_packet_crafting_buffer_packet_replay_packet_crafting_buffer_action_val")]
    public partial class PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal : IEquatable<PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal" /> class.
        /// </summary>
        /// <param name="destIface">Enter destination interface * Set to null to represent an unconfigured state..</param>
        /// <param name="payload">Enter Payload * Set to null to represent an unconfigured state..</param>
        public PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal(decimal? destIface = default(decimal?), string payload = default(string))
        {
            this.DestIface = destIface;
            this.Payload = payload;
        }

        /// <summary>
        /// Enter destination interface * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Enter destination interface * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "dest_iface", EmitDefaultValue = true)]
        public decimal? DestIface { get; set; }

        /// <summary>
        /// Enter Payload * Set to null to represent an unconfigured state.
        /// </summary>
        /// <value>Enter Payload * Set to null to represent an unconfigured state.</value>
        [DataMember(Name = "payload", EmitDefaultValue = true)]
        public string Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal {\n");
            sb.Append("  DestIface: ").Append(DestIface).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal);
        }

        /// <summary>
        /// Returns true if PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal instances are equal
        /// </summary>
        /// <param name="input">Instance of PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacketReplayPacketCraftingBufferPacketReplayPacketCraftingBufferActionVal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DestIface == input.DestIface ||
                    (this.DestIface != null &&
                    this.DestIface.Equals(input.DestIface))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
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
                if (this.DestIface != null)
                {
                    hashCode = (hashCode * 59) + this.DestIface.GetHashCode();
                }
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
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
