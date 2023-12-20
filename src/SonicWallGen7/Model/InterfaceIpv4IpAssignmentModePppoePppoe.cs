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
    /// Interface uses point to point protocol over ethernet.
    /// </summary>
    [DataContract(Name = "interface_ipv4_ip_assignment_mode_pppoe_pppoe")]
    public partial class InterfaceIpv4IpAssignmentModePppoePppoe : IEquatable<InterfaceIpv4IpAssignmentModePppoePppoe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv4IpAssignmentModePppoePppoe" /> class.
        /// </summary>
        /// <param name="dynamic">Enable dynamic acquisition of IP configuration data..</param>
        /// <param name="unnumbered">Enable unnumbered interface..</param>
        /// <param name="inactivity">Enable the PPPoE inactivity timer..</param>
        /// <param name="ip">Set PPPoE IP address..</param>
        /// <param name="lcpEchoPackets">Enable strictly use LCP echo packets for server keep-alive..</param>
        /// <param name="password">Set PPPoE user password..</param>
        /// <param name="serviceName">Set PPPoE service Name..</param>
        /// <param name="reconnect">Enable and set reconnect the PPPoE client if the server does not send traffic for specified minutes..</param>
        /// <param name="userName">Set PPPoE user name..</param>
        /// <param name="ncpNegRetrans">Set the retransmission time during NCP negotiation.</param>
        /// <param name="schedule">schedule.</param>
        public InterfaceIpv4IpAssignmentModePppoePppoe(bool dynamic = default(bool), string unnumbered = default(string), decimal inactivity = default(decimal), string ip = default(string), bool lcpEchoPackets = default(bool), string password = default(string), string serviceName = default(string), decimal reconnect = default(decimal), string userName = default(string), decimal ncpNegRetrans = default(decimal), InterfaceIpv4IpAssignmentModePppoePppoeSchedule schedule = default(InterfaceIpv4IpAssignmentModePppoePppoeSchedule))
        {
            this.Dynamic = dynamic;
            this.Unnumbered = unnumbered;
            this.Inactivity = inactivity;
            this.Ip = ip;
            this.LcpEchoPackets = lcpEchoPackets;
            this.Password = password;
            this.ServiceName = serviceName;
            this.Reconnect = reconnect;
            this.UserName = userName;
            this.NcpNegRetrans = ncpNegRetrans;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Enable dynamic acquisition of IP configuration data.
        /// </summary>
        /// <value>Enable dynamic acquisition of IP configuration data.</value>
        [DataMember(Name = "dynamic", EmitDefaultValue = true)]
        public bool Dynamic { get; set; }

        /// <summary>
        /// Enable unnumbered interface.
        /// </summary>
        /// <value>Enable unnumbered interface.</value>
        [DataMember(Name = "unnumbered", EmitDefaultValue = false)]
        public string Unnumbered { get; set; }

        /// <summary>
        /// Enable the PPPoE inactivity timer.
        /// </summary>
        /// <value>Enable the PPPoE inactivity timer.</value>
        [DataMember(Name = "inactivity", EmitDefaultValue = false)]
        public decimal Inactivity { get; set; }

        /// <summary>
        /// Set PPPoE IP address.
        /// </summary>
        /// <value>Set PPPoE IP address.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Enable strictly use LCP echo packets for server keep-alive.
        /// </summary>
        /// <value>Enable strictly use LCP echo packets for server keep-alive.</value>
        [DataMember(Name = "lcp_echo_packets", EmitDefaultValue = true)]
        public bool LcpEchoPackets { get; set; }

        /// <summary>
        /// Set PPPoE user password.
        /// </summary>
        /// <value>Set PPPoE user password.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Set PPPoE service Name.
        /// </summary>
        /// <value>Set PPPoE service Name.</value>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Enable and set reconnect the PPPoE client if the server does not send traffic for specified minutes.
        /// </summary>
        /// <value>Enable and set reconnect the PPPoE client if the server does not send traffic for specified minutes.</value>
        [DataMember(Name = "reconnect", EmitDefaultValue = false)]
        public decimal Reconnect { get; set; }

        /// <summary>
        /// Set PPPoE user name.
        /// </summary>
        /// <value>Set PPPoE user name.</value>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Set the retransmission time during NCP negotiation
        /// </summary>
        /// <value>Set the retransmission time during NCP negotiation</value>
        [DataMember(Name = "ncp_neg_retrans", EmitDefaultValue = false)]
        public decimal NcpNegRetrans { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public InterfaceIpv4IpAssignmentModePppoePppoeSchedule Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv4IpAssignmentModePppoePppoe {\n");
            sb.Append("  Dynamic: ").Append(Dynamic).Append("\n");
            sb.Append("  Unnumbered: ").Append(Unnumbered).Append("\n");
            sb.Append("  Inactivity: ").Append(Inactivity).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  LcpEchoPackets: ").Append(LcpEchoPackets).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Reconnect: ").Append(Reconnect).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  NcpNegRetrans: ").Append(NcpNegRetrans).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as InterfaceIpv4IpAssignmentModePppoePppoe);
        }

        /// <summary>
        /// Returns true if InterfaceIpv4IpAssignmentModePppoePppoe instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv4IpAssignmentModePppoePppoe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv4IpAssignmentModePppoePppoe input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Dynamic == input.Dynamic ||
                    this.Dynamic.Equals(input.Dynamic)
                ) && 
                (
                    this.Unnumbered == input.Unnumbered ||
                    (this.Unnumbered != null &&
                    this.Unnumbered.Equals(input.Unnumbered))
                ) && 
                (
                    this.Inactivity == input.Inactivity ||
                    this.Inactivity.Equals(input.Inactivity)
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.LcpEchoPackets == input.LcpEchoPackets ||
                    this.LcpEchoPackets.Equals(input.LcpEchoPackets)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Reconnect == input.Reconnect ||
                    this.Reconnect.Equals(input.Reconnect)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.NcpNegRetrans == input.NcpNegRetrans ||
                    this.NcpNegRetrans.Equals(input.NcpNegRetrans)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                hashCode = (hashCode * 59) + this.Dynamic.GetHashCode();
                if (this.Unnumbered != null)
                {
                    hashCode = (hashCode * 59) + this.Unnumbered.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Inactivity.GetHashCode();
                if (this.Ip != null)
                {
                    hashCode = (hashCode * 59) + this.Ip.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LcpEchoPackets.GetHashCode();
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Reconnect.GetHashCode();
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NcpNegRetrans.GetHashCode();
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
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