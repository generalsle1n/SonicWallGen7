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
    ///  Class for testing ZoneGuestServicesExternalAuthAuthPagesWebServer1
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ZoneGuestServicesExternalAuthAuthPagesWebServer1Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ZoneGuestServicesExternalAuthAuthPagesWebServer1
        //private ZoneGuestServicesExternalAuthAuthPagesWebServer1 instance;

        public ZoneGuestServicesExternalAuthAuthPagesWebServer1Tests()
        {
            // TODO uncomment below to create an instance of ZoneGuestServicesExternalAuthAuthPagesWebServer1
            //instance = new ZoneGuestServicesExternalAuthAuthPagesWebServer1();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ZoneGuestServicesExternalAuthAuthPagesWebServer1
        /// </summary>
        [Fact]
        public void ZoneGuestServicesExternalAuthAuthPagesWebServer1InstanceTest()
        {
            // TODO uncomment below to test "IsType" ZoneGuestServicesExternalAuthAuthPagesWebServer1
            //Assert.IsType<ZoneGuestServicesExternalAuthAuthPagesWebServer1>(instance);
        }

        /// <summary>
        /// Test the property 'Login'
        /// </summary>
        [Fact]
        public void LoginTest()
        {
            // TODO unit test for the property 'Login'
        }

        /// <summary>
        /// Test the property 'Expiration'
        /// </summary>
        [Fact]
        public void ExpirationTest()
        {
            // TODO unit test for the property 'Expiration'
        }

        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            // TODO unit test for the property 'Timeout'
        }

        /// <summary>
        /// Test the property 'MaxSessions'
        /// </summary>
        [Fact]
        public void MaxSessionsTest()
        {
            // TODO unit test for the property 'MaxSessions'
        }

        /// <summary>
        /// Test the property 'TrafficExceeded'
        /// </summary>
        [Fact]
        public void TrafficExceededTest()
        {
            // TODO unit test for the property 'TrafficExceeded'
        }
    }
}
