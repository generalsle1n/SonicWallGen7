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
    ///  Class for testing ModelVersion
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModelVersionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ModelVersion
        //private ModelVersion instance;

        public ModelVersionTests()
        {
            // TODO uncomment below to create an instance of ModelVersion
            //instance = new ModelVersion();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModelVersion
        /// </summary>
        [Fact]
        public void ModelVersionInstanceTest()
        {
            // TODO uncomment below to test "IsType" ModelVersion
            //Assert.IsType<ModelVersion>(instance);
        }

        /// <summary>
        /// Test the property 'FirmwareVersion'
        /// </summary>
        [Fact]
        public void FirmwareVersionTest()
        {
            // TODO unit test for the property 'FirmwareVersion'
        }

        /// <summary>
        /// Test the property 'RomVersion'
        /// </summary>
        [Fact]
        public void RomVersionTest()
        {
            // TODO unit test for the property 'RomVersion'
        }

        /// <summary>
        /// Test the property 'SafemodeVersion'
        /// </summary>
        [Fact]
        public void SafemodeVersionTest()
        {
            // TODO unit test for the property 'SafemodeVersion'
        }

        /// <summary>
        /// Test the property 'SerialNumber'
        /// </summary>
        [Fact]
        public void SerialNumberTest()
        {
            // TODO unit test for the property 'SerialNumber'
        }

        /// <summary>
        /// Test the property 'Model'
        /// </summary>
        [Fact]
        public void ModelTest()
        {
            // TODO unit test for the property 'Model'
        }

        /// <summary>
        /// Test the property 'SystemTime'
        /// </summary>
        [Fact]
        public void SystemTimeTest()
        {
            // TODO unit test for the property 'SystemTime'
        }

        /// <summary>
        /// Test the property 'SystemUptime'
        /// </summary>
        [Fact]
        public void SystemUptimeTest()
        {
            // TODO unit test for the property 'SystemUptime'
        }

        /// <summary>
        /// Test the property 'LastModifiedBy'
        /// </summary>
        [Fact]
        public void LastModifiedByTest()
        {
            // TODO unit test for the property 'LastModifiedBy'
        }
    }
}
