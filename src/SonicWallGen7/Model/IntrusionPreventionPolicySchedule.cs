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
    /// Set IPS policy schedule.
    /// </summary>
    [JsonConverter(typeof(IntrusionPreventionPolicyScheduleJsonConverter))]
    [DataContract(Name = "intrusion_prevention_policy_schedule")]
    public partial class IntrusionPreventionPolicySchedule : AbstractOpenAPISchema, IEquatable<IntrusionPreventionPolicySchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionPolicySchedule" /> class
        /// with the <see cref="IntrusionPreventionPolicyScheduleCategory" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IntrusionPreventionPolicyScheduleCategory.</param>
        public IntrusionPreventionPolicySchedule(IntrusionPreventionPolicyScheduleCategory actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionPolicySchedule" /> class
        /// with the <see cref="IntrusionPreventionPolicyScheduleAlwaysOn" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IntrusionPreventionPolicyScheduleAlwaysOn.</param>
        public IntrusionPreventionPolicySchedule(IntrusionPreventionPolicyScheduleAlwaysOn actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionPolicySchedule" /> class
        /// with the <see cref="IntrusionPreventionPolicyScheduleName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IntrusionPreventionPolicyScheduleName.</param>
        public IntrusionPreventionPolicySchedule(IntrusionPreventionPolicyScheduleName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntrusionPreventionPolicySchedule" /> class
        /// with the <see cref="IntrusionPreventionPolicyScheduleDays" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of IntrusionPreventionPolicyScheduleDays.</param>
        public IntrusionPreventionPolicySchedule(IntrusionPreventionPolicyScheduleDays actualInstance)
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
                if (value.GetType() == typeof(IntrusionPreventionPolicyScheduleAlwaysOn))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IntrusionPreventionPolicyScheduleCategory))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IntrusionPreventionPolicyScheduleDays))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(IntrusionPreventionPolicyScheduleName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: IntrusionPreventionPolicyScheduleAlwaysOn, IntrusionPreventionPolicyScheduleCategory, IntrusionPreventionPolicyScheduleDays, IntrusionPreventionPolicyScheduleName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `IntrusionPreventionPolicyScheduleCategory`. If the actual instance is not `IntrusionPreventionPolicyScheduleCategory`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IntrusionPreventionPolicyScheduleCategory</returns>
        public IntrusionPreventionPolicyScheduleCategory GetIntrusionPreventionPolicyScheduleCategory()
        {
            return (IntrusionPreventionPolicyScheduleCategory)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IntrusionPreventionPolicyScheduleAlwaysOn`. If the actual instance is not `IntrusionPreventionPolicyScheduleAlwaysOn`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IntrusionPreventionPolicyScheduleAlwaysOn</returns>
        public IntrusionPreventionPolicyScheduleAlwaysOn GetIntrusionPreventionPolicyScheduleAlwaysOn()
        {
            return (IntrusionPreventionPolicyScheduleAlwaysOn)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IntrusionPreventionPolicyScheduleName`. If the actual instance is not `IntrusionPreventionPolicyScheduleName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IntrusionPreventionPolicyScheduleName</returns>
        public IntrusionPreventionPolicyScheduleName GetIntrusionPreventionPolicyScheduleName()
        {
            return (IntrusionPreventionPolicyScheduleName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `IntrusionPreventionPolicyScheduleDays`. If the actual instance is not `IntrusionPreventionPolicyScheduleDays`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of IntrusionPreventionPolicyScheduleDays</returns>
        public IntrusionPreventionPolicyScheduleDays GetIntrusionPreventionPolicyScheduleDays()
        {
            return (IntrusionPreventionPolicyScheduleDays)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntrusionPreventionPolicySchedule {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, IntrusionPreventionPolicySchedule.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of IntrusionPreventionPolicySchedule
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of IntrusionPreventionPolicySchedule</returns>
        public static IntrusionPreventionPolicySchedule FromJson(string jsonString)
        {
            IntrusionPreventionPolicySchedule newIntrusionPreventionPolicySchedule = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newIntrusionPreventionPolicySchedule;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IntrusionPreventionPolicyScheduleAlwaysOn).GetProperty("AdditionalProperties") == null)
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleAlwaysOn>(jsonString, IntrusionPreventionPolicySchedule.SerializerSettings));
                }
                else
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleAlwaysOn>(jsonString, IntrusionPreventionPolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IntrusionPreventionPolicyScheduleAlwaysOn");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IntrusionPreventionPolicyScheduleAlwaysOn: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IntrusionPreventionPolicyScheduleCategory).GetProperty("AdditionalProperties") == null)
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleCategory>(jsonString, IntrusionPreventionPolicySchedule.SerializerSettings));
                }
                else
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleCategory>(jsonString, IntrusionPreventionPolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IntrusionPreventionPolicyScheduleCategory");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IntrusionPreventionPolicyScheduleCategory: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IntrusionPreventionPolicyScheduleDays).GetProperty("AdditionalProperties") == null)
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleDays>(jsonString, IntrusionPreventionPolicySchedule.SerializerSettings));
                }
                else
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleDays>(jsonString, IntrusionPreventionPolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IntrusionPreventionPolicyScheduleDays");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IntrusionPreventionPolicyScheduleDays: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(IntrusionPreventionPolicyScheduleName).GetProperty("AdditionalProperties") == null)
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleName>(jsonString, IntrusionPreventionPolicySchedule.SerializerSettings));
                }
                else
                {
                    newIntrusionPreventionPolicySchedule = new IntrusionPreventionPolicySchedule(JsonConvert.DeserializeObject<IntrusionPreventionPolicyScheduleName>(jsonString, IntrusionPreventionPolicySchedule.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("IntrusionPreventionPolicyScheduleName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into IntrusionPreventionPolicyScheduleName: {1}", jsonString, exception.ToString()));
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
            return newIntrusionPreventionPolicySchedule;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntrusionPreventionPolicySchedule);
        }

        /// <summary>
        /// Returns true if IntrusionPreventionPolicySchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of IntrusionPreventionPolicySchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntrusionPreventionPolicySchedule input)
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
    /// Custom JSON converter for IntrusionPreventionPolicySchedule
    /// </summary>
    public class IntrusionPreventionPolicyScheduleJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(IntrusionPreventionPolicySchedule).GetMethod("ToJson").Invoke(value, null)));
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
                return IntrusionPreventionPolicySchedule.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
