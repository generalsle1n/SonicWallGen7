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
    /// Enable GMS management and enter GMS management mode.
    /// </summary>
    [JsonConverter(typeof(AdministrationAdministrationGmsManagementJsonConverter))]
    [DataContract(Name = "administration_administration_gms_management")]
    public partial class AdministrationAdministrationGmsManagement : AbstractOpenAPISchema, IEquatable<AdministrationAdministrationGmsManagement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationAdministrationGmsManagement" /> class
        /// with the <see cref="AdministrationGmsManagementIpsecTunnel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AdministrationGmsManagementIpsecTunnel.</param>
        public AdministrationAdministrationGmsManagement(AdministrationGmsManagementIpsecTunnel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationAdministrationGmsManagement" /> class
        /// with the <see cref="AdministrationGmsManagementExistingTunnel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AdministrationGmsManagementExistingTunnel.</param>
        public AdministrationAdministrationGmsManagement(AdministrationGmsManagementExistingTunnel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrationAdministrationGmsManagement" /> class
        /// with the <see cref="AdministrationGmsManagementHttps" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AdministrationGmsManagementHttps.</param>
        public AdministrationAdministrationGmsManagement(AdministrationGmsManagementHttps actualInstance)
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
                if (value.GetType() == typeof(AdministrationGmsManagementExistingTunnel))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AdministrationGmsManagementHttps))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AdministrationGmsManagementIpsecTunnel))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AdministrationGmsManagementExistingTunnel, AdministrationGmsManagementHttps, AdministrationGmsManagementIpsecTunnel");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AdministrationGmsManagementIpsecTunnel`. If the actual instance is not `AdministrationGmsManagementIpsecTunnel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AdministrationGmsManagementIpsecTunnel</returns>
        public AdministrationGmsManagementIpsecTunnel GetAdministrationGmsManagementIpsecTunnel()
        {
            return (AdministrationGmsManagementIpsecTunnel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AdministrationGmsManagementExistingTunnel`. If the actual instance is not `AdministrationGmsManagementExistingTunnel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AdministrationGmsManagementExistingTunnel</returns>
        public AdministrationGmsManagementExistingTunnel GetAdministrationGmsManagementExistingTunnel()
        {
            return (AdministrationGmsManagementExistingTunnel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AdministrationGmsManagementHttps`. If the actual instance is not `AdministrationGmsManagementHttps`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AdministrationGmsManagementHttps</returns>
        public AdministrationGmsManagementHttps GetAdministrationGmsManagementHttps()
        {
            return (AdministrationGmsManagementHttps)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdministrationAdministrationGmsManagement {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AdministrationAdministrationGmsManagement.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AdministrationAdministrationGmsManagement
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AdministrationAdministrationGmsManagement</returns>
        public static AdministrationAdministrationGmsManagement FromJson(string jsonString)
        {
            AdministrationAdministrationGmsManagement newAdministrationAdministrationGmsManagement = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAdministrationAdministrationGmsManagement;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AdministrationGmsManagementExistingTunnel).GetProperty("AdditionalProperties") == null)
                {
                    newAdministrationAdministrationGmsManagement = new AdministrationAdministrationGmsManagement(JsonConvert.DeserializeObject<AdministrationGmsManagementExistingTunnel>(jsonString, AdministrationAdministrationGmsManagement.SerializerSettings));
                }
                else
                {
                    newAdministrationAdministrationGmsManagement = new AdministrationAdministrationGmsManagement(JsonConvert.DeserializeObject<AdministrationGmsManagementExistingTunnel>(jsonString, AdministrationAdministrationGmsManagement.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AdministrationGmsManagementExistingTunnel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AdministrationGmsManagementExistingTunnel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AdministrationGmsManagementHttps).GetProperty("AdditionalProperties") == null)
                {
                    newAdministrationAdministrationGmsManagement = new AdministrationAdministrationGmsManagement(JsonConvert.DeserializeObject<AdministrationGmsManagementHttps>(jsonString, AdministrationAdministrationGmsManagement.SerializerSettings));
                }
                else
                {
                    newAdministrationAdministrationGmsManagement = new AdministrationAdministrationGmsManagement(JsonConvert.DeserializeObject<AdministrationGmsManagementHttps>(jsonString, AdministrationAdministrationGmsManagement.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AdministrationGmsManagementHttps");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AdministrationGmsManagementHttps: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AdministrationGmsManagementIpsecTunnel).GetProperty("AdditionalProperties") == null)
                {
                    newAdministrationAdministrationGmsManagement = new AdministrationAdministrationGmsManagement(JsonConvert.DeserializeObject<AdministrationGmsManagementIpsecTunnel>(jsonString, AdministrationAdministrationGmsManagement.SerializerSettings));
                }
                else
                {
                    newAdministrationAdministrationGmsManagement = new AdministrationAdministrationGmsManagement(JsonConvert.DeserializeObject<AdministrationGmsManagementIpsecTunnel>(jsonString, AdministrationAdministrationGmsManagement.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AdministrationGmsManagementIpsecTunnel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AdministrationGmsManagementIpsecTunnel: {1}", jsonString, exception.ToString()));
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
            return newAdministrationAdministrationGmsManagement;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdministrationAdministrationGmsManagement);
        }

        /// <summary>
        /// Returns true if AdministrationAdministrationGmsManagement instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministrationAdministrationGmsManagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministrationAdministrationGmsManagement input)
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
    /// Custom JSON converter for AdministrationAdministrationGmsManagement
    /// </summary>
    public class AdministrationAdministrationGmsManagementJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AdministrationAdministrationGmsManagement).GetMethod("ToJson").Invoke(value, null)));
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
                return AdministrationAdministrationGmsManagement.FromJson(JObject.Load(reader).ToString(Formatting.None));
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