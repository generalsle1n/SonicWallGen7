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
    /// Specify ike submodule
    /// </summary>
    [DataContract(Name = "debug_cmd_debug_vpn_ike")]
    public partial class DebugCmdDebugVpnIke : IEquatable<DebugCmdDebugVpnIke>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebugCmdDebugVpnIke" /> class.
        /// </summary>
        /// <param name="dpd">Enable ike dpd.</param>
        /// <param name="keepalive">Enable ike keepalive.</param>
        /// <param name="mempool">Enable ike mempool.</param>
        /// <param name="xauth">Enable ike xauth.</param>
        /// <param name="autoprov">Enable ike autoprov.</param>
        /// <param name="nattrav">Enable ike nat traverse.</param>
        /// <param name="ocsp">Enable ike ocsp.</param>
        /// <param name="dhcprelay">Enable ike dhcprelay.</param>
        /// <param name="l2tp">Enable ike l2tp.</param>
        /// <param name="phase1">Enable ike phase1.</param>
        /// <param name="phase2">Enable ike phase2.</param>
        /// <param name="spd">Enable ike spd.</param>
        /// <param name="packet">Enable ike packet .</param>
        /// <param name="pki">Enable ike pki.</param>
        /// <param name="groupvpn">Enable ike groupvpn.</param>
        /// <param name="vpnHandle">Enable ike handle.</param>
        /// <param name="negn">Enable ike negn.</param>
        /// <param name="ikev2">Enable ike ikev2.</param>
        /// <param name="ikekeys">Enable ike keys.</param>
        /// <param name="blade">Enable ike blade.</param>
        public DebugCmdDebugVpnIke(bool dpd = default(bool), bool keepalive = default(bool), bool mempool = default(bool), bool xauth = default(bool), bool autoprov = default(bool), bool nattrav = default(bool), bool ocsp = default(bool), bool dhcprelay = default(bool), bool l2tp = default(bool), bool phase1 = default(bool), bool phase2 = default(bool), bool spd = default(bool), bool packet = default(bool), bool pki = default(bool), bool groupvpn = default(bool), bool vpnHandle = default(bool), bool negn = default(bool), bool ikev2 = default(bool), bool ikekeys = default(bool), bool blade = default(bool))
        {
            this.Dpd = dpd;
            this.Keepalive = keepalive;
            this.Mempool = mempool;
            this.Xauth = xauth;
            this.Autoprov = autoprov;
            this.Nattrav = nattrav;
            this.Ocsp = ocsp;
            this.Dhcprelay = dhcprelay;
            this.L2tp = l2tp;
            this.Phase1 = phase1;
            this.Phase2 = phase2;
            this.Spd = spd;
            this.Packet = packet;
            this.Pki = pki;
            this.Groupvpn = groupvpn;
            this.VpnHandle = vpnHandle;
            this.Negn = negn;
            this.Ikev2 = ikev2;
            this.Ikekeys = ikekeys;
            this.Blade = blade;
        }

        /// <summary>
        /// Enable ike dpd
        /// </summary>
        /// <value>Enable ike dpd</value>
        [DataMember(Name = "dpd", EmitDefaultValue = true)]
        public bool Dpd { get; set; }

        /// <summary>
        /// Enable ike keepalive
        /// </summary>
        /// <value>Enable ike keepalive</value>
        [DataMember(Name = "keepalive", EmitDefaultValue = true)]
        public bool Keepalive { get; set; }

        /// <summary>
        /// Enable ike mempool
        /// </summary>
        /// <value>Enable ike mempool</value>
        [DataMember(Name = "mempool", EmitDefaultValue = true)]
        public bool Mempool { get; set; }

        /// <summary>
        /// Enable ike xauth
        /// </summary>
        /// <value>Enable ike xauth</value>
        [DataMember(Name = "xauth", EmitDefaultValue = true)]
        public bool Xauth { get; set; }

        /// <summary>
        /// Enable ike autoprov
        /// </summary>
        /// <value>Enable ike autoprov</value>
        [DataMember(Name = "autoprov", EmitDefaultValue = true)]
        public bool Autoprov { get; set; }

        /// <summary>
        /// Enable ike nat traverse
        /// </summary>
        /// <value>Enable ike nat traverse</value>
        [DataMember(Name = "nattrav", EmitDefaultValue = true)]
        public bool Nattrav { get; set; }

        /// <summary>
        /// Enable ike ocsp
        /// </summary>
        /// <value>Enable ike ocsp</value>
        [DataMember(Name = "ocsp", EmitDefaultValue = true)]
        public bool Ocsp { get; set; }

        /// <summary>
        /// Enable ike dhcprelay
        /// </summary>
        /// <value>Enable ike dhcprelay</value>
        [DataMember(Name = "dhcprelay", EmitDefaultValue = true)]
        public bool Dhcprelay { get; set; }

        /// <summary>
        /// Enable ike l2tp
        /// </summary>
        /// <value>Enable ike l2tp</value>
        [DataMember(Name = "l2tp", EmitDefaultValue = true)]
        public bool L2tp { get; set; }

        /// <summary>
        /// Enable ike phase1
        /// </summary>
        /// <value>Enable ike phase1</value>
        [DataMember(Name = "phase1", EmitDefaultValue = true)]
        public bool Phase1 { get; set; }

        /// <summary>
        /// Enable ike phase2
        /// </summary>
        /// <value>Enable ike phase2</value>
        [DataMember(Name = "phase2", EmitDefaultValue = true)]
        public bool Phase2 { get; set; }

        /// <summary>
        /// Enable ike spd
        /// </summary>
        /// <value>Enable ike spd</value>
        [DataMember(Name = "spd", EmitDefaultValue = true)]
        public bool Spd { get; set; }

        /// <summary>
        /// Enable ike packet 
        /// </summary>
        /// <value>Enable ike packet </value>
        [DataMember(Name = "packet", EmitDefaultValue = true)]
        public bool Packet { get; set; }

        /// <summary>
        /// Enable ike pki
        /// </summary>
        /// <value>Enable ike pki</value>
        [DataMember(Name = "pki", EmitDefaultValue = true)]
        public bool Pki { get; set; }

        /// <summary>
        /// Enable ike groupvpn
        /// </summary>
        /// <value>Enable ike groupvpn</value>
        [DataMember(Name = "groupvpn", EmitDefaultValue = true)]
        public bool Groupvpn { get; set; }

        /// <summary>
        /// Enable ike handle
        /// </summary>
        /// <value>Enable ike handle</value>
        [DataMember(Name = "vpn_handle", EmitDefaultValue = true)]
        public bool VpnHandle { get; set; }

        /// <summary>
        /// Enable ike negn
        /// </summary>
        /// <value>Enable ike negn</value>
        [DataMember(Name = "negn", EmitDefaultValue = true)]
        public bool Negn { get; set; }

        /// <summary>
        /// Enable ike ikev2
        /// </summary>
        /// <value>Enable ike ikev2</value>
        [DataMember(Name = "ikev2", EmitDefaultValue = true)]
        public bool Ikev2 { get; set; }

        /// <summary>
        /// Enable ike keys
        /// </summary>
        /// <value>Enable ike keys</value>
        [DataMember(Name = "ikekeys", EmitDefaultValue = true)]
        public bool Ikekeys { get; set; }

        /// <summary>
        /// Enable ike blade
        /// </summary>
        /// <value>Enable ike blade</value>
        [DataMember(Name = "blade", EmitDefaultValue = true)]
        public bool Blade { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DebugCmdDebugVpnIke {\n");
            sb.Append("  Dpd: ").Append(Dpd).Append("\n");
            sb.Append("  Keepalive: ").Append(Keepalive).Append("\n");
            sb.Append("  Mempool: ").Append(Mempool).Append("\n");
            sb.Append("  Xauth: ").Append(Xauth).Append("\n");
            sb.Append("  Autoprov: ").Append(Autoprov).Append("\n");
            sb.Append("  Nattrav: ").Append(Nattrav).Append("\n");
            sb.Append("  Ocsp: ").Append(Ocsp).Append("\n");
            sb.Append("  Dhcprelay: ").Append(Dhcprelay).Append("\n");
            sb.Append("  L2tp: ").Append(L2tp).Append("\n");
            sb.Append("  Phase1: ").Append(Phase1).Append("\n");
            sb.Append("  Phase2: ").Append(Phase2).Append("\n");
            sb.Append("  Spd: ").Append(Spd).Append("\n");
            sb.Append("  Packet: ").Append(Packet).Append("\n");
            sb.Append("  Pki: ").Append(Pki).Append("\n");
            sb.Append("  Groupvpn: ").Append(Groupvpn).Append("\n");
            sb.Append("  VpnHandle: ").Append(VpnHandle).Append("\n");
            sb.Append("  Negn: ").Append(Negn).Append("\n");
            sb.Append("  Ikev2: ").Append(Ikev2).Append("\n");
            sb.Append("  Ikekeys: ").Append(Ikekeys).Append("\n");
            sb.Append("  Blade: ").Append(Blade).Append("\n");
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
            return this.Equals(input as DebugCmdDebugVpnIke);
        }

        /// <summary>
        /// Returns true if DebugCmdDebugVpnIke instances are equal
        /// </summary>
        /// <param name="input">Instance of DebugCmdDebugVpnIke to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebugCmdDebugVpnIke input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Dpd == input.Dpd ||
                    this.Dpd.Equals(input.Dpd)
                ) && 
                (
                    this.Keepalive == input.Keepalive ||
                    this.Keepalive.Equals(input.Keepalive)
                ) && 
                (
                    this.Mempool == input.Mempool ||
                    this.Mempool.Equals(input.Mempool)
                ) && 
                (
                    this.Xauth == input.Xauth ||
                    this.Xauth.Equals(input.Xauth)
                ) && 
                (
                    this.Autoprov == input.Autoprov ||
                    this.Autoprov.Equals(input.Autoprov)
                ) && 
                (
                    this.Nattrav == input.Nattrav ||
                    this.Nattrav.Equals(input.Nattrav)
                ) && 
                (
                    this.Ocsp == input.Ocsp ||
                    this.Ocsp.Equals(input.Ocsp)
                ) && 
                (
                    this.Dhcprelay == input.Dhcprelay ||
                    this.Dhcprelay.Equals(input.Dhcprelay)
                ) && 
                (
                    this.L2tp == input.L2tp ||
                    this.L2tp.Equals(input.L2tp)
                ) && 
                (
                    this.Phase1 == input.Phase1 ||
                    this.Phase1.Equals(input.Phase1)
                ) && 
                (
                    this.Phase2 == input.Phase2 ||
                    this.Phase2.Equals(input.Phase2)
                ) && 
                (
                    this.Spd == input.Spd ||
                    this.Spd.Equals(input.Spd)
                ) && 
                (
                    this.Packet == input.Packet ||
                    this.Packet.Equals(input.Packet)
                ) && 
                (
                    this.Pki == input.Pki ||
                    this.Pki.Equals(input.Pki)
                ) && 
                (
                    this.Groupvpn == input.Groupvpn ||
                    this.Groupvpn.Equals(input.Groupvpn)
                ) && 
                (
                    this.VpnHandle == input.VpnHandle ||
                    this.VpnHandle.Equals(input.VpnHandle)
                ) && 
                (
                    this.Negn == input.Negn ||
                    this.Negn.Equals(input.Negn)
                ) && 
                (
                    this.Ikev2 == input.Ikev2 ||
                    this.Ikev2.Equals(input.Ikev2)
                ) && 
                (
                    this.Ikekeys == input.Ikekeys ||
                    this.Ikekeys.Equals(input.Ikekeys)
                ) && 
                (
                    this.Blade == input.Blade ||
                    this.Blade.Equals(input.Blade)
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
                hashCode = (hashCode * 59) + this.Dpd.GetHashCode();
                hashCode = (hashCode * 59) + this.Keepalive.GetHashCode();
                hashCode = (hashCode * 59) + this.Mempool.GetHashCode();
                hashCode = (hashCode * 59) + this.Xauth.GetHashCode();
                hashCode = (hashCode * 59) + this.Autoprov.GetHashCode();
                hashCode = (hashCode * 59) + this.Nattrav.GetHashCode();
                hashCode = (hashCode * 59) + this.Ocsp.GetHashCode();
                hashCode = (hashCode * 59) + this.Dhcprelay.GetHashCode();
                hashCode = (hashCode * 59) + this.L2tp.GetHashCode();
                hashCode = (hashCode * 59) + this.Phase1.GetHashCode();
                hashCode = (hashCode * 59) + this.Phase2.GetHashCode();
                hashCode = (hashCode * 59) + this.Spd.GetHashCode();
                hashCode = (hashCode * 59) + this.Packet.GetHashCode();
                hashCode = (hashCode * 59) + this.Pki.GetHashCode();
                hashCode = (hashCode * 59) + this.Groupvpn.GetHashCode();
                hashCode = (hashCode * 59) + this.VpnHandle.GetHashCode();
                hashCode = (hashCode * 59) + this.Negn.GetHashCode();
                hashCode = (hashCode * 59) + this.Ikev2.GetHashCode();
                hashCode = (hashCode * 59) + this.Ikekeys.GetHashCode();
                hashCode = (hashCode * 59) + this.Blade.GetHashCode();
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
