/*
 * SonicOS API
 *
 * __Swagger Specification for SonicOS APIs__  ___SonicOS support two-factor and bearer token login from SWAGGER only.___  Please follow the following steps to login. > 1. POST \"tfa\" with your username, password, and two-factor code to the firewall. If you are authenticating a username for the first time, please login to GUI and scan the QR code to activate two-factor authentication. > 2. The Bearer Token is returned in response to the \"tfa\" message. Copy the Bearer Token to the \"Authorize\" button. > 3. DELETE \"auth\" to logout of the current session. 
 *
 * The version of the OpenAPI document: 7.0.1
 * Contact: sonicOsApiSupport@SonicWall.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using SonicWallGen7.Model;
using SonicWallGen7.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace SonicWallGen7.Test.Model
{
    /// <summary>
    ///  Class for testing PoliciesSettingBasePoliciesSettingBypassDecryption
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PoliciesSettingBasePoliciesSettingBypassDecryptionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PoliciesSettingBasePoliciesSettingBypassDecryption
        //private PoliciesSettingBasePoliciesSettingBypassDecryption instance;

        public PoliciesSettingBasePoliciesSettingBypassDecryptionTests()
        {
            // TODO uncomment below to create an instance of PoliciesSettingBasePoliciesSettingBypassDecryption
            //instance = new PoliciesSettingBasePoliciesSettingBypassDecryption();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PoliciesSettingBasePoliciesSettingBypassDecryption
        /// </summary>
        [Fact]
        public void PoliciesSettingBasePoliciesSettingBypassDecryptionInstanceTest()
        {
            // TODO uncomment below to test "IsType" PoliciesSettingBasePoliciesSettingBypassDecryption
            //Assert.IsType<PoliciesSettingBasePoliciesSettingBypassDecryption>(instance);
        }

        /// <summary>
        /// Test the property 'CfsNotLicensed'
        /// </summary>
        [Fact]
        public void CfsNotLicensedTest()
        {
            // TODO unit test for the property 'CfsNotLicensed'
        }

        /// <summary>
        /// Test the property 'CfsFailConnect'
        /// </summary>
        [Fact]
        public void CfsFailConnectTest()
        {
            // TODO unit test for the property 'CfsFailConnect'
        }

        /// <summary>
        /// Test the property 'GeoipDatabaseNotDownloaded'
        /// </summary>
        [Fact]
        public void GeoipDatabaseNotDownloadedTest()
        {
            // TODO unit test for the property 'GeoipDatabaseNotDownloaded'
        }
    }
}
