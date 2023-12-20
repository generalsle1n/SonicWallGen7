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
    ///  Class for testing CaptureAtpBaseCaptureAtp
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CaptureAtpBaseCaptureAtpTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CaptureAtpBaseCaptureAtp
        //private CaptureAtpBaseCaptureAtp instance;

        public CaptureAtpBaseCaptureAtpTests()
        {
            // TODO uncomment below to create an instance of CaptureAtpBaseCaptureAtp
            //instance = new CaptureAtpBaseCaptureAtp();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CaptureAtpBaseCaptureAtp
        /// </summary>
        [Fact]
        public void CaptureAtpBaseCaptureAtpInstanceTest()
        {
            // TODO uncomment below to test "IsType" CaptureAtpBaseCaptureAtp
            //Assert.IsType<CaptureAtpBaseCaptureAtp>(instance);
        }

        /// <summary>
        /// Test the property 'Enable'
        /// </summary>
        [Fact]
        public void EnableTest()
        {
            // TODO unit test for the property 'Enable'
        }

        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }

        /// <summary>
        /// Test the property 'LocalNameOrIp'
        /// </summary>
        [Fact]
        public void LocalNameOrIpTest()
        {
            // TODO unit test for the property 'LocalNameOrIp'
        }

        /// <summary>
        /// Test the property 'FileType'
        /// </summary>
        [Fact]
        public void FileTypeTest()
        {
            // TODO unit test for the property 'FileType'
        }

        /// <summary>
        /// Test the property 'FileSize'
        /// </summary>
        [Fact]
        public void FileSizeTest()
        {
            // TODO unit test for the property 'FileSize'
        }

        /// <summary>
        /// Test the property 'AwaitVerdict'
        /// </summary>
        [Fact]
        public void AwaitVerdictTest()
        {
            // TODO unit test for the property 'AwaitVerdict'
        }

        /// <summary>
        /// Test the property 'Exclude'
        /// </summary>
        [Fact]
        public void ExcludeTest()
        {
            // TODO unit test for the property 'Exclude'
        }
    }
}
