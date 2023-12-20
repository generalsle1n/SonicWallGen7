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
    /// Specify a destination service for this Access Policy.
    /// </summary>
    [JsonConverter(typeof(AccessRuleIpv6Ipv6ServiceJsonConverter))]
    [DataContract(Name = "access_rule_ipv6_ipv6_service")]
    public partial class AccessRuleIpv6Ipv6Service : AbstractOpenAPISchema, IEquatable<AccessRuleIpv6Ipv6Service>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6Service" /> class
        /// with the <see cref="AccessRuleIpv6ServiceAny" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv6ServiceAny.</param>
        public AccessRuleIpv6Ipv6Service(AccessRuleIpv6ServiceAny actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6Service" /> class
        /// with the <see cref="AccessRuleIpv6ServiceName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv6ServiceName.</param>
        public AccessRuleIpv6Ipv6Service(AccessRuleIpv6ServiceName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6Service" /> class
        /// with the <see cref="AccessRuleIpv6ServiceGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv6ServiceGroup.</param>
        public AccessRuleIpv6Ipv6Service(AccessRuleIpv6ServiceGroup actualInstance)
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
                if (value.GetType() == typeof(AccessRuleIpv6ServiceAny))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv6ServiceGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv6ServiceName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AccessRuleIpv6ServiceAny, AccessRuleIpv6ServiceGroup, AccessRuleIpv6ServiceName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv6ServiceAny`. If the actual instance is not `AccessRuleIpv6ServiceAny`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv6ServiceAny</returns>
        public AccessRuleIpv6ServiceAny GetAccessRuleIpv6ServiceAny()
        {
            return (AccessRuleIpv6ServiceAny)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv6ServiceName`. If the actual instance is not `AccessRuleIpv6ServiceName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv6ServiceName</returns>
        public AccessRuleIpv6ServiceName GetAccessRuleIpv6ServiceName()
        {
            return (AccessRuleIpv6ServiceName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv6ServiceGroup`. If the actual instance is not `AccessRuleIpv6ServiceGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv6ServiceGroup</returns>
        public AccessRuleIpv6ServiceGroup GetAccessRuleIpv6ServiceGroup()
        {
            return (AccessRuleIpv6ServiceGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRuleIpv6Ipv6Service {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AccessRuleIpv6Ipv6Service.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AccessRuleIpv6Ipv6Service
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AccessRuleIpv6Ipv6Service</returns>
        public static AccessRuleIpv6Ipv6Service FromJson(string jsonString)
        {
            AccessRuleIpv6Ipv6Service newAccessRuleIpv6Ipv6Service = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAccessRuleIpv6Ipv6Service;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv6ServiceAny).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv6Ipv6Service = new AccessRuleIpv6Ipv6Service(JsonConvert.DeserializeObject<AccessRuleIpv6ServiceAny>(jsonString, AccessRuleIpv6Ipv6Service.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv6Ipv6Service = new AccessRuleIpv6Ipv6Service(JsonConvert.DeserializeObject<AccessRuleIpv6ServiceAny>(jsonString, AccessRuleIpv6Ipv6Service.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv6ServiceAny");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv6ServiceAny: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv6ServiceGroup).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv6Ipv6Service = new AccessRuleIpv6Ipv6Service(JsonConvert.DeserializeObject<AccessRuleIpv6ServiceGroup>(jsonString, AccessRuleIpv6Ipv6Service.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv6Ipv6Service = new AccessRuleIpv6Ipv6Service(JsonConvert.DeserializeObject<AccessRuleIpv6ServiceGroup>(jsonString, AccessRuleIpv6Ipv6Service.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv6ServiceGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv6ServiceGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv6ServiceName).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv6Ipv6Service = new AccessRuleIpv6Ipv6Service(JsonConvert.DeserializeObject<AccessRuleIpv6ServiceName>(jsonString, AccessRuleIpv6Ipv6Service.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv6Ipv6Service = new AccessRuleIpv6Ipv6Service(JsonConvert.DeserializeObject<AccessRuleIpv6ServiceName>(jsonString, AccessRuleIpv6Ipv6Service.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv6ServiceName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv6ServiceName: {1}", jsonString, exception.ToString()));
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
            return newAccessRuleIpv6Ipv6Service;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessRuleIpv6Ipv6Service);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv6Ipv6Service instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv6Ipv6Service to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv6Ipv6Service input)
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
    /// Custom JSON converter for AccessRuleIpv6Ipv6Service
    /// </summary>
    public class AccessRuleIpv6Ipv6ServiceJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AccessRuleIpv6Ipv6Service).GetMethod("ToJson").Invoke(value, null)));
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
                return AccessRuleIpv6Ipv6Service.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
