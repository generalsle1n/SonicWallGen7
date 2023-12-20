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
    /// ShowStatusDnsProxySplitEntriesListInner
    /// </summary>
    [DataContract(Name = "show_status_dns_proxy_split_entries_list_inner")]
    public partial class ShowStatusDnsProxySplitEntriesListInner : IEquatable<ShowStatusDnsProxySplitEntriesListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowStatusDnsProxySplitEntriesListInner" /> class.
        /// </summary>
        /// <param name="domainName">domainName.</param>
        /// <param name="dnsServer">dnsServer.</param>
        /// <param name="serverIp">serverIp.</param>
        /// <param name="serverStatus">serverStatus.</param>
        /// <param name="proxiedDnsPacketsSent">proxiedDnsPacketsSent.</param>
        /// <param name="successfulDnsProxy">successfulDnsProxy.</param>
        public ShowStatusDnsProxySplitEntriesListInner(string domainName = default(string), string dnsServer = default(string), string serverIp = default(string), string serverStatus = default(string), string proxiedDnsPacketsSent = default(string), string successfulDnsProxy = default(string))
        {
            this.DomainName = domainName;
            this.DnsServer = dnsServer;
            this.ServerIp = serverIp;
            this.ServerStatus = serverStatus;
            this.ProxiedDnsPacketsSent = proxiedDnsPacketsSent;
            this.SuccessfulDnsProxy = successfulDnsProxy;
        }

        /// <summary>
        /// Gets or Sets DomainName
        /// </summary>
        [DataMember(Name = "domain_name", EmitDefaultValue = false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or Sets DnsServer
        /// </summary>
        [DataMember(Name = "dns_server", EmitDefaultValue = false)]
        public string DnsServer { get; set; }

        /// <summary>
        /// Gets or Sets ServerIp
        /// </summary>
        [DataMember(Name = "server_ip", EmitDefaultValue = false)]
        public string ServerIp { get; set; }

        /// <summary>
        /// Gets or Sets ServerStatus
        /// </summary>
        [DataMember(Name = "server_status", EmitDefaultValue = false)]
        public string ServerStatus { get; set; }

        /// <summary>
        /// Gets or Sets ProxiedDnsPacketsSent
        /// </summary>
        [DataMember(Name = "proxied_dns_packets_sent", EmitDefaultValue = false)]
        public string ProxiedDnsPacketsSent { get; set; }

        /// <summary>
        /// Gets or Sets SuccessfulDnsProxy
        /// </summary>
        [DataMember(Name = "successful_dns_proxy", EmitDefaultValue = false)]
        public string SuccessfulDnsProxy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShowStatusDnsProxySplitEntriesListInner {\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  DnsServer: ").Append(DnsServer).Append("\n");
            sb.Append("  ServerIp: ").Append(ServerIp).Append("\n");
            sb.Append("  ServerStatus: ").Append(ServerStatus).Append("\n");
            sb.Append("  ProxiedDnsPacketsSent: ").Append(ProxiedDnsPacketsSent).Append("\n");
            sb.Append("  SuccessfulDnsProxy: ").Append(SuccessfulDnsProxy).Append("\n");
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
            return this.Equals(input as ShowStatusDnsProxySplitEntriesListInner);
        }

        /// <summary>
        /// Returns true if ShowStatusDnsProxySplitEntriesListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ShowStatusDnsProxySplitEntriesListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShowStatusDnsProxySplitEntriesListInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.DnsServer == input.DnsServer ||
                    (this.DnsServer != null &&
                    this.DnsServer.Equals(input.DnsServer))
                ) && 
                (
                    this.ServerIp == input.ServerIp ||
                    (this.ServerIp != null &&
                    this.ServerIp.Equals(input.ServerIp))
                ) && 
                (
                    this.ServerStatus == input.ServerStatus ||
                    (this.ServerStatus != null &&
                    this.ServerStatus.Equals(input.ServerStatus))
                ) && 
                (
                    this.ProxiedDnsPacketsSent == input.ProxiedDnsPacketsSent ||
                    (this.ProxiedDnsPacketsSent != null &&
                    this.ProxiedDnsPacketsSent.Equals(input.ProxiedDnsPacketsSent))
                ) && 
                (
                    this.SuccessfulDnsProxy == input.SuccessfulDnsProxy ||
                    (this.SuccessfulDnsProxy != null &&
                    this.SuccessfulDnsProxy.Equals(input.SuccessfulDnsProxy))
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
                if (this.DomainName != null)
                {
                    hashCode = (hashCode * 59) + this.DomainName.GetHashCode();
                }
                if (this.DnsServer != null)
                {
                    hashCode = (hashCode * 59) + this.DnsServer.GetHashCode();
                }
                if (this.ServerIp != null)
                {
                    hashCode = (hashCode * 59) + this.ServerIp.GetHashCode();
                }
                if (this.ServerStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ServerStatus.GetHashCode();
                }
                if (this.ProxiedDnsPacketsSent != null)
                {
                    hashCode = (hashCode * 59) + this.ProxiedDnsPacketsSent.GetHashCode();
                }
                if (this.SuccessfulDnsProxy != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessfulDnsProxy.GetHashCode();
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
