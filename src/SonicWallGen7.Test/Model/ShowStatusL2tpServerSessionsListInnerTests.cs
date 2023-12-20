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
    ///  Class for testing ShowStatusL2tpServerSessionsListInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusL2tpServerSessionsListInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusL2tpServerSessionsListInner
        //private ShowStatusL2tpServerSessionsListInner instance;

        public ShowStatusL2tpServerSessionsListInnerTests()
        {
            // TODO uncomment below to create an instance of ShowStatusL2tpServerSessionsListInner
            //instance = new ShowStatusL2tpServerSessionsListInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusL2tpServerSessionsListInner
        /// </summary>
        [Fact]
        public void ShowStatusL2tpServerSessionsListInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusL2tpServerSessionsListInner
            //Assert.IsType<ShowStatusL2tpServerSessionsListInner>(instance);
        }

        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }

        /// <summary>
        /// Test the property 'PppIp'
        /// </summary>
        [Fact]
        public void PppIpTest()
        {
            // TODO unit test for the property 'PppIp'
        }

        /// <summary>
        /// Test the property 'Zone'
        /// </summary>
        [Fact]
        public void ZoneTest()
        {
            // TODO unit test for the property 'Zone'
        }

        /// <summary>
        /// Test the property 'VarInterface'
        /// </summary>
        [Fact]
        public void VarInterfaceTest()
        {
            // TODO unit test for the property 'VarInterface'
        }

        /// <summary>
        /// Test the property 'Authentication'
        /// </summary>
        [Fact]
        public void AuthenticationTest()
        {
            // TODO unit test for the property 'Authentication'
        }

        /// <summary>
        /// Test the property 'HostName'
        /// </summary>
        [Fact]
        public void HostNameTest()
        {
            // TODO unit test for the property 'HostName'
        }
    }
}
