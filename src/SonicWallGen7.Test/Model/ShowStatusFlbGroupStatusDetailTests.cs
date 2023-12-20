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
    ///  Class for testing ShowStatusFlbGroupStatusDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShowStatusFlbGroupStatusDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShowStatusFlbGroupStatusDetail
        //private ShowStatusFlbGroupStatusDetail instance;

        public ShowStatusFlbGroupStatusDetailTests()
        {
            // TODO uncomment below to create an instance of ShowStatusFlbGroupStatusDetail
            //instance = new ShowStatusFlbGroupStatusDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShowStatusFlbGroupStatusDetail
        /// </summary>
        [Fact]
        public void ShowStatusFlbGroupStatusDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShowStatusFlbGroupStatusDetail
            //Assert.IsType<ShowStatusFlbGroupStatusDetail>(instance);
        }

        /// <summary>
        /// Test the property 'GroupName'
        /// </summary>
        [Fact]
        public void GroupNameTest()
        {
            // TODO unit test for the property 'GroupName'
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
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'TotalMembers'
        /// </summary>
        [Fact]
        public void TotalMembersTest()
        {
            // TODO unit test for the property 'TotalMembers'
        }

        /// <summary>
        /// Test the property 'PrimaryMember'
        /// </summary>
        [Fact]
        public void PrimaryMemberTest()
        {
            // TODO unit test for the property 'PrimaryMember'
        }

        /// <summary>
        /// Test the property 'ActiveMember'
        /// </summary>
        [Fact]
        public void ActiveMemberTest()
        {
            // TODO unit test for the property 'ActiveMember'
        }

        /// <summary>
        /// Test the property 'LoadBalancingMember'
        /// </summary>
        [Fact]
        public void LoadBalancingMemberTest()
        {
            // TODO unit test for the property 'LoadBalancingMember'
        }

        /// <summary>
        /// Test the property 'FinalBackUp'
        /// </summary>
        [Fact]
        public void FinalBackUpTest()
        {
            // TODO unit test for the property 'FinalBackUp'
        }

        /// <summary>
        /// Test the property 'GlobalProbing'
        /// </summary>
        [Fact]
        public void GlobalProbingTest()
        {
            // TODO unit test for the property 'GlobalProbing'
        }
    }
}
