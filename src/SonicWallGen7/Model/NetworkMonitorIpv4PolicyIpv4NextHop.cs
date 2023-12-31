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
    /// Set the next hop gateway.
    /// </summary>
    [JsonConverter(typeof(NetworkMonitorIpv4PolicyIpv4NextHopJsonConverter))]
    [DataContract(Name = "network_monitor_ipv4_policy_ipv4_next_hop")]
    public partial class NetworkMonitorIpv4PolicyIpv4NextHop : AbstractOpenAPISchema, IEquatable<NetworkMonitorIpv4PolicyIpv4NextHop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMonitorIpv4PolicyIpv4NextHop" /> class
        /// with the <see cref="NetworkMonitorIpv4PolicyIpv4NextHopName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NetworkMonitorIpv4PolicyIpv4NextHopName.</param>
        public NetworkMonitorIpv4PolicyIpv4NextHop(NetworkMonitorIpv4PolicyIpv4NextHopName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMonitorIpv4PolicyIpv4NextHop" /> class
        /// with the <see cref="NetworkMonitorIpv4PolicyIpv4NextHopHost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NetworkMonitorIpv4PolicyIpv4NextHopHost.</param>
        public NetworkMonitorIpv4PolicyIpv4NextHop(NetworkMonitorIpv4PolicyIpv4NextHopHost actualInstance)
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
                if (value.GetType() == typeof(NetworkMonitorIpv4PolicyIpv4NextHopHost))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NetworkMonitorIpv4PolicyIpv4NextHopName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: NetworkMonitorIpv4PolicyIpv4NextHopHost, NetworkMonitorIpv4PolicyIpv4NextHopName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `NetworkMonitorIpv4PolicyIpv4NextHopName`. If the actual instance is not `NetworkMonitorIpv4PolicyIpv4NextHopName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NetworkMonitorIpv4PolicyIpv4NextHopName</returns>
        public NetworkMonitorIpv4PolicyIpv4NextHopName GetNetworkMonitorIpv4PolicyIpv4NextHopName()
        {
            return (NetworkMonitorIpv4PolicyIpv4NextHopName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NetworkMonitorIpv4PolicyIpv4NextHopHost`. If the actual instance is not `NetworkMonitorIpv4PolicyIpv4NextHopHost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NetworkMonitorIpv4PolicyIpv4NextHopHost</returns>
        public NetworkMonitorIpv4PolicyIpv4NextHopHost GetNetworkMonitorIpv4PolicyIpv4NextHopHost()
        {
            return (NetworkMonitorIpv4PolicyIpv4NextHopHost)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkMonitorIpv4PolicyIpv4NextHop {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NetworkMonitorIpv4PolicyIpv4NextHop.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NetworkMonitorIpv4PolicyIpv4NextHop
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NetworkMonitorIpv4PolicyIpv4NextHop</returns>
        public static NetworkMonitorIpv4PolicyIpv4NextHop FromJson(string jsonString)
        {
            NetworkMonitorIpv4PolicyIpv4NextHop newNetworkMonitorIpv4PolicyIpv4NextHop = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNetworkMonitorIpv4PolicyIpv4NextHop;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NetworkMonitorIpv4PolicyIpv4NextHopHost).GetProperty("AdditionalProperties") == null)
                {
                    newNetworkMonitorIpv4PolicyIpv4NextHop = new NetworkMonitorIpv4PolicyIpv4NextHop(JsonConvert.DeserializeObject<NetworkMonitorIpv4PolicyIpv4NextHopHost>(jsonString, NetworkMonitorIpv4PolicyIpv4NextHop.SerializerSettings));
                }
                else
                {
                    newNetworkMonitorIpv4PolicyIpv4NextHop = new NetworkMonitorIpv4PolicyIpv4NextHop(JsonConvert.DeserializeObject<NetworkMonitorIpv4PolicyIpv4NextHopHost>(jsonString, NetworkMonitorIpv4PolicyIpv4NextHop.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NetworkMonitorIpv4PolicyIpv4NextHopHost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NetworkMonitorIpv4PolicyIpv4NextHopHost: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NetworkMonitorIpv4PolicyIpv4NextHopName).GetProperty("AdditionalProperties") == null)
                {
                    newNetworkMonitorIpv4PolicyIpv4NextHop = new NetworkMonitorIpv4PolicyIpv4NextHop(JsonConvert.DeserializeObject<NetworkMonitorIpv4PolicyIpv4NextHopName>(jsonString, NetworkMonitorIpv4PolicyIpv4NextHop.SerializerSettings));
                }
                else
                {
                    newNetworkMonitorIpv4PolicyIpv4NextHop = new NetworkMonitorIpv4PolicyIpv4NextHop(JsonConvert.DeserializeObject<NetworkMonitorIpv4PolicyIpv4NextHopName>(jsonString, NetworkMonitorIpv4PolicyIpv4NextHop.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NetworkMonitorIpv4PolicyIpv4NextHopName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NetworkMonitorIpv4PolicyIpv4NextHopName: {1}", jsonString, exception.ToString()));
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
            return newNetworkMonitorIpv4PolicyIpv4NextHop;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkMonitorIpv4PolicyIpv4NextHop);
        }

        /// <summary>
        /// Returns true if NetworkMonitorIpv4PolicyIpv4NextHop instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkMonitorIpv4PolicyIpv4NextHop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkMonitorIpv4PolicyIpv4NextHop input)
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
    /// Custom JSON converter for NetworkMonitorIpv4PolicyIpv4NextHop
    /// </summary>
    public class NetworkMonitorIpv4PolicyIpv4NextHopJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NetworkMonitorIpv4PolicyIpv4NextHop).GetMethod("ToJson").Invoke(value, null)));
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
                return NetworkMonitorIpv4PolicyIpv4NextHop.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
