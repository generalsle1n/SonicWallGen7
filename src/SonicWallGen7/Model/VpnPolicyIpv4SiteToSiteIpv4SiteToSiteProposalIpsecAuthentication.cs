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
    /// Authentication hashing encryption algorithm.
    /// </summary>
    [JsonConverter(typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationJsonConverter))]
    [DataContract(Name = "vpn_policy_ipv4_site_to_site_ipv4_site_to_site_proposal_ipsec_authentication")]
    public partial class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication : AbstractOpenAPISchema, IEquatable<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication" /> class
        /// with the <see cref="VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc.</param>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc actualInstance)
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
                if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5 GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1 GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256 GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384 GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512 GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc`. If the actual instance is not `VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc</returns>
        public VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc GetVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc()
        {
            return (VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication</returns>
        public static VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication FromJson(string jsonString)
        {
            VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationAesXcbc: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationMd5: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha256: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha384: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512).GetProperty("AdditionalProperties") == null)
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.SerializerSettings));
                }
                else
                {
                    newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication = new VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication(JsonConvert.DeserializeObject<VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512>(jsonString, VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationSha512: {1}", jsonString, exception.ToString()));
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
            return newVpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication);
        }

        /// <summary>
        /// Returns true if VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication input)
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
    /// Custom JSON converter for VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication
    /// </summary>
    public class VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthenticationJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication).GetMethod("ToJson").Invoke(value, null)));
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
                return VpnPolicyIpv4SiteToSiteIpv4SiteToSiteProposalIpsecAuthentication.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
