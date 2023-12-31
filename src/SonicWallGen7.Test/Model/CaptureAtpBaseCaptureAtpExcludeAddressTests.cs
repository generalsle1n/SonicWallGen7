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
    ///  Class for testing CaptureAtpBaseCaptureAtpExcludeAddress
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CaptureAtpBaseCaptureAtpExcludeAddressTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CaptureAtpBaseCaptureAtpExcludeAddress
        //private CaptureAtpBaseCaptureAtpExcludeAddress instance;

        public CaptureAtpBaseCaptureAtpExcludeAddressTests()
        {
            // TODO uncomment below to create an instance of CaptureAtpBaseCaptureAtpExcludeAddress
            //instance = new CaptureAtpBaseCaptureAtpExcludeAddress();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CaptureAtpBaseCaptureAtpExcludeAddress
        /// </summary>
        [Fact]
        public void CaptureAtpBaseCaptureAtpExcludeAddressInstanceTest()
        {
            // TODO uncomment below to test "IsType" CaptureAtpBaseCaptureAtpExcludeAddress
            //Assert.IsType<CaptureAtpBaseCaptureAtpExcludeAddress>(instance);
        }

        /// <summary>
        /// Test the property 'ForCaptureAtp'
        /// </summary>
        [Fact]
        public void ForCaptureAtpTest()
        {
            // TODO unit test for the property 'ForCaptureAtp'
        }

        /// <summary>
        /// Test the property 'ForBlockUntilVerdict'
        /// </summary>
        [Fact]
        public void ForBlockUntilVerdictTest()
        {
            // TODO unit test for the property 'ForBlockUntilVerdict'
        }
    }
}
