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
    /// Set anti-spyware product schedule.
    /// </summary>
    [JsonConverter(typeof(AntiSpywarePolicyScheduleJsonConverter))]
    [DataContract(Name = "anti_spyware_policy_schedule")]
    public partial class AntiSpywarePolicySchedule : AbstractOpenAPISchema, IEquatable<AntiSpywarePolicySchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntiSpywarePolicySchedule" /> class
        /// with the <see cref="AntiSpywarePolicyScheduleProduct" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AntiSpywarePolicyScheduleProduct.</param>
        public AntiSpywarePolicySchedule(AntiSpywarePolicyScheduleProduct actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AntiSpywarePolicySchedule" /> class
        /// with the <see cref="AntiSpywarePolicyScheduleAlwaysOn" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AntiSpywarePolicyScheduleAlwaysOn.</param>
        public AntiSpywarePolicySchedule(AntiSpywarePolicyScheduleAlwaysOn actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AntiSpywarePolicySchedule" /> class
        /// with the <see cref="AntiSpywarePolicyScheduleName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AntiSpywarePolicyScheduleName.</param>
        public AntiSpywarePolicySchedule(AntiSpywarePolicyScheduleName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AntiSpywarePolicySchedule" /> class
        /// with the <see cref="AntiSpywarePolicyScheduleDays" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AntiSpywarePolicyScheduleDays.</param>
        public AntiSpywarePolicySchedule(AntiSpywarePolicyScheduleDays actualInstance)
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
                if (value.GetType() == typeof(AntiSpywarePolicyScheduleAlwaysOn))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AntiSpywarePolicyScheduleDays))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AntiSpywarePolicyScheduleName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AntiSpywarePolicyScheduleProduct))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AntiSpywarePolicyScheduleAlwaysOn, AntiSpywarePolicyScheduleDays, AntiSpywarePolicyScheduleName, AntiSpywarePolicyScheduleProduct");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AntiSpywarePolicyScheduleProduct`. If the actual instance is not `AntiSpywarePolicyScheduleProduct`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AntiSpywarePolicyScheduleProduct</returns>
        public AntiSpywarePolicyScheduleProduct GetAntiSpywarePolicyScheduleProduct()
        {
            return (AntiSpywarePolicyScheduleProduct)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AntiSpywarePolicyScheduleAlwaysOn`. If the actual instance is not `AntiSpywarePolicyScheduleAlwaysOn`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AntiSpywarePolicyScheduleAlwaysOn</returns>
        public AntiSpywarePolicyScheduleAlwaysOn GetAntiSpywarePolicyScheduleAlwaysOn()
        {
            return (AntiSpywarePolicyScheduleAlwaysOn)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AntiSpywarePolicyScheduleName`. If the actual instance is not `AntiSpywarePolicyScheduleName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AntiSpywarePolicyScheduleName</returns>
        public AntiSpywarePolicyScheduleName GetAntiSpywarePolicyScheduleName()
        {
            return (AntiSpywarePolicyScheduleName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AntiSpywarePolicyScheduleDays`. If the actual instance is not `AntiSpywarePolicyScheduleDays`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AntiSpywarePolicyScheduleDays</returns>
        public AntiSpywarePolicyScheduleDays GetAntiSpywarePolicyScheduleDays()
        {
            return (AntiSpywarePolicyScheduleDays)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntiSpywarePolicySchedule {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AntiSpywarePolicySchedule.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AntiSpywarePolicySchedule
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AntiSpywarePolicySchedule</returns>
        public static AntiSpywarePolicySchedule FromJson(string jsonString)
        {
            AntiSpywarePolicySchedule newAntiSpywarePolicySchedule = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAntiSpywarePolicySchedule;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AntiSpywarePolicyScheduleAlwaysOn).GetProperty("AdditionalProperties") == null)
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleAlwaysOn>(jsonString, AntiSpywarePolicySchedule.SerializerSettings));
                }
                else
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleAlwaysOn>(jsonString, AntiSpywarePolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AntiSpywarePolicyScheduleAlwaysOn");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AntiSpywarePolicyScheduleAlwaysOn: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AntiSpywarePolicyScheduleDays).GetProperty("AdditionalProperties") == null)
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleDays>(jsonString, AntiSpywarePolicySchedule.SerializerSettings));
                }
                else
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleDays>(jsonString, AntiSpywarePolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AntiSpywarePolicyScheduleDays");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AntiSpywarePolicyScheduleDays: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AntiSpywarePolicyScheduleName).GetProperty("AdditionalProperties") == null)
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleName>(jsonString, AntiSpywarePolicySchedule.SerializerSettings));
                }
                else
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleName>(jsonString, AntiSpywarePolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AntiSpywarePolicyScheduleName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AntiSpywarePolicyScheduleName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AntiSpywarePolicyScheduleProduct).GetProperty("AdditionalProperties") == null)
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleProduct>(jsonString, AntiSpywarePolicySchedule.SerializerSettings));
                }
                else
                {
                    newAntiSpywarePolicySchedule = new AntiSpywarePolicySchedule(JsonConvert.DeserializeObject<AntiSpywarePolicyScheduleProduct>(jsonString, AntiSpywarePolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AntiSpywarePolicyScheduleProduct");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AntiSpywarePolicyScheduleProduct: {1}", jsonString, exception.ToString()));
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
            return newAntiSpywarePolicySchedule;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AntiSpywarePolicySchedule);
        }

        /// <summary>
        /// Returns true if AntiSpywarePolicySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of AntiSpywarePolicySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntiSpywarePolicySchedule input)
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
    /// Custom JSON converter for AntiSpywarePolicySchedule
    /// </summary>
    public class AntiSpywarePolicyScheduleJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AntiSpywarePolicySchedule).GetMethod("ToJson").Invoke(value, null)));
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
                return AntiSpywarePolicySchedule.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
