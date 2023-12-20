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
    /// Specify included users.
    /// </summary>
    [JsonConverter(typeof(AccessRuleIpv4Ipv4UsersIncludedJsonConverter))]
    [DataContract(Name = "access_rule_ipv4_ipv4_users_included")]
    public partial class AccessRuleIpv4Ipv4UsersIncluded : AbstractOpenAPISchema, IEquatable<AccessRuleIpv4Ipv4UsersIncluded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersIncluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersIncludedAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersIncludedAll.</param>
        public AccessRuleIpv4Ipv4UsersIncluded(AccessRuleIpv4UsersIncludedAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersIncluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersIncludedGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersIncludedGuests.</param>
        public AccessRuleIpv4Ipv4UsersIncluded(AccessRuleIpv4UsersIncludedGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersIncluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersIncludedAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersIncludedAdministrator.</param>
        public AccessRuleIpv4Ipv4UsersIncluded(AccessRuleIpv4UsersIncludedAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersIncluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersIncludedName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersIncludedName.</param>
        public AccessRuleIpv4Ipv4UsersIncluded(AccessRuleIpv4UsersIncludedName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRuleIpv4Ipv4UsersIncluded" /> class
        /// with the <see cref="AccessRuleIpv4UsersIncludedGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AccessRuleIpv4UsersIncludedGroup.</param>
        public AccessRuleIpv4Ipv4UsersIncluded(AccessRuleIpv4UsersIncludedGroup actualInstance)
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
                if (value.GetType() == typeof(AccessRuleIpv4UsersIncludedAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersIncludedAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersIncludedGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersIncludedGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AccessRuleIpv4UsersIncludedName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AccessRuleIpv4UsersIncludedAdministrator, AccessRuleIpv4UsersIncludedAll, AccessRuleIpv4UsersIncludedGroup, AccessRuleIpv4UsersIncludedGuests, AccessRuleIpv4UsersIncludedName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersIncludedAll`. If the actual instance is not `AccessRuleIpv4UsersIncludedAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersIncludedAll</returns>
        public AccessRuleIpv4UsersIncludedAll GetAccessRuleIpv4UsersIncludedAll()
        {
            return (AccessRuleIpv4UsersIncludedAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersIncludedGuests`. If the actual instance is not `AccessRuleIpv4UsersIncludedGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersIncludedGuests</returns>
        public AccessRuleIpv4UsersIncludedGuests GetAccessRuleIpv4UsersIncludedGuests()
        {
            return (AccessRuleIpv4UsersIncludedGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersIncludedAdministrator`. If the actual instance is not `AccessRuleIpv4UsersIncludedAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersIncludedAdministrator</returns>
        public AccessRuleIpv4UsersIncludedAdministrator GetAccessRuleIpv4UsersIncludedAdministrator()
        {
            return (AccessRuleIpv4UsersIncludedAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersIncludedName`. If the actual instance is not `AccessRuleIpv4UsersIncludedName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersIncludedName</returns>
        public AccessRuleIpv4UsersIncludedName GetAccessRuleIpv4UsersIncludedName()
        {
            return (AccessRuleIpv4UsersIncludedName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AccessRuleIpv4UsersIncludedGroup`. If the actual instance is not `AccessRuleIpv4UsersIncludedGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AccessRuleIpv4UsersIncludedGroup</returns>
        public AccessRuleIpv4UsersIncludedGroup GetAccessRuleIpv4UsersIncludedGroup()
        {
            return (AccessRuleIpv4UsersIncludedGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRuleIpv4Ipv4UsersIncluded {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AccessRuleIpv4Ipv4UsersIncluded.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AccessRuleIpv4Ipv4UsersIncluded
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AccessRuleIpv4Ipv4UsersIncluded</returns>
        public static AccessRuleIpv4Ipv4UsersIncluded FromJson(string jsonString)
        {
            AccessRuleIpv4Ipv4UsersIncluded newAccessRuleIpv4Ipv4UsersIncluded = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAccessRuleIpv4Ipv4UsersIncluded;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersIncludedAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedAdministrator>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedAdministrator>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersIncludedAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersIncludedAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersIncludedAll).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedAll>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedAll>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersIncludedAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersIncludedAll: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersIncludedGroup).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedGroup>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedGroup>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersIncludedGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersIncludedGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersIncludedGuests).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedGuests>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedGuests>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersIncludedGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersIncludedGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AccessRuleIpv4UsersIncludedName).GetProperty("AdditionalProperties") == null)
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedName>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.SerializerSettings));
                }
                else
                {
                    newAccessRuleIpv4Ipv4UsersIncluded = new AccessRuleIpv4Ipv4UsersIncluded(JsonConvert.DeserializeObject<AccessRuleIpv4UsersIncludedName>(jsonString, AccessRuleIpv4Ipv4UsersIncluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AccessRuleIpv4UsersIncludedName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AccessRuleIpv4UsersIncludedName: {1}", jsonString, exception.ToString()));
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
            return newAccessRuleIpv4Ipv4UsersIncluded;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessRuleIpv4Ipv4UsersIncluded);
        }

        /// <summary>
        /// Returns true if AccessRuleIpv4Ipv4UsersIncluded instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessRuleIpv4Ipv4UsersIncluded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRuleIpv4Ipv4UsersIncluded input)
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
    /// Custom JSON converter for AccessRuleIpv4Ipv4UsersIncluded
    /// </summary>
    public class AccessRuleIpv4Ipv4UsersIncludedJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AccessRuleIpv4Ipv4UsersIncluded).GetMethod("ToJson").Invoke(value, null)));
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
                return AccessRuleIpv4Ipv4UsersIncluded.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
