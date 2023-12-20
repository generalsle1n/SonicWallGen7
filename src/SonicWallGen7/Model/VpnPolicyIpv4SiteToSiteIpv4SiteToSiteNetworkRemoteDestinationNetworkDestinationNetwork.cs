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
    /// Choose destination network from list.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetworkJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv4_site_to_site_ipv4_site_to_site_network_remote_destination_network_destination_network")]
    public partial class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork</returns>
        public static VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork FromJson(string jsonString)
        {
            VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkHost: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkNetwork: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkRange: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork input)
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
    /// Custom JSON converter for VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork
    /// </summary>
    public class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetworkJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv4SiteToSiteIpv4SiteToSiteNetworkRemoteDestinationNetworkDestinationNetwork.FromJson(JObject.Load(reader).ToString(Formatting.None));
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