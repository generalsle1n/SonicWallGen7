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
    /// Specify the translated service for the NAT policy.
    /// </summary>
    [JsonConverter(typeof(NatPolicyIpv6Ipv6TranslatedServiceJsonConverter))]
    [DataContract(Name = "nat_policy_ipv6_ipv6_translated_service")]
    public partial class NatPolicyIpv6Ipv6TranslatedService : AbstractOpenAPISchema, IEquatable<NatPolicyIpv6Ipv6TranslatedService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv6Ipv6TranslatedService" /> class
        /// with the <see cref="NatPolicyIpv6TranslatedServiceOriginal" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv6TranslatedServiceOriginal.</param>
        public NatPolicyIpv6Ipv6TranslatedService(NatPolicyIpv6TranslatedServiceOriginal actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv6Ipv6TranslatedService" /> class
        /// with the <see cref="NatPolicyIpv6TranslatedServiceName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv6TranslatedServiceName.</param>
        public NatPolicyIpv6Ipv6TranslatedService(NatPolicyIpv6TranslatedServiceName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NatPolicyIpv6Ipv6TranslatedService" /> class
        /// with the <see cref="NatPolicyIpv6TranslatedServiceGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NatPolicyIpv6TranslatedServiceGroup.</param>
        public NatPolicyIpv6Ipv6TranslatedService(NatPolicyIpv6TranslatedServiceGroup actualInstance)
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
                if (value.GetType() == typeof(NatPolicyIpv6TranslatedServiceGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NatPolicyIpv6TranslatedServiceName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NatPolicyIpv6TranslatedServiceOriginal))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: NatPolicyIpv6TranslatedServiceGroup, NatPolicyIpv6TranslatedServiceName, NatPolicyIpv6TranslatedServiceOriginal");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv6TranslatedServiceOriginal`. If the actual instance is not `NatPolicyIpv6TranslatedServiceOriginal`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv6TranslatedServiceOriginal</returns>
        public NatPolicyIpv6TranslatedServiceOriginal GetNatPolicyIpv6TranslatedServiceOriginal()
        {
            return (NatPolicyIpv6TranslatedServiceOriginal)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv6TranslatedServiceName`. If the actual instance is not `NatPolicyIpv6TranslatedServiceName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv6TranslatedServiceName</returns>
        public NatPolicyIpv6TranslatedServiceName GetNatPolicyIpv6TranslatedServiceName()
        {
            return (NatPolicyIpv6TranslatedServiceName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NatPolicyIpv6TranslatedServiceGroup`. If the actual instance is not `NatPolicyIpv6TranslatedServiceGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NatPolicyIpv6TranslatedServiceGroup</returns>
        public NatPolicyIpv6TranslatedServiceGroup GetNatPolicyIpv6TranslatedServiceGroup()
        {
            return (NatPolicyIpv6TranslatedServiceGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NatPolicyIpv6Ipv6TranslatedService {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NatPolicyIpv6Ipv6TranslatedService.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NatPolicyIpv6Ipv6TranslatedService
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NatPolicyIpv6Ipv6TranslatedService</returns>
        public static NatPolicyIpv6Ipv6TranslatedService FromJson(string jsonString)
        {
            NatPolicyIpv6Ipv6TranslatedService newNatPolicyIpv6Ipv6TranslatedService = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNatPolicyIpv6Ipv6TranslatedService;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv6TranslatedServiceGroup).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv6Ipv6TranslatedService = new NatPolicyIpv6Ipv6TranslatedService(JsonConvert.DeserializeObject<NatPolicyIpv6TranslatedServiceGroup>(jsonString, NatPolicyIpv6Ipv6TranslatedService.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv6Ipv6TranslatedService = new NatPolicyIpv6Ipv6TranslatedService(JsonConvert.DeserializeObject<NatPolicyIpv6TranslatedServiceGroup>(jsonString, NatPolicyIpv6Ipv6TranslatedService.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv6TranslatedServiceGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv6TranslatedServiceGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv6TranslatedServiceName).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv6Ipv6TranslatedService = new NatPolicyIpv6Ipv6TranslatedService(JsonConvert.DeserializeObject<NatPolicyIpv6TranslatedServiceName>(jsonString, NatPolicyIpv6Ipv6TranslatedService.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv6Ipv6TranslatedService = new NatPolicyIpv6Ipv6TranslatedService(JsonConvert.DeserializeObject<NatPolicyIpv6TranslatedServiceName>(jsonString, NatPolicyIpv6Ipv6TranslatedService.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv6TranslatedServiceName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv6TranslatedServiceName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NatPolicyIpv6TranslatedServiceOriginal).GetProperty("AdditionalProperties") == null)
                {
                    newNatPolicyIpv6Ipv6TranslatedService = new NatPolicyIpv6Ipv6TranslatedService(JsonConvert.DeserializeObject<NatPolicyIpv6TranslatedServiceOriginal>(jsonString, NatPolicyIpv6Ipv6TranslatedService.SerializerSettings));
                }
                else
                {
                    newNatPolicyIpv6Ipv6TranslatedService = new NatPolicyIpv6Ipv6TranslatedService(JsonConvert.DeserializeObject<NatPolicyIpv6TranslatedServiceOriginal>(jsonString, NatPolicyIpv6Ipv6TranslatedService.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("NatPolicyIpv6TranslatedServiceOriginal");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NatPolicyIpv6TranslatedServiceOriginal: {1}", jsonString, exception.ToString()));
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
            return newNatPolicyIpv6Ipv6TranslatedService;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NatPolicyIpv6Ipv6TranslatedService);
        }

        /// <summary>
        /// Returns true if NatPolicyIpv6Ipv6TranslatedService instances are equal
        /// </summary>
        /// <param name="input">Instance of NatPolicyIpv6Ipv6TranslatedService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NatPolicyIpv6Ipv6TranslatedService input)
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
    /// Custom JSON converter for NatPolicyIpv6Ipv6TranslatedService
    /// </summary>
    public class NatPolicyIpv6Ipv6TranslatedServiceJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NatPolicyIpv6Ipv6TranslatedService).GetMethod("ToJson").Invoke(value, null)));
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
                return NatPolicyIpv6Ipv6TranslatedService.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
