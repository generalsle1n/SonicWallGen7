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
    /// Assign application group to security policy.
    /// </summary>
    [JsonConverter(typeof(SecurityPolicyIpv4Ipv4ApplicationJsonConverter))]
    [DataContract(Name = "security_policy_ipv4_ipv4_application")]
    public partial class SecurityPolicyIpv4Ipv4Application : AbstractOpenAPISchema, IEquatable<SecurityPolicyIpv4Ipv4Application>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityPolicyIpv4Ipv4Application" /> class
        /// with the <see cref="SecurityPolicyIpv4ApplicationAny" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SecurityPolicyIpv4ApplicationAny.</param>
        public SecurityPolicyIpv4Ipv4Application(SecurityPolicyIpv4ApplicationAny actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityPolicyIpv4Ipv4Application" /> class
        /// with the <see cref="SecurityPolicyIpv4ApplicationGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SecurityPolicyIpv4ApplicationGroup.</param>
        public SecurityPolicyIpv4Ipv4Application(SecurityPolicyIpv4ApplicationGroup actualInstance)
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
                if (value.GetType() == typeof(SecurityPolicyIpv4ApplicationAny))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SecurityPolicyIpv4ApplicationGroup))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: SecurityPolicyIpv4ApplicationAny, SecurityPolicyIpv4ApplicationGroup");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `SecurityPolicyIpv4ApplicationAny`. If the actual instance is not `SecurityPolicyIpv4ApplicationAny`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SecurityPolicyIpv4ApplicationAny</returns>
        public SecurityPolicyIpv4ApplicationAny GetSecurityPolicyIpv4ApplicationAny()
        {
            return (SecurityPolicyIpv4ApplicationAny)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SecurityPolicyIpv4ApplicationGroup`. If the actual instance is not `SecurityPolicyIpv4ApplicationGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SecurityPolicyIpv4ApplicationGroup</returns>
        public SecurityPolicyIpv4ApplicationGroup GetSecurityPolicyIpv4ApplicationGroup()
        {
            return (SecurityPolicyIpv4ApplicationGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityPolicyIpv4Ipv4Application {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SecurityPolicyIpv4Ipv4Application.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SecurityPolicyIpv4Ipv4Application
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SecurityPolicyIpv4Ipv4Application</returns>
        public static SecurityPolicyIpv4Ipv4Application FromJson(string jsonString)
        {
            SecurityPolicyIpv4Ipv4Application newSecurityPolicyIpv4Ipv4Application = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSecurityPolicyIpv4Ipv4Application;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SecurityPolicyIpv4ApplicationAny).GetProperty("AdditionalProperties") == null)
                {
                    newSecurityPolicyIpv4Ipv4Application = new SecurityPolicyIpv4Ipv4Application(JsonConvert.DeserializeObject<SecurityPolicyIpv4ApplicationAny>(jsonString, SecurityPolicyIpv4Ipv4Application.SerializerSettings));
                }
                else
                {
                    newSecurityPolicyIpv4Ipv4Application = new SecurityPolicyIpv4Ipv4Application(JsonConvert.DeserializeObject<SecurityPolicyIpv4ApplicationAny>(jsonString, SecurityPolicyIpv4Ipv4Application.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SecurityPolicyIpv4ApplicationAny");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SecurityPolicyIpv4ApplicationAny: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SecurityPolicyIpv4ApplicationGroup).GetProperty("AdditionalProperties") == null)
                {
                    newSecurityPolicyIpv4Ipv4Application = new SecurityPolicyIpv4Ipv4Application(JsonConvert.DeserializeObject<SecurityPolicyIpv4ApplicationGroup>(jsonString, SecurityPolicyIpv4Ipv4Application.SerializerSettings));
                }
                else
                {
                    newSecurityPolicyIpv4Ipv4Application = new SecurityPolicyIpv4Ipv4Application(JsonConvert.DeserializeObject<SecurityPolicyIpv4ApplicationGroup>(jsonString, SecurityPolicyIpv4Ipv4Application.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SecurityPolicyIpv4ApplicationGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SecurityPolicyIpv4ApplicationGroup: {1}", jsonString, exception.ToString()));
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
            return newSecurityPolicyIpv4Ipv4Application;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecurityPolicyIpv4Ipv4Application);
        }

        /// <summary>
        /// Returns true if SecurityPolicyIpv4Ipv4Application instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityPolicyIpv4Ipv4Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityPolicyIpv4Ipv4Application input)
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
    /// Custom JSON converter for SecurityPolicyIpv4Ipv4Application
    /// </summary>
    public class SecurityPolicyIpv4Ipv4ApplicationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SecurityPolicyIpv4Ipv4Application).GetMethod("ToJson").Invoke(value, null)));
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
                return SecurityPolicyIpv4Ipv4Application.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
