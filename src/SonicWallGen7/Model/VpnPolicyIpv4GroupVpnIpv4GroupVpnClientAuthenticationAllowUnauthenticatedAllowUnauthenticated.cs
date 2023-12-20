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
using System.Reflection;

namespace SonicWallGen7.Model
{
    /// <summary>
    /// Enable unauthenticated access for VPN policy.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticatedJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv4_group_vpn_ipv4_group_vpn_client_authentication_allow_unauthenticated_allow_unauthenticated")]
    public partial class VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated" /> class
        /// with the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated" /> class
        /// with the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated" /> class
        /// with the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated" /> class
        /// with the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated" /> class
        /// with the <see cref="VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork.</param>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName`. If the actual instance is not `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName</returns>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName GetVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName()
        {
            return (VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup`. If the actual instance is not `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup</returns>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup GetVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup()
        {
            return (VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost`. If the actual instance is not `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost</returns>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost GetVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost()
        {
            return (VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange`. If the actual instance is not `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange</returns>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange GetVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange()
        {
            return (VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork`. If the actual instance is not `VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork</returns>
        public VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork GetVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork()
        {
            return (VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated</returns>
        public static VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated FromJson(string jsonString)
        {
            VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedHost: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedNetwork: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated = new VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated(JsonConvert.DeserializeObject<VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange>(jsonString, VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedRange: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newVpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated
    /// </summary>
    public class VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticatedJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return VpnPolicyIpv4GroupVpnIpv4GroupVpnClientAuthenticationAllowUnauthenticatedAllowUnauthenticated.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}