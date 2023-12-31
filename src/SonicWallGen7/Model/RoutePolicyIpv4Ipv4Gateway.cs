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
    /// Set route policy gateway.
    /// </summary>
    [JsonConverter(typeof(RoutePolicyIpv4Ipv4GatewayJsonConverter))]
    [DataContract(Name = "route_policy_ipv4_ipv4_gateway")]
    public partial class RoutePolicyIpv4Ipv4Gateway : AbstractOpenAPISchema, IEquatable<RoutePolicyIpv4Ipv4Gateway>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutePolicyIpv4Ipv4Gateway" /> class
        /// with the <see cref="RoutePolicyIpv4GatewayDefault" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RoutePolicyIpv4GatewayDefault.</param>
        public RoutePolicyIpv4Ipv4Gateway(RoutePolicyIpv4GatewayDefault actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutePolicyIpv4Ipv4Gateway" /> class
        /// with the <see cref="RoutePolicyIpv4GatewayName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RoutePolicyIpv4GatewayName.</param>
        public RoutePolicyIpv4Ipv4Gateway(RoutePolicyIpv4GatewayName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutePolicyIpv4Ipv4Gateway" /> class
        /// with the <see cref="RoutePolicyIpv4GatewayHost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RoutePolicyIpv4GatewayHost.</param>
        public RoutePolicyIpv4Ipv4Gateway(RoutePolicyIpv4GatewayHost actualInstance)
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
                if (value.GetType() == typeof(RoutePolicyIpv4GatewayDefault))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RoutePolicyIpv4GatewayHost))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RoutePolicyIpv4GatewayName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: RoutePolicyIpv4GatewayDefault, RoutePolicyIpv4GatewayHost, RoutePolicyIpv4GatewayName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `RoutePolicyIpv4GatewayDefault`. If the actual instance is not `RoutePolicyIpv4GatewayDefault`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RoutePolicyIpv4GatewayDefault</returns>
        public RoutePolicyIpv4GatewayDefault GetRoutePolicyIpv4GatewayDefault()
        {
            return (RoutePolicyIpv4GatewayDefault)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RoutePolicyIpv4GatewayName`. If the actual instance is not `RoutePolicyIpv4GatewayName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RoutePolicyIpv4GatewayName</returns>
        public RoutePolicyIpv4GatewayName GetRoutePolicyIpv4GatewayName()
        {
            return (RoutePolicyIpv4GatewayName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RoutePolicyIpv4GatewayHost`. If the actual instance is not `RoutePolicyIpv4GatewayHost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RoutePolicyIpv4GatewayHost</returns>
        public RoutePolicyIpv4GatewayHost GetRoutePolicyIpv4GatewayHost()
        {
            return (RoutePolicyIpv4GatewayHost)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutePolicyIpv4Ipv4Gateway {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, RoutePolicyIpv4Ipv4Gateway.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of RoutePolicyIpv4Ipv4Gateway
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of RoutePolicyIpv4Ipv4Gateway</returns>
        public static RoutePolicyIpv4Ipv4Gateway FromJson(string jsonString)
        {
            RoutePolicyIpv4Ipv4Gateway newRoutePolicyIpv4Ipv4Gateway = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newRoutePolicyIpv4Ipv4Gateway;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RoutePolicyIpv4GatewayDefault).GetProperty("AdditionalProperties") == null)
                {
                    newRoutePolicyIpv4Ipv4Gateway = new RoutePolicyIpv4Ipv4Gateway(JsonConvert.DeserializeObject<RoutePolicyIpv4GatewayDefault>(jsonString, RoutePolicyIpv4Ipv4Gateway.SerializerSettings));
                }
                else
                {
                    newRoutePolicyIpv4Ipv4Gateway = new RoutePolicyIpv4Ipv4Gateway(JsonConvert.DeserializeObject<RoutePolicyIpv4GatewayDefault>(jsonString, RoutePolicyIpv4Ipv4Gateway.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RoutePolicyIpv4GatewayDefault");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RoutePolicyIpv4GatewayDefault: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RoutePolicyIpv4GatewayHost).GetProperty("AdditionalProperties") == null)
                {
                    newRoutePolicyIpv4Ipv4Gateway = new RoutePolicyIpv4Ipv4Gateway(JsonConvert.DeserializeObject<RoutePolicyIpv4GatewayHost>(jsonString, RoutePolicyIpv4Ipv4Gateway.SerializerSettings));
                }
                else
                {
                    newRoutePolicyIpv4Ipv4Gateway = new RoutePolicyIpv4Ipv4Gateway(JsonConvert.DeserializeObject<RoutePolicyIpv4GatewayHost>(jsonString, RoutePolicyIpv4Ipv4Gateway.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RoutePolicyIpv4GatewayHost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RoutePolicyIpv4GatewayHost: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RoutePolicyIpv4GatewayName).GetProperty("AdditionalProperties") == null)
                {
                    newRoutePolicyIpv4Ipv4Gateway = new RoutePolicyIpv4Ipv4Gateway(JsonConvert.DeserializeObject<RoutePolicyIpv4GatewayName>(jsonString, RoutePolicyIpv4Ipv4Gateway.SerializerSettings));
                }
                else
                {
                    newRoutePolicyIpv4Ipv4Gateway = new RoutePolicyIpv4Ipv4Gateway(JsonConvert.DeserializeObject<RoutePolicyIpv4GatewayName>(jsonString, RoutePolicyIpv4Ipv4Gateway.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RoutePolicyIpv4GatewayName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RoutePolicyIpv4GatewayName: {1}", jsonString, exception.ToString()));
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
            return newRoutePolicyIpv4Ipv4Gateway;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoutePolicyIpv4Ipv4Gateway);
        }

        /// <summary>
        /// Returns true if RoutePolicyIpv4Ipv4Gateway instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutePolicyIpv4Ipv4Gateway to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutePolicyIpv4Ipv4Gateway input)
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
    /// Custom JSON converter for RoutePolicyIpv4Ipv4Gateway
    /// </summary>
    public class RoutePolicyIpv4Ipv4GatewayJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(RoutePolicyIpv4Ipv4Gateway).GetMethod("ToJson").Invoke(value, null)));
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
                return RoutePolicyIpv4Ipv4Gateway.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
