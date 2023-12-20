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
    ///  Class for testing ShowStatusUsersQuotaListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusUsersQuotaListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusUsersQuotaListInner
        //private ShowStatusUsersQuotaListInner instance;

        public ShowStatusUsersQuotaListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusUsersQuotaListInner
            //instance = new ShowStatusUsersQuotaListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusUsersQuotaListInner
        /// </summary>
        [Fact]
        public void ShowStatusUsersQuotaListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusUsersQuotaListInner
            //Assert.IsType<ShowStatusUsersQuotaListInner>(instance);
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
        /// Test the property 'Domain'
        /// </summary>
        [Fact]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
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
        /// Test the property 'QuotaType'
        /// </summary>
        [Fact]
        public void QuotaTypeTest()
        {
            // TODO unit test for the property 'QuotaType'
        }

        /// <summary>
        /// Test the property 'MaxSession'
        /// </summary>
        [Fact]
        public void MaxSessionTest()
        {
            // TODO unit test for the property 'MaxSession'
        }

        /// <summary>
        /// Test the property 'MaxRx'
        /// </summary>
        [Fact]
        public void MaxRxTest()
        {
            // TODO unit test for the property 'MaxRx'
        }

        /// <summary>
        /// Test the property 'MaxTx'
        /// </summary>
        [Fact]
        public void MaxTxTest()
        {
            // TODO unit test for the property 'MaxTx'
        }

        /// <summary>
        /// Test the property 'RemSession'
        /// </summary>
        [Fact]
        public void RemSessionTest()
        {
            // TODO unit test for the property 'RemSession'
        }

        /// <summary>
        /// Test the property 'RemRx'
        /// </summary>
        [Fact]
        public void RemRxTest()
        {
            // TODO unit test for the property 'RemRx'
        }

        /// <summary>
        /// Test the property 'RemTx'
        /// </summary>
        [Fact]
        public void RemTxTest()
        {
            // TODO unit test for the property 'RemTx'
        }
    }
}