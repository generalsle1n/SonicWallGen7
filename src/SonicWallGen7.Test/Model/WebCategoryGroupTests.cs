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
    ///  Class for testing WebCategoryGroup
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WebCategoryGroupTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WebCategoryGroup
        //private WebCategoryGroup instance;

        public WebCategoryGroupTests()
        {
            // TODO uncomment below to create an instance of WebCategoryGroup
            //instance = new WebCategoryGroup();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebCategoryGroup
        /// </summary>
        [Fact]
        public void WebCategoryGroupInstanceTest()
        {
            // TODO uncomment below to test "IsType" WebCategoryGroup
            //Assert.IsType<WebCategoryGroup>(instance);
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
        /// Test the property 'Uuid'
        /// </summary>
        [Fact]
        public void UuidTest()
        {
            // TODO unit test for the property 'Uuid'
        }

        /// <summary>
        /// Test the property 'WebCategoryObject'
        /// </summary>
        [Fact]
        public void WebCategoryObjectTest()
        {
            // TODO unit test for the property 'WebCategoryObject'
        }

        /// <summary>
        /// Test the property 'VarWebCategoryGroup'
        /// </summary>
        [Fact]
        public void VarWebCategoryGroupTest()
        {
            // TODO unit test for the property 'VarWebCategoryGroup'
        }
    }
}
