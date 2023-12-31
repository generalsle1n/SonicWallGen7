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
    /// ServiceObjectIcmp
    /// </summary>
    [DataContract(Name = "service_object_icmp")]
    public partial class ServiceObjectIcmp : IEquatable<ServiceObjectIcmp>, IValidatableObject
    {
        /// <summary>
        /// Service object ICMP.
        /// </summary>
        /// <value>Service object ICMP.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IcmpEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum EchoReply for value: echo-reply
            /// </summary>
            [EnumMember(Value = "echo-reply")]
            EchoReply = 2,

            /// <summary>
            /// Enum DestinationUnreachable for value: destination-unreachable
            /// </summary>
            [EnumMember(Value = "destination-unreachable")]
            DestinationUnreachable = 3,

            /// <summary>
            /// Enum SourceQuench for value: source-quench
            /// </summary>
            [EnumMember(Value = "source-quench")]
            SourceQuench = 4,

            /// <summary>
            /// Enum Redirect for value: redirect
            /// </summary>
            [EnumMember(Value = "redirect")]
            Redirect = 5,

            /// <summary>
            /// Enum AlternativeHost for value: alternative-host
            /// </summary>
            [EnumMember(Value = "alternative-host")]
            AlternativeHost = 6,

            /// <summary>
            /// Enum EchoRequest for value: echo-request
            /// </summary>
            [EnumMember(Value = "echo-request")]
            EchoRequest = 7,

            /// <summary>
            /// Enum RouterAdvertise for value: router-advertise
            /// </summary>
            [EnumMember(Value = "router-advertise")]
            RouterAdvertise = 8,

            /// <summary>
            /// Enum RouterSolicit for value: router-solicit
            /// </summary>
            [EnumMember(Value = "router-solicit")]
            RouterSolicit = 9,

            /// <summary>
            /// Enum TimeExceeded for value: time-exceeded
            /// </summary>
            [EnumMember(Value = "time-exceeded")]
            TimeExceeded = 10,

            /// <summary>
            /// Enum ParameterProblem for value: parameter-problem
            /// </summary>
            [EnumMember(Value = "parameter-problem")]
            ParameterProblem = 11,

            /// <summary>
            /// Enum Timestamp for value: timestamp
            /// </summary>
            [EnumMember(Value = "timestamp")]
            Timestamp = 12,

            /// <summary>
            /// Enum TimestampReply for value: timestamp-reply
            /// </summary>
            [EnumMember(Value = "timestamp-reply")]
            TimestampReply = 13,

            /// <summary>
            /// Enum InfoRequest for value: info-request
            /// </summary>
            [EnumMember(Value = "info-request")]
            InfoRequest = 14,

            /// <summary>
            /// Enum InfoReply for value: info-reply
            /// </summary>
            [EnumMember(Value = "info-reply")]
            InfoReply = 15,

            /// <summary>
            /// Enum AddressMaskRequest for value: address-mask-request
            /// </summary>
            [EnumMember(Value = "address-mask-request")]
            AddressMaskRequest = 16,

            /// <summary>
            /// Enum AddressMaskReply for value: address-mask-reply
            /// </summary>
            [EnumMember(Value = "address-mask-reply")]
            AddressMaskReply = 17,

            /// <summary>
            /// Enum Traceroute for value: traceroute
            /// </summary>
            [EnumMember(Value = "traceroute")]
            Traceroute = 18,

            /// <summary>
            /// Enum DatagramError for value: datagram-error
            /// </summary>
            [EnumMember(Value = "datagram-error")]
            DatagramError = 19,

            /// <summary>
            /// Enum MobileHostRedirect for value: mobile-host-redirect
            /// </summary>
            [EnumMember(Value = "mobile-host-redirect")]
            MobileHostRedirect = 20,

            /// <summary>
            /// Enum MobileRegistrationRequest for value: mobile-registration-request
            /// </summary>
            [EnumMember(Value = "mobile-registration-request")]
            MobileRegistrationRequest = 21,

            /// <summary>
            /// Enum MobileRegistrationReply for value: mobile-registration-reply
            /// </summary>
            [EnumMember(Value = "mobile-registration-reply")]
            MobileRegistrationReply = 22,

            /// <summary>
            /// Enum DomainName for value: domain-name
            /// </summary>
            [EnumMember(Value = "domain-name")]
            DomainName = 23,

            /// <summary>
            /// Enum DomainNameReply for value: domain-name-reply
            /// </summary>
            [EnumMember(Value = "domain-name-reply")]
            DomainNameReply = 24
        }


        /// <summary>
        /// Service object ICMP.
        /// </summary>
        /// <value>Service object ICMP.</value>
        [DataMember(Name = "icmp", EmitDefaultValue = false)]
        public IcmpEnum? Icmp { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceObjectIcmp" /> class.
        /// </summary>
        /// <param name="icmp">Service object ICMP..</param>
        public ServiceObjectIcmp(IcmpEnum? icmp = default(IcmpEnum?))
        {
            this.Icmp = icmp;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceObjectIcmp {\n");
            sb.Append("  Icmp: ").Append(Icmp).Append("\n");
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
            return this.Equals(input as ServiceObjectIcmp);
        }

        /// <summary>
        /// Returns true if ServiceObjectIcmp instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceObjectIcmp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceObjectIcmp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Icmp == input.Icmp ||
                    this.Icmp.Equals(input.Icmp)
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
                hashCode = (hashCode * 59) + this.Icmp.GetHashCode();
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
