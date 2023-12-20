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
    /// Enter router advertisement configuration mode.
    /// </summary>
    [DataContract(Name = "interface_ipv6_base_ipv6_ip_assignment_mode_static_static_router_advertisement")]
    public partial class InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement : IEquatable<InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement" /> class.
        /// </summary>
        /// <param name="enable">Enable IPv6 router advertisement..</param>
        /// <param name="interval">interval.</param>
        /// <param name="linkMtu">linkMtu.</param>
        /// <param name="reachableTime">reachableTime.</param>
        /// <param name="retransmitTimer">retransmitTimer.</param>
        /// <param name="currentHopLimit">currentHopLimit.</param>
        /// <param name="router">router.</param>
        /// <param name="managed">Enable IPv6 addresses as available via stateful addresses configuration..</param>
        /// <param name="otherConfig">Enable non-address configuration as available via stateful addresses configuration..</param>
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement(bool enable = default(bool), InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval interval = default(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval), InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementLinkMtu linkMtu = default(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementLinkMtu), InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementReachableTime reachableTime = default(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementReachableTime), InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementRetransmitTimer retransmitTimer = default(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementRetransmitTimer), InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementCurrentHopLimit currentHopLimit = default(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementCurrentHopLimit), InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementRouter router = default(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementRouter), bool managed = default(bool), bool otherConfig = default(bool))
        {
            this.Enable = enable;
            this.Interval = interval;
            this.LinkMtu = linkMtu;
            this.ReachableTime = reachableTime;
            this.RetransmitTimer = retransmitTimer;
            this.CurrentHopLimit = currentHopLimit;
            this.Router = router;
            this.Managed = managed;
            this.OtherConfig = otherConfig;
        }

        /// <summary>
        /// Enable IPv6 router advertisement.
        /// </summary>
        /// <value>Enable IPv6 router advertisement.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementInterval Interval { get; set; }

        /// <summary>
        /// Gets or Sets LinkMtu
        /// </summary>
        [DataMember(Name = "link_mtu", EmitDefaultValue = true)]
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementLinkMtu LinkMtu { get; set; }

        /// <summary>
        /// Gets or Sets ReachableTime
        /// </summary>
        [DataMember(Name = "reachable_time", EmitDefaultValue = true)]
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementReachableTime ReachableTime { get; set; }

        /// <summary>
        /// Gets or Sets RetransmitTimer
        /// </summary>
        [DataMember(Name = "retransmit_timer", EmitDefaultValue = true)]
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementRetransmitTimer RetransmitTimer { get; set; }

        /// <summary>
        /// Gets or Sets CurrentHopLimit
        /// </summary>
        [DataMember(Name = "current_hop_limit", EmitDefaultValue = true)]
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementCurrentHopLimit CurrentHopLimit { get; set; }

        /// <summary>
        /// Gets or Sets Router
        /// </summary>
        [DataMember(Name = "router", EmitDefaultValue = false)]
        public InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisementRouter Router { get; set; }

        /// <summary>
        /// Enable IPv6 addresses as available via stateful addresses configuration.
        /// </summary>
        /// <value>Enable IPv6 addresses as available via stateful addresses configuration.</value>
        [DataMember(Name = "managed", EmitDefaultValue = true)]
        public bool Managed { get; set; }

        /// <summary>
        /// Enable non-address configuration as available via stateful addresses configuration.
        /// </summary>
        /// <value>Enable non-address configuration as available via stateful addresses configuration.</value>
        [DataMember(Name = "other_config", EmitDefaultValue = true)]
        public bool OtherConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  LinkMtu: ").Append(LinkMtu).Append("\n");
            sb.Append("  ReachableTime: ").Append(ReachableTime).Append("\n");
            sb.Append("  RetransmitTimer: ").Append(RetransmitTimer).Append("\n");
            sb.Append("  CurrentHopLimit: ").Append(CurrentHopLimit).Append("\n");
            sb.Append("  Router: ").Append(Router).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
            sb.Append("  OtherConfig: ").Append(OtherConfig).Append("\n");
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
            return this.Equals(input as InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement);
        }

        /// <summary>
        /// Returns true if InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement instances are equal
        /// </summary>
        /// <param name="input">Instance of InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterfaceIpv6BaseIpv6IpAssignmentModeStaticStaticRouterAdvertisement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.LinkMtu == input.LinkMtu ||
                    (this.LinkMtu != null &&
                    this.LinkMtu.Equals(input.LinkMtu))
                ) && 
                (
                    this.ReachableTime == input.ReachableTime ||
                    (this.ReachableTime != null &&
                    this.ReachableTime.Equals(input.ReachableTime))
                ) && 
                (
                    this.RetransmitTimer == input.RetransmitTimer ||
                    (this.RetransmitTimer != null &&
                    this.RetransmitTimer.Equals(input.RetransmitTimer))
                ) && 
                (
                    this.CurrentHopLimit == input.CurrentHopLimit ||
                    (this.CurrentHopLimit != null &&
                    this.CurrentHopLimit.Equals(input.CurrentHopLimit))
                ) && 
                (
                    this.Router == input.Router ||
                    (this.Router != null &&
                    this.Router.Equals(input.Router))
                ) && 
                (
                    this.Managed == input.Managed ||
                    this.Managed.Equals(input.Managed)
                ) && 
                (
                    this.OtherConfig == input.OtherConfig ||
                    this.OtherConfig.Equals(input.OtherConfig)
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
                hashCode = (hashCode * 59) + this.Enable.GetHashCode();
                if (this.Interval != null)
                {
                    hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                }
                if (this.LinkMtu != null)
                {
                    hashCode = (hashCode * 59) + this.LinkMtu.GetHashCode();
                }
                if (this.ReachableTime != null)
                {
                    hashCode = (hashCode * 59) + this.ReachableTime.GetHashCode();
                }
                if (this.RetransmitTimer != null)
                {
                    hashCode = (hashCode * 59) + this.RetransmitTimer.GetHashCode();
                }
                if (this.CurrentHopLimit != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentHopLimit.GetHashCode();
                }
                if (this.Router != null)
                {
                    hashCode = (hashCode * 59) + this.Router.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Managed.GetHashCode();
                hashCode = (hashCode * 59) + this.OtherConfig.GetHashCode();
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