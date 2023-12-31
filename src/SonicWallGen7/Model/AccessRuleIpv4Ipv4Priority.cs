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
    /// Set access rule priority
    /// </summary>
    [JsonConverter(typeof(AccessRuleIpv4Ipv4PriorityJsonConverter))]
    [DataContract(Name = "access_rule_ipv4_ipv4_priority")]
    public partial class AccessRuleIpv4Ipv4Priority : AbstractOpenAPISchema, IEquatable<AccessRuleIpv4Ipv4Priority>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4Priority" /> class
        /// with the <see cref="AccessRuleIpv4PriorityAuto" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4PriorityAuto.</param>
        public AccessRuleIpv4Ipv4Priority(AccessRuleIpv4PriorityAuto actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4Priority" /> class
        /// with the <see cref="AccessRuleIpv4PriorityEnd" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4PriorityEnd.</param>
        public AccessRuleIpv4Ipv4Priority(AccessRuleIpv4PriorityEnd actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4Priority" /> class
        /// with the <see cref="AccessRuleIpv4PriorityManual" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4PriorityManual.</param>
        public AccessRuleIpv4Ipv4Priority(AccessRuleIpv4PriorityManual actualInstance)
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
                if (value.GetType() == typeof(AccessRuleIpv4PriorityAuto))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4PriorityEnd))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4PriorityManual))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AccessRuleIpv4PriorityAuto, AccessRuleIpv4PriorityEnd, AccessRuleIpv4PriorityManual");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4PriorityAuto`. If the actual instance is not `AccessRuleIpv4PriorityAuto`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4PriorityAuto</returns>
        public AccessRuleIpv4PriorityAuto GetAccessRuleIpv4PriorityAuto()
        {
            return (AccessRuleIpv4PriorityAuto)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4PriorityEnd`. If the actual instance is not `AccessRuleIpv4PriorityEnd`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4PriorityEnd</returns>
        public AccessRuleIpv4PriorityEnd GetAccessRuleIpv4PriorityEnd()
        {
            return (AccessRuleIpv4PriorityEnd)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4PriorityManual`. If the actual instance is not `AccessRuleIpv4PriorityManual`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4PriorityManual</returns>
        public AccessRuleIpv4PriorityManual GetAccessRuleIpv4PriorityManual()
        {
            return (AccessRuleIpv4PriorityManual)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRuleIpv4Ipv4Priority {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AccessRuleIpv4Ipv4Priority.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AccessRuleIpv4Ipv4Priority
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AccessRuleIpv4Ipv4Priority</returns>
        public static AccessRuleIpv4Ipv4Priority FromJson(string jsonString)
        {
            AccessRuleIpv4Ipv4Priority newAccessRuleIpv4Ipv4Priority = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAccessRuleIpv4Ipv4Priority;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4PriorityAuto).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4Priority = new AccessRuleIpv4Ipv4Priority(JsonConvert.DeserializeObject<AccessRuleIpv4PriorityAuto>(jsonString, AccessRuleIpv4Ipv4Priority.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4Priority = new AccessRuleIpv4Ipv4Priority(JsonConvert.DeserializeObject<AccessRuleIpv4PriorityAuto>(jsonString, AccessRuleIpv4Ipv4Priority.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4PriorityAuto");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4PriorityAuto: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4PriorityEnd).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4Priority = new AccessRuleIpv4Ipv4Priority(JsonConvert.DeserializeObject<AccessRuleIpv4PriorityEnd>(jsonString, AccessRuleIpv4Ipv4Priority.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4Priority = new AccessRuleIpv4Ipv4Priority(JsonConvert.DeserializeObject<AccessRuleIpv4PriorityEnd>(jsonString, AccessRuleIpv4Ipv4Priority.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4PriorityEnd");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4PriorityEnd: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4PriorityManual).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4Priority = new AccessRuleIpv4Ipv4Priority(JsonConvert.DeserializeObject<AccessRuleIpv4PriorityManual>(jsonString, AccessRuleIpv4Ipv4Priority.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4Priority = new AccessRuleIpv4Ipv4Priority(JsonConvert.DeserializeObject<AccessRuleIpv4PriorityManual>(jsonString, AccessRuleIpv4Ipv4Priority.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4PriorityManual");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4PriorityManual: {1}", jsonString, exception.ToString()));
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
            return newAccessRuleIpv4Ipv4Priority;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessRuleIpv4Ipv4Priority);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv4Ipv4Priority instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv4Ipv4Priority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv4Ipv4Priority input)
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
    /// Custom JSON converter for AccessRuleIpv4Ipv4Priority
    /// </summary>
    public class AccessRuleIpv4Ipv4PriorityJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AccessRuleIpv4Ipv4Priority).GetMethod("ToJson").Invoke(value, null)));
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
                return AccessRuleIpv4Ipv4Priority.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
