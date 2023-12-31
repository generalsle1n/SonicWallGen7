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
    ///  Class for testing AppflowSfrMailingTestEmailAppflowSfrMailing
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AppflowSfrMailingTestEmailAppflowSfrMailingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AppflowSfrMailingTestEmailAppflowSfrMailing
        //private AppflowSfrMailingTestEmailAppflowSfrMailing instance;

        public AppflowSfrMailingTestEmailAppflowSfrMailingTests()
        {
            // TODO uncomment below to create an instance of AppflowSfrMailingTestEmailAppflowSfrMailing
            //instance = new AppflowSfrMailingTestEmailAppflowSfrMailing();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppflowSfrMailingTestEmailAppflowSfrMailing
        /// </summary>
        [Fact]
        public void AppflowSfrMailingTestEmailAppflowSfrMailingInstanceTest()
        {
            // TODO uncomment below to test "IsType" AppflowSfrMailingTestEmailAppflowSfrMailing
            //Assert.IsType<AppflowSfrMailingTestEmailAppflowSfrMailing>(instance);
        }

        /// <summary>
        /// Test the property 'TestEmail'
        /// </summary>
        [Fact]
        public void TestEmailTest()
        {
            // TODO unit test for the property 'TestEmail'
        }
    }
}
