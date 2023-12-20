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
    ///  Class for testing SdwanPathSelectionProfiles
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SdwanPathSelectionProfilesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SdwanPathSelectionProfiles
        //private SdwanPathSelectionProfiles instance;

        public SdwanPathSelectionProfilesTests()
        {
            // TODO uncomment below to create an instance of SdwanPathSelectionProfiles
            //instance = new SdwanPathSelectionProfiles();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SdwanPathSelectionProfiles
        /// </summary>
        [Fact]
        public void SdwanPathSelectionProfilesInstanceTest()
        {
            // TODO uncomment below to test "IsType" SdwanPathSelectionProfiles
            //Assert.IsType<SdwanPathSelectionProfiles>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'SdwanGroup'
        /// </summary>
        [Fact]
        public void SdwanGroupTest()
        {
            // TODO unit test for the property 'SdwanGroup'
        }

        /// <summary>
        /// Test the property 'SlaProbe'
        /// </summary>
        [Fact]
        public void SlaProbeTest()
        {
            // TODO unit test for the property 'SlaProbe'
        }

        /// <summary>
        /// Test the property 'SlaClass'
        /// </summary>
        [Fact]
        public void SlaClassTest()
        {
            // TODO unit test for the property 'SlaClass'
        }

        /// <summary>
        /// Test the property 'BackupInterface'
        /// </summary>
        [Fact]
        public void BackupInterfaceTest()
        {
            // TODO unit test for the property 'BackupInterface'
        }

        /// <summary>
        /// Test the property 'ProbeDefaultUp'
        /// </summary>
        [Fact]
        public void ProbeDefaultUpTest()
        {
            // TODO unit test for the property 'ProbeDefaultUp'
        }

        /// <summary>
        /// Test the property 'ResetConnections'
        /// </summary>
        [Fact]
        public void ResetConnectionsTest()
        {
            // TODO unit test for the property 'ResetConnections'
        }
    }
}