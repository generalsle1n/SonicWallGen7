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
    /// Set the DPI-SSL inclusion user object or group.
    /// </summary>
    [JsonConverter(typeof(DpiSslClientDpiSslClientIncludeUserJsonConverter))]
    [DataContract(Name = "dpi_ssl_client_dpi_ssl_client_include_user")]
    public partial class DpiSslClientDpiSslClientIncludeUser : AbstractOpenAPISchema, IEquatable<DpiSslClientDpiSslClientIncludeUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientIncludeUser" /> class
        /// with the <see cref="DpiSslClientIncludeUserAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientIncludeUserAll.</param>
        public DpiSslClientDpiSslClientIncludeUser(DpiSslClientIncludeUserAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientIncludeUser" /> class
        /// with the <see cref="DpiSslClientIncludeUserGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientIncludeUserGuests.</param>
        public DpiSslClientDpiSslClientIncludeUser(DpiSslClientIncludeUserGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientIncludeUser" /> class
        /// with the <see cref="DpiSslClientIncludeUserAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientIncludeUserAdministrator.</param>
        public DpiSslClientDpiSslClientIncludeUser(DpiSslClientIncludeUserAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientIncludeUser" /> class
        /// with the <see cref="DpiSslClientIncludeUserName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientIncludeUserName.</param>
        public DpiSslClientDpiSslClientIncludeUser(DpiSslClientIncludeUserName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientIncludeUser" /> class
        /// with the <see cref="DpiSslClientIncludeUserGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientIncludeUserGroup.</param>
        public DpiSslClientDpiSslClientIncludeUser(DpiSslClientIncludeUserGroup actualInstance)
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
                if (value.GetType() == typeof(DpiSslClientIncludeUserAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientIncludeUserAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientIncludeUserGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientIncludeUserGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientIncludeUserName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DpiSslClientIncludeUserAdministrator, DpiSslClientIncludeUserAll, DpiSslClientIncludeUserGroup, DpiSslClientIncludeUserGuests, DpiSslClientIncludeUserName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientIncludeUserAll`. If the actual instance is not `DpiSslClientIncludeUserAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientIncludeUserAll</returns>
        public DpiSslClientIncludeUserAll GetDpiSslClientIncludeUserAll()
        {
            return (DpiSslClientIncludeUserAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientIncludeUserGuests`. If the actual instance is not `DpiSslClientIncludeUserGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientIncludeUserGuests</returns>
        public DpiSslClientIncludeUserGuests GetDpiSslClientIncludeUserGuests()
        {
            return (DpiSslClientIncludeUserGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientIncludeUserAdministrator`. If the actual instance is not `DpiSslClientIncludeUserAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientIncludeUserAdministrator</returns>
        public DpiSslClientIncludeUserAdministrator GetDpiSslClientIncludeUserAdministrator()
        {
            return (DpiSslClientIncludeUserAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientIncludeUserName`. If the actual instance is not `DpiSslClientIncludeUserName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientIncludeUserName</returns>
        public DpiSslClientIncludeUserName GetDpiSslClientIncludeUserName()
        {
            return (DpiSslClientIncludeUserName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientIncludeUserGroup`. If the actual instance is not `DpiSslClientIncludeUserGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientIncludeUserGroup</returns>
        public DpiSslClientIncludeUserGroup GetDpiSslClientIncludeUserGroup()
        {
            return (DpiSslClientIncludeUserGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DpiSslClientDpiSslClientIncludeUser {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, DpiSslClientDpiSslClientIncludeUser.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DpiSslClientDpiSslClientIncludeUser
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DpiSslClientDpiSslClientIncludeUser</returns>
        public static DpiSslClientDpiSslClientIncludeUser FromJson(string jsonString)
        {
            DpiSslClientDpiSslClientIncludeUser newDpiSslClientDpiSslClientIncludeUser = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDpiSslClientDpiSslClientIncludeUser;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientIncludeUserAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserAdministrator>(jsonString, DpiSslClientDpiSslClientIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserAdministrator>(jsonString, DpiSslClientDpiSslClientIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientIncludeUserAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientIncludeUserAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientIncludeUserAll).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserAll>(jsonString, DpiSslClientDpiSslClientIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserAll>(jsonString, DpiSslClientDpiSslClientIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientIncludeUserAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientIncludeUserAll: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientIncludeUserGroup).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserGroup>(jsonString, DpiSslClientDpiSslClientIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserGroup>(jsonString, DpiSslClientDpiSslClientIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientIncludeUserGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientIncludeUserGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientIncludeUserGuests).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserGuests>(jsonString, DpiSslClientDpiSslClientIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserGuests>(jsonString, DpiSslClientDpiSslClientIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientIncludeUserGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientIncludeUserGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientIncludeUserName).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserName>(jsonString, DpiSslClientDpiSslClientIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientIncludeUser = new DpiSslClientDpiSslClientIncludeUser(JsonConvert.DeserializeObject<DpiSslClientIncludeUserName>(jsonString, DpiSslClientDpiSslClientIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientIncludeUserName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientIncludeUserName: {1}", jsonString, exception.ToString()));
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
            return newDpiSslClientDpiSslClientIncludeUser;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DpiSslClientDpiSslClientIncludeUser);
        }

        /// <summary>
        /// Returns true if DpiSslClientDpiSslClientIncludeUser instances are equal
        /// </summary>
        /// <param name="input">Instance of DpiSslClientDpiSslClientIncludeUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DpiSslClientDpiSslClientIncludeUser input)
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
    /// Custom JSON converter for DpiSslClientDpiSslClientIncludeUser
    /// </summary>
    public class DpiSslClientDpiSslClientIncludeUserJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DpiSslClientDpiSslClientIncludeUser).GetMethod("ToJson").Invoke(value, null)));
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
                return DpiSslClientDpiSslClientIncludeUser.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
