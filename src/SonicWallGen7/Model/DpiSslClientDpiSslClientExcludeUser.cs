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
    [JsonConverter(typeof(DpiSslClientDpiSslClientExcludeUserJsonConverter))]
    [DataContract(Name = "dpi_ssl_client_dpi_ssl_client_exclude_user")]
    public partial class DpiSslClientDpiSslClientExcludeUser : AbstractOpenAPISchema, IEquatable<DpiSslClientDpiSslClientExcludeUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientExcludeUser" /> class
        /// with the <see cref="DpiSslClientExcludeUserAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientExcludeUserAdministrator.</param>
        public DpiSslClientDpiSslClientExcludeUser(DpiSslClientExcludeUserAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientExcludeUser" /> class
        /// with the <see cref="DpiSslClientExcludeUserGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientExcludeUserGuests.</param>
        public DpiSslClientDpiSslClientExcludeUser(DpiSslClientExcludeUserGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientExcludeUser" /> class
        /// with the <see cref="DpiSslClientExcludeUserName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientExcludeUserName.</param>
        public DpiSslClientDpiSslClientExcludeUser(DpiSslClientExcludeUserName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSslClientDpiSslClientExcludeUser" /> class
        /// with the <see cref="DpiSslClientExcludeUserGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSslClientExcludeUserGroup.</param>
        public DpiSslClientDpiSslClientExcludeUser(DpiSslClientExcludeUserGroup actualInstance)
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
                if (value.GetType() == typeof(DpiSslClientExcludeUserAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientExcludeUserGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientExcludeUserGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSslClientExcludeUserName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DpiSslClientExcludeUserAdministrator, DpiSslClientExcludeUserGroup, DpiSslClientExcludeUserGuests, DpiSslClientExcludeUserName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientExcludeUserAdministrator`. If the actual instance is not `DpiSslClientExcludeUserAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientExcludeUserAdministrator</returns>
        public DpiSslClientExcludeUserAdministrator GetDpiSslClientExcludeUserAdministrator()
        {
            return (DpiSslClientExcludeUserAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientExcludeUserGuests`. If the actual instance is not `DpiSslClientExcludeUserGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientExcludeUserGuests</returns>
        public DpiSslClientExcludeUserGuests GetDpiSslClientExcludeUserGuests()
        {
            return (DpiSslClientExcludeUserGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientExcludeUserName`. If the actual instance is not `DpiSslClientExcludeUserName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientExcludeUserName</returns>
        public DpiSslClientExcludeUserName GetDpiSslClientExcludeUserName()
        {
            return (DpiSslClientExcludeUserName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSslClientExcludeUserGroup`. If the actual instance is not `DpiSslClientExcludeUserGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSslClientExcludeUserGroup</returns>
        public DpiSslClientExcludeUserGroup GetDpiSslClientExcludeUserGroup()
        {
            return (DpiSslClientExcludeUserGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DpiSslClientDpiSslClientExcludeUser {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, DpiSslClientDpiSslClientExcludeUser.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DpiSslClientDpiSslClientExcludeUser
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DpiSslClientDpiSslClientExcludeUser</returns>
        public static DpiSslClientDpiSslClientExcludeUser FromJson(string jsonString)
        {
            DpiSslClientDpiSslClientExcludeUser newDpiSslClientDpiSslClientExcludeUser = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDpiSslClientDpiSslClientExcludeUser;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientExcludeUserAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserAdministrator>(jsonString, DpiSslClientDpiSslClientExcludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserAdministrator>(jsonString, DpiSslClientDpiSslClientExcludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientExcludeUserAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientExcludeUserAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientExcludeUserGroup).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserGroup>(jsonString, DpiSslClientDpiSslClientExcludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserGroup>(jsonString, DpiSslClientDpiSslClientExcludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientExcludeUserGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientExcludeUserGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientExcludeUserGuests).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserGuests>(jsonString, DpiSslClientDpiSslClientExcludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserGuests>(jsonString, DpiSslClientDpiSslClientExcludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientExcludeUserGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientExcludeUserGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSslClientExcludeUserName).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserName>(jsonString, DpiSslClientDpiSslClientExcludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSslClientDpiSslClientExcludeUser = new DpiSslClientDpiSslClientExcludeUser(JsonConvert.DeserializeObject<DpiSslClientExcludeUserName>(jsonString, DpiSslClientDpiSslClientExcludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSslClientExcludeUserName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSslClientExcludeUserName: {1}", jsonString, exception.ToString()));
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
            return newDpiSslClientDpiSslClientExcludeUser;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DpiSslClientDpiSslClientExcludeUser);
        }

        /// <summary>
        /// Returns true if DpiSslClientDpiSslClientExcludeUser instances are equal
        /// </summary>
        /// <param name="input">Instance of DpiSslClientDpiSslClientExcludeUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DpiSslClientDpiSslClientExcludeUser input)
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
    /// Custom JSON converter for DpiSslClientDpiSslClientExcludeUser
    /// </summary>
    public class DpiSslClientDpiSslClientExcludeUserJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DpiSslClientDpiSslClientExcludeUser).GetMethod("ToJson").Invoke(value, null)));
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
                return DpiSslClientDpiSslClientExcludeUser.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
