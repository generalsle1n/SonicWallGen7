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
    /// Excluded.
    /// </summary>
    [JsonConverter(typeof(ContentFilterCfsPolicyUserExcludedJsonConverter))]
    [DataContract(Name = "content_filter_cfs_policy_user_excluded")]
    public partial class ContentFilterCfsPolicyUserExcluded : AbstractOpenAPISchema, IEquatable<ContentFilterCfsPolicyUserExcluded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterCfsPolicyUserExcluded" /> class
        /// with the <see cref="ContentFilterCfsPolicyUserExcludedNone" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContentFilterCfsPolicyUserExcludedNone.</param>
        public ContentFilterCfsPolicyUserExcluded(ContentFilterCfsPolicyUserExcludedNone actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterCfsPolicyUserExcluded" /> class
        /// with the <see cref="ContentFilterCfsPolicyUserExcludedGuests" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContentFilterCfsPolicyUserExcludedGuests.</param>
        public ContentFilterCfsPolicyUserExcluded(ContentFilterCfsPolicyUserExcludedGuests actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterCfsPolicyUserExcluded" /> class
        /// with the <see cref="ContentFilterCfsPolicyUserExcludedAdministrator" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContentFilterCfsPolicyUserExcludedAdministrator.</param>
        public ContentFilterCfsPolicyUserExcluded(ContentFilterCfsPolicyUserExcludedAdministrator actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterCfsPolicyUserExcluded" /> class
        /// with the <see cref="ContentFilterCfsPolicyUserExcludedName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContentFilterCfsPolicyUserExcludedName.</param>
        public ContentFilterCfsPolicyUserExcluded(ContentFilterCfsPolicyUserExcludedName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterCfsPolicyUserExcluded" /> class
        /// with the <see cref="ContentFilterCfsPolicyUserExcludedGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ContentFilterCfsPolicyUserExcludedGroup.</param>
        public ContentFilterCfsPolicyUserExcluded(ContentFilterCfsPolicyUserExcludedGroup actualInstance)
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
                if (value.GetType() == typeof(ContentFilterCfsPolicyUserExcludedAdministrator))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContentFilterCfsPolicyUserExcludedGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContentFilterCfsPolicyUserExcludedGuests))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContentFilterCfsPolicyUserExcludedName))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ContentFilterCfsPolicyUserExcludedNone))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ContentFilterCfsPolicyUserExcludedAdministrator, ContentFilterCfsPolicyUserExcludedGroup, ContentFilterCfsPolicyUserExcludedGuests, ContentFilterCfsPolicyUserExcludedName, ContentFilterCfsPolicyUserExcludedNone");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ContentFilterCfsPolicyUserExcludedNone`. If the actual instance is not `ContentFilterCfsPolicyUserExcludedNone`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContentFilterCfsPolicyUserExcludedNone</returns>
        public ContentFilterCfsPolicyUserExcludedNone GetContentFilterCfsPolicyUserExcludedNone()
        {
            return (ContentFilterCfsPolicyUserExcludedNone)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContentFilterCfsPolicyUserExcludedGuests`. If the actual instance is not `ContentFilterCfsPolicyUserExcludedGuests`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContentFilterCfsPolicyUserExcludedGuests</returns>
        public ContentFilterCfsPolicyUserExcludedGuests GetContentFilterCfsPolicyUserExcludedGuests()
        {
            return (ContentFilterCfsPolicyUserExcludedGuests)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContentFilterCfsPolicyUserExcludedAdministrator`. If the actual instance is not `ContentFilterCfsPolicyUserExcludedAdministrator`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContentFilterCfsPolicyUserExcludedAdministrator</returns>
        public ContentFilterCfsPolicyUserExcludedAdministrator GetContentFilterCfsPolicyUserExcludedAdministrator()
        {
            return (ContentFilterCfsPolicyUserExcludedAdministrator)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContentFilterCfsPolicyUserExcludedName`. If the actual instance is not `ContentFilterCfsPolicyUserExcludedName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContentFilterCfsPolicyUserExcludedName</returns>
        public ContentFilterCfsPolicyUserExcludedName GetContentFilterCfsPolicyUserExcludedName()
        {
            return (ContentFilterCfsPolicyUserExcludedName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ContentFilterCfsPolicyUserExcludedGroup`. If the actual instance is not `ContentFilterCfsPolicyUserExcludedGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ContentFilterCfsPolicyUserExcludedGroup</returns>
        public ContentFilterCfsPolicyUserExcludedGroup GetContentFilterCfsPolicyUserExcludedGroup()
        {
            return (ContentFilterCfsPolicyUserExcludedGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentFilterCfsPolicyUserExcluded {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ContentFilterCfsPolicyUserExcluded.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ContentFilterCfsPolicyUserExcluded
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ContentFilterCfsPolicyUserExcluded</returns>
        public static ContentFilterCfsPolicyUserExcluded FromJson(string jsonString)
        {
            ContentFilterCfsPolicyUserExcluded newContentFilterCfsPolicyUserExcluded = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newContentFilterCfsPolicyUserExcluded;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContentFilterCfsPolicyUserExcludedAdministrator).GetProperty("AdditionalProperties") == null)
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedAdministrator>(jsonString, ContentFilterCfsPolicyUserExcluded.SerializerSettings));
                }
                else
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedAdministrator>(jsonString, ContentFilterCfsPolicyUserExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContentFilterCfsPolicyUserExcludedAdministrator");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContentFilterCfsPolicyUserExcludedAdministrator: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContentFilterCfsPolicyUserExcludedGroup).GetProperty("AdditionalProperties") == null)
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedGroup>(jsonString, ContentFilterCfsPolicyUserExcluded.SerializerSettings));
                }
                else
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedGroup>(jsonString, ContentFilterCfsPolicyUserExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContentFilterCfsPolicyUserExcludedGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContentFilterCfsPolicyUserExcludedGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContentFilterCfsPolicyUserExcludedGuests).GetProperty("AdditionalProperties") == null)
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedGuests>(jsonString, ContentFilterCfsPolicyUserExcluded.SerializerSettings));
                }
                else
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedGuests>(jsonString, ContentFilterCfsPolicyUserExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContentFilterCfsPolicyUserExcludedGuests");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContentFilterCfsPolicyUserExcludedGuests: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContentFilterCfsPolicyUserExcludedName).GetProperty("AdditionalProperties") == null)
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedName>(jsonString, ContentFilterCfsPolicyUserExcluded.SerializerSettings));
                }
                else
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedName>(jsonString, ContentFilterCfsPolicyUserExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContentFilterCfsPolicyUserExcludedName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContentFilterCfsPolicyUserExcludedName: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ContentFilterCfsPolicyUserExcludedNone).GetProperty("AdditionalProperties") == null)
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedNone>(jsonString, ContentFilterCfsPolicyUserExcluded.SerializerSettings));
                }
                else
                {
                    newContentFilterCfsPolicyUserExcluded = new ContentFilterCfsPolicyUserExcluded(JsonConvert.DeserializeObject<ContentFilterCfsPolicyUserExcludedNone>(jsonString, ContentFilterCfsPolicyUserExcluded.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ContentFilterCfsPolicyUserExcludedNone");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ContentFilterCfsPolicyUserExcludedNone: {1}", jsonString, exception.ToString()));
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
            return newContentFilterCfsPolicyUserExcluded;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentFilterCfsPolicyUserExcluded);
        }

        /// <summary>
        /// Returns true if ContentFilterCfsPolicyUserExcluded instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentFilterCfsPolicyUserExcluded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentFilterCfsPolicyUserExcluded input)
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
    /// Custom JSON converter for ContentFilterCfsPolicyUserExcluded
    /// </summary>
    public class ContentFilterCfsPolicyUserExcludedJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ContentFilterCfsPolicyUserExcluded).GetMethod("ToJson").Invoke(value, null)));
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
                return ContentFilterCfsPolicyUserExcluded.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
