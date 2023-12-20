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
    /// Specify excluded users.
    /// </summary>
    [JsonConverter(typeof(AccessRuleIpv4Ipv4UsersExcludedJsonConverter))]
    [DataContract(Name = "access_rule_ipv4_ipv4_users_excluded")]
    public partial class AccessRuleIpv4Ipv4UsersExcluded : AbstractOpenAPISchema, IEquatable<AccessRuleIpv4Ipv4UsersExcluded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersExcluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersExcludedNone" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersExcludedNone.</param>
        public AccessRuleIpv4Ipv4UsersExcluded(AccessRuleIpv4UsersExcludedNone actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersExcluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersExcludedGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersExcludedGuests.</param>
        public AccessRuleIpv4Ipv4UsersExcluded(AccessRuleIpv4UsersExcludedGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersExcluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersExcludedAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersExcludedAdministrator.</param>
        public AccessRuleIpv4Ipv4UsersExcluded(AccessRuleIpv4UsersExcludedAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersExcluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersExcludedName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersExcludedName.</param>
        public AccessRuleIpv4Ipv4UsersExcluded(AccessRuleIpv4UsersExcludedName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersExcluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersExcludedGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersExcludedGroup.</param>
        public AccessRuleIpv4Ipv4UsersExcluded(AccessRuleIpv4UsersExcludedGroup actualInstance)
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
                if (value.GetType() == typeof(AccessRuleIpv4UsersExcludedAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersExcludedGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersExcludedGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersExcludedName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersExcludedNone))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AccessRuleIpv4UsersExcludedAdministrator, AccessRuleIpv4UsersExcludedGroup, AccessRuleIpv4UsersExcludedGuests, AccessRuleIpv4UsersExcludedName, AccessRuleIpv4UsersExcludedNone");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersExcludedNone`. If the actual instance is not `AccessRuleIpv4UsersExcludedNone`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersExcludedNone</returns>
        public AccessRuleIpv4UsersExcludedNone GetAccessRuleIpv4UsersExcludedNone()
        {
            return (AccessRuleIpv4UsersExcludedNone)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersExcludedGuests`. If the actual instance is not `AccessRuleIpv4UsersExcludedGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersExcludedGuests</returns>
        public AccessRuleIpv4UsersExcludedGuests GetAccessRuleIpv4UsersExcludedGuests()
        {
            return (AccessRuleIpv4UsersExcludedGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersExcludedAdministrator`. If the actual instance is not `AccessRuleIpv4UsersExcludedAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersExcludedAdministrator</returns>
        public AccessRuleIpv4UsersExcludedAdministrator GetAccessRuleIpv4UsersExcludedAdministrator()
        {
            return (AccessRuleIpv4UsersExcludedAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersExcludedName`. If the actual instance is not `AccessRuleIpv4UsersExcludedName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersExcludedName</returns>
        public AccessRuleIpv4UsersExcludedName GetAccessRuleIpv4UsersExcludedName()
        {
            return (AccessRuleIpv4UsersExcludedName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersExcludedGroup`. If the actual instance is not `AccessRuleIpv4UsersExcludedGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersExcludedGroup</returns>
        public AccessRuleIpv4UsersExcludedGroup GetAccessRuleIpv4UsersExcludedGroup()
        {
            return (AccessRuleIpv4UsersExcludedGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRuleIpv4Ipv4UsersExcluded {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AccessRuleIpv4Ipv4UsersExcluded.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AccessRuleIpv4Ipv4UsersExcluded
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AccessRuleIpv4Ipv4UsersExcluded</returns>
        public static AccessRuleIpv4Ipv4UsersExcluded FromJson(string jsonString)
        {
            AccessRuleIpv4Ipv4UsersExcluded newAccessRuleIpv4Ipv4UsersExcluded = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAccessRuleIpv4Ipv4UsersExcluded;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersExcludedAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedAdministrator>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedAdministrator>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersExcludedAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersExcludedAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersExcludedGroup).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedGroup>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedGroup>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersExcludedGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersExcludedGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersExcludedGuests).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedGuests>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedGuests>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersExcludedGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersExcludedGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersExcludedName).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedName>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedName>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersExcludedName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersExcludedName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersExcludedNone).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedNone>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersExcluded = new AccessRuleIpv4Ipv4UsersExcluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersExcludedNone>(jsonString, AccessRuleIpv4Ipv4UsersExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersExcludedNone");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersExcludedNone: {1}", jsonString, exception.ToString()));
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
            return newAccessRuleIpv4Ipv4UsersExcluded;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessRuleIpv4Ipv4UsersExcluded);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv4Ipv4UsersExcluded instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv4Ipv4UsersExcluded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv4Ipv4UsersExcluded input)
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
    /// Custom JSON converter for AccessRuleIpv4Ipv4UsersExcluded
    /// </summary>
    public class AccessRuleIpv4Ipv4UsersExcludedJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AccessRuleIpv4Ipv4UsersExcluded).GetMethod("ToJson").Invoke(value, null)));
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
                return AccessRuleIpv4Ipv4UsersExcluded.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
