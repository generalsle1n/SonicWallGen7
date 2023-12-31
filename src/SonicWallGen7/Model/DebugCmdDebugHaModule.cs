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
    /// cofigure different ha debug option.
    /// </summary>
    [DataContract(Name = "debug_cmd_debug_ha_module")]
    public partial class DebugCmdDebugHaModule : IEquatable<DebugCmdDebugHaModule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugCmdDebugHaModule" /> class.
        /// </summary>
        /// <param name="statemachine">enable ha statemachine debug.</param>
        /// <param name="varEvent">enable ha event debug.</param>
        /// <param name="recvpkt">enable ha receiving packet debug.</param>
        /// <param name="incomingpkt">enable ha incoming pkt debug.</param>
        /// <param name="outgoingpkt">enable ha outgoingpkt debug.</param>
        /// <param name="cgi">enable ha cgi debug.</param>
        /// <param name="policy">enable ha policy debug.</param>
        /// <param name="timer">enable ha timer debug.</param>
        /// <param name="http">enable ha http debug.</param>
        /// <param name="monitoring">enable ha monitoring debug.</param>
        /// <param name="arp">enable ha arp debug.</param>
        /// <param name="svrrppkt">enable ha svrrp packet debug.</param>
        /// <param name="svrrpstatemachine">enable ha svrrp state machine debug.</param>
        /// <param name="svrrpgrpowner">enable ha svrrp group owner debug.</param>
        /// <param name="ipv6">enable ha ipv6 debug.</param>
        /// <param name="taskctx">enable ha task context debug.</param>
        /// <param name="encryption">enable ha encryption debug.</param>
        /// <param name="all">enable all debug.</param>
        public DebugCmdDebugHaModule(bool statemachine = default(bool), bool varEvent = default(bool), bool recvpkt = default(bool), bool incomingpkt = default(bool), bool outgoingpkt = default(bool), bool cgi = default(bool), bool policy = default(bool), bool timer = default(bool), bool http = default(bool), bool monitoring = default(bool), bool arp = default(bool), bool svrrppkt = default(bool), bool svrrpstatemachine = default(bool), bool svrrpgrpowner = default(bool), bool ipv6 = default(bool), bool taskctx = default(bool), bool encryption = default(bool), bool all = default(bool))
        {
            this.Statemachine = statemachine;
            this.VarEvent = varEvent;
            this.Recvpkt = recvpkt;
            this.Incomingpkt = incomingpkt;
            this.Outgoingpkt = outgoingpkt;
            this.Cgi = cgi;
            this.Policy = policy;
            this.Timer = timer;
            this.Http = http;
            this.Monitoring = monitoring;
            this.Arp = arp;
            this.Svrrppkt = svrrppkt;
            this.Svrrpstatemachine = svrrpstatemachine;
            this.Svrrpgrpowner = svrrpgrpowner;
            this.Ipv6 = ipv6;
            this.Taskctx = taskctx;
            this.Encryption = encryption;
            this.All = all;
        }

        /// <summary>
        /// enable ha statemachine debug
        /// </summary>
        /// <value>enable ha statemachine debug</value>
        [DataMember(Name = "statemachine", EmitDefaultValue = true)]
        public bool Statemachine { get; set; }

        /// <summary>
        /// enable ha event debug
        /// </summary>
        /// <value>enable ha event debug</value>
        [DataMember(Name = "event", EmitDefaultValue = true)]
        public bool VarEvent { get; set; }

        /// <summary>
        /// enable ha receiving packet debug
        /// </summary>
        /// <value>enable ha receiving packet debug</value>
        [DataMember(Name = "recvpkt", EmitDefaultValue = true)]
        public bool Recvpkt { get; set; }

        /// <summary>
        /// enable ha incoming pkt debug
        /// </summary>
        /// <value>enable ha incoming pkt debug</value>
        [DataMember(Name = "incomingpkt", EmitDefaultValue = true)]
        public bool Incomingpkt { get; set; }

        /// <summary>
        /// enable ha outgoingpkt debug
        /// </summary>
        /// <value>enable ha outgoingpkt debug</value>
        [DataMember(Name = "outgoingpkt", EmitDefaultValue = true)]
        public bool Outgoingpkt { get; set; }

        /// <summary>
        /// enable ha cgi debug
        /// </summary>
        /// <value>enable ha cgi debug</value>
        [DataMember(Name = "cgi", EmitDefaultValue = true)]
        public bool Cgi { get; set; }

        /// <summary>
        /// enable ha policy debug
        /// </summary>
        /// <value>enable ha policy debug</value>
        [DataMember(Name = "policy", EmitDefaultValue = true)]
        public bool Policy { get; set; }

        /// <summary>
        /// enable ha timer debug
        /// </summary>
        /// <value>enable ha timer debug</value>
        [DataMember(Name = "timer", EmitDefaultValue = true)]
        public bool Timer { get; set; }

        /// <summary>
        /// enable ha http debug
        /// </summary>
        /// <value>enable ha http debug</value>
        [DataMember(Name = "http", EmitDefaultValue = true)]
        public bool Http { get; set; }

        /// <summary>
        /// enable ha monitoring debug
        /// </summary>
        /// <value>enable ha monitoring debug</value>
        [DataMember(Name = "monitoring", EmitDefaultValue = true)]
        public bool Monitoring { get; set; }

        /// <summary>
        /// enable ha arp debug
        /// </summary>
        /// <value>enable ha arp debug</value>
        [DataMember(Name = "arp", EmitDefaultValue = true)]
        public bool Arp { get; set; }

        /// <summary>
        /// enable ha svrrp packet debug
        /// </summary>
        /// <value>enable ha svrrp packet debug</value>
        [DataMember(Name = "svrrppkt", EmitDefaultValue = true)]
        public bool Svrrppkt { get; set; }

        /// <summary>
        /// enable ha svrrp state machine debug
        /// </summary>
        /// <value>enable ha svrrp state machine debug</value>
        [DataMember(Name = "svrrpstatemachine", EmitDefaultValue = true)]
        public bool Svrrpstatemachine { get; set; }

        /// <summary>
        /// enable ha svrrp group owner debug
        /// </summary>
        /// <value>enable ha svrrp group owner debug</value>
        [DataMember(Name = "svrrpgrpowner", EmitDefaultValue = true)]
        public bool Svrrpgrpowner { get; set; }

        /// <summary>
        /// enable ha ipv6 debug
        /// </summary>
        /// <value>enable ha ipv6 debug</value>
        [DataMember(Name = "ipv6", EmitDefaultValue = true)]
        public bool Ipv6 { get; set; }

        /// <summary>
        /// enable ha task context debug
        /// </summary>
        /// <value>enable ha task context debug</value>
        [DataMember(Name = "taskctx", EmitDefaultValue = true)]
        public bool Taskctx { get; set; }

        /// <summary>
        /// enable ha encryption debug
        /// </summary>
        /// <value>enable ha encryption debug</value>
        [DataMember(Name = "encryption", EmitDefaultValue = true)]
        public bool Encryption { get; set; }

        /// <summary>
        /// enable all debug
        /// </summary>
        /// <value>enable all debug</value>
        [DataMember(Name = "all", EmitDefaultValue = true)]
        public bool All { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DebugCmdDebugHaModule {\n");
            sb.Append("  Statemachine: ").Append(Statemachine).Append("\n");
            sb.Append("  VarEvent: ").Append(VarEvent).Append("\n");
            sb.Append("  Recvpkt: ").Append(Recvpkt).Append("\n");
            sb.Append("  Incomingpkt: ").Append(Incomingpkt).Append("\n");
            sb.Append("  Outgoingpkt: ").Append(Outgoingpkt).Append("\n");
            sb.Append("  Cgi: ").Append(Cgi).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Timer: ").Append(Timer).Append("\n");
            sb.Append("  Http: ").Append(Http).Append("\n");
            sb.Append("  Monitoring: ").Append(Monitoring).Append("\n");
            sb.Append("  Arp: ").Append(Arp).Append("\n");
            sb.Append("  Svrrppkt: ").Append(Svrrppkt).Append("\n");
            sb.Append("  Svrrpstatemachine: ").Append(Svrrpstatemachine).Append("\n");
            sb.Append("  Svrrpgrpowner: ").Append(Svrrpgrpowner).Append("\n");
            sb.Append("  Ipv6: ").Append(Ipv6).Append("\n");
            sb.Append("  Taskctx: ").Append(Taskctx).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
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
            return this.Equals(input as DebugCmdDebugHaModule);
        }

        /// <summary>
        /// Returns true if DebugCmdDebugHaModule instances are equal
        /// </summary>
        /// <param name="input">Instance of DebugCmdDebugHaModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebugCmdDebugHaModule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Statemachine == input.Statemachine ||
                    this.Statemachine.Equals(input.Statemachine)
                ) && 
                (
                    this.VarEvent == input.VarEvent ||
                    this.VarEvent.Equals(input.VarEvent)
                ) && 
                (
                    this.Recvpkt == input.Recvpkt ||
                    this.Recvpkt.Equals(input.Recvpkt)
                ) && 
                (
                    this.Incomingpkt == input.Incomingpkt ||
                    this.Incomingpkt.Equals(input.Incomingpkt)
                ) && 
                (
                    this.Outgoingpkt == input.Outgoingpkt ||
                    this.Outgoingpkt.Equals(input.Outgoingpkt)
                ) && 
                (
                    this.Cgi == input.Cgi ||
                    this.Cgi.Equals(input.Cgi)
                ) && 
                (
                    this.Policy == input.Policy ||
                    this.Policy.Equals(input.Policy)
                ) && 
                (
                    this.Timer == input.Timer ||
                    this.Timer.Equals(input.Timer)
                ) && 
                (
                    this.Http == input.Http ||
                    this.Http.Equals(input.Http)
                ) && 
                (
                    this.Monitoring == input.Monitoring ||
                    this.Monitoring.Equals(input.Monitoring)
                ) && 
                (
                    this.Arp == input.Arp ||
                    this.Arp.Equals(input.Arp)
                ) && 
                (
                    this.Svrrppkt == input.Svrrppkt ||
                    this.Svrrppkt.Equals(input.Svrrppkt)
                ) && 
                (
                    this.Svrrpstatemachine == input.Svrrpstatemachine ||
                    this.Svrrpstatemachine.Equals(input.Svrrpstatemachine)
                ) && 
                (
                    this.Svrrpgrpowner == input.Svrrpgrpowner ||
                    this.Svrrpgrpowner.Equals(input.Svrrpgrpowner)
                ) && 
                (
                    this.Ipv6 == input.Ipv6 ||
                    this.Ipv6.Equals(input.Ipv6)
                ) && 
                (
                    this.Taskctx == input.Taskctx ||
                    this.Taskctx.Equals(input.Taskctx)
                ) && 
                (
                    this.Encryption == input.Encryption ||
                    this.Encryption.Equals(input.Encryption)
                ) && 
                (
                    this.All == input.All ||
                    this.All.Equals(input.All)
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
                hashCode = (hashCode * 59) + this.Statemachine.GetHashCode();
                hashCode = (hashCode * 59) + this.VarEvent.GetHashCode();
                hashCode = (hashCode * 59) + this.Recvpkt.GetHashCode();
                hashCode = (hashCode * 59) + this.Incomingpkt.GetHashCode();
                hashCode = (hashCode * 59) + this.Outgoingpkt.GetHashCode();
                hashCode = (hashCode * 59) + this.Cgi.GetHashCode();
                hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                hashCode = (hashCode * 59) + this.Timer.GetHashCode();
                hashCode = (hashCode * 59) + this.Http.GetHashCode();
                hashCode = (hashCode * 59) + this.Monitoring.GetHashCode();
                hashCode = (hashCode * 59) + this.Arp.GetHashCode();
                hashCode = (hashCode * 59) + this.Svrrppkt.GetHashCode();
                hashCode = (hashCode * 59) + this.Svrrpstatemachine.GetHashCode();
                hashCode = (hashCode * 59) + this.Svrrpgrpowner.GetHashCode();
                hashCode = (hashCode * 59) + this.Ipv6.GetHashCode();
                hashCode = (hashCode * 59) + this.Taskctx.GetHashCode();
                hashCode = (hashCode * 59) + this.Encryption.GetHashCode();
                hashCode = (hashCode * 59) + this.All.GetHashCode();
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
