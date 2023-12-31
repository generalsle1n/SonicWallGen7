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
    ///  Class for testing ShowStatusVoipCallListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusVoipCallListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusVoipCallListInner
        //private ShowStatusVoipCallListInner instance;

        public ShowStatusVoipCallListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusVoipCallListInner
            //instance = new ShowStatusVoipCallListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusVoipCallListInner
        /// </summary>
        [Fact]
        public void ShowStatusVoipCallListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusVoipCallListInner
            //Assert.IsType<ShowStatusVoipCallListInner>(instance);
        }

        /// <summary>
        /// Test the property 'CallerIp'
        /// </summary>
        [Fact]
        public void CallerIpTest()
        {
            // TODO unit test for the property 'CallerIp'
        }

        /// <summary>
        /// Test the property 'CallerId'
        /// </summary>
        [Fact]
        public void CallerIdTest()
        {
            // TODO unit test for the property 'CallerId'
        }

        /// <summary>
        /// Test the property 'CalledIp'
        /// </summary>
        [Fact]
        public void CalledIpTest()
        {
            // TODO unit test for the property 'CalledIp'
        }

        /// <summary>
        /// Test the property 'CalledId'
        /// </summary>
        [Fact]
        public void CalledIdTest()
        {
            // TODO unit test for the property 'CalledId'
        }

        /// <summary>
        /// Test the property 'Protocol'
        /// </summary>
        [Fact]
        public void ProtocolTest()
        {
            // TODO unit test for the property 'Protocol'
        }

        /// <summary>
        /// Test the property 'Bandwith'
        /// </summary>
        [Fact]
        public void BandwithTest()
        {
            // TODO unit test for the property 'Bandwith'
        }

        /// <summary>
        /// Test the property 'TimeStarted'
        /// </summary>
        [Fact]
        public void TimeStartedTest()
        {
            // TODO unit test for the property 'TimeStarted'
        }
    }
}
