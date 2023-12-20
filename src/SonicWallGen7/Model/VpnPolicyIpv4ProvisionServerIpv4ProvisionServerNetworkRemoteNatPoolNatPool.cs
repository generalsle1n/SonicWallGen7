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
    /// Choose NAT pool.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPoolJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv4_provision_server_ipv4_provision_server_network_remote_nat_pool_nat_pool")]
    public partial class VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool" /> class
        /// with the <see cref="VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork.</param>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork`. If the actual instance is not `VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork</returns>
        public VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork GetVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork()
        {
            return (VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool</returns>
        public static VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool FromJson(string jsonString)
        {
            VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolHost: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNetwork: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool = new VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool(JsonConvert.DeserializeObject<VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange>(jsonString, VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolRange: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool input)
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
    /// Custom JSON converter for VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool
    /// </summary>
    public class VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPoolJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv4ProvisionServerIpv4ProvisionServerNetworkRemoteNatPoolNatPool.FromJson(JObject.Load(reader).ToString(Formatting.None));
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