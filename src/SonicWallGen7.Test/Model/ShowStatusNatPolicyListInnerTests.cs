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
    ///  Class for testing ShowStatusNatPolicyListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusNatPolicyListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusNatPolicyListInner
        //private ShowStatusNatPolicyListInner instance;

        public ShowStatusNatPolicyListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusNatPolicyListInner
            //instance = new ShowStatusNatPolicyListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusNatPolicyListInner
        /// </summary>
        [Fact]
        public void ShowStatusNatPolicyListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusNatPolicyListInner
            //Assert.IsType<ShowStatusNatPolicyListInner>(instance);
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
        /// Test the property 'InboundInterface'
        /// </summary>
        [Fact]
        public void InboundInterfaceTest()
        {
            // TODO unit test for the property 'InboundInterface'
        }

        /// <summary>
        /// Test the property 'OutboundInterface'
        /// </summary>
        [Fact]
        public void OutboundInterfaceTest()
        {
            // TODO unit test for the property 'OutboundInterface'
        }

        /// <summary>
        /// Test the property 'OriginalSource'
        /// </summary>
        [Fact]
        public void OriginalSourceTest()
        {
            // TODO unit test for the property 'OriginalSource'
        }

        /// <summary>
        /// Test the property 'TranslatedSource'
        /// </summary>
        [Fact]
        public void TranslatedSourceTest()
        {
            // TODO unit test for the property 'TranslatedSource'
        }

        /// <summary>
        /// Test the property 'OriginalDestination'
        /// </summary>
        [Fact]
        public void OriginalDestinationTest()
        {
            // TODO unit test for the property 'OriginalDestination'
        }

        /// <summary>
        /// Test the property 'TranslatedDestination'
        /// </summary>
        [Fact]
        public void TranslatedDestinationTest()
        {
            // TODO unit test for the property 'TranslatedDestination'
        }

        /// <summary>
        /// Test the property 'OriginalService'
        /// </summary>
        [Fact]
        public void OriginalServiceTest()
        {
            // TODO unit test for the property 'OriginalService'
        }

        /// <summary>
        /// Test the property 'TranslatedService'
        /// </summary>
        [Fact]
        public void TranslatedServiceTest()
        {
            // TODO unit test for the property 'TranslatedService'
        }

        /// <summary>
        /// Test the property 'UsageCount'
        /// </summary>
        [Fact]
        public void UsageCountTest()
        {
            // TODO unit test for the property 'UsageCount'
        }

        /// <summary>
        /// Test the property 'RxBytes'
        /// </summary>
        [Fact]
        public void RxBytesTest()
        {
            // TODO unit test for the property 'RxBytes'
        }

        /// <summary>
        /// Test the property 'RxPackets'
        /// </summary>
        [Fact]
        public void RxPacketsTest()
        {
            // TODO unit test for the property 'RxPackets'
        }

        /// <summary>
        /// Test the property 'TxBytes'
        /// </summary>
        [Fact]
        public void TxBytesTest()
        {
            // TODO unit test for the property 'TxBytes'
        }

        /// <summary>
        /// Test the property 'TxPackets'
        /// </summary>
        [Fact]
        public void TxPacketsTest()
        {
            // TODO unit test for the property 'TxPackets'
        }
    }
}
