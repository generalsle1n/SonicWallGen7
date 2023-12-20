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
    /// Specify a source port for this Access Policy.
    /// </summary>
    [JsonConverter(typeof(AccessRuleIpv6Ipv6SourcePortJsonConverter))]
    [DataContract(Name = "access_rule_ipv6_ipv6_source_port")]
    public partial class AccessRuleIpv6Ipv6SourcePort : AbstractOpenAPISchema, IEquatable<AccessRuleIpv6Ipv6SourcePort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6SourcePort" /> class
        /// with the <see cref="AccessRuleIpv6SourcePortAny" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv6SourcePortAny.</param>
        public AccessRuleIpv6Ipv6SourcePort(AccessRuleIpv6SourcePortAny actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6SourcePort" /> class
        /// with the <see cref="AccessRuleIpv6SourcePortName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv6SourcePortName.</param>
        public AccessRuleIpv6Ipv6SourcePort(AccessRuleIpv6SourcePortName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv6Ipv6SourcePort" /> class
        /// with the <see cref="AccessRuleIpv6SourcePortGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv6SourcePortGroup.</param>
        public AccessRuleIpv6Ipv6SourcePort(AccessRuleIpv6SourcePortGroup actualInstance)
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
                if (value.GetType() == typeof(AccessRuleIpv6SourcePortAny))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv6SourcePortGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv6SourcePortName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AccessRuleIpv6SourcePortAny, AccessRuleIpv6SourcePortGroup, AccessRuleIpv6SourcePortName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv6SourcePortAny`. If the actual instance is not `AccessRuleIpv6SourcePortAny`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv6SourcePortAny</returns>
        public AccessRuleIpv6SourcePortAny GetAccessRuleIpv6SourcePortAny()
        {
            return (AccessRuleIpv6SourcePortAny)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv6SourcePortName`. If the actual instance is not `AccessRuleIpv6SourcePortName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv6SourcePortName</returns>
        public AccessRuleIpv6SourcePortName GetAccessRuleIpv6SourcePortName()
        {
            return (AccessRuleIpv6SourcePortName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv6SourcePortGroup`. If the actual instance is not `AccessRuleIpv6SourcePortGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv6SourcePortGroup</returns>
        public AccessRuleIpv6SourcePortGroup GetAccessRuleIpv6SourcePortGroup()
        {
            return (AccessRuleIpv6SourcePortGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRuleIpv6Ipv6SourcePort {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AccessRuleIpv6Ipv6SourcePort.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AccessRuleIpv6Ipv6SourcePort
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AccessRuleIpv6Ipv6SourcePort</returns>
        public static AccessRuleIpv6Ipv6SourcePort FromJson(string jsonString)
        {
            AccessRuleIpv6Ipv6SourcePort newAccessRuleIpv6Ipv6SourcePort = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAccessRuleIpv6Ipv6SourcePort;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv6SourcePortAny).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv6Ipv6SourcePort = new AccessRuleIpv6Ipv6SourcePort(JsonConvert.DeserializeObject<AccessRuleIpv6SourcePortAny>(jsonString, AccessRuleIpv6Ipv6SourcePort.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv6Ipv6SourcePort = new AccessRuleIpv6Ipv6SourcePort(JsonConvert.DeserializeObject<AccessRuleIpv6SourcePortAny>(jsonString, AccessRuleIpv6Ipv6SourcePort.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv6SourcePortAny");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv6SourcePortAny: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv6SourcePortGroup).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv6Ipv6SourcePort = new AccessRuleIpv6Ipv6SourcePort(JsonConvert.DeserializeObject<AccessRuleIpv6SourcePortGroup>(jsonString, AccessRuleIpv6Ipv6SourcePort.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv6Ipv6SourcePort = new AccessRuleIpv6Ipv6SourcePort(JsonConvert.DeserializeObject<AccessRuleIpv6SourcePortGroup>(jsonString, AccessRuleIpv6Ipv6SourcePort.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv6SourcePortGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv6SourcePortGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv6SourcePortName).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv6Ipv6SourcePort = new AccessRuleIpv6Ipv6SourcePort(JsonConvert.DeserializeObject<AccessRuleIpv6SourcePortName>(jsonString, AccessRuleIpv6Ipv6SourcePort.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv6Ipv6SourcePort = new AccessRuleIpv6Ipv6SourcePort(JsonConvert.DeserializeObject<AccessRuleIpv6SourcePortName>(jsonString, AccessRuleIpv6Ipv6SourcePort.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv6SourcePortName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv6SourcePortName: {1}", jsonString, exception.ToString()));
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
            return newAccessRuleIpv6Ipv6SourcePort;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessRuleIpv6Ipv6SourcePort);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv6Ipv6SourcePort instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv6Ipv6SourcePort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv6Ipv6SourcePort input)
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
    /// Custom JSON converter for AccessRuleIpv6Ipv6SourcePort
    /// </summary>
    public class AccessRuleIpv6Ipv6SourcePortJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AccessRuleIpv6Ipv6SourcePort).GetMethod("ToJson").Invoke(value, null)));
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
                return AccessRuleIpv6Ipv6SourcePort.FromJson(JObject.Load(reader).ToString(Formatting.None));
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