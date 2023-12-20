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
    /// Weekly.
    /// </summary>
    [JsonConverter(typeof(LogAutomationFtpLogSendLogWeeklyWeeklyJsonConverter))]
    [DataContract(Name = "log_automation_ftp_log_send_log_weekly_weekly")]
    public partial class LogAutomationFtpLogSendLogWeeklyWeekly : AbstractOpenAPISchema, IEquatable<LogAutomationFtpLogSendLogWeeklyWeekly>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationFtpLogSendLogWeeklyWeekly" /> class
        /// with the <see cref="LogAutomationFtpLogSendLogWeeklySun" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogAutomationFtpLogSendLogWeeklySun.</param>
        public LogAutomationFtpLogSendLogWeeklyWeekly(LogAutomationFtpLogSendLogWeeklySun actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationFtpLogSendLogWeeklyWeekly" /> class
        /// with the <see cref="LogAutomationFtpLogSendLogWeeklyMon" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogAutomationFtpLogSendLogWeeklyMon.</param>
        public LogAutomationFtpLogSendLogWeeklyWeekly(LogAutomationFtpLogSendLogWeeklyMon actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationFtpLogSendLogWeeklyWeekly" /> class
        /// with the <see cref="LogAutomationFtpLogSendLogWeeklyTue" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogAutomationFtpLogSendLogWeeklyTue.</param>
        public LogAutomationFtpLogSendLogWeeklyWeekly(LogAutomationFtpLogSendLogWeeklyTue actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationFtpLogSendLogWeeklyWeekly" /> class
        /// with the <see cref="LogAutomationFtpLogSendLogWeeklyWed" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogAutomationFtpLogSendLogWeeklyWed.</param>
        public LogAutomationFtpLogSendLogWeeklyWeekly(LogAutomationFtpLogSendLogWeeklyWed actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationFtpLogSendLogWeeklyWeekly" /> class
        /// with the <see cref="LogAutomationFtpLogSendLogWeeklyThu" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogAutomationFtpLogSendLogWeeklyThu.</param>
        public LogAutomationFtpLogSendLogWeeklyWeekly(LogAutomationFtpLogSendLogWeeklyThu actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationFtpLogSendLogWeeklyWeekly" /> class
        /// with the <see cref="LogAutomationFtpLogSendLogWeeklyFri" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogAutomationFtpLogSendLogWeeklyFri.</param>
        public LogAutomationFtpLogSendLogWeeklyWeekly(LogAutomationFtpLogSendLogWeeklyFri actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogAutomationFtpLogSendLogWeeklyWeekly" /> class
        /// with the <see cref="LogAutomationFtpLogSendLogWeeklySat" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LogAutomationFtpLogSendLogWeeklySat.</param>
        public LogAutomationFtpLogSendLogWeeklyWeekly(LogAutomationFtpLogSendLogWeeklySat actualInstance)
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
                if (value.GetType() == typeof(LogAutomationFtpLogSendLogWeeklyFri))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LogAutomationFtpLogSendLogWeeklyMon))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LogAutomationFtpLogSendLogWeeklySat))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LogAutomationFtpLogSendLogWeeklySun))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LogAutomationFtpLogSendLogWeeklyThu))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LogAutomationFtpLogSendLogWeeklyTue))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LogAutomationFtpLogSendLogWeeklyWed))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: LogAutomationFtpLogSendLogWeeklyFri, LogAutomationFtpLogSendLogWeeklyMon, LogAutomationFtpLogSendLogWeeklySat, LogAutomationFtpLogSendLogWeeklySun, LogAutomationFtpLogSendLogWeeklyThu, LogAutomationFtpLogSendLogWeeklyTue, LogAutomationFtpLogSendLogWeeklyWed");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `LogAutomationFtpLogSendLogWeeklySun`. If the actual instance is not `LogAutomationFtpLogSendLogWeeklySun`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklySun</returns>
        public LogAutomationFtpLogSendLogWeeklySun GetLogAutomationFtpLogSendLogWeeklySun()
        {
            return (LogAutomationFtpLogSendLogWeeklySun)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LogAutomationFtpLogSendLogWeeklyMon`. If the actual instance is not `LogAutomationFtpLogSendLogWeeklyMon`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklyMon</returns>
        public LogAutomationFtpLogSendLogWeeklyMon GetLogAutomationFtpLogSendLogWeeklyMon()
        {
            return (LogAutomationFtpLogSendLogWeeklyMon)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LogAutomationFtpLogSendLogWeeklyTue`. If the actual instance is not `LogAutomationFtpLogSendLogWeeklyTue`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklyTue</returns>
        public LogAutomationFtpLogSendLogWeeklyTue GetLogAutomationFtpLogSendLogWeeklyTue()
        {
            return (LogAutomationFtpLogSendLogWeeklyTue)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LogAutomationFtpLogSendLogWeeklyWed`. If the actual instance is not `LogAutomationFtpLogSendLogWeeklyWed`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklyWed</returns>
        public LogAutomationFtpLogSendLogWeeklyWed GetLogAutomationFtpLogSendLogWeeklyWed()
        {
            return (LogAutomationFtpLogSendLogWeeklyWed)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LogAutomationFtpLogSendLogWeeklyThu`. If the actual instance is not `LogAutomationFtpLogSendLogWeeklyThu`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklyThu</returns>
        public LogAutomationFtpLogSendLogWeeklyThu GetLogAutomationFtpLogSendLogWeeklyThu()
        {
            return (LogAutomationFtpLogSendLogWeeklyThu)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LogAutomationFtpLogSendLogWeeklyFri`. If the actual instance is not `LogAutomationFtpLogSendLogWeeklyFri`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklyFri</returns>
        public LogAutomationFtpLogSendLogWeeklyFri GetLogAutomationFtpLogSendLogWeeklyFri()
        {
            return (LogAutomationFtpLogSendLogWeeklyFri)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LogAutomationFtpLogSendLogWeeklySat`. If the actual instance is not `LogAutomationFtpLogSendLogWeeklySat`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklySat</returns>
        public LogAutomationFtpLogSendLogWeeklySat GetLogAutomationFtpLogSendLogWeeklySat()
        {
            return (LogAutomationFtpLogSendLogWeeklySat)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogAutomationFtpLogSendLogWeeklyWeekly {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of LogAutomationFtpLogSendLogWeeklyWeekly
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of LogAutomationFtpLogSendLogWeeklyWeekly</returns>
        public static LogAutomationFtpLogSendLogWeeklyWeekly FromJson(string jsonString)
        {
            LogAutomationFtpLogSendLogWeeklyWeekly newLogAutomationFtpLogSendLogWeeklyWeekly = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newLogAutomationFtpLogSendLogWeeklyWeekly;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogAutomationFtpLogSendLogWeeklyFri).GetProperty("AdditionalProperties") == null)
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyFri>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings));
                }
                else
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyFri>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogAutomationFtpLogSendLogWeeklyFri");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogAutomationFtpLogSendLogWeeklyFri: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogAutomationFtpLogSendLogWeeklyMon).GetProperty("AdditionalProperties") == null)
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyMon>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings));
                }
                else
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyMon>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogAutomationFtpLogSendLogWeeklyMon");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogAutomationFtpLogSendLogWeeklyMon: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogAutomationFtpLogSendLogWeeklySat).GetProperty("AdditionalProperties") == null)
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklySat>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings));
                }
                else
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklySat>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogAutomationFtpLogSendLogWeeklySat");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogAutomationFtpLogSendLogWeeklySat: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogAutomationFtpLogSendLogWeeklySun).GetProperty("AdditionalProperties") == null)
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklySun>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings));
                }
                else
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklySun>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogAutomationFtpLogSendLogWeeklySun");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogAutomationFtpLogSendLogWeeklySun: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogAutomationFtpLogSendLogWeeklyThu).GetProperty("AdditionalProperties") == null)
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyThu>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings));
                }
                else
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyThu>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogAutomationFtpLogSendLogWeeklyThu");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogAutomationFtpLogSendLogWeeklyThu: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogAutomationFtpLogSendLogWeeklyTue).GetProperty("AdditionalProperties") == null)
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyTue>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings));
                }
                else
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyTue>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogAutomationFtpLogSendLogWeeklyTue");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogAutomationFtpLogSendLogWeeklyTue: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LogAutomationFtpLogSendLogWeeklyWed).GetProperty("AdditionalProperties") == null)
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyWed>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.SerializerSettings));
                }
                else
                {
                    newLogAutomationFtpLogSendLogWeeklyWeekly = new LogAutomationFtpLogSendLogWeeklyWeekly(JsonConvert.DeserializeObject<LogAutomationFtpLogSendLogWeeklyWed>(jsonString, LogAutomationFtpLogSendLogWeeklyWeekly.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LogAutomationFtpLogSendLogWeeklyWed");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LogAutomationFtpLogSendLogWeeklyWed: {1}", jsonString, exception.ToString()));
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
            return newLogAutomationFtpLogSendLogWeeklyWeekly;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogAutomationFtpLogSendLogWeeklyWeekly);
        }

        /// <summary>
        /// Returns true if LogAutomationFtpLogSendLogWeeklyWeekly instances are equal
        /// </summary>
        /// <param name="input">Instance of LogAutomationFtpLogSendLogWeeklyWeekly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogAutomationFtpLogSendLogWeeklyWeekly input)
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
    /// Custom JSON converter for LogAutomationFtpLogSendLogWeeklyWeekly
    /// </summary>
    public class LogAutomationFtpLogSendLogWeeklyWeeklyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(LogAutomationFtpLogSendLogWeeklyWeekly).GetMethod("ToJson").Invoke(value, null)));
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
                return LogAutomationFtpLogSendLogWeeklyWeekly.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
