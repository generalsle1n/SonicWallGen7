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
    /// IKE authentication local identifier.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocalJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv6_site_to_site_auth_method_shared_secret_shared_secret_ike_id_local")]
    public partial class VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal" /> class
        /// with the <see cref="VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId.</param>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4 GetVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6 GetVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName GetVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress GetVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId GetVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId`. If the actual instance is not `VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId</returns>
        public VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId GetVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId()
        {
            return (VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal</returns>
        public static VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal FromJson(string jsonString)
        {
            VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalDomainName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalEmailAddress: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalFirewallId: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv4: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalIpv6: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal = new VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal(JsonConvert.DeserializeObject<VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId>(jsonString, VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretIkeIdLocalKeyId: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal input)
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
    /// Custom JSON converter for VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal
    /// </summary>
    public class VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocalJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv6SiteToSiteAuthMethodSharedSecretSharedSecretIkeIdLocal.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
