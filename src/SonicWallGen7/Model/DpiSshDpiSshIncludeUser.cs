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
    /// Set the DPI-SSH inclusion user object or group.
    /// </summary>
    [JsonConverter(typeof(DpiSshDpiSshIncludeUserJsonConverter))]
    [DataContract(Name = "dpi_ssh_dpi_ssh_include_user")]
    public partial class DpiSshDpiSshIncludeUser : AbstractOpenAPISchema, IEquatable<DpiSshDpiSshIncludeUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSshDpiSshIncludeUser" /> class
        /// with the <see cref="DpiSshIncludeUserAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSshIncludeUserAll.</param>
        public DpiSshDpiSshIncludeUser(DpiSshIncludeUserAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSshDpiSshIncludeUser" /> class
        /// with the <see cref="DpiSshIncludeUserGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSshIncludeUserGuests.</param>
        public DpiSshDpiSshIncludeUser(DpiSshIncludeUserGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSshDpiSshIncludeUser" /> class
        /// with the <see cref="DpiSshIncludeUserAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSshIncludeUserAdministrator.</param>
        public DpiSshDpiSshIncludeUser(DpiSshIncludeUserAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSshDpiSshIncludeUser" /> class
        /// with the <see cref="DpiSshIncludeUserName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSshIncludeUserName.</param>
        public DpiSshDpiSshIncludeUser(DpiSshIncludeUserName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DpiSshDpiSshIncludeUser" /> class
        /// with the <see cref="DpiSshIncludeUserGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DpiSshIncludeUserGroup.</param>
        public DpiSshDpiSshIncludeUser(DpiSshIncludeUserGroup actualInstance)
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
                if (value.GetType() == typeof(DpiSshIncludeUserAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSshIncludeUserAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSshIncludeUserGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSshIncludeUserGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DpiSshIncludeUserName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DpiSshIncludeUserAdministrator, DpiSshIncludeUserAll, DpiSshIncludeUserGroup, DpiSshIncludeUserGuests, DpiSshIncludeUserName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DpiSshIncludeUserAll`. If the actual instance is not `DpiSshIncludeUserAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSshIncludeUserAll</returns>
        public DpiSshIncludeUserAll GetDpiSshIncludeUserAll()
        {
            return (DpiSshIncludeUserAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSshIncludeUserGuests`. If the actual instance is not `DpiSshIncludeUserGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSshIncludeUserGuests</returns>
        public DpiSshIncludeUserGuests GetDpiSshIncludeUserGuests()
        {
            return (DpiSshIncludeUserGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSshIncludeUserAdministrator`. If the actual instance is not `DpiSshIncludeUserAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSshIncludeUserAdministrator</returns>
        public DpiSshIncludeUserAdministrator GetDpiSshIncludeUserAdministrator()
        {
            return (DpiSshIncludeUserAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSshIncludeUserName`. If the actual instance is not `DpiSshIncludeUserName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSshIncludeUserName</returns>
        public DpiSshIncludeUserName GetDpiSshIncludeUserName()
        {
            return (DpiSshIncludeUserName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DpiSshIncludeUserGroup`. If the actual instance is not `DpiSshIncludeUserGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DpiSshIncludeUserGroup</returns>
        public DpiSshIncludeUserGroup GetDpiSshIncludeUserGroup()
        {
            return (DpiSshIncludeUserGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DpiSshDpiSshIncludeUser {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, DpiSshDpiSshIncludeUser.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DpiSshDpiSshIncludeUser
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DpiSshDpiSshIncludeUser</returns>
        public static DpiSshDpiSshIncludeUser FromJson(string jsonString)
        {
            DpiSshDpiSshIncludeUser newDpiSshDpiSshIncludeUser = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDpiSshDpiSshIncludeUser;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSshIncludeUserAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserAdministrator>(jsonString, DpiSshDpiSshIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserAdministrator>(jsonString, DpiSshDpiSshIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSshIncludeUserAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSshIncludeUserAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSshIncludeUserAll).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserAll>(jsonString, DpiSshDpiSshIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserAll>(jsonString, DpiSshDpiSshIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSshIncludeUserAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSshIncludeUserAll: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSshIncludeUserGroup).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserGroup>(jsonString, DpiSshDpiSshIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserGroup>(jsonString, DpiSshDpiSshIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSshIncludeUserGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSshIncludeUserGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSshIncludeUserGuests).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserGuests>(jsonString, DpiSshDpiSshIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserGuests>(jsonString, DpiSshDpiSshIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSshIncludeUserGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSshIncludeUserGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DpiSshIncludeUserName).GetProperty("AdditionalProperties") == null)
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserName>(jsonString, DpiSshDpiSshIncludeUser.SerializerSettings));
                }
                else
                {
                    newDpiSshDpiSshIncludeUser = new DpiSshDpiSshIncludeUser(JsonConvert.DeserializeObject<DpiSshIncludeUserName>(jsonString, DpiSshDpiSshIncludeUser.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DpiSshIncludeUserName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DpiSshIncludeUserName: {1}", jsonString, exception.ToString()));
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
            return newDpiSshDpiSshIncludeUser;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DpiSshDpiSshIncludeUser);
        }

        /// <summary>
        /// Returns true if DpiSshDpiSshIncludeUser instances are equal
        /// </summary>
        /// <param name="input">Instance of DpiSshDpiSshIncludeUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DpiSshDpiSshIncludeUser input)
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
    /// Custom JSON converter for DpiSshDpiSshIncludeUser
    /// </summary>
    public class DpiSshDpiSshIncludeUserJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DpiSshDpiSshIncludeUser).GetMethod("ToJson").Invoke(value, null)));
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
                return DpiSshDpiSshIncludeUser.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
