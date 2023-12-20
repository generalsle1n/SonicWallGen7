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
    ///  Class for testing HaBaseHighAvailability
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class HaBaseHighAvailabilityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for HaBaseHighAvailability
        //private HaBaseHighAvailability instance;

        public HaBaseHighAvailabilityTests()
        {
            // TODO uncomment below to create an instance of HaBaseHighAvailability
            //instance = new HaBaseHighAvailability();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HaBaseHighAvailability
        /// </summary>
        [Fact]
        public void HaBaseHighAvailabilityInstanceTest()
        {
            // TODO uncomment below to test "IsType" HaBaseHighAvailability
            //Assert.IsType<HaBaseHighAvailability>(instance);
        }

        /// <summary>
        /// Test the property 'HeartbeatInterval'
        /// </summary>
        [Fact]
        public void HeartbeatIntervalTest()
        {
            // TODO unit test for the property 'HeartbeatInterval'
        }

        /// <summary>
        /// Test the property 'FailoverTriggerLevel'
        /// </summary>
        [Fact]
        public void FailoverTriggerLevelTest()
        {
            // TODO unit test for the property 'FailoverTriggerLevel'
        }

        /// <summary>
        /// Test the property 'Probe'
        /// </summary>
        [Fact]
        public void ProbeTest()
        {
            // TODO unit test for the property 'Probe'
        }

        /// <summary>
        /// Test the property 'ElectionDelayTime'
        /// </summary>
        [Fact]
        public void ElectionDelayTimeTest()
        {
            // TODO unit test for the property 'ElectionDelayTime'
        }

        /// <summary>
        /// Test the property 'RouteHoldDownTime'
        /// </summary>
        [Fact]
        public void RouteHoldDownTimeTest()
        {
            // TODO unit test for the property 'RouteHoldDownTime'
        }

        /// <summary>
        /// Test the property 'SdwanHoldDownTime'
        /// </summary>
        [Fact]
        public void SdwanHoldDownTimeTest()
        {
            // TODO unit test for the property 'SdwanHoldDownTime'
        }

        /// <summary>
        /// Test the property 'IncludeCertificatesKeys'
        /// </summary>
        [Fact]
        public void IncludeCertificatesKeysTest()
        {
            // TODO unit test for the property 'IncludeCertificatesKeys'
        }

        /// <summary>
        /// Test the property 'L3Mode'
        /// </summary>
        [Fact]
        public void L3ModeTest()
        {
            // TODO unit test for the property 'L3Mode'
        }

        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }
    }
}