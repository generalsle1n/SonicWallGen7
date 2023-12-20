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
    /// Set an address object to exclude from blocking the file download until verdict is reached by the capture service.
    /// </summary>
    [JsonConverter(typeof(CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdictJsonConverter))]
    [DataContract(Name = "capture_atp_base_capture_atp_exclude_address_for_block_until_verdict")]
    public partial class CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict : AbstractOpenAPISchema, IEquatable<CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict" /> class
        /// with the <see cref="CaptureAtpBaseExcludeAddressForBlockUntilVerdictName" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CaptureAtpBaseExcludeAddressForBlockUntilVerdictName.</param>
        public CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict(CaptureAtpBaseExcludeAddressForBlockUntilVerdictName actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict" /> class
        /// with the <see cref="CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup.</param>
        public CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict(CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup actualInstance)
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
                if (value.GetType() == typeof(CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CaptureAtpBaseExcludeAddressForBlockUntilVerdictName))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup, CaptureAtpBaseExcludeAddressForBlockUntilVerdictName");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CaptureAtpBaseExcludeAddressForBlockUntilVerdictName`. If the actual instance is not `CaptureAtpBaseExcludeAddressForBlockUntilVerdictName`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CaptureAtpBaseExcludeAddressForBlockUntilVerdictName</returns>
        public CaptureAtpBaseExcludeAddressForBlockUntilVerdictName GetCaptureAtpBaseExcludeAddressForBlockUntilVerdictName()
        {
            return (CaptureAtpBaseExcludeAddressForBlockUntilVerdictName)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup`. If the actual instance is not `CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup</returns>
        public CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup GetCaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup()
        {
            return (CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict</returns>
        public static CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict FromJson(string jsonString)
        {
            CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict newCaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup).GetProperty("AdditionalProperties") == null)
                {
                    newCaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict = new CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict(JsonConvert.DeserializeObject<CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup>(jsonString, CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict.SerializerSettings));
                }
                else
                {
                    newCaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict = new CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict(JsonConvert.DeserializeObject<CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup>(jsonString, CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CaptureAtpBaseExcludeAddressForBlockUntilVerdictGroup: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CaptureAtpBaseExcludeAddressForBlockUntilVerdictName).GetProperty("AdditionalProperties") == null)
                {
                    newCaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict = new CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict(JsonConvert.DeserializeObject<CaptureAtpBaseExcludeAddressForBlockUntilVerdictName>(jsonString, CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict.SerializerSettings));
                }
                else
                {
                    newCaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict = new CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict(JsonConvert.DeserializeObject<CaptureAtpBaseExcludeAddressForBlockUntilVerdictName>(jsonString, CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CaptureAtpBaseExcludeAddressForBlockUntilVerdictName");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CaptureAtpBaseExcludeAddressForBlockUntilVerdictName: {1}", jsonString, exception.ToString()));
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
            return newCaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict);
        }

        /// <summary>
        /// Returns true if CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict instances are equal
        /// </summary>
        /// <param name="input">Instance of CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict input)
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
    /// Custom JSON converter for CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict
    /// </summary>
    public class CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdictJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict).GetMethod("ToJson").Invoke(value, null)));
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
                return CaptureAtpBaseCaptureAtpExcludeAddressForBlockUntilVerdict.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
