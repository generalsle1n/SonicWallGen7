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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using SonicWallGen7.Client;
using SonicWallGen7.Api;
// uncomment below to import models
//using SonicWallGen7.Model;

namespace SonicWallGen7.Test.Api
{
    /// <summary>
    ///  Class for testing LogResetEventCountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LogResetEventCountApiTests : IDisposable
    {
        private LogResetEventCountApi instance;

        public LogResetEventCountApiTests()
        {
            instance = new LogResetEventCountApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogResetEventCountApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LogResetEventCountApi
            //Assert.IsType<LogResetEventCountApi>(instance);
        }

        /// <summary>
        /// Test LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPost
        /// </summary>
        [Fact]
        public void LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string CATNAME = null;
            //string GRPNAME = null;
            //string EVENTNAME = null;
            //Object? body = null;
            //var response = instance.LogResetEventCountCategoryCATNAMEGroupGRPNAMEEventEVENTNAMEPost(CATNAME, GRPNAME, EVENTNAME, body);
            //Assert.IsType<ApiStatus>(response);
        }

        /// <summary>
        /// Test LogResetEventCountCategoryCATNAMEPost
        /// </summary>
        [Fact]
        public void LogResetEventCountCategoryCATNAMEPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string CATNAME = null;
            //Object? body = null;
            //var response = instance.LogResetEventCountCategoryCATNAMEPost(CATNAME, body);
            //Assert.IsType<ApiStatus>(response);
        }
    }
}
