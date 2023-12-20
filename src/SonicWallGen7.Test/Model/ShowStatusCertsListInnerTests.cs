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
    ///  Class for testing ShowStatusCertsListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusCertsListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusCertsListInner
        //private ShowStatusCertsListInner instance;

        public ShowStatusCertsListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusCertsListInner
            //instance = new ShowStatusCertsListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusCertsListInner
        /// </summary>
        [Fact]
        public void ShowStatusCertsListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusCertsListInner
            //Assert.IsType<ShowStatusCertsListInner>(instance);
        }

        /// <summary>
        /// Test the property 'Certificate'
        /// </summary>
        [Fact]
        public void CertificateTest()
        {
            // TODO unit test for the property 'Certificate'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'Validated'
        /// </summary>
        [Fact]
        public void ValidatedTest()
        {
            // TODO unit test for the property 'Validated'
        }

        /// <summary>
        /// Test the property 'ExpiresOn'
        /// </summary>
        [Fact]
        public void ExpiresOnTest()
        {
            // TODO unit test for the property 'ExpiresOn'
        }

        /// <summary>
        /// Test the property 'ExpiredOn'
        /// </summary>
        [Fact]
        public void ExpiredOnTest()
        {
            // TODO unit test for the property 'ExpiredOn'
        }
    }
}
