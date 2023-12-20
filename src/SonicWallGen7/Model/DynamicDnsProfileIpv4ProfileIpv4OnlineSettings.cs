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
    /// Configure dynamic DNS online settings.
    /// </summary>
    [JsonConverter(typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsJsonConverter))]
    [DataContract(Name = "dynamic_dns_profile_ipv4_profile_ipv4_online_settings")]
    public partial class DynamicDnsProfileIpv4ProfileIpv4OnlineSettings : AbstractOpenAPISchema, IEquatable<DynamicDnsProfileIpv4ProfileIpv4OnlineSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDnsProfileIpv4ProfileIpv4OnlineSettings" /> class
        /// with the <see cref="DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan.</param>
        public DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDnsProfileIpv4ProfileIpv4OnlineSettings" /> class
        /// with the <see cref="DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect.</param>
        public DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDnsProfileIpv4ProfileIpv4OnlineSettings" /> class
        /// with the <see cref="DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual.</param>
        public DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual actualInstance)
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
                if (value.GetType() == typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect, DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual, DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan`. If the actual instance is not `DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan</returns>
        public DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan GetDynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan()
        {
            return (DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect`. If the actual instance is not `DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect</returns>
        public DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect GetDynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect()
        {
            return (DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual`. If the actual instance is not `DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual</returns>
        public DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual GetDynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual()
        {
            return (DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicDnsProfileIpv4ProfileIpv4OnlineSettings {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettings
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettings</returns>
        public static DynamicDnsProfileIpv4ProfileIpv4OnlineSettings FromJson(string jsonString)
        {
            DynamicDnsProfileIpv4ProfileIpv4OnlineSettings newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect).GetProperty("AdditionalProperties") == null)
                {
                    newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings = new DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(JsonConvert.DeserializeObject<DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect>(jsonString, DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.SerializerSettings));
                }
                else
                {
                    newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings = new DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(JsonConvert.DeserializeObject<DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect>(jsonString, DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsDetect: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual).GetProperty("AdditionalProperties") == null)
                {
                    newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings = new DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(JsonConvert.DeserializeObject<DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual>(jsonString, DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.SerializerSettings));
                }
                else
                {
                    newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings = new DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(JsonConvert.DeserializeObject<DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual>(jsonString, DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsManual: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan).GetProperty("AdditionalProperties") == null)
                {
                    newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings = new DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(JsonConvert.DeserializeObject<DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan>(jsonString, DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.SerializerSettings));
                }
                else
                {
                    newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings = new DynamicDnsProfileIpv4ProfileIpv4OnlineSettings(JsonConvert.DeserializeObject<DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan>(jsonString, DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsSetToWan: {1}", jsonString, exception.ToString()));
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
            return newDynamicDnsProfileIpv4ProfileIpv4OnlineSettings;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DynamicDnsProfileIpv4ProfileIpv4OnlineSettings);
        }

        /// <summary>
        /// Returns true if DynamicDnsProfileIpv4ProfileIpv4OnlineSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicDnsProfileIpv4ProfileIpv4OnlineSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicDnsProfileIpv4ProfileIpv4OnlineSettings input)
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
    /// Custom JSON converter for DynamicDnsProfileIpv4ProfileIpv4OnlineSettings
    /// </summary>
    public class DynamicDnsProfileIpv4ProfileIpv4OnlineSettingsJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DynamicDnsProfileIpv4ProfileIpv4OnlineSettings).GetMethod("ToJson").Invoke(value, null)));
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
                return DynamicDnsProfileIpv4ProfileIpv4OnlineSettings.FromJson(JObject.Load(reader).ToString(Formatting.None));
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