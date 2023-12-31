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
    /// Enter SIP transformations configure mode. * Set to null or {} to represent  an unconfigured state.
    /// </summary>
    [DataContract(Name = "voip_voip_sip")]
    public partial class VoipVoipSip : IEquatable<VoipVoipSip>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoipVoipSip" /> class.
        /// </summary>
        /// <param name="enable">Enable SIP transformations..</param>
        /// <param name="accessRuleBased">Set SIP transformation will be performed only when it is enabled on the corresponding firewall access rule..</param>
        /// <param name="tcp">Enable transformations on TCP connections..</param>
        /// <param name="transformsInServiceObject">transformsInServiceObject.</param>
        /// <param name="nonSipPackets">Enable permit non-SIP packets on signaling port..</param>
        /// <param name="b2buaSupport">Enable SIP back-to-back user agent (B2BUA) support..</param>
        /// <param name="signalingTimeout">Set SIP signaling inactivity time out (seconds)..</param>
        /// <param name="mediaTimeout">Set SIP media inactivity time out (seconds)..</param>
        /// <param name="signalingPort">signalingPort.</param>
        /// <param name="endpointRegistrationAnomalyTracking">Enable SIP endpoint registration anomaly tracking..</param>
        /// <param name="registrationTrackingInterval">Set SIP registration tracking interval (seconds)..</param>
        /// <param name="failedRegistrationThreshold">Set SIP failed registration threshold..</param>
        /// <param name="endpointBlockInterval">Set endpoint block interval(seconds).</param>
        public VoipVoipSip(bool enable = default(bool), bool accessRuleBased = default(bool), bool tcp = default(bool), VoipVoipSipTransformsInServiceObject transformsInServiceObject = default(VoipVoipSipTransformsInServiceObject), bool nonSipPackets = default(bool), bool b2buaSupport = default(bool), decimal signalingTimeout = default(decimal), decimal mediaTimeout = default(decimal), VoipVoipSipSignalingPort signalingPort = default(VoipVoipSipSignalingPort), bool endpointRegistrationAnomalyTracking = default(bool), decimal registrationTrackingInterval = default(decimal), decimal failedRegistrationThreshold = default(decimal), decimal endpointBlockInterval = default(decimal))
        {
            this.Enable = enable;
            this.AccessRuleBased = accessRuleBased;
            this.Tcp = tcp;
            this.TransformsInServiceObject = transformsInServiceObject;
            this.NonSipPackets = nonSipPackets;
            this.B2buaSupport = b2buaSupport;
            this.SignalingTimeout = signalingTimeout;
            this.MediaTimeout = mediaTimeout;
            this.SignalingPort = signalingPort;
            this.EndpointRegistrationAnomalyTracking = endpointRegistrationAnomalyTracking;
            this.RegistrationTrackingInterval = registrationTrackingInterval;
            this.FailedRegistrationThreshold = failedRegistrationThreshold;
            this.EndpointBlockInterval = endpointBlockInterval;
        }

        /// <summary>
        /// Enable SIP transformations.
        /// </summary>
        /// <value>Enable SIP transformations.</value>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Set SIP transformation will be performed only when it is enabled on the corresponding firewall access rule.
        /// </summary>
        /// <value>Set SIP transformation will be performed only when it is enabled on the corresponding firewall access rule.</value>
        [DataMember(Name = "access_rule_based", EmitDefaultValue = true)]
        public bool AccessRuleBased { get; set; }

        /// <summary>
        /// Enable transformations on TCP connections.
        /// </summary>
        /// <value>Enable transformations on TCP connections.</value>
        [DataMember(Name = "tcp", EmitDefaultValue = true)]
        public bool Tcp { get; set; }

        /// <summary>
        /// Gets or Sets TransformsInServiceObject
        /// </summary>
        [DataMember(Name = "transforms_in_service_object", EmitDefaultValue = false)]
        public VoipVoipSipTransformsInServiceObject TransformsInServiceObject { get; set; }

        /// <summary>
        /// Enable permit non-SIP packets on signaling port.
        /// </summary>
        /// <value>Enable permit non-SIP packets on signaling port.</value>
        [DataMember(Name = "non_sip_packets", EmitDefaultValue = true)]
        public bool NonSipPackets { get; set; }

        /// <summary>
        /// Enable SIP back-to-back user agent (B2BUA) support.
        /// </summary>
        /// <value>Enable SIP back-to-back user agent (B2BUA) support.</value>
        [DataMember(Name = "b2bua_support", EmitDefaultValue = true)]
        public bool B2buaSupport { get; set; }

        /// <summary>
        /// Set SIP signaling inactivity time out (seconds).
        /// </summary>
        /// <value>Set SIP signaling inactivity time out (seconds).</value>
        [DataMember(Name = "signaling_timeout", EmitDefaultValue = false)]
        public decimal SignalingTimeout { get; set; }

        /// <summary>
        /// Set SIP media inactivity time out (seconds).
        /// </summary>
        /// <value>Set SIP media inactivity time out (seconds).</value>
        [DataMember(Name = "media_timeout", EmitDefaultValue = false)]
        public decimal MediaTimeout { get; set; }

        /// <summary>
        /// Gets or Sets SignalingPort
        /// </summary>
        [DataMember(Name = "signaling_port", EmitDefaultValue = true)]
        public VoipVoipSipSignalingPort SignalingPort { get; set; }

        /// <summary>
        /// Enable SIP endpoint registration anomaly tracking.
        /// </summary>
        /// <value>Enable SIP endpoint registration anomaly tracking.</value>
        [DataMember(Name = "endpoint_registration_anomaly_tracking", EmitDefaultValue = true)]
        public bool EndpointRegistrationAnomalyTracking { get; set; }

        /// <summary>
        /// Set SIP registration tracking interval (seconds).
        /// </summary>
        /// <value>Set SIP registration tracking interval (seconds).</value>
        [DataMember(Name = "registration_tracking_interval", EmitDefaultValue = false)]
        public decimal RegistrationTrackingInterval { get; set; }

        /// <summary>
        /// Set SIP failed registration threshold.
        /// </summary>
        /// <value>Set SIP failed registration threshold.</value>
        [DataMember(Name = "failed_registration_threshold", EmitDefaultValue = false)]
        public decimal FailedRegistrationThreshold { get; set; }

        /// <summary>
        /// Set endpoint block interval(seconds)
        /// </summary>
        /// <value>Set endpoint block interval(seconds)</value>
        [DataMember(Name = "endpoint_block_interval", EmitDefaultValue = false)]
        public decimal EndpointBlockInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoipVoipSip {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  AccessRuleBased: ").Append(AccessRuleBased).Append("\n");
            sb.Append("  Tcp: ").Append(Tcp).Append("\n");
            sb.Append("  TransformsInServiceObject: ").Append(TransformsInServiceObject).Append("\n");
            sb.Append("  NonSipPackets: ").Append(NonSipPackets).Append("\n");
            sb.Append("  B2buaSupport: ").Append(B2buaSupport).Append("\n");
            sb.Append("  SignalingTimeout: ").Append(SignalingTimeout).Append("\n");
            sb.Append("  MediaTimeout: ").Append(MediaTimeout).Append("\n");
            sb.Append("  SignalingPort: ").Append(SignalingPort).Append("\n");
            sb.Append("  EndpointRegistrationAnomalyTracking: ").Append(EndpointRegistrationAnomalyTracking).Append("\n");
            sb.Append("  RegistrationTrackingInterval: ").Append(RegistrationTrackingInterval).Append("\n");
            sb.Append("  FailedRegistrationThreshold: ").Append(FailedRegistrationThreshold).Append("\n");
            sb.Append("  EndpointBlockInterval: ").Append(EndpointBlockInterval).Append("\n");
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
            return this.Equals(input as VoipVoipSip);
        }

        /// <summary>
        /// Returns true if VoipVoipSip instances are equal
        /// </summary>
        /// <param name="input">Instance of VoipVoipSip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoipVoipSip input)
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
                    this.AccessRuleBased == input.AccessRuleBased ||
                    this.AccessRuleBased.Equals(input.AccessRuleBased)
                ) && 
                (
                    this.Tcp == input.Tcp ||
                    this.Tcp.Equals(input.Tcp)
                ) && 
                (
                    this.TransformsInServiceObject == input.TransformsInServiceObject ||
                    (this.TransformsInServiceObject != null &&
                    this.TransformsInServiceObject.Equals(input.TransformsInServiceObject))
                ) && 
                (
                    this.NonSipPackets == input.NonSipPackets ||
                    this.NonSipPackets.Equals(input.NonSipPackets)
                ) && 
                (
                    this.B2buaSupport == input.B2buaSupport ||
                    this.B2buaSupport.Equals(input.B2buaSupport)
                ) && 
                (
                    this.SignalingTimeout == input.SignalingTimeout ||
                    this.SignalingTimeout.Equals(input.SignalingTimeout)
                ) && 
                (
                    this.MediaTimeout == input.MediaTimeout ||
                    this.MediaTimeout.Equals(input.MediaTimeout)
                ) && 
                (
                    this.SignalingPort == input.SignalingPort ||
                    (this.SignalingPort != null &&
                    this.SignalingPort.Equals(input.SignalingPort))
                ) && 
                (
                    this.EndpointRegistrationAnomalyTracking == input.EndpointRegistrationAnomalyTracking ||
                    this.EndpointRegistrationAnomalyTracking.Equals(input.EndpointRegistrationAnomalyTracking)
                ) && 
                (
                    this.RegistrationTrackingInterval == input.RegistrationTrackingInterval ||
                    this.RegistrationTrackingInterval.Equals(input.RegistrationTrackingInterval)
                ) && 
                (
                    this.FailedRegistrationThreshold == input.FailedRegistrationThreshold ||
                    this.FailedRegistrationThreshold.Equals(input.FailedRegistrationThreshold)
                ) && 
                (
                    this.EndpointBlockInterval == input.EndpointBlockInterval ||
                    this.EndpointBlockInterval.Equals(input.EndpointBlockInterval)
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
                hashCode = (hashCode * 59) + this.AccessRuleBased.GetHashCode();
                hashCode = (hashCode * 59) + this.Tcp.GetHashCode();
                if (this.TransformsInServiceObject != null)
                {
                    hashCode = (hashCode * 59) + this.TransformsInServiceObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NonSipPackets.GetHashCode();
                hashCode = (hashCode * 59) + this.B2buaSupport.GetHashCode();
                hashCode = (hashCode * 59) + this.SignalingTimeout.GetHashCode();
                hashCode = (hashCode * 59) + this.MediaTimeout.GetHashCode();
                if (this.SignalingPort != null)
                {
                    hashCode = (hashCode * 59) + this.SignalingPort.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EndpointRegistrationAnomalyTracking.GetHashCode();
                hashCode = (hashCode * 59) + this.RegistrationTrackingInterval.GetHashCode();
                hashCode = (hashCode * 59) + this.FailedRegistrationThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.EndpointBlockInterval.GetHashCode();
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
