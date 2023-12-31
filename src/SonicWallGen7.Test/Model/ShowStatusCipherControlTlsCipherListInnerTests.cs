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
    ///  Class for testing ShowStatusCipherControlTlsCipherListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusCipherControlTlsCipherListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusCipherControlTlsCipherListInner
        //private ShowStatusCipherControlTlsCipherListInner instance;

        public ShowStatusCipherControlTlsCipherListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusCipherControlTlsCipherListInner
            //instance = new ShowStatusCipherControlTlsCipherListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusCipherControlTlsCipherListInner
        /// </summary>
        [Fact]
        public void ShowStatusCipherControlTlsCipherListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusCipherControlTlsCipherListInner
            //Assert.IsType<ShowStatusCipherControlTlsCipherListInner>(instance);
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
        /// Test the property 'Strength'
        /// </summary>
        [Fact]
        public void StrengthTest()
        {
            // TODO unit test for the property 'Strength'
        }

        /// <summary>
        /// Test the property 'Block'
        /// </summary>
        [Fact]
        public void BlockTest()
        {
            // TODO unit test for the property 'Block'
        }

        /// <summary>
        /// Test the property 'IsCBC'
        /// </summary>
        [Fact]
        public void IsCBCTest()
        {
            // TODO unit test for the property 'IsCBC'
        }

        /// <summary>
        /// Test the property 'Tls10'
        /// </summary>
        [Fact]
        public void Tls10Test()
        {
            // TODO unit test for the property 'Tls10'
        }

        /// <summary>
        /// Test the property 'Tls11'
        /// </summary>
        [Fact]
        public void Tls11Test()
        {
            // TODO unit test for the property 'Tls11'
        }

        /// <summary>
        /// Test the property 'Tls12'
        /// </summary>
        [Fact]
        public void Tls12Test()
        {
            // TODO unit test for the property 'Tls12'
        }

        /// <summary>
        /// Test the property 'Tls13'
        /// </summary>
        [Fact]
        public void Tls13Test()
        {
            // TODO unit test for the property 'Tls13'
        }

        /// <summary>
        /// Test the property 'DpiSsl'
        /// </summary>
        [Fact]
        public void DpiSslTest()
        {
            // TODO unit test for the property 'DpiSsl'
        }

        /// <summary>
        /// Test the property 'HttpsMgmt'
        /// </summary>
        [Fact]
        public void HttpsMgmtTest()
        {
            // TODO unit test for the property 'HttpsMgmt'
        }

        /// <summary>
        /// Test the property 'SslControl'
        /// </summary>
        [Fact]
        public void SslControlTest()
        {
            // TODO unit test for the property 'SslControl'
        }
    }
}
