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
    [JsonConverter(typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetworkJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv4_provision_server_ipv4_provision_server_network_remote_destination_network_destination_network")]
    public partial class VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork</returns>
        public static VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork FromJson(string jsonString)
        {
            VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkHost: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkNetwork: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkRange: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork input)
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
    /// Custom JSON converter for VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork
    /// </summary>
    public class VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetworkJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteDestinationNetworkDestinationNetwork.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
